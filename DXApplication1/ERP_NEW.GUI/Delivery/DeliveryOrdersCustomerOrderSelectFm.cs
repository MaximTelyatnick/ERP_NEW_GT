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
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_NEW.GUI.Delivery
{
    public partial class DeliveryOrdersCustomerOrderSelectFm : DevExpress.XtraEditors.XtraForm
    {
        private ICustomerOrdersService customerOrdersService;

        private List<CustomerOrdersDTO> returnCustomerOrdersList = new List<CustomerOrdersDTO>();
        private BindingSource customersOrdersBS = new BindingSource();

        /*
          bool siInvoices = false - при использовании формы для выбора проэктов для прикрепления к приходу (DeliveryOrdersEditFm)
          bool siInvoices = true - при использовании формы для выбора проэктов для прикрепления к приходу (DeliveryOrdersEditFm) 
         */

        public DeliveryOrdersCustomerOrderSelectFm(int[] mas, bool isInvoices = false)
        {
            InitializeComponent();

            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();

            List<CustomerOrdersDTO> customerOrdersList = customerOrdersService.GetCustomerOrders().ToList();
            //var rez = customerOrdersService.GetCustomerOrdersFull().Where(name => mas.All(search => !name.Id.Equals(search))).OrderByDescending(bdsm => bdsm.OrderDate).ToList();
            var rez = customerOrdersService.GetCustomerOrdersFullWithReceipt().Where(name => mas.All(search => !name.Id.Equals(search))).OrderByDescending(bdsm => bdsm.OrderDate).ToList();

            customersOrdersBS.DataSource = rez;// rez;
            deliveryOrderCustomerGrid.DataSource = customersOrdersBS;

            if (isInvoices)
                deliveryOrderCustomerGridView.Columns[3].Visible = false;
            else
                deliveryOrderCustomerGridView.Columns[3].Visible = true;

            deliveryOrderCustomerGridView.ExpandAllGroups();
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
            deliveryOrderCustomerGridView.PostEditor();

            returnCustomerOrdersList = ((List<CustomerOrdersDTO>)customersOrdersBS.DataSource).Where(s => s.Selected).ToList();
            if (returnCustomerOrdersList.Count > 0)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }

            else { MessageBox.Show("Не вибрано заказ!"); }
        }

        private void deliveryOrderCustomerGridView_CellMerge(object sender, CellMergeEventArgs e)
        {
            GridView view = sender as GridView;
            CustomerOrdersDTO model1 = (CustomerOrdersDTO)view.GetRow(e.RowHandle1);
            CustomerOrdersDTO model2 = (CustomerOrdersDTO)view.GetRow(e.RowHandle2);

            //if (e.Column.FieldName != "Quantity" && e.Column.FieldName != "CustomerOrderPrice" && e.Column.FieldName != "CustomerOrderCurrencyPrice")
            //{
            //    e.Merge = (model1.Id == model2.Id);
            //    e.Handled = true;
            //}

            if (e.Column.FieldName != "Quantity" && e.Column.FieldName != "ReceiptNum" && e.Column.FieldName != "Nomenclature" && e.Column.FieldName != "NomenclatureName" && e.Column.FieldName != "TotalPrice" && e.Column.FieldName != "UnitLocalName")
            {
                e.Merge = (model1.Id == model2.Id);
                e.Handled = true;
            }
        }

        private void deliveryOrderCustomerGridView_DoubleClick(object sender, EventArgs e)
        {
            deliveryOrderCustomerGridView.PostEditor();

            returnCustomerOrdersList.Add((CustomerOrdersDTO)customersOrdersBS.Current);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        //private void deliveryOrderCustomerGridView_DoubleClick(object sender, EventArgs e)
        //{
        //    deliveryOrderCustomerGridView.PostEditor();

        //    returnCustomerOrdersList.Add((CustomerOrdersDTO)customersOrdersBS.Current);

        //    DialogResult = DialogResult.OK;
        //    this.Close();
        //}

        //private void deliveryOrderCustomerGridView_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        //{
        //    //if (e.Column.FieldName == "OrderNumber")
        //    //{
        //    //    string groupNum1 = deliveryOrderCustomerGridView.GetRowCellValue(e.RowHandle1, e.Column).ToString();
        //    //    string groupNum2 = deliveryOrderCustomerGridView.GetRowCellValue(e.RowHandle2, e.Column).ToString();
        //    //    e.Merge = (groupNum1 == groupNum2);
        //    //    e.Handled = true;
        //    //    return;
        //    //}

        //    GridView view = sender as GridView;
        //    CustomerOrdersDTO model1 = (CustomerOrdersDTO)view.GetRow(e.RowHandle1);
        //    CustomerOrdersDTO model2 = (CustomerOrdersDTO)view.GetRow(e.RowHandle2);

        //    //if (e.Column.FieldName != "Quantity" && e.Column.FieldName != "CustomerOrderPrice" && e.Column.FieldName != "CustomerOrderCurrencyPrice")
        //    //{
        //    //    e.Merge = (model1.Id == model2.Id);
        //    //    e.Handled = true;
        //    //}

        //    if (e.Column.FieldName != "Quantity")
        //    {
        //        e.Merge = (model1.Id == model2.Id);
        //        e.Handled = true;
        //    }
        //}
    }
}