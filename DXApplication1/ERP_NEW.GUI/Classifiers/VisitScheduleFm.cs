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

using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using System.Drawing.Drawing2D;
using DevExpress.XtraScheduler.Reporting;
using Calendar.NET;
using Nager.Date;


namespace ERP_NEW.GUI.Classifiers
{
    public partial class VisitScheduleFm : DevExpress.XtraEditors.XtraForm
    {
        public UserTasksDTO userTasksDTO;
        public IEmployeesService employeesService;
        public IReportService reportService;

        TimeSpan s1, s2;

        public DateTime currentDateStart, currentDateEnd;

        public BindingSource departmentBS = new BindingSource();
        public BindingSource employeesInfoBS = new BindingSource();
        public BindingSource employeesVisitBS = new BindingSource();
        public BindingSource employeeHistoryBS = new BindingSource();

        public List<EmployeeVisitScheduleDTO> returnTimeSheetList = new List<EmployeeVisitScheduleDTO>();

        public int global;

        public CustomEvent[] events = new CustomEvent[60];
        
        public VisitScheduleFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            global = 0;

            this.userTasksDTO = userTasksDTO;

            SelectDays();

            LoadData();

        }


        #region Method's
        private void LoadData()
        {
            employeesService = Program.kernel.Get<IEmployeesService>();
            employeesInfoBS.DataSource = employeesService.GetEmployeesWorking();
            visitSheduleDepartmentsGrid.DataSource = employeesInfoBS;
            calendarEditor.CalendarDate = DateTime.Today;

            //decimal accountNumber = ((EmployeesInfoDTO)employeesInfoBS.Current).AccountNumber;

            //var employeeHistory = employeesService.GetEmployeeHistory(accountNumber);

        }

        private int CompareTime(string t1, string t2)
        {
             s1 = TimeSpan.Parse(t1);
             s2 = TimeSpan.Parse(t2);
            return s2.CompareTo(s1);
        }

        private void SetValue(EmployeeVisitScheduleDTO source) 
        {
            

            //events[global] = new CustomEvent();
            //events[global].Date = source.Date.Date;
            //events[global].RecurringFrequency = RecurringFrequencies.Daily;
            ////events[global].EventText = "Ушел в 16.55";
            ////events[global].EventColor = Color.Tomato;
            //calendar1.AddEvent(events[global]);

            //++global;


//            for (int i = 0; i > events.Length; i++)
//            {
//                events[i].Date = DateTime.Now.AddDays(i);
//                events[i].RecurringFrequency = RecurringFrequencies.Daily;
//                events[i].EventText = "Ушел в 16.55";
//                events[i].EventColor = Color.Tomato;
//                calendar1.AddEvent(events[i]);
////DateSystem.IsPublicHoliday(new DateTime(currentDate.Year, currentDate.Month, i )),
//               // DateSystem.IsPublicHoliday(new DateTime(currentDate.Year, currentDate.Month, j), CountryCode.UA


//                //if (date == Newdate)
//                ////   return Newdate;
//                //{
//                //    var groundhogEvent = new CustomEvent
//                //    {
//                //        //Date = new DateTime(2019, 3, 8),
//                //        //EventText = "Женньщины ДеНь",
//                //        //RecurringFrequency = RecurringFrequencies.Yearly
                        
//                //        EventText = "Прибуття на роботу -" + date,

//                //        EventColor = Color.FromArgb(0, 255, 0),
//                //        EventTextColor = Color.FromArgb(0, 0, 0),

//                //        RecurringFrequency = RecurringFrequencies.Yearly
//                //    };

//                //    calendar1.AddEvent(events.da);
//                //}
//            }
              
        
        }

        private void SelectDays()
        {
            calendarEditor.CalendarDate = DateTime.Now;
            calendarEditor.CalendarView = CalendarViews.Month;
            calendarEditor.AllowEditingEvents = true;    
        }







