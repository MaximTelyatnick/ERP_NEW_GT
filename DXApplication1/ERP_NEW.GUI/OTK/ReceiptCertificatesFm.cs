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
using Ninject;

using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Services;
using ERP_NEW.BLL.DTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraEditors.Controls;
using ERP_NEW.BLL.Infrastructure;

using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraVerticalGrid.Localization;
using DevExpress.XtraVerticalGrid;
using DevExpress.Utils;

namespace ERP_NEW.GUI.OTK
{
    public partial class ReceiptCertificatesFm : DevExpress.XtraEditors.XtraForm
    {
        private IReceiptCertificateService receiptCertificateService;
        private BindingSource ordersBS = new BindingSource();
        private ReceiptCertificatesDTO certificateDTO;
      
        public ReceiptCertificatesFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            SetGridFont(receiptsCertificateVGrid, new Font("Tahoma", 9), Color.Black);

            VGridLocalizer.Active = new VerticalGridLocalizer();
            //this.receiptsCertificateVGrid.ViewInfo[vertGridRenameHitInfo.Row].

            //var findPanel = receiptsCertificateVGrid.Controls.Find("FindControl", true).FirstOrDefault(control => control.Name == "FindControl") as DevExpress.XtraEditors.Controls;
            
            receiptsCertificateVGrid.Rows["changesBtn"].Properties.ReadOnly = (userTasksDTO.AccessRightId == 1);

