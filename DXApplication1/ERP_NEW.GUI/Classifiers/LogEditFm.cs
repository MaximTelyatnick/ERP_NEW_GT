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

namespace ERP_NEW.GUI.Classifiers
{
    public partial class LogEditFm : DevExpress.XtraEditors.XtraForm
    {
       
        private List<LogDTO> log = new List<LogDTO>();
        private BindingSource logBS = new BindingSource();
        private Utils.Operation operation;
        public LogEditFm(Utils.Operation operation, LogDTO model)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

        //    LoadData();

            this.operation = operation;

            logBS.DataSource  = model;
        }
    }
}