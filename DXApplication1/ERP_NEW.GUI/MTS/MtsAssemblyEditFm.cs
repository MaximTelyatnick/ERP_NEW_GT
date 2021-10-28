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
using ERP_NEW.GUI.Contractors;
using ERP_NEW.GUI.Classifiers;

namespace ERP_NEW.GUI.MTS
{
    public partial class MtsAssemblyEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IMtsSpecificationsService mtsSpecificationsService;
        private IEmployeesService employeesService;
        private IContractorsService contractorsService;
        private ICityService cityService;

        private BindingSource mtsAssembliesBS = new BindingSource();
        private BindingSource employeesBS = new BindingSource();
        private BindingSource contractorsBS = new BindingSource();
        private BindingSource citiesBS = new BindingSource();

        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return mtsAssembliesBS.Current as ObjectBase; }
            set
            {
                mtsAssembliesBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public MtsAssemblyEditFm(Utils.Operation operation, MtsAssembliesDTO model)
        {
            InitializeComponent();
            
            LoadData();

            this.operation = operation;
            mtsAssembliesBS.DataSource = Item = model;

            nameTBox.DataBindings.Add("EditValue", mtsAssembliesBS, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            drawingTBox.DataBindings.Add("EditValue", mtsAssembliesBS, "Drawing", true, DataSourceUpdateMode.OnPropertyChanged);
            descriptionTBox.DataBindings.Add("EditValue", mtsAssembliesBS, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            dateCreatedEdit.DataBindings.Add("EditValue", mtsAssembliesBS, "DateCreated", true, DataSourceUpdateMode.OnPropertyChanged);

            designerEdit.DataBindings.Add("EditValue", mtsAssembliesBS, "DesignerId", true, DataSourceUpdateMode.OnPropertyChanged);
            designerEdit.Properties.DataSource = employeesBS;
            designerEdit.Properties.ValueMember = "EmployeeID";
            designerEdit.Properties.DisplayMember = "Fio";
            designerEdit.Properties.NullText = "Немає данних";

            contractorsEdit.DataBindings.Add("EditValue", mtsAssembliesBS, "ContractorId", true, DataSourceUpdateMode.OnPropertyChanged);
            contractorsEdit.Properties.DataSource = contractorsBS;
            contractorsEdit.Properties.ValueMember = "Id";
            contractorsEdit.Properties.DisplayMember = "Name";
            contractorsEdit.Properties.NullText = "Немає данних";

            destinationEdit.DataBindings.Add("EditValue", mtsAssembliesBS, "CityId", true, DataSourceUpdateMode.OnPropertyChanged);
            destinationEdit.Properties.DataSource = citiesBS;
            destinationEdit.Properties.ValueMember = "Id";
            destinationEdit.Properties.DisplayMember = "FullName_UA";
            destinationEdit.Properties.NullText = "Немає данних";

            if (this.operation == Utils.Operation.Add)
            {
                designerEdit.EditValue = null;
                ((MtsAssembliesDTO)Item).DateCreated = DateTime.Now;
            }
            else
            {
                designerEdit.EditValue = ((MtsAssembliesDTO)Item).DesignerId;
            }

            drawingTBox.Focus();
            assemblyValidationProvider.Validate();
        }

     
        #region Metod's

        private void LoadData()
        {
            splashScreenManager.ShowWaitForm();
            
            mtsSpecificationsService = Program.kernel.Get<IMtsSpecificationsService>();
            cityService = Program.kernel.Get<ICityService>();
            employeesService = Program.kernel.Get<IEmployeesService>();
            contractorsService = Program.kernel.Get<IContractorsService>();

            citiesBS.DataSource = cityService.GetCities();
            contractorsBS.DataSource = contractorsService.GetContractors(2); // 1 - все данные, 2 - только контрагенты без договоров, 3 - только договора
            employeesBS.DataSource = employeesService.GetEmployeesWorking();

            splashScreenManager.CloseWaitForm();
        }

        public long Return()
        {
            return ((MtsAssembliesDTO)Item).Id;
        }

        private bool FindDublicate(MtsAssembliesDTO model)
        {
            mtsSpecificationsService = Program.kernel.Get<IMtsSpecificationsService>();
            return mtsSpecificationsService.GetMtsAssemblies(DateTime.MinValue, DateTime.MaxValue).Any(a => a.Drawing == model.Drawing && a.AssemblyId != model.Id);
        }

        private bool SaveAssembly()
        {
            this.Item.EndEdit();
            
            try
            {
                ((MtsAssembliesDTO)Item).UserId = UserService.AuthorizatedUser.UserId;

                if (this.operation == Utils.Operation.Add)
                {
                    ((MtsAssembliesDTO)Item).AssemblyStatus = 1;
                    ((MtsAssembliesDTO)Item).Id = mtsSpecificationsService.CreateAssembly((MtsAssembliesDTO)mtsAssembliesBS.Current);

                    MtsSpecificationsTestDTO model = new MtsSpecificationsTestDTO()
                    {
                        ParentId = null,
                        AssemblyId = ((MtsAssembliesDTO)Item).Id,
                        DateAdded = DateTime.Now,
                        Quantity = 1,
                        UserId = ((MtsAssembliesDTO)Item).UserId
                    };

                    long idSpec = mtsSpecificationsService.CreateSpecification(model);
                    model.Id = idSpec;
                    model.RootId = idSpec;
                    mtsSpecificationsService.UpdateSpecification(model);
                }
                else
                {
                    mtsSpecificationsService.UpdateAssembly(((MtsAssembliesDTO)Item));
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion

        #region Validate event's

        private void drawingTBox_TextChanged(object sender, EventArgs e)
        {
            assemblyValidationProvider.Validate((Control)sender);
        }

        private void nameTBox_TextChanged(object sender, EventArgs e)
        {
            assemblyValidationProvider.Validate((Control)sender);
        }

        private void designerEdit_EditValueChanged(object sender, EventArgs e)
        {
            assemblyValidationProvider.Validate((Control)sender);
        }

        private void dateCreatedEdit_EditValueChanged(object sender, EventArgs e)
        {
            assemblyValidationProvider.Validate((Control)sender);
        }
       
        private void assemblyValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (assemblyValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void assemblyValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;

        }
        #endregion

        #region  Events

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();

            if (FindDublicate((MtsAssembliesDTO)this.Item))
            {
                MessageBox.Show("Проект з таким номером вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveAssembly())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
                
        private void contractorsEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Добавить
                    {
                        using (ContractorEditFm contractorEditFm = new ContractorEditFm(Utils.Operation.Add, new ContractorsDTO()))
                        {
                            if (contractorEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = contractorEditFm.Return();
                                contractorsService = Program.kernel.Get<IContractorsService>();
                                contractorsEdit.Properties.DataSource = contractorsService.GetContractors(2);
                                contractorsEdit.EditValue = return_Id;
                            }
                        }
                        
                        break;
                    }
                case 2: //Очистить
                    {
                        contractorsEdit.EditValue = null;
                        contractorsEdit.Properties.NullText = "Немає данних";
                        
                        break;
                    }
            }
        }

        private void destinationEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (CityEditFm cityEditFm = new CityEditFm(Utils.Operation.Add, new CityDTO()))
                        {
                            if (cityEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = cityEditFm.Return();
                                cityService = Program.kernel.Get<ICityService>();
                                destinationEdit.Properties.DataSource = cityService.GetCities();
                                destinationEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 2://Редагувати
                    {
                        if (destinationEdit.EditValue == DBNull.Value)
                            return;

                        using (CityEditFm cityEditFm = new CityEditFm(Utils.Operation.Update, (CityDTO)destinationEdit.GetSelectedDataRow()))
                        {
                            if (cityEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = cityEditFm.Return();
                                cityService = Program.kernel.Get<ICityService>();
                                destinationEdit.Properties.DataSource = cityService.GetCities();
                                destinationEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 3: //Очистить
                    {
                        destinationEdit.EditValue = null;
                        destinationEdit.Properties.NullText = "Немає данних";

                        break;
                    }
            }
        }
                       
        #endregion

    }
}