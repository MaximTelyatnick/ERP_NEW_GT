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
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;
using ERP_NEW.BLL.Interfaces;

namespace ERP_NEW.GUI.Classifiers
{
    public partial class NomenclaturesMaterialsEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IContractorsService contractorService;
        private IUnitsService unitsService;
        private IAccountsService accountsService;

        private BindingSource nomenclatureMaterialsBS = new BindingSource();
        private BindingSource nomenclatureGroupsBS = new BindingSource();
        private BindingSource accountBalanceBS = new BindingSource();
        private BindingSource unitLocalNameBS = new BindingSource();

        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return nomenclatureMaterialsBS.Current as ObjectBase; }
            set
            {
                nomenclatureMaterialsBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public NomenclaturesMaterialsEditFm(Utils.Operation operation, NomenclaturesDTO model)
        {
            InitializeComponent();
 
            LoadData();

            _operation = operation;

            nomenclatureMaterialsBS.DataSource = Item = model;
            
            nomenclatureNumberEdit.DataBindings.Add("EditValue", nomenclatureMaterialsBS, "Nomenclature", true, DataSourceUpdateMode.OnPropertyChanged);
            nomenclatureNameEdit.DataBindings.Add("EditValue", nomenclatureMaterialsBS, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            //unitNameEdit.DataBindings.Add("Text", nomenclatureMaterialsBS, "Measure", true, DataSourceUpdateMode.OnPropertyChanged);

            balanceAccountEdit.DataBindings.Add("EditValue", nomenclatureMaterialsBS, "BALANCE_ACCOUNT_ID", true, DataSourceUpdateMode.OnPropertyChanged);
            balanceAccountEdit.Properties.DataSource = accountsService.GetAccounts();
            balanceAccountEdit.Properties.ValueMember = "Id";
            balanceAccountEdit.Properties.DisplayMember = "Num";
            balanceAccountEdit.Properties.NullText = "Немає данних";

            unitNameEdit.DataBindings.Add("EditValue", nomenclatureMaterialsBS, "UnitId", true, DataSourceUpdateMode.OnPropertyChanged);
            unitNameEdit.Properties.DataSource = unitsService.GetUnits();
            unitNameEdit.Properties.ValueMember = "UnitId";
            unitNameEdit.Properties.DisplayMember = "UnitLocalName";
            unitNameEdit.Properties.NullText = "Немає данних";

            groupNameEdit.DataBindings.Add("EditValue", nomenclatureMaterialsBS, "Nomencl_Group_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            groupNameEdit.Properties.DataSource = storeHouseService.GetAllNomenclaturesGroups();
            groupNameEdit.Properties.ValueMember = "Id";
            groupNameEdit.Properties.DisplayMember = "Name";
            groupNameEdit.Properties.NullText = "Немає данних";

            if (_operation == Utils.Operation.Add)
                ((NomenclaturesDTO)Item).Nomencl_Group_Id = model.Nomencl_Group_Id;

            ControlValidation();
        }

        #region Method's                                      

        private void LoadData()
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            contractorService = Program.kernel.Get<IContractorsService>();
            unitsService = Program.kernel.Get<IUnitsService>();
            accountsService = Program.kernel.Get<IAccountsService>();
        }

        public NomenclaturesDTO Return()
        {
            ((NomenclaturesDTO)Item).Num = accountsService.GetAccounts().First(bdsm => bdsm.Id == ((NomenclaturesDTO)Item).BALANCE_ACCOUNT_ID).Num;
            ((NomenclaturesDTO)Item).UnitLocalName = unitsService.GetUnits().First(bdsm => bdsm.UnitId == ((NomenclaturesDTO)Item).UnitId).UnitLocalName;

            return ((NomenclaturesDTO)Item);
        }

        private bool CheckNomenclatureNum()
        {

            var nomenclatures = storeHouseService.GetAllNomenclatures();

            string searchNomenclature = ((NomenclaturesDTO)Item).Nomenclature;

            if (!nomenclatures.Any(bdsm => bdsm.Nomenclature == searchNomenclature && bdsm.ID != ((NomenclaturesDTO)Item).ID))
                    return true;
                else
                    return false;
            
        }

        private bool SaveNomenclatureMaterials()
        {
            this.Item.EndEdit();

            if (!CheckNomenclatureNum())
            {
                MessageBox.Show("Номенклатура з таким номером вже існує", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (_operation == Utils.Operation.Add)
            {
                ((NomenclaturesDTO)nomenclatureMaterialsBS.Current).Measure = unitNameEdit.Text;
                ((NomenclaturesDTO)Item).ID = storeHouseService.NomenclatureMaterialsCreate((NomenclaturesDTO)nomenclatureMaterialsBS.Current);
            }
            else
            {
                ((NomenclaturesDTO)nomenclatureMaterialsBS.Current).Measure = unitNameEdit.Text;
                storeHouseService.NomenclatureMaterialsUpdate((NomenclaturesDTO)nomenclatureMaterialsBS.Current);
            }

            DialogResult = DialogResult.OK;
            this.Close();

            return true;
        }

        #endregion

        #region Event's                                       

        private void balanceAccountEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (balanceAccountEdit.EditValue != DBNull.Value)
            {
                ((NomenclaturesDTO)Item).BALANCE_ACCOUNT_ID = (int)balanceAccountEdit.EditValue;

                long? nextNomenclatureNumber = Int64.Parse(storeHouseService.GetLastNomenclatureNumber((int)balanceAccountEdit.EditValue, balanceAccountEdit.Text)) + 1;

                nomenclatureNumberEdit.EditValue = nextNomenclatureNumber.ToString();
            }

            nomenclatureValidationProvider.Validate((Control)sender);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveNomenclatureMaterials())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("При береженні номенклатури виникла помилка. " + ex.Message, "Збереження номенклатури", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void unitNameEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            unitsService = Program.kernel.Get<IUnitsService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (UnitEditFm unitsEditFm = new UnitEditFm(Utils.Operation.Add, new UnitsDTO()))
                        {
                            if (unitsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = unitsEditFm.Return();
                                unitsService = Program.kernel.Get<IUnitsService>();
                                unitNameEdit.Properties.DataSource = unitsService.GetUnits();
                                unitNameEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 2://Редагувати
                    {
                        if (unitNameEdit.EditValue == DBNull.Value)
                            return;

                        using (UnitEditFm unitsEditFm = new UnitEditFm(Utils.Operation.Update, (UnitsDTO)unitNameEdit.GetSelectedDataRow()))
                        {
                            if (unitsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = unitsEditFm.Return();
                                unitsService = Program.kernel.Get<IUnitsService>();
                                unitNameEdit.Properties.DataSource = unitsService.GetUnits();
                                unitNameEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 3://Видалити
                    {
                        if (unitNameEdit.EditValue == DBNull.Value)
                            return;

                        if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            unitsService.UnitDelete(((UnitsDTO)unitNameEdit.GetSelectedDataRow()).UnitId);
                            unitsService = Program.kernel.Get<IUnitsService>();
                            unitNameEdit.Properties.DataSource = unitsService.GetUnits();
                            unitNameEdit.EditValue = null;
                            unitNameEdit.Properties.NullText = "Немає данних";
                        }

                        break;
                    }
                case 4://Очистити
                    {
                        unitNameEdit.EditValue = null;
                        unitNameEdit.Properties.NullText = "Немає данних";
                        break;
                    }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region Validation                                    

        private bool ControlValidation()
        {
            return nomenclatureValidationProvider.Validate();
        }

        private void nomenclatureValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void nomenclatureValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (nomenclatureValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void groupNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            nomenclatureValidationProvider.Validate((Control)sender);
        }

        private void nomenclatureNumberEdit_EditValueChanged(object sender, EventArgs e)
        {
            nomenclatureValidationProvider.Validate((Control)sender);
        }

        private void nomenclatureNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            nomenclatureValidationProvider.Validate((Control)sender);
        }

        private void unitNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            nomenclatureValidationProvider.Validate((Control)sender);
        }

        #endregion

        private void groupNameEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                balanceAccountEdit.Focus();
        }

        private void balanceAccountEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                nomenclatureNumberEdit.Focus();
        }

        private void nomenclatureNumberEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                nomenclatureNameEdit.Focus();
        }

        private void nomenclatureNameEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                unitNameEdit.Focus();
        }

        private void unitNameEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                saveBtn.Focus();
        }
    }
}