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
using ERP_NEW.BLL.Services;
using ERP_NEW.BLL.DTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraEditors.Controls;
using Ninject;
using System.Web;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class BusinessTripsSelectFm : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource businessTripsBS = new BindingSource();

        private List<BusinessTripsJournalDTO> returnTripList = new List<BusinessTripsJournalDTO>();
                        
        public BusinessTripsSelectFm(List<BusinessTripsJournalDTO> source)
        {
            InitializeComponent();

            businessTripsBS.DataSource = source;
            businessTripsGrid.DataSource = businessTripsBS;
        }

        public List<BusinessTripsJournalDTO> Return()
        {
            return returnTripList;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            businessTripsGridView.PostEditor();

            returnTripList = ((List<BusinessTripsJournalDTO>)businessTripsBS.DataSource).Where(s => s.Selection).ToList();
            
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
                
    }
}