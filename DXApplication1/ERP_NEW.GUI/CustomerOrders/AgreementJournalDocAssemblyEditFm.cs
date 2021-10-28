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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraBars;
using Ninject;
using System.IO;
using System.Diagnostics;
using ERP_NEW.BLL.Infrastructure;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ERP_NEW.BLL;
using DevExpress.Data.Filtering;
using System.Reflection;
using System.Collections;

namespace ERP_NEW.GUI.CustomerOrders
{
    public partial class AgreementJournalDocAssemblyEditFm : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource agreementTypesBS = new BindingSource();
        private IContractorsService contractorsService;
        private Utils.Operation operation;
        string typeName = "";
        int checkType = 0;

        public AgreementJournalDocAssemblyEditFm(Utils.Operation operation, AgreementTypeDocumentsDTO model)
        {
            InitializeComponent();

            this.operation = operation;
            agreementTypesBS.DataSource = Item = model;
            LoadData();
            nameNewDocEdit.DataBindings.Add("EditValue", agreementTypesBS, "TypeDocuments", true, DataSourceUpdateMode.OnPropertyChanged);

            if (operation == Utils.Operation.Update)
            {
                nameNewDocEdit.EditValue = ((AgreementTypeDocumentsDTO)Item).TypeDocuments;
            }
            else
            {
                nameNewDocEdit.EditValue = null;
                Item = model;
            }
        }
        #region Method's
        
        public AgreementJournalDocAssemblyEditFm()
        {
            InitializeComponent();
        }

        private ObjectBase Item
        {
            get { return agreementTypesBS.Current as ObjectBase; }
            set
            {
                agreementTypesBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public long Return()
        {
            return ((AgreementTypeDocumentsDTO)Item).Id;
        }

        private void LoadData()
        {
            contractorsService = Program.kernel.Get<IContractorsService>();
        }

        private bool SaveItem()
        {
            typeName = nameNewDocEdit.Text;
            this.Item.EndEdit();
            contractorsService = Program.kernel.Get<IContractorsService>();
            checkType = 0;
            CheckTypeDocumentsForUniqueness();
            if (checkType == 0)
            {
                if (operation == Utils.Operation.Add)
                    if (typeName != "")

                        ((AgreementTypeDocumentsDTO)Item).Id = contractorsService.AgreementsTypeDocumentsCreate((AgreementTypeDocumentsDTO)Item);
                    else return false;
                else
                    contractorsService.AgreementsTypeDocumentsUpdate((AgreementTypeDocumentsDTO)Item);
                return true;

            }
            else MessageBox.Show("Такий тип документу вже існує!");
            return false;


        }
        private void CheckTypeDocumentsForUniqueness()
        {
            string typeDoc;

            List<AgreementTypeDocumentsDTO> typeList = contractorsService.GetAgreementsTypeDocuments().ToList();
            if (typeList.Count > 0)
            {
                for (int i = 0; i < typeList.Count; i++)
                {
                    typeDoc = typeList[i].TypeDocuments;
                    if (typeName == typeDoc)
                    {
                        checkType = 1;
                        i = typeList.Count;
                    }
                }
            }
        }
        #endregion

        #region Validation's

        private void nameNewDocEdit_EditValueChanged(object sender, EventArgs e)
        {
            agreementJournalDocAssemblyValidationProvider.Validate((Control)sender);
        }

        private void agreementJournalDocAssemblyValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveAddNewDocBut.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void agreementJournalDocAssemblyValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (agreementJournalDocAssemblyValidationProvider.GetInvalidControls().Count == 0);
            this.saveAddNewDocBut.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }
        #endregion

        #region Event's
        private void saveAddNewDocBut_Click(object sender, EventArgs e)
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
                { MessageBox.Show("error" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void cancelAddNewDocBut_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }

}