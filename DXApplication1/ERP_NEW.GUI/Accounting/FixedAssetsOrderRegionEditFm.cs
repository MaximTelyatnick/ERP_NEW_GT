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
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;

namespace ERP_NEW.GUI.Accounting
{
    public partial class FixedAssetsOrderRegionEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IFixedAssetsOrderService fixedassetsOrderService;
        private BindingSource regionBS = new BindingSource();
        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return regionBS.Current as ObjectBase; }
            set
            {
                regionBS.DataSource = value;
                value.BeginEdit();
            }
        }
        public FixedAssetsOrderRegionEditFm(Utils.Operation operation, RegionDTO model)
        {
            InitializeComponent();

            this.operation = operation;
            regionBS.DataSource = Item = model;

            nameEdit.DataBindings.Add("EditValue", regionBS, "Name");
            typeEdit.DataBindings.Add("EditValue", regionBS, "Type");
            descriptionEdit.DataBindings.Add("EditValue", regionBS, "Description");
            //fixedAssetsGroupNameEdit.DataBindings.Add("EditValue", groupBS, "AmortizationFactor");
            //fixedAssetsGroupNameEdit.DataBindings.Add("EditValue", groupBS, "UsefulPeriod");
            dxValidationProvider.Validate();
            //fixedAssetsGroupValidationProvider.Validate();
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();

            fixedassetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();

            if (operation == Utils.Operation.Add)
            {
                ((RegionDTO)Item).Id = fixedassetsOrderService.RegionCreate((RegionDTO)Item);
            }
            else
            {
                fixedassetsOrderService.RegionUpdate((RegionDTO)Item);
            }
            return true;
        }

        public long Return()
        {
            return ((RegionDTO)Item).Id;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveItem())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        // MessageBox.Show("Не вірний номер податкової.Такий номер вже існує.", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //numberAccountingEdit.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);

            this.validateLbl.Visible = !isValidate;
            this.saveBtn.Enabled = isValidate;
        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void nameEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }
    }
}