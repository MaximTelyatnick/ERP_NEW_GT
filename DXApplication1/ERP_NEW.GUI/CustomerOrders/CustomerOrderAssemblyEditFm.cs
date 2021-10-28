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
using DevExpress.XtraBars;
using System;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.CustomerOrders
{
    public partial class CustomerOrderAssemblyEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IMtsSpecificationsService mtsSpecificationsService;
        private ICustomerOrdersService customerOrdersService;

        private BindingSource customerOrderAssemblyBS = new BindingSource();
        private BindingSource assembliesBS = new BindingSource();

        private Utils.Operation _operation;
        
        private ObjectBase Item
        {
            get { return customerOrderAssemblyBS.Current as ObjectBase; }
            set
            {
                customerOrderAssemblyBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }
        
        public CustomerOrderAssemblyEditFm(Utils.Operation operation, CustomerOrderAssembliesDTO model)
        {
            InitializeComponent();

            _operation = operation;
            customerOrderAssemblyBS.DataSource = Item = model;

            LoadData();
            
            assemblyEdit.DataBindings.Add("EditValue", customerOrderAssemblyBS, "AssemblyId", true, DataSourceUpdateMode.OnPropertyChanged);
            assemblyEdit.Properties.DataSource = assembliesBS;
            assemblyEdit.Properties.ValueMember = "AssemblyId";
            assemblyEdit.Properties.DisplayMember = "Drawing";
            assemblyEdit.Properties.NullText = "Немає данних";
                        
            assemblyValidationProvider.Validate();
        }

        private void LoadData()
        {
            mtsSpecificationsService = Program.kernel.Get<IMtsSpecificationsService>();
            assembliesBS.DataSource = mtsSpecificationsService.GetMtsAssemblies(DateTime.MinValue, DateTime.MaxValue);
        }

        public int Return()
        {
            return ((CustomerOrderAssembliesDTO)Item).Id;
        }

        private bool SaveAssembly()
        {
            Item.EndEdit();

            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            
            try
            {
                if (_operation == Utils.Operation.Add)
                {
                    ((CustomerOrderAssembliesDTO)Item).Id = customerOrdersService.CustomerOrderAssemblyCreate((CustomerOrderAssembliesDTO)Item);
                }
                else
                    customerOrdersService.CustomerOrderAssemblyUpdate((CustomerOrderAssembliesDTO)Item);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveAssembly())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Validate event's

        private void assemblyEdit_EditValueChanged(object sender, EventArgs e)
        {
            assemblyValidationProvider.Validate((Control)sender);
        }

        private void assemblyGroupValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (assemblyValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void assemblyValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }
        
        #endregion
    }
}