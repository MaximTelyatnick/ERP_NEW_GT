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
using ERP_NEW.BLL.DTO.SelectedDTO;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class StoreHouseJournalFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IReportService reportService;

        private BindingSource accountClothesJournalBS = new BindingSource();

        private UserTasksDTO _userTasksDTO;


        public StoreHouseJournalFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            _userTasksDTO = userTasksDTO;

            DateTime firstDay = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime lastDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            startDateEdit.EditValue = firstDay;
            lastDateEdit.EditValue = lastDay.AddMonths(1).AddDays(-1);
            selectDateEdit.EditValue = 0;
            

            AuthorizatedUserAccess();
            LoadDataAccountClothesJournal((DateTime)startDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
            
        }

        private void LoadDataAccountClothesJournal(DateTime beginDate, DateTime endDate)
        {

            splashScreenManager.ShowWaitForm();
            
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            
            switch ((int)selectDateEdit.EditValue)
            {
                case 0:
                    //accountClothesJournalBS.DataSource = storeHouseService.GetAccountClothesByCard(beginDate, endDate);
                    accountClothesJournalBS.DataSource = storeHouseService.GetAccountClothesByCardProc(beginDate, endDate);

                    accountsClothesMaterialsGrid.DataSource = accountClothesJournalBS;
                    writeActWriteOffMaterialsBtn.Enabled = false;
                    break;

                case 1:
                    //accountClothesJournalBS.DataSource = storeHouseService.GetAccountClothesByDateOutput(beginDate, endDate);

                    accountClothesJournalBS.DataSource = storeHouseService.GetAccountClothByDateOutputProc(beginDate, endDate);
                    accountsClothesMaterialsGrid.DataSource = accountClothesJournalBS;
                    writeActWriteOffMaterialsBtn.Enabled = false;
                    break;

                case 2:
                    //accountClothesJournalBS.DataSource = storeHouseService.GetAccountClothesByDateReturn(beginDate, endDate);
                    accountClothesJournalBS.DataSource = storeHouseService.GetAccountClothByDateReturnProc(beginDate, endDate);
                    accountsClothesMaterialsGrid.DataSource = accountClothesJournalBS;
                    writeActWriteOffMaterialsBtn.Enabled = true;
                    break;

                default:
                    MessageBox.Show("Не вірні параметри виклику!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            splashScreenManager.CloseWaitForm();
        }

        private void AuthorizatedUserAccess()
        {
            selectDateEdit.Enabled = (_userTasksDTO.AccessRightId == 2);
            startDateEdit.Enabled = (_userTasksDTO.AccessRightId == 2);
            showBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            writeAccountClothesBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            writeActWriteOffMaterialsBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
        }



        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDataAccountClothesJournal((DateTime)startDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);    
        }

        private void writeAccountClothesBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (accountClothesJournalBS.Count > 0)
            {
                reportService = Program.kernel.Get<IReportService>();

                reportService.PrintAccountClothesJournalCard((List<AccountClothesJournalDTO>)accountClothesJournalBS.DataSource, (DateTime)startDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
            }
        }

        private void writeActWriteOffMaterialsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (accountClothesJournalBS.Count > 0)
            {
                reportService = Program.kernel.Get<IReportService>();

                reportService.PrintAccountClothesJournalWriteOff((List<AccountClothesJournalDTO>)accountClothesJournalBS.DataSource, (DateTime)startDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
            }
        }

        private void selectDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataAccountClothesJournal((DateTime)startDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
        }
    }
}