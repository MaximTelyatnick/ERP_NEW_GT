using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.MTS
{
    public partial class MtsSpecificationOldDetailsFm : DevExpress.XtraEditors.XtraForm
    {
        private IMtsSpecificationsService mtsService;

        private BindingSource specificationBS = new BindingSource();
        private BindingSource specificationListBS = new BindingSource();

        private List<MTSSpecificationsDTO> specificationList = new List<MTSSpecificationsDTO>();
        private List<MTSSpecificationsDTO> deleteSpecificationList = new List<MTSSpecificationsDTO>();

        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return specificationBS.Current as ObjectBase; }
            set
            {
                specificationBS.DataSource = value;
                value.BeginEdit();
            }
        }


        public MtsSpecificationOldDetailsFm(MTSSpecificationsDTO model, Utils.Operation operation)
        {
            InitializeComponent();

            mtsService = Program.kernel.Get<IMtsSpecificationsService>();

            //this.model = model;
            this.operation = operation;

            specificationBS.DataSource = Item = model;

            specificationListBS.DataSource = specificationList;
            specificationGrid.DataSource = specificationListBS;

            nameSpecificationEdit.DataBindings.Add("EditValue", specificationBS, "NAME", true, DataSourceUpdateMode.OnPropertyChanged);
            drawingEdit.DataBindings.Add("EditValue", specificationBS, "DRAWING", true, DataSourceUpdateMode.OnPropertyChanged);
            //quantityEdit.DataBindings.Add("EditValue", specificationBS, "QUANTITY", true, DataSourceUpdateMode.OnPropertyChanged);
            weightEdit.DataBindings.Add("EditValue", specificationBS, "WEIGHT", true, DataSourceUpdateMode.OnPropertyChanged);
            dateEdit.DataBindings.Add("EditValue", specificationBS, "CREATION_DATE", true, DataSourceUpdateMode.OnPropertyChanged);


            ((MTSSpecificationsDTO)Item).QUANTITY = 1;
            ((MTSSpecificationsDTO)Item).CREATION_DATE = DateTime.Now;
            ((MTSSpecificationsDTO)Item).AUTHORIZATION_USERS_ID = 1;

        }

        private void addSpecDetailBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (MtsSpecificationOldSelectFm mtsSpecificationOldSelectFm = new MtsSpecificationOldSelectFm())
            {
                if (mtsSpecificationOldSelectFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var returnList = mtsSpecificationOldSelectFm.Return();

                    specificationGridView.BeginDataUpdate();

                    //customersOrderList.AddRange(returnList.Select(s => { s.Selected = false; return s; }));

                    //var saveItems = returnList.Select(s => new BusinessTripsOrderCustDTO()
                    //{
                    //    ID = 0,
                    //    BusinessTripsId = model.ID,
                    //    CustomerOrderId = s.Id,
                    //    ContractorName = s.ContractorName,
                    //    OrderDate = s.OrderDate,
                    //    OrderNumber = s.OrderNumber,
                    //    Selected = false,
                    //    UserId = userTasksDTO.UserId
                    //});


                    specificationList.AddRange(returnList);

                    //customersOrderList.AddRange(returnList.SelectMany(s => new List<BusinessTripsOrderCustDTO>()
                    //    {

                    //    }));

                    specificationListBS.DataSource = specificationList;
                    specificationGrid.DataSource = specificationListBS;

                    specificationGridView.EndDataUpdate();
                }
            }
        }

        public MTSSpecificationsDTO Return()
        {
            return (MTSSpecificationsDTO)Item;
        }

        private void deleteSpecDetailBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            specificationGridView.PostEditor();
            specificationGridView.BeginDataUpdate();

            specificationList.RemoveAll(s => s.Selected);
            specificationGrid.DataSource = specificationBS;

            specificationGridView.EndDataUpdate();
        }

        private bool FindDublicate(MTSSpecificationsDTO model)
        {
            mtsService = Program.kernel.Get<IMtsSpecificationsService>();
            return mtsService.GetAllSpecificationOld().Any(s => s.NAME== model.NAME  && s.ID != model.ID);
        }

        private bool SaveSpecificationsDetails()
        {
            this.Item.EndEdit();

            if (FindDublicate((MTSSpecificationsDTO)this.Item))
            {
                MessageBox.Show("Специфікація з такою назвою вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (specificationListBS.Count == 0)
            {
                MessageBox.Show("Необхідно вибрати специфікації для створення зведеної специфікації!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (specificationList.Any(bdsm => bdsm.QUANTITY == 0))
            {
                MessageBox.Show("Не коректно вказана кількість в одній з специфікацій", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            try
            {

                ((MTSSpecificationsDTO)Item).COMPILATION_NAMES = string.Join(";", specificationList.Select(slt => slt.NAME));
                ((MTSSpecificationsDTO)Item).COMPILATION_NAMES += ";";
                ((MTSSpecificationsDTO)Item).COMPILATION_DRAWINGS = string.Join(";", specificationList.Select(slt => slt.DRAWING));
                ((MTSSpecificationsDTO)Item).COMPILATION_DRAWINGS += ";";
                ((MTSSpecificationsDTO)Item).COMPILATION_QUANTITIES = string.Join(";", specificationList.Select(slt => slt.QUANTITY));
                ((MTSSpecificationsDTO)Item).COMPILATION_QUANTITIES += ";";

                ((MTSSpecificationsDTO)Item).ID = mtsService.MTSSpecificationCreate((MTSSpecificationsDTO)Item);

                foreach (var item in specificationList)
                {
                   var detailsSpecific = mtsService.GetAllDetailsSpecificShort(((MTSSpecificationsDTO)item).ID);

                    if (detailsSpecific != null)
                    {
                        List<MTSDetailsDTO> mtsDetailsList = new List<MTSDetailsDTO>(); 

                        foreach (var itemDetailSpecific in detailsSpecific)
                        {
                            mtsDetailsList.Add(itemDetailSpecific);
                            mtsDetailsList.Last().SPECIFICATIONS_ID = ((MTSSpecificationsDTO)Item).ID;
                            mtsDetailsList.Last().QUANTITY = mtsDetailsList.Last().QUANTITY * item.QUANTITY;
                            mtsDetailsList.Last().TIME_OF_ADD = DateTime.Now;
                        }
                        mtsService.MTSDetailsCreateRange(mtsDetailsList);
                    }

                    var detailsSpecificBuy = mtsService.GetBuysDetalSpecificShort(((MTSSpecificationsDTO)item).ID);

                    if (detailsSpecificBuy != null)
                    {
                        List<MTSPurchasedProductsDTO> mtsPurchasedList = new List<MTSPurchasedProductsDTO>();

                        foreach (var itemDetailSpecificBuy in detailsSpecificBuy)
                        {
                            mtsPurchasedList.Add(itemDetailSpecificBuy);
                            mtsPurchasedList.Last().SPECIFICATIONS_ID = ((MTSSpecificationsDTO)Item).ID;
                            mtsPurchasedList.Last().QUANTITY = mtsPurchasedList.Last().QUANTITY * item.QUANTITY;
                            mtsPurchasedList.Last().TIME_OF_ADD = DateTime.Now;
                        }
                        mtsService.MTSPurchasedProductsCreateRange(mtsPurchasedList);
                    }

                    var detailsSpecificMaterials = mtsService.GetMaterialsSpecificShort(((MTSSpecificationsDTO)item).ID);

                    if (detailsSpecificMaterials != null)
                    {
                        List<MTSMaterialsDTO> mtsMaterialsList = new List<MTSMaterialsDTO>();

                        foreach (var itemDetailsSpecificMaterials in detailsSpecificMaterials)
                        {
                            mtsMaterialsList.Add(itemDetailsSpecificMaterials);
                            mtsMaterialsList.Last().SPECIFICATIONS_ID = ((MTSSpecificationsDTO)Item).ID;
                            mtsMaterialsList.Last().QUANTITY = mtsMaterialsList.Last().QUANTITY * item.QUANTITY;
                            mtsMaterialsList.Last().TIME_OF_ADD = DateTime.Now;
                        }
                        mtsService.MTSMaterialCreateRange(mtsMaterialsList);
                    }
                }

                return true;
                //if (deleteDecreeDetailList.Count > 0)
                //{
                //    businessTripsService = Program.kernel.Get<IBusinessTripsService>();
                //    businessTripsService.BusinessTripDecreeDetailRemoveRange(deleteDecreeDetailList);
                //}

                //if (_operation == Utils.Operation.Add)
                //{
                //    businessTripsService = Program.kernel.Get<IBusinessTripsService>();

                //    switch (((BusinessTripsDecreeDTO)Item).DecreeType)
                //    {
                //        case 1:
                //            ((BusinessTripsDecreeDTO)Item).ID = businessTripsService.BusinessTripDecreeCreate((BusinessTripsDecreeDTO)Item);
                //            var source = (from p in tripList
                //                          select new BusinessTripsDecreeDetailsDTO()
                //                          {
                //                              BusinessTripDetailId = p.ID,
                //                              DecreeId = ((BusinessTripsDecreeDTO)Item).ID
                //                          }).ToList();
                //            businessTripsService.BusinessTripDecreeDetailCreateRange(source);

                //            break;

                //        case 2:
                //            if (businessTripsGridView.SelectedRowsCount > 0)
                //            {
                //                var updateList = tripList.Where(t => t.Selection).ToList();

                //                foreach (var item in updateList)
                //                {
                //                    BusinessTripsDTO newModel = new BusinessTripsDTO()
                //                    {
                //                        ID = ((BusinessTripsJournalDTO)item).BusinessTripsID,
                //                        Doc_Number = ((BusinessTripsJournalDTO)item).Doc_Number,
                //                        Doc_Date = ((BusinessTripsJournalDTO)item).Doc_Date,
                //                        DepartureID = ((BusinessTripsJournalDTO)item).DepartureID,
                //                        EmployeesID = ((BusinessTripsJournalDTO)item).EmployeesID,
                //                        CityID = ((BusinessTripsJournalDTO)item).CityID,
                //                        ContractorsID = ((BusinessTripsJournalDTO)item).ContractorsID,
                //                        AgreementsID = ((BusinessTripsJournalDTO)item).AgreementsID,
                //                        PurposeID = ((BusinessTripsJournalDTO)item).PurposeID,
                //                        StartDate = ((BusinessTripsJournalDTO)item).StartDate,
                //                        EndDate = ((BusinessTripsJournalDTO)item).EndDate,
                //                        AmountDays = ((BusinessTripsJournalDTO)item).AmountDays
                //                    };

                //                    businessTripsService.BusinessTripUpdate(newModel);

                //                    ((BusinessTripsDecreeDTO)Item).ID = businessTripsService.BusinessTripDecreeCreate((BusinessTripsDecreeDTO)Item);

                //                    businessTripsService.BusinessTripDecreeDetailCreate(new BusinessTripsDecreeDetailsDTO()
                //                    {
                //                        Id = item.DecreeDetailId ?? 0,
                //                        BusinessTripDetailId = item.ID,
                //                        DecreeId = ((BusinessTripsDecreeDTO)Item).ID
                //                    });
                //                }

                //            }
                //            break;

                //        case 3:
                //            ((BusinessTripsDecreeDTO)Item).ID = businessTripsService.BusinessTripDecreeCreate((BusinessTripsDecreeDTO)Item);

                //            var createList = tripList.Where(t => t.Selection).Select(s => new BusinessTripsDecreeDetailsDTO()
                //            {
                //                Id = s.DecreeDetailId ?? 0,
                //                BusinessTripDetailId = s.ID,
                //                DecreeId = ((BusinessTripsDecreeDTO)Item).ID
                //            }).ToList();


                //            businessTripsService.BusinessTripDecreeDetailCreateRange(createList);
                //            break;

                //        default:
                //            MessageBox.Show("Невідома команда!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            break;
                //    }
                //    return true;
                //}
                //else
                //{
                //    businessTripsService.BusinessTripDecreeUpdate((BusinessTripsDecreeDTO)Item);

                //    var source = (from p in tripList
                //                  select new BusinessTripsDecreeDetailsDTO()
                //                  {
                //                      Id = p.DecreeDetailId ?? 0,
                //                      BusinessTripDetailId = p.ID,
                //                      DecreeId = ((BusinessTripsDecreeDTO)Item).ID
                //                  }
                //        ).ToList();

                //    foreach (var item in source)
                //    {
                //        if (item.Id == 0)
                //            businessTripsService.BusinessTripDecreeDetailCreate(item);
                //        else
                //            businessTripsService.BusinessTripDecreeDetailUpdate(item);
                //    }
                //    return true;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Створити зведену специфікацію?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveSpecificationsDetails())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                { MessageBox.Show("" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}