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
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using Ninject;
using ERP_NEW.BLL.DTO.SelectedDTO;

namespace ERP_NEW.GUI.Production
{
    public partial class StoreHouseProjectExpendituresEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IPeriodService periodService;
        private ICustomerOrdersService customerOrdersService;
        private IEmployeesService employeesService;

        private BindingSource customerOrdersBS = new BindingSource();
        private BindingSource expendituresStoreHousesBS = new BindingSource();

        private ExpedinturesAccountantDTO expendituresStoreHousesDTO;
        private Utils.Operation operation;
        private UserTasksDTO userTaskDTO;

        private decimal expQuantity = 0.000000m;
        private decimal expPrice = 0.00m;

        private decimal expQuantityMax = 0.000000m;
        private decimal expPriceMax = 0.00m;

        private ObjectBase Item
        {
            get { return expendituresStoreHousesBS.Current as ObjectBase; }
            set
            {
                expendituresStoreHousesBS.DataSource = value;
                value.BeginEdit();
            }
        }


        public StoreHouseProjectExpendituresEditFm(Utils.Operation operation, ExpedinturesAccountantDTO expedinturesAccountantDTO, UserTasksDTO userTaskDTO)
        {
            InitializeComponent();

            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            employeesService = Program.kernel.Get<IEmployeesService>();

            expQuantityMax = expedinturesAccountantDTO.QUANTITY;
            expPriceMax = expedinturesAccountantDTO.PRICE;

            expendituresStoreHousesDTO = expedinturesAccountantDTO;
            expendituresStoreHousesBS.DataSource = Item = expendituresStoreHousesDTO;

            this.userTaskDTO = userTaskDTO;
            this.operation = operation;

            orderNumberEdit.DataBindings.Add("EditValue", expendituresStoreHousesBS, "CustomerOrderId", true, DataSourceUpdateMode.OnPropertyChanged);
            employeesEdit.DataBindings.Add("EditValue", expendituresStoreHousesBS, "EmployeeId", true, DataSourceUpdateMode.OnPropertyChanged);
            nomenclatureEdit.DataBindings.Add("EditValue", expendituresStoreHousesBS, "Nomenclature", true, DataSourceUpdateMode.OnPropertyChanged);
            nomenclatureNameEdit.DataBindings.Add("EditValue", expendituresStoreHousesBS, "NomenclatureName", true, DataSourceUpdateMode.OnPropertyChanged);

            measureEdit.DataBindings.Add("EditValue", expendituresStoreHousesBS, "UnitLocalName", true, DataSourceUpdateMode.OnPropertyChanged);
            balanceNumEdit.DataBindings.Add("EditValue", expendituresStoreHousesBS, "BalanceAccountNum", true, DataSourceUpdateMode.OnPropertyChanged);
            quantitySpinEdit.DataBindings.Add("EditValue", expendituresStoreHousesBS, "QUANTITY", true, DataSourceUpdateMode.OnPropertyChanged);
            //sumEdit.DataBindings.Add("EditValue", expendituresStoreHousesBS, "PRICE");
            expenditureDateEdit.DataBindings.Add("EditValue", expendituresStoreHousesBS, "RealExpDate", true, DataSourceUpdateMode.OnPropertyChanged);
           
            customerOrdersBS.DataSource = customerOrdersService.GetCustomerOrdersFull().OrderByDescending(sort => sort.OrderDate).ToList();
            orderNumberEdit.Properties.DataSource = customerOrdersBS;
            orderNumberEdit.Properties.ValueMember = "Id";
            orderNumberEdit.Properties.DisplayMember = "OrderNumber";
            orderNumberEdit.Properties.NullText = "";

            employeesEdit.Properties.DataSource = employeesService.GetEmployeesWorking();
            employeesEdit.Properties.ValueMember = "EmployeeID";
            employeesEdit.Properties.DisplayMember = "Fio";
            employeesEdit.Properties.NullText = null;

            quantitySpinEdit.Properties.MinValue = 0;
            quantitySpinEdit.Properties.MaxValue = expendituresStoreHousesDTO.QUANTITY;


            if (operation == Utils.Operation.Add)
            {
                ((ExpedinturesAccountantDTO)Item).RealExpDate = DateTime.Now;
                quantitySpinEdit.ReadOnly = false;



            }
            else
            {
                if (orderNumberEdit.Text == "")
                    employeesEdit.Visible = true;
                else               
                    employeesEdit.Visible = false;

                ((ExpedinturesAccountantDTO)Item).ProdCustomerOrderId = ((ExpedinturesAccountantDTO)Item).CustomerOrderId;

                quantitySpinEdit.ReadOnly = false;
            }

            ((ExpedinturesAccountantDTO)Item).UserId = userTaskDTO.UserId;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();

            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveItem())
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


