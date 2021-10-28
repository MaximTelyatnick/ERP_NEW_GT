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

namespace ERP_NEW.GUI.MTS
{
    public partial class MtsSpecificationOldSelectFm : DevExpress.XtraEditors.XtraForm
    {

        private List<MTSSpecificationsDTO> mtsSpecificationsList = new List<MTSSpecificationsDTO>();
        private IMtsSpecificationsService mtsService;
        private BindingSource specificBS = new BindingSource();

        public MtsSpecificationOldSelectFm()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            mtsService = Program.kernel.Get<IMtsSpecificationsService>();
            specificBS.DataSource = mtsService.GetAllSpecificationOld();
            specificGrid.DataSource = specificBS;
        }

        public List<MTSSpecificationsDTO> Return()
        {
            return mtsSpecificationsList;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            specificGridView.PostEditor();


            mtsSpecificationsList = ((List<MTSSpecificationsDTO>)specificBS.DataSource).Where(s => s.Selected).ToList();
            if (mtsSpecificationsList.Count > 0)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }

            else { MessageBox.Show("Оберіть будь ласка заказ!"); }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}