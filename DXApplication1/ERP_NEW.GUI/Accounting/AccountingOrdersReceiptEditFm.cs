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
using ERP_NEW.GUI.Classifiers;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.Interfaces;
using Ninject;

namespace ERP_NEW.GUI.Accounting
{
    public partial class AccountingOrdersReceiptEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IAccountsService accountsService;
        private ICurrencyService currencyService;

        private UserTasksDTO userTaskDTO;

        private ReceiptsDTO receiptsDTO = new ReceiptsDTO();

        private BindingSource receiptsBS = new BindingSource();
        private BindingSource currencyBS = new BindingSource();
        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return receiptsBS.Current as ObjectBase; }
            set
            {
                receiptsBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public AccountingOrdersReceiptEditFm(Utils.Operation operation, ReceiptsDTO receiptsDTO, UserTasksDTO userTaskDTO, bool isCurrency = false, bool isCorrection = false)
        {
            InitializeComponent();

            this.userTaskDTO = userTaskDTO;
            this.receiptsDTO = receiptsDTO;
            this.operation = operation;

            receiptsBS.DataSource = Item = receiptsDTO;

            if (operation == Utils.Operation.Add)
            {
                //((ReceiptsDTO)receiptsBS.Current).TOTAL_CURRENCY = 0.00m;
                ((ReceiptsDTO)receiptsBS.Current).Storehouse_Id = 1;
                ((ReceiptsDTO)receiptsBS.Current).POS = null;

            }


            if (!isCurrency)
            {
                totalCurrencyEdit.Visible = false;
                totalCurrencyLbl.Visible = false;
                unitCurrencyEdit.Visible = false;
                unitCurrencyLbl.Visible = false;
                currencyEdit.Visible = false;
                currencyLbl.Visible = false;
                currencyRateEdit.Visible = false;
                rateLbl.Visible = false;
                totalPriceEdit.ReadOnly = false;
                //unitPriceEdit.ReadOnly = false;
            }
            else
            {
                totalPriceEdit.ReadOnly = true;
                //unitPriceEdit.ReadOnly = true;
            }

            if (!isCorrection)
            {
                totalPriceEdit.Properties.Mask.EditMask = "###,###,###,###0.00;";
                //unitPriceEdit.Properties.Mask.EditMask = "###,###,###,###0.00;";
                totalCurrencyEdit.Properties.Mask.EditMask = "###,###,###,###0.00;";
                //unitCurrencyEdit.Properties.Mask.EditMask = "###,###,###,###0.00;";
            }
            else
            {
                totalPriceEdit.Properties.Mask.EditMask = "###,###,###,###0.00";
                //unitPriceEdit.Properties.Mask.EditMask = "###,###,###,###0.00";
                totalCurrencyEdit.Properties.Mask.EditMask = "###,###,###,###0.00";
                //unitCurrencyEdit.Properties.Mask.EditMask = "###,###,###,###0.00";
            }

            currencyService = Program.kernel.Get<ICurrencyService>();

            measureEdit.DataBindings.Add("EditValue", receiptsBS, "UnitLocalName", true, DataSourceUpdateMode.OnPropertyChanged);
            nomenclatureEdit.DataBindings.Add("EditValue", receiptsBS, "Nomenclature", true, DataSourceUpdateMode.OnPropertyChanged);
            nomenclatureNameEdit.DataBindings.Add("EditValue", receiptsBS, "NomenclatureName", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityEdit.DataBindings.Add("EditValue", receiptsBS, "QUANTITY", true, DataSourceUpdateMode.OnPropertyChanged);
            totalPriceEdit.DataBindings.Add("EditValue", receiptsBS, "TOTAL_PRICE", true, DataSourceUpdateMode.OnPropertyChanged);
            unitPriceEdit.DataBindings.Add("EditValue", receiptsBS, "UNIT_PRICE", true, DataSourceUpdateMode.OnPropertyChanged);
            totalCurrencyEdit.DataBindings.Add("EditValue", receiptsBS, "TOTAL_CURRENCY", true, DataSourceUpdateMode.OnPropertyChanged);
            unitCurrencyEdit.DataBindings.Add("EditValue", receiptsBS, "UNIT_CURRENCY", true, DataSourceUpdateMode.OnPropertyChanged);
            balanceNumEdit.DataBindings.Add("EditValue", receiptsBS, "BalanceAccountNum", true, DataSourceUpdateMode.OnPropertyChanged);
            currencyRateEdit.DataBindings.Add("EditValue", receiptsBS, "CURRENCY_RATE", true, DataSourceUpdateMode.OnPropertyChanged);

            currencyEdit.DataBindings.Add("EditValue", receiptsBS, "CURRENCY_ID", true, DataSourceUpdateMode.OnPropertyChanged);
            currencyEdit.Properties.DataSource = currencyService.GetCurrency();
            currencyEdit.Properties.ValueMember = "Id";
            currencyEdit.Properties.DisplayMember = "Code";
            currencyEdit.Properties.NullText = "Немає данних";

            ControlValidation();
        }

        private void measureEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (NomenclaturesFm nomenclaturesFm = new NomenclaturesFm(userTaskDTO, true))
            {
                if (nomenclaturesFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    NomenclaturesDTO returnItem = nomenclaturesFm.Return();

                    Item.BeginEdit();

                    ((ReceiptsDTO)Item).NomenclatureName = returnItem.Name;
                    ((ReceiptsDTO)Item).Nomenclature = returnItem.Nomenclature;
                    ((ReceiptsDTO)Item).UnitLocalName = returnItem.UnitLocalName;
                    ((ReceiptsDTO)Item).UnitId = returnItem.UnitId;
                    ((ReceiptsDTO)Item).BalanceAccountId = returnItem.BALANCE_ACCOUNT_ID;
                    ((ReceiptsDTO)Item).BalanceAccountNum = returnItem.Num;
                    ((ReceiptsDTO)Item).NomenclatureGroupId = returnItem.Nomencl_Group_Id;
                    ((ReceiptsDTO)Item).NOMENCLATURE_ID = returnItem.ID;

                    Item.EndEdit();

                    receiptsBS.ResetBindings(true);

                    quantityEdit.Focus();

                    DialogResult = DialogResult.None;
                }
                else
                {
                    DialogResult = DialogResult.None;
                }
            }
        }


        public ReceiptsDTO Return() 
        {
            return ((ReceiptsDTO)Item);
        }

        private void nomenclatureEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.OnlyNumbers(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (receiptsBS.Count > 0)
                    CheckNomenclature(nomenclatureEdit.Text.Trim()); 
            }
        }


        private void CheckNomenclature(string Nomenclature)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            accountsService = Program.kernel.Get<IAccountsService>();

            List<NomenclaturesDTO> nomenclatureSearch = storeHouseService.GetNomenclatureWithAccountNumber(Nomenclature).ToList();

            if (nomenclatureSearch.Count != 0)
            {
                Item.BeginEdit();

                ((ReceiptsDTO)Item).NomenclatureName = nomenclatureSearch[0].Name;
                ((ReceiptsDTO)Item).UnitLocalName = nomenclatureSearch[0].UnitLocalName;
                ((ReceiptsDTO)Item).UnitId = nomenclatureSearch[0].UnitId;
                ((ReceiptsDTO)Item).BalanceAccountId = nomenclatureSearch[0].BALANCE_ACCOUNT_ID;
                ((ReceiptsDTO)Item).BalanceAccountNum = nomenclatureSearch[0].Num;
                ((ReceiptsDTO)Item).NomenclatureGroupId = nomenclatureSearch[0].Nomencl_Group_Id;
                ((ReceiptsDTO)Item).NOMENCLATURE_ID = nomenclatureSearch[0].ID;

                Item.EndEdit();

                quantityEdit.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Номенклатура выдсутня в базі даних!\n Створити?", "Не знайдено номенклатуру", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    NomenclaturesDTO addNomenclature = new NomenclaturesDTO()
                    {
                        Nomenclature = Nomenclature
                    };

                    var balanceAccount = accountsService.GetAccounts();

                    foreach (var item in balanceAccount)
                    {

                        string tempValue = item.Num.ToString().Replace("/", "");

                        if (Nomenclature.Length >= tempValue.Length && Nomenclature.IndexOf(tempValue, 0, tempValue.Length) != -1)
                        {
                            addNomenclature.BALANCE_ACCOUNT_ID = item.Id;
                            addNomenclature.Num = item.Num;

                            break;
                        }
                    }

                    if (addNomenclature.BALANCE_ACCOUNT_ID == null)
                    {
                        MessageBox.Show("Балансовий рахунок відсутній в базі даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        nomenclatureNameEdit.EditValue = "";
                        nomenclatureEdit.EditValue = "";

                        return;
                    }

                    using (NomenclaturesMaterialsEditFm nomenclaturesMaterialsEditFm = new NomenclaturesMaterialsEditFm(Utils.Operation.Add, addNomenclature))
                    {
                        if (nomenclaturesMaterialsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            NomenclaturesDTO returnItem = nomenclaturesMaterialsEditFm.Return();

                            ((ReceiptsDTO)Item).NomenclatureName = returnItem.Name;
                            ((ReceiptsDTO)Item).Nomenclature = returnItem.Nomenclature;
                            ((ReceiptsDTO)Item).UnitLocalName = returnItem.UnitLocalName;
                            ((ReceiptsDTO)Item).UnitId = returnItem.UnitId;
                            ((ReceiptsDTO)Item).BalanceAccountId = returnItem.BALANCE_ACCOUNT_ID;
                            ((ReceiptsDTO)Item).BalanceAccountNum = returnItem.Num;
                            ((ReceiptsDTO)Item).NomenclatureGroupId = returnItem.Nomencl_Group_Id;
                            ((ReceiptsDTO)Item).NOMENCLATURE_ID = returnItem.ID;

                            receiptsBS.ResetBindings(false);

                        }
                    }
                }
                else
                {
                    this.Close();
                }
            }

            DialogResult = DialogResult.None;

        }

        private void totalPriceEdit_TextChanged(object sender, EventArgs e)
        {
            if (totalPriceEdit.Text.Length == 1 && totalPriceEdit.Text == "-")
                return;
            UnitPrice();

            receiptsBS.ResetBindings(false);
        }

        private void UnitPrice()
        {

            double Quantity = quantityEdit.Text.Length == 0 ? 0.000 : Convert.ToDouble(quantityEdit.Text);
            double TotalPrice = totalPriceEdit.Text.Length == 0 ? 0.00 : Convert.ToDouble(totalPriceEdit.Text);
            if (Quantity > 0)
            {
                double UnitPrice = TotalPrice / Quantity;
                ((ReceiptsDTO)receiptsBS.Current).UNIT_PRICE = Convert.ToDecimal(Math.Round(UnitPrice, 2).ToString("N", Utils.NumFormat(2)));
            }
            else
            {
                unitPriceEdit.EditValue = Convert.ToDecimal(0.00);
            }
        }


        private void UnitCurrency()
        {
            double Quantity = quantityEdit.Text.Length == 0 ? 0.000 : Convert.ToDouble(quantityEdit.Text);
            double TotalPrice = totalCurrencyEdit.Text.Length == 0 ? 0.00 : Convert.ToDouble(totalCurrencyEdit.Text);
            if (Quantity > 0 && TotalPrice > 0)
            {
                double UnitPrice = TotalPrice / Quantity;
                ((ReceiptsDTO)receiptsBS.Current).UNIT_CURRENCY = Convert.ToDecimal(Math.Round(UnitPrice, 2).ToString("N", Utils.NumFormat(2)));
            }
            else
            {
                ((ReceiptsDTO)receiptsBS.Current).UNIT_CURRENCY = Convert.ToDecimal(0.00);
            }
        }

        private void quantityEdit_TextChanged(object sender, EventArgs e)
        {
            if (quantityEdit.Text.Length == 1 && quantityEdit.Text == "-")
                return;



            
        }

        private void totalCurrencyEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                decimal totalCurrency = (totalCurrencyEdit.Text.Length > 0) ? decimal.Parse(totalCurrencyEdit.Text) : 0.00m;
                decimal rate = (currencyRateEdit.Text.Length > 0) ? decimal.Parse(currencyRateEdit.Text) : 0.00m;

                ((ReceiptsDTO)receiptsBS.Current).TOTAL_PRICE =  Math.Round(totalCurrency * rate, 2);

                receiptsBS.ResetBindings(false);
            }
        }

        private void totalCurrencyEdit_TextChanged(object sender, EventArgs e)
        {
            
            UnitCurrency();

            receiptsBS.ResetBindings(false);
        }

        private void totalCurrencyEdit_Leave(object sender, EventArgs e)
        {
            receiptsBS.EndEdit();
        }

        private void totalPriceEdit_Leave(object sender, EventArgs e)
        {
            receiptsBS.EndEdit();
        }

        private void materialValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void materialValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (materialValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void nomenclatureEdit_EditValueChanged(object sender, EventArgs e)
        {
            materialValidationProvider.Validate((Control)sender);
        }

        private void quantityEdit_EditValueChanged(object sender, EventArgs e)
        {
            //if (quantityEdit.Text.Length == 1 && quantityEdit.Text == "-")
            //    return;

            //UnitPrice();
            //UnitCurrency();

            //receiptsBS.ResetBindings(false);
            UnitPrice();
            UnitCurrency();


            materialValidationProvider.Validate((Control)sender);
            ControlValidation();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //receiptsBS.ResetBindings(false);
            //this.Item.CancelEdit();

            this.Item.EndEdit();

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ControlValidation()
        {
            return materialValidationProvider.Validate();
        }

        private void balanceNumEdit_EditValueChanged(object sender, EventArgs e)
        {
            materialValidationProvider.Validate((Control)sender);
        }

        private void totalPriceEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void nomenclatureEdit_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Utils.OnlyNumbers(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (receiptsBS.Count > 0)
                    CheckNomenclature(nomenclatureEdit.Text.Trim());
                else
                    MessageBox.Show("Не додано жодного рядка. Спочатку додайте пустий рядок, перед его редагуванням!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("Такого балансового счёта нет в базе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //receiptsBS.EndEdit();
            }
        }

        //private void CheckNomenclature(string Nomenclature)
        //{


        //    storeHouseService = Program.kernel.Get<IStoreHouseService>();
        //    accountsService = Program.kernel.Get<IAccountsService>();
        //    receiptsBS.EndEdit();
        //    //receiptsGridView.ro.DefaultCellStyle.BackColor = Color.White;

        //    List<NomenclaturesDTO> nomenclatureSearch = storeHouseService.GetNomenclatureWithAccountNumber(Nomenclature).ToList();

        //    if (nomenclatureSearch.Count != 0)
        //    {
        //        ((ReceiptsDTO)receiptsBS.Current).NomenclatureName = nomenclatureSearch[0].Name;
        //        ((ReceiptsDTO)receiptsBS.Current).UnitLocalName = nomenclatureSearch[0].UnitLocalName;
        //        ((ReceiptsDTO)receiptsBS.Current).UnitId = nomenclatureSearch[0].UnitId;
        //        ((ReceiptsDTO)receiptsBS.Current).BalanceAccountId = nomenclatureSearch[0].BALANCE_ACCOUNT_ID;
        //        ((ReceiptsDTO)receiptsBS.Current).BalanceAccountNum = nomenclatureSearch[0].Num;
        //        ((ReceiptsDTO)receiptsBS.Current).NomenclatureGroupId = nomenclatureSearch[0].Nomencl_Group_Id;
        //        ((ReceiptsDTO)receiptsBS.Current).NOMENCLATURE_ID = nomenclatureSearch[0].ID;

        //        nomenclatureNameEdit.EditValue = nomenclatureSearch[0].Name;
        //        measureEdit.EditValue = nomenclatureSearch[0].UnitLocalName;

        //        quantityEdit.Focus();

        //    }
        //    else
        //    {

        //        MessageBox.Show("Номенклатура выдсутня в базі даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

 
        //    }

        //    DialogResult = DialogResult.None;

        //}



    }
}