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

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class BusinessTripsCustomerOrdersSelectFm : DevExpress.XtraEditors.XtraForm
    {
        private ICustomerOrdersService customerOrdersService;

        private List<CustomerOrdersDTO> returnCustomerOrdersList = new List<CustomerOrdersDTO>();
        private BindingSource customersOrdersBS = new BindingSource();


        public BusinessTripsCustomerOrdersSelectFm(int[] mas)
        {
            InitializeComponent();

            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();

            List<BusinessTripsOrderCustDTO> tripOrder = new List<BusinessTripsOrderCustDTO>();//1 big form
  
            List<CustomerOrdersDTO> customOrder = customerOrdersService.GetCustomerOrders().ToList();

            var rez = customerOrdersService.GetCustomerOrdersFull().Where(name => mas.All(search => !name.Id.Equals(search))).OrderByDescending(bdsm => bdsm.OrderDate).ToList();

            customersOrdersBS.DataSource = rez;
            businessTripsOrdersGrid.DataSource = customersOrdersBS;

        }

        public List<CustomerOrdersDTO> Return()
        {
            return returnCustomerOrdersList;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            businessTripsOrdersGridView.PostEditor();


            returnCustomerOrdersList = ((List<CustomerOrdersDTO>)customersOrdersBS.DataSource).Where(s => s.Selected).ToList();
            if (returnCustomerOrdersList.Count > 0)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }

            else { MessageBox.Show("Оберіть будь ласка заказ!"); }


                
        }

    }
}