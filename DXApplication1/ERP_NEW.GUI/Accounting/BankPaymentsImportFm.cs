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
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.Interfaces;
using Ninject;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Services;
using DevExpress.XtraEditors.Repository;

namespace ERP_NEW.GUI.Accounting
{
    public partial class BankPaymentsImportFm : DevExpress.XtraEditors.XtraForm
    {
        private OpenFileDialog openDialog = new OpenFileDialog();

        private IAccountsService accountsService;
        private ICurrencyService currencyService;
        private IBankImportService bankImportService;
        private IBankPaymentsService bankPaymentsService;
        private IContractorsService contractorsService;
        private IPeriodService periodService;
        private ICustomerOrdersService customerOrdersService;

        private BindingSource bankPaymentBS = new BindingSource();
        private List<BankPaymentsInfoDTO> bankPaymentList = new List<BankPaymentsInfoDTO>();

        public BankPaymentsImportFm()
        {
            InitializeComponent();

            accountsService = Program.kernel.Get<IAccountsService>();
            currencyService = Program.kernel.Get<ICurrencyService>();
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();

            vatAccountsEditRepository.DataSource = accountsService.GetAccounts().Where(s => s.VatMark == 1).ToList();
            vatAccountsEditRepository.ValueMember = "Id";
            vatAccountsEditRepository.DisplayMember = "Num";

            accountsRepository.DataSource = accountsService.GetBankPaymentImportAccounts();
            accountsRepository.ValueMember = "Id";
            accountsRepository.DisplayMember = "Num";

            bankAccountsEdit.DataSource = accountsService.GetBankPaymentImportAccounts();
            bankAccountsEdit.ValueMember = "Id";
            bankAccountsEdit.DisplayMember = "Num";

            currencyEditRepository.DataSource = currencyService.GetCurrency();
            currencyEditRepository.ValueMember = "Id";
            currencyEditRepository.DisplayMember = "Code";
        }

        #region Method's

        private void LoadBankPaymentData(List<PaymentImportModelDTO> payments, short bankAccountId)
        {
            bankPaymentsService = Program.kernel.Get<IBankPaymentsService>();
            currencyService = Program.kernel.Get<ICurrencyService>();
            contractorsService = Program.kernel.Get<IContractorsService>();
            accountsService = Program.kernel.Get<IAccountsService>();

            List<CurrencyDTO> currencyList = currencyService.GetCurrency().ToList();
            List<ContractorsDTO> contractorsList = contractorsService.GetContractors(1).ToList();
            List<AccountsDTO> accountsList = accountsService.GetAccounts().ToList();
            
            bankAccountsItem.EditValue = bankAccountId;

            switch (bankAccountId)
            {
                case 37:
                    bankNameItem.Caption = "Полтавабанк";
                    break;
                case 45:
                    bankNameItem.Caption = "Финансы и Кредит";
                    break;
                case 39:
                    bankNameItem.Caption = "Сбербанк";
                    break;
                case 49:
                    bankNameItem.Caption = "Приватбанк";
                    break;
                case 109:
                    bankNameItem.Caption = "Банк Кредит Днепр";
                    break;
                case 133://311/7
                    bankNameItem.Caption = "АТ УКРЕКСІМБАНК";
                    break;
                default:
                    bankNameItem.Caption = "";
                    break;
            }

            bankPaymentList.Clear();

            decimal price = 0, priceCurrency = 0;

            for (int i = 0; i < payments.Count; i++)
            {
                price = (payments[i].PaymentCurrencyName == "UAH") ? payments[i].Sum : payments[i].SumEq;
                priceCurrency = (payments[i].PaymentCurrencyName == "UAH") ? 0 : payments[i].Sum;

                BankPaymentsInfoDTO item = new BankPaymentsInfoDTO();

                item.PartnerSrn = payments[i].RecipientSrn;
                item.PartnerName = payments[i].RecipientName;
                item.RecipientAccountNum = payments[i].RecipientBankAccountNum;
                item.Payment_Document = payments[i].DocumentNum.ToString();
                item.RecipientBankMfo = payments[i].RecipientBankCode;
                item.RecipientBankName = payments[i].RecipientBankName;
                item.Payment_Date = payments[i].DocumentApplyDate;
                item.Purpose = payments[i].PaymentPurpose;
                item.Payment_Price = price;
                item.Payment_PriceCurrency = priceCurrency;
                item.Bank_Account_Id = bankAccountId;
                item.CurrencyName = payments[i].PaymentCurrencyName;
                item.CurrencyId = currencyList.FirstOrDefault(c => c.Code.Trim() == payments[i].PaymentCurrencyName.Trim()).Id;
                item.Rate = payments[i].Rate;
                item.ContractorName = payments[i].RecipientSrn;

                var tempContractorModel = contractorsList.FirstOrDefault(c => (c.Srn ?? "").Trim() == payments[i].RecipientSrn.Trim());
                if (tempContractorModel != null)
                    item.Contractor_Id = tempContractorModel.Id;

                if (payments[i].OperationType == 1)
                {
                    item.DebitPrice = price;
                    item.DebitPriceCurrency = priceCurrency;
                    item.AccountingOperationId = 1;
                }
                else
                {
                    item.CreditPrice = price;
                    item.CreditPriceCurrency = priceCurrency;
                    item.AccountingOperationId = 2;
                }

                string purpose = payments[i].PaymentPurpose;

                if (purpose.Contains("товар"))
                    item.PurposeAccountNum = "631";
                if (purpose.Contains("послуг") || purpose.Contains("услуг"))
                    item.PurposeAccountNum = "63";

                var tempAccountModel = accountsList.FirstOrDefault(a => a.Num.Trim() == (item.PurposeAccountNum ?? "").Trim());
                if (tempAccountModel != null)
                    item.Purpose_Account_Id = tempAccountModel.Id;

                bool itemExistStatus = bankPaymentsService.GetExistImportPayment(item.Payment_Date, item.Payment_Document, item.Bank_Account_Id, item.Payment_Price ?? 0.00m);
                
                item.PaymentExists = itemExistStatus;

                bankPaymentList.Add(item);
            }

            importPaymentsGridView.BeginDataUpdate();

            bankPaymentBS.DataSource = bankPaymentList;
            importPaymentsGrid.DataSource = bankPaymentBS;

            importPaymentsGridView.EndDataUpdate();
        }

