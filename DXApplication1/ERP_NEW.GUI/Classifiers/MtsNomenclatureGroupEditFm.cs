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

namespace ERP_NEW.GUI.Classifiers
{
    public partial class MtsNomenclatureGroupEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IMtsNomenclaturesService mtsNomenclaturesService;
        private BindingSource unitsAdditCalculationBS = new BindingSource();
        private BindingSource mtsNomenclatureGroupsBS = new BindingSource();
        private Utils.Operation operation;
        
        private ObjectBase Item
        {
            get { return mtsNomenclatureGroupsBS.Current as ObjectBase; }
            set
            {
               mtsNomenclatureGroupsBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public MtsNomenclatureGroupEditFm(Utils.Operation operation, MtsNomenclatureGroupsDTO model)
        {
            InitializeComponent();
            LoadData();
            
            this.operation = operation;
            mtsNomenclatureGroupsBS.DataSource = Item = model;

            nameTBox.DataBindings.Add("EditValue", mtsNomenclatureGroupsBS, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            ratioOfWasteTBox.DataBindings.Add("EditValue", mtsNomenclatureGroupsBS, "RatioOfWaste", true);

            unitsEdit.Properties.DataSource = unitsAdditCalculationBS;
            unitsEdit.Properties.ValueMember = "Id";
            unitsEdit.Properties.DisplayMember = "AdditUnitLocalName";
            unitsEdit.Properties.NullText = "Немає данних";

            if (this.operation == Utils.Operation.Update)
            {
                unitsEdit.EditValue = ((MtsNomenclatureGroupsDTO)Item).MtsAdditCalculationId;
                
                if (((MtsNomenclatureGroupsDTO)Item).AdditCalculationActive == 1)
                {
                    additCalculationActiveCheck.CheckState = CheckState.Checked;
                    unitsEdit.Enabled = true;
                }
            }
            else
            {
                model.RatioOfWaste = 0.000m;
                Item = model;
                unitsEdit.EditValue = null;
            }
            nameTBox.Focus();
            nomenclatureGroupValidationProvider.Validate();
        }

    
        #region Event's

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveNomenclatureGroup();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();
            this.Close();
        }

        private void additCalculationActiveCheck_CheckStateChanged(object sender, EventArgs e)
        {
            CheckEdit edit = sender as CheckEdit;
            if (edit.CheckState == CheckState.Checked)
            {
                ((MtsNomenclatureGroupsDTO)Item).AdditCalculationActive = 1;
                unitsEdit.Enabled = true;
            }
            else
            {
                ((MtsNomenclatureGroupsDTO)Item).AdditCalculationActive = 0;
                unitsEdit.Enabled = false;
                unitsEdit.EditValue = null;
            }
        }

        #endregion

        #region Metod's

        private void LoadData()
        {
            mtsNomenclaturesService = Program.kernel.Get<IMtsNomenclaturesService>();

            unitsAdditCalculationBS.DataSource = mtsNomenclaturesService.GetAdditCalculationUnits();
        }

        public long Return()
        {
            return ((MtsNomenclatureGroupsDTO)Item).Id;
        }

        private void SaveNomenclatureGroup()
        {
            this.Item.EndEdit();

            if (((MtsNomenclatureGroupsDTO)Item).AdditCalculationActive == 1)
                ((MtsNomenclatureGroupsDTO)Item).MtsAdditCalculationId = ((MtsAdditCalculationsDTO)unitsEdit.GetSelectedDataRow()).Id;
            else
                ((MtsNomenclatureGroupsDTO)Item).MtsAdditCalculationId = null;

            if (this.operation == Utils.Operation.Add)
            {
                ((MtsNomenclatureGroupsDTO)Item).Id = mtsNomenclaturesService.NomenclarureGroupCreate((MtsNomenclatureGroupsDTO)mtsNomenclatureGroupsBS.Current);
            }
            else
            {
                mtsNomenclaturesService.NomenclarureGroupUpdate(((MtsNomenclatureGroupsDTO)mtsNomenclatureGroupsBS.Current));
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

        #region Validate event's

        private void nameTBox_TextChanged(object sender, EventArgs e)
        {
            nomenclatureGroupValidationProvider.Validate((Control)sender);
        }

        private void nomenclatureGroupValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (nomenclatureGroupValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void nomenclatureGroupValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;

        }
        #endregion

      
    }


}