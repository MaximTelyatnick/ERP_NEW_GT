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
using ERP_NEW.BLL.Infrastructure;


namespace ERP_NEW.GUI.Classifiers
{
    public partial class WeldWpsFm : DevExpress.XtraEditors.XtraForm
    {
        public IWeldStampsService weldStampsService;
        
        public BindingSource weldWpsBS = new BindingSource();

        public UserTasksDTO _userTasksDTO;

        public WeldWpsFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            _userTasksDTO = userTasksDTO;

            AuthorizatedUserAccess();

            splashScreenManager.ShowWaitForm();

            LoadData();

            splashScreenManager.CloseWaitForm();
        }

        #region Method's

        public void AuthorizatedUserAccess()
        {
            addItem.Enabled = (_userTasksDTO.AccessRightId == 2);
            editItem.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteItem.Enabled = (_userTasksDTO.AccessRightId == 2);
        }

        private void LoadData()
        {
            weldStampsService = Program.kernel.Get<IWeldStampsService>();
            weldWpsBS.DataSource = weldStampsService.GetWeldWps();
            weldWpsGrid.DataSource = weldWpsBS;
        }

        private void EditWeldWps(Utils.Operation operation, WeldWpsDTO model)
        {
            using (WeldWpsEditFm weldWpsEditFm = new WeldWpsEditFm(operation, model))
            {
                if (weldWpsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int return_Id = weldWpsEditFm.Return();
                    weldWpsGridView.BeginDataUpdate();

                    weldStampsService = Program.kernel.Get<IWeldStampsService>();
                    weldWpsBS.DataSource = weldStampsService.GetWeldWps();
                    weldWpsGrid.DataSource = weldWpsBS;

                    weldWpsGridView.EndDataUpdate();
                    int rowHandle = weldWpsGridView.LocateByValue("Id", return_Id);
                    weldWpsGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        #endregion

        #region Event's

        private void addItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditWeldWps(Utils.Operation.Add, new WeldWpsDTO());
        }

        private void editItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (weldWpsBS.Count != 0)
                EditWeldWps(Utils.Operation.Update, (WeldWpsDTO)weldWpsBS.Current);
        }

        private void deleteItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (weldWpsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    weldStampsService = Program.kernel.Get<IWeldStampsService>();

                    weldWpsGridView.BeginDataUpdate();

                    if (weldStampsService.RemoveWeldWpsById(((WeldWpsDTO)weldWpsBS.Current).Id))
                        weldWpsBS.RemoveCurrent();

                    weldWpsGridView.EndDataUpdate();
                }
            }
        }
        
        private void weldWpsGridView_DoubleClick(object sender, System.EventArgs e)
        {
            if (weldWpsBS.Count != 0)
                EditWeldWps(Utils.Operation.Update, (WeldWpsDTO)weldWpsBS.Current);
        }
        
        #endregion
    }
}