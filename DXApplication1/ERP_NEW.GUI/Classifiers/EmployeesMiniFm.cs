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
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using Ninject;
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.Classifiers
{
    public partial class EmployeesMiniFm : DevExpress.XtraEditors.XtraForm
    {
        public IEmployeesService employeesService;
        public BindingSource employeesBS = new BindingSource();
        public BindingSource employeeHistoryBS = new BindingSource();
        public UserTasksDTO userTasksDTO;
        public EmployeesMiniFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            this.userTasksDTO = userTasksDTO;
            AuthorizatedUserAccess();
            LoadData();
        }

        private void AuthorizatedUserAccess()
        {
            addEmployeBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editEmployeBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteEmployeBtn.Enabled = (userTasksDTO.AccessRightId == 2);
        }

        private void LoadData()
        {
            splashScreenManager.ShowWaitForm();
            employeesService = Program.kernel.Get<IEmployeesService>();
            var employeesInfo = employeesService.GetEmployeesWorking();

            //GridLocalizer.Active = new MyGridLocalizer();

            List<EmployeesInfoDTO> firstList = employeesInfo.OrderByDescending(ord => ord.AccountNumber).ToList();

            foreach (var item in firstList)
            {
                if ((item.AccountNumber == 1) || item.AccountNumber == 7)
                    item.UserPhoto = Resizer(item.UserPhoto, 131, 150);
                else
                    item.UserPhoto = Resizer(item.UserPhoto, 121, 160);// 195, 260);
            }

            employeesBS.DataSource = firstList;
            employeesGrid.DataSource = employeesBS;
            splashScreenManager.CloseWaitForm();
            //employeesInfoGrid.Focus();
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

        private void addEmployeBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditEmployes(new EmployeesInfoDTO(), Utils.Operation.Add, userTasksDTO);
        }

        private void editEmployeBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditEmployes((EmployeesInfoDTO)employeesBS.Current, Utils.Operation.Update, userTasksDTO);
        }

        private void deleteEmployeBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EmployeesEditDetailsFm employeesEditDetailsFm = new EmployeesEditDetailsFm((EmployeesInfoDTO)employeesBS.Current))
            {
                if (employeesEditDetailsFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    EmployeesInfoDTO returnItem = employeesEditDetailsFm.Return();
                    employeesGridView.BeginDataUpdate();
                    LoadData();
                    employeesGridView.EndDataUpdate();
                    int rowHandle = employeesGridView.LocateByValue("EmployeeID", returnItem.EmployeeID);
                    employeesGridView.FocusedRowHandle = (rowHandle - 1);
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
                    employeesGridView.BeginDataUpdate();
                    LoadData();
                    employeesGridView.EndDataUpdate();
                    int rowHandle = employeesGridView.LocateByValue("EmployeeID", returnItem.EmployeeID);
                    employeesGridView.FocusedRowHandle = rowHandle;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
}