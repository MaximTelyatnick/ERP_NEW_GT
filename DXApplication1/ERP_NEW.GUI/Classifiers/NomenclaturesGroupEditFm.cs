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

namespace ERP_NEW.GUI.Classifiers
{
    public partial class NomenclaturesGroupEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;

        private BindingSource nomenclatureGroupsBS = new BindingSource();

        private Utils.Operation _operation;
        
        private ObjectBase Item
        {
            get { return nomenclatureGroupsBS.Current as ObjectBase; }
            set
            {
                nomenclatureGroupsBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public NomenclaturesGroupEditFm(Utils.Operation operation, NomenclatureGroupsDTO model)
        {
            InitializeComponent();

            _operation = operation;

            nomenclatureGroupsBS.DataSource = Item = model;

            nameEdit.DataBindings.Add("EditValue", nomenclatureGroupsBS, "Name");

            if (_operation == Utils.Operation.Custom)
                ((NomenclatureGroupsDTO)Item).Name = "";

        }

        #region Method's                                       

        private bool SaveItem()
        {
            this.Item.EndEdit();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            switch (_operation)
            {
                case Utils.Operation.Add:
                    ((NomenclatureGroupsDTO)Item).Name = (string)nameEdit.EditValue;
                    ((NomenclatureGroupsDTO)Item).Parent_Id = null;
                    storeHouseService.NomenclatureGroupCreate(((NomenclatureGroupsDTO)Item));
                    break;
                case Utils.Operation.Custom:
                    ((NomenclatureGroupsDTO)Item).Name = (string)nameEdit.EditValue;
                    ((NomenclatureGroupsDTO)Item).Parent_Id = ((NomenclatureGroupsDTO)Item).Id;
                    storeHouseService.NomenclatureGroupCreate(((NomenclatureGroupsDTO)Item));
                    break;
                case Utils.Operation.Update:
                    ((NomenclatureGroupsDTO)Item).Name = nameEdit.Text;
                    storeHouseService.NomenclatureGroupUpdate(((NomenclatureGroupsDTO)Item));
                    break;
                default:
                    MessageBox.Show("Не вірні параметри виклику!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            return true;
        }

        public NomenclatureGroupsDTO Return()
        {
            return ((NomenclatureGroupsDTO)Item);
        }



        #endregion

        #region Event's                                        

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

        #endregion

        #region Validation                                     

        private void validationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void validationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (validationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void nameEdit_EditValueChanged(object sender, EventArgs e)
        {
            validationProvider.Validate((Control)sender);
        }

        #endregion
    }
}