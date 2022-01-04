
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
using ERP_NEW.BLL.Infrastructure;
using Ninject;

namespace ERP_NEW.GUI.Classifiers
{
    public partial class LogFm : DevExpress.XtraEditors.XtraForm
    {
        private ILogService logService;
        private List<LogDTO> log = new List<LogDTO>();
        private BindingSource logBS = new BindingSource();
        private BindingSource employeeBS = new BindingSource();
        private UserTasksDTO _userTasksDTO;
        private EmployeesDetailsDTO employeesDetalDTO;
        private object logEditFm;
        public LogFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            _userTasksDTO = userTasksDTO;
            LoadDate();
        }
        private void LoadDate()
        {
            splashScreenManager.ShowWaitForm();
            logService = Program.kernel.Get<ILogService>();
            logBS.DataSource = logService.GetLogs();
            logGridControl.DataSource = logBS;
            splashScreenManager.CloseWaitForm();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Видалити користувача  " + ((LogDTO)logBS.Current).EmployeeName + "?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (logService.LogDelete(((LogDTO)logBS.Current).Id))
                {
                    logGridView.BeginUpdate();
                    LoadDate();
                    logGridView.EndUpdate();
                    logGridControl.Refresh();
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LogDTO model = ((LogDTO)logBS.Current);
            using (LogEditFm logEditFm = new LogEditFm(Utils.Operation.Add, model))
            {
                if (logEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    logGridView.BeginDataUpdate();
                    LoadDate();
                    logGridView.EndDataUpdate();
                }
            }
        }

        private void EditButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (logBS.Count > 0)
            {            
                LogDTO model = ((LogDTO)logBS.Current);              
                using (LogEditFm logEditFm = new LogEditFm(Utils.Operation.Update, model))
                {
                    if (logEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        logGridView.BeginDataUpdate();
                        LoadDate();
                        logGridView.EndDataUpdate();
                    }
                }
            }
        }
        private void editButton(Utils.Operation operation, LogDTO model)
        {
        

        }
    }
}