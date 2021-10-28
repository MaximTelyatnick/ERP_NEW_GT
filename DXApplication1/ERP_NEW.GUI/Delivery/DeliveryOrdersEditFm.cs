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
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using Ninject;

namespace ERP_NEW.GUI.Delivery
{
    public partial class DeliveryOrdersEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IDeliveryService deliveryService;

        private BindingSource deliveryOrdersBS = new BindingSource();
        private BindingSource receiptDetailsBS = new BindingSource();

        private List<DeliveryOrdersDTO> deliveryOrdersList = new List<DeliveryOrdersDTO>();
        private List<DeliveryOrdersDTO> deleteDeliveryOrdersList = new List<DeliveryOrdersDTO>();
        private List<ReceiptDetailsDTO> receiptDetailsList = new List<ReceiptDetailsDTO>();
        private List<ReceiptDetailsDTO> deleteReceiptDetailsList = new List<ReceiptDetailsDTO>();

        private Utils.Operation operation;

        public DeliveryOrdersEditFm(Utils.Operation operation, List<DeliveryOrdersDTO> deliveryOrdersList)
        {
            InitializeComponent();

            this.operation = operation;
            this.deliveryOrdersList = deliveryOrdersList;

            deliveryOrdersBS.DataSource = deliveryOrdersList;
            deliveryOrderGrid.DataSource = deliveryOrdersBS;

            switch (operation)
            {
                case Utils.Operation.Add:

                    break;

                case Utils.Operation.Update:

                    deliveryService = Program.kernel.Get<IDeliveryService>();

                    receiptDetailsList = deliveryService.GetReceiptDetails(deliveryOrdersList[0].ReceiptID).ToList();
                    receiptDetailsBS.DataSource = receiptDetailsList;
                    customerOrdersGrid.DataSource = receiptDetailsBS;

                    deleteReceiptBtn.Enabled = false;

                    break;

                default:
                    MessageBox.Show("При завантаженні форми " + this.Text + " виникла помилка. ", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        #region Method's                

        public List<DeliveryOrdersDTO> Return()
        {
            return deliveryOrdersList;
        }

        private bool SaveItem()
        {
            try
            {
                if (operation == Utils.Operation.Add)
                {
                    deliveryService = Program.kernel.Get<IDeliveryService>();

                    if (deleteReceiptDetailsList.Count > 0)
                        deliveryService.ReceiptDetailsRemoveRange(deleteReceiptDetailsList);

                    List<ReceiptDetailsDTO> addReceiptDetailsList = new List<ReceiptDetailsDTO>();
                    receiptDetailsList = ((List<ReceiptDetailsDTO>)receiptDetailsBS.DataSource);

                    foreach (var itemDeliveryOrder in deliveryOrdersList)
                    {
                        foreach (var itemReceiptDetails in receiptDetailsList)
                        {
                            ReceiptDetailsDTO addReceiptDetailsDTO = new ReceiptDetailsDTO()
                            {
                                CustomerOrderId = itemReceiptDetails.CustomerOrderId,
                                ReceiptId = itemDeliveryOrder.ReceiptID
                            };
                            addReceiptDetailsList.Add(addReceiptDetailsDTO);
                        }
                    }

                    foreach (var item in addReceiptDetailsList)
                        deliveryService.ReceiptDetailsCreate(item);
                }
                else
                {
                    if (deleteReceiptDetailsList.Count > 0)
                        deliveryService.ReceiptDetailsRemoveRange(deleteReceiptDetailsList);

                    List<ReceiptDetailsDTO> addReceiptDetailsList = new List<ReceiptDetailsDTO>();
                    receiptDetailsList = ((List<ReceiptDetailsDTO>)receiptDetailsBS.DataSource).Where(bdsm => bdsm.Id == 0).ToList();

                    foreach (var itemDeliveryOrder in deliveryOrdersList)
                    {
                        foreach (var itemReceiptDetails in receiptDetailsList)
                        {
                            ReceiptDetailsDTO addReceiptDetailsDTO = new ReceiptDetailsDTO()
                            {
                                CustomerOrderId = itemReceiptDetails.CustomerOrderId,
                                ReceiptId = itemDeliveryOrder.ReceiptID
                            };

                            deliveryService.ReceiptDetailsCreate(addReceiptDetailsDTO);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #endregion

        #region Event's                 

        private void addCustomerOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] massiv = receiptDetailsList.Select(bdsm => bdsm.CustomerOrderId).ToArray();

            using (DeliveryOrdersCustomerOrderSelectFm deliveryOrdersCustomerOrderSelectFm = new DeliveryOrdersCustomerOrderSelectFm(massiv))
            {
                if (deliveryOrdersCustomerOrderSelectFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var returnList = deliveryOrdersCustomerOrderSelectFm.Return();

                    customerOrdersGridView.PostEditor();
                    customerOrdersGridView.BeginDataUpdate();

                    var saveItems = returnList.Select(s => new ReceiptDetailsDTO()
                    {
                        Id = 0,
                        CustomerOrderId = s.Id,
                        ContractorName = s.ContractorName,
                        CustomerOrderNumber = s.OrderNumber,
                        Drawing = s.Drawing
                    });

                    receiptDetailsList.AddRange(saveItems);
                    receiptDetailsBS.DataSource = receiptDetailsList;
                    customerOrdersGrid.DataSource = receiptDetailsBS;

                    customerOrdersGridView.EndDataUpdate();
                }
            }
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

        private void deleteCustomerOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (receiptDetailsBS.Count == 0)
                return;

            customerOrdersGridView.PostEditor();
            customerOrdersGridView.BeginDataUpdate();

            List<ReceiptDetailsDTO> customerOrdersBufferList = (List<ReceiptDetailsDTO>)receiptDetailsBS.DataSource;
            var checkItems = customerOrdersBufferList.Where(t => t.Selected && t.Id != 0);
            deleteReceiptDetailsList.AddRange(checkItems);
            customerOrdersBufferList.RemoveAll(s => s.Selected);
            receiptDetailsBS.DataSource = customerOrdersBufferList;

            customerOrdersGridView.EndDataUpdate();
        }

        private void deleteReceiptBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (deliveryOrdersList.Count(s => s.Selected) == deliveryOrdersList.Count)
            {
                MessageBox.Show("Не можливо видалити всі рядки.", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                deliveryOrderGridView.EndDataUpdate();
                return;
            }

            deliveryOrderGridView.PostEditor();
            deliveryOrderGridView.BeginDataUpdate();

            deliveryOrdersList.RemoveAll(s => s.Selected);
            receiptDetailsBS.DataSource = deliveryOrdersList;

            if (deliveryOrdersList.Count == 0)
                saveBtn.Enabled = false;
            else
                saveBtn.Enabled = true;

            deliveryOrderGridView.EndDataUpdate();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        private void DeliveryOrdersEditFm_Load(object sender, EventArgs e)
        {

        }
    }
}