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
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Infrastructure;
using Ninject;

namespace ERP_NEW.GUI.Accounting
{
    public partial class CashBookEditFm : DevExpress.XtraEditors.XtraForm
    {
        private ICashBookService cashBookService;

        private BindingSource cashBookPageBS = new BindingSource();
        private BindingSource cashBookRecordsBS = new BindingSource();

        private List<CashBookRecordJournalDTO> cashBookRecordsList = new List<CashBookRecordJournalDTO>();
        private List<CashBookRecordDTO> deleteCashBookRecordList = new List<CashBookRecordDTO>();

        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return cashBookPageBS.Current as ObjectBase; }
            set
            {
                cashBookPageBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public CashBookEditFm(Utils.Operation operation, CashBookPageDTO model, List<CashBookRecordJournalDTO> cashBookRecordsSource)
        {
            InitializeComponent();

            LoadData();

            this.operation = operation;

            cashBookRecordsList = cashBookRecordsSource;

            cashBookPageBS.DataSource = Item = model;
            cashBookRecordsBS.DataSource = cashBookRecordsList;
            cashBookRecordsGrid.DataSource = cashBookRecordsBS;

            cashBookPageNumberTBox.DataBindings.Add("EditValue", cashBookPageBS, "PageNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            cashBookPageDateEdit.DataBindings.Add("EditValue", cashBookPageBS, "PageDate", true, DataSourceUpdateMode.OnPropertyChanged);

            if (this.operation == Utils.Operation.Add)
            {
                ((CashBookPageDTO)Item).PageDate = DateTime.Now;
                ((CashBookPageDTO)Item).PageNumber = cashBookService.GetLatestPageNumber(((CashBookPageDTO)Item).PageDate, model.CashBookId);
            }
            else
            {
                ((CashBookPageDTO)Item).PageDate = model.PageDate;
                ((CashBookPageDTO)Item).PageNumber = model.PageNumber;
            }
        }

        #region Method's

        private void LoadData()
        {
            cashBookService = Program.kernel.Get<ICashBookService>();

        }

        public CashBookPageDTO Return()
        {
            return ((CashBookPageDTO)Item);
        }


        private void EditCashBookRecord(Utils.Operation operation, CashBookRecordJournalDTO model, List<CashBookRecordJournalDTO> models)
        {
            cashBookService = Program.kernel.Get<ICashBookService>();

            using (CashBookRecordEditFm cashBookRecordEditFm = new CashBookRecordEditFm(operation, model, models, ((CashBookPageDTO)Item).PageDate, ((CashBookPageDTO)Item).CashBookId))
            {
                if (cashBookRecordEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CashBookRecordJournalDTO cashBookRecordJournalDTO = cashBookRecordEditFm.Return();

                    cashBookRecordsGridView.BeginDataUpdate();

                    if (cashBookRecordJournalDTO.Id == 0)
                        cashBookRecordsList.Add(cashBookRecordJournalDTO);

                    cashBookRecordsBS.DataSource = cashBookRecordsList;

                    cashBookRecordsGrid.DataSource = cashBookRecordsBS;

                    cashBookRecordsGridView.EndDataUpdate();
                }
            }

        }


        #endregion

        #region Event's

        private void deleteRecordBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cashBookRecordsGridView.PostEditor();

            cashBookRecordsGridView.BeginDataUpdate();

            var checkItems = cashBookRecordsList.Where(t => t.Selection && t.Id != 0).Select(s => new CashBookRecordDTO()
            {

                Id = s.Id,
                DocumentNumber = s.DocumentNumber,
                AccountId = s.BalanceAccountId,
                BasisId = s.BasisId,
                CashBookPageId = s.CashBookPageId,
                ContractorId = s.ContractorId,
                CurrencyTypeId = s.CurrencyTypeId,
                Payment = s.Payment

            });

            deleteCashBookRecordList.AddRange(checkItems);
            cashBookRecordsList.RemoveAll(s => s.Selection);

            cashBookRecordsBS.DataSource = cashBookRecordsList;
            cashBookRecordsGrid.DataSource = cashBookRecordsBS;

            cashBookRecordsGridView.EndDataUpdate();

        }

        private void addRecordBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditCashBookRecord(Utils.Operation.Add, new CashBookRecordJournalDTO(), cashBookRecordsList);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveCashBookPage())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void editRecordsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditCashBookRecord(Utils.Operation.Update,   (CashBookRecordJournalDTO)cashBookRecordsBS.Current, cashBookRecordsList);
        }

        private bool SaveCashBookPage()
        {
            this.Item.EndEdit();

            //if (FindDublicate((BusinessTripsDecreeDTO)this.Item))
            //{
            //    MessageBox.Show("Наказ з таким номером вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return false;
            //}

            if (cashBookRecordsBS.Count == 0)
            {
                MessageBox.Show("Необхідно додати записи до сторінки!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            try
            {
                //if (deleteCashBookRecordList.Count > 0)
                //{
                //    cashBookService = Program.kernel.Get<ICashBookService>();
                //    cashBookService.CashBookRecordRemoveRange(deleteCashBookRecordList);
                //}

                if (operation == Utils.Operation.Add)
                {
                    cashBookService = Program.kernel.Get<ICashBookService>();

                    ((CashBookPageDTO)Item).Id = cashBookService.CashBookPageCreate(((CashBookPageDTO)Item));

                    cashBookRecordsList.Select(s => { s.CashBookPageId = ((CashBookPageDTO)Item).Id; return s; }).ToList();

                    foreach (var item in cashBookRecordsList)
                    {
                        CashBookRecordDTO newModel = new CashBookRecordDTO()
                        {
                            Payment = ((CashBookRecordJournalDTO)item).Payment,
                            AccountId = ((CashBookRecordJournalDTO)item).BalanceAccountId,
                            BasisId = ((CashBookRecordJournalDTO)item).BasisId,
                            CashBookPageId = ((CashBookRecordJournalDTO)item).CashBookPageId,
                            ContractorId = ((CashBookRecordJournalDTO)item).ContractorId,
                            CurrencyTypeId = ((CashBookRecordJournalDTO)item).CurrencyTypeId,
                            DocumentNumber = ((CashBookRecordJournalDTO)item).DocumentNumber,
                            AdditionalId = ((CashBookRecordJournalDTO)item).AdditionalId
                        };

                        cashBookService.CashBookRecordCreate(newModel);
                    }
                }

                else
                {
                    cashBookService = Program.kernel.Get<ICashBookService>();
                    cashBookService.CashBookPageUpdate((CashBookPageDTO)Item);

                    cashBookRecordsList.Select(s => { s.CashBookPageId = ((CashBookPageDTO)Item).Id; return s; }).ToList();

                    foreach (var item in cashBookRecordsList)
                    {
                        if (item.Id == 0)
                        {
                            CashBookRecordDTO newModel = new CashBookRecordDTO()
                            {
                                Payment = ((CashBookRecordJournalDTO)item).Payment,
                                AccountId = ((CashBookRecordJournalDTO)item).BalanceAccountId,
                                BasisId = ((CashBookRecordJournalDTO)item).BasisId,
                                CashBookPageId = ((CashBookRecordJournalDTO)item).CashBookPageId,
                                ContractorId = ((CashBookRecordJournalDTO)item).ContractorId,
                                CurrencyTypeId = ((CashBookRecordJournalDTO)item).CurrencyTypeId,
                                DocumentNumber = ((CashBookRecordJournalDTO)item).DocumentNumber,
                                AdditionalId = ((CashBookRecordJournalDTO)item).AdditionalId
                            };

                            cashBookService.CashBookRecordCreate(newModel);

                        }
                        else
                        {
                            CashBookRecordDTO updateModel = new CashBookRecordDTO()
                            {

                                Id = ((CashBookRecordJournalDTO)item).Id,
                                Payment = ((CashBookRecordJournalDTO)item).Payment,
                                AccountId = ((CashBookRecordJournalDTO)item).BalanceAccountId,
                                BasisId = ((CashBookRecordJournalDTO)item).BasisId,
                                CashBookPageId = ((CashBookRecordJournalDTO)item).CashBookPageId,
                                ContractorId = ((CashBookRecordJournalDTO)item).ContractorId,
                                CurrencyTypeId = ((CashBookRecordJournalDTO)item).CurrencyTypeId,
                                DocumentNumber = ((CashBookRecordJournalDTO)item).DocumentNumber,
                                AdditionalId = ((CashBookRecordJournalDTO)item).AdditionalId
                            };

                            cashBookService.CashBookRecordUpdate(updateModel);
                        }


                    }
                    if (deleteCashBookRecordList.Count > 0)
                    {
                        foreach (var item in deleteCashBookRecordList)
                        {
                            if (item.Id > 0)
                                cashBookService.CashBookRecordDelete(item.Id);
                        }
                    }
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region Validation's

        private bool ControlValidation()
        {
            return cashBookValidationProvider.Validate();
        }

        private void cashBookPageNumberTBox_EditValueChanged(object sender, EventArgs e)
        {
            cashBookValidationProvider.Validate((Control)sender);
        }

        private void cashBookValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void cashBookValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (cashBookValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void cashBookPageDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (cashBookPageDateEdit != null && operation == Utils.Operation.Add)
                    ((CashBookPageDTO)Item).PageNumber = cashBookService.GetLatestPageNumber((DateTime)cashBookPageDateEdit.EditValue, ((CashBookPageDTO)Item).CashBookId);
            
            cashBookValidationProvider.Validate((Control)sender);
        }

        #endregion

        






    }
}