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
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;

namespace ERP_NEW.GUI.Classifiers
{
    public partial class ProfessionEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IEmployeesService employeesService;

        private BindingSource professionBS = new BindingSource();

        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return professionBS.Current as ObjectBase; }
            set
            {
                professionBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public ProfessionEditFm(Utils.Operation operation, ProfessionsDTO model)
        {
            InitializeComponent();

            this.operation = operation;
            professionBS.DataSource = Item = model;
            professionNameEdit.DataBindings.Add("EditValue", professionBS, "Name");
            professionCodeEdit.DataBindings.Add("EditValue", professionBS, "Code");
            dxValidationProvider.Validate();
        }

        #region Method's

        private bool SaveProfession()
        {
            this.Item.EndEdit();

            employeesService = Program.kernel.Get<IEmployeesService>();

            if (operation == Utils.Operation.Add)
            {
                ((ProfessionsDTO)Item).ProfessionGroupID = 5;
                ((ProfessionsDTO)Item).ProfessionID = employeesService.GetLastProfessionId() + 1;
                employeesService.ProfessionCreate((ProfessionsDTO)Item);
            }
            else
            {
                employeesService.ProfessionUpdate((ProfessionsDTO)Item);
            }
            return true;
        }

        private bool FindDublicate(ProfessionsDTO model)
        {
            return employeesService.GetProfessions().Any(s => s.Name.Trim() == model.Name.Trim());
        }

        public long Return()
        {
            return ((ProfessionsDTO)Item).ProfessionID;
        }

        #endregion

        #region Event's

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveProfession())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        #endregion


        #region Validation's

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void professionNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void professionCodeEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        #endregion

        
    }
}