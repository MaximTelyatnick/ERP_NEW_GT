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
using System;
using System.Diagnostics;
using ERP_NEW.BLL.Infrastructure;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace ERP_NEW.GUI.Classifiers
{
    public partial class CitiesFm : DevExpress.XtraEditors.XtraForm
    {
        private ICityService cityService;
        private BindingSource cityBS = new BindingSource();
        private UserTasksDTO _userTasksDTO;

        public CitiesFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            
            _userTasksDTO = userTasksDTO;
            
            LoadData();
            
            AuthorizatedUserAccess();
        }

        #region Method's
        
        private void LoadData()
        {
            splashScreenManager.ShowWaitForm();

            cityService = Program.kernel.Get<ICityService>();
            cityBS.DataSource = cityService.GetCities();
            citiesGrid.DataSource = cityBS;

            splashScreenManager.CloseWaitForm();
        }

        private void AuthorizatedUserAccess()
        {
            addCityBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editCityBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteCityBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
        }

        private void DeleteCity()
        {
            if (cityBS.Count != 0)
            {
                if (MessageBox.Show("Видалити місто?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cityService = Program.kernel.Get<ICityService>();
                    int rowHandle = citiesGridView.FocusedRowHandle - 1;
                    citiesGridView.BeginDataUpdate();

                    if ((((CityDTO)cityBS.Current).ParentId) != null)
                    {
                        int tempId = ((CityDTO)cityBS.Current).ParentId ?? 0;
                        cityService.CityDelete(((CityDTO)cityBS.Current).Id);
                        CityDTO modelUpdate = cityService.GetCityById(tempId);
                        modelUpdate.Description = null;
                        modelUpdate.EndRegistrationDate = null;
                        cityService.CityUpdate(modelUpdate);
                    }
                    else
                    {
                        cityService.CityDelete(((CityDTO)cityBS.Current).Id);
                    }

                    LoadData();
                    citiesGridView.EndDataUpdate();
                    citiesGridView.FocusedRowHandle = (citiesGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }

        private void AddCity()
        {
            using (CityEditFm cityEditFm = new CityEditFm(Utils.Operation.Add, new CityDTO()))
            {
                if (cityEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    long return_Id = cityEditFm.Return();
                    citiesGridView.BeginDataUpdate();
                    LoadData();
                    citiesGridView.EndDataUpdate();
                    int rowHandle = citiesGridView.LocateByValue("Id", return_Id);
                    citiesGridView.FocusedRowHandle = rowHandle;

                }
            }   
        }

        private void EditCity()
        {
            if (cityBS.Count != 0)
            {
                using (CityEditFm cityEditFm = new CityEditFm(Utils.Operation.Update, (CityDTO)cityBS.Current))
                {
                    if (cityEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        long return_Id = cityEditFm.Return();
                        citiesGridView.BeginDataUpdate();
                        LoadData();
                        citiesGridView.EndDataUpdate();
                        int rowHandle = citiesGridView.LocateByValue("Id", return_Id);
                        citiesGridView.FocusedRowHandle = rowHandle;
                    }
                }
            }
        }

        private void RenameCity()
        {
            if (cityBS.Count != 0)
            {
                using (RenameCityEditFm renameCityEditFm = new RenameCityEditFm((CityDTO)cityBS.Current))
                {
                    if (renameCityEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        long return_Id = renameCityEditFm.Return();
                        citiesGridView.BeginDataUpdate();
                        LoadData();
                        citiesGridView.EndDataUpdate();
                        int rowHandle = citiesGridView.LocateByValue("Id", return_Id);
                        citiesGridView.FocusedRowHandle = rowHandle;
                    }
                }
            } 
        }
        
        private CityDTO GetRenameCityInfo(int id)
        {
            cityService = Program.kernel.Get<ICityService>();
            return cityService.GetCityById(id);
        }

        #endregion

        #region Event's
        
        private void deleteCityBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteCity();
        }

        private void updateCityBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            citiesGridView.BeginDataUpdate();
            LoadData();
            citiesGridView.EndDataUpdate();
        }
        
        private void addCityBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddCity();
        }

        private void editCityBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditCity();
        }

        private void citiesGrid_DoubleClick(object sender, System.EventArgs e)
        {
            EditCity();
        }

        private void renameCityBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            RenameCity();
        }

        private void citiesGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            CityDTO item = (CityDTO)cityBS[e.ListSourceRowIndex];

            if (e.Column == infoCol && e.IsGetData)
            {
                if (item.ParentId != null)
                    e.Value = imageCollection.Images[0];
            }
        }
                
        private void toolTipController_GetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.SelectedControl is GridControl)
            {
                GridView view = ((GridControl)e.SelectedControl).GetViewAt(e.ControlMousePosition) as GridView;

                if (view == null) return;

                GridHitInfo hi = view.CalcHitInfo(e.ControlMousePosition);

                if (hi.HitTest == GridHitTest.RowCell && hi.Column != null && hi.Column == infoCol)
                {
                    var relatedModel = view.GetRow(hi.RowHandle);
                    if (relatedModel != null)
                    {
                        if (((CityDTO)relatedModel).ParentId != null)
                        {
                            CityDTO infoItem = GetRenameCityInfo(((CityDTO)relatedModel).ParentId ?? 0);

                            StringBuilder makeToolMsg = new StringBuilder();
                            makeToolMsg.Append("<u>Початкова назва:</u> " + "<b>" + infoItem.CityName_UA + "</b>");
                            makeToolMsg.AppendLine();
                            makeToolMsg.Append("<u>Дата перейменування:</u> " + "<b>" + infoItem.EndRegistrationDate.Value.ToShortDateString() + "</b>");
                            makeToolMsg.AppendLine();
                            makeToolMsg.Append("<u>Примітки:</u> " + "<b>" + infoItem.Description + "</b>");

                            string toolMsg =  makeToolMsg.ToString();

                            ToolTipControlInfo infoTool = new ToolTipControlInfo(hi.Column, toolMsg, "Інформація по перейменуванню міста", ToolTipIconType.Information);

                            e.Info = infoTool;
                        }
                    }
                }
            }
        }

        #endregion
    }
}