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
using DevExpress.XtraEditors.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace ERP_NEW.GUI.CustomerOrders
{
    public partial class AgreementJournalDocEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IContractorsService contractorsService;
        private BindingSource agreementJournalBS = new BindingSource();
        private Utils.Operation operation;
        private IAccountsService accountsService;
        public AgreementDocumentsDTO agreementDocumentsDTO = new AgreementDocumentsDTO();
        public AgreementJournalDTO agrementJournalModelDTO = new AgreementJournalDTO();
        public UserTasksDTO userTaskDTO = new UserTasksDTO();

        string sourcePath = "";//@"\\SERVER-TFS\Data\Journal\";
        string rezJournalDTO = "";
        int checkCreateDirectory = 0;
        int checkAccessToDirectory = 0;

        string dbf_File = "";      
        string nameDirectory = "";
        string selectedFile = "";

        DateTime dateNow = new DateTime(2020,10,1);//.Now.Date;

        public AgreementJournalDocEditFm(Utils.Operation operation, AgreementJournalDTO agrementJournalModelDTO, AgreementDocumentsDTO documentModelDTO, UserTasksDTO userTaskDTO)
        {
            InitializeComponent();

            this.userTaskDTO = userTaskDTO;
            this.operation = operation;
            this.agrementJournalModelDTO = agrementJournalModelDTO;

            agreementJournalBS.DataSource = Item = documentModelDTO;
            LoadData();
            nameFileDocEdit.Enabled = false;
            if (operation == Utils.Operation.Update)
            {              
                addFileBut.Enabled = false;
                deleteFileBut.Enabled = false;
                pictureEdit.Enabled = false;
                renameFileTextEdit.Enabled = false;               
                pictureEdit.Properties.NullText = " ";
            }

            nameTypeDocumentLookUp.DataBindings.Add("EditValue", documentModelDTO, "AgreementTypeDocumentsId", true, DataSourceUpdateMode.OnPropertyChanged); // same AgreementDocumentsDTO

            List<AgreementTypeDocumentsDTO> numbersList = contractorsService.GetAgreementsTypeDocuments().ToList();
            nameTypeDocumentLookUp.Properties.DataSource = numbersList;
            nameTypeDocumentLookUp.Properties.ValueMember = "Id";
            nameTypeDocumentLookUp.Properties.DisplayMember = "TypeDocuments";
            nameTypeDocumentLookUp.Properties.NullText = "Немає данних";

            nameFileDocEdit.DataBindings.Add("EditValue", agreementJournalBS, "URL", true, DataSourceUpdateMode.OnPropertyChanged);

            rezJournalDTO = ReturnCurrentDTO(agrementJournalModelDTO);
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
            sourcePath = DefinitionPathToServer.DefinitionPath();
            if (sourcePath == "SBD1")
                sourcePath = @"\\SBD1\Data\Journal\";
            else sourcePath = @"\\SBD1\Data\DebugJournal\";
        }

        private string ReturnCurrentDTO(AgreementJournalDTO modelJournal)
        {
            string numberJournal = modelJournal.NumberWithTilda;
            return numberJournal;
        }

        public AgreementDocumentsDTO Return()
        {
            return ((AgreementDocumentsDTO)Item);
        }

        private void RenameFileInDirectory()
        {
            checkCreateDirectory = 0;
            selectedFile = System.IO.Path.GetFileName(renameFileTextEdit.Text);
            nameDirectory = System.IO.Path.GetFileNameWithoutExtension(renameFileTextEdit.Text+".pdf");
            DirectoryInfo dInfo = new DirectoryInfo(@"\\SBD1\Data");
            checkAccessToDirectory = 0;

            try
            {                
                if (renameFileTextEdit.EditValue != "")
                {
                    dInfo.GetDirectories();
                    if (Directory.Exists(sourcePath + "\\" + rezJournalDTO))
                    {
                        if (!File.Exists(sourcePath + rezJournalDTO + "\\" + System.IO.Path.GetFileNameWithoutExtension(renameFileTextEdit.Text + ".pdf") + "_" + dateNow.ToShortDateString() + ".pdf"))
                        {
                            splashScreenManager.ShowWaitForm();
                            File.Copy(nameFileDocEdit.Text, sourcePath + "\\" + rezJournalDTO + "\\" + dbf_File, true);//+ dateNow.ToShortDateString()+"~" 
                            checkCreateDirectory = 1;
                            //rename file
                            System.IO.File.Move(sourcePath + "\\" + rezJournalDTO + "\\" + dbf_File, sourcePath + "\\" + rezJournalDTO + "\\" + System.IO.Path.GetFileNameWithoutExtension(renameFileTextEdit.Text + ".pdf") + "_" + dateNow.ToShortDateString() + ".pdf");
                            splashScreenManager.CloseWaitForm();
                        }                      
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("У вас немає доступу до мережевої папки! Зверніться будь-ласка у відділ АСУП", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);//+ex.ToString());               
                checkAccessToDirectory = 1;
            }       
        }


        private bool SaveItem()
        {
            
            this.Item.EndEdit();
            contractorsService = Program.kernel.Get<IContractorsService>();


            RenameFileInDirectory();

            if (checkAccessToDirectory == 0)
            {
                if (operation == Utils.Operation.Add)
                {
                    //  CopyDirectoryWithFilesDocumentsToServer();
                    if (checkCreateDirectory == 1)
                    {
                        ((AgreementDocumentsDTO)Item).NameDocument = System.IO.Path.GetFileName(renameFileTextEdit.Text);
                        ((AgreementDocumentsDTO)Item).AgreementId = agrementJournalModelDTO.AgreementId;
                        ((AgreementDocumentsDTO)Item).Id = agrementJournalModelDTO.AgreementId;
                        ((AgreementDocumentsDTO)Item).URL = sourcePath + rezJournalDTO + "\\" + System.IO.Path.GetFileName(renameFileTextEdit.Text) +"_"+dateNow.ToShortDateString()+ ".pdf";// +"\\" + System.IO.Path.GetFileName(renameFileTextEdit.Text);
                        ((AgreementDocumentsDTO)Item).ResponsiblePersonId = userTaskDTO.UserId;
                        ((AgreementDocumentsDTO)Item).DateCreateFile = dateNow;

                        contractorsService.AgreementsDocumentsCreate((AgreementDocumentsDTO)Item);

                        //open file after add document
                        System.Diagnostics.Process.Start(((AgreementDocumentsDTO)Item).URL);
                    }
                    else
                        return false;
                }
                else
                {
                    ((AgreementDocumentsDTO)Item).DateCreateFile = dateNow;
                    contractorsService.AgreementsDocumentsUpdate((AgreementDocumentsDTO)Item);
                }
                return true;
            }
            else
                return false;            
        }

        #endregion

        #region Validation's

        private bool ControlValidation()
        {
            return agreementJournalDocValidationProvider.Validate();
        }
        private void agreementJournalDocValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBut.Enabled = false;
        }

        private void agreementJournalDocValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (agreementJournalDocValidationProvider.GetInvalidControls().Count == 0);
            this.saveBut.Enabled = isValidate;
        }
        #endregion

        #region Event's
        private void addFileBut_Click(object sender, EventArgs e)
        {
            checkCreateDirectory = 0;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            ofd.InitialDirectory = @"D:\";
            rezJournalDTO = rezJournalDTO.Trim();
           
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                nameFileDocEdit.EditValue = ofd.FileName;
                pictureEdit.Image = imageCollection.Images[1];
                dbf_File = System.IO.Path.GetFileName(ofd.FileName);
                renameFileTextEdit.EditValue = System.IO.Path.GetFileNameWithoutExtension(ofd.SafeFileName);
            }  
         }

        private void deleteFileBut_Click(object sender, EventArgs e)
        {
            pictureEdit.EditValue = null;
            nameFileDocEdit.EditValue = null;
        }
        private void nameTypeDocumentLookUp_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            contractorsService = Program.kernel.Get<IContractorsService>();
            switch (e.Button.Index)
            {
                case 1: //ДОБАВИТЬ
                    {
                        using (AgreementJournalDocAssemblyEditFm agreementJournalDocAssemblyEditFm = new AgreementJournalDocAssemblyEditFm(Utils.Operation.Add, new AgreementTypeDocumentsDTO()))
                        {
                            if (agreementJournalDocAssemblyEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = agreementJournalDocAssemblyEditFm.Return();
                                contractorsService = Program.kernel.Get<IContractorsService>();
                                nameTypeDocumentLookUp.Properties.DataSource = contractorsService.GetAgreementsTypeDocuments();
                                nameTypeDocumentLookUp.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 2://РЕДАКТИРОВАТЬ
                    {
                        if (nameTypeDocumentLookUp.EditValue == DBNull.Value)
                            return;

                        using (AgreementJournalDocAssemblyEditFm agreementJournalDocAssemblyEditFm = new AgreementJournalDocAssemblyEditFm(Utils.Operation.Update, (AgreementTypeDocumentsDTO)nameTypeDocumentLookUp.GetSelectedDataRow()))
                        {
                            if (agreementJournalDocAssemblyEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = agreementJournalDocAssemblyEditFm.Return();
                                contractorsService = Program.kernel.Get<IContractorsService>();
                                nameTypeDocumentLookUp.Properties.DataSource = contractorsService.GetAgreementsTypeDocuments();
                                nameTypeDocumentLookUp.EditValue = return_Id;
                            }
                        }
                        break;
                    }

                case 3://УДАЛИТЬ
                    {
                        if (agreementJournalBS.Count != 0)
                        {
                            if (nameTypeDocumentLookUp.EditValue == DBNull.Value)
                                return;
                            if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                contractorsService.AgreementsTypeDocumentsDelete(((AgreementTypeDocumentsDTO)nameTypeDocumentLookUp.GetSelectedDataRow()).Id);
                                contractorsService = Program.kernel.Get<IContractorsService>();
                                nameTypeDocumentLookUp.Properties.DataSource = contractorsService.GetAgreementsTypeDocuments();
                                nameTypeDocumentLookUp.EditValue = null;
                                nameTypeDocumentLookUp.Properties.NullText = "Немає данних";
                            }
                        }
                        break;
                    }
            }
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
                    else
                       MessageBox.Show("Файл з таким ім'ям вже існує!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                { MessageBox.Show("Помилка!" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        private void cancelBut_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void nameTypeDocumentLookUp_EditValueChanged(object sender, EventArgs e)
        {
            agreementJournalDocValidationProvider.Validate((Control)sender);
        }   
        private void renameFileTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            agreementJournalDocValidationProvider.Validate((Control)sender);
        }      

        private void nameFileDocEdit_EditValueChanged(object sender, EventArgs e)
        {
            agreementJournalDocValidationProvider.Validate((Control)sender);
        }
        #endregion

        private void pictureEdit_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void pictureEdit_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                string result = Path.GetFileName(file);
                nameFileDocEdit.EditValue = result;
                pictureEdit.Image = imageCollection.Images[1];
                dbf_File = System.IO.Path.GetFileName(result);
                renameFileTextEdit.EditValue = System.IO.Path.GetFileNameWithoutExtension(result);
            }
        }
    }
}