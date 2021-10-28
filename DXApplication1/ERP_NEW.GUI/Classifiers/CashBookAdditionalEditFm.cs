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

namespace ERP_NEW.GUI.Classifiers
{
    public partial class CashBookAdditionalEditFm : DevExpress.XtraEditors.XtraForm
    {

        private ICashBookService cashBookService;
        private BindingSource additionalBS = new BindingSource();
        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return additionalBS.Current as ObjectBase; }
            set
            {
                additionalBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public CashBookAdditionalEditFm(Utils.Operation operation, CashBookAdditionalTypeDTO model)
        {
            InitializeComponent();
            LoadData();
            this.operation = operation;
            additionalBS.DataSource = Item = model;

            cashBookAdditionalEdit.DataBindings.Add("EditValue", additionalBS, "NameAdditionalType", true, DataSourceUpdateMode.OnPropertyChanged);
            cashBookAdditionalValidationProvider.Validate();
        }


        #region Method's

        private void LoadData()
        {
            cashBookService = Program.kernel.Get<ICashBookService>();
            additionalBS.DataSource = cashBookService.GetCashBookAdditional();
        }

        public long Return()
        {
            return ((CashBookAdditionalTypeDTO)Item).Id;
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();

            cashBookService = Program.kernel.Get<ICashBookService>();

            if (operation == Utils.Operation.Add)
            {
                //((CashBookAdditionalTypeDTO)Item).NameAdditionalType = (String)cashBookAdditionalEdit.EditValue;
                ((CashBookAdditionalTypeDTO)Item).Id = cashBookService.CashBookAdditionalTypeCreate((CashBookAdditionalTypeDTO)Item);


            }
            else
            {
                cashBookService.CashBookAdditionalTypeUpdate((CashBookAdditionalTypeDTO)Item);
            }
            return true;
        }



        #endregion


        #region Event's
        private void saveCashBookAdditionalBtn_Click(object sender, EventArgs e)
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
                    MessageBox.Show("При збереженні заявки виникла помилка. " + ex.Message, "Збереження додатка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void cancelCashBookAdditionalBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion



        #region Validation's

        private void cashBookAdditionalValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveCashBookAdditionalBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void cashBookAdditionalValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (cashBookAdditionalValidationProvider.GetInvalidControls().Count == 0);
            this.saveCashBookAdditionalBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;

        }

        private void cashBookAdditionalEdit_EditValueChanged(object sender, EventArgs e)
        {
            cashBookAdditionalValidationProvider.Validate();
        }


        #endregion

    }
}