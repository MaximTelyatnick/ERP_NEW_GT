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
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using Ninject;

namespace ERP_NEW.GUI.Classifiers
{
    public partial class EmployeesEditDetailsFm : DevExpress.XtraEditors.XtraForm
    {
        private IEmployeesService employeesService;

        private EmployeesInfoDTO model;

        public EmployeesEditDetailsFm(EmployeesInfoDTO model)
        {
            InitializeComponent();
            this.model = model;
            dateEndJobEdit.EditValue = DateTime.Now;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дата звільнення працівника " +(dateEndJobEdit.DateTime.ToShortDateString()) + " ?", "Збереження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dateEndJobEdit.EditValue == null)
                {
                    MessageBox.Show("Необхідно вказати дату звільнення працівника", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                employeesService = Program.kernel.Get<IEmployeesService>();

                try
                {
                    EmployeesDTO employeesUpdateDTO = new EmployeesDTO();
                    employeesUpdateDTO.EmployeeID = (int)model.EmployeeID;
                    employeesUpdateDTO.AccountNumber = (int)model.AccountNumber;
                    employeesUpdateDTO.Engaged = model.DateBegin;
                    employeesUpdateDTO.Fired = dateEndJobEdit.DateTime;

                    employeesService.EmployeesUpdate(employeesUpdateDTO);

                    EmployeesDetailsDTO employeesDetailsUpdateDTO = new EmployeesDetailsDTO();
                    employeesDetailsUpdateDTO.RecordID = model.RecordID;
                    employeesDetailsUpdateDTO.LastName = model.LastName;
                    employeesDetailsUpdateDTO.FirstName = model.FirstName;
                    employeesDetailsUpdateDTO.MiddleName = model.SecondName;
                    employeesDetailsUpdateDTO.EmployeeID = model.EmployeeID;
                    employeesDetailsUpdateDTO.StartDate = model.DateBegin;
                    employeesDetailsUpdateDTO.EndDate = dateEndJobEdit.DateTime;
                    employeesDetailsUpdateDTO.DepartmentID = (int)model.DepartmentID;
                    employeesDetailsUpdateDTO.ProfessionID = (int)model.ProfessionID;

                    employeesService.EmployeesDetailsUpdate(employeesDetailsUpdateDTO);

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При звыльненны співробітника виникла помилка "+ex.Message, "Виникла помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        public EmployeesInfoDTO Return()
        {
            return model;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}