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
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using Ninject;

namespace ERP_NEW.GUI.Classifiers
{
    public partial class LogEditFm : DevExpress.XtraEditors.XtraForm
    {
       
        private List<LogDTO> log = new List<LogDTO>();

        private BindingSource logBS = new BindingSource();
        private BindingSource responsiblePersonBS = new BindingSource();
        private BindingSource tasksBS = new BindingSource();

        private Utils.Operation operation;
        private ILogService logService;
        private IEmployeesService employeesService;
        private IUserService userService;
        public LogEditFm(Utils.Operation operation, LogDTO model)
        {
            InitializeComponent();
            employeesService = Program.kernel.Get<IEmployeesService>();
            userService = Program.kernel.Get<IUserService>();
            logService = Program.kernel.Get<ILogService>();

            splashScreenManager.ShowWaitForm();
            this.operation = operation;
            logBS.DataSource = model;        
            nameGridLookUpEdit.DataBindings.Add("EditValue", logBS, "EmployeeId", true, DataSourceUpdateMode.OnPropertyChanged);
            modeGridLookUpEdit.DataBindings.Add("EditValue", logBS, "TaskId", true, DataSourceUpdateMode.OnPropertyChanged);
            dateEdit.DataBindings.Add("EditValue",logBS,"RecDate", true, DataSourceUpdateMode.OnPropertyChanged);
           
            //nameEdit.DataBindings.Add("EditValue", logBS, "EmployeeId", true, DataSourceUpdateMode.OnPropertyChanged);
            responsiblePersonBS.DataSource = employeesService.GetEmployeesWorking();
            nameGridLookUpEdit.Properties.DataSource = responsiblePersonBS;
            nameGridLookUpEdit.Properties.ValueMember = "EmployeeID";
            nameGridLookUpEdit.Properties.DisplayMember = "Fio";
            nameGridLookUpEdit.Properties.NullText = "Немае данних";
         


            tasksBS.DataSource = userService.GetTasksAll();
            modeGridLookUpEdit.Properties.DataSource = tasksBS;
            modeGridLookUpEdit.Properties.ValueMember = "TaskId";
            modeGridLookUpEdit.Properties.DisplayMember = "TaskCaption";
            modeGridLookUpEdit.Properties.NullText = "Немае данних";

           

        }
        private void SaveLog()//(Utils.Operation operation, LogDTO model)
        {
           
            logService = Program.kernel.Get<ILogService>();
            if (operation == Utils.Operation.Update)
            {
                logService.LogUpdate((LogDTO)logBS.Current);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            if (operation == Utils.Operation.Add)
            {
             
                logService.LogCreate((LogDTO)logBS.Current);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //logBS.DataSource = model;
            SaveLog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}