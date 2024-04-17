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
using ERP_NEW.BLL.Services;
using Ninject;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.Charts.Model;
using DevExpress.XtraCharts;
using DevExpress.XtraPrinting;
using System.IO;

namespace ERP_NEW.GUI.Classifiers
{
    public partial class NomenclaturesFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;

        private List<NomenclaturesDTO> nomenclaturesList = new List<NomenclaturesDTO>();
        private IEnumerable<ReceiptHistoryOrdersDTO> receiptsByNomenclaturesId;
 
        private BindingSource nomenclaturesGroupTreeBS = new BindingSource();
        private BindingSource nomenclaturesMaterialsBS = new BindingSource();
        private BindingSource receiptByNomenclatureBS = new BindingSource();

        private bool checkNomenclature;

        private UserTasksDTO _userTasksDTO;

        public NomenclaturesFm(UserTasksDTO userTasksDTO, bool checkNomenclature = false)
        {
            InitializeComponent();
            splashScreenManager.ShowWaitForm();
            this.checkNomenclature = checkNomenclature;
            _userTasksDTO = userTasksDTO;
            LoadGroupsData();
            AuthorizatedUserAccess();
            splashScreenManager.CloseWaitForm();
        }

        private void AuthorizatedUserAccess()
        {
            addMaterialsBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editMaterialsBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteMaterialsBtn.Enabled = (_userTasksDTO.AccessRightId == 2);

            addGroupBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            addSubGroupBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editGroupBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteGroupBtn.Enabled = (_userTasksDTO.AccessRightId == 2);

            xtraTabPage1.PageVisible = (_userTasksDTO.PriceAttribute == 1);
            unitPriceCol.Visible = (_userTasksDTO.PriceAttribute == 1);
            totalPriceCol.Visible = (_userTasksDTO.PriceAttribute == 1);
        }

        private void LoadNomenclatureMaterials(int Id)
        {
            nomenclaturesMaterialGridView.BeginDataUpdate();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            nomenclaturesList = storeHouseService.GetAllNomenclaturesMaterials(Id).ToList();
            nomenclaturesMaterialsBS.DataSource = nomenclaturesList;
            nomenclaturesMaterialGrid.DataSource = nomenclaturesMaterialsBS;
            nomenclaturesMaterialGridView.EndDataUpdate();
        }

        private void LoadGroupsData()
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            List<NomenclatureGroupsDTO> nomenclatureGroupList = storeHouseService.GetAllNomenclaturesGroups().ToList();
            nomenclatureGroupList.Insert(0,new NomenclatureGroupsDTO
            {
                Id = -1,
                Name = "Усі"
            });

