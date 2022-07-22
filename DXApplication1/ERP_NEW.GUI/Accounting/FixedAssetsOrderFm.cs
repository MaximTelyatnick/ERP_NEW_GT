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
using DevExpress.XtraPrinting;


namespace ERP_NEW.GUI.Accounting
{
    public partial class FixedAssetsOrderFm : DevExpress.XtraEditors.XtraForm
    {
        private UserTasksDTO userTasksDTO;
        private IFixedAssetsOrderService fixedAssetsOrderService;
        private IReportService reportService;
        private IAccountsService accountsService;

        private BindingSource fixedAssetsOrderBS = new BindingSource();
        private BindingSource fixedAssetsOrderNoAmortBS = new BindingSource();
        private BindingSource fixedAssetsOrderMaterialsBS = new BindingSource();
        private BindingSource fixedAssetsOrderArchiveBS = new BindingSource();
        private BindingSource fixedAssetsOrderArchiveBStest = new BindingSource();
        private BindingSource fixedAssetsOrderAmortizationDateBS = new BindingSource();
        private List<FixedAssetsMaterialsDTO> materialsList = new List<FixedAssetsMaterialsDTO>();
        private List<FixedAssetsMaterialsDTO> testMaterialsList = new List<FixedAssetsMaterialsDTO>();
        private List<FixedAssetsOrderJournalDTO> testFAList = new List<FixedAssetsOrderJournalDTO>();
        private List<FixedAssetsOrderArchiveJournalDTO> archiveList = new List<FixedAssetsOrderArchiveJournalDTO>();           
        private DateTime lastDay, firstDay, beginDateArchive, endDateArchive;
        int check = 0;
        //if rezTagTabPage=1 - enter fixedAssetsOrder  if rezTagTabPage=2 - enter archive
        string rezTagTabPage="0";

        private ObjectBase ItemJournal
        {
            get { return fixedAssetsOrderBS.Current as ObjectBase; }
            set
            {
                fixedAssetsOrderBS.DataSource = value;
                value.BeginEdit();
            }
        }

        private ObjectBase ItemJournalArchive
        {
            get { return fixedAssetsOrderArchiveBS.Current as ObjectBase; }
            set
            {
                fixedAssetsOrderArchiveBS.DataSource = value;
                value.BeginEdit();
            }
        }
        public FixedAssetsOrderFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            this.userTasksDTO = userTasksDTO;

            monthEdit.EditValue = DateTime.Now.Month;
            yearEdit.EditValue = DateTime.Now;

            beginDateArchive = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            endDateArchive = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            beginDateArchiveEdit.EditValue = beginDateArchive;
            endDateArchiveEdit.EditValue = endDateArchive;

            

            LoadFixedAssetsOrder();
            LoadFixedAssetsOrderArchive((DateTime)beginDateArchiveEdit.EditValue, (DateTime)endDateArchiveEdit.EditValue);

            
        }

        #region Method's
        #region FixedAssetsOrder
        
        private void LoadFixedAssetsOrder()
        {
            splashScreenManager.ShowWaitForm();
            fixedAssetsOrderGridView.BeginDataUpdate();
            //fixedAssetsAmortGridView.BeginDataUpdate();

            firstDay = new DateTime(((DateTime)yearEdit.EditValue).Year, (int)monthEdit.EditValue, 1);
            lastDay = new DateTime(((DateTime)yearEdit.EditValue).Year, (int)monthEdit.EditValue, 1).AddMonths(1).AddDays(-1);
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            testFAList = fixedAssetsOrderService.GetFixedAssetsOrderJournal(lastDay).ToList();
            fixedAssetsOrderBS.DataSource = testFAList;
            //fixedAssetsOrderNoAmortBS.DataSource = testFAList;
            fixedAssetsOrderGrid.DataSource = fixedAssetsOrderBS;
            //fixedAssetsAmortGrid.DataSource = fixedAssetsOrderNoAmortBS;
            fixedAssetsOrderGrid.EndUpdate();
            fixedAssetsOrderGridView.EndDataUpdate();
            //fixedAssetsAmortGridView.EndDataUpdate();
            splashScreenManager.CloseWaitForm();

            testFAList = fixedAssetsOrderBS.DataSource as List<FixedAssetsOrderJournalDTO>;
            //----
          //  TestAmortization();
            //----
        }

        private void LoadMaterials(int fixedAssetsOrderId)
        {
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            fixedAssetsOrderMaterialsBS.DataSource = fixedAssetsOrderService.GetFixedAssestMaterials(fixedAssetsOrderId, lastDay);
            fixedAssetsMaterialsGrid.DataSource = fixedAssetsOrderMaterialsBS;
            testMaterialsList = fixedAssetsOrderMaterialsBS.DataSource as List<FixedAssetsMaterialsDTO>;
        }

        private void LoadAmortizationDate(int fixedAssetsOrderId)
        {
            //fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            //fixedAssetsOrderAmortizationDateBS.DataSource = fixedAssetsOrderService.GetFixedAssestAmortizationDateById(fixedAssetsOrderId);
            //dateNoAmortGrid.DataSource = fixedAssetsOrderAmortizationDateBS;
            //testMaterialsList = fixedAssetsOrderMaterialsBS.DataSource as List<FixedAssetsMaterialsDTO>;
        }

