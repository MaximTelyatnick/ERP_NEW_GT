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

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class DeliveryOrganisationFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        
        private BindingSource deliveryNameBS = new BindingSource();

        public DeliveryOrganisationFm()
        {
            InitializeComponent();

            LoadData();
        }


        

        //private List<InvoiceRequirementExpenditureInfoDTO> returnInvoiceRequirementExpenditureList = new List<InvoiceRequirementExpenditureInfoDTO>();

       

        private void LoadData()
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            deliveryNameBS.DataSource = storeHouseService.GetAllDelivery();
            deliveryGrid.DataSource = deliveryNameBS;
        }
    }
}