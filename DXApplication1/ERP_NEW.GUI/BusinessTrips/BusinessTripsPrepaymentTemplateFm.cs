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
using Ninject;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class BusinessTripsPrepaymentTemplateFm : DevExpress.XtraEditors.XtraForm
    {
        private IBusinessTripsService businessTripsService;
        private IPeriodService periodService;

        private BindingSource prepaymentTemplateBS = new BindingSource();
        private BindingSource businessTripsBS = new BindingSource();
        private BindingSource prepaymentsBS = new BindingSource();

        private BusinessTripsPrepaymentJournalDTO _model;

        public BusinessTripsPrepaymentTemplateFm( BusinessTripsPrepaymentJournalDTO model)
        {
            InitializeComponent();

            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            _model = model;

            LoadDataByPeriod();
        }

        #region Method's                               

        private void LoadDataByPeriod()
        {
            splashScreenManager.ShowWaitForm();

            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            businessTripsBS.DataSource = businessTripsService.GetBusinessTripsPrepaymentJournalByPeriod(DateTime.MinValue, DateTime.MaxValue);
            businessTripsEdit.Properties.DataSource = businessTripsBS;
            businessTripsEdit.Properties.ValueMember = "BusinessTripsDetailsID";
            businessTripsEdit.Properties.DisplayMember = "Doc_Number";
            businessTripsEdit.Properties.NullText = "Немає данних";

            splashScreenManager.CloseWaitForm();
        }

        private bool SaveBusinessTripTemplate()
        {
            prepaymentsGridView.PostEditor();
            prepaymentsGridView.BeginDataUpdate();
            
            List<BusinessTripsPrepaymentDTO> list = (List<BusinessTripsPrepaymentDTO>)prepaymentsBS.DataSource;

            if (list.Any(m => m.Selected))
            {

                var updateList = list.Where(l => l.Selected).Select(item =>
                {
                    item.BusinessTripsDetailsID = _model.BusinessTripsDetailsID;
                    item.EmployeesID = _model.EmployeesID;
                    return item;
                }).ToList();

                foreach (var item in updateList)
                {
                    if (!CheckPeriodAccess(item.Doc_Date))
                    {
                        MessageBox.Show("Період закритий або не існує!", "Редагування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }

                businessTripsService.BusinessTripsPrepaymentCreateRange(updateList);

                prepaymentsGridView.EndDataUpdate();
                return true;
            }
            else
            {
                MessageBox.Show("Не вибрано жодного авансу!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                prepaymentsGridView.EndDataUpdate();
                return false;
            }
            
        }

        private void LoadPrepaymentDateByBTDId(int btdId)
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            prepaymentsBS.DataSource = businessTripsService.GetBusinessTripsPrepaymentList(btdId);
            prepaymentsGrid.DataSource = prepaymentsBS;
        }

        private bool CheckPeriodAccess(DateTime currentDate)
        {
            periodService = Program.kernel.Get<IPeriodService>();

            return periodService.GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month && p.StateBusinesTrip);
        }

        #endregion

        #region Event's                                

        private void businessTripsEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (businessTripsEdit.EditValue != null)
                LoadPrepaymentDateByBTDId((int)businessTripsEdit.EditValue);

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveBusinessTripTemplate())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        

    }
}