            DateTime begin_Date = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); // год - месяц - день
            DateTime end_Date = DateTime.Today;
            beginDateEdit.EditValue = begin_Date;
            endDateEdit.EditValue = end_Date;
            LoadData(begin_Date, end_Date);
         }

        private void receiptsCertificateVGrid_CustomUnboundData(object sender, DevExpress.XtraVerticalGrid.Events.CustomDataEventArgs e)
        {
            if (e.Row == informationRow && e.IsGetData)
            {
                int flag;
                if (((OrdersInfoDTO)ordersBS[e.ListSourceRowIndex]).ScanPersence == 1)
                {
                    flag = 3;
                    e.Value = imageCollection1.Images[flag];
                }
            }
        }
        private void LoadData(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();
            receiptCertificateService = Program.kernel.Get<IReceiptCertificateService>();

            VGridLocalizer.Active = new VerticalGridLocalizer();

            var orders = receiptCertificateService.GetOrdersWithCertificate(beginDate, endDate);
            ordersBS.DataSource = orders;
            receiptsCertificateVGrid.DataSource = ordersBS;

            

            splashScreenManager.CloseWaitForm();
            receiptsCertificateVGrid.Focus();
        }

        private void showOrdersForDate_Click(object sender, EventArgs e)
        {
            DateTime begin_Date = (DateTime)beginDateEdit.EditValue;
            DateTime end_Date = (DateTime)endDateEdit.EditValue;
            LoadData(begin_Date, end_Date);
            VGridLocalizer.Active = new VerticalGridLocalizer();
        }

        private void repositoryItemPictureEdit1_DoubleClick(object sender, EventArgs e)
        {
          if (((OrdersInfoDTO)ordersBS.Current).ScanPersence == 1)
          {
            string fileName = ((OrdersInfoDTO)ordersBS.Current).FileName;
            long id =(long)((OrdersInfoDTO)ordersBS.Current).ReceiptCertificateId;
            certificateDTO = receiptCertificateService.GetCertificate(id);
            byte[] scan = certificateDTO.CertificateScan;
            string puth = Utils.HomePath + @"\Temp\";

            System.IO.File.WriteAllBytes(puth + fileName, scan);

            System.Diagnostics.Process.Start(puth + fileName);
          }
        }

        private void imageComboBoxEdit1_SelectedValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.ImageComboBoxEdit combo = (DevExpress.XtraEditors.ImageComboBoxEdit)sender;
            var value= combo.SelectedItem;
        }

        void SetGridFont(VGridControl control, Font font, Color color)
        {
            foreach (AppearanceObject ap in control.Appearance)
            {
                ap.Font = font;
                ap.ForeColor = color;
            }              
        }

        private void repositoryItemImageComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.ImageComboBoxEdit combo = (DevExpress.XtraEditors.ImageComboBoxEdit)sender;
               
            var selected = combo.EditValue;
            switch ((short)selected)
            {
                case 0:
                    if (((OrdersInfoDTO)ordersBS.Current).ReceiptCertificateId == null)
                    {
                        editCertificate(Utils.Operation.Add);
                    }
                    else
                        MessageBox.Show("Сертифікат вже закріплений за вибраним надходженням!");
                    break;
                case 1:
                    if (((OrdersInfoDTO)ordersBS.Current).ReceiptCertificateId != null)
                    {
                       editCertificate(Utils.Operation.Update);
                    }
                    else
                        MessageBox.Show("Сертифікат не закріплений за вибраним надходженням!");
                    break;
                case 2:

                    if (((OrdersInfoDTO)ordersBS.Current).ReceiptCertificateId != null)
                    {
                        if (MessageBox.Show("Видалити сертифікат?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            long id = (long)((OrdersInfoDTO)ordersBS.Current).ReceiptCertificateId;

                            if (receiptCertificateService.RemoveCertificateById(id))
                            {
                                DateTime begin_Date = (DateTime)beginDateEdit.EditValue;
                                DateTime end_Date = (DateTime)endDateEdit.EditValue;
                                LoadData(begin_Date, end_Date);
                                receiptsCertificateVGrid.Focus();
                            }
                        }
                    }
                    else
                        MessageBox.Show("Сертифікат не закріплений за вибраним надходженням!");

                    break;
                default:
                    break;
            }
        }

        private void editCertificate(Utils.Operation operation)
        {
            //CertificateEditFm certificateEditFm = new CertificateEditFm(operation, (OrdersInfoDTO)ordersBS.Current);
           
            //if (certificateEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    DateTime begin_Date = (DateTime)beginDateEdit.EditValue;
            //    DateTime end_Date = (DateTime)endDateEdit.EditValue;
            //    LoadData(begin_Date, end_Date);
            //    receiptsCertificateVGrid.Focus();
            //}
        }

        private void rulesBtn_Click(object sender, EventArgs e)
        {
            
           // System.Diagnostics.Process.Start( Utils.HomePath+@"\FindPanel.docx");
        }

        private void receiptsCertificateVGrid_Layout(object sender, LayoutEventArgs e)
        {
           // var gridControl = sender as DevExpress.XtraVerticalGrid.VGridControl;

            //var findPanel = receiptsCertificateVGrid.Controls.Find("FindControl", true).FirstOrDefault(control => control.Name == "FindControl");
            //    if (findPanel == null)
            //        return;
            //    var fontSizeDelta = 15;


            //    //findPanel.FindButton.Appearance.FontSizeDelta = fontSizeDelta;
            //    ////findPanel.FindButton.Appearance.FontSizeDelta
            //    //findPanel.ClearButton.Appearance.FontSizeDelta = fontSizeDelta;
            //    ////findPanel.CloseButton.Appearance.FontSizeDelta = fontSizeDelta;
            //    //findPanel.FindEdit.Properties.Appearance.FontSizeDelta = fontSizeDelta;
            
        }


    }
    #region Custom search and clear button

    public class VerticalGridLocalizer : VGridLocalizer
    {
        public override string GetLocalizedString(VGridStringId id)
        {
            if (id == VGridStringId.FindControlFindButton)
                return "Додати критерій пошуку";
            if (id == VGridStringId.FindControlClearButton)
                return "Відмінити";

            if (id == VGridStringId.FindNullPrompt)
                return "Відмінити";
         //   if (id == VGridStringId.CustomFilterDialogHint)
           //     return "Відмінити";
            //if (id == GridStringId)
            //    return "Відмінити";
            //if (id == GridStringId.Hin)
            //    return "Відмінити";
            return base.GetLocalizedString(id);
        }
    }

    #endregion


    public class CtbFindControl : FindControl
    {
        public CtbFindControl(ColumnView view, object findPanelProperties)
            : base(view, findPanelProperties)
        {
            //UpdateDropDownButtonVisibility();
            //teFind.Properties.Items.CollectionChanged += new CollectionChangeEventHandler(Items_CollectionChanged);
        }

        public bool ShowFindButton
        {
            get { return lciFindButton.Visibility == LayoutVisibility.Always; }
            set { lciFindButton.Visibility = value ? LayoutVisibility.Always : LayoutVisibility.Never; }
        }

        public bool ShowClearButton
        {
            get { return lciClearButton.Visibility == LayoutVisibility.Always; }
            set { lciClearButton.Visibility = value ? LayoutVisibility.Always : LayoutVisibility.Never; }
        }

        public string FindText
        {
            get { return lciFind.Text; }
            set
            {
                lciFind.Text = value;
                lciFind.TextVisible = lciFind.Text != "";
            }
        }
    }
}