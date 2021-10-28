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
using Ninject;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System.IO;
using DevExpress.XtraBars;
using System.Diagnostics;
using ERP_NEW.BLL.Infrastructure;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class InvoiceRequirementFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IReportService reportService;

        private BindingSource invoiceRequirementOrdersBS = new BindingSource();
        private BindingSource invoiceRequirementMaterialsBS = new BindingSource();
        private UserTasksDTO userTasksDTO;
        private Utils.InvoiceType invoiceType;

        private bool checkInvoices;
        private List<InvoiceRequirementMaterialsInfoDTO> selectedMaterials = new List<InvoiceRequirementMaterialsInfoDTO>();
        private InvoiceRequirementOrdersDTO modelReturn = new InvoiceRequirementOrdersDTO();


        public InvoiceRequirementFm(UserTasksDTO userTasksDTO, Utils.InvoiceType invoiceType, bool checkInvoices = false, List<InvoiceRequirementMaterialsInfoDTO> selectedMaterials = null)
        {
            InitializeComponent();

            this.userTasksDTO = userTasksDTO;
            this.checkInvoices = checkInvoices;
            this.invoiceType = invoiceType;

            DateTime firstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime lastDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            firstDateEdit.EditValue = firstDay;
            lastDateEdit.EditValue = lastDay.AddMonths(1).AddDays(-1);

            AuthorizatedUserAccess();

            switch (invoiceType)
            {
                case Utils.InvoiceType.Accountint:
                    LoadDataInvoiceRequirementOrders((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
                    break;
                case Utils.InvoiceType.Storehouses:
                    LoadDataInvoiceRequirementOrders((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);

                    if (checkInvoices)
                    {
                        addOrderBtn.Enabled = false;
                        deleteOrderBtn.Enabled = false;
                        updateOrderBtn.Enabled = false;
                        writeRequirementBtn.Enabled = false;
                        this.selectedMaterials.AddRange(selectedMaterials);
                    }

                    break;
                case Utils.InvoiceType.Production:
                    break;
                default:
                    break;
            }


            

            
        }

        #region Method's

        private void LoadDataInvoiceRequirementOrders(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            invoiceRequirementOrdersBS.DataSource = storeHouseService.GetAllInvoiceRequirementOrders(beginDate, endDate);
            invoiceRequirementOrderGrid.DataSource = invoiceRequirementOrdersBS;

            if (invoiceRequirementOrdersBS.Count > 0)
                LoadDataInvoiceRequirementMaterials(((InvoiceRequirementOrdersDTO)invoiceRequirementOrdersBS.Current).Id);

            splashScreenManager.CloseWaitForm();
        }

        private void LoadDataInvoiceRequirementMaterials(int id)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            if(userTasksDTO.PriceAttribute==1)
                invoiceRequirementMaterialsBS.DataSource = storeHouseService.GetInvoiceMaterialsByOrderId(id);
            else
                invoiceRequirementMaterialsBS.DataSource = storeHouseService.GetInvoiceMaterialsForStoreHouseByOrderId(id);
            invoiceRequirementMaterialsGrid.DataSource = invoiceRequirementMaterialsBS;
        }

        private void AuthorizatedUserAccess()
        {
            addOrderBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editOrderBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteOrderBtn.Enabled = (userTasksDTO.AccessRightId == 2);
                        
            unitPriceCol.Visible = (userTasksDTO.PriceAttribute == 1);
            totalPriceCol.Visible = (userTasksDTO.PriceAttribute == 1);
        }

        private void EditInvoiceRequirement(Utils.Operation operation,Utils.InvoiceType invoiceType, InvoiceRequirementOrdersDTO model, List<InvoiceRequirementMaterialsInfoDTO> invoiceRequirementMaterialsList)
        {
            using (InvoiceRequirementEditFm invoiceRequirementEditFm = new InvoiceRequirementEditFm(operation,invoiceType, userTasksDTO, model, invoiceRequirementMaterialsList))
            {
                if (invoiceRequirementEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (checkInvoices)
                    {
                        InvoiceRequirementOrdersDTO invoiceRequirementOrdersDTO = invoiceRequirementEditFm.Return();

                        modelReturn = invoiceRequirementOrdersDTO;

                        this.Close();



                    }
                    else
                    {
                        InvoiceRequirementOrdersDTO invoiceRequirementOrdersDTO = invoiceRequirementEditFm.Return();

                        invoiceRequirementOrderGridView.BeginDataUpdate();

                        LoadDataInvoiceRequirementOrders((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);

                        invoiceRequirementOrderGridView.EndDataUpdate();
                    }
                }
            }
        }

        public InvoiceRequirementOrdersDTO Return()
        {
            return modelReturn;
        }

        private void DeleteInvoiceRequirement()
        {
            if (invoiceRequirementOrdersBS.Count != 0)
            {
                if (MessageBox.Show("Видалити вимогу?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (invoiceRequirementMaterialsBS.Count > 0)
                    {
                        MessageBox.Show("Вимога містить матеріали!", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    storeHouseService = Program.kernel.Get<IStoreHouseService>();
                    int rowHandle = invoiceRequirementOrderGridView.FocusedRowHandle - 1;
                    invoiceRequirementOrderGridView.BeginDataUpdate();
                    storeHouseService.InvoiceRequirementOrderDelete(((InvoiceRequirementOrdersDTO)invoiceRequirementOrdersBS.Current).Id);
                    LoadDataInvoiceRequirementOrders((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
                    if (invoiceRequirementOrdersBS.Count == 0)
                        invoiceRequirementMaterialsBS.DataSource = null;
                    invoiceRequirementOrderGridView.EndDataUpdate();
                    invoiceRequirementOrderGridView.FocusedRowHandle = (invoiceRequirementOrderGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }

        #endregion

        #region Event's

        private void updateOrderBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadDataInvoiceRequirementOrders((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
        }

        private void invoiceRequirementOrderGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (invoiceRequirementOrdersBS.Count > 0)
                LoadDataInvoiceRequirementMaterials(((InvoiceRequirementOrdersDTO)invoiceRequirementOrdersBS.Current).Id);
        }

        private void addOrderBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditInvoiceRequirement(Utils.Operation.Add, invoiceType, new InvoiceRequirementOrdersDTO(), new List<InvoiceRequirementMaterialsInfoDTO>());
        }

        private void editOrderBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (invoiceRequirementOrdersBS.Count > 0)
            {
                if (!checkInvoices)
                {
                    EditInvoiceRequirement(Utils.Operation.Update,invoiceType, (InvoiceRequirementOrdersDTO)invoiceRequirementOrdersBS.Current, (List<InvoiceRequirementMaterialsInfoDTO>)invoiceRequirementMaterialsBS.DataSource);
                }
                else
                {
                    selectedMaterials.AddRange((List<InvoiceRequirementMaterialsInfoDTO>)invoiceRequirementMaterialsBS.DataSource);
                    EditInvoiceRequirement(Utils.Operation.Update, invoiceType, (InvoiceRequirementOrdersDTO)invoiceRequirementOrdersBS.Current, selectedMaterials);                
                }
            }
        }

        private void deleteOrderBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (invoiceRequirementOrdersBS.Count > 0)
            {
                try
                {
                    DeleteInvoiceRequirement();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("При видаленні виникла помилка. " + ex.Message, "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadDataInvoiceRequirementOrders((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
        }

        private void writeRequirementBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (invoiceRequirementOrdersBS.Count > 0)
            {
                reportService = Program.kernel.Get<IReportService>();

                reportService.InvoiceRequirement((List<InvoiceRequirementMaterialsInfoDTO>)invoiceRequirementMaterialsBS.DataSource,
                                                 ((InvoiceRequirementOrdersDTO)invoiceRequirementOrdersBS.Current).Number,
                                                 ((InvoiceRequirementOrdersDTO)invoiceRequirementOrdersBS.Current).Date.ToShortDateString(),
                                                 ((InvoiceRequirementOrdersDTO)invoiceRequirementOrdersBS.Current).Responsible_Person_Name);
            }
        }
                
        private void invoiceRequirementMaterialGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            //if (e.RowHandle > 0 && (e.Column.Name == "expenAccountNumCol" || e.Column.Name == "totalPriceCol" || e.Column.Name == "expenQuantityCol"))
            //{
            //    var model = (InvoiceRequirementMaterialsInfoDTO)invoiceRequirementMaterialGridView.GetRow(e.RowHandle);

            //    if (model.ExpendituresId == null)
            //    {
            //        e.Appearance.BackColor2 = Color.LightSalmon;
            //        e.Appearance.BackColor = Color.Tomato;
            //    }
            //}
        }

        #endregion

        private void InvoiceRequirementFm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void InvoicesAndFixedAssetsBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            InvoiceRequirementFixedAssetsJournalFm invoiceRequirementFixedAssetsJournalFm = new InvoiceRequirementFixedAssetsJournalFm((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
            invoiceRequirementFixedAssetsJournalFm.Show();
        }
        
    }
}