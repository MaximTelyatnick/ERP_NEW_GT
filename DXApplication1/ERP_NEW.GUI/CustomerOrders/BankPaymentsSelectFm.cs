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
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_NEW.GUI.CustomerOrders
{
    public partial class BankPaymentsSelectFm : DevExpress.XtraEditors.XtraForm
    {
        private IBankPaymentsService bankPaymentsService;
        private ICustomerOrdersService customerOrdersService;

        private BindingSource paymentsBS = new BindingSource();
                
        private List<BankPaymentsSelectDTO> paymentsList = new List<BankPaymentsSelectDTO>();

        private int _paymentStatus;
        private int _customerOrderId;
 
        public BankPaymentsSelectFm(int paymentStatus, int customerOrderId) // 1 - prepayment, 2 - payment
        {
            InitializeComponent();

            _paymentStatus = paymentStatus;
            _customerOrderId = customerOrderId;

            firstDateEdit.EditValue = new DateTime(DateTime.Now.AddMonths(-1).Year, DateTime.Now.AddMonths(-1).Month, 1);
            lastDateEdit.EditValue = DateTime.Now;

            LoadData((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
        }

        private void LoadData(DateTime firstDateEdit, DateTime lastDateEdit)
        {
            bankPaymentsService = Program.kernel.Get<IBankPaymentsService>();

            paymentsBS.DataSource = (_paymentStatus == 1) 
                ? bankPaymentsService.GetBankPaymentsForCOPrepayments(firstDateEdit, lastDateEdit)
                : bankPaymentsService.GetBankPaymentsForCOPayments(firstDateEdit, lastDateEdit);
                         
            bankPaymentsGrid.DataSource = paymentsBS;
        }

        private bool SaveItems(List<BankPaymentsSelectDTO> paymentSource)
        {
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();

            if (_paymentStatus == 1)
            {
                var saveList = paymentSource.Select(s => new CustomerOrderPrepaymentsDTO()
                {
                    CustomerOrderId = _customerOrderId,
                    BankPaymentId = s.Id,
                    Prepayment = s.PaymentPriceAdded,
                    PrepaymentCurrency = s.PaymentPriceCurrencyAdded
                }).ToList();

                foreach (var item in saveList)
                {
                    customerOrdersService.CustomerOrderPrepaymentCreate(item);
                }
            }
            else
            {
                var saveList = paymentSource.Select(s => new CustomerOrderPaymentsDTO()
                {
                    CustomerOrderId = _customerOrderId,
                    BankPaymentId = s.Id,
                    Payment = s.PaymentPriceAdded,
                    PaymentCurrency = s.PaymentPriceCurrencyAdded
                }).ToList();

                foreach (var item in saveList)
                {
                    customerOrdersService.CustomerOrderPaymentCreate(item);
                }
            }

            return true;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            bankPaymentsGridView.PostEditor();

            paymentsList = ((List<BankPaymentsSelectDTO>)paymentsBS.DataSource).Where(s => s.Selected).ToList();

            if (paymentsList.Count > 0)
            {
                if (paymentsList.Any(s => s.PaymentPriceAdded == 0 && s.PaymentPriceCurrencyAdded == 0))
                {
                    MessageBox.Show("Збереження відмінено. Введіть суму для всіх відмічених записів.", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (paymentsList.Any(s => s.PaymentPriceRemains < s.PaymentPriceAdded || s.PaymentPriceCurrencyRemains < s.PaymentPriceCurrencyAdded))
                {
                    MessageBox.Show("Збереження відмінено. Сума залишку менше доданої суми.", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {                        
                        try
                        {
                            if (SaveItems(paymentsList))
                            {
                                DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void viewBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
        }
                
        private void bankPaymentsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            BankPaymentsSelectDTO item = (BankPaymentsSelectDTO)paymentsBS[e.ListSourceRowIndex];

            if (e.Column == statusCol && e.IsGetData)
            {
                if (item.Selected)
                {
                    if (item.PaymentPriceAdded == 0 && item.PaymentPriceCurrencyAdded == 0)
                        e.Value = imageCollection.Images[0];
                }

                if(item.PaymentPriceRemains < item.PaymentPriceAdded || item.PaymentPriceCurrencyRemains < item.PaymentPriceCurrencyAdded)
                    e.Value = imageCollection.Images[1];
            }
        }

        private void bankPaymentsGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var item = (BankPaymentsSelectDTO)bankPaymentsGridView.GetRow(e.RowHandle);

                if (e.Column.Name == "paymentPriceAddedCol")
                {
                    if (item.PaymentPriceRemains < item.PaymentPriceAdded)
                    {
                        e.Appearance.BackColor = Color.LightSalmon;
                        e.Appearance.BackColor2 = Color.Tomato;
                    }
                }
                
                if (e.Column.Name == "paymentPriceCurrencyAddedCol")
                {
                    if (item.PaymentPriceCurrencyRemains < item.PaymentPriceCurrencyAdded)
                    {
                        e.Appearance.BackColor = Color.LightSalmon;
                        e.Appearance.BackColor2 = Color.Tomato;
                    }
                }
            }
        }
                
    }
}