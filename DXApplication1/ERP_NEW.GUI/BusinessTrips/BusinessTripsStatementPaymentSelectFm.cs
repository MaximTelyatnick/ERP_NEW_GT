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
using ERP_NEW.BLL.DTO.ReportsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraGrid.Localization;

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class BusinessTripsStatementPaymentSelectFm : DevExpress.XtraEditors.XtraForm
    {
        private IEmployeesService employeesService;
        private IReportService reportService;

        private BindingSource creditPaymentsBS = new BindingSource();

        private List<BusinessTripsPaymentStatementDTO> businesTripsEmployeesWithCreditPaymentList = new List<BusinessTripsPaymentStatementDTO>();
        private List<BusinessTripsPaymentStatementDTO> businesTripsEmployeesWithCreditPaymentSelectedList = new List<BusinessTripsPaymentStatementDTO>();

        DateTime firstDate;
        DateTime secondDate;


        public BusinessTripsStatementPaymentSelectFm(DateTime firstDate, DateTime secondDate)
        {
            employeesService = Program.kernel.Get<IEmployeesService>();
            reportService = Program.kernel.Get<IReportService>();
            
            InitializeComponent();

            businesTripsEmployeesWithCreditPaymentList = reportService.GetBSTPaymentStatement(firstDate, secondDate).ToList();

            LoadData(firstDate, secondDate);

        }

        public void LoadData(DateTime firstDate, DateTime secondDate)
        {
            employeesService = Program.kernel.Get<IEmployeesService>();
            reportService = Program.kernel.Get<IReportService>();

            GridLocalizer.Active = new MyGridLocalizer();
            this.firstDate = firstDate;
            this.secondDate = secondDate;

            repositoryItemSearchLookUpEdit.DataSource = employeesService.GetEmployeesWorkingNonPhoto();
            repositoryItemSearchLookUpEdit.ValueMember = "EmployeeID";
            repositoryItemSearchLookUpEdit.DisplayMember = "FullName";
            repositoryItemSearchLookUpEdit.Properties.NullText = "Немає данних";

            creditPaymentsBS.DataSource = businesTripsEmployeesWithCreditPaymentList;
            businessTripeStatementGrid.DataSource = creditPaymentsBS;

            if (businesTripsEmployeesWithCreditPaymentList.Count == 0)
                MessageBox.Show("Відсутні робітники з поточним кредитом на виплату!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (employeesEdit.EditValue != null && moneyEdit.EditValue !=null)
            {

                splashScreenManager.ShowWaitForm();

                var bdsm = repositoryItemSearchLookUpEdit.GetRowByKeyValue((int)employeesEdit.EditValue);

                decimal d = 0;

                BusinessTripsPaymentStatementDTO businessTripsPaymentStatementDTO = new BusinessTripsPaymentStatementDTO()
                {
                    AccountNumber = Convert.ToString(((EmployeesInfoNonPhotoDTO)bdsm).AccountNumber),
                    CreditEnd = Math.Abs(decimal.TryParse(moneyEdit.EditValue.ToString(), out d) ? d : 0),
                    Fio = ((EmployeesInfoNonPhotoDTO)bdsm).FullName,
                    IdentNumber = ((EmployeesInfoNonPhotoDTO)bdsm).IdentNumber
                };

                businessTripsPaymentStatementDTO.Fio = businessTripsPaymentStatementDTO.Fio.Substring(0, businessTripsPaymentStatementDTO.Fio.LastIndexOf('('));

                businesTripsEmployeesWithCreditPaymentList.Add(businessTripsPaymentStatementDTO);

                businessTripeStatementGridView.PostEditor();

                businessTripeStatementGridView.BeginDataUpdate();

                creditPaymentsBS.DataSource = businesTripsEmployeesWithCreditPaymentList;
                businessTripeStatementGrid.DataSource = creditPaymentsBS;

                businessTripeStatementGridView.EndDataUpdate();

                splashScreenManager.CloseWaitForm();
            }
            else
            {
                MessageBox.Show("Не обрано співробітника або не додано суму!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (businesTripsEmployeesWithCreditPaymentList.Count > 0)
            {


                businessTripeStatementGridView.PostEditor();

                businessTripeStatementGridView.BeginDataUpdate();

                businesTripsEmployeesWithCreditPaymentList.RemoveAll((bdsm) => bdsm.Selected == true);

                creditPaymentsBS.DataSource = businesTripsEmployeesWithCreditPaymentList;
                businessTripeStatementGrid.DataSource = creditPaymentsBS;


                businessTripeStatementGridView.EndDataUpdate();
            }
            else
                MessageBox.Show("Відсутні робітники з поточним кредитом на виплату!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void printStatementReportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.PrintBSTPaymentStatement(businesTripsEmployeesWithCreditPaymentList,firstDate, secondDate))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (creditPaymentsBS.Count == 0 || businessTripeStatementGridView.FocusedRowHandle < 0)
                e.Cancel = true;
        }

        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            switch (e.ClickedItem.ToString())
            {
                case "Відмітити усіх":
                    foreach (var item in creditPaymentsBS.List)
                         ((BusinessTripsPaymentStatementDTO)item).Selected = true;

                    businessTripeStatementGridView.PostEditor();

                    businessTripeStatementGridView.BeginDataUpdate();

                    creditPaymentsBS.DataSource = businesTripsEmployeesWithCreditPaymentList;
                    businessTripeStatementGrid.DataSource = creditPaymentsBS;

                    businessTripeStatementGridView.EndDataUpdate();

                    break;
                case "Прибрати відмітки":
                    foreach (var item in creditPaymentsBS.List)
                         ((BusinessTripsPaymentStatementDTO)item).Selected = false;

                    businessTripeStatementGridView.PostEditor();

                    businessTripeStatementGridView.BeginDataUpdate();

                    creditPaymentsBS.DataSource = businesTripsEmployeesWithCreditPaymentList;
                    businessTripeStatementGrid.DataSource = creditPaymentsBS;

                    businessTripeStatementGridView.EndDataUpdate();
                    break;

                default:
                    break;
            }
        }
    }



    #region Custom search and clear button

    public class MyGridLocalizer : GridLocalizer
    {
        public override string GetLocalizedString(GridStringId id)
        {
            if (id == GridStringId.FindControlFindButton)
                return "Додати критерій пошуку";
            if (id == GridStringId.FindControlClearButton)
                return "Відмінити";
            if (id == GridStringId.CustomFilterDialogHint)
                return "Відмінити";
            return base.GetLocalizedString(id);
        }
    }

    #endregion
}