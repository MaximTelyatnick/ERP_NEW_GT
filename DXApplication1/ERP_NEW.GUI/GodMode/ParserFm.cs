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
using Ninject;
using ERP_NEW.BLL.DTO.ModelsDTO;
using Spire.Xls;
using SpreadsheetGear;
using ERP_NEW.GUI.GodMode.Parser;

namespace ERP_NEW.GUI.GodMode
{
    public partial class ParserFm : DevExpress.XtraEditors.XtraForm
    {
        private IAccountsService accountsService;
        private ICustomerOrdersService customerOrdersService;
        private IStoreHouseService storeHouseService;
        private IReceiptCertificateService receiptCertificateService;

        private List<ExpedinturesAccountantDTO> expenditureAccountantList = new List<ExpedinturesAccountantDTO>();
        private List<CustomerOrdersDTO> customerOrdersList = new List<CustomerOrdersDTO>();

        public ParserFm()
        {
            InitializeComponent();
        }

        private void parserBtn_Click(object sender, EventArgs e)
        {





        }
           


            //cells[1] + (currentPosition) + ":" + vsS[HeaderColumn["EndCredit"] - 1] + (currentPosition)].Interior.Color = Color.LemonChiffon;




            //int i = 1;
            //int columnCount = ;
            //foreach (CellRange range in sheet.Columns[1])
            //{
            //    DictionaryUKTVDTO currentCode;


            //   currentCode =  oldUKTVList.FirstOrDefault(search => search.CodeUKTV == range.Text);


            //   if (currentCode!= null)
            //   { currentCode.CodeUKTV =  sheet.Cells[1].ToString();

            //    //DictionaryUKTVDTO
            //   }


            //    //if (range.Text == "teacher")
            //    //{
            //    //    CellRange sourceRange = sheet.Range[range.Row, 1, range.Row, columnCount];
            //    //    CellRange destRange = newSheet.Range[i, 1, i, columnCount];
            //    //    sheet.Copy(sourceRange, destRange, true);
            //    //    i++;
            //    //}
            //}


            List<KvedDTO> parseData = new List<KvedDTO>();

        public class KvedDTO
        {
            public string OldNumber { get; set; }
            public string NewNumber { get; set; }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            accountsService = Program.kernel.Get<IAccountsService>();

            //Workbook workbook = new Workbook();
            //Worksheet sheet = workbook.Worksheets[0];
            SpreadsheetGear.IWorkbook workbook = Factory.GetWorkbook("parser.xlsx");
            var worksheet = workbook.Worksheets[1];
            var cells = worksheet.Cells;
            //cells[1,1].Value = 10;
            List<DictionaryUKTVDTO> createList = new List<DictionaryUKTVDTO>();
            List<DictionaryUKTVDTO> updateUKTVList = new List<DictionaryUKTVDTO>();
            List<DictionaryUKTVDTO> oldUKTVList = accountsService.GetDictionaryUKTV().ToList();

            for (int i = 0; i < 1418; ++i)
            {
                int level = 0;

                for (int j = i+1; j < 1418; ++j)
                {
                    if (cells[i, 0].Value.ToString() == cells[j, 0].Value.ToString())
                        ++level;
                    else
                        break;

                }

                if (level == 0)
                {
                    DictionaryUKTVDTO currentCode;
                    

                    currentCode = oldUKTVList.FirstOrDefault(search => search.CodeUKTV == cells[i, 0].Value.ToString());

                    if (currentCode != null)
                    {
                        currentCode.CodeUKTV = cells[i, 1].Value.ToString();

                        //accountsService.DictionaryUKTVUpdate(currentCode);


                        updateUKTVList.Add(currentCode);
                    }
                }
                else
                {
                    DictionaryUKTVDTO currentCode;
                    currentCode = oldUKTVList.FirstOrDefault(search => search.CodeUKTV == cells[i, 0].Value.ToString());

                    if (currentCode != null)
                    {
                        currentCode.CodeUKTV = cells[i, 1].Value.ToString();

                        accountsService.DictionaryUKTVUpdate(currentCode);


                        updateUKTVList.Add(currentCode);

                        int k = level;
                        for (int m = 1; m < k + 1; ++m )
                        {
                            currentCode.CodeUKTV = cells[i + m, 1].Value.ToString();
                            currentCode.Id = 0;
                            createList.Add(currentCode);

                        }

                    }

                    i = i + level;
                }


            }

