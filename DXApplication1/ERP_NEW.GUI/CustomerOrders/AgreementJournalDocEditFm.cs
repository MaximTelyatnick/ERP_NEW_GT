﻿using System;
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
        private BindingSource agreementBS = new BindingSource();
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

            documentModelDTO.RealAgreementId = agrementJournalModelDTO.AgreementIdFromContractors;
            agreementJournalBS.DataSource = Item = documentModelDTO;
            LoadData();
            nameFileDocEdit.Enabled = false;
            if (operation == Utils.Operation.Update)
            {
                if (documentModelDTO != null)
                {
                    int stratIndex = documentModelDTO.URL.IndexOf('.');
                    string typeFile = documentModelDTO.URL.Substring(stratIndex);

                    switch (typeFile)
                    {
                        case ".pdf":
                            pictureEdit.Image = imageCollection.Images[1];
                            pictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
                            break;
                        default:
                            pictureEdit.Image = imageCollection.Images[0];
                            pictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
                            break;
                    }

                    nameFileDocEdit.EditValue = documentModelDTO.URL;
                }
            }

            nameTypeDocumentLookUp.DataBindings.Add("EditValue", agreementJournalBS, "AgreementTypeDocumentsId", true, DataSourceUpdateMode.OnPropertyChanged); // same AgreementDocumentsDTO

            List<AgreementTypeDocumentsDTO> numbersList = contractorsService.GetAgreementsTypeDocuments().ToList();
            nameTypeDocumentLookUp.Properties.DataSource = numbersList;
            nameTypeDocumentLookUp.Properties.ValueMember = "Id";
            nameTypeDocumentLookUp.Properties.DisplayMember = "TypeDocuments";
            nameTypeDocumentLookUp.Properties.NullText = "Немає данних";

            List<ContractorsDTO> numberList1 = contractorsService.GetContractors(3).ToList();
            agreementEdit.DataBindings.Add("EditValue", agreementJournalBS, "RealAgreementId", true, DataSourceUpdateMode.OnPropertyChanged);

            agreementEdit.Properties.DataSource = numberList1;
            agreementEdit.Properties.ValueMember = "Id";
            agreementEdit.Properties.DisplayMember = "Name";
            agreementEdit.Properties.NullText = "Немає данних";



            nameFileDocEdit.DataBindings.Add("EditValue", agreementJournalBS, "URL", true, DataSourceUpdateMode.OnPropertyChanged);
            renameFileTextEdit.DataBindings.Add("EditValue", agreementJournalBS, "NameDocument", true, DataSourceUpdateMode.OnPropertyChanged);

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

            //agreementBS.DataSource = contractorsService.GetContractors(3).ToList();

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
                if (renameFileTextEdit.Text != "")
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
            catch (Exception)
            {
                MessageBox.Show("У вас немає доступу до мережевої папки! Зверніться будь-ласка у відділ АСУП", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);//+ex.ToString());               
                checkAccessToDirectory = 1;
            }       
        }


        private bool SaveItemDb()
        {
            this.Item.EndEdit();
            contractorsService = Program.kernel.Get<IContractorsService>();

            if (operation == Utils.Operation.Add)
            {

                   // ((AgreementDocumentsDTO)Item).NameDocument = System.IO.Path.GetFileName(renameFileTextEdit.Text);
                    ((AgreementDocumentsDTO)Item).AgreementId = agrementJournalModelDTO.AgreementId;
                    ((AgreementDocumentsDTO)Item).Id = agrementJournalModelDTO.AgreementId;
                    //((AgreementDocumentsDTO)Item).URL = System.IO.Path.GetFileName(renameFileTextEdit.Text);
                    //((AgreementDocumentsDTO)Item).URL = sourcePath + rezJournalDTO + "\\" + System.IO.Path.GetFileName(renameFileTextEdit.Text) + "_" + dateNow.ToShortDateString() + ".pdf";// +"\\" + System.IO.Path.GetFileName(renameFileTextEdit.Text);
                    ((AgreementDocumentsDTO)Item).ResponsiblePersonId = userTaskDTO.UserId;
                    ((AgreementDocumentsDTO)Item).DateCreateFile = DateTime.Now;
                    ((AgreementDocumentsDTO)Item).DateChange = DateTime.Now;

                contractorsService.AgreementsDocumentsCreate((AgreementDocumentsDTO)Item);

                    //open file after add document
                    //System.Diagnostics.Process.Start(((AgreementDocumentsDTO)Item).URL);

            }
            else
            {
                ((AgreementDocumentsDTO)Item).DateChange = DateTime.Now;
                contractorsService.AgreementsDocumentsUpdate((AgreementDocumentsDTO)Item);
            }
            return true;
        }


        private bool SaveItem()
        {
            
            this.Item.EndEdit();
            contractorsService = Program.kernel.Get<IContractorsService>();


            //RenameFileInDirectory();

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
                //pictureEdit.Image = imageCollection.Images[1];
                dbf_File = System.IO.Path.GetFileName(ofd.FileName);
                renameFileTextEdit.EditValue = System.IO.Path.GetFileName(ofd.SafeFileName);

                if (ofd.FileName.Length > 0)
                {
                    byte[] scan = System.IO.File.ReadAllBytes(@ofd.FileName);
                    FileInfo info = new FileInfo(@ofd.FileName);

                    if (Utils.ToSize(info.Length, Utils.SizeUnits.GB) > Properties.Settings.Default.MaxFileSizeMb)
                    {
                        MessageBox.Show("Перевищено максимальний розмір файлу (" + Properties.Settings.Default.MaxFileSizeMb.ToString() + " мегабайт) !!!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int stratIndex = System.IO.Path.GetFileName(ofd.FileName).IndexOf('.');
                    string typeFile = System.IO.Path.GetFileName(ofd.FileName).Substring(stratIndex);

                    switch (typeFile)
                    {
                        case ".pdf":
                            pictureEdit.Image = imageCollection.Images[1];
                            pictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
                            break;
                        default:
                            pictureEdit.Image = imageCollection.Images[0];
                            pictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
                            break;
                    }

                    ((AgreementDocumentsDTO)Item).Scan = scan;
                    ((AgreementDocumentsDTO)Item).NameDocument = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
                    ((AgreementDocumentsDTO)Item).URL = System.IO.Path.GetFileName(ofd.FileName);
                }
            }  
        }

        private void pictureEdit_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void pictureEdit_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                string result = Path.GetFullPath(file);
                nameFileDocEdit.EditValue = Path.GetFileName(file);
                pictureEdit.Image = imageCollection.Images[1];


                dbf_File = System.IO.Path.GetFileName(result);
                renameFileTextEdit.EditValue = System.IO.Path.GetFileName(result);

                if (result.Length > 0)
                {
                    byte[] scan = System.IO.File.ReadAllBytes(@result);
                    FileInfo info = new FileInfo(@result);

                    if (Utils.ToSize(info.Length, Utils.SizeUnits.GB) > Properties.Settings.Default.MaxFileSizeMb)
                    {
                        MessageBox.Show("Перевищено максимальний розмір файлу (" + Properties.Settings.Default.MaxFileSizeMb.ToString() + " мегабайт) !!!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int stratIndex = System.IO.Path.GetFileName(result).IndexOf('.');
                    string typeFile = System.IO.Path.GetFileName(result).Substring(stratIndex);

                    switch (typeFile)
                    {
                        case ".pdf":
                            pictureEdit.Image = imageCollection.Images[1];
                            pictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
                            break;
                        default:
                            pictureEdit.Image = imageCollection.Images[0];
                            pictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
                            break;
                    }

                    ((AgreementDocumentsDTO)Item).Scan = scan;
                    ((AgreementDocumentsDTO)Item).NameDocument = System.IO.Path.GetFileNameWithoutExtension(result);
                    ((AgreementDocumentsDTO)Item).URL = System.IO.Path.GetFileName(result);
                }
            }
        }

        private void deleteFileBut_Click(object sender, EventArgs e)
        {
            pictureEdit.EditValue = null;
            renameFileTextEdit.EditValue = null;
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
                    if (SaveItemDb())
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

        private void pictureEdit_EditValueChanged(object sender, EventArgs e)
        {
           // byte[] scan = ((AgreementDocumentsDTO)documentsBS.Current).Scan;
            //string path = Utils.HomePath + @"\Temp\";
            //System.IO.File.WriteAllBytes(path + ((AgreementDocumentsDTO)documentsBS.Current).NameDocument, scan);
            //System.Diagnostics.Process.Start(path + ((AgreementDocumentsDTO)documentsBS.Current).NameDocument);

            //if (((AgreementDocumentsDTO)Item).Scan != null)
            //{
            //    byte[] scan = ((AgreementDocumentsDTO)Item).Scan;
            //    string path = Utils.HomePath + @"\Temp\";
            //    System.IO.File.WriteAllBytes(path + ((AgreementDocumentsDTO)Item).URL, scan);
            //    System.Diagnostics.Process.Start(path + ((AgreementDocumentsDTO)Item).URL);
            //}
        }

        private void pictureEdit_DoubleClick(object sender, EventArgs e)
        {
            if (((AgreementDocumentsDTO)Item).Scan != null)
            {
                byte[] scan = ((AgreementDocumentsDTO)Item).Scan;
                string path = Utils.HomePath + @"\Temp\";
                System.IO.File.WriteAllBytes(path + ((AgreementDocumentsDTO)Item).URL, scan);
                System.Diagnostics.Process.Start(path + ((AgreementDocumentsDTO)Item).URL);
            }
        }
    }
}