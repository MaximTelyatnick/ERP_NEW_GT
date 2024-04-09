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
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using Ninject;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraBars;
using ERP_NEW.GUI.StoreHouse;

namespace ERP_NEW.GUI.Production
{
    public partial class StoreHouseProjectFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private ICustomerOrdersService customerOrdersService;
        private List<StoreHouseReceiptProjectDTO> stoteHouseReceiptProject = new List<StoreHouseReceiptProjectDTO>();
        private decimal quantityCurrent = 0;
        private string lastNomenclature;
        //private List<InvoiceRequirementOrdersDTO> invoiceRequiremtOrdersList = new List<InvoiceRequirementOrdersDTO>();
        //private List<InvoiceRequirementMaterialsInfoDTO> invoiceRequirementMaterialList = new List<InvoiceRequirementMaterialsInfoDTO>(); 

        private BindingSource storeHouseReceiptProjectBS = new BindingSource();
        private BindingSource customerOrdersBS = new BindingSource();
        private BindingSource expendituresBS = new BindingSource();
        
        //private BindingSource invoiceRequirementMaterialsBS = new BindingSource();
        private UserTasksDTO userTasksDTO;

        public StoreHouseProjectFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            this.userTasksDTO = userTasksDTO;

            DateTime firstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime lastDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            repositoryItemGridLookUpEdit.PopupFilterMode = PopupFilterMode.Contains; 

            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();

            repositoryItemGridLookUpEdit.DataSource = customerOrdersService.GetCustomerOrdersFull().OrderByDescending(sort => sort.OrderDate).ToList();
            //repositoryItemSearchLookUpEdit.DataSource = employeesService.GetEmployeesWorkingNonPhoto();
            repositoryItemGridLookUpEdit.ValueMember = "Id";
            repositoryItemGridLookUpEdit.DisplayMember = "OrderNumber";
            repositoryItemGridLookUpEdit.NullText = "Немає данних";


            //firstDateEdit.EditValue = firstDay;
            firstDateEdit.EditValue = lastDay.AddMonths(1).AddDays(-1);

            AuthorizatedUserAccess();

