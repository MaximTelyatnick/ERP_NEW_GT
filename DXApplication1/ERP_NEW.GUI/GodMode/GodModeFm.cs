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
using DevExpress.XtraBars.Docking2010.Views.Tabbed;

namespace ERP_NEW.GUI.GodMode
{
    public partial class GodModeFm : DevExpress.XtraEditors.XtraForm
    {
        public GodModeFm()
        {
            InitializeComponent();

            documentManager.MdiParent = this;
            documentManager.View = new TabbedView();
        }

        

        private void employeesBtn_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            EmployeesDetailFm employeesDetail = new EmployeesDetailFm();
            employeesDetail.Text = "Співробітники ТОВ Техвагонмаш";
            employeesDetail.MdiParent = this;
            employeesDetail.Show();
        }

        private void parserBtn_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            ParserFm parser = new ParserFm();
            parser.Text = "Форма бездельника";
            parser.MdiParent = this;
            parser.Show();
        }
    }
}