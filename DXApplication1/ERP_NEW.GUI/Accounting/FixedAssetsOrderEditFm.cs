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
using DevExpress.XtraEditors.Controls;
using Ninject;
using System.Web;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL;

namespace ERP_NEW.GUI.Accounting
{
    public partial class FixedAssetsOrderEditFm : DevExpress.XtraEditors.XtraForm
    {

        private BindingSource fixedAssetsOrderBS = new BindingSource();
        private BindingSource materialsBS = new BindingSource();
        private BindingSource employeesBS = new BindingSource();

        private IFixedAssetsOrderService fixedAssetsOrderService;
        private IEmployeesService employeesService;
        private IAccountsService accountsService;

        private Utils.Operation operation;
        private List<FixedAssetsMaterialsDTO> materialsList = new List<FixedAssetsMaterialsDTO>();
        private List<FixedAssetsMaterialsDTO> deletematerialsList = new List<FixedAssetsMaterialsDTO>();

        private IEnumerable<FixedAssetsOrderDTO> getAllFixedAssetsOrder;
        private BindingSource getAllFixedAssetsOrderBS = new BindingSource();
        private int clickMaterialBtn = 0;

        private ObjectBase Item
        {
            get { return fixedAssetsOrderBS.Current as ObjectBase; }
            set
            {
                fixedAssetsOrderBS.DataSource = value;
                value.BeginEdit();
            }
        }

        private ObjectBase ItemMaterial
        {
            get { return materialsBS.Current as ObjectBase; }
            set
            {
                materialsBS.DataSource = value;
                value.BeginEdit();
            }
        }


