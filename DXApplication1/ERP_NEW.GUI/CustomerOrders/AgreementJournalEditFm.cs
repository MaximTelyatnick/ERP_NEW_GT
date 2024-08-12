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
using System.Security.AccessControl;

namespace ERP_NEW.GUI.CustomerOrders
{
    public partial class AgreementJournalEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IContractorsService contractorsService;
        private BindingSource agreementJournalBS = new BindingSource();
        private Utils.Operation operation;
        private List<AgreementsDTO> agreementsList = new List<AgreementsDTO>();
        private IAccountsService accountsService;

        string nameJournalWithTilda = "";
        string homePath = ""; 
        string rezNumber = "";
        int checkCreateDirectory = 0;
        int checkAccessToDirectory = 0;

        public AgreementJournalEditFm(Utils.Operation operation, AgreementsDTO model)
        {
            InitializeComponent();

            this.operation = operation;
            agreementJournalBS.DataSource = Item = model;
            LoadData();          

            // same AgreementsDTO
            List<ContractorsDTO> numberList = contractorsService.GetContractors(5).ToList();

            //List<AgreementsDTO> contractorList = contractorsService.GetAgreements().ToList();

            //numberList.RemoveAll(el => contractorList.Exists(el2 => el2.AgreementsIdFromContractor == el.Id));

            numberLookUpEdit.DataBindings.Add("EditValue", agreementJournalBS, "AgreementsIdFromContractor", true, DataSourceUpdateMode.OnPropertyChanged);

            numberLookUpEdit.Properties.DataSource = numberList;
            numberLookUpEdit.Properties.ValueMember = "Id";
            numberLookUpEdit.Properties.DisplayMember = "Name";
            numberLookUpEdit.Properties.NullText = "Немає данних";

            //if (operation == Utils.Operation.Update)
            //{
            //   numberLookUpEdit.Enabled = false;
            //}
            nameContractorLookUpEdit.DataBindings.Add("EditValue", agreementJournalBS, "ContractorId", true, DataSourceUpdateMode.OnPropertyChanged);

            List<ContractorsDTO> nameContractroList = contractorsService.GetContractors(1).ToList();
            nameContractorLookUpEdit.Properties.DataSource = nameContractroList;
            nameContractorLookUpEdit.Properties.ValueMember = "Id";
            nameContractorLookUpEdit.Properties.DisplayMember = "Name";
            nameContractorLookUpEdit.Properties.NullText = "Немає данних";

            currencyNameEdit.DataBindings.Add("EditValue", agreementJournalBS, "CurrencyId", true, DataSourceUpdateMode.OnPropertyChanged);

            List<CurrencyDTO> curList = contractorsService.GetAgreementsCurrency().ToList();
            currencyNameEdit.Properties.DataSource = curList;
            currencyNameEdit.Properties.ValueMember = "Id";
            currencyNameEdit.Properties.DisplayMember = "Code";
            currencyNameEdit.Properties.NullText = "Немає данних";

            typeLookUpEdit.DataBindings.Add("EditValue", agreementJournalBS, "TypeId", true, DataSourceUpdateMode.OnPropertyChanged);

            List<AgreementsTypeDTO> typeList = contractorsService.GetAgreementsType().ToList();
            typeLookUpEdit.Properties.DataSource = typeList;
            typeLookUpEdit.Properties.ValueMember = "Id";
            typeLookUpEdit.Properties.DisplayMember = "TypeName";
            typeLookUpEdit.Properties.NullText = "Немає данних";

            

            dateEdit.DataBindings.Add("EditValue", agreementJournalBS, "Date", true, DataSourceUpdateMode.OnPropertyChanged);
            totalSumEdit.DataBindings.Add("EditValue", agreementJournalBS, "Price", true, DataSourceUpdateMode.OnPropertyChanged);

            if (operation == Utils.Operation.Add)
            {
                ((AgreementsDTO)Item).Date = DateTime.Now;
                ((AgreementsDTO)Item).Price = 0.00m;
            }
        }
        #region Method's

        private ObjectBase Item
        {
            get { return agreementJournalBS.Current as ObjectBase; }
            set
            {
                agreementJournalBS.DataSource = value;
                value.BeginEdit();
            }
        }
        private void LoadData()
        {
            contractorsService = Program.kernel.Get<IContractorsService>();
            accountsService = Program.kernel.Get<IAccountsService>();
            homePath = DefinitionPathToServer.DefinitionPath();
            if (homePath == "SBD1")
                homePath = @"\\SBD1\Data\Journal\";
            else homePath = @"\\SBD1\Data\DebugJournal\";
        }

