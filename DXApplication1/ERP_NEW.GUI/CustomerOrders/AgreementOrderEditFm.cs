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
using DevExpress.XtraEditors.Controls;

namespace ERP_NEW.GUI.CustomerOrders
{
    public partial class AgreementOrderEditFm : DevExpress.XtraEditors.XtraForm
    {
        private ICustomerOrdersService customerOrdersService;
        private IContractorsService contractorsService;
        private ICurrencyService currencyService;
        private IUserService userService;

        private AgreementOrderScanDTO agreementOrderScanDTO;

        private BindingSource agreementOrderBS = new BindingSource();
        private BindingSource organisationBS = new BindingSource();
        private BindingSource contractorBS = new BindingSource();
        private BindingSource agreementBS = new BindingSource();
        private BindingSource purposeBS = new BindingSource();
        private BindingSource currencyBS = new BindingSource();

        private Utils.Operation operation;

        private UserTasksDTO userTasksDTO;

        private ObjectBase Item
        {
            get { return agreementOrderBS.Current as ObjectBase; }
            set
            {
                agreementOrderBS.DataSource = value;

                value.BeginEdit();
            }
        }

        public AgreementOrderEditFm(Utils.Operation operation, AgreementOrderDTO model, UserTasksDTO userTaskDTO)
        {
            InitializeComponent();

            this.operation = operation;
            this.userTasksDTO = userTaskDTO;
            agreementOrderBS.DataSource = Item = model;

            LoadData();

            agreemtnOrderNumberEdit.DataBindings.Add("EditValue", agreementOrderBS, "AgreementOrderNumber" ,true, DataSourceUpdateMode.OnPropertyChanged);
            agreementOrderDateEdit.DataBindings.Add("EditValue", agreementOrderBS, "AgreementOrderDate", true, DataSourceUpdateMode.OnPropertyChanged);
            agreementOrderPriceEdit.DataBindings.Add("EditValue", agreementOrderBS, "Price", true, DataSourceUpdateMode.OnPropertyChanged);


            contractorEdit.DataBindings.Add("EditValue", agreementOrderBS, "ContractorId", true, DataSourceUpdateMode.OnPropertyChanged);
            contractorEdit.Properties.DataSource = contractorBS;
            contractorEdit.Properties.ValueMember = "Id";
            contractorEdit.Properties.DisplayMember = "Name";
            contractorEdit.Properties.NullText = "Немає данних";

            agreementEdit.DataBindings.Add("EditValue", agreementOrderBS, "AgreementId", true, DataSourceUpdateMode.OnPropertyChanged);
            agreementEdit.Properties.DataSource = agreementBS;
            agreementEdit.Properties.ValueMember = "Id";
            agreementEdit.Properties.DisplayMember = "Name";
            agreementEdit.Properties.NullText = "Немає данних";


            currencyEdit.DataBindings.Add("EditValue", agreementOrderBS, "CurrencyId", true, DataSourceUpdateMode.OnPropertyChanged);
            currencyEdit.Properties.DataSource = currencyBS;
            currencyEdit.Properties.ValueMember = "Id";
            currencyEdit.Properties.DisplayMember = "Name";
            currencyEdit.Properties.NullText = "Немає данних";

            purposeEdit.DataBindings.Add("EditValue", agreementOrderBS, "PurposeId", true, DataSourceUpdateMode.OnPropertyChanged);
            purposeEdit.Properties.DataSource = purposeBS;
            purposeEdit.Properties.ValueMember = "Id";
            purposeEdit.Properties.DisplayMember = "Purpose";
            purposeEdit.Properties.NullText = "Немає данних";


            switch (operation)
            {
                case Utils.Operation.Add:
                    ((AgreementOrderDTO)Item).AgreementOrderDate = DateTime.Now;
                    ((AgreementOrderDTO)Item).AgreementOrderNumber = contractorsService.GetAgreementOrderLastNumber(DateTime.Now);
                    agreementOrderScanDTO = new AgreementOrderScanDTO();
                    break;

                case Utils.Operation.Update:
                    agreementOrderScanDTO = new AgreementOrderScanDTO();
                    agreementOrderScanDTO = contractorsService.GetAgreementOrderScanById(((AgreementOrderDTO)Item).AgreementOrderScanId);

                    if (agreementOrderScanDTO != null)
                    {
                        int stratIndex = agreementOrderScanDTO.FileName.IndexOf('.');
                        string typeFile = agreementOrderScanDTO.FileName.Substring(stratIndex);

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

                        fileNameTbox.EditValue = agreementOrderScanDTO.FileName;
                    }
                    break;

                default:
                    MessageBox.Show("При завантаженні форми " + this.Text + " виникла помилка. ", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        #region Method's

        private void LoadData()
        {
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            currencyService = Program.kernel.Get<ICurrencyService>();
            contractorsService = Program.kernel.Get<IContractorsService>();
            userService = Program.kernel.Get<IUserService>();

            splashScreenManager.ShowWaitForm();

            currencyBS.DataSource = currencyService.GetCurrency();
            contractorBS.DataSource = contractorsService.GetContractors(2); // 1 - все данные, 2 - только контрагенты без договоров, 3 - только договора
            agreementBS.DataSource = contractorsService.GetContractors(3);
            purposeBS.DataSource = contractorsService.GetAgreementOrderPurpose();

            splashScreenManager.CloseWaitForm();
        }

        public AgreementOrderDTO Return()
        {
            return (AgreementOrderDTO)Item;
        }

        private bool SaveAgreementOrder()
        {
            try
            {
                contractorsService = Program.kernel.Get<IContractorsService>();

                switch (operation)
                {
                    case Utils.Operation.Add:
                        if (contractorsService.CheckAgreementOrderNumber((DateTime)((AgreementOrderDTO)Item).AgreementOrderDate, ((AgreementOrderDTO)Item).AgreementOrderNumber))
                        {
                            MessageBox.Show("рахунок з номером " + ((AgreementOrderDTO)Item).AgreementOrderNumber + " вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            agreemtnOrderNumberEdit.Text = contractorsService.GetAgreementOrderLastNumber((DateTime)((AgreementOrderDTO)Item).AgreementOrderDate).ToString();

                            //((AgreementOrderDTO)Item).AgreementOrderNumber = contractorsService.GetAgreementOrderLastNumber((DateTime)((AgreementOrderDTO)Item).AgreementOrderDate);
                            return false;
                        }

                        if (agreementOrderScanDTO.Scan != null)
                            ((AgreementOrderDTO)Item).AgreementOrderScanId = contractorsService.AgreementOrderScanCreate(agreementOrderScanDTO);

                        ((AgreementOrderDTO)Item).ResponsibleId = userTasksDTO.UserId;
                        ((AgreementOrderDTO)Item).Id = contractorsService.AgreementOrderCreate((AgreementOrderDTO)Item);

                        break;
                    case Utils.Operation.Update:
                        ((AgreementOrderDTO)Item).ResponsibleId = userTasksDTO.UserId;

                        if (agreementOrderScanDTO != null)
                        {
                            if (agreementOrderScanDTO.Scan == null && agreementOrderScanDTO.Id > 0)
                            {
                                contractorsService.AgreementOrderScanDelete(agreementOrderScanDTO.Id);
                                ((AgreementOrderDTO)Item).AgreementOrderScanId = null;
                            }
                            else if (agreementOrderScanDTO.Scan != null && agreementOrderScanDTO.Id == 0)
                            {
                                ((AgreementOrderDTO)Item).AgreementOrderScanId = contractorsService.AgreementOrderScanCreate(agreementOrderScanDTO);
                            }
                            else
                            {
                                contractorsService.AgreementsOrderScanUpdate(agreementOrderScanDTO);
                            }
                        }

                        contractorsService.AgreementsOrderUpdate((AgreementOrderDTO)Item);
                        break;

                    default:
                        break;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion

        #region Event's

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            if (agreementOrderScanDTO == null)
                agreementOrderScanDTO = new AgreementOrderScanDTO();

            string filePath = "";
            string fileName = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                fileName = ofd.SafeFileName;
            }
            if (filePath.Length > 0)
            {
                byte[] scan = System.IO.File.ReadAllBytes(@filePath);

                agreementOrderScanDTO.Scan = scan;
                agreementOrderScanDTO.FileName = fileName;
            }
            else
                return;

            try
            {
                Bitmap bitmap = new Bitmap(filePath);
                pictureEdit.Properties.SizeMode = PictureSizeMode.Zoom;
                pictureEdit.EditValue = bitmap;
                fileNameTbox.EditValue = fileName;
            }
            catch (Exception)
            {
                int stratIndex = filePath.IndexOf('.');
                string typeFile = filePath.Substring(stratIndex);

                switch (typeFile)
                {
                    case ".pdf":
                        fileNameTbox.EditValue = fileName;
                        pictureEdit.Image = imageCollection.Images[1];
                        pictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
                        break;
                    default:
                        fileNameTbox.EditValue = fileName;
                        pictureEdit.Image = imageCollection.Images[0];
                        pictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
                        break;
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            agreementOrderScanDTO.Scan = null;
            agreementOrderScanDTO.FileName = null;
            pictureEdit.EditValue = null;
            fileNameTbox.EditValue = null;
        }

        private void purposeEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            contractorsService = Program.kernel.Get<IContractorsService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (AgreementOrderPurposeEditFm purposeEditFm = new AgreementOrderPurposeEditFm(Utils.Operation.Add, new AgreementOrderPurposeDTO()))
                        {
                            if (purposeEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                int return_Id = purposeEditFm.Return();
                                contractorsService = Program.kernel.Get<IContractorsService>();
                                purposeEdit.Properties.DataSource = contractorsService.GetAgreementOrderPurpose();
                                purposeEdit.EditValue = return_Id;


                            }
                        }
                        break;
                    }
                case 2://Редагувати
                    {
                        if (purposeEdit.EditValue == DBNull.Value)
                            return;

                        using (AgreementOrderPurposeEditFm purposeEditFm = new AgreementOrderPurposeEditFm(Utils.Operation.Update, (AgreementOrderPurposeDTO)purposeEdit.GetSelectedDataRow()))
                        {
                            if (purposeEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                int return_Id = purposeEditFm.Return();
                                contractorsService = Program.kernel.Get<IContractorsService>();
                                purposeEdit.Properties.DataSource = contractorsService.GetAgreementOrderPurpose();
                                purposeEdit.EditValue = return_Id;


                            }
                        }
                        break;
                    }
                case 3://Видалити
                    {
                        if (purposeEdit.EditValue == DBNull.Value)
                            return;

                        if (purposeEdit.EditValue == null)
                            return;

                        if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            contractorsService.AgreementOrderPurposeDelete(((AgreementOrderPurposeDTO)purposeEdit.GetSelectedDataRow()).Id);
                            contractorsService = Program.kernel.Get<IContractorsService>();
                            purposeEdit.Properties.DataSource = contractorsService.GetAgreementOrderPurpose();
                            purposeEdit.EditValue = null;
                            purposeEdit.Properties.NullText = "Немає данних";
                        }

                        break;
                    }
                case 4://Очистити
                    {
                        purposeEdit.EditValue = null;
                        purposeEdit.Properties.NullText = "Немає данних";
                        break;
                    }
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            string fileName = (string)fileNameTbox.EditValue;
            byte[] scan = agreementOrderScanDTO.Scan;
            if (fileName != null)
            {
                string puth = Utils.HomePath + @"\Temp";

                System.IO.File.WriteAllBytes(puth + fileName, scan);

                System.Diagnostics.Process.Start(puth + fileName);
            }
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();

            if (MessageBox.Show("Зберегти зміни?", "Збереження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (SaveAgreementOrder())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
                this.Close();
        }

        private void agreemtnOrderNumberEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void agreementOrderDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            DateTime datValue =  (DateTime)agreementOrderDateEdit.EditValue;
            ((AgreementOrderDTO)Item).AgreementOrderNumber = contractorsService.GetAgreementOrderLastNumber(datValue);   //(DateTime.Now);
            dxValidationProvider.Validate((Control)sender);
        }

        private void contractorEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void agreementEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void agreementOrderPriceEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void currencyEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void purposeEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        #endregion

        #region Validation's

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBut.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.saveBut.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        #endregion

    }
}