        private bool SaveItem()
        {
            ((ExpedinturesAccountantDTO)Item).PRICE = Convert.ToDecimal(sumEdit.Text);
            this.Item.EndEdit();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            periodService = Program.kernel.Get<IPeriodService>();

            if (!periodService.CheckPeriodAccess((DateTime)((ExpedinturesAccountantDTO)Item).RealExpDate))
            {
                MessageBox.Show("Період закрит або не існує!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (((ExpedinturesAccountantDTO)Item).EmployeeId == null && ((ExpedinturesAccountantDTO)Item).CustomerOrderId == null)
            {
                MessageBox.Show("Повинен бути вказаний заказ або працівник", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (operation == Utils.Operation.Add)
            {
                storeHouseService.ExpendituresAccountantCreate((ExpedinturesAccountantDTO)Item);
                return true;
            }
            else
            {
                if (((ExpedinturesAccountantDTO)Item).CustomerOrderId == null)
                    ((ExpedinturesAccountantDTO)Item).ProdCustomerOrderId = null;
                else
                    ((ExpedinturesAccountantDTO)Item).EmployeeId = null;

                ((ExpedinturesAccountantDTO)Item).EXP_DATE = new DateTime(((ExpedinturesAccountantDTO)Item).RealExpDate.Value.Year, ((ExpedinturesAccountantDTO)Item).RealExpDate.Value.Month, 1).AddMonths(1).AddDays(-1);
                storeHouseService.ExpendituresAccountantUpdate((ExpedinturesAccountantDTO)Item);
                return true;
            }
        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void orderNumberEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (orderNumberEdit.Text == "")
            {
                ((ExpedinturesAccountantDTO)Item).PROJECT_NUM = "0";
                //((ExpedinturesAccountantDTO)Item).EmployeeId = null;
                employeesEdit.Visible = true;
                employeesLbl.Visible = true;
            }
            else
            {
                employeesEdit.Visible = false;
                employeesLbl.Visible = false;
                ((ExpedinturesAccountantDTO)Item).PROJECT_NUM = orderNumberEdit.Text.Replace(".", "");
                //((ExpedinturesAccountantDTO)Item).EmployeeId = null;
            }
        }

        private void expenditureDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
            SetPeriodBtnImage();
        }

        private void quantitySpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void SetPeriodBtnImage()
        {
            periodService = Program.kernel.Get<IPeriodService>();
            if (expenditureDateEdit.EditValue != null && !DBNull.Value.Equals(expenditureDateEdit.EditValue))
            {
                periodEditBtn.Enabled = true;
                if (periodService.CheckPeriodAccess((DateTime)expenditureDateEdit.EditValue))
                    periodEditBtn.Image = imageCollection.Images[1];
                else
                    periodEditBtn.Image = imageCollection.Images[0];
            }
            else
            {
                periodEditBtn.Enabled = false;
            }

        }

        public ExpedinturesAccountantDTO Return()
        {
            return ((ExpedinturesAccountantDTO)expendituresStoreHousesBS.Current);
        }

        private void periodEditBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені що бажаєте редагувати період?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    periodService = Program.kernel.Get<IPeriodService>();

                    if (periodService.CheckPeriodAccess((DateTime)expenditureDateEdit.EditValue))
                    {
                        PeriodsDTO model = periodService.GetPeriodByKey(((DateTime)expenditureDateEdit.EditValue).Year, ((DateTime)expenditureDateEdit.EditValue).Month);
                        model.State = false;

                        periodService.PeriodsUpdate(model);
                    }
                    else
                    {
                        if (periodService.CheckPeriodExist((DateTime)expenditureDateEdit.EditValue))
                        {
                            PeriodsDTO model = periodService.GetPeriodByKey(((DateTime)expenditureDateEdit.EditValue).Year, ((DateTime)expenditureDateEdit.EditValue).Month);
                            model.State = true;

                            periodService.PeriodsUpdate(model);
                        }
                        else if (MessageBox.Show("Вказаного періода не існує в системі! Додати період?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            PeriodsDTO model = new PeriodsDTO()
                            {
                                Year = ((DateTime)expenditureDateEdit.EditValue).Year,
                                Month = ((DateTime)expenditureDateEdit.EditValue).Month,
                                State = true,
                                StateBank = false,
                                StateBusinesTrip = false
                            };

                            periodService.PeriodsCreate(model);
                        }
                    }

                    SetPeriodBtnImage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При збереженні періоду виникла помилка. " + ex.Message, "Збереження періоду", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void employeesEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Очистити
                    {
                        employeesEdit.EditValue = null;
                        break;
                    }
            }
        }

        private void orderNumberEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Очистити
                    {
                        orderNumberEdit.EditValue = null;
                        break;
                    }
            }
        }

        private void quantitySpinEdit_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            if (expQuantityMax != 0)
            {
                decimal Quantity = Convert.ToDecimal(quantitySpinEdit.Text.Length == 0 ? "0,00000" : quantitySpinEdit.Text.Replace('.', ','));
                decimal Price = Convert.ToDecimal(sumEdit.Text.Length == 0 ? "0,00" : sumEdit.Text.Replace('.', ','));

                //decimal RemainsQuantity = Convert.ToDecimal(((ExpedinturesAccountantDTO)storeHouseReceiptProjectBS.Current).);

                decimal RemainsQuantity = Convert.ToDecimal(expQuantityMax);

                if (Quantity == RemainsQuantity)
                {
                    expQuantity = Quantity;
                    expPrice = Convert.ToDecimal(expPriceMax);
                    sumEdit.Text = Math.Round(expPrice, 2).ToString("N", Utils.NumFormat(2));
                }
                else
                {
                    expPrice = Quantity * Convert.ToDecimal(expendituresStoreHousesDTO.UnitPrice);
                    sumEdit.Text = quantitySpinEdit.Text.Length == 0 ? "" : Math.Round(expPrice, 2).ToString("N", Utils.NumFormat(2));
                    expQuantity = Quantity;
                }

                expQuantity = Quantity;

                if (Quantity > RemainsQuantity)
                {
                    dxErrorProvider.SetError(quantitySpinEdit, "Недостатня кількість!");
                    saveBtn.Enabled = false;
                }
                else
                {
                    dxErrorProvider.ClearErrors();
                    saveBtn.Enabled = true;
                }
            }
        }
       
    }
}