            LoadData((DateTime)firstDateEdit.EditValue);


        }

        private void LoadData(DateTime beginDate)
        {
            splashScreenManager.ShowWaitForm();

            storeHouseService = Program.kernel.Get<IStoreHouseService>();


            stoteHouseReceiptProject = storeHouseService.GetStoreHouseReceiptProject(beginDate).ToList();
            storeHouseReceiptProjectBS.DataSource = stoteHouseReceiptProject;
            storeHouseProjectGrid.DataSource = storeHouseReceiptProjectBS;
            storeHouseProjectGridView.ExpandAllGroups();
            
            //invoiceRequirementOrderGrid.DataSource = invoiceRequirementOrdersBS;

            //if (invoiceRequirementOrdersBS.Count > 0)
            //    LoadDataInvoiceRequirementMaterials(((InvoiceRequirementOrdersDTO)invoiceRequirementOrdersBS.Current).Id);

            splashScreenManager.CloseWaitForm();
        }


        private void LoadDetaExpenditureByCustomerOrder(int customerOrderId)
        {
            splashScreenManager.ShowWaitForm();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            expendituresBS.DataSource = storeHouseService.GetExpendituresStoreHousesByPeriod(DateTime.MinValue, DateTime.MaxValue).Where(bdsm => bdsm.CustomerOrderId == customerOrderId).OrderByDescending(sort => sort.Id).ToList();
            expendituresGrid.DataSource = expendituresBS;


            splashScreenManager.CloseWaitForm();
        }

        private void LoadDataInvoiceRequirementMaterials(int? id)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            //invoiceRequirementMaterialList = storeHouseService.GetInvoiceMaterialsForStoreHouseByOrderId(id).ToList();
            //invoiceRequirementMaterialsBS.DataSource = invoiceRequirementMaterialList;
            //storeHouseProjectGrid.DataSource = invoiceRequirementMaterialsBS;
        }

        private void AuthorizatedUserAccess()
        {
            //if (userTasksDTO.AccessRightId == 1)
            //{
            //    addBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //    deleteBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //}
            //else if (userTasksDTO.AccessRightId == 2)
            //{
            //    addBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            //    deleteBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            //}
        }

        private void searchBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData((DateTime)firstDateEdit.EditValue);
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //EditProductionInvoices(Utils.Operation.Update, (InvoiceRequirementOrdersDTO)invoiceRequirementOrdersBS.Current, (List<InvoiceRequirementMaterialsInfoDTO>)invoiceRequirementMaterialsBS.DataSource, userTasksDTO);
        }

        private void EditProductionInvoices(Utils.Operation operation, ExpedinturesAccountantDTO model,UserTasksDTO usersTasksDTO )
        {

            using (StoreHouseProjectExpendituresEditFm storeHouseProjectExpendituresEditFm = new StoreHouseProjectExpendituresEditFm(operation, model, usersTasksDTO))
            {
                if (storeHouseProjectExpendituresEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    storeHouseProjectGridView.BeginDataUpdate();
                    expendituresGridView.BeginDataUpdate();

                    LoadData((DateTime)firstDateEdit.EditValue);
                    if (customerOrderEdit.EditValue != null)
                    {
                        LoadDetaExpenditureByCustomerOrder((int)customerOrderEdit.EditValue);
                    }

                    ExpedinturesAccountantDTO returnItem = storeHouseProjectExpendituresEditFm.Return();
                    if (returnItem.Nomenclature == lastNomenclature)
                    {
                        quantityCurrent += returnItem.QUANTITY;
                        quantityEdit.EditValue = quantityCurrent;
                    }
                    else
                    {
                        quantityCurrent = returnItem.QUANTITY;
                        quantityEdit.EditValue = quantityCurrent;
                    }

                    lastNomenclature = returnItem.Nomenclature;
                    nomenclatureEdit.EditValue = lastNomenclature;

                    expendituresGridView.EndDataUpdate();
                    storeHouseProjectGridView.EndDataUpdate();
                }
                else
                {
                    return;
                }
            }
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            //ExpendituresStoreHousesDTO expendituresStoreHousesDTO = new ExpendituresStoreHousesDTO()
            //{
            //    CustomerOrderId = (int?)customerOrderEdit.EditValue,
            //    Quantity = ((StoreHouseReceiptProjectDTO)storeHouseReceiptProjectBS.Current).RemainsQuantity,
            //    ReceiptId = ((StoreHouseReceiptProjectDTO)storeHouseReceiptProjectBS.Current).ReceiptId,
            //    Nomenclature = ((StoreHouseReceiptProjectDTO)storeHouseReceiptProjectBS.Current).Nomenclature,
            //    NomenclatureName = ((StoreHouseReceiptProjectDTO)storeHouseReceiptProjectBS.Current).NomenclatureName,
            //    BalanceAccountNum = ((StoreHouseReceiptProjectDTO)storeHouseReceiptProjectBS.Current).DebitNum,
            //    UnitLocalName = ((StoreHouseReceiptProjectDTO)storeHouseReceiptProjectBS.Current).UnitLocalName

            //};

            //EditProductionInvoices(Utils.Operation.Add, expendituresStoreHousesDTO, userTasksDTO);

            

        }


        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (invoiceRequirementOrdersBS.Count > 0)
            //{
            //    try
            //    {
            //        DeleteInvoiceRequirement();
            //    }
            //    catch (System.Exception ex)
            //    {
            //        MessageBox.Show("При видаленні виникла помилка. " + ex.Message, "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void DeleteInvoiceRequirement()
        {
            //if (invoiceRequirementOrdersBS.Count != 0)
            //{
            //    if (MessageBox.Show("Видалити вимогу?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        //storeHouseService = Program.kernel.Get<IStoreHouseService>();
            //        //int rowHandle = invoiceRequirementOrderGridView.FocusedRowHandle - 1;
            //        //invoiceRequirementOrderGridView.BeginDataUpdate();
            //        //storeHouseService.InvoiceRequirementOrderDelete(((InvoiceRequirementOrdersDTO)invoiceRequirementOrdersBS.Current).Id);
            //        //LoadDataInvoiceRequirementOrders((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
            //        //if (invoiceRequirementOrdersBS.Count == 0)
            //        //    invoiceRequirementMaterialsBS.DataSource = null;
            //        //invoiceRequirementOrderGridView.EndDataUpdate();
            //        //invoiceRequirementOrderGridView.FocusedRowHandle = (invoiceRequirementOrderGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
            //    }
            //}

        }

        

        private void invoiceRequirementOrderGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //if (invoiceRequirementOrdersBS.Count > 0)
            //    LoadDataInvoiceRequirementMaterials(((InvoiceRequirementOrdersDTO)invoiceRequirementOrdersBS.Current).Id);
        }

        private void storeHouseProjectGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //nomenclatureCurrent = ((StoreHouseReceiptProjectDTO)storeHouseReceiptProjectBS.Current).Nomenclature;
            //nomenclatureEdit.EditValue = nomenclatureCurrent;

            //if (nomenclatureCurrent != lastNomenclature)
            //{
            //    quantityCurrent = 0;
            //    quantityEdit.EditValue = quantityCurrent;
            //}
                
        }

        private void storeHouseProjectGridView_DoubleClick(object sender, EventArgs e)
        {
            //ExpendituresStoreHousesDTO expendituresStoreHousesDTO = new ExpendituresStoreHousesDTO()
            //{
            //    CustomerOrderId = (int?)customerOrderEdit.EditValue,
            //    Quantity = ((StoreHouseReceiptProjectDTO)storeHouseReceiptProjectBS.Current).RemainsQuantity,
            //    ReceiptId = ((StoreHouseReceiptProjectDTO)storeHouseReceiptProjectBS.Current).ReceiptId,
            //    Nomenclature = ((StoreHouseReceiptProjectDTO)storeHouseReceiptProjectBS.Current).Nomenclature,
            //    NomenclatureName = ((StoreHouseReceiptProjectDTO)storeHouseReceiptProjectBS.Current).NomenclatureName,
            //    BalanceAccountNum = ((StoreHouseReceiptProjectDTO)storeHouseReceiptProjectBS.Current).DebitNum,
            //    UnitLocalName = ((StoreHouseReceiptProjectDTO)storeHouseReceiptProjectBS.Current).UnitLocalName

            //};

            //EditProductionInvoices(Utils.Operation.Add, expendituresStoreHousesDTO, userTasksDTO);

            //if (nomenclatureCurrent == lastNomenclature)
            //{
            //    quantityCurrent += expendituresStoreHousesDTO.Quantity;
            //    quantityEdit.EditValue = quantityCurrent;
            //}
            //else
            //{
            //    quantityCurrent = expendituresStoreHousesDTO.Quantity;
            //    quantityEdit.EditValue = quantityCurrent;
            //}

            //lastNomenclature = expendituresStoreHousesDTO.Nomenclature;
            //nomenclatureEdit.EditValue = lastNomenclature;
        }

        private void customerOrderEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (customerOrderEdit.EditValue != null)
            {
                LoadDetaExpenditureByCustomerOrder((int)customerOrderEdit.EditValue);
            }
        }

        private void storeHouseProjectGridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            storeHouseProjectGridView.ExpandAllGroups();
        }

        private void expwnditureBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

        }


    }
}