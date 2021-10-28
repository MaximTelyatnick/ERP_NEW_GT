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
using Ninject;

using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Services;
using ERP_NEW.BLL.DTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraEditors.Controls;
using ERP_NEW.BLL.Infrastructure;
using DevExpress.XtraEditors.Repository;

namespace ERP_NEW.GUI.Marketing
{
    public partial class ShipmentListsFm : DevExpress.XtraEditors.XtraForm
    {
        private IShipmentListsService shipmentListsService;
        private BindingSource shipmentListsBS = new BindingSource();
        private UserTasksDTO _userTasksDTO;

        public ShipmentListsFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            _userTasksDTO = userTasksDTO;

            splashScreenManager.ShowWaitForm();
            beginDateEditItem.EditValue = new DateTime(DateTime.Now.Year, 1, 1);
            endDateEditItem.EditValue = DateTime.Now;

            LoadData((DateTime)beginDateEditItem.EditValue, (DateTime)endDateEditItem.EditValue);
            AuthorizatedUserAccess();
            splashScreenManager.CloseWaitForm();
        }
        
        #region Method's
        
        private void LoadData(DateTime beginDate, DateTime endDate)
        {
            shipmentListsService = Program.kernel.Get<IShipmentListsService>();

            var shipmentLists = shipmentListsService.GetShipmentLists(beginDate, endDate);
            shipmentListsBS.DataSource = shipmentLists;
            shipmentListsGrid.DataSource = shipmentListsBS;
            
            shipmentListsGrid.Focus();
        }

        public void AuthorizatedUserAccess()
        {
            addActBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editActBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteActBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
        }

        #endregion

        #region Event's

        private void shipmentListsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column == informationCol && e.IsGetData)
            {
                int flag = ((ShipmentListsDTO)shipmentListsBS[e.ListSourceRowIndex]).ScanPersence;
                if (flag == 1)
                {
                    flag = 0;
                    e.Value = columnCollection.Images[flag];
                }
            }
        }

        private void showItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData((DateTime)beginDateEditItem.EditValue, (DateTime)endDateEditItem.EditValue);
        }

        private void addActBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShipmentListEditFm shipmentListEditFm = new ShipmentListEditFm(Utils.Operation.Add, new ShipmentListsDTO());

            if (shipmentListEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int return_Id = shipmentListEditFm.Return();
                
                shipmentListsGridView.BeginDataUpdate();
                LoadData((DateTime)beginDateEditItem.EditValue, (DateTime)endDateEditItem.EditValue);
                shipmentListsGridView.EndDataUpdate();
                
                int rowHandle = shipmentListsGridView.LocateByValue("ShipmentListId", return_Id);
                shipmentListsGridView.FocusedRowHandle = rowHandle;
            }
        }

        private void editActBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (shipmentListsBS.Count > 0)
            {
                ShipmentListEditFm shipmentListEditFm = new ShipmentListEditFm(Utils.Operation.Update, (ShipmentListsDTO)shipmentListsBS.Current);

                if (shipmentListEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int return_Id = shipmentListEditFm.Return();
                    
                    shipmentListsGridView.BeginDataUpdate();
                    LoadData((DateTime)beginDateEditItem.EditValue, (DateTime)endDateEditItem.EditValue);
                    shipmentListsGridView.EndDataUpdate();
                    
                    int rowHandle = shipmentListsGridView.LocateByValue("ShipmentListId", return_Id);
                    shipmentListsGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void deleteActBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (shipmentListsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити документ?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (this.shipmentListsService.RemoveShipmentListById(((ShipmentListsDTO)shipmentListsBS.Current).ShipmentListId))
                    {
                        shipmentListsBS.RemoveCurrent();
                        shipmentListsGridView.Focus();
                    }
                }
            }
        }

        private void showBtnRepository_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (((ShipmentListsDTO)shipmentListsBS.Current).ScanPersence == 1)
            {
                string fileName = ((ShipmentListsDTO)shipmentListsBS.Current).FileName;
                int id = ((ShipmentListsDTO)shipmentListsBS.Current).ShipmentListId;
                byte[] scan = ((ShipmentListsDTO)shipmentListsBS.Current).ShipmentScan;
                string puth = Utils.HomePath + @"\Temp\";

                System.IO.File.WriteAllBytes(puth + fileName, scan);

                System.Diagnostics.Process.Start(puth + fileName);
            }
        }

        private void shipmentListsGridView_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (shipmentListsBS.Count > 0)
            {
                if (e.Column == informationCol)
                {
                    bool status = (Convert.ToInt32(shipmentListsGridView.GetRowCellValue(e.RowHandle, "ScanPersence")) == 0);

                    if (status)
                    {
                        RepositoryItemButtonEdit ritem = new RepositoryItemButtonEdit();
                        ritem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
                        ritem.ReadOnly = true;
                        ritem.Buttons[0].Enabled = false;
                        e.RepositoryItem = ritem;
                    }
                }
            }
        }

        private void refreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int return_Id = ((ShipmentListsDTO)shipmentListsBS.Current).ShipmentListId;

            shipmentListsGridView.BeginDataUpdate();
            LoadData((DateTime)beginDateEditItem.EditValue, (DateTime)endDateEditItem.EditValue);
            shipmentListsGridView.EndDataUpdate();

            int rowHandle = shipmentListsGridView.LocateByValue("ShipmentListId", return_Id);
            shipmentListsGridView.FocusedRowHandle = rowHandle;
        }

        #endregion
    }
}