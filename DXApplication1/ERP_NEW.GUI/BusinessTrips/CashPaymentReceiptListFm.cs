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
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.Interfaces;
using Ninject;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Services;

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class CashPaymentReceiptListFm : DevExpress.XtraEditors.XtraForm
    {
        private IBusinessTripsService businessTripsService;
        private IAccountsService accountsService;
        private ICustomerOrdersService customerOrdersService;

        private BindingSource receiptsBS = new BindingSource();

        private List<InvoiceRequirementExpenditureInfoDTO> returnInvoiceRequirementExpenditureList = new List<InvoiceRequirementExpenditureInfoDTO>();

        private int _cashPrepaymentId;

        public CashPaymentReceiptListFm(int cashPrepaymentId)
        {
            InitializeComponent();

            _cashPrepaymentId = cashPrepaymentId;

            accountsService = Program.kernel.Get<IAccountsService>();
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            
            accountsEdit.DataSource = accountsService.GetAccounts();
            accountsEdit.ValueMember = "Id";
            accountsEdit.DisplayMember = "Num";

            customerOrderEdit.DataSource = customerOrdersService.GetCustomerOrdersFull();
            customerOrderEdit.ValueMember = "Id";
            customerOrderEdit.DisplayMember = "OrderNumber";

            firstDateEdit.EditValue = new DateTime(DateTime.Now.AddMonths(-1).Year, DateTime.Now.AddMonths(-1).Month, 1);
            lastDateEdit.EditValue = DateTime.Now;

            LoadData((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
        }

        #region Method's

        private void LoadData(DateTime firstDateEdit, DateTime lastDateEdit)
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            receiptsBS.DataSource = businessTripsService.GetReceiptsForCashPayment(firstDateEdit, lastDateEdit);
            receiptsGrid.DataSource = receiptsBS;
        }

        private bool SaveItems(List<CashPaymentsDTO> paymentSource)
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

       		businessTripsService.CashPaymentCreateRange(paymentSource);

            return true;     
        }

        #endregion

        #region Event's

        private void viewBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            receiptsGridView.PostEditor();

            List<CashPaymentsInfoDTO> receiptsList = ((List<CashPaymentsInfoDTO>)receiptsBS.DataSource).Where(s => s.Selected).ToList();

            if (receiptsList.Count > 0)
            {
                if (receiptsList.Any(s => s.VatAccountId == 0 && s.VatPrice > 0))
                {
                    MessageBox.Show("Збереження відмінено. Виберіть рахунок ПДВ для всіх відмічених записів.", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var paymentList = (from r in receiptsList
                                           select new CashPaymentsDTO()
                                           {
                                               CashPrepaymentId = _cashPrepaymentId,
                                               ReceiptId = r.ReceiptId,
                                               VatAccountId = r.VatAccountId,
                                               VatPrice = r.VatPrice,
                                               UserId = UserService.AuthorizatedUser.UserId,
                                               DateAdded = DateTime.Now,
                                               CustomerOrderId = r.CustomerOrderId
                                           }).ToList();

                        try
                        {
                            if (SaveItems(paymentList))
                            {
                                DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження інформації про аванс", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Не вибрано жодного запису для збереження.", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
        private void accountsEdit_EditValueChanged(object sender, EventArgs e)
        {
            receiptsGridView.PostEditor();
        }

        private void selectedPaymentRepository_CheckedChanged(object sender, EventArgs e)
        {
            receiptsGridView.PostEditor();

            checkRecordSumTBox.EditValue = ((List<CashPaymentsInfoDTO>)receiptsBS.DataSource).Where(s => s.Selected).Sum(s => s.TotalPrice) ?? 0.00m;
        }

        private void customerOrderEdit_EditValueChanged(object sender, EventArgs e)
        {
            receiptsGridView.PostEditor();
        }

        private void receiptsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            CashPaymentsInfoDTO item = (CashPaymentsInfoDTO)receiptsBS[e.ListSourceRowIndex];

            if (e.Column == statusCol && e.IsGetData)
            {
                if (item.Selected)
                {
                    if (item.VatPrice > 0 && item.VatAccountId == 0)
                        e.Value = imageCollection.Images[0];
                }
            }
        }
                
        #endregion

        private void receiptsGridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Column.Name == "vatPriceCol")
            {
                var cellValue = (decimal)receiptsGridView.GetRowCellValue(e.RowHandle, vatPriceCol);

                if (cellValue > 0)
                {
                    e.Appearance.BackColor2 = Color.LightGreen;
                    e.Appearance.BackColor = Color.PaleGreen;

                    e.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
                }
            }
        }
    }
}