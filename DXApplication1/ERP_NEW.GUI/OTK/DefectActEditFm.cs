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

namespace ERP_NEW.GUI.OTK
{
    public partial class DefectActEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IDefectActsService defectActsService;
        private IMtsSpecificationsService mtsSpecificationsService;
        private ICustomerOrdersService customerOrdersService;
        
        private BindingSource defectActBS = new BindingSource();
        private BindingSource customerOrdersBS = new BindingSource();
        
        private Utils.Operation operation;
        

        private ObjectBase Item
        {
            get { return defectActBS.Current as ObjectBase; }
            set
            {
                defectActBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public DefectActEditFm(Utils.Operation operation, DefectActsDTO defectAct)
        {
            InitializeComponent();
            this.operation = operation;
            defectActsService = Program.kernel.Get<IDefectActsService>();
            mtsSpecificationsService = Program.kernel.Get<IMtsSpecificationsService>();
            customerOrdersService = Program.kernel.Get<CustomerOrdersService>();

            defectActBS.DataSource = Item = defectAct;

            orderNumberEdit.DataBindings.Add("EditValue", defectActBS, "CustomerOrderId", true, DataSourceUpdateMode.OnPropertyChanged);
            actNumberTbox.DataBindings.Add("EditValue", defectActBS, "ActNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            actDateEdit.DataBindings.Add("EditValue", defectActBS, "ActDate", true);
            descriptionMemoEdit.DataBindings.Add("EditValue", defectActBS, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            detailsMemoEdit.DataBindings.Add("EditValue", defectActBS, "Details", true, DataSourceUpdateMode.OnPropertyChanged);

            customerOrdersBS.DataSource = customerOrdersService.GetCustomerOrdersFull().OrderByDescending(sort => sort.OrderDate).ToList();
            orderNumberEdit.Properties.DataSource = customerOrdersBS;
            orderNumberEdit.Properties.ValueMember = "Id";
            orderNumberEdit.Properties.DisplayMember = "OrderNumber";
            orderNumberEdit.Properties.NullText = "Немає данних";

            
            assemblyEdit.DataBindings.Add("EditValue", defectActBS, "MtsAssemblyId", true, DataSourceUpdateMode.OnPropertyChanged);
            assemblyEdit.Properties.DataSource = mtsSpecificationsService.GetJournalAssembliesWithCustomerOrders();
            assemblyEdit.Properties.ValueMember = "AssemblyId";
            assemblyEdit.Properties.DisplayMember = "Drawing";
            assemblyEdit.Properties.NullText = "Немає данних";
           
            if (this.operation == Utils.Operation.Add)
            {
                ((DefectActsDTO)Item).ActDate = DateTime.Today;
            }
            else
            {
                assemblyEdit.EditValue = ((DefectActsDTO)Item).MtsAssemblyId;
                actDateEdit.EditValue = ((DefectActsDTO)Item).ActDate;
                pictureEdit.EditValue = ((DefectActsDTO)Item).ActScan;

                if (pictureEdit.Image == null && ((DefectActsDTO)Item).FileName != null)
                {
                    int stratIndex = ((DefectActsDTO)Item).FileName.IndexOf('.');
                    string typeFile = ((DefectActsDTO)Item).FileName.Substring(stratIndex);

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
                }

                fileNameTbox.EditValue = ((DefectActsDTO)Item).FileName;
            }

            ControlValidation();
        }

        #region Method's

        private void SaveAct()
        {
            this.Item.EndEdit();

            if (this.operation == Utils.Operation.Add)
                ((DefectActsDTO)Item).Id = defectActsService.CreateDefectAct((DefectActsDTO)Item);
            else
                defectActsService.UpdateDefectAct((DefectActsDTO)Item);
        }

        public int Return()
        {
            return ((DefectActsDTO)Item).Id;
        }

        #endregion

        #region Event's

        private void openFileBtn_Click(object sender, EventArgs e)
        {
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

                ((DefectActsDTO)Item).ActScan = scan;
                ((DefectActsDTO)Item).FileName = fileName;
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

        private void showBtn_Click(object sender, EventArgs e)
        {
            string fileName = (string)fileNameTbox.EditValue;
            byte[] scan = ((DefectActsDTO)Item).ActScan;
            if (fileName != null)
            {
                string puth = Utils.HomePath + @"\Temp";

                System.IO.File.WriteAllBytes(puth + fileName, scan);

                System.Diagnostics.Process.Start(puth + fileName);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ((DefectActsDTO)Item).ActScan = null;
            ((DefectActsDTO)Item).FileName = null;
            pictureEdit.EditValue = null;
            fileNameTbox.EditValue = null;
        }

        private void orderNumberEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Очистити
                    {
                        orderNumberEdit.EditValue = null;
                        break;
                    }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!ControlValidation()) return;

            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveAct();

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        #endregion

        #region Validate event's

        private bool ControlValidation()
        {
            return defectActValidationProvider.Validate();
        }
        
        private void actNumberTBox_TextChanged(object sender, EventArgs e)
        {
            defectActValidationProvider.Validate((Control)sender);
        }

        private void actDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            defectActValidationProvider.Validate((Control)sender);
        }

        private void orderNumberEdit_EditValueChanged(object sender, EventArgs e)
        {
            defectActValidationProvider.Validate((Control)sender);
        }

        private void defectActValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (defectActValidationProvider.GetInvalidControls().Count == 0);
            saveBtn.Enabled = isValidate;
            validateLbl.Visible = !isValidate;
        }

        private void defectActValidationProviderValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            saveBtn.Enabled = false;
            validateLbl.Visible = true;
        }
        
        #endregion 

    }
}