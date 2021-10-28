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
using ERP_NEW.BLL.Services;
using ERP_NEW.BLL.DTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraEditors.Controls;
using Ninject;
using System.Web;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.GUI.Classifiers;
using ERP_NEW.GUI.Contractors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class BusinessTripsDecreeEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IBusinessTripsService businessTripsService;

        private BindingSource businessTripsDecreeBS = new BindingSource();
        private BindingSource businessTripsBS = new BindingSource();

        private List<BusinessTripsJournalDTO> tripList;
        private List<BusinessTripsDecreeDetailsDTO> deleteDecreeDetailList = new List<BusinessTripsDecreeDetailsDTO>();

        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return businessTripsDecreeBS.Current as ObjectBase; }
            set
            {
                businessTripsDecreeBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public BusinessTripsDecreeEditFm(Utils.Operation operation, BusinessTripsDecreeDTO model, int decreeType, List<BusinessTripsJournalDTO> tripSource)
        {
            InitializeComponent();

            _operation = operation;
            tripList = tripSource;

            businessTripsDecreeBS.DataSource = Item = model;
            businessTripsBS.DataSource = tripList;
            businessTripsGrid.DataSource = businessTripsBS;

            decreeNumberEdit.DataBindings.Add("EditValue", businessTripsDecreeBS, "Number");
            decreeDateEdit.DataBindings.Add("EditValue", businessTripsDecreeBS, "DecreeDate");

            if (_operation == Utils.Operation.Add)
            {
                businessTripsService = Program.kernel.Get<IBusinessTripsService>();

                switch (decreeType)
                {
                    case 1:
                        ((BusinessTripsDecreeDTO)Item).DecreeDate = DateTime.Now;
                        ((BusinessTripsDecreeDTO)Item).DecreeType = decreeType;
                        ((BusinessTripsDecreeDTO)Item).Number = businessTripsService.GetLatestDecreeNumber();
                        break;
                    case 2:
                        ((BusinessTripsDecreeDTO)Item).DecreeDate = DateTime.Now;
                        ((BusinessTripsDecreeDTO)Item).DecreeType = decreeType;
                        ((BusinessTripsDecreeDTO)Item).ParentId = ((BusinessTripsDecreeDTO)Item).ID;
                        ((BusinessTripsDecreeDTO)Item).ID = 0;
                        ((BusinessTripsDecreeDTO)Item).Number = businessTripsService.GetLatestDecreeNumber();
                        break;
                    case 3:
                        ((BusinessTripsDecreeDTO)Item).DecreeDate = DateTime.Now;
                        ((BusinessTripsDecreeDTO)Item).DecreeType = decreeType;
                        ((BusinessTripsDecreeDTO)Item).ParentId = ((BusinessTripsDecreeDTO)Item).ID;
                        ((BusinessTripsDecreeDTO)Item).ID = 0;
                        ((BusinessTripsDecreeDTO)Item).Number = businessTripsService.GetLatestDecreeNumber();
                        break;
                    default:
                        MessageBox.Show("Не вірні параметри виклику!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            else if (_operation == Utils.Operation.Update && decreeType != 1)
            {
                deleteBusinessTrips.Enabled = false;
                addBusinessTrips.Enabled = false;
                businessTripsGrid.Enabled = false;
            }

            decreeValidationProvider.Validate();
        }

        #region Method's

        private bool SaveDecree()
        {
            this.Item.EndEdit();

            if (FindDublicate((BusinessTripsDecreeDTO)this.Item))
            {
                MessageBox.Show("Наказ з таким номером вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (businessTripsBS.Count == 0)
            {
                MessageBox.Show("Необхідно додати посвідчення до наказу!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            try
            {
                if (deleteDecreeDetailList.Count > 0)
                {
                    businessTripsService = Program.kernel.Get<IBusinessTripsService>();
                    businessTripsService.BusinessTripDecreeDetailRemoveRange(deleteDecreeDetailList);
                }

                if (_operation == Utils.Operation.Add)
                {
                    businessTripsService = Program.kernel.Get<IBusinessTripsService>();

                    switch (((BusinessTripsDecreeDTO)Item).DecreeType)
                    {
                        case 1:
                            ((BusinessTripsDecreeDTO)Item).ID = businessTripsService.BusinessTripDecreeCreate((BusinessTripsDecreeDTO)Item);
                            var source = (from p in tripList
                                          select new BusinessTripsDecreeDetailsDTO()
                                          {
                                              BusinessTripDetailId = p.ID,
                                              DecreeId = ((BusinessTripsDecreeDTO)Item).ID
                                          }).ToList();
                            businessTripsService.BusinessTripDecreeDetailCreateRange(source);

                            break;

                        case 2:
                            if (businessTripsGridView.SelectedRowsCount > 0)
                            {
                                var updateList = tripList.Where(t => t.Selection).ToList();
                                
                                foreach (var item in updateList)
                                {
                                        BusinessTripsDTO newModel = new BusinessTripsDTO()
                                        {
                                            ID = ((BusinessTripsJournalDTO)item).BusinessTripsID,
                                            Doc_Number = ((BusinessTripsJournalDTO)item).Doc_Number,
                                            Doc_Date = ((BusinessTripsJournalDTO)item).Doc_Date,
                                            DepartureID = ((BusinessTripsJournalDTO)item).DepartureID,
                                            EmployeesID = ((BusinessTripsJournalDTO)item).EmployeesID,
                                            CityID = ((BusinessTripsJournalDTO)item).CityID,
                                            ContractorsID = ((BusinessTripsJournalDTO)item).ContractorsID,
                                            AgreementsID = ((BusinessTripsJournalDTO)item).AgreementsID,
                                            PurposeID = ((BusinessTripsJournalDTO)item).PurposeID,
                                            StartDate = ((BusinessTripsJournalDTO)item).StartDate,
                                            EndDate = ((BusinessTripsJournalDTO)item).EndDate,
                                            AmountDays = ((BusinessTripsJournalDTO)item).AmountDays
                                        };

                                        businessTripsService.BusinessTripUpdate(newModel);
                                    
                                        ((BusinessTripsDecreeDTO)Item).ID = businessTripsService.BusinessTripDecreeCreate((BusinessTripsDecreeDTO)Item);
                                    
                                        businessTripsService.BusinessTripDecreeDetailCreate(new BusinessTripsDecreeDetailsDTO()
                                        {
                                            Id = item.DecreeDetailId ?? 0,
                                            BusinessTripDetailId = item.ID,
                                            DecreeId = ((BusinessTripsDecreeDTO)Item).ID
                                        });
                                    }

                            }
                            break;

                        case 3:
                            ((BusinessTripsDecreeDTO)Item).ID = businessTripsService.BusinessTripDecreeCreate((BusinessTripsDecreeDTO)Item);
                                    
                            var createList = tripList.Where(t => t.Selection).Select(s => new BusinessTripsDecreeDetailsDTO()
                                    {
                                        Id = s.DecreeDetailId ?? 0,
                                        BusinessTripDetailId = s.ID,
                                        DecreeId = ((BusinessTripsDecreeDTO)Item).ID
                                    }).ToList();


                            businessTripsService.BusinessTripDecreeDetailCreateRange(createList);
                            break;

                        default:
                            MessageBox.Show("Невідома команда!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                    return true;
                }
                else
                {
                    businessTripsService.BusinessTripDecreeUpdate((BusinessTripsDecreeDTO)Item);

                    var source = (from p in tripList
                              select new BusinessTripsDecreeDetailsDTO()
                              {
                                  Id = p.DecreeDetailId ?? 0,
                                  BusinessTripDetailId = p.ID,
                                  DecreeId = ((BusinessTripsDecreeDTO)Item).ID
                              }
                        ).ToList();

                    foreach (var item in source)
                    {
                        if (item.Id == 0)
                            businessTripsService.BusinessTripDecreeDetailCreate(item);
                        else
                            businessTripsService.BusinessTripDecreeDetailUpdate(item);
                    }
                    return true;
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private bool FindDublicate(BusinessTripsDecreeDTO model)
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            return businessTripsService.GetBusinessTripsDecrees().Any(s => s.Number == model.Number && s.DecreeDate.Year == model.DecreeDate.Year && s.ID != model.ID);
        }

        public int Return()
        {
            return ((BusinessTripsDecreeDTO)Item).ID;
        }

        #endregion

        #region Event's

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveDecree())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void addBusinessTrips_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            var sourceTripList = businessTripsService.GetBusinessTripsWithoutDecree().ToList();

            using (BusinessTripsSelectFm businessTripsSelectFm = new BusinessTripsSelectFm(sourceTripList))
            {
                if (businessTripsSelectFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var returnList = businessTripsSelectFm.Return();

                    businessTripsGridView.BeginDataUpdate();

                    tripList.AddRange(returnList.Select(s => { s.Selection = false; return s;}));
                    businessTripsBS.DataSource = tripList;
                    businessTripsGrid.DataSource = businessTripsBS;

                    businessTripsGridView.EndDataUpdate();
                }
            }
        }

        private void deleteBusinessTrips_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            businessTripsGridView.PostEditor();

            businessTripsGridView.BeginDataUpdate();

            var checkItems = tripList.Where(t => t.Selection && t.DecreeDetailId != 0).Select(s => new BusinessTripsDecreeDetailsDTO()
                        {
                            
                            
                            
                            Id = s.DecreeDetailId ?? 0,
                            BusinessTripDetailId = s.ID,
                            DecreeId = s.DecreeId ?? 0
                        });

            deleteDecreeDetailList.AddRange(checkItems);
            tripList.RemoveAll(s => s.Selection);

            businessTripsBS.DataSource = tripList;
            businessTripsGrid.DataSource = businessTripsBS;

            businessTripsGridView.EndDataUpdate();
        }

        private void businessTripsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            BusinessTripsJournalDTO item = (BusinessTripsJournalDTO)businessTripsBS[e.ListSourceRowIndex];

            if (e.Column == decreeStatusCol && e.IsGetData)
            {
                if (item.DecreeId != null)
                        {
                    e.Value = (item.DecreeProlongStatus == 0 && item.DecreeAvoidanceStatus == 0)
                        ? imageCollection.Images[1]
                        : (item.DecreeProlongStatus == 1)
                            ? imageCollection.Images[2]
                            : imageCollection.Images[3];
                }
            }
            
            if (e.Column == paymentStatusCol && e.IsGetData)
            {
                if (item.PaymentStatus == 1 || item.PrepaymentStatus == 1)
                    e.Value = imageCollection.Images[4];
            }
        }

        private void selectionRepository_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckEdit)sender).Checked)
        {
            if (((BusinessTripsDecreeDTO)Item).DecreeType == 2)
            {
                    businessTripsGridView.PostEditor();

                    BusinessTripsDTO currentModelForDateEdit = businessTripsService.GetBusinessTripsByDetailId(((BusinessTripsJournalDTO)businessTripsBS.Current).ID);

                    using (BusinessTripsEditFm businessTripsEditFm = new BusinessTripsEditFm(Utils.Operation.Custom, currentModelForDateEdit))
                    {
                        DialogResult result = businessTripsEditFm.ShowDialog();
                        if (result == System.Windows.Forms.DialogResult.Retry)
                        {
                            businessTripsGridView.BeginDataUpdate();
                            var returnItem = businessTripsEditFm.Return();
                            ((BusinessTripsJournalDTO)businessTripsBS.Current).EndDate = returnItem.EndDate;
                            ((BusinessTripsJournalDTO)businessTripsBS.Current).AmountDays = returnItem.AmountDays;

                            businessTripsGridView.EndDataUpdate();

                            businessTripsBS.EndEdit();
                        }
                        else
                        {
                            ((CheckEdit)sender).Checked = false;
                        }
                    }
                }
            }
                        }

        private void businessTripsGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (((BusinessTripsDecreeDTO)Item).DecreeType > 1)
            {
                if (((GridView)sender).FocusedColumn.FieldName == "Selection" &&
                    ((BusinessTripsJournalDTO)businessTripsBS.Current).DecreeAvoidanceStatus == 1)
                    e.Cancel = true;
                }

            if (_operation == Utils.Operation.Update)
            {
                if (((GridView)sender).FocusedColumn.FieldName == "Selection" &&
                                   ((((BusinessTripsJournalDTO)businessTripsBS.Current).DecreeAvoidanceStatus == 1) ||
                                   (((BusinessTripsJournalDTO)businessTripsBS.Current).DecreeProlongStatus == 1) ||
                                   (((BusinessTripsJournalDTO)businessTripsBS.Current).PaymentStatus == 1) ||
                                   (((BusinessTripsJournalDTO)businessTripsBS.Current).PrepaymentStatus == 1)))
                    e.Cancel = true;
            }
        }

        private void toolTipController_GetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.SelectedControl is GridControl)
            {
                GridView view = ((GridControl)e.SelectedControl).GetViewAt(e.ControlMousePosition) as GridView;

                if (view == null) return;

                GridHitInfo hi = view.CalcHitInfo(e.ControlMousePosition);

                if (hi.HitTest == GridHitTest.RowCell && hi.Column != null && hi.Column == decreeStatusCol)
                {
                    Image relatedImage = (Image)view.GetRowCellValue(hi.RowHandle, hi.Column);
                    if (relatedImage != null)
                    {
                        if (relatedImage == imageCollection.Images[0])
                            e.Info = new ToolTipControlInfo(hi.Column, "Посвідчення не включено до наказу.");
                        else if (relatedImage == imageCollection.Images[1])
                            e.Info = new ToolTipControlInfo(hi.Column, "Включено до основного наказу");
                        else if (relatedImage == imageCollection.Images[2])
                            e.Info = new ToolTipControlInfo(hi.Column, "Включено до наказу на зміну терміну");
                        else if (relatedImage == imageCollection.Images[3])
                            e.Info = new ToolTipControlInfo(hi.Column, "Включено до наказу на скасування");
                    }
                }

                if (hi.HitTest == GridHitTest.RowCell && hi.Column != null && hi.Column == paymentStatusCol)
                {
                    Image relatedImage = (Image)view.GetRowCellValue(hi.RowHandle, hi.Column);
                    if (relatedImage != null)
                    {
                        if (relatedImage == imageCollection.Images[4])
                            e.Info = new ToolTipControlInfo(hi.Column, "Посвідчення містить грошові виплати");
                    }
                }
            }
        }

        #endregion

        #region Validation's

        private bool ControlValidation()
        {
            return decreeValidationProvider.Validate();
        }
        
        private void decreeValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void decreeValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (decreeValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void decreeNumberEdit_TextChanged(object sender, EventArgs e)
        {
            decreeValidationProvider.Validate((Control)sender);
        }

        private void decreeDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            decreeValidationProvider.Validate((Control)sender);
        }

        #endregion

    }
}