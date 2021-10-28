using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using System;
using System.Collections;

using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Services;

using System.Collections.Generic;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;


namespace ERP_NEW.GUI.Production
{
    public partial class ProjectExetutersEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IEmployeesService employeesService;
        private IProjectDetailsService projectDetailsService;
        
        private BindingSource personsBS = new BindingSource();

        private List<EmployeesInfoOnlyWithWeldStampDTO> source;
        private ProjectDetailsDTO _model;
        
        public ProjectExetutersEditFm(ProjectDetailsDTO model)
        {
            InitializeComponent();

            _model = model;
            employeesService = Program.kernel.Get<IEmployeesService>();
            
            // 29 - группа "Виробництво СТО" 

            //source = employeesService.GetEmployeesWorking().Where(bdsm=>bdsm.ProfessionID == 170 || bdsm.ProfessionID == 110 || bdsm.ProfessionID == 99  || bdsm.ProfessionID == 95 ).ToList();

            source = employeesService.GetEmployeesWorkingWithWeldStamp().ToList();

            
            personsBS.DataSource = source;
            personsGrid.DataSource = personsBS;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var executorsList = source.Where(s => s.Checked == "1").Select(s => new ProjectDetailExecutorsDTO
            {
                EmployeeId = s.EmployeeId,
                ProjectDetailId = _model.ProjectDetailId
            }).ToList();

            if (executorsList.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Додати відповідальну особу?", "Збереження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        projectDetailsService = Program.kernel.Get<IProjectDetailsService>();

                        projectDetailsService.ProjectExecutorsUpdateRange(executorsList);
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при збереженні!\n" + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Не відмічено жодного робітника", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}