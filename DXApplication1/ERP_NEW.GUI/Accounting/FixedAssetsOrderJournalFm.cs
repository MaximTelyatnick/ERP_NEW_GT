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
using ERP_NEW.BLL;
using DevExpress.Data.Filtering;
using System.Reflection;
using System.Collections;
using ERP_NEW.BLL.DTO.ReportsDTO;
using System.Globalization;

namespace ERP_NEW.GUI.Accounting
{
    public partial class FixedAssetsOrderJournalFm : DevExpress.XtraEditors.XtraForm
    {
        private IFixedAssetsOrderService fixedAssetsOrderService;
        private BindingSource fixedAssetsOrderRegJournalBS = new BindingSource();
        private BindingSource fixedAssetsOrderBS = new BindingSource();
        private BindingSource fixedAssetsOrderMaterialsBS = new BindingSource();
        private DateTime beginDate, endDate, lastDate;
        private IReportService reportService;
        List<FixedAssetsOrderRegJournalDTO> fixedAssetsOrderRegJournalList = new List<FixedAssetsOrderRegJournalDTO>();

        private ObjectBase Item
        {
            get { return fixedAssetsOrderRegJournalBS.Current as ObjectBase; }
            set
            {
                fixedAssetsOrderRegJournalBS.DataSource = value;
                value.BeginEdit();
            }
        }



        public FixedAssetsOrderJournalFm(FixedAssetsOrderJournalDTO fixedAssetsOrderJournalDTO)
        {
            InitializeComponent();
            beginDate = new DateTime(2011, 1, 1);
            endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
            beginDateItem.EditValue = beginDate;
            endDateItem.EditValue = endDate;
            fixedAssetsOrderBS.DataSource = fixedAssetsOrderJournalDTO;
            LoadFixedAssetsOrder();
            
            lastDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
        }
        private void LoadFixedAssetsOrder()
        {
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            fixedAssetsOrderRegJournalBS.DataSource = fixedAssetsOrderService.GetFixedAssetsOrderRegistration((DateTime)beginDateItem.EditValue, (DateTime)endDateItem.EditValue);
            regJournalGrid.DataSource = fixedAssetsOrderRegJournalBS;
            fixedAssetsOrderRegJournalList = fixedAssetsOrderRegJournalBS.DataSource as List<FixedAssetsOrderRegJournalDTO>;
            LoadMaterials(((FixedAssetsOrderRegJournalDTO)fixedAssetsOrderRegJournalBS.Current).FixedAssetsOrderId);
            regJournalGrid.EndUpdate();
        }

        private void LoadMaterials(int fixedAssetsOrderId)
        {
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            fixedAssetsOrderMaterialsBS.DataSource = fixedAssetsOrderService.GetFixedAssestMaterials(fixedAssetsOrderId, (DateTime)endDateItem.EditValue);//lastDay);
            fixedAssetsMaterialsJournalGrid.DataSource = fixedAssetsOrderMaterialsBS;
        }

        public int countRow()
        {
            int count=fixedAssetsOrderRegJournalBS.Count;
            return count;
        }
        private void showRegOrderBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadFixedAssetsOrder();
        }

