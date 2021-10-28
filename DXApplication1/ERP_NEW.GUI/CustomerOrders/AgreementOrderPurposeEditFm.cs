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
using ERP_NEW.BLL.Interfaces;
using Ninject;

namespace ERP_NEW.GUI.CustomerOrders
{
    public partial class AgreementOrderPurposeEditFm : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource agreementOrderPurposeBS = new BindingSource();
        private IContractorsService contractorsService;
        private Utils.Operation operation;


        public AgreementOrderPurposeEditFm(Utils.Operation operation, AgreementOrderPurposeDTO model)
        {
            InitializeComponent();

            this.operation = operation;

            agreementOrderPurposeBS.DataSource = model;

            contractorsService = Program.kernel.Get<IContractorsService>();

            nameAgreementOrderPurposeEdit.DataBindings.Add("EditValue", agreementOrderPurposeBS, "Purpose", true, DataSourceUpdateMode.OnPropertyChanged);

            if (operation == Utils.Operation.Update)
            {
                nameAgreementOrderPurposeEdit.EditValue = model.Purpose;
            }
            else
            {
                nameAgreementOrderPurposeEdit.EditValue = null;
            }

        }
        public int Return()
        {
            return ((AgreementOrderPurposeDTO)agreementOrderPurposeBS.Current).Id;
        }

        private bool SaveItem()
        {
            agreementOrderPurposeBS.EndEdit();
            contractorsService = Program.kernel.Get<IContractorsService>();

            if (operation == Utils.Operation.Add)
            {
                if (((AgreementOrderPurposeDTO)agreementOrderPurposeBS.Current).Purpose != "")
                    ((AgreementOrderPurposeDTO)agreementOrderPurposeBS.Current).Id = contractorsService.AgreementOrderPurposeCreate((AgreementOrderPurposeDTO)agreementOrderPurposeBS.Current);
                else
                    return false;
            }
            else
                contractorsService.AgreementsOrderPurposeUpdate((AgreementOrderPurposeDTO)agreementOrderPurposeBS.Current);
            return true;


        }

        


        private void saveAddNewPurposeBtn_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Помилка: " + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelAddNewPurposeBtn_Click(object sender, EventArgs e)
        {
            agreementOrderPurposeBS.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void nameAgreementOrderPurposeEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveAddNewPurposeBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.saveAddNewPurposeBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }
    }
}