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
using System.Runtime.InteropServices;
using System.IO;
using Ninject;
using ERP_NEW.BLL.DTO.ModelsDTO;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;  
using System.Xml;


namespace ERP_NEW.GUI.Classifiers
{
    public partial class ConverterFm : DevExpress.XtraEditors.XtraForm
    {
        public ConverterFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            dxValidationProvider.Validate();
        }

        private void converterBtnBrow_Click(object sender, EventArgs e)
        {
            DialogResult drResult = converterOFD.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
                converterTxtPath.Text = converterOFD.FileName;
        }

        private string[] vsS =
            {
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",

                "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK",
                "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV",
                "AW", "AX", "AY", "AZ",

                "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM",
                "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ",

                "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM",
                "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CV", "CW", "CX", "CY", "CZ"
            };

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        } 

        private void converterBtnConver_Click(object sender, EventArgs e)
        {
            converterPrgsBar.Value = 0;
            if (converterChekName.Checked && converterTxtName.Text != "" && converterTxtPath.Text != "")
            {
                if (File.Exists(converterTxtPath.Text))
                {
                    string CustXmlFilePath = Path.Combine(new FileInfo(converterTxtPath.Text).DirectoryName, converterTxtName.Text); // Ceating Path for Xml Files  
                    System.Data.DataTable dt = CreateDataTableFromXml(converterTxtPath.Text);
                    ExportDataTableToExcel(dt, CustXmlFilePath, converterTxtName.Text);
                }
                else
                    MessageBox.Show("Не корректно вказано ім'я файлу");
            }
            else if (!converterChekName.Checked || converterTxtPath.Text != "") // Using Default Xml File Name  
            {
                if (File.Exists(converterTxtPath.Text))
                {
                    FileInfo fi = new FileInfo(converterTxtPath.Text);
                    string XlFile = fi.DirectoryName + fi.Name.Replace(fi.Extension, ".xlsx");
                    System.Data.DataTable dt = CreateDataTableFromXml(converterTxtPath.Text);
                    ExportDataTableToExcel(dt, XlFile, fi.Name.Replace(fi.Extension, ".xlsx"));
                }
                else
                    MessageBox.Show("Не корректно вказано ім'я файлу");
            }          
            else
            {
                MessageBox.Show("");
            }
            this.Close();
        }

        

private void ExportDataTableToExcel(System.Data.DataTable table, string Xlfile, string XlfileName)  
{  
  
    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();  
    Workbook book = excel.Application.Workbooks.Add(Type.Missing);
    string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
  //  string filepath = path + "\\myfile.txt";
    excel.Visible = false;  
    excel.DisplayAlerts = false;
   
    Worksheet excelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;  
    excelWorkSheet.Name = table.TableName;
    converterPrgsBar.Maximum = table.Columns.Count;  
    for (int i = 1; i < table.Columns.Count + 1; i++) // Creating Header Column In Excel  
    {
        excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
        excelWorkSheet.Columns[i].AutoFit();
        //if (converterPrgsBar.Value < converterPrgsBar.Maximum)  
        //{
        //    converterPrgsBar.Value++;
        //    int percent = (int)(((double)converterPrgsBar.Value / (double)converterPrgsBar.Maximum) * 100);
        //    converterPrgsBar.CreateGraphics().DrawString(percent.ToString() + "%", new System.Drawing.Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(converterPrgsBar.Width / 2 - 10, converterPrgsBar.Height / 2 - 7));  
        //    System.Windows.Forms.Application.DoEvents();  
        //}  
    }
    Range range = excelWorkSheet.get_Range(vsS[0] + 1, vsS[(table.Columns.Count-1)] + (table.Rows.Count+1));
    range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
    range.Borders.Weight = Excel.XlBorderWeight.xlMedium;
    try
    {
        for (int j = 0; j < table.Rows.Count; j++) // Exporting Rows in Excel  
        {
            for (int k = 0; k < table.Columns.Count; k++)
            {
                excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
            }
            //if (converterPrgsBar.Value < converterPrgsBar.Maximum)
            //{
            //    converterPrgsBar.Value++;
            //    int percent = (int)(((double)converterPrgsBar.Value / (double)converterPrgsBar.Maximum) * 100);
            //    converterPrgsBar.CreateGraphics().DrawString(percent.ToString() + "%", new System.Drawing.Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(converterPrgsBar.Width / 2 - 10, converterPrgsBar.Height / 2 - 7));
            //    System.Windows.Forms.Application.DoEvents();
            //}
        }
        excel.Visible = true;
        excel.DisplayAlerts = true;  
    }
    catch (Exception)
    {
        throw;
    }
  //  book.Close(true);  
 //   excel.Quit();    
    book.SaveAs(path+@"\"+XlfileName);
    //Marshal.ReleaseComObject(book);  
    Marshal.ReleaseComObject(book);  
    Marshal.ReleaseComObject(excel);    
}  

        #region Event's
        
        #endregion

        #region Metod's

        public System.Data.DataTable CreateDataTableFromXml(string XmlFile)  
        {  
  
            System.Data.DataTable Dt = new System.Data.DataTable();   
            try  
            {  
                DataSet ds = new DataSet();  
                ds.ReadXml(@XmlFile);  
                int indexTableMaxRow = 0;
                if (ds.Tables.Count > 1)
                {
                    for (int i = 1; i < ds.Tables.Count; i++)
                        if (ds.Tables[indexTableMaxRow].Rows.Count < ds.Tables[i].Rows.Count)
                            indexTableMaxRow = i;
                }
                Dt = ds.Tables[indexTableMaxRow];
             }  
            catch (Exception)  
            {  

            }  
            return Dt;  
        }       
        #endregion

        #region Validation's

        private bool ControlValidation()
        {
            return dxValidationProvider.Validate();
        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.converterBtnConver.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.converterBtnConver.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void nameEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        #endregion


        public object xlContinuous { get; set; }

        public XlBorderWeight xlMedium { get; set; }

        private void converterTxtName_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }
    }
}