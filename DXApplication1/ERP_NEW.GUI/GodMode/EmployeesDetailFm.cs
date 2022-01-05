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
using DevExpress.XtraGrid.Localization;
using Ninject;
using ERP_NEW.BLL.DTO.SelectedDTO;

namespace ERP_NEW.GUI.GodMode
{
    public partial class EmployeesDetailFm : DevExpress.XtraEditors.XtraForm
    {

        public IEmployeesService employeesService;
        public BindingSource employeesBS = new BindingSource();
        public BindingSource employeeHistoryBS = new BindingSource();
        public bool online;
        public int flag=0;
        List<EmployeesInfoDTO> employeesList;

        public EmployeesDetailFm()
        {
            InitializeComponent();
            LoadData(true);
        }

        private void notWorkingEmployeesBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flag = 1;
            LoadData(false);
        }

        private void LoadData(bool working)
        {
            splashScreenManager.ShowWaitForm();

            //flyoutPanel1.Showing += flyoutPanel1_Showing;
            //flyoutPanel1.Hidden += flyoutPanel1_Hidden;

            employeesService = Program.kernel.Get<IEmployeesService>();
            if (working)
            {
                if (online)  //to write 04.01
                    employeesList = employeesService.GetEmployeesWorkingOnline().ToList();
                else
                    employeesList = employeesService.GetEmployeesWorking().ToList();
            }
            else
                employeesList = employeesService.GetEmployeesNotWorking().ToList();

            

            //List<EmployeesInfoDTO> firstList = employeesInfo.ToList();

            GridLocalizer.Active = new MyGridLocalizer();

            foreach (var item in employeesList)
            {
                if ((item.AccountNumber == 1) || item.AccountNumber == 7)
                {
                    item.UserPhoto = Resizer(item.UserPhoto, 190, 210);
                }
                else
                    item.UserPhoto = Resizer(item.UserPhoto, 180, 240);// 195, 260);
            }

            employeesBS.DataSource = employeesList;

            employeesInfoGrid.DataSource = employeesBS;

            employeesCounterEdit.EditValue = employeesList.Count.ToString();

            

            //dateEndWorkCol

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

        private void workingEmployeesBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flag = 0;
            LoadData(true);
        }

        private void employeesInfoGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //flyoutPanel1.ShowPopup();
        }

        void flyoutPanel1_Showing(object sender, DevExpress.Utils.FlyoutPanelEventArgs e)
        {
            //LabelControlResetVisible();
        }

        void flyoutPanel1_Hidden(object sender, DevExpress.Utils.FlyoutPanelEventArgs e)
        {
            //LabelControlResetVisible();
        }

        private void seasonLayOffAnalyzatorBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //using (BusinessTripsEditFm businessTripsEditFm = new BusinessTripsEditFm(operation, model))
            //{
            //    if (businessTripsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        //BusinessTripsDTO return_Id = businessTripsEditFm.Return();
            //        //businessTripsGridView.BeginDataUpdate();
            //        //LoadData((DateTime)firstDateBusinessTripEdit.EditValue, (DateTime)lastDateBusinessTripEdit.EditValue);
            //        //businessTripsGridView.EndDataUpdate();
            //        //int rowHandle = businessTripsGridView.LocateByValue("BusinessTripsID", return_Id.ID);
            //        //businessTripsGridView.FocusedRowHandle = rowHandle;

            //    }
            //}
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void flyoutPanelControl_Click(object sender, EventArgs e)
        {
            //flyoutPanel1.HidePopup();
        }

        private void workingEmployeesOnlineBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flag = 2;
            online = true;
            LoadData(true);
            online = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (flag == 0)
                LoadData(true);
            if (flag == 1)
                LoadData(false);
            if (flag==2)
            {
                online = true;
                LoadData(true);
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