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

namespace ERP_NEW.GUI.Classifiers
{
    public partial class WeldWpsEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IWeldStampsService weldStampsService;
        
        private BindingSource weldWpsBS = new BindingSource();
        
        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return weldWpsBS.Current as ObjectBase; }
            set
            {
                weldWpsBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public WeldWpsEditFm(Utils.Operation operation, WeldWpsDTO weldWps)
        {
            InitializeComponent();

            this.operation = operation;
            weldWpsBS.DataSource = Item = weldWps;

            wireDiameterEdit.DataBindings.Add("EditValue", weldWpsBS, "WireDiameter");
            seamSizeZEdit.DataBindings.Add("EditValue", weldWpsBS, "SeamSizeZ");
            seamSizeAEdit.DataBindings.Add("EditValue", weldWpsBS, "SeamSizeA");
            wpqrEdit.DataBindings.Add("EditValue", weldWpsBS, "Wpqr");
            wpsEdit.DataBindings.Add("EditValue", weldWpsBS, "Wps");
            layerMarkEdit.DataBindings.Add("EditValue", weldWpsBS, "LayerMark");
            materialThicknessEdit.DataBindings.Add("EditValue", weldWpsBS, "MaterialThickness");

            connectionTypeLookUpEdit.Properties.DataSource = Enum.GetValues(typeof(Utils.ConnectionType));
            connectionTypeLookUpEdit.Properties.ValueMember = "Column";
            connectionTypeLookUpEdit.DataBindings.Add("EditValue", weldWpsBS, "EnumConnectionType");

            weldPositionLookUpEdit.Properties.DataSource = Enum.GetValues(typeof(Utils.WeldPosition));
            weldPositionLookUpEdit.Properties.ValueMember = "Column";
            weldPositionLookUpEdit.DataBindings.Add("EditValue", weldWpsBS, "EnumWeldPosition");
                       
        }

        private void SaveWps()
        {
            ((WeldWpsDTO)Item).ConnectionType = ((WeldWpsDTO)Item).EnumConnectionType.ToString();
            ((WeldWpsDTO)Item).WeldPosition = ((WeldWpsDTO)Item).EnumWeldPosition.ToString();

            this.Item.EndEdit();
            
            weldStampsService = Program.kernel.Get<IWeldStampsService>();

            if (this.operation == Utils.Operation.Add)
                ((WeldWpsDTO)Item).Id = weldStampsService.CreateWeldWps((WeldWpsDTO)Item);
            else
                weldStampsService.UpdateWeldWps((WeldWpsDTO)Item);        
        }

        public int Return()
        {
            return ((WeldWpsDTO)Item).Id;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveWps();

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}