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

namespace ERP_NEW.GUI.Classifiers
{
    public partial class InfoFormFm : DevExpress.XtraEditors.XtraForm
    {
        int rezForm = 0;
        public  InfoFormFm()
        {
            InitializeComponent();        
        }

        public int returnRez()
        {
            return rezForm;
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            this.Close();

            MessageBox.Show("Змінювати кольори в документі ЗАБОРОНЕНО! ", "               Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          
                rezForm = 1;
           
        }

    }
}