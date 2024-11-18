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
using Ninject;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System.IO;
using ERP_NEW.BLL.Infrastructure;
using System;

namespace ERP_NEW.GUI.Contractors
{
    public partial class ContractorEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IContractorsService contractorsService;

        private BindingSource contractorBS = new BindingSource();
        private BindingSource productCategoryBS = new BindingSource();
        private BindingSource contractorTypeBS = new BindingSource();
        private BindingSource contractorContactAddressBS = new BindingSource();
        private BindingSource contactPersonAddressBS = new BindingSource();
        private Utils.Operation operation;
        private ContractorsDTO contractor2;
        
        public ContractorEditFm(Utils.Operation operation, ContractorsDTO contractor)
        {
            InitializeComponent();
            contractor2 = contractor;
            LoadData();
            
            this.operation = operation;
            contractorBS.DataSource = contractor2;

            nameTBox.DataBindings.Add("EditValue", contractorBS, "Name");
            tinTBox.DataBindings.Add("EditValue", contractorBS, "Tin");
            srnTBox.DataBindings.Add("EditValue", contractorBS, "Srn");
            activeCheck.DataBindings.Add("EditValue", contractorBS, "Active");


            productCategoryEdit.Properties.DataSource = productCategoryBS;
            productCategoryEdit.Properties.ValueMember = "Id";
            productCategoryEdit.Properties.DisplayMember = "CategoryName";
            productCategoryEdit.Properties.NullText = "Немає данних";


            contractorTypeEdit.Properties.DataSource = contractorTypeBS;
            contractorTypeEdit.Properties.ValueMember = "TypeId";
            contractorTypeEdit.Properties.DisplayMember = "TypeName";
            contractorTypeEdit.Properties.NullText = "Немає данних";

            List<string> ownTypes = new List<string>(){"Вітчизняні", "Зарубіжні"};
            
            ownTypeCBox.Properties.Items.AddRange(ownTypes);
            
            if (operation == Utils.Operation.Update)
            {
                productCategoryEdit.EditValue = contractor.ProductCategoryId;
                contractorTypeEdit.EditValue = contractor.ContractorTypeId;
                ownTypeCBox.SelectedIndex = (contractor.OwnType != null ? ((int)contractor.OwnType - 1) : -1);
            }

                contractorContactAddressGrid.DataSource = contractorContactAddressBS;
                contactPersonAddressGrid.DataSource = contactPersonAddressBS;
           
            if (productCategoryEdit.EditValue == null)
                ProductCategoryEditBtnEnabled(false);

            ControlValidation(); 
        }

        #region Method's

        public long Return()
        {
            return contractor2.Id;
        }

        private void LoadData()
        {
            contractorsService = Program.kernel.Get<IContractorsService>();
            productCategoryBS.DataSource = contractorsService.GetProductCategories();
            contractorTypeBS.DataSource = contractorsService.GetContractorTypes();
            contractorContactAddressBS.DataSource = contractorsService.GetContractorContactAddress(contractor2.Id);
            contactPersonAddressBS.DataSource = contractorsService.GetContactPersonAddress(contractor2.Id);
        }

