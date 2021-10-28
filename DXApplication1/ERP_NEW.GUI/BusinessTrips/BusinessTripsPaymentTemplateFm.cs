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
using Ninject;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class BusinessTripsPaymentTemplateFm : DevExpress.XtraEditors.XtraForm
    {
        private IBusinessTripsService businessTripsService;
        private ICurrencyService currencyService;
        private IPeriodService periodService;

        private BindingSource paymentTemplateBS = new BindingSource();
        private BindingSource businessTripsBS = new BindingSource();
        private BindingSource paymentsBS = new BindingSource();

        private BusinessTripsPrepaymentJournalDTO _model;

        public BusinessTripsPaymentTemplateFm(BusinessTripsPrepaymentJournalDTO model)
        {
            InitializeComponent();

            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            currencyService = Program.kernel.Get<ICurrencyService>();

            _model = model;

            LoadDataByPeriod();
        }

        #region Method's

        private void LoadDataByPeriod()
        {
            splashScreenManager.ShowWaitForm();

            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            businessTripsBS.DataSource = businessTripsService.GetBusinessTripsPrepaymentJournalByPeriod(DateTime.MinValue, DateTime.MaxValue);
            businessTripsEdit.Properties.DataSource = businessTripsBS;
            businessTripsEdit.Properties.ValueMember = "BusinessTripsDetailsID";
            businessTripsEdit.Properties.DisplayMember = "Doc_Number";
            businessTripsEdit.Properties.NullText = "Немає данних";

            splashScreenManager.CloseWaitForm();
        }

        private bool SaveBusinessTripTemplate()
        {
            paymentsGridView.PostEditor();
            paymentsGridView.BeginDataUpdate();

            List<BusinessTripsPaymentDTO> list = (List<BusinessTripsPaymentDTO>)paymentsBS.DataSource;

            if (list.Any(m => m.Selected))
            {

                var updateList = list.Where(l => l.Selected).Select(item =>
                {
                    item.BusinessTripsDetailsID = _model.BusinessTripsDetailsID;
                    item.EmployeesID = _model.EmployeesID;
                    return item;
                }).ToList();

                foreach (var item in updateList)
                {
                    if (!CheckPeriodAccess(item.Doc_Date))
                    {
                        MessageBox.Show("Період закритий або не існує!", "Редагування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }

                foreach (var item in updateList)
                {
                    if (item.BusinessTripsPaymentVatID != null)
                    {
                        BusinessTripsPaymentVatDTO vatItem = new BusinessTripsPaymentVatDTO() { VatAccountID = item.VatAccountId ?? 0, VatPayment = item.VatPayment ?? 0 };
                        item.BusinessTripsPaymentVatID = businessTripsService.BusinessTripsPaymentVatCreate(vatItem);
                    }

                    if (item.CurrencyRatesID != null)
                    {
                        Currency_RatesDTO crItem = new Currency_RatesDTO()
                        {
                            Currency_Id = item.CurrencyId,
                            CurrencyPayment = item.CurrencyPayment,
                            Date = item.CurrencyDate ?? DateTime.Now,
                            Rate = item.CurrencyRate,
                            Multiplicity = 1
                        };

                        item.CurrencyRatesID = currencyService.CurrencyRatesCreate(crItem);
                    }
                }

                businessTripsService.BusinessTripsPaymentCreateRange(updateList);

                paymentsGridView.EndDataUpdate();
                
                return true;
            }
            else
            {
                MessageBox.Show("Не вибрано жодного звіту!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                paymentsGridView.EndDataUpdate();
                return false;
            }

        }

        private void LoadPaymentDateByBTDId(int btdId)
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            paymentsBS.DataSource = businessTripsService.GetBusinessTripsPaymentList(btdId);
            paymentsGrid.DataSource = paymentsBS;
        }

        private bool CheckPeriodAccess(DateTime currentDate)
        {
            periodService = Program.kernel.Get<IPeriodService>();

            return periodService.GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month && p.StateBusinesTrip);
        }

        #endregion

        #region Event's

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveBusinessTripTemplate())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void businessTripsEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (businessTripsEdit.EditValue != null)
                LoadPaymentDateByBTDId((int)businessTripsEdit.EditValue);
        }

        #endregion
    }
}