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
using ERP_NEW.BLL.Interfaces;
using Ninject;

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class BusinessTripsPaymentSelectAccountEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IAccountsService accountsService;
        private IBusinessTripsService businessTripsService;

        private List<BusinessTripsPaymentDTO> payments = new List<BusinessTripsPaymentDTO>();

        public BusinessTripsPaymentSelectAccountEditFm(List<BusinessTripsPaymentDTO> payments)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            this.payments = payments;

            LoadData();

            splashScreenManager.CloseWaitForm();
        }

        private void LoadData()
        {
            accountsService = Program.kernel.Get<IAccountsService>();
            accountEdit.Properties.DataSource = accountsService.GetAccounts();
            accountEdit.Properties.ValueMember = "Id";
            accountEdit.Properties.DisplayMember = "Num";
            accountEdit.Properties.NullText = "Немає данних";
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
                    MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private bool SaveItem()
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            int accountId = ((AccountsDTO)accountEdit.GetSelectedDataRow()).Id;


            foreach (var item in payments)
            {
                item.AccountsID = accountId;
                businessTripsService.BusinessTripsPaymentUpdate(item);
            }


            return true;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}