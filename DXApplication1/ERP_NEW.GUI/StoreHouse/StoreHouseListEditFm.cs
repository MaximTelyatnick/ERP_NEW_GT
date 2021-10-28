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

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class StoreHouseListEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;

        private BindingSource storeHouseListBS = new BindingSource();

        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return storeHouseListBS.Current as ObjectBase; }
            set
            {
                storeHouseListBS.DataSource = value;
                value.BeginEdit();
            }
        }




        public StoreHouseListEditFm(Utils.Operation operation, StorehousesDTO model)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            _operation = operation;

            storeHouseListBS.DataSource = Item = model;


            numberStoreHouseEdit.DataBindings.Add("EditValue", storeHouseListBS, "Num");

            nameStoreHouseEdit.DataBindings.Add("EditValue", storeHouseListBS, "Name");

            descriptionStoreHouseEdit.DataBindings.Add("EditValue", storeHouseListBS, "Note");


            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            

            splashScreenManager.CloseWaitForm();

            storeHousesValidationProvider.Validate();

        }


        private bool SaveItem()
        {
            this.Item.EndEdit();

            if (FindDublicate((StorehousesDTO)this.Item))
            {
                MessageBox.Show("Номер складу з таким номером вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            try
            {
                storeHouseService = Program.kernel.Get<IStoreHouseService>();


                if (_operation == Utils.Operation.Add)
                {
                    storeHouseService.StoreHousesCreate((StorehousesDTO)Item);

                    return true;
                }
                else
                {
                    storeHouseService.StoreHousesUpdate((StorehousesDTO)Item);

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public StorehousesDTO Return()
        {
            return ((StorehousesDTO)Item);
        }

        private bool FindDublicate(StorehousesDTO model)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            return storeHouseService.GetAllStorehouses().Any(s => s.Num == model.Num && s.Id != model.Id);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveItem())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void numberStoreHouseEdit_TextChanged(object sender, EventArgs e)
        {
            storeHousesValidationProvider.Validate((Control)sender);
        }

        private void nameStoreHouseEdit_TextChanged(object sender, EventArgs e)
        {
            storeHousesValidationProvider.Validate((Control)sender);
        }

        private void storeHousesValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void storeHousesValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (storeHousesValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

       
    }
}