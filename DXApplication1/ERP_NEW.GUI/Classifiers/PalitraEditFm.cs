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

namespace ERP_NEW.GUI.Classifiers
{
    public partial class PalitraEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IInfrastructureService infrastructureService;

       // private short peremen;
        private BindingSource colorsBS = new BindingSource();

        private Utils.Operation operation;
        private ObjectBase model;

        private ObjectBase Item
        {
            get { return colorsBS.Current as ObjectBase; }
            set
            {
                colorsBS.DataSource = value;
                value.BeginEdit();
            }
        }
        public PalitraEditFm(Utils.Operation operation, ColorsDTO model)
        {
            InitializeComponent();
            this.operation = operation;
            colorsBS.DataSource = Item = model;
            colorNameEdit.DataBindings.Add("EditValue", colorsBS, "Name_Rus");
            colorEdit.DataBindings.Add("EditValue", colorsBS, "Name");
           // dxValidationProvider.Validate();
        }

        #region Method's


        //string ArgbToHexColor(System.Drawing.Color color)
        //{
        //    return string.Concat("#", (color.ToArgb() & 0x00FFFFFFFF).ToString("X8"));

        //}

        private bool FindDublicate(ColorsDTO model)
        {
            infrastructureService = Program.kernel.Get<IInfrastructureService>();
            return infrastructureService.GetColorsAll().Any(s => s.Color_Code == model.Color_Code && s.Id != model.Id);
        }

        private bool SaveColors()
        {
            this.Item.EndEdit();

            infrastructureService = Program.kernel.Get<IInfrastructureService>();


            if (operation == Utils.Operation.Add)
            {
                ((ColorsDTO)Item).Color_Code = ColorTranslator.ToHtml(Color.FromArgb(colorEdit.Color.ToArgb()));
                if (FindDublicate((ColorsDTO)this.Item))
                {
                    MessageBox.Show("Такий колір в базі вже існує", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    colorNameEdit.Text = " ";
                    colorNameEdit.EditValue = " ";
                    return false;
                }
                else
                infrastructureService.ColorsCreate((ColorsDTO)Item);
            }
            else
            {
                ((ColorsDTO)Item).Color_Code = ColorTranslator.ToHtml(Color.FromArgb(colorEdit.Color.ToArgb()));         
                infrastructureService.ColorsUpdate((ColorsDTO)Item);
            }
            return true;
        }
        public ColorsDTO Return()
        {
            return (ColorsDTO)Item;
        }

        #endregion

        #region Event's
        private void saveBtn_Click(object sender, EventArgs e)
        {
           // if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          //  {
                if (SaveColors())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                    //MessageBox.Show("Збережено!", "Підтвердження",MessageBoxButtons.OK);
                    MessageBox.Show("Збережено!", "Сповіщення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
         //   }
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
           // this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

        private void colorEdit_TextChanged(object sender, EventArgs e)
        {
  
            
        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void colorNameEdit_EditValueChanged(object sender, EventArgs e)
        {
                      
            dxValidationProvider.Validate((Control)sender);
        }

        private void colorEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void colorEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
           
        }
        //private bool FindDublicate(ProfessionsDTO model)
        //{
        //    return employeesService.GetProfessions().Any(s => s.Name.Trim() == model.Name.Trim());
        //}



    }
}