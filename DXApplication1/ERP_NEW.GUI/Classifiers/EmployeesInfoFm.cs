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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System.IO;
using System;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Controls;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.Classifiers
{
    public partial class EmployeesInfoFm : DevExpress.XtraEditors.XtraForm
    {
        public IEmployeesService employeesService;
        public BindingSource employeesBS = new BindingSource();
        public BindingSource employeeHistoryBS = new BindingSource();
        public UserTasksDTO userTasksDTO;

        public EmployeesInfoFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            this.userTasksDTO = userTasksDTO;
            AuthorizatedUserAccess();
            LoadData();
        }

        private void AuthorizatedUserAccess()
        {
            editEmployeeItem.Enabled = (userTasksDTO.AccessRightId == 2);
            addEmployeeItem.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteEmployeeItem.Enabled = (userTasksDTO.AccessRightId == 2);
        }

        private void LoadData()
        {
            splashScreenManager.ShowWaitForm();
            employeesService = Program.kernel.Get<IEmployeesService>();
            var employeesInfo = employeesService.GetEmployeesWorking();

            GridLocalizer.Active = new MyGridLocalizer();

            List<EmployeesInfoDTO> firstList = employeesInfo.OrderByDescending(ord => ord.AccountNumber).ToList();

            foreach (var item in firstList)
            {
                //if ((item.AccountNumber == 1) || item.AccountNumber ==7)
                //{
                //    item.UserPhoto = Resizer(item.UserPhoto, 190, 210);
                //}
                //else
                //    item.UserPhoto = Resizer(item.UserPhoto,180,240);// 195, 260);

                if ((item.AccountNumber == 1) || item.AccountNumber == 7)
                    item.UserPhoto = Resizer(item.UserPhoto, 131, 150);
                else
                    item.UserPhoto = Resizer(item.UserPhoto, 121, 160);// 195, 260);
            }

            employeesBS.DataSource = firstList;

            employeesInfoGrid.DataSource = employeesBS;

            splashScreenManager.CloseWaitForm();
            employeesInfoGrid.Focus();

            employeesInfoGridView.FindFilterText = " ";
        }


        public byte[] Resizer(byte[] imageByte, int rows, int columns)
        {
            Image image;
            Image incognitoUser = Image.FromFile("Images/happy-face.png");
            byte[] xByte = null;
            ImageConverter imageConverter = new ImageConverter();

            if (imageByte.Length > 0)
            {
                image = (Bitmap)((new ImageConverter()).ConvertFrom(imageByte));


                Bitmap source = new Bitmap(image);
                Bitmap result = new Bitmap(source, rows, columns);
                xByte = (byte[])imageConverter.ConvertTo((Image)result, typeof(byte[]));

            }
            else
            {

                Bitmap source = new Bitmap(incognitoUser);
                Bitmap result = new Bitmap(source, rows, columns);
                xByte = (byte[])imageConverter.ConvertTo((Image)result, typeof(byte[]));
            }
            return xByte;

        }

        private void employeesInfoGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var accountNumber = ((EmployeesInfoDTO)employeesBS.Current).AccountNumber;
           
            var employeeHistory = employeesService.GetEmployeeHistory(accountNumber);

            List<EmployeesInfoCustomDTO> employeesInfoCustom = new List<EmployeesInfoCustomDTO>();


            foreach (var item in employeeHistory)
            {
                if (item.DateEnd > DateTime.Now)
                {
                    employeesInfoCustom.Add(new EmployeesInfoCustomDTO()
                    {
                        AccountNumber = item.AccountNumber,
                        DateBegin = item.DateBegin.ToShortDateString(),
                        DateEnd = "по сьогодення",
                        DepartmentID = item.DepartmentID,
                        DepartmentName = item.DepartmentName,
                        EmployeeID = item.EmployeeID,
                        Fio = item.Fio,
                        FullName = item.FullName,
                        ProfessionID = item.ProfessionID,
                        ProfessionName = item.ProfessionName
                    });
                }
                else
                {
                    employeesInfoCustom.Add(new EmployeesInfoCustomDTO()
                    {
                        AccountNumber = item.AccountNumber,
                        DateBegin = item.DateBegin.ToShortDateString(),
                        DateEnd = item.DateEnd.ToShortDateString(),
                        DepartmentID = item.DepartmentID,
                        DepartmentName = item.DepartmentName,
                        EmployeeID = item.EmployeeID,
                        Fio = item.Fio,
                        FullName = item.FullName,
                        ProfessionID = item.ProfessionID,
                        ProfessionName = item.ProfessionName
                    });
                }

            }

            if (employeesInfoCustom.Count() > 0)
            {
                employeeHistoryBS.DataSource = employeesInfoCustom;
                employeeHistoryGrid.DataSource = employeeHistoryBS;
                photoPictureEdit.EditValue = ((EmployeesInfoDTO)employeesBS.Current).UserPhoto;
                fioLabel.Text = ((EmployeesInfoDTO)employeesBS.Current).Fio;
                
                //  accountNumberLabel.Text = ((EmployeesInfoDTO)employeesBS.Current).AccountNumber.ToString();
            }
            else
            {
                employeeHistoryBS.DataSource = null;
                employeeHistoryGrid.DataSource = employeeHistoryBS;
                photoPictureEdit.EditValue = null;
                fioLabel.Text = null;
       //         accountNumberLabel.Text = null;
            }

        }

        private void addEmployeeItem_Click(object sender, EventArgs e)
        {
            EditEmployes( new EmployeesInfoDTO(), Utils.Operation.Add, userTasksDTO);
        }

        private void editEmployeeItem_Click(object sender, EventArgs e)
        {
            EditEmployes((EmployeesInfoDTO)employeesBS.Current, Utils.Operation.Update, userTasksDTO);
        }

        private void deleteEmployeeItem_Click(object sender, EventArgs e)
        {
            using (EmployeesEditDetailsFm employeesEditDetailsFm = new EmployeesEditDetailsFm((EmployeesInfoDTO)employeesBS.Current))
            {
                if (employeesEditDetailsFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    EmployeesInfoDTO returnItem = employeesEditDetailsFm.Return();
                    employeesInfoGridView.BeginDataUpdate();
                    LoadData();
                    employeesInfoGridView.EndDataUpdate();
                    int rowHandle = employeesInfoGridView.LocateByValue("EmployeeID", returnItem.EmployeeID);
                    employeesInfoGridView.FocusedRowHandle = (rowHandle-1);
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void EditEmployes(EmployeesInfoDTO model, Utils.Operation operation, UserTasksDTO userTaskDTO)
        {
            using (EmployeesEditFm employeesEditFm = new EmployeesEditFm(model, operation, userTaskDTO))
            {
                if (employeesEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    EmployeesInfoDTO returnItem = employeesEditFm.Return();
                    employeesInfoGridView.BeginDataUpdate();
                    LoadData();
                    employeesInfoGridView.EndDataUpdate();
                    int rowHandle = employeesInfoGridView.LocateByValue("EmployeeID", returnItem.EmployeeID);
                    employeesInfoGridView.FocusedRowHandle = rowHandle;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

      }

    #region Custom search and clear button

    public class MyGridLocalizer : GridLocalizer
    {
        public override string GetLocalizedString(GridStringId id)
        {
            if (id == GridStringId.FindControlFindButton)
                return "Додати критерій пошуку";
            if (id == GridStringId.FindControlClearButton)
                return "Відмінити";
            if (id == GridStringId.CustomFilterDialogHint)
                return "Відмінити";
            //if (id == GridStringId)
            //    return "Відмінити";
            //if (id == GridStringId.Hin)
            //    return "Відмінити";
            return base.GetLocalizedString(id);
        }
    }

    #endregion

    
}