        private bool CheckPeriodAccess(DateTime currentDate)
        {
            periodService = Program.kernel.Get<IPeriodService>();

            return periodService.GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month && p.StateBank);
        }
        
        private bool SaveItems(List<BankPaymentsInfoDTO> saveSource)
        {
            bankPaymentsService = Program.kernel.Get<IBankPaymentsService>();
            contractorsService = Program.kernel.Get<IContractorsService>();

            foreach (var item in saveSource)
            {
                if (!CheckPeriodAccess(item.Payment_Date ?? DateTime.Now))
                {
                    MessageBox.Show("Період " + item.Payment_Date.Value.Month + "." + item.Payment_Date.Value.Year + "закритий або не існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (item.Contractor_Id == null)
                {
                    List<ContractorsDTO> contractorsList = contractorsService.GetContractors(1).ToList();

                    var tempContractorModel = contractorsList.FirstOrDefault(c => (c.Srn ?? "").Trim() == item.ContractorName.Trim());
                    if (tempContractorModel != null)
                        item.Contractor_Id = tempContractorModel.Id;
                    else
                        item.Contractor_Id = contractorsService.ContractorCreate(new ContractorsDTO() { Srn = item.PartnerSrn, Name = item.PartnerName });
                    
                }
                bankPaymentsService.BankPaymentCreate(new Bank_PaymentsDTO()
                {
                    Id = item.Id,
                    AccountingOperationId = item.AccountingOperationId,
                    Bank_Account_Id = Convert.ToInt32(bankAccountsItem.EditValue),
                    Contractor_Id = item.Contractor_Id,
                    CurrencyId = item.CurrencyId,
                    CurrencyRatesConvertId = item.CurrencyRatesConvertId,
                    Payment_Document = item.Payment_Document,
                    Payment_Date = item.Payment_Date,
                    Direction = item.Direction,
                    EmployeesId = item.EmployeesId,
                    Payment_Price = item.Payment_Price,
                    Payment_PriceCurrency = item.Payment_PriceCurrency,
                    Payment_Price_Eq = item.Payment_Price,
                    Purpose = item.Purpose,
                    Purpose_Account_Id = item.Purpose_Account_Id,
                    Rate = item.Rate,
                    VatAccountId = item.VatAccountId,
                    VatPrice = item.VatPrice,
                    DateCreate = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    UserId = UserService.AuthorizatedUser.UserId
                });

                //Bank_PaymentsDTO newModel = new Bank_PaymentsDTO();

                //newModel.Id = item.Id;
                //newModel.AccountingOperationId = item.AccountingOperationId;
                //newModel.Bank_Account_Id = (int)bankAccountsItem.EditValue;
                //newModel.Contractor_Id = item.Contractor_Id;
                //newModel.CurrencyId = item.CurrencyId;
                //newModel.CurrencyRatesConvertId = item.CurrencyRatesConvertId;
                //newModel.CustomerOrderId = item.CustomerOrderId;
                //newModel.Payment_Document = item.Payment_Document;
                //newModel.Payment_Date = item.Payment_Date;
                //newModel.Direction = item.Direction;
                //newModel.EmployeesId = item.EmployeesId;
                //newModel.Payment_Price = item.Payment_Price;
                //newModel.Payment_PriceCurrency = item.Payment_PriceCurrency;
                //newModel.Payment_Price_Eq = item.Payment_Price;
                //newModel.Purpose = item.Purpose;
                //newModel.Purpose_Account_Id = item.Purpose_Account_Id;
                //newModel.Rate = item.Rate;
                //newModel.VatAccountId = item.VatAccountId;
                //newModel.VatPrice = item.VatPrice;
                //newModel.DateCreate = DateTime.Now;
                //newModel.DateUpdate = DateTime.Now;
                //newModel.UserId = UserService.AuthorizatedUser.UserId;
            }
            
            return true;
        }

        #endregion

        #region Event's

        #region UAH

        private void privatBankItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openDialog.Filter = "Все файлы(*.*)|*.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                splashScreenManager.ShowWaitForm();

                bankImportService = Program.kernel.Get<IBankImportService>();

                try
                {
                    LoadBankPaymentData(bankImportService.GetPrivatBankList(openDialog.FileName), 49);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не можливо прочитати документ!\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                splashScreenManager.CloseWaitForm();
            }
        }

        private void privatBankCardItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openDialog.Filter = "Все файлы(*.*)|*.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                splashScreenManager.ShowWaitForm();

                bankImportService = Program.kernel.Get<IBankImportService>();

                try
                {
                    LoadBankPaymentData(bankImportService.GetPrivatBankCardList(openDialog.FileName), 49);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Не можливо прочитати документ!\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                splashScreenManager.CloseWaitForm();
            }
        }