        private void LoadEmployeesByDeparnmentsVisitFactory(int employeeId, DateTime startDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            for (global = 0; global < 60; ++global )
                calendarEditor.RemoveEvent(events[global]);
            
            global = 0;
            employeesService = Program.kernel.Get<IEmployeesService>();

            List<EmployeeVisitScheduleDTO> firstList = employeesService.GetEmployeeVisitScheduleProc(employeeId, startDate, endDate).ToList();

            DateTime dateCounter = startDate;
            var intime = new TimeSpan(8, 00, 00);
            var intimeOut = new TimeSpan(16, 50, 00);

            //var timeStartWork = new TimeSpan(8,00,00);
            //var timeEndWork = new TimeSpan(17, 00, 00);
            var timeRez = new TimeSpan(8,00,00);
            //TimeSpan correctlyTime;







            while (dateCounter != endDate)
            {
                var data = firstList.FirstOrDefault(bdsm => bdsm.Date.Date == dateCounter.Date);
                if (data != null)
                {
                    events[global] = new CustomEvent();
                    events[global].Date = ((EmployeeVisitScheduleDTO)data).Date.Date;
                    events[global].EventText = "Прибув " + ((EmployeeVisitScheduleDTO)data).EmployeeCome.TimeOfDay;
                    //correctlyTime = (((EmployeeVisitScheduleDTO)data).EmployeeOut.TimeOfDay)-(((EmployeeVisitScheduleDTO)data).EmployeeCome.TimeOfDay);
                    events[global].EventColor = Color.PaleGreen;
                    events[global].EventTextColor = Color.Black;
                    events[global].Rank = 0;
                    events[global].EventFont = new Font("TimesNewRoman", 11, FontStyle.Regular);
                    calendarEditor.AddEvent(events[global]);
                    ++global;

                    events[global] = new CustomEvent();
                    events[global].Date = ((EmployeeVisitScheduleDTO)data).Date.Date;
                    events[global].EventText = "Вибув " + ((EmployeeVisitScheduleDTO)data).EmployeeOut.TimeOfDay;
                    events[global].EventColor = Color.PaleGreen;
                    events[global].EventTextColor = Color.Black;
                    events[global].EventFont = new Font("TimesNewRoman", 11, FontStyle.Regular);
                    events[global].Rank = 1;
                    calendarEditor.AddEvent(events[global]);
                    ++global;
                }
                dateCounter = dateCounter.AddDays(1);
            }




            




                //-----

                //while (dateCounter != endDate)
                //{
                //    var data = firstList.FirstOrDefault(bdsm => bdsm.Date.Date == dateCounter.Date);
                //    if (data != null)
                //    {
                //        events[global] = new CustomEvent();
                //        events[global].Date = ((EmployeeVisitScheduleDTO)data).Date.Date;
                //        events[global].EventText = "Прибув " + ((EmployeeVisitScheduleDTO)data).EmployeeCome.TimeOfDay;
                //        //correctlyTime = (((EmployeeVisitScheduleDTO)data).EmployeeOut.TimeOfDay)-(((EmployeeVisitScheduleDTO)data).EmployeeCome.TimeOfDay);
                //        events[global].EventColor = Color.PaleGreen;
                //        events[global].EventTextColor = Color.Black;
                //        events[global].Rank = 0;
                //        events[global].EventFont = new Font("TimesNewRoman", 11, FontStyle.Regular);
                //        calendar1.AddEvent(events[global]);
                //        ++global;
                //        global = 1;
                //        events[global] = new CustomEvent();
                //        events[global].Date = ((EmployeeVisitScheduleDTO)data).Date.Date;
                //        events[global].EventText = "Вибув " + ((EmployeeVisitScheduleDTO)data).EmployeeOut.TimeOfDay;
                //        events[global].EventColor = Color.PaleGreen;
                //        events[global].EventTextColor = Color.Black;
                //        events[global].EventFont = new Font("TimesNewRoman", 11, FontStyle.Regular);
                //        events[global].Rank = 1;
                //        calendar1.AddEvent(events[global]);
                //        ++global;
                //        //if (correctlyTime >= timeRez)
                //        //{

                //        //}

                //        //if ((((EmployeeVisitScheduleDTO)data).EmployeeCome.TimeOfDay) < intime)
                //        //{
                //        //    events[global].EventColor = Color.Green;
                //        //}
                //        //else
                //        //{
                //        //    events[global].EventColor = Color.Red;
                //        //}



                //        //events[global].Enabled.
                //        //if ((((EmployeeVisitScheduleDTO)data).EmployeeOut.TimeOfDay)>intimeOut)
                //        //{
                //        //    events[global].EventColor = Color.Green;
                //        //}
                //        //else
                //        //{
                //        //    events[global].EventColor = Color.Red;
                //        //}


                //    }
                //    dateCounter = dateCounter.AddDays(1);
                //}
                //----           
                //DateTime valueTime = ((EmployeesInfoDTO)employeesInfoBS.Current).DateEnd.Date;


                //var accountNumber = ((EmployeesInfoDTO)employeesInfoBS.Current).AccountNumber;

                //var employeeHistory = employeesService.GetEmployeeHistory(accountNumber);



                //var timeList = employeesService.GetEmployeeHistory(432);

                //var accountNumber = ((EmployeesInfoDTO)employeesInfoBS.Current).AccountNumber;

                //var employeeHistory = employeesService.GetEmployeeHistory(1);


                //if (valueTime > DateTime.Now)
                //{
                //    photoPictureEdit.EditValue = ((EmployeesInfoDTO)employeesInfoBS.Current).UserPhoto;
                //    nameProfessionLabel.Text = ((EmployeesInfoDTO)employeesInfoBS.Current).ProfessionName;
                //    accountNumberLabel.Text = ((EmployeesInfoDTO)employeesInfoBS.Current).AccountNumber.ToString();
                //    dateStartWorkingLabel.Text = ((EmployeesInfoDTO)employeesInfoBS.Current).DateBegin.Date.ToString("dd.MM.yyyy");
                //    dateEndWorkingLabel.Text = "по сьогодення";//((EmployeesInfoDTO)employeesInfoBS.Current).DateEnd.Date.ToString("dd.MM.yyyy");
                //}
                //    dateStartWorkingLabel2.Text = ((EmployeesInfoDTO)employeesInfoBS.Current).DateBegin.Date.ToString("dd.MM.yyyy");


                //---

                //List<EmployeesInfoCustomDTO> employeesInfoCustom = new List<EmployeesInfoCustomDTO>();
                //if (employeesInfoCustom.Count() > 0)
                //{
                //    //employeeHistoryBS.DataSource = employeeHistory;

                //    employeeHistoryBS.DataSource = employeesInfoCustom;
                //    employeeHistoryGrid.DataSource = employeeHistoryBS;
                //    photoPictureEdit.EditValue = ((EmployeesInfoDTO)employeesBS.Current).UserPhoto;
                //    fioLabel.Text = ((EmployeesInfoDTO)employeesBS.Current).Fio;
                //    accountNumberLabel.Text = ((EmployeesInfoDTO)employeesBS.Current).AccountNumber.ToString();
                //}
                //else
                //{
                //    employeeHistoryBS.DataSource = null;
                //    employeeHistoryGrid.DataSource = employeeHistoryBS;
                //    photoPictureEdit.EditValue = null;
                //    fioLabel.Text = null;
                //    accountNumberLabel.Text = null;
                //}


                splashScreenManager.CloseWaitForm();

                
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
        public static DateTime NextDayOfWeek(DateTime date, DayOfWeek day)
        {
            int diff = ((int)day - (int)date.DayOfWeek + 6) % 7;
            return date.AddDays((diff + 1) - 7);
        }


        #endregion

        #region Event's

        private void visitSheduleDepartmentsgridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DateTime currentDateTime = NextDayOfWeek(DateTime.Now, DayOfWeek.Sunday);
            LoadEmployeesByDeparnmentsVisitFactory(((EmployeesInfoDTO)employeesInfoBS.Current).EmployeeID, currentDateTime.AddDays(-30), currentDateTime);


            photoPictureEdit.EditValue = Resizer((((EmployeesInfoDTO)employeesInfoBS.Current).UserPhoto), 145, 205);
            nameProfessionLabel.Text = "Назва професії: " + ((EmployeesInfoDTO)employeesInfoBS.Current).ProfessionName;
            accountNumberLabel.Text = "Номер табелю: " + ((EmployeesInfoDTO)employeesInfoBS.Current).AccountNumber.ToString();


            DateTime valueTime = ((EmployeesInfoDTO)employeesInfoBS.Current).DateEnd.Date;
            //var accountNumber = ((EmployeesInfoDTO)employeesInfoBS.Current).AccountNumber;
            //employeesService = Program.kernel.<IEmployeesService>();
            //var employeeHistory = employeesService.GetEmployeeHistory((Decimal)690.00);


            //if (valueTime > DateTime.Now)
            //{
            //    photoPictureEdit.EditValue = ((EmployeesInfoDTO)employeesInfoBS.Current).UserPhoto;
            //nameProfessionLabel.Text = ((EmployeesInfoDTO)employeesInfoBS.Current).ProfessionName;
            //accountNumberLabel.Text = ((EmployeesInfoDTO)employeesInfoBS.Current).AccountNumber.ToString();
            //dateStartWorkingLabel.Text = ((EmployeesInfoDTO)employeesInfoBS.Current).DateBegin.Date.ToString("dd.MM.yyyy");
            //dateEndWorkingLabel.Text = "по сьогодення";//((EmployeesInfoDTO)employeesInfoBS.Current).DateEnd.Date.ToString("dd.MM.yyyy");
            // }



            //    List<EmployeesInfoCustomDTO> employeesInfoCustom = new List<EmployeesInfoCustomDTO>();
            //    if (employeesInfoCustom.Count() > 0)
            //    {
            //        //employeeHistoryBS.DataSource = employeeHistory;

            //        employeeHistoryBS.DataSource = employeesInfoCustom;
            //        visitSheduleDepartmentsGrid.DataSource = employeeHistoryBS;
            //        photoPictureEdit.EditValue = ((EmployeesInfoDTO)employeesInfoBS.Current).UserPhoto;
            ////        fioLabel.Text = ((EmployeesInfoDTO)employeesInfoBS.Current).Fio;
            ////        accountNumberLabel.Text = ((EmployeesInfoDTO)employeesInfoBS.Current).AccountNumber.ToString();
            //    }
            //    else
            //    {
            //        employeeHistoryBS.DataSource = null;
            //        visitSheduleDepartmentsGrid.DataSource = employeeHistoryBS;
            //        photoPictureEdit.EditValue = null;
            ////        fioLabel.Text = null;
            ////        accountNumberLabel.Text = null;
            //    }



            //visitSheduleDepartmentsGrid.DataSource = departmentBS;
            //int employeeId = ((DepartmentsDTO)departmentBS.Current).DepartmentID;

            //for (int i = 0; i > endDate.Day; i++)
            //{
            //    LoadEmployeesByDeparnments(employeeId, startDate, endDate);

            //}



            //LoadEmployeesByDeparnments(((DepartmentsDTO)departmentBS.Current).DepartmentID, startDate, endDate);
            //startDate.AddDays(1);

            //private void schedulerControl1_InitAppointmentDisplayText(object sender, AppointmentDisplayTextEventArgs e)
            //{
            //    //e.Text = e.Appointment.Start.TimeOfDay.ToString() + Environment.NewLine + e.Appointment.End.TimeOfDay.ToString();
            //   // e.Text = e.Appointment.Start.TimeOfDay.ToString();
            //}






            //private void calendar1_Paint(object sender, PaintEventArgs e)
            //{
            //    // Create pen.
            //    Pen blackPen = new Pen(Color.Black, 3);

            //    // Create rectangle for ellipse.
            //    Rectangle rect = new Rectangle(0, 0, 200, 100);

            //    // Draw ellipse to screen.
            //    e.Graphics.DrawEllipse(blackPen, rect);
            //}

        }
        #endregion



    
    }



}