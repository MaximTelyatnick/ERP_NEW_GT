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
using ERP_NEW.BLL.DTO.SelectedDTO;
using Ninject;
using ERP_NEW.BLL.Services;
using System.IO;
using DevExpress.XtraEditors.Repository;

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class BusinessTripsCustomerOrderEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IBusinessTripsService businessTripsService;
        private ICustomerOrdersService customerOrdersService;

        private BindingSource businessTripsCustomerOrdersBS = new BindingSource();
        private List<BusinessTripsOrderCustDTO> businessTripsCustOrderList = new List<BusinessTripsOrderCustDTO>();
        private List<BusinessTripsOrderCustDTO> deleteBusinesTripsOrderCustList = new List<BusinessTripsOrderCustDTO>();
        private BusinessTripsDTO model;
        private UserTasksDTO userTasksDTO;

        //private ObjectBase Item
        //{
        //    get { return businessTripsBS.Current as ObjectBase; }
        //    set
        //    {
        //        businessTripsBS.DataSource = value;
        //        value.BeginEdit();
        //    }
        //}

        public BusinessTripsCustomerOrderEditFm(BusinessTripsDTO model, UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            this.model = model;

            this.userTasksDTO = userTasksDTO;

            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();


            businessTripsCustOrderList = businessTripsService.GetBusinessOrderCustByBTId(model.ID).ToList();
            businessTripsCustomerOrdersBS.DataSource = businessTripsCustOrderList;
            businessTripsOrdersGrid.DataSource = businessTripsCustomerOrdersBS;



            //businessTripsBS.DataSource = Item = model;

            //customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();

            //customerOrdersEdit.DataBindings.Add("EditValue", businessTripsBS, "CustomerOrderId", true, DataSourceUpdateMode.OnPropertyChanged);
            //customerOrdersEdit.Properties.DataSource = customerOrdersService.GetCustomerOrdersFull();
            //customerOrdersEdit.Properties.ValueMember = "Id";
            //customerOrdersEdit.Properties.DisplayMember = "OrderNumber";
            //customerOrdersEdit.Properties.NullText = "Немає данних";
        }

        public BusinessTripsDTO Return()
        {
            return model;
        }



        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    if (SaveItem())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //this.Item.CancelEdit();
            //DialogResult = DialogResult.Cancel;
            //this.Close();
        }

        private void customerOrdersEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (e.Button.Index == 1)
            //{
            //    customerOrdersEdit.EditValue = null;
            //    customerOrdersEdit.Properties.NullText = "Немає данних";
            //}
        }

        private void customerOrdersEdit_Popup(object sender, EventArgs e)
        {
            GridLookUpEdit editor = (GridLookUpEdit)sender;
            RepositoryItemGridLookUpEdit properties = editor.Properties;
            properties.PopupFormSize = new Size(editor.Width - 4, properties.PopupFormSize.Height);
        }

        private void businessTripsOrdersGrid_Click(object sender, EventArgs e)
        {

        }

        private bool SaveItem()
        {

           

            try
            {

                if (deleteBusinesTripsOrderCustList.Count > 0)
                {
                    businessTripsService = Program.kernel.Get<IBusinessTripsService>();
                    businessTripsService.BusinessTripsOrderCustRemoveRange(deleteBusinesTripsOrderCustList);
                }

                businessTripsCustOrderList = ((List<BusinessTripsOrderCustDTO>)businessTripsCustomerOrdersBS.DataSource);


                var items = businessTripsCustOrderList.Where(bdsm => bdsm.ID == 0);

                foreach (var item in items)
                    businessTripsService.BusinessTripsOrderCustCreate(item);
                




            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }




        private void addOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] massiv = businessTripsCustOrderList.Select(bdsm=>bdsm.CustomerOrderId).ToArray();

            using (BusinessTripsCustomerOrdersSelectFm businessTripsCustomerOrderSelectFm = new BusinessTripsCustomerOrdersSelectFm(massiv))
            {
                if (businessTripsCustomerOrderSelectFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                 {
                    var returnList = businessTripsCustomerOrderSelectFm.Return();

                    businessTripsOrdersGridView.BeginDataUpdate();

                    //customersOrderList.AddRange(returnList.Select(s => { s.Selected = false; return s; }));

                    var saveItems = returnList.Select(s => new BusinessTripsOrderCustDTO()
                    {   
                        ID = 0,
                        BusinessTripsId = model.ID,
                        CustomerOrderId = s.Id,
                        ContractorName = s.ContractorName,
                        OrderDate = s.OrderDate,
                        OrderNumber = s.OrderNumber,
                        Selected = false,
                        UserId = userTasksDTO.UserId
                    });


                    businessTripsCustOrderList.AddRange(saveItems);

                    //customersOrderList.AddRange(returnList.SelectMany(s => new List<BusinessTripsOrderCustDTO>()
                    //    {
                            
                    //    }));

                    businessTripsCustomerOrdersBS.DataSource = businessTripsCustOrderList;
                    businessTripsOrdersGrid.DataSource = businessTripsCustomerOrdersBS;

                    businessTripsOrdersGridView.EndDataUpdate();
                 }
            }
        }

        private void deleteOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            businessTripsOrdersGridView.PostEditor();

            businessTripsOrdersGridView.BeginDataUpdate();

            List<BusinessTripsOrderCustDTO> businesstripsOrderCustBufferList = (List<BusinessTripsOrderCustDTO>)businessTripsCustomerOrdersBS.DataSource;

            var checkItems = businesstripsOrderCustBufferList.Where(t => t.Selected && t.ID != 0);


            deleteBusinesTripsOrderCustList.AddRange(checkItems);
            businesstripsOrderCustBufferList.RemoveAll(s => s.Selected);

            businessTripsCustomerOrdersBS.DataSource = businesstripsOrderCustBufferList;

            businessTripsOrdersGridView.EndDataUpdate();
        }
    
    }
}