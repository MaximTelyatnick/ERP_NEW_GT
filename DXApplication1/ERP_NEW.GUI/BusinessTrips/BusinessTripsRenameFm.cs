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
using ERP_NEW.BLL.Services;
using ERP_NEW.BLL.DTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraEditors.Controls;
using Ninject;
using System.Web;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class BusinessTripsRenameFm : DevExpress.XtraEditors.XtraForm
    {
        private IBusinessTripsService businessTripsService;

        private BindingSource businessTripsBS = new BindingSource();

        private int returnModelId = 0;
        private int _bstdId;

        private ObjectBase Item
        {
            get { return businessTripsBS.Current as ObjectBase; }
            set
            {
                businessTripsBS.DataSource = value;
                value.BeginEdit();
            }
        }


        public BusinessTripsRenameFm(BusinessTripsDTO model, int bstdId)
        {
            InitializeComponent();

            businessTripsBS.DataSource = Item = model;
            _bstdId = bstdId;

            docNumberEdit.DataBindings.Add("EditValue", businessTripsBS, "Doc_Number");

            ControlValidation();
        }

        private bool FindDublicate(BusinessTripsDTO model)
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            return businessTripsService.GetBusinessTrips().Any(s => s.Doc_Number == model.Doc_Number && s.Doc_Date.Year == model.Doc_Date.Year);
        }

        public int Return()
        {
            return returnModelId;
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();

            try
            {
                businessTripsService = Program.kernel.Get<IBusinessTripsService>();

                if (FindDublicate((BusinessTripsDTO)Item))
                {
                    MessageBox.Show("Заявка з таким номером вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    int oldBSTId = ((BusinessTripsDTO)Item).ID;
                    returnModelId = businessTripsService.BusinessTripCreate((BusinessTripsDTO)Item);
                    
                    BusinessTripsDetailsDTO modelBusinessTripsDetails = businessTripsService.GetBusinessTripsDetailById(_bstdId);
                    modelBusinessTripsDetails.BusinessTripsID = returnModelId;

                    businessTripsService.BusinessTripsDetailsUpdate(modelBusinessTripsDetails);

                    businessTripsService.BusinessTripDelete(oldBSTId);
                    
                    return true;
                }
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
                    MessageBox.Show("При береженні заявки виникла помилка. " + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #region Validation
        
        private bool ControlValidation()
        {
            return renameValidationProvider.Validate();
        }

        private void renameValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
        }

        private void renameValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (renameValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
        }

        private void docNumberEdit_EditValueChanged(object sender, EventArgs e)
        {
            renameValidationProvider.Validate((Control)sender);
        }

        #endregion
    }
}