        private void poltavaBankItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openDialog.Filter = "Текстовые файлы(*.txt)|*.txt";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                splashScreenManager.ShowWaitForm();

                bankImportService = Program.kernel.Get<IBankImportService>();

                try
                {
                    LoadBankPaymentData(bankImportService.GetPoltavaBankList(openDialog.FileName), 37);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не можливо прочитати документ!\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                splashScreenManager.CloseWaitForm();
            }
        }

        private void sberBankItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openDialog.Filter = "Файл XML(*.xml)|*.xml";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                splashScreenManager.ShowWaitForm();

                bankImportService = Program.kernel.Get<IBankImportService>();

                try
                {
                    LoadBankPaymentData(bankImportService.GetSberBankList(openDialog.FileName), 39);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не можливо прочитати документ!\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                splashScreenManager.CloseWaitForm();
            }
        }

        private void bankCreditDneprItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openDialog.Filter = "Все файлы(*.*)|*.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                splashScreenManager.ShowWaitForm();

                bankImportService = Program.kernel.Get<IBankImportService>();

                try
                {
                    LoadBankPaymentData(bankImportService.GetBankCreditDneprList(openDialog.FileName), 109);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не можливо прочитати документ!\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                splashScreenManager.CloseWaitForm();
            }
        }

        #endregion

        #region Currency

        private void privatBankCurrencyItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openDialog.Filter = "Все файлы(*.*)|*.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                splashScreenManager.ShowWaitForm();

                bankImportService = Program.kernel.Get<IBankImportService>();

                try
                {
                    LoadBankPaymentData(bankImportService.GetPrivatBankCurrencyList(openDialog.FileName), 49);
                }
                catch
                {
                    MessageBox.Show("Не можливо прочитати документ!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                splashScreenManager.CloseWaitForm();
            }
        }

        private void poltavaBankCurrencyItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openDialog.Filter = "Текстовые файлы(*.txt)|*.txt";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                splashScreenManager.ShowWaitForm();

                bankImportService = Program.kernel.Get<IBankImportService>();

                try
                {
                    LoadBankPaymentData(bankImportService.GetPoltavaBankCurrencyList(openDialog.FileName), 37);
                }
                catch
                {
                    MessageBox.Show("Не можливо прочитати документ!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                splashScreenManager.CloseWaitForm();
            }
        }

        private void sberBankCurrencyItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openDialog.Filter = "Файл XML(*.xml)|*.xml";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                splashScreenManager.ShowWaitForm();

                bankImportService = Program.kernel.Get<IBankImportService>();

                try
                {
                    LoadBankPaymentData(bankImportService.GetSberBankList(openDialog.FileName), 39);
                }
                catch
                {
                    MessageBox.Show("Не можливо прочитати документ!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                splashScreenManager.CloseWaitForm();
            }
        }

        private void bankCreditDneprCurrencyItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openDialog.Filter = "Все файлы(*.*)|*.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                splashScreenManager.ShowWaitForm();

                bankImportService = Program.kernel.Get<IBankImportService>();

                try
                {
                    LoadBankPaymentData(bankImportService.GetBankCreditDneprList(openDialog.FileName), 109);
                }
                catch
                {
                    MessageBox.Show("Не можливо прочитати документ!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                splashScreenManager.CloseWaitForm();
            }
        }

        #endregion

        private void saveBtn_Click(object sender, EventArgs e)
        {
            importPaymentsGridView.PostEditor();

            List<BankPaymentsInfoDTO> importList = ((List<BankPaymentsInfoDTO>)bankPaymentBS.DataSource).Where(s => !s.PaymentExists).ToList();

            if (importList.Count > 0)
            {
                if (importList.Any(s => s.Purpose_Account_Id == null))
                {
                    MessageBox.Show("Збереження відмінено. Виберіть рахунок призначення для всіх записів.", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (SaveItems(importList))
                        {
                            DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else
            {
                MessageBox.Show("Немає жодного запису для збереження.", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
        private void importPaymentsGridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle > -1)
            {
                var model = (BankPaymentsInfoDTO)importPaymentsGridView.GetRow(e.RowHandle);

                if (model.PaymentExists)
                {
                    e.Appearance.BackColor2 = Color.LightGreen;
                    e.Appearance.BackColor = Color.Azure;
                }
            }
        }

        private void importPaymentsGridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Column.Name == "purposeAccountNumCol")
            {
                var model = (BankPaymentsInfoDTO)importPaymentsGridView.GetRow(e.RowHandle);

                if(!model.PaymentExists && model.Purpose_Account_Id == null)
                {
                    e.Appearance.BackColor2 = Color.LightSalmon;
                    e.Appearance.BackColor = Color.Tomato;
                }
            }
        }

        private void importPaymentsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            BankPaymentsInfoDTO item = (BankPaymentsInfoDTO)bankPaymentBS[e.ListSourceRowIndex];

            if (e.Column == saveStatusCol && e.IsGetData)
            {
                if (item.PaymentExists)
                    e.Value = imageCollection.Images[0];
                else
                    e.Value = imageCollection.Images[1];
            }
        }
                
        #endregion

        private void importPaymentsGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //((InvoicesDTO)accountingInvoicesBS.Current).Color_Name = e.ClickedItem.ToolTipText;
            //((InvoicesDTO)accountingInvoicesBS.Current).Color_Id = (int)e.ClickedItem.Tag;
            //accountingInvoicesBS.EndEdit();
            //accountingInvoicesService.AccountsInvoiceUpdate((InvoicesDTO)accountingInvoicesBS.Current); 
        }

        private void debetMenuItem_Click(object sender, EventArgs e)
        {
            importPaymentsGridView.BeginDataUpdate();

            BankPaymentsInfoDTO model =  (BankPaymentsInfoDTO)bankPaymentBS.Current;

            if (model.CreditPrice != 0 && model.CreditPrice != null)
            {
                ((BankPaymentsInfoDTO)bankPaymentBS.Current).DebitPrice = model.CreditPrice;
                ((BankPaymentsInfoDTO)bankPaymentBS.Current).DebitPriceCurrency = model.CreditPriceCurrency;
                ((BankPaymentsInfoDTO)bankPaymentBS.Current).CreditPrice = 0;
                ((BankPaymentsInfoDTO)bankPaymentBS.Current).CreditPriceCurrency = 0;
                ((BankPaymentsInfoDTO)bankPaymentBS.Current).AccountingOperationId = 1;
                ((BankPaymentsInfoDTO)bankPaymentBS.Current).Direction = 1;
            }
            else
            {
                MessageBox.Show("Платіж не є кредитовим.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            importPaymentsGridView.EndDataUpdate();

        }

        private void creditMenuItem_Click(object sender, EventArgs e)
        {
            importPaymentsGridView.BeginDataUpdate();

            BankPaymentsInfoDTO model = (BankPaymentsInfoDTO)bankPaymentBS.Current;

            if (model.DebitPrice != 0 && model.DebitPrice != null)
            {
                ((BankPaymentsInfoDTO)bankPaymentBS.Current).CreditPrice = model.DebitPrice;
                ((BankPaymentsInfoDTO)bankPaymentBS.Current).CreditPriceCurrency = model.DebitPriceCurrency;
                ((BankPaymentsInfoDTO)bankPaymentBS.Current).DebitPrice = 0;
                ((BankPaymentsInfoDTO)bankPaymentBS.Current).DebitPriceCurrency = 0;
                ((BankPaymentsInfoDTO)bankPaymentBS.Current).AccountingOperationId = 2;
                ((BankPaymentsInfoDTO)bankPaymentBS.Current).Direction = -1;
            }
            else
            {
                MessageBox.Show("Платіж не є дебетовим.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            importPaymentsGridView.EndDataUpdate();
        }

        private void ukrEximItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openDialog.Filter = "Файл XML(*.xml)|*.xml";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                splashScreenManager.ShowWaitForm();

                bankImportService = Program.kernel.Get<IBankImportService>();

                try
                {
                    LoadBankPaymentData(bankImportService.GetUkrEximBankList(openDialog.FileName), 133);
                }
                catch (Exception ex)
                {
                    splashScreenManager.CloseWaitForm();
                    MessageBox.Show("Не можливо прочитати документ!\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                splashScreenManager.CloseWaitForm();
            }
        }

        private void ukrEximBankCurrentItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openDialog.Filter = "Файл XML(*.xml)|*.xml";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                splashScreenManager.ShowWaitForm();

                bankImportService = Program.kernel.Get<IBankImportService>();

                try
                {
                    List<PaymentImportModelDTO> test=bankImportService.GetUkrEximBankList(openDialog.FileName);
                    short rezBankAccount=0;
                    string accounName = test[0].RecipientBankAccountNum.ToString();
                    accounName = accounName.Substring(3, accounName.Length-12);
                    if (accounName != "")
                    {
                        if (test[0].PaymentCurrencyName == "USD")
                        {
                            if (accounName == "0")
                                rezBankAccount = 51;
                            else
                                rezBankAccount = 75;
                        }
                        if (test[0].PaymentCurrencyName == "EUR")
                        {
                            if (accounName == "0")
                                rezBankAccount = 54;
                            else
                                rezBankAccount = 100;
                        }

                        if (test[0].PaymentCurrencyName == "RUB")
                        {
                            if (accounName == "0")
                                rezBankAccount = 53;
                            else
                                rezBankAccount = 194;
                        }
                    }
                    else rezBankAccount = 0;

                    LoadBankPaymentData(test, rezBankAccount);//133
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не можливо прочитати документ!\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                splashScreenManager.CloseWaitForm();
            }
        }

        private void replaceContractorBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bankPaymentList.Where(s=>s.Check).Count()>0)
            {
                using (BankPaymentsImportContractorEditFm bankPaymentsImportContractorEditFm = new BankPaymentsImportContractorEditFm())
                {
                    if (bankPaymentsImportContractorEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        importPaymentsGridView.PostEditor();

                        importPaymentsGridView.BeginDataUpdate();

                        ContractorsDTO contractor = bankPaymentsImportContractorEditFm.Return();
                        var updatePaymentList = bankPaymentList.Where(s => s.Check);
                        foreach (var item in updatePaymentList)
                        {
                            item.Contractor_Id = contractor.Id;
                            item.PartnerName = contractor.Name;
                            item.PartnerSrn = contractor.Srn;
                            
                            
                        }


                        bankPaymentBS.DataSource = bankPaymentList;
                        importPaymentsGrid.DataSource = bankPaymentBS;


                        //LoadDataByPeriod(_beginDate, _endDate);
                        importPaymentsGridView.EndDataUpdate();
                    }
                }
            }
        }
    }
}