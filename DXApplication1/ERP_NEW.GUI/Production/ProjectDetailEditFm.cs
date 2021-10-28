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
using ERP_NEW.BLL.Interfaces;
using Ninject;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.SelectedDTO;

namespace ERP_NEW.GUI.Production
{
    public partial class ProjectDetailEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IProjectDetailsService projectDetailsService;
        private ICustomerOrdersService customerOrdersService;
        private IMtsSpecificationsService mtsSpecificationsService;

        private BindingSource projectDetailsBS = new BindingSource();
        private BindingSource customerOrdersBS = new BindingSource();
        private BindingSource assemblyBS = new BindingSource();

        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return projectDetailsBS.Current as ObjectBase; }
            set
            {
                projectDetailsBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public ProjectDetailEditFm(Utils.Operation operation, ProjectDetailsDTO model)
        {
            InitializeComponent();

            mtsSpecificationsService = Program.kernel.Get<IMtsSpecificationsService>();
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();

            projectDetailsBS.DataSource = Item = model;
            _operation = operation;

            //assemblyNameTBox.DataBindings.Add("EditValue", projectDetailsBS, "AssemblyName", true, DataSourceUpdateMode.OnPropertyChanged);
            //drawingTBox.DataBindings.Add("EditValue", projectDetailsBS, "Drawing", true, DataSourceUpdateMode.OnPropertyChanged);
            assemblyNameTBox.DataBindings.Add("EditValue", projectDetailsBS, "AssemblyName", true, DataSourceUpdateMode.OnPropertyChanged);
            assemblyDrawingTBox.DataBindings.Add("EditValue", projectDetailsBS, "AssemblyDrawing", true, DataSourceUpdateMode.OnPropertyChanged);
            orderNumberEdit.DataBindings.Add("EditValue", projectDetailsBS, "CustomerOrderId", true, DataSourceUpdateMode.OnPropertyChanged);

            generalAssemblyAsAssemblyCheck.Checked = false;
            //drawingTBox.ReadOnly = true;
            assemblyGeneralNameTBox.ReadOnly = true;

            assemblyBS.DataSource = mtsSpecificationsService.GetJournalAssemblies().OrderByDescending(bdsm => bdsm.DateCreated).ToList();

            assemblyEdit.Properties.DataSource = assemblyBS;
            assemblyEdit.Properties.ValueMember = "AssemblyId";
            assemblyEdit.Properties.DisplayMember = "Drawing";
            assemblyEdit.Properties.NullText = "Немає данних";

            customerOrdersBS.DataSource = customerOrdersService.GetCustomerOrderForWelding(DateTime.MinValue, DateTime.MaxValue).ToList();

            orderNumberEdit.Properties.DataSource = customerOrdersBS;
            orderNumberEdit.Properties.ValueMember = "Id";
            orderNumberEdit.Properties.DisplayMember = "OrderNumber";
            orderNumberEdit.Properties.NullText = "Немає данних";




            //customerOrdersBS.DataSource = customerOrdersService.GetCustomerOrdersFull().OrderByDescending(bdsm => bdsm.OrderDate).ToList();

            //orderNumberEdit.Properties.DataSource = customerOrdersBS;
            //orderNumberEdit.Properties.ValueMember = "Id";
            //orderNumberEdit.Properties.DisplayMember = "OrderNumber";
            //orderNumberEdit.Properties.NullText = "Немає данних";
            
            if (_operation == Utils.Operation.Add)
            {
                //assemblyEdit.EditValue = model.AssemblyId;
                //assemblyDateEdit.EditValue = model.AssemblyDate;
                //if (((ProjectDetailsDTO)Item).AssemblyId != null)
                //{
                //    assemblyEdit.EditValue = ((ProjectDetailsDTO)Item).AssemblyId;
                //    assemblyDateEdit.EditValue = ((ProjectDetailsDTO)Item).AssemblyDate;
                //}
            }
            else if (_operation == Utils.Operation.Add)
            {
                //assemblyEdit.EditValue = ((ProjectDetailsDTO)Item).CustomerOrderId;
                //assemblyDateEdit.EditValue = ((ProjectDetailsDTO)Item).OrderDate;
                long? k = ((ProjectDetailsDTO)Item).AssemblyId;


                assemblyEdit.EditValue = ((ProjectDetailsDTO)Item).AssemblyId;
                assemblyDateEdit.EditValue = ((ProjectDetailsDTO)Item).AssemblyDate;
            }
            else
            {
                assemblyEdit.EditValue = ((ProjectDetailsDTO)Item).AssemblyId;
                assemblyDateEdit.EditValue = ((ProjectDetailsDTO)Item).AssemblyDate;
            }

            projectValidationProvider.Validate();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!ControlValidation()) return;

            if (MessageBox.Show("Зберегти зміни?", "Збереження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveProject();

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void orderNumberEdit_EditValueChanged(object sender, EventArgs e)
        {
            object key = assemblyEdit.EditValue;
            var selectedIndex = assemblyEdit.Properties.GetIndexByKeyValue(key);
            assemblyDateEdit.EditValue = ((MtsAssembliesInfoDTO)assemblyEdit.GetSelectedDataRow()).DateCreated;
            //drawingTBox.EditValue = ((MtsAssembliesInfoDTO)assemblyEdit.GetSelectedDataRow()).Drawing;
            assemblyGeneralNameTBox.EditValue = ((MtsAssembliesInfoDTO)assemblyEdit.GetSelectedDataRow()).Name;
            
            projectValidationProvider.Validate((Control)sender);
        }

        private void projectValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void projectValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (projectValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private bool ControlValidation()
        {
            return projectValidationProvider.Validate();
        }

        private void SaveProject()
        {
            ((ProjectDetailsDTO)Item).AssemblyId = ((MtsAssembliesInfoDTO)assemblyEdit.GetSelectedDataRow()).AssemblyId;
            this.Item.EndEdit();

            projectDetailsService = Program.kernel.Get<IProjectDetailsService>();

            if (_operation == Utils.Operation.Add || _operation == Utils.Operation.Template)
                ((ProjectDetailsDTO)Item).ProjectDetailId = projectDetailsService.ProjectDetailCreate((ProjectDetailsDTO)Item);
            else
                projectDetailsService.ProjectDetailUpdate((ProjectDetailsDTO)Item);        
        }

        public int Return()
        {
            return ((ProjectDetailsDTO)Item).ProjectDetailId;
        }

        private void drawingTBox_TextChanged(object sender, EventArgs e)
        {
            projectValidationProvider.Validate((Control)sender);

        }

        private void assemblyGeneralNameTBox_TextChanged(object sender, EventArgs e)
        {
            //projectValidationProvider.Validate((Control)sender);
        }

        private void assemblyNameTBox_TextChanged(object sender, EventArgs e)
        {
            projectValidationProvider.Validate((Control)sender);
        }

        private void assemblyDrawingTBox_TextChanged(object sender, EventArgs e)
        {
            projectValidationProvider.Validate((Control)sender);
        }

        private void generalAssemblyAsAssemblyCheck_EditValueChanged(object sender, EventArgs e)
        {
            //if (generalAssemblyAsAssemblyCheck.Checked)
            //{
            //    assemblyNameTBox.EditValue = ((ProjectDetailsDTO)Item).AssemblyGeneralName;
            //    assemblyDrawingTBox.EditValue = ((ProjectDetailsDTO)Item).Drawing;
            //}
            //else
            //{
            //    assemblyNameTBox.EditValue = "";
            //    assemblyDrawingTBox.EditValue = "";
            //}
        }

        private void generalAssemblyAsAssemblyCheck_CheckedChanged(object sender, EventArgs e)
        {

            if (assemblyEdit.EditValue != null)
            {
                if (generalAssemblyAsAssemblyCheck.Checked)
                {
                    //assemblyNameTBox.EditValue = ((ProjectDetailsDTO)Item).AssemblyGeneralName;
                    //assemblyDrawingTBox.EditValue = ((ProjectDetailsDTO)Item).Drawing;

                    assemblyNameTBox.EditValue = ((MtsAssembliesInfoDTO)assemblyEdit.GetSelectedDataRow()).Name;
                    assemblyDrawingTBox.EditValue = ((MtsAssembliesInfoDTO)assemblyEdit.GetSelectedDataRow()).Drawing;
                }
                else
                {
                    assemblyNameTBox.EditValue = "";
                    assemblyDrawingTBox.EditValue = "";
                }
            }
        }

        private void assemblyEdit_EditValueChanged(object sender, EventArgs e)
        {
            object key = assemblyEdit.EditValue;
            var selectedIndex = assemblyEdit.Properties.GetIndexByKeyValue(key);
            assemblyDateEdit.EditValue = ((MtsAssembliesInfoDTO)assemblyEdit.GetSelectedDataRow()).DateCreated;
            //drawingTBox.EditValue = ((MtsAssembliesInfoDTO)assemblyEdit.GetSelectedDataRow()).Drawing;
            assemblyGeneralNameTBox.EditValue = ((MtsAssembliesInfoDTO)assemblyEdit.GetSelectedDataRow()).Name;

            

            //projectValidationProvider.Validate((Control)sender);
        }

        private void orderNumberEdit_EditValueChanged_1(object sender, EventArgs e)
        {
            projectValidationProvider.Validate((Control)sender);
        }
    }
}