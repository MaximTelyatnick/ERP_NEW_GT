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
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.Interfaces;
using Ninject;
using System.Web;

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class BusinessTripsPurposeEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IBusinessTripsService businessTripsService;
        private UserTasksDTO _userTasksDTO;
        private Utils.Operation _operation;
        private BindingSource purposeBS = new BindingSource();

        private ObjectBase Item
        {
            get { return purposeBS.Current as ObjectBase; }
            set
            {
                purposeBS.DataSource = value;

                value.BeginEdit();
            }
        }

        public BusinessTripsPurposeEditFm(Utils.Operation operation, BusinessTripsPurposeDTO model)
        {
            InitializeComponent();
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            purposeBS.DataSource = businessTripsService.GetBusinessTripsPurpose();
            _operation = operation;
            purposeBS.DataSource = Item = model;

            purposeEdit.DataBindings.Add("EditValue", purposeBS, "Purpose");

            if (_operation == Utils.Operation.Update)
            {
                purposeEdit.EditValue = ((BusinessTripsPurposeDTO)Item).Purpose;
            }
            else
            {
                purposeEdit.EditValue = null;
                Item = model;
               
            }
        }

        private bool FindDublicate(BusinessTripsPurposeDTO model)
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            return businessTripsService.GetBusinessTripsPurpose().Any(s => s.Purpose == model.Purpose && s.PurposeID != model.PurposeID);
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            if (FindDublicate((BusinessTripsPurposeDTO)this.Item))
            {
                MessageBox.Show("Така мета вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                if (_operation == Utils.Operation.Add)
                {
                    ((BusinessTripsPurposeDTO)Item).PurposeID = businessTripsService.BusinessTripsPurposeCreate((BusinessTripsPurposeDTO)Item);
                    return true;
                }
                else
                {
                   
                    businessTripsService.BusinessTripsPurposeUpdate((BusinessTripsPurposeDTO)Item);
                    return true;
                }

            }
        }

        public long Return()
        {
            return ((BusinessTripsPurposeDTO)Item).PurposeID;
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
                }

            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}