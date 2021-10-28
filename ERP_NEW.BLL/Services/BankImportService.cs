using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.Xml.Linq;
using SpreadsheetGear;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace ERP_NEW.BLL.Services
{
    public class BankImportService : IBankImportService
    {
        public List<PaymentImportModelDTO> GetPrivatBankList(string filePath)
        {
            List<PaymentImportModelDTO> resultList = new List<PaymentImportModelDTO>();

            var encoding = Encoding.GetEncoding(1251);
            //using (var src = new StreamReader(filePath, encoding: encoding)

            var reader = new StreamReader(filePath, encoding: encoding);

            //StreamReader reader = File.OpenText(filePath, encoding: encoding);

            //HtmlDocument doc = new HtmlDocument();
            //doc.Load(filePath, Encoding.UTF8);
            bool header = false;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] items = line.Split(';');
                if (header)
                {
                    decimal d;
                    byte operationType = 0;

                    if (items[11].Substring(0, 1) != "-")
                    {
                        operationType = 1;
                    }

                    string modoficateBancAccount = items[8];

                    if (modoficateBancAccount.Any(c => char.IsLetter(c)))
                        modoficateBancAccount = NumberCrop(modoficateBancAccount);

                    resultList.Add(new PaymentImportModelDTO
                    {
                        DocumentNum = items[4], // номер документа
                        Sum = Math.Abs(decimal.TryParse(items[11].Replace('.', ','), out d) ? d : 0), // сумма
                        PaymentCurrencyName = items[3], // тип валюты
                        RecipientSrn = items[0], // МФО банка
                        RecipientBankAccountNum = ulong.Parse(modoficateBancAccount),
                        RecipientBankCode = uint.Parse(items[6]),
                        RecipientName = items[10].Replace("&quot", "\""),
                        PaymentPurpose = items[12],
                        DocumentApplyDate = Convert.ToDateTime(items[5]),
                        OperationType = operationType
                    });
                }
                

                header = true;
            }




            //var trNodes = doc.DocumentNode.SelectNodes("//tr");

            //if (trNodes.Count() != 0)
            //{
            //    foreach (var item in trNodes)
            //    {
            //        var tdNodes = item.ChildNodes.Where(x => x.Name == "td").ToArray();

            //        if (tdNodes.Count() != 0)
            //        {
            //            decimal d;
            //            byte operationType = 0;

            //            if (tdNodes[3].InnerText.Substring(0, 1) != "-")
            //            {
            //                operationType = 1;
            //            }

            //            resultList.Add(new PaymentImportModelDTO
            //            {
            //                DocumentNum = tdNodes[0].InnerText,
            //                Sum = Math.Abs(decimal.TryParse(tdNodes[3].InnerText.Replace('.', ','), out d) ? d : 0),
            //                PaymentCurrencyName = tdNodes[4].InnerText,
            //                RecipientSrn = tdNodes[5].InnerText,
            //                RecipientBankAccountNum = ulong.Parse(tdNodes[7].InnerText),
            //                RecipientBankCode = uint.Parse(tdNodes[8].InnerText),
            //                RecipientName = tdNodes[6].InnerText,
            //                PaymentPurpose = tdNodes[9].InnerText,
            //                DocumentApplyDate = Convert.ToDateTime(tdNodes[1].InnerText),
            //                OperationType = operationType
            //            });
            //        }
            //    }
            //}

            return resultList;
        }

        //public 

        public string NumberCrop(string modoficateBancAccount)
        {

            int[] trend = new int[modoficateBancAccount.Count()];

            for (int i = modoficateBancAccount.Count(); i > 0; i--)
            {
                int maxZeroCounter = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (modoficateBancAccount[j] == '0')
                        maxZeroCounter++;
                    else
                        break;
                }

                trend[i - 1] = maxZeroCounter;

            }
            modoficateBancAccount = modoficateBancAccount.Remove(0, trend.ToList().IndexOf(trend.Max()) + 1);

            return modoficateBancAccount;
        }


        public List<PaymentImportModelDTO> GetPrivatBankCurrencyList(string filePath)
        {
            List<PaymentImportModelDTO> resultList = new List<PaymentImportModelDTO>();

            var encoding = Encoding.GetEncoding(1251);

            var reader = new StreamReader(filePath, encoding: encoding);

            bool header = false;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] items = line.Split(';');
                if (header)
                {
                    decimal d;
                    byte operationType = 0;

                    if (items[11].Substring(0, 1) != "-")
                    {
                        operationType = 1;
                    }

                    string modoficateBancAccount = items[8];


                    if (modoficateBancAccount.Any(c => char.IsLetter(c)))
                        modoficateBancAccount = NumberCrop(modoficateBancAccount);

                    resultList.Add(new PaymentImportModelDTO
                    {
                        DocumentNum = items[4], // номер документа
                        Sum = Math.Abs(decimal.TryParse(items[11].Replace('.', ','), out d) ? d : 0), // сумма
                        PaymentCurrencyName = items[3], // тип валюты
                        RecipientSrn = items[0], // МФО банка
                        RecipientBankAccountNum = ulong.Parse(modoficateBancAccount),
                        RecipientBankCode = uint.Parse(items[6]),
                        RecipientName = items[10].Replace("&quot", "\""),
                        PaymentPurpose = items[12],
                        DocumentApplyDate = Convert.ToDateTime(items[5]),
                        OperationType = operationType
                    });
                }
                header = true;
            }


            return resultList;
            
        }

        public List<PaymentImportModelDTO> GetPrivatBankCardList(string filePath)
        {
            List<PaymentImportModelDTO> resultList = new List<PaymentImportModelDTO>();

            //try
            //{
            //    if (filePath.Contains("xlsx"))
            //    {
            //        //Spire.Xls.Workbook workbookSpire = new Spire.Xls.Workbook();
            //        //workbookSpire.LoadFromFile(filePath);

            //        //filePath.Replace("xlsx", "xls");

            //        //workbookSpire.SaveToFile(filePath, Spire.Xls.ExcelVersion.Version97to2003);
            //        //Factory.GetWorkbook(filePath);

            //        ////////////////////////////////////////////////////////////////////////////

            //        //var xlsxFile = new ExcelFile();

            //        //// Load data from XLSX file.
            //        //xlsxFile.LoadXlsx(fileName + ".xls", XlsxOptions.PreserveMakeCopy);

            //        //// Save XLSX file to XLS file.
            //        //xlsxFile.SaveXls(fileName + ".xls");

            //        //////////////////////////////////////////////////////////////////////////


            //        var app = new Microsoft.Office.Interop.Excel.Application();
            //        var wb = app.Workbooks.Open(filePath);

            //        filePath.Replace("xlsx", "xls");

            //        wb.SaveAs(Filename: filePath, FileFormat: Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook);
            //        wb.Close();
            //        app.Quit();

            //        Factory.GetWorkbook(filePath);
            //        //SpreadsheetGear.IWorkbook workbookk = SpreadsheetGear.Factory.GetWorkbook(filePath);
            //        //SpreadsheetGear.IWorksheet worksheett = workbookk.Worksheets["Sheet1"];
            //        //SpreadsheetGear.IRange cellss = worksheett.Cells;

                   

            //    }
            //    else
            //    {
            //        Factory.GetWorkbook(filePath);
            //    }

            //    //Factory.GetWorkbook(filePath);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Не вірний формат документа! Необхідний формат: xls, xlsx \n" + ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return resultList;
            //}


            ////var Workbook = Factory.GetWorkbook(filePath);
            ////var Worksheet = Workbook.Worksheets[0];
            ////var Сells = Worksheet.Cells;



            ////SpreadsheetGear.IWorkbook workbook = Factory.GetWorkbook(filePath);

            ////var worksheet = workbook.Worksheets[0];
            ////var cells = worksheet.Cells;

            ////int currentRow = 4; // 0, 1, 2 - header

            ////while (cells["A" + currentRow].Value != null)
            ////{
            ////    decimal d;
            ////    DateTime docDate;

            ////    bool result = DateTime.TryParse(cells["A" + currentRow].Value.ToString(), out docDate);

            ////    NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;

            ////    string value = cells["E" + currentRow].Value.ToString().Replace('.', ',');
            ////    string formatString = Regex.Replace(value, @"[^0-9$,]", "");

            ////    if (result)
            ////    {
            ////        resultList.Add(new PaymentImportModelDTO
            ////        {
            ////            DocumentNum = "б/н",
            ////            Sum = Math.Abs(decimal.TryParse(formatString, out d) ? d : 0),
            ////            PaymentCurrencyName = "UAH",
            ////            RecipientSrn = "32686844",
            ////            RecipientName = "ТОВ \"НВФ \"ТЕХВАГОНМАШ\"",
            ////            PaymentPurpose = cells["B" + currentRow].Value.ToString().Trim(),
            ////            DocumentApplyDate = docDate,
            ////            OperationType = (byte)((cells["E" + currentRow].Value.ToString().Trim().Substring(0, 1) != "-") ? 1 : 0)
            ////        });
            ////    }


            ////    ++currentRow;
            ////}


            var Workbook = Factory.GetWorkbook(filePath);
            var Worksheet = Workbook.Worksheets[0];
            var Сells = Worksheet.Cells;



            SpreadsheetGear.IWorkbook workbook = Factory.GetWorkbook(filePath);

            var worksheet = workbook.Worksheets[0];
            var cells = worksheet.Cells;

            int currentRow = 4; // 1,2,3 - header

            while (cells["A" + currentRow].Value != null)
            {
                decimal d;
                DateTime docDate;

                bool result = DateTime.TryParse(cells["A" + currentRow].Value.ToString(), out docDate);

                NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;

                string value = cells["E" + currentRow].Value.ToString().Replace('.', ',');
                string formatString = Regex.Replace(value, @"[^0-9$,]", "");

                if (result)
                {
                    resultList.Add(new PaymentImportModelDTO
                    {
                        DocumentNum = "б/н",
                        Sum = Math.Abs(decimal.TryParse(formatString, out d) ? d : 0),
                        PaymentCurrencyName = "UAH",
                        RecipientSrn = "32686844",
                        RecipientName = "ТОВ \"НВФ \"ТЕХВАГОНМАШ\"",
                        PaymentPurpose = cells["B" + currentRow].Value.ToString().Trim(),
                        DocumentApplyDate = docDate,
                        OperationType = (byte)((cells["E" + currentRow].Value.ToString().Trim().Substring(0, 1) != "-") ? 1 : 0)
                    });
                }


                ++currentRow;
            }




            ////HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            ////doc.Load(filePath, Encoding.UTF8);

            ////var trNodes = doc.DocumentNode.SelectNodes("//tr");

            ////if (trNodes.Count() != 0)
            ////{
            ////    foreach (var item in trNodes)
            ////    {
            ////        var tdNodes = item.ChildNodes.Where(x => x.Name == "td").ToArray();

            ////        if (tdNodes.Count() != 0)
            ////        {
            ////            decimal d;
            ////            DateTime docDate;

            ////            bool result = DateTime.TryParse(tdNodes[1].InnerText, out docDate);

            ////            if (result)
            ////            {
            ////                resultList.Add(new PaymentImportModelDTO
            ////                {
            ////                    DocumentNum = "б/н",
            ////                    Sum = Math.Abs(decimal.TryParse(tdNodes[4].InnerText.Replace('.', ','), out d) ? d : 0),
            ////                    PaymentCurrencyName = "UAH",
            ////                    RecipientSrn = "32686844",
            ////                    RecipientName = "ТОВ \"НВФ \"ТЕХВАГОНМАШ\"",
            ////                    PaymentPurpose = tdNodes[2].InnerText.Trim(),
            ////                    DocumentApplyDate = docDate,
            ////                    OperationType = (byte)((tdNodes[4].InnerText.Trim().Substring(0, 1) != "-") ? 1 : 0)
            ////                });
            ////            }
            ////        }
            ////    }
            ////}

            return resultList;
        }

        public List<PaymentImportModelDTO> GetBankCreditDneprList(string filePath)
        {
            List<PaymentImportModelDTO> resultList = new List<PaymentImportModelDTO>();

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(filePath, Encoding.UTF8);

            var trNodes = doc.DocumentNode.SelectNodes("//tr");

            DateTime parseDate;

            if (trNodes.Count() != 0)
            {
                foreach (var item in trNodes)
                {
                    var tdNodes = item.ChildNodes.Where(x => x.Name == "td").ToArray();

                    if ((tdNodes.Count() != 0) && DateTime.TryParse(tdNodes[0].InnerText, out parseDate))
                    {
                        string modoficateBancAccount = tdNodes[7].InnerText;

                        if (modoficateBancAccount.Any(c => char.IsLetter(c)))
                            modoficateBancAccount = NumberCrop(modoficateBancAccount);


                        resultList.Add(new PaymentImportModelDTO
                        {
                            DocumentNum = tdNodes[2].InnerText,
                            Sum = (tdNodes[5].InnerText == "UAH") ?
                                            ((Convert.ToDecimal(tdNodes[10].InnerText.Replace('.', ',')) > 0) ? Convert.ToDecimal(tdNodes[10].InnerText.Replace('.', ',')) : Convert.ToDecimal(tdNodes[11].InnerText.Replace('.', ',')))
                                            : ((Convert.ToDecimal(tdNodes[8].InnerText.Replace('.', ',')) > 0) ? -1 : 1),
                            SumEq = (tdNodes[5].InnerText == "UAH") ?
                                            0
                                            : ((Convert.ToDecimal(tdNodes[10].InnerText.Replace('.', ',')) > 0) ? Convert.ToDecimal(tdNodes[10].InnerText.Replace('.', ',')) : Convert.ToDecimal(tdNodes[11].InnerText.Replace('.', ','))),
                            PaymentCurrencyName = tdNodes[5].InnerText,
                            RecipientSrn = tdNodes[14].InnerText,
                            RecipientBankAccountNum = ulong.Parse(modoficateBancAccount),
                            RecipientBankCode = uint.Parse(tdNodes[15].InnerText),
                            RecipientName = tdNodes[13].InnerText,
                            PaymentPurpose = tdNodes[12].InnerText,
                            DocumentApplyDate = parseDate,
                            OperationType = (byte)((tdNodes[5].InnerText == "UAH") ?
                                            ((Convert.ToDecimal(tdNodes[10].InnerText.Replace('.', ',')) > 0) ? -1 : 1)
                                            : ((Convert.ToDecimal(tdNodes[8].InnerText.Replace('.', ',')) > 0) ? -1 : 1))
                        });
                    }
                }
            }

            return resultList;
        }
               
        public List<PaymentImportModelDTO> GetPoltavaBankList(string filePath)
        {
            string[] CurrenciesStrName = { "USD", "EUR", "RUB", "UAH" };
            
            List<string> allData = new List<string>();
            List<PaymentImportModelDTO> payments = new List<PaymentImportModelDTO>();
            string lastFoundPaymentCurrencyName = "";

            using (StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding("windows-1251")))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                        allData.Add(line);
                }
            }

            for (int i = 0; i < allData.Count; i++)
            {
                var paymentRow = new PaymentImportModelDTO();
                var currentRow = allData[i];

                #region currencyName
                if (currentRow.IndexOf("Вал.:") != -1)
                {
                    //PaymentCurrencyName
                    for (int elem = 0; elem < CurrenciesStrName.Length; elem++)
                    {
                        if (currentRow.IndexOf(CurrenciesStrName[elem]) != -1)
                        {
                            lastFoundPaymentCurrencyName = CurrenciesStrName[elem];
                            break;
                        }
                    }
                }
                paymentRow.PaymentCurrencyName = lastFoundPaymentCurrencyName;

                #endregion currencyName

                if (Char.IsDigit(currentRow[0]))
                {
                    int operationLength = 8;
                    int sumPos = currentRow.IndexOf("Списання");
                    byte operationType = 0;
                    if (sumPos < 0)
                    {
                        sumPos = currentRow.IndexOf("Зарахування");
                        operationLength = 11;
                        operationType = 1;
                    }

                    #region documentNumber

                    string documentNumber = "";

                    for (int y = sumPos - 1; y > 0; y--)
                    {
                        if (currentRow[y] != ' ')
                        {
                            documentNumber += currentRow[y];
                            if (currentRow[y - 1] == ' ')
                                break;
                        }
                    }

                    var array = documentNumber.ToCharArray();
                    Array.Reverse(array);
                    paymentRow.DocumentNum = new String(array);

                    #endregion documentNumber

                    #region sum

                    string sum = "";
                    string returnValue = SearchString(sum, sumPos + operationLength, currentRow);
                    paymentRow.Sum = decimal.Parse(returnValue.Replace(',', ' ').Replace('.', ','));

                    #endregion sum

                    #region payment account, srn, contractor, purpose

                    string purpose = "";

                    i += 2;

                    //string modoficateBancAccount = items[8];

                    //if (modoficateBancAccount.Any(c => char.IsLetter(c)))
                    //{
                    //    int indexOfStr = modoficateBancAccount.IndexOf("2600");
                    //    modoficateBancAccount = modoficateBancAccount.Remove(0, indexOfStr);
                    //}


                    int paymentAccountPos = allData[i].IndexOf("Рах.:");
                    int srnPos = allData[i].IndexOf("Код:");

                    if (paymentAccountPos >= 0 && srnPos >= 0)
                    {
                        string paymentAccount = "";
                        string srn = "";

                        //paymentRow.RecipientBankAccountNum = ulong.Parse(SearchString(paymentAccount, paymentAccountPos + 5, allData[i]));

                        string bankAccount = SearchString(paymentAccount, paymentAccountPos + 5, allData[i]);

                        if (bankAccount.Any(c => char.IsLetter(c)))
                        {
                            bankAccount = NumberCrop(bankAccount);
                        }

                        paymentRow.RecipientBankAccountNum = ulong.Parse(bankAccount);
                        paymentRow.RecipientSrn = SearchString(srn, srnPos + 5, allData[i]);
                        paymentRow.RecipientName = allData[++i].Trim();

                        i++;

                        int k = i;
                        while (!Char.IsDigit(allData[k][0]))
                        {
                            purpose += allData[k];

                            if (k + 1 == allData.Count || allData[k + 1].Contains("---------------- ----------------"))
                                break;
                            else
                                k++;
                        }
                    }

                    #endregion payment account, srn, contractor, purpose

                    #region payment date

                    var row = allData.First(c => c.Contains("Дата проведення"));

                    string paymentDate = "";
                    int paymentDatePos = row.IndexOf("Дата проведення");

                    if (paymentDatePos >= 0)
                    {
                        int pPosition = paymentDatePos + 16;

                        if (row[pPosition] != ' ')
                            paymentDate += row.Substring(pPosition, 10);
                    }

                    #endregion payment date

                    paymentRow.OperationType = operationType;
                    paymentRow.PaymentPurpose = purpose.Trim();
                    paymentRow.DocumentApplyDate = DateTime.Parse(paymentDate);
                    payments.Add(paymentRow);
                }
            }

            return payments;
        }

        public List<PaymentImportModelDTO> GetPoltavaBankCurrencyList(string filePath)
        {
            string[] CurrenciesStrName = { "USD", "EUR", "RUB", "UAH" };

            List<string> allData = new List<string>();
            List<PaymentImportModelDTO> payments = new List<PaymentImportModelDTO>();
            string lastFoundPaymentCurrencyName = "";
            decimal lastFoundRate = 0.00m;

            using (StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding("windows-1251")))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if(line!= "")
                        allData.Add(line);
                }
            }

            for (int i = 0; i < allData.Count; i++)
            {
                var paymentRow = new PaymentImportModelDTO();
                var currentRow = allData[i];



                #region currencyName
                if (currentRow.IndexOf("Вал.:") != -1)
                {
                    //PaymentCurrencyName
                    for (int elem = 0; elem < CurrenciesStrName.Length; elem++)
                    {
                        if (currentRow.IndexOf(CurrenciesStrName[elem]) != -1)
                        {
                            lastFoundPaymentCurrencyName = CurrenciesStrName[elem];
                            //System.Windows.Forms.MessageBox.Show(CurrenciesStrName[elem]);
                            break;
                        }
                    }
                    //Rate value
                    int rateStrStartPosition = currentRow.IndexOf("Курс:");
                    if (rateStrStartPosition != -1)
                    {
                        rateStrStartPosition += "Курс:".Length;
                        int rateStrLength = currentRow.IndexOf("/", rateStrStartPosition) - rateStrStartPosition;

                        lastFoundRate = decimal.Parse(currentRow.Substring(rateStrStartPosition, rateStrLength).Replace('.', ','));

                    }
                }
                paymentRow.PaymentCurrencyName = lastFoundPaymentCurrencyName;
                paymentRow.Rate = lastFoundRate;


                #endregion currencyName
                if (currentRow != "")
                {
                    if (Char.IsDigit(currentRow[0]))
                    {
                        int operationLength = 8;
                        int sumPos = currentRow.IndexOf("Списання");
                        byte operationType = 0;
                        if (sumPos < 0)
                        {
                            sumPos = currentRow.IndexOf("Зарахування");
                            operationLength = 11;
                            operationType = 1;
                        }

                        #region documentNumber

                        string documentNumber = "";

                        for (int y = sumPos - 1; y > 0; y--)
                        {
                            if (currentRow[y] != ' ')
                            {
                                documentNumber += currentRow[y];
                                if (currentRow[y - 1] == ' ')
                                    break;
                            }
                        }

                        var array = documentNumber.ToCharArray();
                        Array.Reverse(array);
                        paymentRow.DocumentNum = new String(array);

                        #endregion documentNumber

                        #region sum

                        string sum = "";
                        string returnValue = SearchString(sum, sumPos + operationLength, currentRow);
                        paymentRow.Sum = decimal.Parse(returnValue.Replace(',', ' ').Replace('.', ','));

                        #endregion sum

                        #region payment account, srn, contractor, purpose

                        string purpose = "";

                        i += 2;
                        int paymentAccountPos = allData[i].IndexOf("Рах.:");
                        int srnPos = allData[i].IndexOf("Код:");

                        if (paymentAccountPos >= 0 && srnPos >= 0)
                        {
                            string paymentAccount = "";
                            string srn = "";

                            string bankAccount = SearchString(paymentAccount, paymentAccountPos + 5, allData[i]);

                            if (bankAccount.Any(c => char.IsLetter(c)))
                            {
                                bankAccount = NumberCrop(bankAccount);
                            }

                            paymentRow.RecipientBankAccountNum = ulong.Parse(bankAccount);
                            //string bankAccount = SearchString(paymentAccount, paymentAccountPos + 5, allData[i]);

                            //if (bankAccount.Any(c => char.IsLetter(c)))
                            //{
                            //    int indexOfStr = bankAccount.IndexOf("0003");
                            //    indexOfStr += 3;
                            //    bankAccount = bankAccount.Remove(0, indexOfStr);
                            //}


                            //paymentRow.RecipientBankAccountNum = ulong.Parse(bankAccount);
                            paymentRow.RecipientSrn = SearchString(srn, srnPos + 5, allData[i]);
                            paymentRow.RecipientName = allData[++i].Trim();



                            i++;

                            int k = i;
                            while (!Char.IsDigit(allData[k][0]))
                            {
                                purpose += allData[k];

                                if (k + 1 == allData.Count || allData[k + 1].Contains("---------------- ----------------"))
                                    break;
                                else
                                    k++;
                            }
                        }


                       

                        #endregion payment account, srn, contractor, purpose

                        #region payment date

                        var row = allData.First(c => c.Contains("Дата проведення"));

                        string paymentDate = "";
                        int paymentDatePos = row.IndexOf("Дата проведення");

                        if (paymentDatePos >= 0)
                        {
                            int pPosition = paymentDatePos + 16;

                            if (row[pPosition] != ' ')
                                paymentDate += row.Substring(pPosition, 10);
                        }

                        #endregion payment date

                        paymentRow.OperationType = operationType;
                        paymentRow.PaymentPurpose = purpose.Trim();
                        paymentRow.DocumentApplyDate = DateTime.Parse(paymentDate);
                        payments.Add(paymentRow);
                    }
                }
            }

            return payments;
        }

        public List<PaymentImportModelDTO> GetSberBankList(string filePath)
        {
            XDocument xml = XDocument.Load(filePath);
            return xml.Root.Elements().Select
                (
                    c => new PaymentImportModelDTO
                    {
                        DocumentNum = c.Attribute("DOCUMENTNO").Value, //1
                        PayerBankAccountNum = ulong.Parse(c.Attribute("ACCOUNTNO").Value), //2
                        PaymentCurrencyCode = ushort.Parse(c.Attribute("CURRENCYID").Value), //3
                        PayerBankCode = uint.Parse(c.Attribute("BANKID").Value), //4
                        RecipientBankCode = uint.Parse(c.Attribute("CORRBANKID").Value), //5
                        RecipientBankAccountNum = ulong.Parse(c.Attribute("CORRACCOUNTNO").Value), //6
                        OperationType = byte.Parse(c.Attribute("OPERATIONID").Value), //7
                        BankApplyDate = DateTime.ParseExact(c.Attribute("BANKDATE").Value, "yyyyMMdd", CultureInfo.InvariantCulture), //8
                        PaymentCurrencyName = c.Attribute("CURRSYMBOLCODE").Value, //9
                        DocumentTypeName = c.Attribute("DOCSUBTYPESNAME").Value, //10
                        PaymentPurpose = c.Attribute("PLATPURPOSE").Value, //11
                        DocumentApplyDate = DateTime.ParseExact(c.Attribute("DOCUMENTDATE").Value, "yyyyMMdd", CultureInfo.InvariantCulture), //12
                        RecipientBankName = c.Attribute("CORRBANKNAME").Value, //13
                        RecipientSrn = c.Attribute("CORRIDENTIFYCODE").Value, //14
                        RecipientName = c.Attribute("CORRCONTRAGENTSNAME").Value, //15
                        PayerBankName = c.Attribute("BANKNAME").Value, //16
                        PayerSrn = c.Attribute("IDENTIFYCODE").Value, //17
                        PayerFullName = c.Attribute("ACCDESCR").Value, //18
                        PayerName = c.Attribute("CONTRAGENTSNAME").Value, //19
                        PayerInnerCode = int.Parse(c.Attribute("ACCOUNTID").Value), //20
                        PaymentTime = DateTime.ParseExact(c.Attribute("BOOKEDDATE").Value, "yyyyMMddTHH:mm:fffff", CultureInfo.InvariantCulture), //21
                        DocumentTypeId = ushort.Parse(c.Attribute("DOCUMENTTYPEID").Value), //22
                        RecordVersion = uint.Parse(c.Attribute("DATAVERSION").Value), //23
                        SumEq = decimal.Parse(c.Attribute("SUMMAEQ").Value) / 100.00m, //24
                        Sum = decimal.Parse(c.Attribute("SUMMA").Value) / 100.00m //25
                    }
                ).ToList();
        }

        //-----
        public List<PaymentImportModelDTO> GetUkrEximBankList(string filePath)
        {
            XDocument xml = XDocument.Load(filePath);
            return xml.Root.Elements().Select
                (
                    c => new PaymentImportModelDTO
                    {
                        DocumentNum = c.Attribute("DOCUMENTNO").Value, //1
                        PayerBankAccountNum = ulong.Parse(c.Attribute("ACCOUNTNO").Value), //2
                        PaymentCurrencyCode = ushort.Parse(c.Attribute("CURRENCYID").Value), //3
                        PayerBankCode = uint.Parse(c.Attribute("BANKID").Value), //4
                        RecipientBankCode = uint.Parse(c.Attribute("CORRBANKID").Value), //5
                        RecipientBankAccountNum = ulong.Parse(c.Attribute("CORRACCOUNTNO").Value), //6
                        OperationType = byte.Parse(c.Attribute("OPERATIONID").Value), //7
                        BankApplyDate = DateTime.ParseExact(c.Attribute("BANKDATE").Value, "yyyyMMdd", CultureInfo.InvariantCulture), //8
                        PaymentCurrencyName = c.Attribute("CURRSYMBOLCODE").Value, //9
                        DocumentTypeName = c.Attribute("DOCSUBTYPESNAME").Value, //10
                        PaymentPurpose = c.Attribute("PLATPURPOSE").Value, //11
                        DocumentApplyDate = DateTime.ParseExact(c.Attribute("DOCUMENTDATE").Value, "yyyyMMdd", CultureInfo.InvariantCulture), //12
                        RecipientBankName = c.Attribute("CORRBANKNAME").Value, //13
                        RecipientSrn = c.Attribute("CORRIDENTIFYCODE").Value, //14
                        RecipientName = c.Attribute("CORRCONTRAGENTSNAME").Value, //15
                        PayerBankName = c.Attribute("BANKNAME").Value, //16
                        PayerSrn = c.Attribute("IDENTIFYCODE").Value, //17
                        PayerFullName = c.Attribute("ACCDESCR").Value, //18
                        PayerName = c.Attribute("CONTRAGENTSNAME").Value, //19
                        PayerInnerCode = int.Parse(c.Attribute("ACCOUNTID").Value), //20
                        PaymentTime = DateTime.ParseExact(c.Attribute("BOOKEDDATE").Value, "yyyyMMddTHH:mm:fffff", CultureInfo.InvariantCulture), //21
                        DocumentTypeId = int.Parse(c.Attribute("DOCUMENTTYPEID").Value), //22
                        RecordVersion = uint.Parse(c.Attribute("DATAVERSION").Value), //23
                        SumEq = decimal.Parse(c.Attribute("SUMMAEQ").Value) / 100.00m, //24
                        Sum = decimal.Parse(c.Attribute("SUMMA").Value) / 100.00m //25
                    }
                ).ToList();
        }


        
        //-----

        private string SearchString(string returnValue, int pos, string currentRow)
        {
            for (int y = pos; y < currentRow.Length; y++)
            {
                if (currentRow[y] != ' ')
                {
                    returnValue += currentRow[y];

                    if (y + 1 != currentRow.Length && currentRow[y + 1] == ' ')
                        break;
                }
            }

            return returnValue;
        }
    }
}
