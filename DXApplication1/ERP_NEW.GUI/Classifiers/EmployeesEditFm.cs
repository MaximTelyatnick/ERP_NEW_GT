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
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using Ninject;
using System.IO;
using DevExpress.XtraEditors.Controls;


namespace ERP_NEW.GUI.Classifiers
{
    public partial class EmployeesEditFm : DevExpress.XtraEditors.XtraForm
    {

        private IEmployeesService employeesService;

        private BindingSource professionBS = new BindingSource();
        private BindingSource departmentBS = new BindingSource();
        private BindingSource customerOrdersBS = new BindingSource();
        private BindingSource customerOrdersHistoryBS = new BindingSource();
        private BindingSource employeesBS = new BindingSource();

        private Utils.Operation operation;
        private UserTasksDTO userTasksDTO;

        private EntityPhotosDTO userPhoto;

        private ObjectBase Item
        {
            get { return employeesBS.Current as ObjectBase; }
            set
            {
                employeesBS.DataSource = value;
                value.BeginEdit();
            }
        }


        public EmployeesEditFm(EmployeesInfoDTO model, Utils.Operation operation, UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            employeesService = Program.kernel.Get<IEmployeesService>();


            this.userTasksDTO = userTasksDTO;
            this.operation = operation;

            employeesBS.DataSource = Item = model;

            tabelNumberEdit.DataBindings.Add("EditValue", employeesBS, "AccountNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            lastNameEdit.DataBindings.Add("EditValue", employeesBS, "LastName", true, DataSourceUpdateMode.OnPropertyChanged);
            firstNameEdit.DataBindings.Add("EditValue", employeesBS, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged);
            secondNameEdit.DataBindings.Add("EditValue", employeesBS, "SecondName", true, DataSourceUpdateMode.OnPropertyChanged);
            dateStartJobEdit.DataBindings.Add("EditValue", employeesBS, "DateBegin", true, DataSourceUpdateMode.OnPropertyChanged);
            creditCardNumberEdit.DataBindings.Add("EditValue", employeesBS, "CreditCardNumber", true, DataSourceUpdateMode.OnPropertyChanged);

            professionBS.DataSource = employeesService.GetProfessions().ToList();
            professionEdit.DataBindings.Add("EditValue", employeesBS, "ProfessionID", true, DataSourceUpdateMode.OnPropertyChanged);
            professionEdit.Properties.DataSource = professionBS;
            professionEdit.Properties.ValueMember = "ProfessionID";
            professionEdit.Properties.DisplayMember = "Name";
            professionEdit.Properties.NullText = null;

            departmentBS.DataSource = employeesService.GetDepartments().ToList();
            departmentEdit.DataBindings.Add("EditValue", employeesBS, "DepartmentID", true, DataSourceUpdateMode.OnPropertyChanged);
            departmentEdit.Properties.DataSource = departmentBS;
            departmentEdit.Properties.ValueMember = "DepartmentID";
            departmentEdit.Properties.DisplayMember = "Name";
            departmentEdit.Properties.NullText = "";


            switch (operation)
            {
                case Utils.Operation.Add:
                    //((EmployeesInfoDTO)Item).AccountNumber = LastNumber();
                    userPhoto = new EntityPhotosDTO();
                    ((EmployeesInfoDTO)Item).AccountNumber = GetLastAccountNumber();
                    ((EmployeesInfoDTO)Item).DateBegin = DateTime.Now;

                    break;

                case Utils.Operation.Update:
                    userPhoto = new EntityPhotosDTO();
                    //packingMaterialModelPack = packingListsService.GetPackingListMaterialsById(((PackingListsDTO)Item).PackingListMaterialsId);
                    userPhoto.Photo = ((EmployeesInfoDTO)Item).UserPhoto;
                    pictureEdit.Image = byteArrayToImage(((EmployeesInfoDTO)Item).UserPhoto);

                    if (((EmployeesInfoDTO)Item).Gender == "M")
                        genderGroup.SelectedIndex = 0;
                    else
                        genderGroup.SelectedIndex = 1;

                    break;

                default:
                    MessageBox.Show("При завантаженні форми " + this.Text + " виникла помилка. ", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            dxValidationProvider.Validate();


        }

        public EmployeesInfoDTO Return()
        {
            return ((EmployeesInfoDTO)Item);
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {

            Image returnImage = null;
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms, true);
            }
            catch { }

            return returnImage;
        }
        


        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genderGroup.SelectedIndex == 0)
                ((EmployeesInfoDTO)Item).Gender = "M";
            else
                ((EmployeesInfoDTO)Item).Gender = "F";
        }

