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
using System.Globalization;
using System.Threading;

namespace ERP_NEW.GUI.Classifiers
{
    public partial class PeriodsFm : DevExpress.XtraEditors.XtraForm
    {
        private IPeriodService periodService;

        private BindingSource periodBS = new BindingSource();
        private UserTasksDTO _userTasksDTO;

        public PeriodsFm(UserTasksDTO userTasksDTO)
        {
            
            InitializeComponent();

            LoadDataPeriod();

            _userTasksDTO = userTasksDTO;
            AuthorizatedUserAccess();

        }

        #region Method's                                             

        private void AuthorizatedUserAccess()
        {
            periodGrid.Enabled = (_userTasksDTO.AccessRightId == 2);
        }

        private void LoadDataPeriod()
        {
            splashScreenManager.ShowWaitForm();

            periodService = Program.kernel.Get<IPeriodService>();
            periodBS.DataSource = periodService.GetAllPeriods();
            periodGrid.DataSource = periodBS;

            splashScreenManager.CloseWaitForm();
        }

        private void UpdateData()
        {

            periodService = Program.kernel.Get<IPeriodService>();

            periodGridView.BeginDataUpdate();

            periodService.PeriodsUpdate((PeriodsDTO)periodBS.Current);

            periodGridView.EndDataUpdate();

        }
        
        #endregion

        #region Event's                                              
        
        private void stateRepository_CheckedChanged(object sender, EventArgs e)
        {
            periodGridView.PostEditor();
            periodBS.EndEdit();

            string fullMonthName = new DateTime(((PeriodsDTO)periodBS.Current).Year, ((PeriodsDTO)periodBS.Current).Month, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("uk"));

            if (periodBS.Count != 0)
            {
                if (((PeriodsDTO)periodBS.Current).State )
                {
                    if (MessageBox.Show("Вы впевнені що хочете відкрити бухгалтерський період за " + fullMonthName + " у " + ((PeriodsDTO)periodBS.Current).Year + " році?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        UpdateData();
                    else
                        LoadDataPeriod();
                }
                else
                {
                    if (MessageBox.Show("Вы впевнені що хочете закрити бухгалтерський період за " + fullMonthName + " у " + ((PeriodsDTO)periodBS.Current).Year + " році?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        UpdateData();
                    else
                        LoadDataPeriod();              
                }
            } 
        }

        private void stateBankRepository_CheckedChanged(object sender, EventArgs e)
        {
            periodGridView.PostEditor();
            periodBS.EndEdit();

            string fullMonthName = new DateTime(((PeriodsDTO)periodBS.Current).Year, ((PeriodsDTO)periodBS.Current).Month, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("uk"));

            if (periodBS.Count != 0)
            {
                if (((PeriodsDTO)periodBS.Current).StateBank)
                {
                    if (MessageBox.Show("Вы впевнені що хочете відкрити банківський період за " + fullMonthName + " у " + ((PeriodsDTO)periodBS.Current).Year + " році?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        UpdateData();
                    else
                        LoadDataPeriod();
                }
                else
                {
                    if (MessageBox.Show("Вы впевнені що хочете закрити банківський період за " + fullMonthName + " у " + ((PeriodsDTO)periodBS.Current).Year + " році?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        UpdateData();
                    else
                        LoadDataPeriod();
                }
            } 
        }

        private void stateBusinesTripRepository_CheckedChanged(object sender, EventArgs e)
        {
            periodGridView.PostEditor();
            periodBS.EndEdit();

            string fullMonthName = new DateTime(((PeriodsDTO)periodBS.Current).Year, ((PeriodsDTO)periodBS.Current).Month, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("uk"));

            if (periodBS.Count != 0)
            {
                if (((PeriodsDTO)periodBS.Current).StateBusinesTrip)
                {
                    if (MessageBox.Show("Вы впевнені що хочете відкрити період відряджень за " + fullMonthName + " у " + ((PeriodsDTO)periodBS.Current).Year + " році?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        UpdateData();
                    else
                        LoadDataPeriod();
                }
                else
                {
                    if (MessageBox.Show("Вы впевнені що хочете закрити банківський період відряджень за " + fullMonthName + " у " + ((PeriodsDTO)periodBS.Current).Year + " році?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        UpdateData();
                    else
                        LoadDataPeriod();
                }
            } 
        }

        private void stateTaxInvoicesRepository_CheckedChanged(object sender, EventArgs e)
        {
            periodGridView.PostEditor();
            periodBS.EndEdit();

            string fullMonthName = new DateTime(((PeriodsDTO)periodBS.Current).Year, ((PeriodsDTO)periodBS.Current).Month, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("uk"));

            if (periodBS.Count != 0)
            {
                if (((PeriodsDTO)periodBS.Current).StateTaxInvoices)
                {
                    if (MessageBox.Show("Вы впевнені що хочете відкрити період налогових за " + fullMonthName + " у " + ((PeriodsDTO)periodBS.Current).Year + " році?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        UpdateData();
                    else
                        LoadDataPeriod();
                }
                else
                {
                    if (MessageBox.Show("Вы впевнені що хочете закрити налоговий період  за " + fullMonthName + " у " + ((PeriodsDTO)periodBS.Current).Year + " році?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        UpdateData();
                    else
                        LoadDataPeriod();
                }
            } 
        }

        private void periodGridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Column.Name == "stateCol")
            {
                var cellValue = periodGridView.GetRowCellValue(e.RowHandle, stateCol);

                if ((cellValue != null) && ((bool)cellValue))
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                    e.Appearance.BackColor2 = Color.Tomato;
                }
                else
                {
                    e.Appearance.BackColor = Color.LimeGreen;
                    e.Appearance.BackColor = Color.PaleGreen;
                }
            }


            if (e.RowHandle >= 0 && e.Column.Name == "stateBankCol")
            {
                var cellValue = periodGridView.GetRowCellValue(e.RowHandle, stateBankCol);

                if ((cellValue != null) && ((bool)cellValue))
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                    e.Appearance.BackColor2 = Color.Tomato;
                }
                else
                {
                    e.Appearance.BackColor = Color.LimeGreen;
                    e.Appearance.BackColor = Color.PaleGreen;
                }
            }

            if (e.RowHandle >= 0 && e.Column.Name == "stateBusinestripCol")
            {
                var cellValue = periodGridView.GetRowCellValue(e.RowHandle, stateBusinestripCol);

                if ((cellValue != null) && ((bool)cellValue))
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                    e.Appearance.BackColor2 = Color.Tomato;
                }
                else
                {
                    e.Appearance.BackColor = Color.LimeGreen;
                    e.Appearance.BackColor = Color.PaleGreen;
                }
            }

            if (e.RowHandle >= 0 && e.Column.Name == "stateTaxInvoicesCol")
            {
                var cellValue = periodGridView.GetRowCellValue(e.RowHandle, stateTaxInvoicesCol);

                if ((cellValue != null) && ((bool)cellValue))
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                    e.Appearance.BackColor2 = Color.Tomato;
                }
                else
                {
                    e.Appearance.BackColor = Color.LimeGreen;
                    e.Appearance.BackColor = Color.PaleGreen;
                }
            }
        }

        #endregion

        

        

    }
}