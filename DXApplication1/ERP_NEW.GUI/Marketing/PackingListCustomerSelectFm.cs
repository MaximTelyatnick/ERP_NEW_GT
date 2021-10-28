using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using Ninject;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;

namespace ERP_NEW.GUI.Marketing
{
    public partial class PackingListCustomerSelectFm : DevExpress.XtraEditors.XtraForm
    {
        private IMtsSpecificationsService mtsSpecificationsService;
        private ICustomerOrdersService customerOrdersService;

        private List<CustomerOrdersDTO> returnAsemblieList = new List<CustomerOrdersDTO>();

        List<MtsAssembliesInfoDTO> sortCustomerOrdersList = new List<MtsAssembliesInfoDTO>();

        private BindingSource assembliesBS = new BindingSource();
        private BindingSource customerOrdersSpecBS = new BindingSource();

        public PackingListCustomerSelectFm()
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();

            List<CustomerOrdersDTO> customOrder = customerOrdersService.GetCustomerOrdersFull().OrderByDescending(ord => ord.OrderDate).ToList();

            //var rez = mtsSpecificationsService.GetJournalAssemblies().OrderByDescending(bdsm => bdsm.DateCreated).ToList();

            assembliesBS.DataSource = customOrder;

            customerOrdersGrid.DataSource = assembliesBS; 



            splashScreenManager.CloseWaitForm();

        }

        #region Method's

        public List<CustomerOrdersDTO> Return()
        {
            return returnAsemblieList;
        }

        public void LoadCustomerOrderSpecificationsData(int customerOrderId)
        {
            //customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            //customerOrdersSpecBS.DataSource = customerOrdersService.GetCustomerOrderSpecificationsByOrderId(customerOrderId);
            //specificationGrid.DataSource = customerOrdersSpecBS;

        }
        
        #endregion

        #region Event's

        private void saveBtn_Click(object sender, EventArgs e)
        {
            customerOrdersGridView.PostEditor();

            returnAsemblieList = ((List<CustomerOrdersDTO>)assembliesBS.DataSource).Where(s => s.Selected).ToList();

            DialogResult = DialogResult.OK;
            this.Close();
        }



        private void customerOrdersGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //if (assembliesBS.Count > 0)
            //{
            //    if (((MtsAssembliesInfoDTO)assembliesBS.Current).CustomerOrderId.HasValue)
            //        LoadCustomerOrderSpecificationsData(((MtsAssembliesInfoDTO)assembliesBS.Current).CustomerOrderId.GetValueOrDefault());
            //    else
            //        specificationGrid.DataSource = null;
            //}
            //else
            //{
            //    specificationGrid.DataSource = null;
            //}
        }

        #endregion

       
    }
}