            updateUKTVList.Clear();
           

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void parseExpenditureBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            customerOrdersList = customerOrdersService.GetCustomerOrdersFull().ToList();

            for (int i = 0; i < customerOrdersList.Count(); ++i)
                customerOrdersList[i].OrderNumberParse = customerOrdersList[i].OrderNumber.Replace(".", "");

            List<ExpedinturesAccountantDTO> expenditureAccountantList = storeHouseService.GetExpendituresAccountant().Where(srch => srch.CustomerOrderId == null).ToList();

            for (int i = 0; i < expenditureAccountantList.Count(); ++i)
            {
                if (expenditureAccountantList[i].PROJECT_NUM == "0")
                {
                    expenditureAccountantList[i].CustomerOrderNumber = "0";
                    continue;
                }
                if (customerOrdersList.Where(srch => srch.OrderNumberParse == expenditureAccountantList[i].PROJECT_NUM).Count() == 1)
                {
                    expenditureAccountantList[i].CustomerOrderNumber = customerOrdersList.FirstOrDefault(srch => srch.OrderNumberParse == expenditureAccountantList[i].PROJECT_NUM).OrderNumber;
                    expenditureAccountantList[i].CustomerOrderId = customerOrdersList.FirstOrDefault(srch => srch.OrderNumberParse == expenditureAccountantList[i].PROJECT_NUM).Id;
                }
            }
            foreach (var item in expenditureAccountantList)
            {
                storeHouseService.ExpendituresAccountantUpdate(item);
            }

            MessageBox.Show("Закази оновлено!");
        }

        private void expAccToExpStoreBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            List<ExpedinturesAccountantDTO> accExpenditureList = storeHouseService.GetExpendituresAccountant().ToList();

            foreach (var item in accExpenditureList)
            {
                ExpenditureStoreHouseDTO createModel = new ExpenditureStoreHouseDTO()
                {
                     Id = item.ID,
                      ReceiptId = item.RECEIPT_ID,
                       Quantity = item.QUANTITY,
                        ExpDate = item.EXP_DATE,
                         RealExpDate = item.EXP_DATE,
                          CustomerOrderId = item.CustomerOrderId,
                           EmployeeId = 851,
                            ExpenditureId = item.ID,
                             Check = false       
                };

                storeHouseService.ExpenditureStoreHouseCreate(createModel);

                createModel.Id = item.ID;
            }

            MessageBox.Show("Закази оновлено!");
           
        }

        private void fixedCertificateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            receiptCertificateService = Program.kernel.Get<IReceiptCertificateService>();
           

            List<ReceiptCertificatesDTO> receipeCertificatesList = receiptCertificateService.GetCertificates().ToList();

            foreach (var item in receipeCertificatesList)
            {
                ReceiptCertificateDetailDTO createModel = new ReceiptCertificateDetailDTO()
                {
                    ReceiptCertificateId = item.ReceiptCertificateId,
                     ReceiptId = item.ReceiptId
                };
                try
                {
                    createModel.ReceiptCertificateDetailId = receiptCertificateService.CreateCertificateDetail(createModel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

            MessageBox.Show("Сертифікати перенесено");
        }

        private void fixedCertificateUserBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            receiptCertificateService = Program.kernel.Get<IReceiptCertificateService>();

            List<ReceiptCertificatesDTO> receipeCertificatesList = receiptCertificateService.GetCertificates().ToList();

            foreach (var item in receipeCertificatesList)
            {
                int l = storeHouseService.GetUserIdByReceiptCertId((int)item.ReceiptCertificateId);
                if (l == 94)
                {
                    item.UserId = 50;
                    receiptCertificateService.UpdateCertificate(item);
                }
                else
                {
                    item.UserId = 242;
                    receiptCertificateService.UpdateCertificate(item);
                }

            }

            MessageBox.Show("Сертифікати перенесено");
        }
    }
}