        /*     
               private void TestAmortization()
               {
                    List<FixedAssetsOrderJournalDTO> test = new List<FixedAssetsOrderJournalDTO>();
                    List<FixedAssetsOrderJournalDTO> rez = new List<FixedAssetsOrderJournalDTO>();
                    rez = testFAList;
                   // testFAList.RemoveAt(56);
                   DateTime year=(DateTime)yearEdit.EditValue;


                   //for(int i=0; i<testMaterialsList.Count;i++)
                   //{
                   //    ordDateMonth = testMaterialsList[i].OrderDate.Value.Month;
                   //    expDateMonth = testMaterialsList[i].ExpDate.Value.Month;
                   //    if (ordDateMonth != expDateMonth)
                   //        rez.Add(testMaterialsList[i]);
                   //}
                   testFAList=testFAList.Where(a => a.Id == 56).ToList();

                   if ((int)monthEdit.EditValue == 12 && year.Year==2020)
                   {
                       check = 1;
                       fixedAssetsOrderGridView.BeginDataUpdate();
                       test = testFAList.Select(a => new FixedAssetsOrderJournalDTO
                           {
                               Id = a.Id,
                               CurrentAmortization = (decimal)(1609.30),
                               Balance_Account_Id = a.Balance_Account_Id,
                               BalanceAccountNum = a.BalanceAccountNum,
                               BeginDate = a.BeginDate,
                               BeginPrice = a.BeginPrice,
                               BeginRecordDate = a.BeginRecordDate,
                               CurrentPrice = a.CurrentPrice,
                               EndRecordDate = a.EndRecordDate,
                               FixedAccountId = a.FixedAccountId,
                               FixedAccountNum = a.FixedAccountNum,
                               FixedCardStatus = a.FixedCardStatus,
                               InventoryName = a.InventoryName,
                               TotalPrice = a.TotalPrice,
                               GroupId = a.GroupId,
                               GroupName = a.GroupName,
                               Id_Parent = a.Id_Parent,
                               IncreasePrice = a.IncreasePrice,
                               UsefulMonth = a.UsefulMonth,
                               InventoryNumber = a.InventoryNumber,
                               OperatingPerson_Id = a.OperatingPerson_Id,
                               OperatingPersonName = a.OperatingPersonName,
                               PeriodAmortization = a.PeriodAmortization,
                               PeriodYearAmortization = a.PeriodYearAmortization+(decimal)(1296.05),
                               Region_Id = a.Region_Id,
                               RegionName = a.RegionName,
                               SupplierId = a.SupplierId,
                               SupplierName = a.SupplierName,
                               SelectedCard = a.SelectedCard


                           }).ToList();
                       rez.AddRange(test);
                     //   = //==56 && p.CurrentAmortization==(decimal)313.25);
                       var w = rez.Single(a => a.Id == 56 && a.CurrentAmortization == (decimal)313.25);//((from r in rez select r.Id).Distinct()).ToList();
                      rez.Remove(w);
                       fixedAssetsOrderGrid.DataSource = rez;
                       fixedAssetsOrderGridView.EndDataUpdate();


                   }
                   //for(int i=0;i<testFAList.Count;i++)
                   //{

                   //}
               }

               */
        private void AddFixedAssetsOrder(Utils.Operation operation, FixedAssetsOrderDTO model, List<FixedAssetsMaterialsDTO> materialsListSource)
        {
            using (FixedAssetsOrderEditFm fixedAssetsOrderEditFm = new FixedAssetsOrderEditFm(operation, model, materialsListSource))
            {
                if (fixedAssetsOrderEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FixedAssetsOrderDTO return_Id = fixedAssetsOrderEditFm.ReturnInt();
                    LoadFixedAssetsOrder();
                    int rowHandle = fixedAssetsOrderGridView.LocateByValue("Id", return_Id.Id);

                    fixedAssetsOrderGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void SoldFixedAssetsOrder(FixedAssetsOrderDTO model, List<FixedAssetsMaterialsDTO> materialsListSource)
        {
            using (FixedAssetsOrderSoldFm fixedAssetsOrderSold = new FixedAssetsOrderSoldFm(model, materialsListSource))
            {
                if (fixedAssetsOrderSold.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FixedAssetsOrderDTO return_Id = fixedAssetsOrderSold.ReturnInt();
                    LoadFixedAssetsOrder();
                    int rowHandle = fixedAssetsOrderGridView.LocateByValue("Id", return_Id.Id);
                    fixedAssetsOrderGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void ExpenditureFixedAssetsOrder(FixedAssetsOrderDTO model, List<FixedAssetsMaterialsDTO> materialsListSource)
        {
            using (FixedAssetsOrderExpenFm fixedAssetsOrderExpen = new FixedAssetsOrderExpenFm(model, materialsListSource))
            {
                if (fixedAssetsOrderExpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FixedAssetsOrderDTO return_Id = fixedAssetsOrderExpen.ReturnInt();
                    LoadFixedAssetsOrder();
                    int rowHandle = fixedAssetsOrderGridView.LocateByValue("Id", return_Id.Id);
                    fixedAssetsOrderGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void TransferFixedAssetsOrder(FixedAssetsOrderDTO model, List<FixedAssetsMaterialsDTO> materialsListSource)
        {
            using (FixedAssetsOrderTransferFm fixedAssetsOrderTransferFm = new FixedAssetsOrderTransferFm(model, materialsListSource))
            {
                if (fixedAssetsOrderTransferFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FixedAssetsOrderDTO returnupd = fixedAssetsOrderTransferFm.Returnupd();
                    LoadFixedAssetsOrder();
                    int rowHandleUp = fixedAssetsOrderGridView.LocateByValue("Id", returnupd.Id);
                    fixedAssetsOrderGridView.FocusedRowHandle = rowHandleUp;
                }
            }
        }
        #endregion

        #region Archive
        public void LoadFixedAssetsOrderArchive(DateTime beginDate,DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();
            fixedAssetsArchiveGridView.BeginDataUpdate();
            fixedAssetsOrderArchiveBS.DataSource = fixedAssetsOrderService.GetFixedAssetsOrderArchive(beginDate,endDate).ToList();
            fixedAssetsArchiveGrid.DataSource = fixedAssetsOrderArchiveBS;
            fixedAssetsArchiveGridView.EndDataUpdate();
            splashScreenManager.CloseWaitForm();
        }
        #endregion

        #endregion

        #region Event's


        #region FixesAssetsOrder

        private void fixedAssesOrderShowBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadFixedAssetsOrder();
        }

        private void addBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddFixedAssetsOrder(Utils.Operation.Add, new FixedAssetsOrderDTO(), new List<FixedAssetsMaterialsDTO>());
        }

        private void editBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fixedAssetsOrderBS.Count != 0)
            {
                FixedAssetsOrderDTO model = new FixedAssetsOrderDTO()
                {
                    Id = ((FixedAssetsOrderJournalDTO)ItemJournal).Id,
                    Id_Parent = ((FixedAssetsOrderJournalDTO)ItemJournal).Id_Parent,
                    Balance_Account_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).Balance_Account_Id,
                    BeginDate = ((FixedAssetsOrderJournalDTO)ItemJournal).BeginDate, 
                    CurrentAmortization = ((FixedAssetsOrderJournalDTO)ItemJournal).CurrentAmortization,
                    CurrentPrice = ((FixedAssetsOrderJournalDTO)ItemJournal).CurrentPrice,
                    FixedAccountId = testMaterialsList[0].Fixed_Account_Id,//((FixedAssetsOrderJournalDTO)ItemJournal).FixedAccountId,
                    FixedAccountNum = testMaterialsList[0].FixedNum,//((FixedAssetsOrderJournalDTO)ItemJournal).FixedAccountNum,
                    Group_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).GroupId,
                    GroupName = ((FixedAssetsOrderJournalDTO)ItemJournal).GroupName,
                    UsefulMonth = ((FixedAssetsOrderJournalDTO)ItemJournal).UsefulMonth,
                    IncreasePrice = ((FixedAssetsOrderJournalDTO)ItemJournal).IncreasePrice,
                    InventoryName = ((FixedAssetsOrderJournalDTO)ItemJournal).InventoryName,
                    InventoryNumber = ((FixedAssetsOrderJournalDTO)ItemJournal).InventoryNumber,
                    OperatingPerson_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).OperatingPerson_Id,
                    OperatingPersonName = ((FixedAssetsOrderJournalDTO)ItemJournal).OperatingPersonName,
                    PeriodAmortization = ((FixedAssetsOrderJournalDTO)ItemJournal).PeriodAmortization,
                    PeriodYearAmortization = ((FixedAssetsOrderJournalDTO)ItemJournal).PeriodYearAmortization,
                    Region_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).Region_Id,
                    RegionName = ((FixedAssetsOrderJournalDTO)ItemJournal).RegionName,
                    Supplier_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).SupplierId,
                    SupplierName = ((FixedAssetsOrderJournalDTO)ItemJournal).SupplierName,
                    TotalPrice = ((FixedAssetsOrderJournalDTO)ItemJournal).TotalPrice,
                    BeginRecordDate = ((FixedAssetsOrderJournalDTO)ItemJournal).BeginRecordDate,
                    EndRecordDate = ((FixedAssetsOrderJournalDTO)ItemJournal).EndRecordDate,
                    FixedCardStatus = ((FixedAssetsOrderJournalDTO)ItemJournal).FixedCardStatus,
                    BeginPrice = ((FixedAssetsOrderJournalDTO)ItemJournal).BeginPrice,
                    BalanceAccountNum = ((FixedAssetsOrderJournalDTO)ItemJournal).BalanceAccountNum
                  

                };
                AddFixedAssetsOrder(Utils.Operation.Update, (FixedAssetsOrderDTO)model, (List<FixedAssetsMaterialsDTO>)fixedAssetsOrderMaterialsBS.DataSource);
            }
            else MessageBox.Show("Помилка редагування основного засобу! ", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void fixedAssetsOrderGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (((FixedAssetsOrderJournalDTO)ItemJournal).EndRecordDate != null)
            {
                deleteBtn.Enabled = false;
                editBtn.Enabled = false;
                soldFixeAssetsBtn.Enabled = false;
                expFixeAssetsBtn.Enabled = false;
                transferFixeAssetsBtn.Enabled = false;
            }
            else
            {
                deleteBtn.Enabled = true;
                editBtn.Enabled = true;
                soldFixeAssetsBtn.Enabled = true;
                expFixeAssetsBtn.Enabled = true;
                transferFixeAssetsBtn.Enabled = true;
            }
            


            if (check == 0)
            {
                if (fixedAssetsOrderBS.Count > 0 && fixedAssetsOrderBS != null)
                    LoadMaterials(((FixedAssetsOrderJournalDTO)fixedAssetsOrderBS.Current).Id);
                else
                    fixedAssetsOrderMaterialsBS.DataSource = null;
            }
            else
            {
                LoadMaterials(56);
                check = 1;
            }
        }
        private void deleteBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fixedAssetsOrderBS.Count != 0)
            {
                if (MessageBox.Show("Видалити запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();

                    if (fixedAssetsOrderService.FixedAssetsOrderDelete(((FixedAssetsOrderJournalDTO)fixedAssetsOrderBS.Current).Id))
                    {
                        FixedAssetsOrderDTO oldFixedAssets = fixedAssetsOrderService.GetFixedAssestsOrder().Where(srch => srch.Id == ((FixedAssetsOrderJournalDTO)fixedAssetsOrderBS.Current).Id_Parent).FirstOrDefault();
                        if (oldFixedAssets != null)
                        {
                            oldFixedAssets.EndRecordDate = null;
                            fixedAssetsOrderService.FixedAssetsOrderUpdate(oldFixedAssets);
                        }
                           
                        int rowHandle = fixedAssetsOrderGridView.FocusedRowHandle - 1;
                        fixedAssetsOrderGridView.BeginDataUpdate();

                        fixedAssetsOrderGridView.EndDataUpdate();
                        fixedAssetsOrderGridView.FocusedRowHandle = (fixedAssetsOrderGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                        LoadFixedAssetsOrder();
                    }
                }
            }
        }

        private void fixedAssetsMaterialsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
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

        private void soldFixeAssetsBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(((FixedAssetsOrderJournalDTO)ItemJournal).EndRecordDate!=null)
            {
                MessageBox.Show("Не можливо продати основний засіб який було раніше списано, продано, або переміщено! ", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FixedAssetsOrderDTO model = new FixedAssetsOrderDTO()
                {
                    Id = ((FixedAssetsOrderJournalDTO)ItemJournal).Id,
                    Id_Parent = ((FixedAssetsOrderJournalDTO)ItemJournal).Id_Parent,
                    Balance_Account_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).Balance_Account_Id,
                    BeginDate = ((FixedAssetsOrderJournalDTO)ItemJournal).BeginDate,
                    CurrentAmortization = ((FixedAssetsOrderJournalDTO)ItemJournal).CurrentAmortization,
                    CurrentPrice = ((FixedAssetsOrderJournalDTO)ItemJournal).CurrentPrice,
                    FixedAccountId = ((FixedAssetsOrderJournalDTO)ItemJournal).FixedAccountId,
                    FixedAccountNum = ((FixedAssetsOrderJournalDTO)ItemJournal).FixedAccountNum,
                    Group_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).GroupId,
                    GroupName = ((FixedAssetsOrderJournalDTO)ItemJournal).GroupName,
                    UsefulMonth = ((FixedAssetsOrderJournalDTO)ItemJournal).UsefulMonth,
                    IncreasePrice = ((FixedAssetsOrderJournalDTO)ItemJournal).IncreasePrice,
                    InventoryName = ((FixedAssetsOrderJournalDTO)ItemJournal).InventoryName,
                    InventoryNumber = ((FixedAssetsOrderJournalDTO)ItemJournal).InventoryNumber,
                    OperatingPerson_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).OperatingPerson_Id,
                    OperatingPersonName = ((FixedAssetsOrderJournalDTO)ItemJournal).OperatingPersonName,
                    PeriodAmortization = ((FixedAssetsOrderJournalDTO)ItemJournal).PeriodAmortization,
                    PeriodYearAmortization = ((FixedAssetsOrderJournalDTO)ItemJournal).PeriodYearAmortization,
                    Region_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).Region_Id,
                    RegionName = ((FixedAssetsOrderJournalDTO)ItemJournal).RegionName,
                    Supplier_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).SupplierId,
                    SupplierName = ((FixedAssetsOrderJournalDTO)ItemJournal).SupplierName,
                    TotalPrice = ((FixedAssetsOrderJournalDTO)ItemJournal).TotalPrice,
                    BeginRecordDate = ((FixedAssetsOrderJournalDTO)ItemJournal).BeginRecordDate,
                    EndRecordDate = ((FixedAssetsOrderJournalDTO)ItemJournal).EndRecordDate,
                    FixedCardStatus = ((FixedAssetsOrderJournalDTO)ItemJournal).FixedCardStatus,
                    BeginPrice = ((FixedAssetsOrderJournalDTO)ItemJournal).BeginPrice,
                    BalanceAccountNum = ((FixedAssetsOrderJournalDTO)ItemJournal).BalanceAccountNum
                };
            SoldFixedAssetsOrder((FixedAssetsOrderDTO)model, (List<FixedAssetsMaterialsDTO>)fixedAssetsOrderMaterialsBS.DataSource);

        }
        private void transferFixeAssetsBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

             if(((FixedAssetsOrderJournalDTO)ItemJournal).EndRecordDate != null)
            {
                MessageBox.Show("Не можливо перемістити основний засіб, який було переміщено раніше! ", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FixedAssetsOrderDTO model = new FixedAssetsOrderDTO()
            {
                Id = ((FixedAssetsOrderJournalDTO)ItemJournal).Id,
                Id_Parent = ((FixedAssetsOrderJournalDTO)ItemJournal).Id_Parent,
                Balance_Account_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).Balance_Account_Id,
                BeginDate = ((FixedAssetsOrderJournalDTO)ItemJournal).BeginDate,
                CurrentAmortization = ((FixedAssetsOrderJournalDTO)ItemJournal).CurrentAmortization,
                CurrentPrice = ((FixedAssetsOrderJournalDTO)ItemJournal).CurrentPrice,
                FixedAccountId = ((FixedAssetsOrderJournalDTO)ItemJournal).FixedAccountId,
                FixedAccountNum = ((FixedAssetsOrderJournalDTO)ItemJournal).FixedAccountNum,
                Group_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).GroupId,
                GroupName = ((FixedAssetsOrderJournalDTO)ItemJournal).GroupName,
                UsefulMonth = ((FixedAssetsOrderJournalDTO)ItemJournal).UsefulMonth,
                IncreasePrice = ((FixedAssetsOrderJournalDTO)ItemJournal).IncreasePrice,
                InventoryName = ((FixedAssetsOrderJournalDTO)ItemJournal).InventoryName,
                InventoryNumber = ((FixedAssetsOrderJournalDTO)ItemJournal).InventoryNumber,
                OperatingPerson_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).OperatingPerson_Id,
                OperatingPersonName = ((FixedAssetsOrderJournalDTO)ItemJournal).OperatingPersonName,
                PeriodAmortization = ((FixedAssetsOrderJournalDTO)ItemJournal).PeriodAmortization,
                PeriodYearAmortization = ((FixedAssetsOrderJournalDTO)ItemJournal).PeriodYearAmortization,
                Region_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).Region_Id,
                RegionName = ((FixedAssetsOrderJournalDTO)ItemJournal).RegionName,
                Supplier_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).SupplierId,
                SupplierName = ((FixedAssetsOrderJournalDTO)ItemJournal).SupplierName,
                TotalPrice = ((FixedAssetsOrderJournalDTO)ItemJournal).TotalPrice,
                BeginRecordDate = ((FixedAssetsOrderJournalDTO)ItemJournal).BeginRecordDate,
                EndRecordDate = ((FixedAssetsOrderJournalDTO)ItemJournal).EndRecordDate,
                FixedCardStatus = ((FixedAssetsOrderJournalDTO)ItemJournal).FixedCardStatus,
                BeginPrice = ((FixedAssetsOrderJournalDTO)ItemJournal).BeginPrice,
                BalanceAccountNum = ((FixedAssetsOrderJournalDTO)ItemJournal).BalanceAccountNum

            };
            TransferFixedAssetsOrder((FixedAssetsOrderDTO)model, (List<FixedAssetsMaterialsDTO>)fixedAssetsOrderMaterialsBS.DataSource);
        }

        private void printBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
           // if (check == 0)
                reportService.PrintFixedAssetsOder((FixedAssetsOrderJournalDTO)fixedAssetsOrderBS.Current, (List<FixedAssetsMaterialsDTO>)fixedAssetsOrderMaterialsBS.DataSource, lastDay, firstDay);
            //else
            //{
            //    LoadMaterials(56);
            //    var t = ((FixedAssetsOrderJournalDTO)ItemJournal);//fixedAssetsOrderBS.Current);
            //    t.Id = 56;
            //    t.PeriodYearAmortization = (decimal)(5055.05);
            //    t.BeginPrice = (decimal)(234782.14);
            //    t.IncreasePrice = (decimal)(96558.15);
            //    t.TotalPrice = (decimal)(331340.29);
            //    t.CurrentPrice = (decimal)(91546.15);
            //    t.PeriodAmortization = (decimal)(239794.14);
            //    t.CurrentAmortization = (decimal)(1609.3);
            //    t.InventoryName = t.InventoryName;
            //    t.InventoryNumber = "104530";
            //    reportService.PrintFixedAssetsOder(t, (List<FixedAssetsMaterialsDTO>)fixedAssetsOrderMaterialsBS.DataSource, lastDay, firstDay);
            //    check = 0;
            //}
        }
        private void printInventoryCardBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            if (((FixedAssetsOrderJournalDTO)fixedAssetsOrderBS.Current).GroupId == 10)
                reportService.PrintInventoryCardForSoftware((FixedAssetsOrderJournalDTO)fixedAssetsOrderBS.Current);
            else
                MessageBox.Show("Картка " + ((FixedAssetsOrderJournalDTO)fixedAssetsOrderBS.Current).InventoryNumber + " не є об'єктом права інтелектуальної власності.\n Необхідно обрати групу Авторське право та суміжні з ним права", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void actBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            if (fixedAssetsOrderBS.Count > 0)
            {
                short group = (short)(((FixedAssetsOrderJournalDTO)fixedAssetsOrderBS.Current).GroupId);
                switch (group)
                {
                    case 10:
                    case 2:
                        reportService.PrintFixedAssetsOrderActForSoftware((FixedAssetsOrderJournalDTO)fixedAssetsOrderBS.Current);
                        break;
                    default:
                        reportService.PrintFixedAssetsOrderAct((FixedAssetsOrderJournalDTO)fixedAssetsOrderBS.Current, (List<FixedAssetsMaterialsDTO>)fixedAssetsOrderMaterialsBS.DataSource);
                        break;
                }
            }
            else MessageBox.Show("Оберіть основний засіб! ", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void actWriteOffBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            int monthSource, yearSource;

            monthSource = (int)monthEdit.EditValue;
            yearSource = (int)(((DateTime)yearEdit.EditValue).Year);

            if (fixedAssetsOrderBS.Count > 0)
            {
                decimal curPrice = (decimal)(((FixedAssetsOrderJournalDTO)fixedAssetsOrderBS.Current).CurrentPrice);
                if (curPrice == 0)
                    MessageBox.Show("Залишкова вартість обраної картки не дорівнює нулю", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reportService.PrintFixedAssetsOrderActWriteOff((FixedAssetsOrderJournalDTO)fixedAssetsOrderBS.Current, (List<FixedAssetsMaterialsDTO>)fixedAssetsOrderMaterialsBS.DataSource, monthSource, yearSource);

            }
            else MessageBox.Show("Оберіть основний засіб! ", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void materialsBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FixedAssetsOrderMaterialsForPrintFm(lastDay).Show();//, materialsListSource))
        }
        #endregion

        #region Archive
       
        private void showArchivBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadFixedAssetsOrderArchive((DateTime)beginDateArchiveEdit.EditValue, (DateTime)endDateArchiveEdit.EditValue);
        }

        public void printArchive(GridControl gridView,DateTime beginDate, DateTime endDate)
        {
            string periodArchiveStr = beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.WYSIWYG;
            string exportFilePath = "ОЗ_Архів_" + periodArchiveStr + ".xls";
            try
            {
                gridView.ExportToXls(exportFilePath);
            }
            catch (Exception)
            {
                MessageBox.Show("Збереження файлу неможливе, документ вже відкритий! \n Закрийте документ і спробуйте ще.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (File.Exists(exportFilePath))
            {
                try
                {
                    //Try to open the file and let windows decide how to open it.
                    System.Diagnostics.Process.Start(exportFilePath);
                }
                catch
                {
                    String msg = "Неможливо відкрити файл." + Environment.NewLine + Environment.NewLine + "Путь: " + exportFilePath;
                    MessageBox.Show(msg, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void printArchiceBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            printArchive(fixedAssetsArchiveGrid,(DateTime)beginDateArchiveEdit.EditValue, (DateTime)endDateArchiveEdit.EditValue);
        }

        private void fixedAssetsArchiveGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            //if sale color cell OperationStatus = green. If transfer color cell OperationStatus = blue.
            GridView gv = sender as GridView;
            if (e.Column.Name == "operationNameCol")
            {
                if (gv.GetRowCellValue(e.RowHandle, "OperationStatus") != null && gv.GetRowCellValue(e.RowHandle, "OperationStatus").Equals(2))//sale
                {
                    e.Appearance.BackColor = Color.LightGreen;
                    e.Appearance.BackColor2 = Color.Green;
                }
                if (gv.GetRowCellValue(e.RowHandle, "OperationStatus") != null && gv.GetRowCellValue(e.RowHandle, "OperationStatus").Equals(1))//transfer
                {
                    e.Appearance.BackColor = Color.LightBlue;
                    e.Appearance.BackColor2 = Color.SteelBlue;
                }
                if (gv.GetRowCellValue(e.RowHandle, "OperationStatus") != null && gv.GetRowCellValue(e.RowHandle, "OperationStatus").Equals(4))//expenditure
                {
                    e.Appearance.BackColor = Color.Yellow;
                    e.Appearance.BackColor2 = Color.Orange;
                }
            }
        }
        
        private void deleteFromArchiveBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            int countOrder;
            List<FixedAssetsOrderJournalDTO> fixOrderList = new List<FixedAssetsOrderJournalDTO>();
            List<FixedAssetsOrderDTO> newListDel = new List<FixedAssetsOrderDTO>();
            List<FixedAssetsOrderJournalDTO> delfixOrderList = new List<FixedAssetsOrderJournalDTO>();
            List<FixedAssetsOrderDTO> delfixOrderList2 = new List<FixedAssetsOrderDTO>();
            List<FixedAssetsMaterialsDTO> allMaterailsList = new List<FixedAssetsMaterialsDTO>();
           
            fixOrderList=fixedAssetsOrderBS.DataSource as List<FixedAssetsOrderJournalDTO>;           
            newListDel = fixedAssetsOrderService.GetFixedAssestsOrder().ToList();
            allMaterailsList = fixedAssetsOrderService.GetAllFixedAssetsMaterials().ToList();
            if (fixedAssetsOrderBS.Count > 0)
            {
                int card = (int)((FixedAssetsOrderArchiveJournalDTO)ItemJournalArchive).FixedCardStatus;
                int orderId =((FixedAssetsOrderArchiveJournalDTO)ItemJournalArchive).Id;
                switch(card)
                {
                    case 1:
                        for (int i = 0; i < fixOrderList.Count; i++)
                        {
                                                     
                          if (fixOrderList[i].Id_Parent == orderId && fixOrderList[i].Id != orderId && fixOrderList[i].EndRecordDate == null)
                                delfixOrderList.Add(fixOrderList[i]);                          
                        }
                        countOrder = fixOrderList.Where(a => a.Id_Parent == orderId && a.Id != orderId && a.EndRecordDate == null).Count();
                        if (countOrder == 1)
                        {
                            for (int i = 0; i < newListDel.Count; i++)
                            {
                                if (newListDel[i].Id == orderId)
                                {
                                    delfixOrderList2.Add(newListDel[i]);
                                    if (delfixOrderList2[0].Id == newListDel[i].Id)
                                    {
                                        FixedAssetsOrderDTO newModel = new FixedAssetsOrderDTO()
                                        {
                                            EndRecordDate = null,
                                            FixedCardStatus = null,
                                            Balance_Account_Id = newListDel[i].Balance_Account_Id,
                                            BalanceAccountNum = newListDel[i].BalanceAccountNum,
                                            BeginDate = newListDel[i].BeginDate,
                                            BeginPrice = newListDel[i].BeginPrice,
                                            BeginRecordDate = newListDel[i].BeginRecordDate,
                                            CurrentAmortization = newListDel[i].CurrentAmortization,
                                            CurrentPrice = newListDel[i].CurrentPrice,
                                            FixedAccountId = newListDel[i].FixedAccountId,
                                            FixedAccountNum = newListDel[i].FixedAccountNum,
                                            Group_Id = newListDel[i].Group_Id,
                                            GroupName = newListDel[i].GroupName,
                                            Id = newListDel[i].Id,
                                            Id_Parent = newListDel[i].Id_Parent,
                                            IncreasePrice = newListDel[i].IncreasePrice,
                                            InventoryName = newListDel[i].InventoryName,
                                            InventoryNumber = newListDel[i].InventoryNumber,
                                            OperatingPerson_Id = newListDel[i].OperatingPerson_Id,
                                            OperatingPersonName = newListDel[i].OperatingPersonName,
                                            PeriodAmortization = newListDel[i].PeriodAmortization,
                                            PeriodYearAmortization = newListDel[i].PeriodYearAmortization,
                                            Region_Id = newListDel[i].Region_Id,
                                            RegionName = newListDel[i].RegionName,
                                            Supplier_Id = newListDel[i].Supplier_Id,
                                            SupplierName = newListDel[i].SupplierName,
                                            TotalPrice = newListDel[i].TotalPrice,
                                            UsefulMonth = newListDel[i].UsefulMonth
                                        };
                                        fixedAssetsOrderService.FixedAssetsOrderUpdate(newModel);
                                    }
                                    fixedAssetsOrderService.FixedAssetsOrderDelete(delfixOrderList[0].Id);//new line transfer
                                    LoadFixedAssetsOrderArchive((DateTime)beginDateArchiveEdit.EditValue, (DateTime)endDateArchiveEdit.EditValue);
                                }
                            }
                        }
                        else
                            MessageBox.Show(String.Format("Картку № '{0}' неможливо відновити. " +
                                                              "Для початку треба видалити всі дії, які виконувалися з нею.", ((FixedAssetsOrderJournalDTO)ItemJournal).InventoryNumber),
                                                              "Відновлення картки",
                                                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case 2:
                    case 4:
                        allMaterailsList.Where(a => a.FixedAssetsOrder_Id == orderId).ToList().ForEach(r => r.SoldPrice = null);
                        FixedAssetsMaterialsDTO newModelMaterials = new FixedAssetsMaterialsDTO()
                        {
                            ContractorName = allMaterailsList[0].ContractorName,
                            DebitAccountId = allMaterailsList[0].DebitAccountId,
                            Description = allMaterailsList[0].Description,
                            ExpDate = allMaterailsList[0].ExpDate,
                            Expenditures_Id = allMaterailsList[0].Expenditures_Id,
                            ExpenNum = allMaterailsList[0].ExpenNum,
                            Fixed_Account_Id = allMaterailsList[0].Fixed_Account_Id,
                            FixedAssetsOrder_Id = allMaterailsList[0].FixedAssetsOrder_Id,
                            FixedNum = allMaterailsList[0].FixedNum,
                            FixedPrice = allMaterailsList[0].FixedPrice,
                            Flag = allMaterailsList[0].Flag,
                            FlagNote = allMaterailsList[0].FlagNote,
                            Id = allMaterailsList[0].Id,
                            MaterialsDate = allMaterailsList[0].MaterialsDate,
                            Name = allMaterailsList[0].Name,
                            Nomenclature = allMaterailsList[0].Nomenclature,
                            NomenclatureId = allMaterailsList[0].NomenclatureId,
                            OrderDate = allMaterailsList[0].OrderDate,
                            OrderNum = allMaterailsList[0].OrderNum,
                            Price = allMaterailsList[0].Price,
                            Quantity = allMaterailsList[0].Quantity,
                            ReceiptId = allMaterailsList[0].ReceiptId,
                            ReceiptNum = allMaterailsList[0].ReceiptNum,
                            SoldPrice = null,
                            Srn = allMaterailsList[0].Srn,
                            TotalPrice = allMaterailsList[0].TotalPrice,
                            UnitPrice = allMaterailsList[0].UnitPrice,
                            VendorId = allMaterailsList[0].VendorId
                        };
                        fixedAssetsOrderService.FixedAssetsOrderMaterialsUpdate(newModelMaterials);


                        for (int i = 0; i < newListDel.Count; i++)
                        {
                            if (newListDel[i].Id == orderId)// && fixOrderList[i].EndRecordDate != null) old line 
                            {
                                delfixOrderList2.Add(newListDel[i]);
                                if (delfixOrderList2[0].Id == newListDel[i].Id)
                                {
                                    FixedAssetsOrderDTO newModelFixedOrderForSale = new FixedAssetsOrderDTO()
                                                    {
                                                        EndRecordDate = null,
                                                        FixedCardStatus = null,
                                                        Balance_Account_Id = delfixOrderList2[0].Balance_Account_Id,
                                                        BalanceAccountNum = delfixOrderList2[0].BalanceAccountNum,
                                                        BeginDate = delfixOrderList2[0].BeginDate,
                                                        BeginPrice = delfixOrderList2[0].BeginPrice,
                                                        BeginRecordDate = delfixOrderList2[0].BeginRecordDate,
                                                        CurrentAmortization = delfixOrderList2[0].CurrentAmortization,
                                                        CurrentPrice = delfixOrderList2[0].CurrentPrice,
                                                        FixedAccountId = delfixOrderList2[0].FixedAccountId,
                                                        FixedAccountNum = delfixOrderList2[0].FixedAccountNum,
                                                        Group_Id = delfixOrderList2[0].Group_Id,
                                                        GroupName = delfixOrderList2[0].GroupName,
                                                        Id = delfixOrderList2[0].Id,
                                                        Id_Parent = delfixOrderList2[0].Id_Parent,
                                                        IncreasePrice = delfixOrderList2[0].IncreasePrice,
                                                        InventoryName = delfixOrderList2[0].InventoryName,
                                                        InventoryNumber = delfixOrderList2[0].InventoryNumber,
                                                        OperatingPerson_Id = delfixOrderList2[0].OperatingPerson_Id,
                                                        OperatingPersonName = delfixOrderList2[0].OperatingPersonName,
                                                        PeriodAmortization = delfixOrderList2[0].PeriodAmortization,
                                                        PeriodYearAmortization = delfixOrderList2[0].PeriodYearAmortization,
                                                        Region_Id = delfixOrderList2[0].Region_Id,
                                                        RegionName = delfixOrderList2[0].RegionName,
                                                        Supplier_Id = delfixOrderList2[0].Supplier_Id,
                                                        SupplierName = delfixOrderList2[0].SupplierName,
                                                        TotalPrice = delfixOrderList2[0].TotalPrice,
                                                        UsefulMonth = delfixOrderList2[0].UsefulMonth
                                                    };
                                    fixedAssetsOrderService.FixedAssetsOrderUpdate(newModelFixedOrderForSale);
                                }


                            }
                        }
                        break;
                    //case 3:

                    //                         .Where(r => r.Field<int>("Id_Parent") == order_id)
                    //                    .Where(r => r.Field<int>("Id") != order_id)
                    //                    .Where(r => r.Field<string>("EndRecordDate") == null)
                    //                    .Count();
                    //    if (countOrderRow == 1)
                    //    {
                    //        (DataModule.AccountingDS.Tables["FixedAssetsOrder"]).Rows.OfType<DataRow>()
                    //            .Where(r => r.Field<int>("Id_Parent") == order_id)
                    //            .Where(r => r.Field<int>("Id") != order_id)
                    //            .Where(r => r.Field<string>("EndRecordDate") == null)
                    //            .ToList()
                    //            .ForEach(r => r.Delete());

                    //        _rowsForDelete.Rows[i]["EndRecordDate"] = DBNull.Value;
                    //        _rowsForDelete.Rows[i]["FixedCardStatus"] = DBNull.Value;

                    //        localFixedAssetsMaterials.Rows.OfType<DataRow>()
                    //            .Where(r => r.Field<int>("FixedAssetsOrder_Id") == order_id)
                    //            .ToList()
                    //            .ForEach(r => r["SoldPrice"] = DBNull.Value);
                        //}
                        //else
                        //{
                        //    MessageBox.Show(String.Format("Картку № '{0}' неможливо відновити. " +
                        //                                  "Для початку треба видалити всі дії, які виконувалися з нею.", (string)_rowsForDelete.Rows[i]["InventoryNumber"]),
                        //                                  "Відновлення картки",
                        //                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}

                        //break;
                }
                LoadFixedAssetsOrderArchive((DateTime)beginDateArchiveEdit.EditValue, (DateTime)endDateArchiveEdit.EditValue);
            }
        }
        #endregion

        private void journalOrderBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FixedAssetsOrderJournalFm((FixedAssetsOrderJournalDTO) fixedAssetsOrderBS.Current).Show();
         
        }

      
       
        #endregion

        private void regJournalOrderBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fixedAssetsOrderMaterialsBS.Count!=0)
            {
                try
                {
                    RegistrationJournalOrder((FixedAssetsOrderJournalDTO)fixedAssetsOrderBS.Current, (FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current, (List<FixedAssetsMaterialsDTO>)fixedAssetsOrderMaterialsBS.DataSource);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else MessageBox.Show("Виберіть картку основного засобу", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
     
        private void RegistrationJournalOrder(FixedAssetsOrderJournalDTO model,FixedAssetsOrderArchiveJournalDTO modelArchive, List<FixedAssetsMaterialsDTO> fixedAssetsOrderMaterialsBS)
        {
                 new FixedAssetsOrderAddJournalFm(model, modelArchive,rezTagTabPage,fixedAssetsOrderMaterialsBS,firstDay,lastDay).Show();
        }

        private void expFixeAssetsBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            FixedAssetsOrderDTO model = new FixedAssetsOrderDTO()
            {
                Id = ((FixedAssetsOrderJournalDTO)ItemJournal).Id,
                Id_Parent = ((FixedAssetsOrderJournalDTO)ItemJournal).Id_Parent,
                Balance_Account_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).Balance_Account_Id,
                BeginDate = ((FixedAssetsOrderJournalDTO)ItemJournal).BeginDate,
                CurrentAmortization = ((FixedAssetsOrderJournalDTO)ItemJournal).CurrentAmortization,
                CurrentPrice = ((FixedAssetsOrderJournalDTO)ItemJournal).CurrentPrice,
                FixedAccountId = ((FixedAssetsOrderJournalDTO)ItemJournal).FixedAccountId,
                FixedAccountNum = ((FixedAssetsOrderJournalDTO)ItemJournal).FixedAccountNum,
                Group_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).GroupId,
                GroupName = ((FixedAssetsOrderJournalDTO)ItemJournal).GroupName,
                UsefulMonth = ((FixedAssetsOrderJournalDTO)ItemJournal).UsefulMonth,
                IncreasePrice = ((FixedAssetsOrderJournalDTO)ItemJournal).IncreasePrice,
                InventoryName = ((FixedAssetsOrderJournalDTO)ItemJournal).InventoryName,
                InventoryNumber = ((FixedAssetsOrderJournalDTO)ItemJournal).InventoryNumber,
                OperatingPerson_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).OperatingPerson_Id,
                OperatingPersonName = ((FixedAssetsOrderJournalDTO)ItemJournal).OperatingPersonName,
                PeriodAmortization = ((FixedAssetsOrderJournalDTO)ItemJournal).PeriodAmortization,
                PeriodYearAmortization = ((FixedAssetsOrderJournalDTO)ItemJournal).PeriodYearAmortization,
                Region_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).Region_Id,
                RegionName = ((FixedAssetsOrderJournalDTO)ItemJournal).RegionName,
                Supplier_Id = ((FixedAssetsOrderJournalDTO)ItemJournal).SupplierId,
                SupplierName = ((FixedAssetsOrderJournalDTO)ItemJournal).SupplierName,
                TotalPrice = ((FixedAssetsOrderJournalDTO)ItemJournal).TotalPrice,
                BeginRecordDate = ((FixedAssetsOrderJournalDTO)ItemJournal).BeginRecordDate,
                EndRecordDate = ((FixedAssetsOrderJournalDTO)ItemJournal).EndRecordDate,
                FixedCardStatus = ((FixedAssetsOrderJournalDTO)ItemJournal).FixedCardStatus,
                BeginPrice = ((FixedAssetsOrderJournalDTO)ItemJournal).BeginPrice,
                BalanceAccountNum = ((FixedAssetsOrderJournalDTO)ItemJournal).BalanceAccountNum
            };
            ExpenditureFixedAssetsOrder((FixedAssetsOrderDTO)model, (List<FixedAssetsMaterialsDTO>)fixedAssetsOrderMaterialsBS.DataSource);
        }

        private void printActExpenditureBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            accountsService = Program.kernel.Get<IAccountsService>();
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();

            if (fixedAssetsOrderArchiveBS.Count > 0)
            {
                // получаем счет списания материалов 
                string expenditureAccount = "";
                int? expenditureAccountId = fixedAssetsOrderService.GetFixedAssetsMaterialsByFixedAssetsId(((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).Id).First().Fixed_Account_Id;
                if (expenditureAccountId != null)
                    expenditureAccount = accountsService.GetAllAccounts().FirstOrDefault(srch => srch.Id == expenditureAccountId).Num;
                ((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).ExpenditureAccount = expenditureAccount;

                FixedAssetsOrderRegistrationDTO currentFixedAssetsOrderReg = fixedAssetsOrderService.GetByFixedAssetsOrderId(((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).Id, 4);
                if (currentFixedAssetsOrderReg == null)
                {
                    if (MessageBox.Show("Не сформовано наказ, створити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            FixedAssetsOrderJournalDTO newModel = ConvertArchiveJournalToJournal();
                            currentFixedAssetsOrderReg = RegistrationArchive(newModel, (FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current, (List<FixedAssetsMaterialsDTO>)fixedAssetsOrderMaterialsBS.DataSource);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("error" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        PrintFixedAssetsOrderExpenditureAct(currentFixedAssetsOrderReg);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                    PrintFixedAssetsOrderExpenditureAct(currentFixedAssetsOrderReg);
            }
            else MessageBox.Show("Оберіть основний засіб! ", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        public void PrintFixedAssetsOrderExpenditureAct(FixedAssetsOrderRegistrationDTO fixedAssetsOrderRegistration)
        {
            reportService = Program.kernel.Get<IReportService>();
            short group = (short)(((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).GroupId);
            switch (group)
            {
                case 10:
                case 2:
                    reportService.PrintFixedAssetsOrderExpenditureAct((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current, fixedAssetsOrderRegistration);
                    break;
                default:
                    reportService.PrintFixedAssetsOrderExpenditureAct((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current, fixedAssetsOrderRegistration);
                    break;
            }
        }

        //private void RegistrationArchive(FixedAssetsOrderJournalDTO model, FixedAssetsOrderArchiveJournalDTO modelArchive, List<FixedAssetsMaterialsDTO> fixedAssetsOrderMaterialsBS)
        //{
        //    new FixedAssetsOrderAddJournalFm(model, modelArchive, rezTagTabPage, fixedAssetsOrderMaterialsBS,beginDateArchive,endDateArchive).Show();
        //}

        private FixedAssetsOrderRegistrationDTO RegistrationArchive(FixedAssetsOrderJournalDTO model, FixedAssetsOrderArchiveJournalDTO modelArchive, List<FixedAssetsMaterialsDTO> fixedAssetsOrderMaterialsBS)
        {
            using (FixedAssetsOrderAddJournalFm fixedAssetsOrderAddJournalFm = new FixedAssetsOrderAddJournalFm(model, modelArchive, rezTagTabPage, fixedAssetsOrderMaterialsBS, beginDateArchive, endDateArchive))
            {
                if (fixedAssetsOrderAddJournalFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    return fixedAssetsOrderAddJournalFm.Return();
                else
                    return null;
            }
        }

        private void fixedAssetsAmortGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (fixedAssetsOrderNoAmortBS.Count > 0 && fixedAssetsOrderNoAmortBS != null)
                LoadAmortizationDate(((FixedAssetsOrderJournalDTO)fixedAssetsOrderNoAmortBS.Current).Id);
            else
                fixedAssetsOrderAmortizationDateBS.DataSource = null;
        }

        private void printInventoryCardNewBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            // if (check == 0)
            reportService.PrintFixedAssetsOderNew((FixedAssetsOrderJournalDTO)fixedAssetsOrderBS.Current, (List<FixedAssetsMaterialsDTO>)fixedAssetsOrderMaterialsBS.DataSource, lastDay, firstDay);
        }

        public FixedAssetsOrderJournalDTO ConvertArchiveJournalToJournal()
        {
            FixedAssetsOrderJournalDTO newModel = new FixedAssetsOrderJournalDTO()
            {
                Balance_Account_Id = ((FixedAssetsOrderArchiveJournalDTO)ItemJournalArchive).Balance_Account_Id,
                BalanceAccountNum = ((FixedAssetsOrderArchiveJournalDTO)ItemJournalArchive).BalanceAccountNum,
                FixedCardStatus = ((FixedAssetsOrderArchiveJournalDTO)ItemJournalArchive).FixedCardStatus,
                GroupId = ((FixedAssetsOrderArchiveJournalDTO)ItemJournalArchive).GroupId,
                GroupName = ((FixedAssetsOrderArchiveJournalDTO)ItemJournalArchive).GroupName,
                InventoryName = ((FixedAssetsOrderArchiveJournalDTO)ItemJournalArchive).InventoryName,
                InventoryNumber = ((FixedAssetsOrderArchiveJournalDTO)ItemJournalArchive).InventoryNumber,
                Id = ((FixedAssetsOrderArchiveJournalDTO)ItemJournalArchive).Id,
                BeginRecordDate = ((FixedAssetsOrderArchiveJournalDTO)ItemJournalArchive).BeginRecordDate,
                BeginDate = ((FixedAssetsOrderArchiveJournalDTO)ItemJournalArchive).BeginDate,
                EndRecordDate = ((FixedAssetsOrderArchiveJournalDTO)ItemJournalArchive).EndRecordDate,
                SupplierName = ((FixedAssetsOrderArchiveJournalDTO)ItemJournalArchive).SupplierName
            };

            return newModel;
        }

        private void regArchiveBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fixedAssetsOrderArchiveBS.Count != 0 && ((FixedAssetsOrderArchiveJournalDTO)ItemJournalArchive).OperationStatus!=1)
            {
                if(fixedAssetsOrderService.GetByFixedAssetsOrderId(((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).Id, 4)!=null)
                {
                    MessageBox.Show("Основний засіб вже списано наказом на списання!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (fixedAssetsOrderService.GetByFixedAssetsOrderId(((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).Id, 3) != null)
                {
                    MessageBox.Show("Основний засіб вже списано наказом на продаж!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    FixedAssetsOrderJournalDTO newModel = ConvertArchiveJournalToJournal();
                    RegistrationArchive(newModel, (FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current, (List<FixedAssetsMaterialsDTO>)fixedAssetsOrderMaterialsBS.DataSource);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Помилка! Необхідно обрати картку з полем продаж або списання!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fixedAssessOrderTab_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            int tabIndex = fixedAssessOrderTab.SelectedTabPageIndex;
            if (tabIndex==0)
                rezTagTabPage = fixedAssestsTabPage.Tag.ToString();
            if (tabIndex==1)
                rezTagTabPage = arhivTabPage.Tag.ToString();

        }
    }   
}