        public FixedAssetsOrderEditFm(Utils.Operation operation, FixedAssetsOrderDTO model, List<FixedAssetsMaterialsDTO> materialsListModel)
        {
            InitializeComponent();
            
            this.operation = operation;
            fixedAssetsOrderBS.DataSource = Item = model;
            materialsList = materialsListModel;

            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            employeesService = Program.kernel.Get<IEmployeesService>();
            accountsService = Program.kernel.Get<IAccountsService>();
            getAllFixedAssetsOrder = fixedAssetsOrderService.GetFixedAssestsOrder();
            
            LoadData();

            inventoryNumberEdit.DataBindings.Add("EditValue", fixedAssetsOrderBS, "InventoryNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            inventoryNameEdit.DataBindings.Add("EditValue", fixedAssetsOrderBS, "InventoryName", true, DataSourceUpdateMode.OnPropertyChanged);
            beginDateEdit.DataBindings.Add("EditValue", fixedAssetsOrderBS, "BeginDate", true, DataSourceUpdateMode.OnPropertyChanged);
            usefulMonthEdit.DataBindings.Add("EditValue", fixedAssetsOrderBS, "UsefulMonth", true, DataSourceUpdateMode.OnPropertyChanged);
            endDateEdit.DataBindings.Add("EditValue", fixedAssetsOrderBS, "EndRecordDate", true, DataSourceUpdateMode.OnPropertyChanged);
            balanceEdit.DataBindings.Add("EditValue", fixedAssetsOrderBS, "BalanceAccountNum", true, DataSourceUpdateMode.OnPropertyChanged);

            supplierLookUp.DataBindings.Add("EditValue", fixedAssetsOrderBS, "Supplier_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            employeesBS.DataSource = employeesService.GetEmployeesWorking();
            supplierLookUp.Properties.DataSource = employeesBS;
            supplierLookUp.Properties.ValueMember = "EmployeeID";
            supplierLookUp.Properties.DisplayMember = "FullName";
            supplierLookUp.Properties.NullText = "Немає данних";

            operatingPersonLookUp.DataBindings.Add("EditValue", fixedAssetsOrderBS, "OperatingPerson_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            operatingPersonLookUp.Properties.DataSource = employeesBS;
            operatingPersonLookUp.Properties.ValueMember = "EmployeeID";
            operatingPersonLookUp.Properties.DisplayMember = "FullName";
            operatingPersonLookUp.Properties.NullText = "Немає данних";

            fixedAssetsGroupLookUp.DataBindings.Add("EditValue", fixedAssetsOrderBS, "Group_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            List<FixedAssetsGroupDTO> groupList = fixedAssetsOrderService.GetFixedAssestGroup().ToList();
            fixedAssetsGroupLookUp.Properties.DataSource = groupList;
            fixedAssetsGroupLookUp.Properties.ValueMember = "Id";
            fixedAssetsGroupLookUp.Properties.DisplayMember = "Name";
            fixedAssetsGroupLookUp.Properties.NullText = "Немає данних";

            debitLookUp.DataBindings.Add("EditValue", fixedAssetsOrderBS, "FixedAccountId", true, DataSourceUpdateMode.OnPropertyChanged);//??"FixedAccountNum"
            List<AccountsDTO> numList = accountsService.GetAccounts().ToList();
            debitLookUp.Properties.DataSource = numList;
            debitLookUp.Properties.ValueMember = "Id";
            debitLookUp.Properties.DisplayMember = "Num";
            debitLookUp.Properties.NullText = "Немає данних";

            regionLookUp.DataBindings.Add("EditValue", fixedAssetsOrderBS, "Region_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            List<RegionDTO> regionList = fixedAssetsOrderService.GetRegion().ToList();
            regionLookUp.Properties.DataSource = regionList;
            regionLookUp.Properties.ValueMember = "Id";
            regionLookUp.Properties.DisplayMember = "Name";
            regionLookUp.Properties.NullText = "Немає данних";

            //amortizing
            priceEdit.DataBindings.Add("EditValue", fixedAssetsOrderBS, "BeginPrice", true, DataSourceUpdateMode.OnPropertyChanged);
            increaseEdit.DataBindings.Add("EditValue", fixedAssetsOrderBS, "IncreasePrice", true, DataSourceUpdateMode.OnPropertyChanged);
            totalPriceEdit.DataBindings.Add("EditValue", fixedAssetsOrderBS, "TotalPrice", true, DataSourceUpdateMode.OnPropertyChanged);
            currentPriceEdit.DataBindings.Add("EditValue", fixedAssetsOrderBS, "CurrentPrice", true, DataSourceUpdateMode.OnPropertyChanged);
            allAmmortizationPriceEdit.DataBindings.Add("EditValue", fixedAssetsOrderBS, "PeriodAmortization", true, DataSourceUpdateMode.OnPropertyChanged);
            periodAmortizationPriceEdit.DataBindings.Add("EditValue", fixedAssetsOrderBS, "PeriodYearAmortization", true, DataSourceUpdateMode.OnPropertyChanged);
            currentAmortizationPriceEdit.DataBindings.Add("EditValue", fixedAssetsOrderBS, "CurrentAmortization", true, DataSourceUpdateMode.OnPropertyChanged);
    

            if (operation == Utils.Operation.Add)
                editIncreaseCostBtn.Enabled = false;      
            materialsBS.DataSource = materialsListModel;
            fixedAssetsMaterialsGrid.DataSource = materialsBS;
        }

        #region Methot's

        private void LoadData()
        {
            if (materialsBS.Count <= 0 && operation == Utils.Operation.Add || materialsBS.Count <= 0)
            {
                editMaterialBtn.Enabled = false;
                increaseCostBtn.Enabled = false;
                deleteMaterialBtn.Enabled = false;
            }
            if (materialsBS.Count > 0 || operation == Utils.Operation.Update || (materialsBS.Count > 0 && operation == Utils.Operation.Add))
            {
                editMaterialBtn.Enabled = true;
                increaseCostBtn.Enabled = true;
                deleteMaterialBtn.Enabled = true;
            }
        }

        private bool CheckFullGrid(SimpleButton checkBtn)
        {
            if (materialsList.Count <= 0)
            {
                checkBtn.Enabled = false;
                return false;
            }
            else
            {
                checkBtn.Enabled = true;
                return true;
            }
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            LoadData();
            if (materialsBS.Count <= 0)
            {
                MessageBox.Show("Необхідно додати матеріал!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            try
            {
                if (operation == Utils.Operation.Add)
                {
                    materialsBS.DataSource = materialsList;
                    materialsList.Select(s => { s.FixedAssetsOrder_Id = ((FixedAssetsOrderDTO)Item).Id; return s; }).ToList();

                    switch ((int)fixedAssetsGroupLookUp.EditValue)
                    {
                        case 1: balanceEdit.EditValue = 27;
                            break;
                        case 2: balanceEdit.EditValue = 35;
                            break;
                        case 3: balanceEdit.EditValue = 27;
                            break;
                        case 4: balanceEdit.EditValue = 30;
                            break;
                        case 5: balanceEdit.EditValue = 58;
                            break;
                        case 6: balanceEdit.EditValue = 32;
                            break;
                        case 7: balanceEdit.EditValue = 22;
                            break;
                        case 8: balanceEdit.EditValue = 27;
                            break;
                        case 9: balanceEdit.EditValue = 108;
                            break;
                        case 10: balanceEdit.EditValue = 124;
                            break;

                    }
                    ((FixedAssetsOrderDTO)Item).UsefulMonth = (int)usefulMonthEdit.EditValue;
                    ((FixedAssetsOrderDTO)Item).BeginRecordDate = (DateTime)beginDateEdit.EditValue;
                    ((FixedAssetsOrderDTO)Item).Balance_Account_Id = (int)balanceEdit.EditValue;
                    ((FixedAssetsOrderDTO)Item).DebitNum = debitLookUp.EditValue.ToString();

                    ((FixedAssetsOrderDTO)Item).Id = fixedAssetsOrderService.FixedAssetsOrderCreate((FixedAssetsOrderDTO)Item);

                    foreach (var item in materialsList)
                    {
                        if (item.Id == 0)
                        {
                            FixedAssetsMaterialsDTO newModel = new FixedAssetsMaterialsDTO()
                            {
                                FixedAssetsOrder_Id = ((FixedAssetsOrderDTO)Item).Id,
                                Expenditures_Id = item.Expenditures_Id,
                                Fixed_Account_Id = (int)debitLookUp.EditValue,
                                FixedNum = item.FixedNum,
                                FixedPrice = item.FixedPrice,
                                Description = item.Description,
                                MaterialsDate = item.MaterialsDate,
                                Flag = item.Flag,
                                Id = item.Id,
                                AccountNum = debitLookUp.EditValue.ToString()
                                 
                                 
                            };
                            fixedAssetsOrderService.FixedAssetsOrderMaterialsCreate(newModel);
                        }
                    }
                }
                else
                {
                    fixedAssetsOrderService.FixedAssetsOrderUpdate((FixedAssetsOrderDTO)Item);
                    materialsList.Select(s => { s.FixedAssetsOrder_Id = ((FixedAssetsOrderDTO)Item).Id; return s; }).ToList();
                   // ((FixedAssetsOrderDTO)Item).BeginRecordDate = DateTime.Now;
                    materialsList = materialsBS.DataSource as List<FixedAssetsMaterialsDTO>;
                    foreach (var item in materialsList)
                    {
                        if (item.Id == 0)
                        {
                            if (item.Nomenclature == null)
                            {
                                FixedAssetsMaterialsDTO newModel = new FixedAssetsMaterialsDTO()
                                {
                                    FixedAssetsOrder_Id = ((FixedAssetsOrderDTO)Item).Id,
                                    Fixed_Account_Id = (int)debitLookUp.EditValue,
                                    FixedNum = item.FixedNum,
                                    FixedPrice = item.FixedPrice,
                                    Description = item.Description,
                                    MaterialsDate = item.MaterialsDate,
                                    Flag = item.Flag,
                                    AccountNum = debitLookUp.EditValue.ToString()
                                };
                                fixedAssetsOrderService.FixedAssetsOrderMaterialsCreate(newModel);
                            }
                            else
                            {
                                FixedAssetsMaterialsDTO newModel = new FixedAssetsMaterialsDTO()//name
                                {
                                    FixedAssetsOrder_Id = ((FixedAssetsOrderDTO)Item).Id,
                                    Expenditures_Id = item.Expenditures_Id,
                                    ExpDate = item.ExpDate,
                                    Fixed_Account_Id = (int)debitLookUp.EditValue,
                                    FixedNum = item.FixedNum,
                                    FixedPrice = item.FixedPrice,
                                    Flag = item.Flag,
                                    Name=item.Name,
                                    AccountNum = debitLookUp.EditValue.ToString()
                                     
                                };
                                fixedAssetsOrderService.FixedAssetsOrderMaterialsCreate(newModel);
                            }
                        }
                        else
                        {
                            FixedAssetsMaterialsDTO updateModel = new FixedAssetsMaterialsDTO()
                            {
                                Id = item.Id,
                                FixedAssetsOrder_Id = ((FixedAssetsOrderDTO)Item).Id,
                                Expenditures_Id = item.Expenditures_Id,
                                ExpDate = item.ExpDate,
                                Fixed_Account_Id = (int)debitLookUp.EditValue,
                                FixedNum = item.FixedNum,
                                FixedPrice = item.FixedPrice,
                                Flag = item.Flag,
                                Description = item.Description,
                                MaterialsDate = item.MaterialsDate,
                                Name = item.Name,
                                AccountNum = debitLookUp.EditValue.ToString()
                            };
                            fixedAssetsOrderService.FixedAssetsOrderMaterialsUpdate(updateModel);
                        }
                    }
                }
                if (deletematerialsList.Count > 0)
                {
                    foreach (var item in deletematerialsList)
                    {
                        if (item.Id > 0)
                            fixedAssetsOrderService.FixedAssetsOrderMaterialsDelete(item.Id);
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

        public FixedAssetsMaterialsDTO Return()
        {
            return ((FixedAssetsMaterialsDTO)ItemMaterial);
        }

        public FixedAssetsOrderDTO ReturnInt()
        {
            return ((FixedAssetsOrderDTO)Item);
        }

        private bool ValidateInventorNumber()
        {
            if (operation == Utils.Operation.Add)
            {
                var duplicates = getAllFixedAssetsOrder.Where(c => c.InventoryNumber == (string)inventoryNumberEdit.EditValue).ToList();

                int countDuplicate = duplicates.Count;
                if (countDuplicate > 0)
                {
                    MessageBox.Show("Такий інвентарний номер вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else return true;
            }
            else return true;
        }

        private void AddMaterials(Utils.Operation operation, FixedAssetsMaterialsDTO materials, int clickBtn)
        {
            using (FixedAssetsOrderListMaterialsEditFm fixedAssetsOrderListMaterialsEdit = new FixedAssetsOrderListMaterialsEditFm(operation, materials, clickBtn))
            {
                if (fixedAssetsOrderListMaterialsEdit.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                   
                    FixedAssetsMaterialsDTO getAllFixedAssetsOrder = fixedAssetsOrderListMaterialsEdit.Return();
                    fixedAssetsMaterialsGridView.BeginDataUpdate();

                    if(getAllFixedAssetsOrder.Id==0)
                       materialsList.Add(getAllFixedAssetsOrder);
                    materialsBS.DataSource = materialsList;
                    fixedAssetsMaterialsGrid.DataSource = materialsBS;
                    fixedAssetsMaterialsGridView.EndDataUpdate();
                    LoadData();
                }
            }
        }


        private void AddIncreaseCost(Utils.Operation operation, FixedAssetsMaterialsDTO materials)
        {
            using (FixedAssetsOrderEditCostFm fixedAssetsOrderEditCostFm = new FixedAssetsOrderEditCostFm(operation, materials))
            {
                if (fixedAssetsOrderEditCostFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FixedAssetsMaterialsDTO getAllFixedAssetsOrder = fixedAssetsOrderEditCostFm.Return();
                    fixedAssetsMaterialsGridView.BeginDataUpdate();

                    LoadData();
                    if (operation == Utils.Operation.Add)
                        materialsList.Add(getAllFixedAssetsOrder);

                    materialsBS.DataSource = materialsList;
                    fixedAssetsMaterialsGrid.DataSource = materialsBS;

                    fixedAssetsMaterialsGridView.EndDataUpdate();

                }
            }
        }
        #endregion

        #region Event's
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInventorNumber())
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
                        else
                        {
                            // MessageBox.Show("Не вірний номер податкової.Такий номер вже існує.", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //numberAccountingEdit.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void addMaterialsBtn_Click(object sender, EventArgs e)
        {
            clickMaterialBtn = 1;
            int clickBtn = clickMaterialBtn;
            AddMaterials(Utils.Operation.Add, new FixedAssetsMaterialsDTO(), clickBtn);


        }

        private void increaseCostBtn_Click(object sender, EventArgs e)
        {
            //AddIncreaseCost(Utils.Operation.Add, new FixedAssetsMaterialsDTO());
            clickMaterialBtn = 2;
            int clickBtn = clickMaterialBtn;
            AddMaterials(Utils.Operation.Add, new FixedAssetsMaterialsDTO(), clickBtn);
        }

        private void editMaterialBtn_Click(object sender, EventArgs e)//edit
        {
            //clickMaterialBtn = 2;
            //int clickBtn = clickMaterialBtn;
            //AddMaterials(Utils.Operation.Add, new FixedAssetsMaterialsDTO(), clickBtn);
            AddIncreaseCost(Utils.Operation.Add, new FixedAssetsMaterialsDTO());
        }

        private void editIncreaseCostBtn_Click(object sender, EventArgs e)//korect
        {
            AddIncreaseCost(Utils.Operation.Update, (FixedAssetsMaterialsDTO)materialsBS.Current);
            //clickMaterialBtn = 2;
            //int clickBtn = clickMaterialBtn;
            //AddMaterials(Utils.Operation.Add, new FixedAssetsMaterialsDTO(), clickBtn);
        }

        private void fixedAssetsMaterialsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            FixedAssetsMaterialsDTO item = (FixedAssetsMaterialsDTO)materialsBS[e.ListSourceRowIndex];

            if (e.Column == flagImageCol && e.IsGetData)
            {
                if (item.Id != null)
                {
                    if (item.Flag == 0)
                        e.Value = imageCollection.Images[0];
                    if (item.Flag == 1)
                        e.Value = imageCollection.Images[1];
                    if (item.Flag == 2)
                        e.Value = imageCollection.Images[2];
                    if (item.Flag == 3)
                        e.Value = imageCollection.Images[3];
                }
            }
            //block button Correct if active row don't correction 
            if ((item.Flag == 1 || item.Flag == 2) && (item.Nomenclature == null))
                editIncreaseCostBtn.Enabled = true;
            else
                editIncreaseCostBtn.Enabled = false;
        }
        private void deleteMaterialBtn_Click(object sender, EventArgs e)
        {
            FixedAssetsMaterialsDTO test = new FixedAssetsMaterialsDTO();
            fixedAssetsMaterialsGridView.PostEditor();
            fixedAssetsMaterialsGridView.BeginDataUpdate();
            if (materialsBS.Count != 0 && MessageBox.Show("Удалить материал?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                test = (FixedAssetsMaterialsDTO)materialsBS.Current;
                deletematerialsList.Add(test);
                materialsList.Remove(test);
                materialsBS.DataSource = materialsList;
            }
            fixedAssetsMaterialsGrid.DataSource = materialsBS;
            fixedAssetsMaterialsGridView.EndDataUpdate();


        }

       

        private void saveBtn_EnabledChanged(object sender, EventArgs e)
        {
            //if (materialsList.Count == 0)
            //    saveBtn.Enabled = false;
            //else saveBtn.Enabled = true;
            //fixedAssetsOrderValidationProvider.Validate((Control)sender);
        }


        #endregion

        #region Validation's

        private bool ControlValidation()
        {
            return fixedAssetsOrderValidationProvider.Validate();
        }
        private void fixedAssetsOrderValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }
        private void fixedAssetsOrderValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (fixedAssetsOrderValidationProvider.GetInvalidControls().Count == 0);
          
            this.validateLbl.Visible = !isValidate;
            this.saveBtn.Enabled = isValidate;
        }

        private void inventoryNumberEdit_EditValueChanged(object sender, EventArgs e)
        {
            fixedAssetsOrderValidationProvider.Validate((Control)sender);
        }

        private void inventoryNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            fixedAssetsOrderValidationProvider.Validate((Control)sender);
        }

        private void fixedAssetsGroupLookUp_EditValueChanged(object sender, EventArgs e)
        {
            fixedAssetsOrderValidationProvider.Validate((Control)sender);
        }

        private void beginDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            fixedAssetsOrderValidationProvider.Validate((Control)sender);
        }

        private void usefulMonthEdit_EditValueChanged(object sender, EventArgs e)
        {
            fixedAssetsOrderValidationProvider.Validate((Control)sender);
        }

        private void supplierLookUp_EditValueChanged(object sender, EventArgs e)
        {
            fixedAssetsOrderValidationProvider.Validate((Control)sender);
        }

        private void debitLookUp_EditValueChanged(object sender, EventArgs e)
        {
            fixedAssetsOrderValidationProvider.Validate((Control)sender);
        }

        #endregion




    }
}