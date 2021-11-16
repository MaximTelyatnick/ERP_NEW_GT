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
using ERP_NEW.BLL.Infrastructure;
using DevExpress.XtraEditors.DXErrorProvider;

namespace ERP_NEW.GUI.MTS
{
    public partial class MtsSpecificationEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IMtsSpecificationsService mtsSpecificationsService;
        private IEmployeesService employeesService;

        private BindingSource mtsAssembliesBS = new BindingSource();
        private BindingSource mtsRootAssembliesBS = new BindingSource();
        private BindingSource mtsSpecificationBS = new BindingSource();
        private BindingSource employeesBS = new BindingSource();

        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return mtsSpecificationBS.Current as ObjectBase; }
            set
            {
                mtsSpecificationBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public MtsSpecificationEditFm(Utils.Operation operation, MtsSpecificationsDTO model)
        {
            InitializeComponent();
            this.operation = operation;
            mtsSpecificationBS.DataSource = Item = model;
            
            LoadData();

            nameTBox.DataBindings.Add("EditValue", mtsAssembliesBS, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            drawingTBox.DataBindings.Add("EditValue", mtsAssembliesBS, "Drawing", true, DataSourceUpdateMode.OnPropertyChanged);
            descriptionTBox.DataBindings.Add("EditValue", mtsAssembliesBS, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            dateCreatedEdit.DataBindings.Add("EditValue", mtsAssembliesBS, "DateAdded", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityTBox.DataBindings.Add("EditValue", mtsSpecificationBS, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged);
            userTBox.DataBindings.Add("EditValue", mtsSpecificationBS, "UserName", true, DataSourceUpdateMode.OnPropertyChanged);

            assemblieParentEdit.Properties.DataSource = mtsRootAssembliesBS;
            assemblieParentEdit.Properties.ValueMember = "Id";
            assemblieParentEdit.Properties.DisplayMember = "Drawing";
            assemblieParentEdit.Properties.NullText = "Немає данних";

            designerEdit.Properties.DataSource = employeesBS;
            designerEdit.Properties.ValueMember = "EmployeeID";
            designerEdit.Properties.DisplayMember = "Fio";
            designerEdit.Properties.NullText = "Немає данних";

            if (this.operation == Utils.Operation.Update)
            {
                designerEdit.EditValue = ((MtsSpecificationsDTO)Item).DesignerId;
                assemblieParentEdit.EditValue = ((MtsSpecificationsDTO)Item).ParentId;

                if (((MtsSpecificationsDTO)Item).ParentId == null)
                {
                    assemblieParentEdit.Enabled = false;
                    drawingTBox.Enabled = false;
                    nameTBox.Enabled = false;
                    dateCreatedEdit.Enabled = false;
                    designerEdit.Enabled = false;
                }
                else
                {
                    SetValidationRuleForAssemblyParentEdit();
                }
            }
            else
            {
                designerEdit.EditValue = null;
                assemblieParentEdit.EditValue = null;
                ((MtsSpecificationsDTO)Item).DateAdded = DateTime.Today;
                ((MtsSpecificationsDTO)Item).UserId = UserService.AuthorizatedUser.UserId;
                ((MtsSpecificationsDTO)Item).UserName = UserService.AuthorizatedUser.Fio;

                if (((MtsSpecificationsDTO)Item).ParentId == null)
                {
                    SetValidationRuleForAssemblyParentEdit();
                }
            }

            drawingTBox.Focus();
            assemblyValidationProvider.Validate();
        }

        private void LoadData()
        {
            mtsSpecificationsService = Program.kernel.Get<IMtsSpecificationsService>();
            employeesService = Program.kernel.Get<IEmployeesService>();

            employeesBS.DataSource = employeesService.GetEmployeesWorking();
            mtsRootAssembliesBS.DataSource = mtsSpecificationsService.GetMtsAssembliesByRoot(((MtsSpecificationsDTO)Item).RootId);
            mtsSpecificationBS.DataSource = mtsSpecificationsService.GetMtsAssemblyById(((MtsSpecificationsDTO)Item).AssemblyId ?? 0);
        }

        private void SetValidationRuleForAssemblyParentEdit()
        {
            ConditionValidationRule rule = new ConditionValidationRule();
            
            rule.ConditionOperator = ConditionOperator.IsNotBlank;
            rule.ErrorText = "Виберіть кореневий вузол";
            rule.ErrorType = ErrorType.Critical;

            assemblyValidationProvider.SetValidationRule(assemblieParentEdit, rule);
        }

        public MtsSpecificationsDTO Return()
        {
            return (MtsSpecificationsDTO)Item;
        }

        private bool FindDublicate(MtsAssembliesDTO model)
        {
            mtsSpecificationsService = Program.kernel.Get<IMtsSpecificationsService>();
            return mtsSpecificationsService.GetAllMtsAssemblies().Any(a => a.Drawing == model.Drawing && a.Id != model.Id);
        }

        private bool SaveAssemblySpecification()
        {
            this.Item.EndEdit();

            mtsAssembliesBS.EndEdit();

            if (FindDublicate((MtsAssembliesDTO)mtsAssembliesBS.Current))
            {
                MessageBox.Show("Проект з таким номером вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
            try
            {
                ((MtsAssembliesDTO)mtsAssembliesBS.Current).DesignerId = ((EmployeesInfoDTO)designerEdit.GetSelectedDataRow()).EmployeeID;
                ((MtsAssembliesDTO)mtsAssembliesBS.Current).UserId = UserService.AuthorizatedUser.UserId;

                if (this.operation == Utils.Operation.Add)
                {
                    ((MtsAssembliesDTO)mtsAssembliesBS.Current).DateCreated = DateTime.Now;
                    ((MtsAssembliesDTO)mtsAssembliesBS.Current).AssemblyStatus = 2;
                    
                    ((MtsAssembliesDTO)Item).Id = mtsSpecificationsService.CreateAssembly((MtsAssembliesDTO)mtsAssembliesBS.Current);
                }
                else
                {
                    mtsSpecificationsService.UpdateAssembly(((MtsAssembliesDTO)mtsAssembliesBS.Current));
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveAssemblySpecification())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void assemblieParentEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.mtsRootAssembliesBS.EndEdit();
            parentNameTBox.EditValue = ((MtsAssembliesDTO)assemblieParentEdit.GetSelectedDataRow()).Name;
            parentDateCreatedEdit.EditValue = ((MtsAssembliesDTO)assemblieParentEdit.GetSelectedDataRow()).DateCreated;

            assemblyValidationProvider.Validate((Control)sender);
        }

        #region Validate event's

        private void drawingTBox_TextChanged(object sender, EventArgs e)
        {
            assemblyValidationProvider.Validate((Control)sender);
        }

        private void nameTBox_TextChanged(object sender, EventArgs e)
        {
            assemblyValidationProvider.Validate((Control)sender);
        }

        private void quantityTBox_TextChanged(object sender, EventArgs e)
        {
            assemblyValidationProvider.Validate((Control)sender);
        }

        private void designerEdit_EditValueChanged(object sender, EventArgs e)
        {
            assemblyValidationProvider.Validate((Control)sender);
        }

        private void assemblyValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (assemblyValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void assemblyValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;

        }
        #endregion

        
    }
}