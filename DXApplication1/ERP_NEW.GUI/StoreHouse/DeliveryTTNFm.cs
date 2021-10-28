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
using Ninject;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System.IO;
using DevExpress.XtraBars;
using System.Diagnostics;
using ERP_NEW.BLL.Infrastructure;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class DeliveryTTNFm : DevExpress.XtraEditors.XtraForm
    {
        private UserTasksDTO userTasksDTO;

        private IStoreHouseService deliveryService;

        private BindingSource deliveryTTNBS = new BindingSource();

        DateTime firstDay = new DateTime(DateTime.Now.Year, 1, 1);
        DateTime lastDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

        public ObjectBase Item
        {
            get { return deliveryTTNBS.Current as ObjectBase; }
            set
            {
                deliveryTTNBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public DeliveryTTNFm(UserTasksDTO userTasksDTO, DateTime? firstDate = null, DateTime? lastDate = null)
        {
            InitializeComponent();
            this.userTasksDTO = userTasksDTO;
            
            AuthorizatedUserAccess();


            if (firstDate != null && lastDate != null)
            {
                firstDateEdit.EditValue = firstDate.Value;
                lastDateEdit.EditValue = lastDate.Value;
            }
            else
            {
                firstDateEdit.EditValue = firstDay;
                lastDateEdit.EditValue = lastDay.AddMonths(1).AddDays(-1);

            }
            LoadTTN((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
        }

        #region Method's
        public void AuthorizatedUserAccess()
        {
            //2=write
            addBtn.Enabled = (userTasksDTO.AccessRightId == 2);           
            editBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteBtn.Enabled = (userTasksDTO.AccessRightId == 2);

        }
        private void LoadTTN(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            deliveryService = Program.kernel.Get<IStoreHouseService>();
            deliveryTTNBS.DataSource = deliveryService.GetDeliveryOrder(beginDate, endDate).OrderByDescending(date => date.OrderDate).ToList();
            deliveryTTNGrid.DataSource = deliveryTTNBS;

            splashScreenManager.CloseWaitForm();
        }

        public DeliveryOrderDTO Return()
        {
            DialogResult = DialogResult.OK;
            return (DeliveryOrderDTO)Item;
        }


        private void EditDelivery(Utils.Operation operation, DeliveryOrderDTO model)
        {
            using (DeliveryTTNEditFm deliveryTTNEditFm = new DeliveryTTNEditFm(operation, model))
            {
                if (deliveryTTNEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DeliveryOrderDTO return_Id = deliveryTTNEditFm.Return();

                    deliveryTTNGridView.BeginDataUpdate();

                    LoadTTN((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);

                    deliveryTTNGridView.EndDataUpdate();

                    int rowHandle = deliveryTTNGridView.LocateByValue("Id", return_Id.Id);

                    deliveryTTNGridView.FocusedRowHandle = rowHandle;
                 }
            }
        }

        private void DeleteDeliveryTTN()
        {
            if (deliveryTTNBS.Count != 0)
            {
                if (MessageBox.Show("Видалити запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    deliveryService = Program.kernel.Get<IStoreHouseService>();
                    int rowHandle = deliveryTTNGridView.FocusedRowHandle - 1;
                    if ((((DeliveryOrderDTO)deliveryTTNBS.Current).Id) != 0)
                    {
                        if (deliveryService.DeliveryOrderDelete(((DeliveryOrderDTO)deliveryTTNBS.Current).Id))
                        {                            
                            deliveryTTNGridView.BeginDataUpdate();
                            LoadTTN((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
                        }                
                    }
                    else
                    {
                        deliveryService.DeliveryOrderDelete(((DeliveryOrderDTO)deliveryTTNBS.Current).Id);
                    }

                    deliveryTTNGridView.EndDataUpdate();
                    deliveryTTNGridView.FocusedRowHandle = (deliveryTTNGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }
        #endregion

        #region Event's
        private void addBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            //DeliveryOrderDTO modelTTN = new DeliveryOrderDTO();
            //modelTTN.Id = ((DeliveryOrderDTO)deliveryTTNBS.Current).Id;

            EditDelivery(Utils.Operation.Add, new DeliveryOrderDTO());//, (DeliveryDTO)deliveryBS.Current);
        }        

        private void editBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditDelivery(Utils.Operation.Update, (DeliveryOrderDTO)deliveryTTNBS.Current);
        }
       
        private void deleteBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteDeliveryTTN();
        }       

        private void deliveryTTNGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0 && deliveryTTNBS.Count>0 && (e.Column.Name == "numberTTNCol" || e.Column.Name == "carrierCol" || e.Column.Name == "dateCol" || e.Column.Name == "sumaCol" || e.Column.Name == "typePaymentCol" || e.Column.Name == "numberCommingCol"))
            {
                var model = (DeliveryOrderDTO)deliveryTTNGridView.GetRow(e.RowHandle);

                if (model.DeliveryOrderId == null)        
                   e.Appearance.BackColor = Color.LightSalmon;
                else
                    e.Appearance.BackColor = Color.LightGreen;
            }        
        }

        private void showBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadTTN((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
        }

        private void deliveryTTNGridView_DoubleClick(object sender, EventArgs e)
        {
            Return();
        }

        private void exportBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            string path = "Журнал ТТН за період " + ((DateTime)firstDateEdit.EditValue).Date.ToShortDateString() + " по " + ((DateTime)lastDateEdit.EditValue).Date.ToShortDateString() + ".xls";
            deliveryTTNGrid.ExportToXls(path);
            Process.Start(path);
        }

        #endregion

    }
}