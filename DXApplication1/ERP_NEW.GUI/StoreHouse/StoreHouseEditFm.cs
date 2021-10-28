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
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using DevExpress.XtraGrid.Views.Grid;
using ERP_NEW.BLL.DTO.SelectedDTO;
using Ninject;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class StoreHouseEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IEmployeesService employeesService;

        private BindingSource accountClothesBS = new BindingSource();
        private BindingSource accountClothesMaterialsBS = new BindingSource();
        private BindingSource employeesBS = new BindingSource();
        private BindingSource responsiblePersonBS = new BindingSource();

        private Utils.Operation _operation;

        private List<AccountClothesMaterialsDTO> accountClothesMaterialsList = new List<AccountClothesMaterialsDTO>();
        private List<AccountClothesMaterialsDTO> deleteMaterialsList = new List<AccountClothesMaterialsDTO>();
        private List<EmployeesInfoDTO> employeesList;
        
        private ObjectBase Item
        {
            get { return accountClothesBS.Current as ObjectBase; }
            set
            {
                accountClothesBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public StoreHouseEditFm(Utils.Operation operation, AccountClothesDTO model, List<AccountClothesMaterialsDTO> accountClothesMaterialSource)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            _operation = operation;
            accountClothesMaterialsList = accountClothesMaterialSource;

            accountClothesBS.DataSource = Item = model;
            accountClothesMaterialsBS.DataSource = accountClothesMaterialsList;
            accountsClothesMaterialsGrid.DataSource = accountClothesMaterialsBS;

            docNumberEdit.DataBindings.Add("EditValue", accountClothesBS, "DocNumber");

            docDateEdit.DataBindings.Add("EditValue", accountClothesBS, "DocDate");

            employeesService = Program.kernel.Get<IEmployeesService>();
            employeesList = employeesService.GetEmployeesWorking().ToList();

            employeeEdit.DataBindings.Add("EditValue", accountClothesBS, "EmployeeId");
            employeesBS.DataSource = employeesList;
            employeeEdit.Properties.DataSource = employeesBS;
            employeeEdit.Properties.ValueMember = "EmployeeID";
            employeeEdit.Properties.DisplayMember = "Fio";
            employeeEdit.Properties.NullText = "Немає данних";

            responsiblePersonEdit.DataBindings.Add("EditValue", accountClothesBS, "ResponsiblePersonId", true, DataSourceUpdateMode.OnPropertyChanged);
            responsiblePersonBS.DataSource = employeesList;
            responsiblePersonEdit.Properties.DataSource = responsiblePersonBS;
            responsiblePersonEdit.Properties.ValueMember = "EmployeeID";
            responsiblePersonEdit.Properties.DisplayMember = "Fio";
            responsiblePersonEdit.Properties.NullText = "Немає данних";

            if (_operation == Utils.Operation.Add)
            {
                ((AccountClothesDTO)Item).DocDate = DateTime.Now;
                ((AccountClothesDTO)Item).DocNumber = GetLastNumber();
            }

            splashScreenManager.CloseWaitForm();

            clothesValidationProvider.Validate();
        }

        #region Method's                                 

        private bool SaveItem()
        {
            this.Item.EndEdit();

            if (FindDublicate((AccountClothesDTO)this.Item))
            {
                MessageBox.Show("Картка з таким номером вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (accountClothesMaterialsBS.Count == 0)
            {
                MessageBox.Show("Необхідно додати спецодяг до картки!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (accountClothesMaterialsList.Any(a => a.DateOutput == null || a.QuantityOutput == null))
            {
                MessageBox.Show("Не повністю введена інформація по даті або кількості видачі!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            try
            {
                storeHouseService = Program.kernel.Get<IStoreHouseService>();

                if (deleteMaterialsList.Count > 0)
                {
                    storeHouseService.AccountClothesMaterialsRemoveRange(deleteMaterialsList);
                }

                if (_operation == Utils.Operation.Add)
                {
                    ((AccountClothesDTO)Item).Id = storeHouseService.AccountClothesCreate((AccountClothesDTO)Item);

                    var saveSource = accountClothesMaterialsList.Select(s => { s.AccountClothesId = ((AccountClothesDTO)Item).Id; return s; }).ToList();
                    
                    storeHouseService.AccountClothesMaterialsCreateRange(saveSource);

                    return true;
                }
                else
                {
                    storeHouseService.AccountClothesUpdate((AccountClothesDTO)Item);

                    var saveSource = accountClothesMaterialsList.Select(s => { s.AccountClothesId = ((AccountClothesDTO)Item).Id; return s; }).ToList();

                    foreach (var item in saveSource)
                    {
                        if (item.Id == 0)
                            storeHouseService.AccountClothesMaterialsCreate(item);
                        else
                            storeHouseService.AccountClothesMaterialsUpdate(item);
                    }
                    
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public AccountClothesDTO Return()
        {
            return ((AccountClothesDTO)Item);
        }

        private bool FindDublicate(AccountClothesDTO model)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            return storeHouseService.GetAllAccountClothes().Any(s => s.DocNumber == model.DocNumber && s.Id != model.Id);
        }

        private string GetLastNumber()
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            var allNumberBusinessTrips = storeHouseService.GetAllAccountClothes().OrderByDescending(x => Decimal.
                Parse(x.DocNumber.Replace('/', ','))).FirstOrDefault();

            if (allNumberBusinessTrips != null)
            {
                decimal lastNumberBusinessTrips = Decimal.Parse(allNumberBusinessTrips.DocNumber.Replace('/', ','));
                allNumberBusinessTrips.DocNumber = (Math.Truncate(lastNumberBusinessTrips) + 1).ToString();
                return allNumberBusinessTrips.DocNumber;
            }
            else
            {
                return "1";
            }
        }

        #endregion

        #region Event's                                  

        private void saveBtn_Click(object sender, EventArgs e)
        {
            accountClothesMaterialsGridView.PostEditor();

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
                    MessageBox.Show("При збереженні картки виникла помилка. " + ex.Message, "Збереження картки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void addAccountClothesMaterialsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (StoreHouseMaterialEditFm storeHouseMaterialEditFm = new StoreHouseMaterialEditFm())
            {
                if (storeHouseMaterialEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var returnList = storeHouseMaterialEditFm.Return();

                    accountClothesMaterialsGridView.BeginDataUpdate();

                    accountClothesMaterialsList.AddRange(returnList.Select(s => new AccountClothesMaterialsDTO()
                    {
                        InvoiceRequirementMaterialId = s.Id,
                        NomenclatureId = s.NomenclatureId,
                        NomenclatureName = s.NomenclatureName,
                        NomenclatureNumber = s.Nomenclature,
                        UnitPrice = s.UnitPrice,
                        UnitLocalName = s.UnitLocalName,
                        OrderDate = s.OrderDate,
                        ReceiptNum = s.ReceiptNum,
                        BalanceAccountNum = s.BalanceAccountNum,
                        PercentageOutput = 100
                    }));

                    accountClothesMaterialsBS.DataSource = accountClothesMaterialsList;
                    accountsClothesMaterialsGrid.DataSource = accountClothesMaterialsBS;

                    accountClothesMaterialsGridView.EndDataUpdate();
                }
            }
        }

        private void deleteAccountClothesMaterialsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            accountClothesMaterialsGridView.PostEditor();

            accountClothesMaterialsGridView.BeginDataUpdate();

            deleteMaterialsList.AddRange(accountClothesMaterialsList.Where(t => t.Selection && t.Id != 0));
            accountClothesMaterialsList.RemoveAll(s => s.Selection);

            accountClothesMaterialsBS.DataSource = accountClothesMaterialsList;
            accountsClothesMaterialsGrid.DataSource = accountClothesMaterialsBS;

            accountClothesMaterialsGridView.EndDataUpdate();
        }

        #endregion

        #region Validation

        private bool ControlValidation()
        {
            return clothesValidationProvider.Validate();
        }

        private void clothesValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void clothesValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (clothesValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void docNumberEdit_TextChanged(object sender, EventArgs e)
        {
            clothesValidationProvider.Validate((Control)sender);
        }

        private void docDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            clothesValidationProvider.Validate((Control)sender);
        }

        private void responsiblePersonEdit_EditValueChanged(object sender, EventArgs e)
        {
            clothesValidationProvider.Validate((Control)sender);
        }

        private void employeeEdit_EditValueChanged(object sender, EventArgs e)
        {
            clothesValidationProvider.Validate((Control)sender);
        }

        #endregion

    }
}