        public AgreementsDTO Return()
        {
            return ((AgreementsDTO)Item);
        }

        private bool SaveItem()
        {
            rezNumber = numberLookUpEdit.Text;
            this.Item.EndEdit();
            contractorsService = Program.kernel.Get<IContractorsService>();
            
            if (totalSumEdit.Text.Length < 15)
            {
                if (operation == Utils.Operation.Add)
                {
                    if ((rezNumber != "") && (rezNumber != "Немає данних"))
                    {
                        
                        CreteDirectoryAgreement();
                        if (checkAccessToDirectory == 0)
                        {
                            if (nameJournalWithTilda != "")
                            {

                                if (checkCreateDirectory == 0)
                                {
                                    ((AgreementsDTO)Item).Number = rezNumber;
                                    ((AgreementsDTO)Item).NumberWithTilda = nameJournalWithTilda;
                                    ((AgreementsDTO)Item).UrlNameJournal = homePath + nameJournalWithTilda;
                                    ((AgreementsDTO)Item).Id = contractorsService.AgreementsCreate((AgreementsDTO)Item);
                                }
                                else
                                {
                                    MessageBox.Show("Папка з ім'ям Номер договору вже існує!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Поле Номер договору не створено!");
                                return false;
                            }
                            return true;
                        }
                        else return false;
                    }
                    else
                    {
                        MessageBox.Show("Поле Номер договору порожнє!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                    contractorsService.AgreementsUpdate((AgreementsDTO)Item);
            }
            else
            {
                MessageBox.Show("Довжина суми перевищує 15 символів!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public long Returnl()
        {
            return ((AgreementsDTO)Item).Id;
        }

        private void CreteDirectoryAgreement()
        {
            DirectoryInfo dInfo = new DirectoryInfo(@"\\SBD1\Data");
           
            string nameJournal = rezNumber;
            string num;
            nameJournalWithTilda = nameJournal.Replace("/", "~");
            nameJournalWithTilda.Trim();
            checkCreateDirectory = 0;

            try
            {
                dInfo.GetDirectories();
                List<AgreementsDTO> numberList = contractorsService.GetAgreements().ToList();
                if (numberList.Count != 0)
                {
                    for (int i = 0; i < numberList.Count; i++)
                    {
                        //проверка в базе есть ли такое имя
                        num = numberList[i].Number;
                        if (nameJournal == num)
                        {
                            checkCreateDirectory = 1;
                            i = numberList.Count;
                        }
                        else
                        {
                            //  create directory journal
                            if (!Directory.Exists(homePath + nameJournalWithTilda))
                            {
                                Directory.CreateDirectory(homePath + nameJournalWithTilda);
                                checkCreateDirectory = 0;
                            }
                        }
                    }
                }
                else
                {
                    //  create directory journal
                    if (!Directory.Exists(homePath + nameJournalWithTilda))
                    {
                        Directory.CreateDirectory(homePath + nameJournalWithTilda);
                        checkCreateDirectory = 0;
                    }
                }
            }
            catch (Exception) {
                MessageBox.Show("У вас немає доступу до мережевої папки! Зверніться будь-ласка у відділ АСУП", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkAccessToDirectory = 1;
            }
        }


        #endregion

        #region Event's

        private void nameContractorLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            agreementJournalValidationProvider.Validate((Control)sender);
            if (((ContractorsDTO)nameContractorLookUpEdit.GetSelectedDataRow()) != null && operation == Utils.Operation.Add)
            {
                if (((ContractorsDTO)nameContractorLookUpEdit.GetSelectedDataRow()).Id == 0)
                    nameContractorLookUpEdit.EditValue = contractorsService.GetContractors(1);
            }
        }

        private void totalSumEdit_EditValueChanged(object sender, EventArgs e)
        {
            agreementJournalValidationProvider.Validate((Control)sender);
        }

        private void numberLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            agreementJournalValidationProvider.Validate((Control)sender);
        }

        private void typeLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            agreementJournalValidationProvider.Validate((Control)sender);
        }

        private void currencyNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            agreementJournalValidationProvider.Validate((Control)sender);
        }

        private void saveBut_Click(object sender, EventArgs e)
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
                { MessageBox.Show("" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void cancelBut_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        #endregion

        #region Validation's

        private bool ControlValidation()
        {
            return agreementJournalValidationProvider.Validate();
        }

        private void agreementJournalValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBut.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void agreementJournalValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (agreementJournalValidationProvider.GetInvalidControls().Count == 0);
            this.saveBut.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        #endregion






    }
}