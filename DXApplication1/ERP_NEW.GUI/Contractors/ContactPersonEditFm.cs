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
    public partial class ContactPersonEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IContractorsService contractorsService;
        private BindingSource contactPersonBS = new BindingSource();

        private Utils.Operation operation;
        private ContactPersonsDTO contactPerson2;
        private int contractorId;

        public ContactPersonEditFm(Utils.Operation operation, ContactPersonsDTO contactPerson, int contractorId)
        {
            InitializeComponent();
            this.operation = operation;
            this.contractorId = contractorId;
            contactPerson2 = contactPerson;
            LoadData();

            lastNameTBox.DataBindings.Add("EditValue", contactPersonBS, "LastName");
            firstNameTBox.DataBindings.Add("EditValue", contactPersonBS, "FirstName");
            middleNameTBox.DataBindings.Add("EditValue", contactPersonBS, "MiddleName");
            professionTBox.DataBindings.Add("EditValue", contactPersonBS, "Profession");
            additionInfoTBox.DataBindings.Add("EditValue", contactPersonBS, "AdditionInfo");
        }

        private void LoadData()
        {
            contractorsService = Program.kernel.Get<IContractorsService>();
            contactPersonBS.DataSource = contactPerson2;
        }

        private void saveBtn_Click(object sender, System.EventArgs e)
        {
            if ((lastNameTBox.Text.Length > 0) && (firstNameTBox.Text.Length > 0))
            {
                if (this.operation == Utils.Operation.Add)
                {
                    contactPerson2.Id = contractorsService.ContactPersonCreate(contactPerson2);
                    if (contactPerson2.Id > 0)
                    {
                        var id = contractorsService.ContractorContactPersonCreate(new ContractorContactPersonsDTO { ContractorId = this.contractorId, ContactPersonId = contactPerson2.Id });
                        this.Close();
                    }
                    else
                        MessageBox.Show("Виникла помилка! Запис не збережено!", "Помилка", MessageBoxButtons.OK);
                }
                else
                {
                    contractorsService.ContactPersonUpdate(contactPerson2);
                    this.Close();
                }
                
            }
            else
                MessageBox.Show("Не введено прізвище або ім'я контактної особи", "Увага", MessageBoxButtons.OK);
        }
             
    }
}