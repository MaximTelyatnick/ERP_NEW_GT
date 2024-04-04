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

namespace ERP_NEW.GUI.Classifiers
{
    public partial class TimeSheetFm : DevExpress.XtraEditors.XtraForm
    {
        private IEmployeesService employeesService;
        private IReportService reportService;
        private UserTasksDTO userTasksDTO;

        DateTime currentTime = new DateTime();

        private BindingSource departmentBS = new BindingSource();
        private BindingSource employeesInfoBS = new BindingSource();
        private List<EmployeesInfoDTO> returnTimeSheetList = new List<EmployeesInfoDTO>();

        public TimeSheetFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            this.userTasksDTO = userTasksDTO;

            yearEdit.EditValue = DateTime.Now;

            monthEdit.EditValue = DateTime.Now.Month;
            LoadData();      
        }

       


        #region Method's

        private void LoadData()
        {
            employeesService = Program.kernel.Get<IEmployeesService>();
            departmentBS.DataSource = employeesService.GetDepartments().Where(qwe => qwe.Name != "Техвагонмаш");
            timeSheetDepartmentsGrid.DataSource = departmentBS;
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

        private void LoadEmployeesByDeparnments(int departmentId)
        {
           //check all employees
            employeesService = Program.kernel.Get<IEmployeesService>();
            var firstList = employeesService.GetEmployeesWorkingByDeparmentId(((DepartmentsDTO)departmentBS.Current).DepartmentID);
           List<EmployeesInfoDTO> returnEmpList = firstList.ToList();

            for (int i = 0; i < returnEmpList.Count; i++)
            {
                returnEmpList.ToList().ForEach(c => c.Selected = true);
                i = returnEmpList.Count;
            }

            splashScreenManager.ShowWaitForm();
            foreach (var item in firstList)
            {
                if ((item.AccountNumber == 1) || (item.AccountNumber == 7))
                    item.UserPhoto = Resizer(item.UserPhoto, 190, 210);
                else
                    item.UserPhoto = Resizer(item.UserPhoto, 160, 220);
            }

            employeesInfoBS.DataSource = firstList;
            timeSheetProfessionsGrid.DataSource = employeesInfoBS;
            timeSheetDepartmentsGrid.DataSource = departmentBS;
            
            splashScreenManager.CloseWaitForm();       
        }

        #endregion

        #region Event's
        private void timeSheetDepartmentsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadEmployeesByDeparnments(((DepartmentsDTO)departmentBS.Current).DepartmentID);                     
        }

        private void excelExportAndPrintTimeSheetBtn_ItemClick(object sender, ItemClickEventArgs e)
        {


            using (InfoFormFm info = new InfoFormFm())
            {
                //info.Show();
                //rezForm = info.returnRez();


                if (info.ShowDialog() == System.Windows.Forms.DialogResult.Cancel && info.returnRez()==1)
                {
                    splashScreenManager.ShowWaitForm();
                    timeSheetProfessionsGridView.PostEditor();

                    returnTimeSheetList = ((List<EmployeesInfoDTO>)employeesInfoBS.DataSource).Where(s => s.Selected).OrderByDescending(o => o.AccountNumber).ToList();

                    if ((employeesInfoBS.Count > 0) && (yearEdit.EditValue != null))
                    {
                        reportService = Program.kernel.Get<IReportService>();

                        currentTime = new DateTime(((DateTime)yearEdit.EditValue).Year, (int)monthEdit.EditValue, 1);

                        reportService.PrintTimeSheet(returnTimeSheetList, currentTime);
                    }
                    else
                        MessageBox.Show("Оберіть рік! ", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    splashScreenManager.CloseWaitForm();
                }
            }
        }
    };
        #endregion

}