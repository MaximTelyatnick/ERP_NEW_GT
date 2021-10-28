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
    public partial class ContractorContactAddressEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IContractorsService contractorsService;
        private BindingSource contractorContactAddressBS = new BindingSource();
        private BindingSource contactTypesBS = new BindingSource();
        private BindingSource contactKindsBS = new BindingSource();

        private Utils.Operation operation;
        private ContractorContactAddressDTO contractorContactAddress2;
        private IEnumerable<ContactKindsDTO> contactKinds;

        public ContractorContactAddressEditFm(Utils.Operation operation, ContractorContactAddressDTO contractorContactAddress)
        {
            InitializeComponent();
            this.operation = operation;
            contractorContactAddress2 = contractorContactAddress;
            LoadData();
                                    
            detailsTBox.DataBindings.Add("EditValue", contractorContactAddressBS, "Details");
            contactTypesEdit.Properties.DataSource = contactTypesBS;
            contactTypesEdit.Properties.ValueMember = "Id";
            contactTypesEdit.Properties.DisplayMember = "TypeName";
            contactTypesEdit.Properties.NullText = "Немає данних";

            contactKindsEdit.Properties.DataSource = contactKindsBS;
            contactKindsEdit.Properties.ValueMember = "Id";
            contactKindsEdit.Properties.DisplayMember = "KindName";
            contactKindsEdit.Properties.NullText = "Немає данних";

            if (operation == Utils.Operation.Update)
            {
                contactTypesEdit.EditValue = contractorContactAddress.TypeId;
                contactKindsEdit.EditValue = contractorContactAddress.ContractorContactKindId;
            }
            else
            {
                contactKindsEdit.EditValue = null;
                contactTypesEdit.EditValue = null;
            }
        }

        private void LoadData()
        {
            contractorsService = Program.kernel.Get<IContractorsService>();
            contractorContactAddressBS.DataSource = contractorContactAddress2;
            contactTypesBS.DataSource = contractorsService.GetContactTypes();
            contactKinds = contractorsService.GetContactKinds();
        }

        private void contactTypesEdit_EditValueChanged(object sender, System.EventArgs e)
        {
            if (contactTypesEdit.EditValue != null)
            {
                var source = contactKinds.Where(c => c.ContactTypeId == (int)contactTypesEdit.EditValue).ToList();
                contactKindsBS.DataSource = source;
                int firstId = source.Select(c => c.Id).First();
                contactKindsEdit.EditValue = firstId;
            }
        }

        private void cancelBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, System.EventArgs e)
        {
            if ((contactTypesEdit.ItemIndex >= 0) && (detailsTBox.Text.Length > 0) && (contactKindsEdit.ItemIndex >= 0))
            {
                contractorContactAddress2.ContractorContactKindId = (contactKindsEdit.ItemIndex >= 0) ? ((ContactKindsDTO)contactKindsEdit.GetSelectedDataRow()).Id : (int?)null;

                if (this.operation == Utils.Operation.Add)
                {
                    contractorContactAddress2.Id = contractorsService.ContractorContactAddresCreate((ContractorContactAddressDTO)contractorContactAddressBS.Current);
                }
                else
                {
                    contractorsService.ContractorContactAddresUpdate((ContractorContactAddressDTO)contractorContactAddressBS.Current);
                }

                this.Close();
            }
            else
                MessageBox.Show("Не введені дані", "Увага", MessageBoxButtons.OK);
        }
    }
}