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
    public partial class CashBookContractorEditFm : DevExpress.XtraEditors.XtraForm
    {
        private ICashBookService contractorService;
        private BindingSource contractorBS = new BindingSource();
        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return contractorBS.Current as ObjectBase; }
            set
            {
                contractorBS.DataSource = value;
                value.BeginEdit();
            }
        }


        public CashBookContractorEditFm(Utils.Operation operation, CashBookContractorDTO model)
        {
            InitializeComponent();
            LoadData();
            this.operation = operation;
            contractorBS.DataSource = Item = model;

            cashBookContractorEdit.DataBindings.Add("EditValue", contractorBS, "CashBookContractorName");

            if (this.operation == Utils.Operation.Update)
            {
                cashBookContractorEdit.EditValue = ((CashBookContractorDTO)Item).CashBookContractorName;
            }
            else
            {
                cashBookContractorEdit.EditValue = null;
                Item = model;
            }

            cashBookContractorValidationProvider.Validate();
        }

        #region Method's
       
        private void LoadData()
        {
            contractorService = Program.kernel.Get<ICashBookService>();
            contractorBS.DataSource = contractorService.GetContractors();
        }

        public long Return()
        {
            return ((CashBookContractorDTO)Item).Id;
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();

            contractorService = Program.kernel.Get<ICashBookService>();

            if (operation == Utils.Operation.Add)
            {
                ((CashBookContractorDTO)Item).Id = contractorService.CashBookContractorCreate((CashBookContractorDTO)Item);
            }
            else
            {
                contractorService.CashBookContractorUpdate((CashBookContractorDTO)Item);
            }
            return true;
        }

        #endregion

        #region Event's
        private void saveCashBookContractorBtn_Click(object sender, EventArgs e)
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
                    MessageBox.Show("При збереженні заявки виникла помилка. " + ex.Message, "Збереження контрагента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void cancelCashBookContractorBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        #endregion


        #region Validation's

        private void cashBookContractorValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveCashBookContractorBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void cashBookContractorValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (cashBookContractorValidationProvider.GetInvalidControls().Count == 0);
            this.saveCashBookContractorBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;

        }

        private void cashBookContractorEdit_EditValueChanged(object sender, EventArgs e)
        {
            cashBookContractorValidationProvider.Validate();
        }

 
         
        #endregion



    }
}