            nomenclaturesGroupTreeBS.DataSource = nomenclatureGroupList;
            nomenclatureGroupTree.DataSource = nomenclaturesGroupTreeBS;
            nomenclatureGroupTree.RootValue = -1;
            nomenclatureGroupTree.KeyFieldName = "Id";
            nomenclatureGroupTree.ParentFieldName = "Parent_Id";
            nomenclatureGroupTree.ExpandAll();
        }
        public NomenclaturesDTO Return()
        {
            return (NomenclaturesDTO)nomenclaturesMaterialsBS.Current;
        }

        private void EditGroups(Utils.Operation operation, NomenclatureGroupsDTO model)
        {
            using (NomenclaturesGroupEditFm nomenclaturesGroupEditFm = new NomenclaturesGroupEditFm(operation, model))
            {
                if (nomenclaturesGroupEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    NomenclatureGroupsDTO return_Id = nomenclaturesGroupEditFm.Return();
                    nomenclatureGroupTree.BeginUpdate();
                    LoadGroupsData();
                    nomenclatureGroupTree.EndUpdate();
                    nomenclatureGroupTree.SetFocusedNode(nomenclatureGroupTree.FindNodeByKeyID(return_Id));
                }
            }   
        }

        private void EditMaterials(Utils.Operation operation, NomenclaturesDTO model)
        {
            using (NomenclaturesMaterialsEditFm nomenclaturesMaterialsEditFm = new NomenclaturesMaterialsEditFm(operation, model))
            {
                if (nomenclaturesMaterialsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    NomenclaturesDTO return_Id = nomenclaturesMaterialsEditFm.Return();
                    nomenclaturesMaterialGrid.BeginUpdate();
                    LoadNomenclatureMaterials((int)nomenclatureGroupTree.FocusedNode[nomenclatureGroupTree.KeyFieldName]);
                    nomenclaturesMaterialGrid.EndUpdate();      
                }
            }
        }


        private void DeleteNomenclatureGroups()
        {
            if (nomenclaturesGroupTreeBS.Count != 0)
            {
                if (MessageBox.Show("Видалити групу?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    storeHouseService = Program.kernel.Get<IStoreHouseService>();
                    nomenclatureGroupTree.BeginUpdate();
                    if (storeHouseService.NomenclatureGroupDelete(((NomenclatureGroupsDTO)nomenclaturesGroupTreeBS.Current).Id))
                    {
                        LoadGroupsData();
                    }

                    nomenclatureGroupTree.EndUpdate();
                }
            }
        }

        private void DeleteNomenclatureMaterials()
        {
            if (nomenclaturesMaterialsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити номенклатуру?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    storeHouseService = Program.kernel.Get<IStoreHouseService>();
                    int rowHandle = nomenclaturesMaterialGridView.FocusedRowHandle - 1;
                    nomenclaturesMaterialGridView.BeginDataUpdate();
                    storeHouseService.NomenclatureMaterialsDelete(((NomenclaturesDTO)nomenclaturesMaterialsBS.Current).ID);
                    LoadNomenclatureMaterials((int)nomenclatureGroupTree.FocusedNode[nomenclatureGroupTree.KeyFieldName]);
                    nomenclaturesMaterialGridView.EndDataUpdate();
                    nomenclaturesMaterialGridView.FocusedRowHandle = (nomenclaturesMaterialGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }

        private void nomenclatureGroupTree_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            LoadNomenclatureMaterials((int)nomenclatureGroupTree.FocusedNode[nomenclatureGroupTree.KeyFieldName]);
        }
        
        private void addGroupBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            EditGroups(Utils.Operation.Add, new NomenclatureGroupsDTO());
        }
        
        private void editGroupBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditGroups(Utils.Operation.Update, (NomenclatureGroupsDTO)nomenclaturesGroupTreeBS.Current);
        }

        private void deleteGroupBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DeleteNomenclatureGroups();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("При видаленні виникла помилка. " + ex.Message, "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addMaterialsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NomenclaturesDTO modelSaveGroup = new NomenclaturesDTO();
            modelSaveGroup.Nomencl_Group_Id = ((NomenclatureGroupsDTO)nomenclaturesGroupTreeBS.Current).Id;
            EditMaterials(Utils.Operation.Add, modelSaveGroup);
        }

        private void editMaterialsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditMaterials(Utils.Operation.Update, (NomenclaturesDTO)nomenclaturesMaterialsBS.Current);
        }

        private void nomenclaturesMaterialGrid_DoubleClick(object sender, EventArgs e)
        {
            if (!checkNomenclature)
            {
                EditMaterials(Utils.Operation.Update, (NomenclaturesDTO)nomenclaturesMaterialsBS.Current);
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void refreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadNomenclatureMaterials((int)nomenclatureGroupTree.FocusedNode[nomenclatureGroupTree.KeyFieldName]);
        }

        private void deleteMaterialsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DeleteNomenclatureMaterials();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("При видаленні виникла помилка. " + ex.Message, "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addSubGroupBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditGroups(Utils.Operation.Custom, (NomenclatureGroupsDTO)nomenclaturesGroupTreeBS.Current);
        }

        private void nomenclaturesMaterialGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (nomenclaturesMaterialsBS.Count > 0)
            {
                storeHouseService = Program.kernel.Get<IStoreHouseService>();

                receiptsByNomenclaturesId = storeHouseService.GetReceiptsByNomenclaturesId(((NomenclaturesDTO)nomenclaturesMaterialsBS.Current).ID, DateTime.Now.AddYears(-1), DateTime.Now);
                receiptByNomenclatureBS.DataSource = receiptsByNomenclaturesId;
                chartControl.DataSource = receiptByNomenclatureBS;

                XYDiagram diagram = chartControl.Diagram as XYDiagram;
                if (diagram == null) return;

                AxisY axisY = diagram.AxisY;

                if (receiptByNomenclatureBS.Count == 0)
                {
                    axisY.Title.Text = "Грн./" + String.Empty;
                }
                else
                {
                    axisY.Title.Text = "Грн./" + ((ReceiptHistoryOrdersDTO)receiptByNomenclatureBS.Current).UnitLocalName;
                }
                
                recieptArchiveGrid.DataSource = receiptByNomenclatureBS;

            }

        }

        private void printNomenclatureBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                    string exportFilePath = Utils.HomePath + @"\Temp\" + "Список номенклатур за " + DateTime.Now.ToShortDateString()+".xls";
                    var optionXls = new XlsExportOptions();
                    optionXls.ExportMode = XlsExportMode.SingleFilePageByPage;
                    optionXls.SheetName = "Залишки за надходженнями";
                    optionXls.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;
                    nomenclaturesMaterialGrid.ExportToXls(exportFilePath, optionXls);

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "Не можливо відкрити файл." + Environment.NewLine + Environment.NewLine + "Шлях: " + exportFilePath;
                            MessageBox.Show(msg, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "Не можливо відкрити файл." + Environment.NewLine + Environment.NewLine + "Шлях: " + exportFilePath;
                        MessageBox.Show(msg, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }
    }
}