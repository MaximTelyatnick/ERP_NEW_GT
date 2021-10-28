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
using Ninject;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using ERP_NEW.BLL.Infrastructure;


namespace ERP_NEW.GUI.Classifiers
{
    public partial class BasisJournalEditFM : DevExpress.XtraEditors.XtraForm
    {
        private ICashBookService cashBookService;
        private UserTasksDTO _userTasksDTO;
        private BindingSource basisBS = new BindingSource();
        private Utils.Operation _operation;
        

        private ObjectBase Item
        {
            get { return basisBS.Current as ObjectBase; }
            set
            {
                basisBS.DataSource = value;

                value.BeginEdit();
            }
        }


        public BasisJournalEditFM(Utils.Operation operation, CashBookBasisTypeDTO model)
        {
            InitializeComponent();
            LoadData();
            _operation = operation;
            basisBS.DataSource = Item = model;

            basisJournalEdit.DataBindings.Add("EditValue", basisBS, "BasisType");


           

        }

       
        #region Metod's

       
        private void LoadData()
        {
            cashBookService = Program.kernel.Get<ICashBookService>();
            basisBS.DataSource = cashBookService.GetBasis();
        }
        public long Return()
        {
            return ((CashBookBasisTypeDTO)Item).Id;
        }
        private bool SaveItem()
        {
            this.Item.EndEdit();

            cashBookService = Program.kernel.Get<ICashBookService>();

            if (_operation == Utils.Operation.Add)
            {
                ((CashBookBasisTypeDTO)Item).Id = cashBookService.CashBookBasisCreate((CashBookBasisTypeDTO)Item);
            }
            else
            {
                cashBookService.CashBookBasisUpdate((CashBookBasisTypeDTO)Item);
            }
            return true;
        }

        #endregion





        #region Event's
        private void saveBasisJournalBtn_Click(object sender, EventArgs e)
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
                    MessageBox.Show("При береженні заявки виникла помилка. " + ex.Message, "Збереження підстави", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }  

        }

        private void cancelBasisJournalBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        #endregion

        #region Validation's
        
        private void cashBookBasisValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBasisJournalBtn.Enabled = false;
            this.validateLbl.Visible = true;

        }

        private void cashBookBasisValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (cashBookBasisValidationProvider.GetInvalidControls().Count == 0);
            this.saveBasisJournalBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;

        }

        #endregion

        private void basisJournalEdit_EditValueChanged(object sender, EventArgs e)
        {
            cashBookBasisValidationProvider.Validate();
        }
    }
}