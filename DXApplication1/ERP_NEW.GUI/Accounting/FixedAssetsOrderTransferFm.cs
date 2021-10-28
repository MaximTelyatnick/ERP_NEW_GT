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
    public partial class FixedAssetsOrderTransferFm : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource employeesBS = new BindingSource();
        private BindingSource employeesOperatingBS = new BindingSource(); 
        private List<FixedAssetsMaterialsDTO> materialsList = new List<FixedAssetsMaterialsDTO>();
        private BindingSource materialsBS = new BindingSource();
        private BindingSource updateFixedAssetsOrderBS = new BindingSource();
        private BindingSource newFixedAssetsOrderBS = new BindingSource();
        private IFixedAssetsOrderService fixedAssetsOrderService;
        private IAccountsService accountsService;
        private IEmployeesService employeesService;
        private IEmployeesService opEmployeesService;
        const short transfer = 1;
        int idGroup = 0;

        private ObjectBase ItemNew
        {
            get { return newFixedAssetsOrderBS.Current as ObjectBase; }
            set
            {
                newFixedAssetsOrderBS.DataSource = value;
                value.BeginEdit();
            }
        }

        private ObjectBase ItemUpdate
        {
            get { return updateFixedAssetsOrderBS.Current as ObjectBase; }
            set
            {
                updateFixedAssetsOrderBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public FixedAssetsOrderTransferFm(FixedAssetsOrderDTO model, List<FixedAssetsMaterialsDTO> sourceMaterials)
        {
            InitializeComponent();
            updateFixedAssetsOrderBS.DataSource = ItemUpdate = model;
            materialsList = sourceMaterials;
            LoadData();

            fixedAssetInventory.Text = model.InventoryName;
            groupEdit.Text = model.GroupName;
            usefulMonthEdit.EditValue = model.UsefulMonth;
            fixedAccountEdit.Text = model.FixedAccountNum;
            regionEdit.Text = model.RegionName;
            supplierEdit.Text = model.SupplierName;
            operatingPersonEdit.Text = model.OperatingPersonName;
            dateEdit.EditValue = "01.01.1900";//DateTime.Now.Date;
            balanceAccountEdit.Text = model.BalanceAccountNum;

            idGroup = model.Group_Id;

            newBalanceAccountLookUp.DataBindings.Add("EditValue", updateFixedAssetsOrderBS, "Balance_Account_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            List<AccountsDTO> numList = accountsService.GetAccounts().ToList();
            newBalanceAccountLookUp.Properties.DataSource = numList;
            newBalanceAccountLookUp.Properties.ValueMember = "Id";
            newBalanceAccountLookUp.Properties.DisplayMember = "Num";
            newBalanceAccountLookUp.Properties.NullText = "Немає данних";

            newGroupLookUp.DataBindings.Add("EditValue", updateFixedAssetsOrderBS, "Group_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            List<FixedAssetsGroupDTO> groupList = fixedAssetsOrderService.GetFixedAssestGroup().ToList();
            newGroupLookUp.Properties.DataSource = groupList;
            newGroupLookUp.Properties.ValueMember = "Id";
            newGroupLookUp.Properties.DisplayMember = "Name";
            newGroupLookUp.Properties.NullText = "Немає данних";

            newUsefulMonthNumeric.Value = model.UsefulMonth;
            newFixedAccountLookUp.DataBindings.Add("EditValue", updateFixedAssetsOrderBS, "FixedAccountId", true, DataSourceUpdateMode.OnPropertyChanged);
            newFixedAccountLookUp.Properties.DataSource = numList;
            newFixedAccountLookUp.Properties.ValueMember = "Id";
            newFixedAccountLookUp.Properties.DisplayMember = "Num";
            newFixedAccountLookUp.Properties.NullText = "Немає данних";

            newRegionLookUp.DataBindings.Add("EditValue", updateFixedAssetsOrderBS, "Region_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            List<RegionDTO> regionList = fixedAssetsOrderService.GetRegion().ToList();
            newRegionLookUp.Properties.DataSource = regionList;
            newRegionLookUp.Properties.ValueMember = "Id";
            newRegionLookUp.Properties.DisplayMember = "Name";
            newRegionLookUp.Properties.NullText = "Немає данних";

            newSupplierLookUp.DataBindings.Add("EditValue", updateFixedAssetsOrderBS, "Supplier_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            employeesBS.DataSource = employeesService.GetEmployeesWorking();
            newSupplierLookUp.Properties.DataSource = employeesBS;
            newSupplierLookUp.Properties.ValueMember = "EmployeeID";
            newSupplierLookUp.Properties.DisplayMember = "FullName";
            newSupplierLookUp.Properties.NullText = "Немає данних";

            newOperatingPersonLookUp.DataBindings.Add("EditValue", updateFixedAssetsOrderBS, "OperatingPerson_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            employeesOperatingBS.DataSource = opEmployeesService.GetEmployeesWorking();
            newOperatingPersonLookUp.Properties.DataSource = employeesOperatingBS;
            newOperatingPersonLookUp.Properties.ValueMember = "EmployeeID";
            newOperatingPersonLookUp.Properties.DisplayMember = "FullName";
            newOperatingPersonLookUp.Properties.NullText = "";// "Немає данних";
        }

        #region Method's
        
       
        public FixedAssetsOrderDTO ReturnNew()
        {
            return ((FixedAssetsOrderDTO)ItemNew);
        }
        public FixedAssetsOrderDTO Returnupd()
        {
            return ((FixedAssetsOrderDTO)ItemUpdate);
        }

        private void LoadData()
        {
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            employeesService = Program.kernel.Get<IEmployeesService>();
            accountsService = Program.kernel.Get<IAccountsService>();
            opEmployeesService = Program.kernel.Get<IEmployeesService>();
        }

        private bool SaveItem()
        {
            this.ItemUpdate.EndEdit();
            LoadData();
            if (newRegionLookUp.Text != "Немає данних")
            {
                try
                {
                    fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
                    FixedAssetsOrderDTO updateModel = new FixedAssetsOrderDTO()
                    {
                        EndRecordDate = (DateTime)dateEdit.EditValue,
                        FixedCardStatus = transfer,
                        GroupName = groupEdit.Text,
                        Group_Id = idGroup,
                        InventoryName = ((FixedAssetsOrderDTO)ItemUpdate).InventoryName,
                        InventoryNumber = ((FixedAssetsOrderDTO)ItemUpdate).InventoryNumber,
                        UsefulMonth = ((FixedAssetsOrderDTO)ItemUpdate).UsefulMonth,
                        FixedAccountNum = ((FixedAssetsOrderDTO)ItemUpdate).FixedAccountNum,
                        RegionName = ((FixedAssetsOrderDTO)ItemUpdate).RegionName,
                        SupplierName = ((FixedAssetsOrderDTO)ItemUpdate).SupplierName,
                        OperatingPersonName = ((FixedAssetsOrderDTO)ItemUpdate).OperatingPersonName,
                        BeginRecordDate = ((FixedAssetsOrderDTO)ItemUpdate).BeginRecordDate,
                        Balance_Account_Id = ((FixedAssetsOrderDTO)ItemUpdate).Balance_Account_Id,
                        FixedAccountId = ((FixedAssetsOrderDTO)ItemUpdate).FixedAccountId,
                        OperatingPerson_Id = ((FixedAssetsOrderDTO)ItemUpdate).OperatingPerson_Id,
                        Region_Id = ((FixedAssetsOrderDTO)ItemUpdate).Region_Id,
                        Supplier_Id = ((FixedAssetsOrderDTO)ItemUpdate).Supplier_Id,
                        BalanceAccountNum = ((FixedAssetsOrderDTO)ItemUpdate).BalanceAccountNum,
                        PeriodAmortization = ((FixedAssetsOrderDTO)ItemUpdate).PeriodAmortization,
                        IncreasePrice = ((FixedAssetsOrderDTO)ItemUpdate).IncreasePrice,
                        PeriodYearAmortization = ((FixedAssetsOrderDTO)ItemUpdate).PeriodYearAmortization,
                        TotalPrice = ((FixedAssetsOrderDTO)ItemUpdate).TotalPrice,
                        BeginPrice = ((FixedAssetsOrderDTO)ItemUpdate).BeginPrice,
                        BeginDate = ((FixedAssetsOrderDTO)ItemUpdate).BeginDate,
                        CurrentPrice = ((FixedAssetsOrderDTO)ItemUpdate).CurrentPrice,
                        CurrentAmortization = ((FixedAssetsOrderDTO)ItemUpdate).CurrentAmortization,
                        Id = ((FixedAssetsOrderDTO)ItemUpdate).Id,
                        Id_Parent = ((FixedAssetsOrderDTO)ItemUpdate).Id_Parent
                    };
                    fixedAssetsOrderService.FixedAssetsOrderUpdate(updateModel);

                    FixedAssetsOrderDTO newModel = new FixedAssetsOrderDTO()
                    {
                        InventoryName = updateModel.InventoryName,
                        InventoryNumber = updateModel.InventoryNumber,
                        GroupName = newGroupLookUp.Text,
                        UsefulMonth = (int)newUsefulMonthNumeric.Value,
                        FixedAccountNum = newFixedAccountLookUp.Text,//
                        RegionName = newRegionLookUp.Text,
                        SupplierName = newSupplierLookUp.Text,
                        OperatingPersonName = newOperatingPersonLookUp.Text,
                        BeginRecordDate = (DateTime)dateEdit.DateTime.AddDays(1),
                        Balance_Account_Id = updateModel.Balance_Account_Id,
                        FixedAccountId = updateModel.FixedAccountId,//for list materials
                        Group_Id = (int)newGroupLookUp.EditValue,
                        OperatingPerson_Id = updateModel.OperatingPerson_Id,
                        Region_Id = (int)newRegionLookUp.EditValue,
                        Supplier_Id = updateModel.Supplier_Id,
                        BalanceAccountNum = newBalanceAccountLookUp.Text,
                        PeriodAmortization = updateModel.PeriodAmortization,//
                        IncreasePrice = updateModel.IncreasePrice,
                        PeriodYearAmortization = updateModel.PeriodYearAmortization,//
                        TotalPrice = updateModel.TotalPrice,
                        BeginPrice = updateModel.BeginPrice,
                        BeginDate = updateModel.BeginDate,
                        CurrentPrice = updateModel.CurrentPrice,//
                        CurrentAmortization = updateModel.CurrentAmortization,//
                        Id_Parent = updateModel.Id
                    };
                    var idNewModel = fixedAssetsOrderService.FixedAssetsOrderCreate(newModel);
                    materialsList.Select(s => { s.FixedAssetsOrder_Id = updateModel.Id; return s; }).ToList();

                    foreach (var item in materialsList)
                    {

                        FixedAssetsMaterialsDTO createMaterialsModel = new FixedAssetsMaterialsDTO()
                        {
                            FixedAssetsOrder_Id = idNewModel,
                            Expenditures_Id = item.Expenditures_Id,
                            Fixed_Account_Id = item.Fixed_Account_Id,
                            FixedPrice = item.FixedPrice,
                            Description = item.Description,
                            MaterialsDate = item.MaterialsDate,
                            DebitAccountId = item.DebitAccountId,
                            Flag = item.Flag,
                            SoldPrice = item.SoldPrice
                        };
                        fixedAssetsOrderService.FixedAssetsOrderMaterialsCreate(createMaterialsModel);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Необхідно заповнити поле 'Місце знаходження' ", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion

        #region Event's
        
       
        private void saveBtn_Click(object sender, EventArgs e)
        {
            #region Validation

            int amountOfChange = 0;

            amountOfChange += (balanceAccountEdit.Text == newBalanceAccountLookUp.Text) ? 0 : 1;
            amountOfChange += (groupEdit.Text == newGroupLookUp.Text) ? 0 : 1;
            amountOfChange += (usefulMonthEdit.Text == newUsefulMonthNumeric.Value.ToString()) ? 0 : 1;
            amountOfChange += (fixedAccountEdit.Text == newFixedAccountLookUp.Text) ? 0 : 1;
            amountOfChange += (regionEdit.Text == newRegionLookUp.Text) ? 0 : 1;
            amountOfChange += (supplierEdit.Text == newSupplierLookUp.Text) ? 0 : 1;
            amountOfChange += (operatingPersonEdit.Text == newOperatingPersonLookUp.Text) ? 0 : 1;

            #endregion
            if (amountOfChange > 0)
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
                        MessageBox.Show("error" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Змініть інформацію для переміщення картки основного засобу!", "Переміщення основного засобу", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.ItemUpdate.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion


        private bool ControlValidation()
        {
            return dxValidationProvider.Validate();
        }
        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
        }

        private void dateEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }
    }
}