        private void openPhotoBtn_Click(object sender, EventArgs e)
        {
            if (((EmployeesInfoDTO)Item).UserPhoto != null)
                userPhoto = new EntityPhotosDTO();



            string filePath = "";
            string fileName = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                fileName = ofd.SafeFileName;
            }
            if (filePath.Length > 0)
            {
                byte[] scan = System.IO.File.ReadAllBytes(@filePath);

                userPhoto.Photo = scan;
                userPhoto.LocalCopyPath = fileName;
            }
            else
                return;

            try
            {
                Bitmap bitmap = new Bitmap(filePath);
                pictureEdit.Properties.SizeMode = PictureSizeMode.Zoom;
                pictureEdit.EditValue = bitmap;
                fileNameComplTbox.EditValue = fileName;
            }
            catch (Exception)
            {
                
            }
        }

        private void clearPhotoBtn_Click(object sender, EventArgs e)
        {
            userPhoto.Photo = null;
            userPhoto.LocalCopyPath = null;
            pictureEdit.EditValue = null;
            fileNameComplTbox.EditValue = null;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private int GetLastAccountNumber()
        {
            var lastEmployee = employeesService.GetEmployees().OrderByDescending(x => x.AccountNumber).FirstOrDefault();

            if (lastEmployee != null)
                return Convert.ToInt32(lastEmployee.AccountNumber + 1);
            else
                return 1;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();

            if (MessageBox.Show("Зберегти зміни?", "Збереження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (employeesBS.Count == 0)
                {
                    MessageBox.Show("Необхідно додати номер проекту до пакувального листа", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (SaveEmployee())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private bool SaveEmployee()
        {
            try
            {
                employeesService = Program.kernel.Get<IEmployeesService>();

                //if (FindDublicate((PackingListsDTO)this.Item))
                //{
                //    MessageBox.Show("Пакувальний лист з таким номером вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return false;
                //}

                switch (operation)
                {
                    case Utils.Operation.Add:

                        //if (userPhoto.Photo != null)
                        //    ((PackingListsDTO)Item).PackingListMaterialsId = packingListsService.PackingListMaterialsCreate(packingMaterialModelPack);
                        EmployeesDTO employeesDTO = new EmployeesDTO();
                        employeesDTO.EmployeeID = employeesService.GetLastEmployeesId()+1;
                        employeesDTO.AccountNumber = (int)((EmployeesInfoDTO)Item).AccountNumber;
                        employeesDTO.Engaged = ((EmployeesInfoDTO)Item).DateBegin;
                        employeesDTO.Fired = new DateTime(3000,01,01);

                        int EmployeeID =  employeesService.EmployeesCreate(employeesDTO);

                        EmployeesDetailsDTO employeesDetailsDTO = new EmployeesDetailsDTO();
                        employeesDetailsDTO.RecordID = employeesService.GetLastEmployeesDetailsRecordId()+ 1;
                        employeesDetailsDTO.LastName = ((EmployeesInfoDTO)Item).LastName;
                        employeesDetailsDTO.FirstName = ((EmployeesInfoDTO)Item).FirstName;
                        employeesDetailsDTO.MiddleName = ((EmployeesInfoDTO)Item).SecondName;
                        employeesDetailsDTO.EmployeeID = employeesDTO.EmployeeID;
                        employeesDetailsDTO.StartDate = ((EmployeesInfoDTO)Item).DateBegin;
                        employeesDetailsDTO.EndDate = new DateTime(3000, 01, 01);
                        employeesDetailsDTO.DepartmentID = (int)((EmployeesInfoDTO)Item).DepartmentID;
                        employeesDetailsDTO.ProfessionID = (int)((EmployeesInfoDTO)Item).ProfessionID;

                        int RecordID = employeesService.EmployeesDetailsCreate(employeesDetailsDTO);

                        EmployeesDetailsStandartDTO employeesDetailsStandartDTO = new EmployeesDetailsStandartDTO();

                        employeesDetailsStandartDTO.RecordID = RecordID;
                        employeesDetailsStandartDTO.Gender = ((EmployeesInfoDTO)Item).Gender;
                        employeesDetailsStandartDTO.Description = ((EmployeesInfoDTO)Item).CreditCardNumber;
                        int EmpStandRecordID = employeesService.EmployeesDetailsStandartCreate(employeesDetailsStandartDTO);

                        AccessScheduleEntityDTO accessScheduleEntityDTO = new AccessScheduleEntityDTO();

                        accessScheduleEntityDTO.EntityID = employeesService.GetAccessScheduleEntityEntityId() +1;

                        accessScheduleEntityDTO.OwnerID = RecordID;
                        accessScheduleEntityDTO.OwnerType = 1;
                        accessScheduleEntityDTO.StartDate = ((EmployeesInfoDTO)Item).DateBegin;
                        accessScheduleEntityDTO.Override = 0;
                        accessScheduleEntityDTO.ParentID = null;

                        int accesSheduleEntityID = employeesService.AccessScheduleEntityCreate(accessScheduleEntityDTO);

                        if (userPhoto.Photo != null)
                        {
                            EntityPhotosDTO entityPhotosDTO = new EntityPhotosDTO();

                            entityPhotosDTO.EntityID = accesSheduleEntityID;
                            entityPhotosDTO.LocalCopyPath = userPhoto.LocalCopyPath;
                            entityPhotosDTO.Photo = userPhoto.Photo;

                            int EntityPhotosEntityID = employeesService.EntityPhotosCreate(entityPhotosDTO);
                        }

                        break;
                    case Utils.Operation.Update:

                        EmployeesDTO employeesUpdateDTO = new EmployeesDTO();
                        employeesUpdateDTO.EmployeeID = (int)((EmployeesInfoDTO)Item).EmployeeID;
                        employeesUpdateDTO.AccountNumber = (int)((EmployeesInfoDTO)Item).AccountNumber;
                        employeesUpdateDTO.Engaged = ((EmployeesInfoDTO)Item).DateBegin;
                        employeesUpdateDTO.Fired = new DateTime(3000, 01, 01);

                        employeesService.EmployeesUpdate(employeesUpdateDTO);

                        EmployeesDetailsDTO employeesDetailsUpdateDTO = new EmployeesDetailsDTO();
                        employeesDetailsUpdateDTO.RecordID = ((EmployeesInfoDTO)Item).RecordID;
                        employeesDetailsUpdateDTO.LastName = ((EmployeesInfoDTO)Item).LastName;
                        employeesDetailsUpdateDTO.FirstName = ((EmployeesInfoDTO)Item).FirstName;
                        employeesDetailsUpdateDTO.MiddleName = ((EmployeesInfoDTO)Item).SecondName;
                        employeesDetailsUpdateDTO.EmployeeID = ((EmployeesInfoDTO)Item).EmployeeID;
                        employeesDetailsUpdateDTO.StartDate = ((EmployeesInfoDTO)Item).DateBegin;
                        employeesDetailsUpdateDTO.EndDate = new DateTime(3000, 01, 01);
                        employeesDetailsUpdateDTO.DepartmentID = (int)((EmployeesInfoDTO)Item).DepartmentID;
                        employeesDetailsUpdateDTO.ProfessionID = (int)((EmployeesInfoDTO)Item).ProfessionID;

                        employeesService.EmployeesDetailsUpdate(employeesDetailsUpdateDTO);

                        EmployeesDetailsStandartDTO employeesDetailsStandartUpdateDTO = new EmployeesDetailsStandartDTO();
                        employeesDetailsStandartUpdateDTO.RecordID = ((EmployeesInfoDTO)Item).RecordID;
                        employeesDetailsStandartUpdateDTO.Gender = ((EmployeesInfoDTO)Item).Gender;
                        employeesDetailsStandartUpdateDTO.Description = ((EmployeesInfoDTO)Item).CreditCardNumber;

                        employeesService.EmployeesDetailsStandartUpdate(employeesDetailsStandartUpdateDTO);

                        //int EmpStandRecordID = employeesService.EmployeesDetailsStandartCreate(employeesDetailsStandartDTO);

                        AccessScheduleEntityDTO accessScheduleEntityUpdateDTO = new AccessScheduleEntityDTO();
                        accessScheduleEntityUpdateDTO.EntityID = ((EmployeesInfoDTO)Item).EntityID;
                        accessScheduleEntityUpdateDTO.OwnerID = ((EmployeesInfoDTO)Item).RecordID;;
                        accessScheduleEntityUpdateDTO.OwnerType = 1;
                        accessScheduleEntityUpdateDTO.StartDate = ((EmployeesInfoDTO)Item).DateBegin;
                        accessScheduleEntityUpdateDTO.Override = 0;
                        accessScheduleEntityUpdateDTO.ParentID = null;
                        employeesService.AccessScheduleEntityUpdate(accessScheduleEntityUpdateDTO);

                        if (userPhoto.Photo != null)
                        {
                            EntityPhotosDTO entityPhotosDTO = new EntityPhotosDTO();

                            entityPhotosDTO.EntityID = ((EmployeesInfoDTO)Item).EntityID;
                            entityPhotosDTO.LocalCopyPath = userPhoto.LocalCopyPath;
                            entityPhotosDTO.Photo = userPhoto.Photo;

                            if (employeesService.CheckEntityPhotos(((EmployeesInfoDTO)Item).EntityID))
                                employeesService.EntityPhotosUpdate(entityPhotosDTO);
                            else
                                employeesService.EntityPhotosCreate(entityPhotosDTO);
                        }

                        break;

                    default:
                        break;
                }

                //if (deletePackingListDetailsList.Count > 0)
                //{
                //    foreach (var item in deletePackingListDetailsList)
                //    {
                //        if (item.Id > 0)
                //            packingListsService.PackingListDetailsDeleteById(item.Id);
                //    }
                //}

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
        }

        private void tabelNumberEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void lastNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void firstNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void secondNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void dateStartJobEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void professionEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void departmentEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void professionEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            employeesService = Program.kernel.Get<IEmployeesService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (ProfessionEditFm professionEditFm = new ProfessionEditFm(Utils.Operation.Add, new ProfessionsDTO()))
                        {
                            if (professionEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = professionEditFm.Return();
                                employeesService = Program.kernel.Get<IEmployeesService>();
                                professionEdit.Properties.DataSource = employeesService.GetProfessions();
                                professionEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 2: //Редагувати
                    {
                        if (professionEdit.EditValue == DBNull.Value)
                            return;

                        using (ProfessionEditFm professionEditFm = new ProfessionEditFm(Utils.Operation.Update, (ProfessionsDTO)professionEdit.GetSelectedDataRow()))
                        {
                            if (professionEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = professionEditFm.Return();
                                employeesService = Program.kernel.Get<IEmployeesService>();
                                professionEdit.Properties.DataSource = employeesService.GetProfessions();
                                professionEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 3: //Видалити
                    {
                        if (professionEdit.EditValue == DBNull.Value)
                            return;

                        if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            employeesService.ProfessionDelete(((ProfessionsDTO)professionEdit.GetSelectedDataRow()).ProfessionID);
                            professionEdit.Properties.DataSource = employeesService.GetProfessions();
                            professionEdit.EditValue = DBNull.Value;
                            professionEdit.Properties.NullText = "Немає данних";
                        }

                        break;
                    }
            }
        }

        private void departmentEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            employeesService = Program.kernel.Get<IEmployeesService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (DepartmentEditFm departmentEditFm = new DepartmentEditFm(Utils.Operation.Add, new DepartmentsDTO()))
                        {
                            if (departmentEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = departmentEditFm.Return();
                                employeesService = Program.kernel.Get<IEmployeesService>();
                                departmentEdit.Properties.DataSource = employeesService.GetDepartments();
                                departmentEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 2: //Редагувати
                    {
                        if (departmentEdit.EditValue == DBNull.Value)
                            return;

                        using (DepartmentEditFm departmentEditFm = new DepartmentEditFm(Utils.Operation.Update, (DepartmentsDTO)departmentEdit.GetSelectedDataRow()))
                        {
                            if (departmentEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = departmentEditFm.Return();
                                employeesService = Program.kernel.Get<IEmployeesService>();
                                departmentEdit.Properties.DataSource = employeesService.GetDepartments();
                                departmentEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 3: //Видалити
                    {
                        if (departmentEdit.EditValue == DBNull.Value)
                            return;

                        if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            employeesService.DepartmentsDelete(((DepartmentsDTO)departmentEdit.GetSelectedDataRow()).DepartmentID);
                            departmentEdit.Properties.DataSource = employeesService.GetDepartments();
                            departmentEdit.EditValue = DBNull.Value;
                            departmentEdit.Properties.NullText = "Немає данних";
                        }

                        break;
                    }
            }
        }
    }
}