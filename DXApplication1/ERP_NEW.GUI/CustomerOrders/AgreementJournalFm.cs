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
    public partial class AgreementJournalFm : DevExpress.XtraEditors.XtraForm
    {
        private UserTasksDTO userTasksDTO;
        private IContractorsService contractorsService;

        private BindingSource agreementJournalBS = new BindingSource();
        private BindingSource testBS = new BindingSource();
        string homePath = "";

        private BindingSource documentsBS = new BindingSource();
        int checkDeleteFileJournal = 0;

        IContractorsService contractorService;

        public AgreementJournalFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            this.userTasksDTO = userTasksDTO;

            DateTime firstDay = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime lastDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            firstDateEdit.EditValue = firstDay;
            lastDateEdit.EditValue = lastDay.AddMonths(1).AddDays(-1);

            LoadData();

            AuthorizatedUserAccess();
        }


        #region Method's

        public void AuthorizatedUserAccess()
        {
            //2=write
            addAgreemBut.Enabled = (userTasksDTO.AccessRightId == 2);
            addDocBut.Enabled = (userTasksDTO.AccessRightId == 2);
            editAgreemBut.Enabled = (userTasksDTO.AccessRightId == 2);
            editDocBut.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteAgreemBut.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteDocBut.Enabled = (userTasksDTO.AccessRightId == 2);

            //agreement department
            if (userTasksDTO.UserRoleId == 8)
            {
                deleteAgreemBut.Enabled = (userTasksDTO.AccessRightId == 1);
                deleteDocBut.Enabled = (userTasksDTO.AccessRightId == 1);
            }
        }

        private void LoadData()
        {
            contractorsService = Program.kernel.Get<IContractorsService>();
            agreementJournalBS.DataSource = contractorsService.GetAgreementJournal((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
            contractorGrid.DataSource = agreementJournalBS;
            if (agreementJournalBS.Count == 0)
                documentGrid.DataSource = null;
            else
                documentGrid.DataSource = documentsBS;           
        }

        private void AddAgreementsJournal(Utils.Operation operation, AgreementsDTO model)
        {
            using (AgreementJournalEditFm agreementJournalEditFm = new AgreementJournalEditFm(operation, model))
            {
                if (agreementJournalEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    AgreementsDTO return_Id = agreementJournalEditFm.Return();
                    contractorGridView.BeginDataUpdate();
                    LoadData();
                    contractorGridView.EndDataUpdate();
                }
            }
        }

        private void DeleteAgreementsJournal()
        {
            if (agreementJournalBS.Count != 0)
            {
                if (MessageBox.Show("Видалити запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    contractorsService = Program.kernel.Get<IContractorsService>();

                    DeleteFileJournal();
                    if (checkDeleteFileJournal == 0)
                    {
                        if (contractorsService.AgreementsDelete(((AgreementJournalDTO)agreementJournalBS.Current).AgreementId))
                        {
                            int rowHandle = contractorGridView.FocusedRowHandle - 1;
                            contractorGridView.BeginDataUpdate();
                            LoadData();
                            contractorGridView.EndDataUpdate();
                            contractorGridView.FocusedRowHandle = (contractorGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                        }
                    }
                }
            }
        }


        private void AddAgreementsJournalDoc(Utils.Operation operation, AgreementJournalDTO modelJournal, AgreementDocumentsDTO modelDocuments, UserTasksDTO userTaskDTO)
        {
            using (AgreementJournalDocEditFm agreementJournalDocEditFm = new AgreementJournalDocEditFm(operation, modelJournal, modelDocuments, userTaskDTO))
            {
                if (agreementJournalDocEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    AgreementDocumentsDTO return_Id = agreementJournalDocEditFm.Return();
                    documentGridView.BeginDataUpdate();
                    LoadDocuments(((AgreementJournalDTO)agreementJournalBS.Current).AgreementId);
                    documentGridView.EndDataUpdate();
                }
            }
        }

        private void DeleteAgreementsJournalDoc()
        {

            if (documentsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    contractorsService = Program.kernel.Get<IContractorsService>();
                    documentGridView.BeginDataUpdate();
                    DeleteFileJournalDocument();
                    if (contractorsService.AgreementsDocumentsDelete(((AgreementDocumentsDTO)documentsBS.Current).Id))
                    {
                        LoadDocuments(((AgreementJournalDTO)agreementJournalBS.Current).AgreementId);//LoadData();
                        contractorsService.GetAgreementsDocuments();
                    }
                    documentGridView.EndDataUpdate();
                }
            }
        }

        private void DeleteFileJournal()
        {
            checkDeleteFileJournal = 0;
          
            // delete directory journal
            homePath = ((AgreementJournalDTO)agreementJournalBS.Current).UrlNameJournal;
            if (Directory.Exists(homePath))
            {
                Directory.Delete(homePath, true);            
            }
            else
            {
                MessageBox.Show("Ім'я папки не існує! Видалення папки не можливе!");
                checkDeleteFileJournal = 1;
            }
        }

        private void DeleteFileJournalDocument()
        {
            documentGridView.BeginDataUpdate();
            // delete directory document
            homePath = ((AgreementDocumentsDTO)documentsBS.Current).URL;
            if (File.Exists(homePath))
                File.Delete(homePath);
            //else MessageBox.Show("Ім'я папки не існує! Видалення папки не можливе!");
            documentGridView.EndDataUpdate();
        }

        private ObjectBase Item
        {
            get { return documentsBS.Current as ObjectBase; }
            set
            {
                documentsBS.DataSource = value;
                value.BeginEdit();
            }
        }

        private ObjectBase ItemJournal
        {
            get { return agreementJournalBS.Current as ObjectBase; }
            set
            {
                agreementJournalBS.DataSource = value;
                value.BeginEdit();
            }
        }

        private void LoadDocuments(int btdId)
        {
            contractorService = Program.kernel.Get<IContractorsService>();
            documentsBS.DataSource = contractorService.GetAgreementDocumentsByAgreementId(btdId);
            documentGrid.DataSource = documentsBS;
        }
        #endregion


        #region Event's

        private void searchBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void addAgreemBut_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddAgreementsJournal(Utils.Operation.Add, new AgreementsDTO());
        }


        private void editAgreemBut_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (agreementJournalBS.Count > 0)
            {
                AgreementsDTO model = new AgreementsDTO()
                {
                    Id = ((AgreementJournalDTO)ItemJournal).AgreementId,
                    Number = ((AgreementJournalDTO)ItemJournal).NumberOrder,
                    UrlNameJournal = ((AgreementJournalDTO)ItemJournal).UrlNameJournal,
                    NumberWithTilda = ((AgreementJournalDTO)ItemJournal).NumberWithTilda,
                    AgreementsIdFromContractor = ((AgreementJournalDTO)ItemJournal).ContractorId,
                    Price = ((AgreementJournalDTO)ItemJournal).Price,
                    Date = ((AgreementJournalDTO)ItemJournal).DateOrder,
                    CurrencyId = ((AgreementJournalDTO)ItemJournal).CurrencyId,
                    TypeId = ((AgreementJournalDTO)ItemJournal).TypeId,
                    ContractorId = ((AgreementJournalDTO)ItemJournal).ContractorId
                };
                AddAgreementsJournal(Utils.Operation.Update, (AgreementsDTO)model);
            }
            else MessageBox.Show("Помилка редагування договору! Створіть спочатку договір!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void deleteAgreemBut_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (agreementJournalBS.Count > 0)
                DeleteAgreementsJournal();
            else MessageBox.Show("Помилка видалення договору! Створіть спочатку договір!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void addDocBut_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (agreementJournalBS.Count > 0)
                AddAgreementsJournalDoc(Utils.Operation.Add, (AgreementJournalDTO)agreementJournalBS.Current, new AgreementDocumentsDTO(), userTasksDTO);
            else MessageBox.Show("Помилка створення документу! Створіть спочатку договір!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void editDocBut_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (documentsBS.Count > 0)
                AddAgreementsJournalDoc(Utils.Operation.Update, (AgreementJournalDTO)agreementJournalBS.Current, (AgreementDocumentsDTO)documentsBS.Current, userTasksDTO);
            else MessageBox.Show("Помилка редагування документу! Документа не існує!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void deleteDocBut_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (documentsBS.Count > 0)
                DeleteAgreementsJournalDoc();
            else MessageBox.Show("Помилка видалення документу!Оберіть документ!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void contractorGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var model = (AgreementJournalDTO)contractorGridView.GetRow(e.FocusedRowHandle) ?? null;

            if (model != null)
                LoadDocuments(((AgreementJournalDTO)agreementJournalBS.Current).AgreementId);
        }

        private void documentGridView_DoubleClick(object sender, EventArgs e)
        {
            string url = "";

            if (documentsBS.Count > 0)
            {
                url = ((AgreementDocumentsDTO)documentsBS.Current).URL;
                if (url != "")
                {
                    try
                    {
                        Process.Start(url);
                    }
                    catch (Win32Exception win32Exception)
                    {
                        //The system cannot find the file specified...
                        Console.WriteLine(win32Exception.Message);
                    }
                }
            }
        }
        #endregion
    }
}