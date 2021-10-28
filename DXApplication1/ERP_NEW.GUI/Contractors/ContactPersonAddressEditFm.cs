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

namespace ERP_NEW.GUI.Contractors
{
    public partial class ContactPersonAddressEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IContractorsService contractorsService;
        private BindingSource contactPersonAddressBS = new BindingSource();
        private BindingSource contactTypesBS = new BindingSource();
        private BindingSource contactKindsBS = new BindingSource();
        private BindingSource contactPersonsBS = new BindingSource();

        private Utils.Operation operation;
        private ContactPersonAddressDTO contactPersonAddress2;
        private IEnumerable<ContactKindsDTO> contactKinds;

        public ContactPersonAddressEditFm(Utils.Operation operation, ContactPersonAddressDTO contactPersonAddress)
        {
            InitializeComponent();
            this.operation = operation;
            contactPersonAddress2 = contactPersonAddress;
            LoadData();

            detailsTBox.DataBindings.Add("EditValue", contactPersonAddressBS, "Details");

            professionTBox.DataBindings.Add("EditValue", contactPersonAddressBS, "Profession");
            additionInfoTBox.DataBindings.Add("EditValue", contactPersonAddressBS, "AdditionInfo");

            contactTypesEdit.Properties.DataSource = contactTypesBS;
            contactTypesEdit.Properties.ValueMember = "Id";
            contactTypesEdit.Properties.DisplayMember = "TypeName";
            contactTypesEdit.Properties.NullText = "Немає данних";

            fioEdit.Properties.DataSource = contactPersonsBS;
            fioEdit.Properties.ValueMember = "Id";
            fioEdit.Properties.DisplayMember = "Fio";
            fioEdit.Properties.NullText = "Немає данних";

            contactKindsEdit.Properties.DataSource = contactKindsBS;
            contactKindsEdit.Properties.ValueMember = "Id";
            contactKindsEdit.Properties.DisplayMember = "KindName";
            contactKindsEdit.Properties.NullText = "Немає данних";

            if (operation == Utils.Operation.Update)
            {
                contactTypesEdit.EditValue = contactPersonAddress2.TypeId;
                contactKindsEdit.EditValue = contactPersonAddress2.ContactKindId;
                fioEdit.EditValue = contactPersonAddress2.ContactPersonId;
              
            }
            else
            {
                contactKindsEdit.EditValue = null;
                contactTypesEdit.EditValue = null;
                fioEdit.EditValue = null;
            }

            if (fioEdit.EditValue == null)
                FioEditBtnEnabled(false);
        }

        private void LoadData()
        {
            contractorsService = Program.kernel.Get<IContractorsService>();
            contactPersonAddressBS.DataSource = contactPersonAddress2;
            contactTypesBS.DataSource = contractorsService.GetContactTypes();
            contactKinds = contractorsService.GetContactKinds().Where(c => c.ContactTypeId == contactPersonAddress2.TypeId).ToList();
            contactKindsBS.DataSource = contactKinds;
            contactPersonsBS.DataSource = contractorsService.GetContactPersons(contactPersonAddress2.ContractorId);
        }

        private void contactTypesEdit_EditValueChanged(object sender, System.EventArgs e)
        {
            if (contactTypesEdit.ItemIndex >= 0) //(contactTypesEdit.EditValue != null)
            {
                contactKinds = contractorsService.GetContactKinds().Where(c => c.ContactTypeId == (int)contactTypesEdit.EditValue).ToList();
                contactKindsBS.DataSource = contactKinds;
                int firstId = contactKinds.Select(c => c.Id).First();
                contactKindsEdit.EditValue = firstId;
            }
        }

        private void cancelBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, System.EventArgs e)
        {
            if ((fioEdit.ItemIndex >= 0) && (contactTypesEdit.ItemIndex >= 0) && (contactKindsEdit.ItemIndex >= 0))
            {
                contactPersonAddress2.ContactKindId = (contactKindsEdit.ItemIndex >= 0) ? ((ContactKindsDTO)contactKindsEdit.GetSelectedDataRow()).Id : (int?)null;
                contactPersonAddress2.ContactPersonId = ((ContactPersonsDTO)fioEdit.GetSelectedDataRow()).Id;
                if (this.operation == Utils.Operation.Add)
                {
                        contactPersonAddress2.Id = contractorsService.ContactPersonAddresCreate((ContactPersonAddressDTO)contactPersonAddressBS.Current);
                }
                else
                {
                    contractorsService.ContactPersonAddresUpdate((ContactPersonAddressDTO)contactPersonAddressBS.Current);
                }

                this.Close();
            }
            else
                MessageBox.Show("Не заповнені дані", "Увага", MessageBoxButtons.OK);
        }

        private void fioEdit_EditValueChanged(object sender, System.EventArgs e)
        {
            if (fioEdit.ItemIndex >= 0)
            {
                contactPersonAddress2.Profession = ((ContactPersonsDTO)fioEdit.GetSelectedDataRow()).Profession;
                contactPersonAddress2.AdditionInfo = ((ContactPersonsDTO)fioEdit.GetSelectedDataRow()).AdditionInfo;
                contactPersonAddressBS.DataSource = contactPersonAddress2;
                contactPersonAddressBS.ResetCurrentItem();
                FioEditBtnEnabled(true);
            }
         }

        private void fioEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Очистить
                    {
                        fioEdit.EditValue = null;
                        fioEdit.Properties.NullText = "Немає данних";
                        FioEditBtnEnabled(false);
                        break;
                    }
                case 2: //ДОБАВИТЬ
                    {
                        new ContactPersonEditFm(Utils.Operation.Add, new ContactPersonsDTO(), contactPersonAddress2.ContractorId).ShowDialog();
                        LoadData();
                        break;
                    }
                case 3://РЕДАКТИРОВАТЬ
                    {
                        new ContactPersonEditFm(Utils.Operation.Update, (ContactPersonsDTO)fioEdit.GetSelectedDataRow(), contactPersonAddress2.ContractorId).ShowDialog();
                        contactPersonAddress2.Profession = ((ContactPersonsDTO)fioEdit.GetSelectedDataRow()).Profession;
                        contactPersonAddress2.AdditionInfo = ((ContactPersonsDTO)fioEdit.GetSelectedDataRow()).AdditionInfo;
                        LoadData();
                        contactPersonAddressBS.ResetCurrentItem();
                        break;
                    }
                case 4://УДАЛИТЬ
                    {
                        if (contactPersonsBS.Count != 0)
                        {
                            if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                contractorsService.ContactPersonDelete(((ContactPersonsDTO)fioEdit.GetSelectedDataRow()).Id);
                                LoadData();
                                fioEdit.EditValue = null;
                                fioEdit.Properties.NullText = "Немає данних";
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

        private void FioEditBtnEnabled(bool state)
        {
            fioEdit.Properties.Buttons[3].Enabled = state;
            fioEdit.Properties.Buttons[4].Enabled = state;
        }
    }
}