        private void editBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fixedAssetsOrderRegJournalBS.Count != 0)
            {
                FixedAssetsOrderRegJournalDTO fixedAssetsOrderRegJournalDTO = ((FixedAssetsOrderRegJournalDTO)fixedAssetsOrderRegJournalBS.Current);

                FixedAssetsOrderRegistrationDTO model = new FixedAssetsOrderRegistrationDTO()
                {
                    NumberOrder = fixedAssetsOrderRegJournalDTO.NumberOrder,
                    FixedAssetsOrderId = fixedAssetsOrderRegJournalDTO.FixedAssetsOrderId,
                    Id = fixedAssetsOrderRegJournalDTO.Id,
                    DateOrder = fixedAssetsOrderRegJournalDTO.DateOrder,
                    TypeOrder = fixedAssetsOrderRegJournalDTO.TypeOrder,
                    StatusTypeOrder = fixedAssetsOrderRegJournalDTO.StatusTypeOrder
                     
                };
                EditFixedAssetsOrderReg((FixedAssetsOrderRegistrationDTO)model);
            }
            else MessageBox.Show("Помилка редагування! ", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void EditFixedAssetsOrderReg(FixedAssetsOrderRegistrationDTO model)
        {
            using (FixedAssetsOrderJournalEditFm fixedAssetsOrderJournalEditFm = new FixedAssetsOrderJournalEditFm(model))
            {
                if (fixedAssetsOrderJournalEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FixedAssetsOrderRegistrationDTO return_Id = fixedAssetsOrderJournalEditFm.ReturnInt();
                    LoadFixedAssetsOrder();
                    int rowHandle = regJournalGridView.LocateByValue("Id", return_Id.Id);

                    regJournalGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void deleteBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fixedAssetsOrderRegJournalBS.Count != 0)
                Delete();
        }

        private void Delete()
        {
            if (MessageBox.Show("Видалити рахунок під номером " + ((FixedAssetsOrderRegJournalDTO)fixedAssetsOrderRegJournalBS.Current).FixedAssetsOrderId + "?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (fixedAssetsOrderService.FixedAssetsOrderRegistrationDelete(((FixedAssetsOrderRegJournalDTO)fixedAssetsOrderRegJournalBS.Current).Id))
                {
                    regJournalGrid.BeginUpdate();
                    LoadFixedAssetsOrder();
                    regJournalGrid.EndUpdate();
                    regJournalGrid.Refresh();
                }
            }
        }
        DateTime lastDay = new DateTime(2020, 5, 1);
        private void printOrderBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            var currentRow=(FixedAssetsOrderRegJournalDTO)fixedAssetsOrderRegJournalBS.Current;//??? beginPrice =null
            var currentRowMaterials = (FixedAssetsMaterialsDTO)fixedAssetsOrderMaterialsBS.Current;
            short group = (short)(((FixedAssetsOrderRegJournalDTO)fixedAssetsOrderRegJournalBS.Current).GroupId);
            List<FixedAssetsMaterialsDTO> materialsList = fixedAssetsOrderMaterialsBS.DataSource as List<FixedAssetsMaterialsDTO>; ;
            if (currentRow.StatusTypeOrder == 1)
                reportService.FixedAssetsDecreeInput(currentRow, materialsList);
            if (currentRow.StatusTypeOrder == 2)
                if (currentRowMaterials.Flag==1)
                    reportService.FixedAssetsDecreeAddedPrice(currentRow, currentRowMaterials);
                else MessageBox.Show(" Обрано не вірний матеріал! \n Виберіть матеріл, який збільшив вартість основного засобу.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);           
            if (currentRow.StatusTypeOrder == 3)
                switch (currentRow.GroupId)//group)
                {
                    case 10:
                    case 2:
                        reportService.PrintFixedAssetsOrderActForSaleSoftWare(currentRow);
                        break;
                    default:
                        reportService.PrintFixedAssetsDecreeSold((FixedAssetsOrderRegJournalDTO)fixedAssetsOrderRegJournalBS.Current);
                        break;
                }
        }
        private void fixedAssetsMaterialsJournalGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            FixedAssetsMaterialsDTO materialModel = (FixedAssetsMaterialsDTO)fixedAssetsOrderMaterialsBS[e.ListSourceRowIndex];
            if (e.Column == flagNoteCol && e.IsGetData)
            {
                if (fixedAssetsOrderMaterialsBS.Count > 0)
                {
                    if (materialModel.Flag == 0)
                        e.Value = imageCollection.Images[0];
                    if (materialModel.Flag == 1)
                        e.Value = imageCollection.Images[1];
                    if (materialModel.Flag == 2)
                        e.Value = imageCollection.Images[2];
                    if (materialModel.Flag == 3)
                        e.Value = imageCollection.Images[3];
                }
            }
        }

        private void regJournalGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var currentRow=(FixedAssetsOrderRegJournalDTO)fixedAssetsOrderRegJournalBS.Current;
            if (fixedAssetsOrderRegJournalBS.Count > 0 && fixedAssetsOrderRegJournalBS != null && currentRow.StatusTypeOrder != 3)
                LoadMaterials(((FixedAssetsOrderRegJournalDTO)fixedAssetsOrderRegJournalBS.Current).FixedAssetsOrderId);//Id);
            else
                fixedAssetsOrderMaterialsBS.DataSource = null;

        }

        private void printJournalBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            reportService.PrintAllJournalFixedAssetsOder(fixedAssetsOrderRegJournalList, beginDate, endDate);
        }

        private void regJournalGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gv = sender as GridView;
            if (e.Column.Name == "typeOrderCol")
            {
                if (gv.GetRowCellValue(e.RowHandle, "StatusTypeOrder") != null && gv.GetRowCellValue(e.RowHandle, "StatusTypeOrder").Equals(2))//sale
                {
                    e.Appearance.BackColor = Color.LawnGreen;
                    e.Appearance.BackColor2 = Color.Green;
                }
                if (gv.GetRowCellValue(e.RowHandle, "StatusTypeOrder") != null && gv.GetRowCellValue(e.RowHandle, "StatusTypeOrder").Equals(1))//transfer
                {
                    e.Appearance.BackColor = Color.LightCyan;
                    e.Appearance.BackColor2 = Color.SkyBlue;
                }
                if (gv.GetRowCellValue(e.RowHandle, "StatusTypeOrder") != null && gv.GetRowCellValue(e.RowHandle, "StatusTypeOrder").Equals(3))//transfer
                {
                    e.Appearance.BackColor = Color.Yellow;
                    e.Appearance.BackColor2 = Color.Orange;
                }
            }

        }

           }
}