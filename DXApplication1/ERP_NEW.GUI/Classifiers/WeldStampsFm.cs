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
    public partial class WeldStampsFm : DevExpress.XtraEditors.XtraForm
    {
        public IWeldStampsService weldStampsService;

        public BindingSource weldStampsBS = new BindingSource();

        public UserTasksDTO _userTasksDTO;

        public WeldStampsFm(UserTasksDTO userTasksDTO)
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
            weldStampsBS.DataSource = weldStampsService.GetWeldStamps();
            weldStampsGrid.DataSource = weldStampsBS;
        }

        private void EditWeldStamps(Utils.Operation operation, WeldStampsDTO model)
        {
            using (WeldStampsEditFm weldStampsEditFm = new WeldStampsEditFm(operation, model))
            {
                if (weldStampsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int return_Id = weldStampsEditFm.Return();
                    weldStampsGridView.BeginDataUpdate();

                    weldStampsService = Program.kernel.Get<IWeldStampsService>();
                    weldStampsBS.DataSource = weldStampsService.GetWeldStamps();
                    weldStampsGrid.DataSource = weldStampsBS;

                    weldStampsGridView.EndDataUpdate();
                    int rowHandle = weldStampsGridView.LocateByValue("Id", return_Id);
                    weldStampsGridView.FocusedRowHandle = rowHandle;
                }
            }
        }
        
        #endregion

        private void addItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditWeldStamps(Utils.Operation.Add, new WeldStampsDTO());
        }

        private void editItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (weldStampsBS.Count != 0)
                EditWeldStamps(Utils.Operation.Update, (WeldStampsDTO)weldStampsBS.Current);
        }

        private void deleteItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (weldStampsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    weldStampsService = Program.kernel.Get<IWeldStampsService>();

                    if (weldStampsService.RemoveWeldStampsById(((WeldStampsDTO)weldStampsBS.Current).Id))
                        weldStampsBS.RemoveCurrent();
                }
            }
        }

        private void weldStampsGridView_DoubleClick(object sender, System.EventArgs e)
        {
            if (weldStampsBS.Count != 0)
                EditWeldStamps(Utils.Operation.Update, (WeldStampsDTO)weldStampsBS.Current);
        }
    }
}