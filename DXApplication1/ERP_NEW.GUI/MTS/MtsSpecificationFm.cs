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
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.MTS
{
    public partial class MtsSpecificationFm : DevExpress.XtraEditors.XtraForm
    {
        private IMtsSpecificationsService mtsSpecificationsService;

        private BindingSource specificationTreeBS = new BindingSource();
        private BindingSource assembliesBS = new BindingSource();
        private BindingSource assemblyInfoBS = new BindingSource();
        private BindingSource purchasedBS = new BindingSource();
        private BindingSource materialsBS = new BindingSource();
        private BindingSource detailsBS = new BindingSource();

        private List<MtsSpecificationTreeInfoDTO> specificationTreeList = new List<MtsSpecificationTreeInfoDTO>();
        private List<MtsSpecificationTreeInfoDTO> purchasedList = new List<MtsSpecificationTreeInfoDTO>();
        private List<MtsSpecificationTreeInfoDTO> materialsList = new List<MtsSpecificationTreeInfoDTO>();
        private List<MtsSpecificationTreeInfoDTO> detailsList = new List<MtsSpecificationTreeInfoDTO>();

        private UserTasksDTO _userTasksDTO;
        private MtsAssembliesInfoDTO assemblyItem;

        public MtsSpecificationFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            _userTasksDTO = userTasksDTO;

            AuthorizatedUserAccess();
            
            LoadAssembliesData();

            assemblyEdit.Properties.DataSource = assembliesBS;
            assemblyEdit.Properties.ValueMember = "AssemblyId";
            assemblyEdit.Properties.DisplayMember = "Drawing";
            assemblyEdit.Properties.NullText = "Немає данних";

            assemblyEdit.EditValue = null;
        }

        #region Method's

        private void AuthorizatedUserAccess()
        {
            //addBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            //editBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            //deleteBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
        }

        private void LoadAssembliesData()
        {
            mtsSpecificationsService = Program.kernel.Get<IMtsSpecificationsService>();
            assembliesBS.DataSource = mtsSpecificationsService.GetMtsAssemblies(DateTime.MinValue, DateTime.MaxValue);
        }

        private void LoadPurchasedProductsDataBySpecId(long specId)
        {
            purchasedGridView.BeginDataUpdate();

            purchasedList = specificationTreeList.Where(s => s.ParentId == specId && s.MaterialStatus == 1).ToList();
            purchasedBS.DataSource = purchasedList;
            purchasedGrid.DataSource = purchasedBS;

            purchasedGridView.EndDataUpdate();
        }

        private void LoadDetailsDataBySpecId(long specId)
        {
            detailsGridView.BeginDataUpdate();

            detailsList = specificationTreeList.Where(s => s.ParentId == specId && s.MtsCreatedDetailId != null).ToList();
            detailsBS.DataSource = detailsList;
            detailsGrid.DataSource = detailsBS;

            detailsGridView.EndDataUpdate();
        }

        private void LoadMaterialsDataBySpecId(long specId)
        {
            materialsGridView.BeginDataUpdate();

            materialsList = specificationTreeList.Where(s => s.ParentId == specId && s.MaterialStatus == 2).ToList();
            materialsBS.DataSource = materialsList;
            materialsGrid.DataSource = materialsBS;

            materialsGridView.EndDataUpdate();
        }

        private void LoadSpecificationTreeData(long id)
        {
            splashScreenManager.ShowWaitForm();

            mtsSpecificationsService = Program.kernel.Get<IMtsSpecificationsService>();

            specificationTreeList = mtsSpecificationsService.GetMtsSpecificationTreeInfoByRootId(id);
            specificationTreeBS.DataSource = specificationTreeList;
            specificationTree.DataSource = specificationTreeBS;
            specificationTree.KeyFieldName = "Id";
            specificationTree.ParentFieldName = "ParentId";

            splashScreenManager.CloseWaitForm();
        }

        private void SetAssemblyVGridSource()
        {
            assemblyItem = (MtsAssembliesInfoDTO)assemblyEdit.GetSelectedDataRow();
            assemblyInfoBS.DataSource = assemblyItem;
            assembliesInfoVGrid.DataSource = assemblyInfoBS;
        }

        private void EditMtsSpecification(Utils.Operation operation, MtsSpecificationsDTO model)
        {
            using (MtsSpecificationEditFm mtsSpecificationEditFm = new MtsSpecificationEditFm(operation, model))
            {
                if (mtsSpecificationEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var returnModel = mtsSpecificationEditFm.Return();

                    specificationTree.BeginUpdate();
                    LoadSpecificationTreeData(returnModel.RootId);
                    specificationTree.EndUpdate();

                    specificationTree.SetFocusedNode(specificationTree.FindNodeByKeyID(returnModel.Id));
                }
            }
        }

        private void EditAssembly(Utils.Operation operation, MtsAssembliesDTO model)
        {
            using (MtsAssemblyEditFm mtsAssemblyEditFm = new MtsAssemblyEditFm(operation, model))
            {
                if (mtsAssemblyEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    long return_Id = mtsAssemblyEditFm.Return();

                    LoadAssembliesData();

                    specificationTree.BeginUpdate();

                    assemblyEdit.EditValue = return_Id;
                    long idSpec = ((MtsAssembliesInfoDTO)assemblyEdit.GetSelectedDataRow()).SpecificationId;
                    LoadSpecificationTreeData(idSpec);
                    
                    specificationTree.EndUpdate();

                    specificationTree.SetFocusedNode(specificationTree.FindNodeByKeyID(idSpec));
                    SetAssemblyVGridSource();
                }
            }
        }

        private void DeleteAssembly()
        {
            if (assemblyEdit.EditValue != null)
            {
                if (MessageBox.Show("Видалити проект?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (mtsSpecificationsService.DeleteSpecification(((MtsAssembliesInfoDTO)assemblyEdit.GetSelectedDataRow()).SpecificationId))
                    {
                        if (mtsSpecificationsService.DeleteAssembly(((MtsAssembliesInfoDTO)assemblyEdit.GetSelectedDataRow()).AssemblyId))
                        {
                            LoadAssembliesData();
                            specificationTree.BeginUpdate();
                            LoadSpecificationTreeData((long)assemblyEdit.EditValue);
                            specificationTree.EndUpdate();

                            SetAssemblyVGridSource();
                        }
                    }
                }
            }
        }

        #endregion

        #region Event's

        #region Button's click

        private void addSpecBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (specificationTreeBS.Count > 0)
            {
                EditMtsSpecification(Utils.Operation.Add, new MtsSpecificationsDTO() { RootId = ((MtsSpecificationTreeInfoDTO)specificationTreeBS.Current).RootId });
            }
        }

        private void editSpecBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (specificationTreeBS.Count > 0)
            {
                MtsSpecificationTreeInfoDTO item = (MtsSpecificationTreeInfoDTO)specificationTreeBS.Current;

                MtsSpecificationsDTO model = new MtsSpecificationsDTO()
                {
                    Id = item.Id,
                    ParentId = item.ParentId,
                    RootId = item.RootId,
                    AssemblyId = item.AssemblyId,
                    MtsCreatedDetailId = item.MtsCreatedDetailId,
                    MtsMaterialId = item.MtsMaterialId,
                    MtsModificationId = item.MtsMaterialId,
                    DateAdded = item.DateAdded,
                    DateUpdated = item.DateUpdated,
                    Description = item.Description,
                    DesignerId = item.DesignerId,
                    Drawing = item.Drawing,
                    MaterialStatus = item.MaterialStatus,
                    Name = item.Name,
                    Quantity = item.Quantity,
                    QuantityOfBlanks = item.QuantityOfBlanks,
                    UserId = item.UserId,
                    UserName = item.UserName
                };

                EditMtsSpecification(Utils.Operation.Update, model);
            }
        }

        private void deleteSpecBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void addAssemblyBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditAssembly(Utils.Operation.Add, new MtsAssembliesDTO());
        }

        private void editAssemblyBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (assemblyEdit.EditValue != null)
            {
                MtsAssembliesInfoDTO item = ((MtsAssembliesInfoDTO)assemblyEdit.GetSelectedDataRow());
                MtsAssembliesDTO model = new MtsAssembliesDTO
                {
                    Id = item.AssemblyId,
                    Name = item.Name,
                    Drawing = item.Drawing,
                    DesignerId = item.DesignerId,
                    Description = item.Description,
                    UserId = item.UserId,
                    DateCreated = item.DateCreated,
                    AssemblyStatus = item.AssemblyStatus
                };
                
                EditAssembly(Utils.Operation.Update, model);

            }
        }

        private void deleteAssemblyBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteAssembly();
        }

        private void refreshBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        #endregion

        private void specificationTree_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
        {
            int level = e.Node.Level;
            bool isAssembly = Convert.ToInt32(e.Node.GetValue("AssemblyId")) > 0;
            int materialStatus = Convert.ToInt32(e.Node.GetValue("MaterialStatus"));

            e.NodeImageIndex = level == 0
                ? 0
                : (isAssembly)
                    ? 1
                    : (materialStatus == 0)
                        ? 2
                        : (materialStatus == 1)
                            ? 3
                            : 10;
        }

        private void specificationTree_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            bool isAssembly = Convert.ToInt32(e.Node.GetValue("AssemblyId")) > 0;

            if (e.Column == drawingCol || e.Column == nameCol || e.Column == quantityCol || e.Column == weightCol || e.Column == allQuantityCol)
            {
                if (e.Node.Level == 0)
                {
                    e.Appearance.ForeColor = Color.Maroon;
                    e.Appearance.Font = new Font("Tahoma", 10, FontStyle.Bold);
                }
                else if (isAssembly)
                {
                    e.Appearance.ForeColor = Color.Navy;
                    e.Appearance.Font = new Font("Tahoma", 9, FontStyle.Bold);
                }
            }
        }

        private void specificationTree_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (((MtsSpecificationTreeInfoDTO)specificationTreeBS.Current).AssemblyId > 0)
            {
                LoadPurchasedProductsDataBySpecId(((MtsSpecificationTreeInfoDTO)specificationTreeBS.Current).Id);
                LoadMaterialsDataBySpecId(((MtsSpecificationTreeInfoDTO)specificationTreeBS.Current).Id);
                LoadDetailsDataBySpecId(((MtsSpecificationTreeInfoDTO)specificationTreeBS.Current).Id);
            }
        }
                                
        private void assemblyEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (assemblyEdit.EditValue != null)
            {
                SetAssemblyVGridSource();
                LoadSpecificationTreeData(((MtsAssembliesInfoDTO)assemblyEdit.GetSelectedDataRow()).SpecificationId);
            }
        }
                
        #endregion
    }
}