        private bool SaveItem()
        {
            contractorsService = Program.kernel.Get<IContractorsService>();
            string s = nameTBox.Text.Remove(3);
            //char ch = '"';
            //int indexOfChar = nameTBox.Text.IndexOf(ch);

            if (contractorsService.CheckContractor(((ContractorsDTO)contractorBS.Current)))
            {
                MessageBox.Show("Контрагент з таким іменем вже існує.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

                if (s != "Дог")
                {
                    if ((nameTBox.Text.Length > 0) /*&& (contractorTypeEdit.ItemIndex >= 0) && (productCategoryEdit.ItemIndex >= 0)*/)
                    {
                        contractorBS.EndEdit();
                        contractor2.ContractorTypeId = (contractorTypeEdit.ItemIndex >= 0) ? ((ContractorTypesDTO)contractorTypeEdit.GetSelectedDataRow()).TypeId : (int?)null;
                        contractor2.ProductCategoryId = (productCategoryEdit.ItemIndex >= 0) ? ((ProductCategoriesDTO)productCategoryEdit.GetSelectedDataRow()).Id : (int?)null;
                        contractor2.OwnType = ownTypeCBox.SelectedIndex + 1;

                        if (this.operation == Utils.Operation.Add)
                        {
                            contractor2.Id = contractorsService.ContractorCreate(((ContractorsDTO)contractorBS.Current));
                        }
                        else
                        {
                            contractorsService.ContractorUpdate(((ContractorsDTO)contractorBS.Current));
                        }

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Не внесені дані!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    if (this.operation == Utils.Operation.Add)
                    {
                        contractor2.Id = contractorsService.ContractorCreate(((ContractorsDTO)contractorBS.Current));
                    }
                    else
                    {
                        contractorsService.ContractorUpdate(((ContractorsDTO)contractorBS.Current));
                    }
                    return true;
                }
        }

        #endregion

        #region Event's

        private void productCategoryEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Очистить
                    {
                        productCategoryEdit.EditValue = null;
                        productCategoryEdit.Properties.NullText = "Немає данних";
                        ProductCategoryEditBtnEnabled(false);
                        break;
                    }
                case 2: //ДОБАВИТЬ
                    {
                        new ProductCategoryEditFm(Utils.Operation.Add, new ProductCategoriesDTO()).ShowDialog();
                        LoadData();
                        break;
                    }
                case 3://РЕДАКТИРОВАТЬ
                    {
                        new ProductCategoryEditFm(Utils.Operation.Update, (ProductCategoriesDTO)productCategoryEdit.GetSelectedDataRow()).ShowDialog();
                        LoadData();
                        break;
                    }
                case 4://УДАЛИТЬ
                    {
                        if (productCategoryBS.Count != 0)
                        {
                            if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                contractorsService.ProductCategotyDelete(((ProductCategoriesDTO)productCategoryEdit.GetSelectedDataRow()).Id);
                                LoadData();
                                productCategoryEdit.EditValue = null;
                                productCategoryEdit.Properties.NullText = "Немає данних";
                            }
                        }
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }

        private void ProductCategoryEditBtnEnabled(bool state)
        {
            productCategoryEdit.Properties.Buttons[3].Enabled = state;
            productCategoryEdit.Properties.Buttons[4].Enabled = state;
        }

        private void saveBtn_Click(object sender, System.EventArgs e)
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
                MessageBox.Show("При береженні виникла помилка. " + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void productCategoryEdit_EditValueChanged(object sender, System.EventArgs e)
        {
            contractorValidationProvider.Validate((Control)sender);

            ProductCategoryEditBtnEnabled(true);
        }

        private void deletePersonBtn_Click(object sender, System.EventArgs e)
        {
            if (contactPersonAddressBS.Count > 0)
            {
                if (MessageBox.Show("Видалити контактну особу?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    contractorsService.ContactPersonDelete((int)((ContactPersonAddressDTO)contactPersonAddressBS.Current).ContactPersonId);
                    LoadData();
                }
            }
        }

        private void deleteKBtn_Click(object sender, System.EventArgs e)
        {
            if (contactPersonAddressBS.Count > 0)
            {
                if (MessageBox.Show("Видалити запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    contractorsService.ContactPersonAddresDelete(((ContactPersonAddressDTO)contactPersonAddressBS.Current).Id);
                    LoadData();
                }
            }

        }

        private void deleteBtn_Click(object sender, System.EventArgs e)
        {
            if (contractorContactAddressBS.Count > 0)
            {
                if (MessageBox.Show("Видалити запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    contractorsService.ContactPersonAddresDelete(((ContractorContactAddressDTO)contractorContactAddressBS.Current).Id);
                    LoadData();
                }
            }
        }

        private void deleteAllBtn_Click(object sender, System.EventArgs e)
        {
            if (contractorContactAddressBS.Count > 0)
            {
                if (MessageBox.Show("Видалити всю інформацію?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    contractorsService.ContractorContacts(((ContractorContactAddressDTO)contractorContactAddressBS.Current).ContractorId);
                    LoadData();
                }
            }
        }

        private void addBtn_Click(object sender, System.EventArgs e)
        {
            new ContractorContactAddressEditFm(Utils.Operation.Add, new ContractorContactAddressDTO { ContractorId = contractor2.Id }).ShowDialog();
            LoadData();
        }

        private void editBtn_Click(object sender, System.EventArgs e)
        {
            if (contractorContactAddressBS.Count > 0)
            {
                new ContractorContactAddressEditFm(Utils.Operation.Update, (ContractorContactAddressDTO)contractorContactAddressBS.Current).ShowDialog();
                LoadData();
            }
        }

        private void addKBtn_Click(object sender, System.EventArgs e)
        {
            new ContactPersonAddressEditFm(Utils.Operation.Add, new ContactPersonAddressDTO { ContractorId = contractor2.Id }).ShowDialog();
            LoadData();
        }

        private void editKBtn_Click(object sender, System.EventArgs e)
        {
            if (contactPersonAddressBS.Count > 0)
            {
                new ContactPersonAddressEditFm(Utils.Operation.Update, (ContactPersonAddressDTO)contactPersonAddressBS.Current).ShowDialog();
                LoadData();
            }
        }

        #endregion

        #region Validation
        
        private bool ControlValidation()
        {
            return contractorValidationProvider.Validate();
        }

        private void nameTBox_TextChanged(object sender, EventArgs e)
        {
            contractorValidationProvider.Validate((Control)sender);
        }

        private void contractorTypeEdit_EditValueChanged(object sender, EventArgs e)
        {
            contractorValidationProvider.Validate((Control)sender);
        }

        private void contractorValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void contractorValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (contractorValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        #endregion
    }
}