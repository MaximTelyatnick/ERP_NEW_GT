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
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using Ninject;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraEditors.Controls;
using ERP_NEW.GUI.Contractors;
using ERP_NEW.GUI.Classifiers;

namespace ERP_NEW.GUI.Marketing
{
    public partial class PackingListEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IPackingListsService packingListsService;
        private IEmployeesService employeesService;
        private ICityService cityService;
        private IContractorsService contractorsService;
        private IMtsSpecificationsService mtsSpecificationsService;
        
        private BindingSource packingBS = new BindingSource();
        private BindingSource packingDetailsBS = new BindingSource();
        private BindingSource responsiblePersonBS = new BindingSource();
        private BindingSource contractorsBS = new BindingSource();
        private BindingSource citiesBS = new BindingSource();


        private PackingListMaterialsDTO packingMaterialModelPack;
        private PackingListMaterialsDTO packingMaterialModelCompl;

        List<PackingListDetailDTO> packingListDetailsList = new List<PackingListDetailDTO>();
        List<PackingListDetailDTO> deletePackingListDetailsList = new List<PackingListDetailDTO>();

        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return packingBS.Current as ObjectBase; }
            set
            {
                packingBS.DataSource = value;
                value.BeginEdit();
            }
        }
        
        public PackingListEditFm(Utils.Operation operation, PackingListsDTO model)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            LoadData();

            this.operation = operation;

            packingBS.DataSource = Item = model;

            packingNumberTBox.DataBindings.Add("EditValue", packingBS, "PackingNumber");
            packingNumberPartTBox.DataBindings.Add("EditValue", packingBS, "PackingNumberPart");
            packingDateEdit.DataBindings.Add("EditValue", packingBS, "PackingDate");
            descriptionTBox.DataBindings.Add("EditValue", packingBS, "Description");
            descriptionProjectTBox.DataBindings.Add("EditValue", packingBS, "DescriptionProject");

            contractorsEdit.DataBindings.Add("EditValue", packingBS, "ContractorId", true, DataSourceUpdateMode.OnPropertyChanged);
            
            contractorsBS.DataSource = contractorsService.GetContractors(2);
            contractorsEdit.Properties.DataSource = contractorsBS;
            contractorsEdit.Properties.ValueMember = "Id";
            contractorsEdit.Properties.DisplayMember = "Name";
            contractorsEdit.Properties.NullText = "Немає данних";

            destinationEdit.DataBindings.Add("EditValue", packingBS, "CityId", true, DataSourceUpdateMode.OnPropertyChanged);
            citiesBS.DataSource = cityService.GetCities();
            destinationEdit.Properties.DataSource = citiesBS;
            destinationEdit.Properties.ValueMember = "Id";
            destinationEdit.Properties.DisplayMember = "FullName_UA";
            destinationEdit.Properties.NullText = "Немає данних";

            responsiblePersonEdit.DataBindings.Add("EditValue", packingBS, "ResponsiblePersonId", true, DataSourceUpdateMode.OnPropertyChanged);
            responsiblePersonBS.DataSource = employeesService.GetEmployeesWorking();
            responsiblePersonEdit.Properties.DataSource = responsiblePersonBS;
            responsiblePersonEdit.Properties.ValueMember = "EmployeeID";
            responsiblePersonEdit.Properties.DisplayMember = "Fio";
            responsiblePersonEdit.Properties.NullText = "Немає данних";

            switch (operation)
            {
                case Utils.Operation.Add:
                    ((PackingListsDTO)Item).PackingDate = DateTime.Now;
                    ((PackingListsDTO)Item).PackingNumber = GetLastNumber();
                    packingMaterialModelPack = new PackingListMaterialsDTO();
                    packingMaterialModelCompl = new PackingListMaterialsDTO();
                    break;

                case Utils.Operation.Update:
                    packingMaterialModelPack = new PackingListMaterialsDTO();
                    packingMaterialModelPack = packingListsService.GetPackingListMaterialsById(((PackingListsDTO)Item).PackingListMaterialsId);

                    if (packingMaterialModelPack != null)
                    {
                        int stratIndex = packingMaterialModelPack.FileName.IndexOf('.');
                        string typeFile = packingMaterialModelPack.FileName.Substring(stratIndex);

                        switch (typeFile)
                        {
                            case ".pdf":
                                pictureEdit.Image = imageCollection.Images[1];
                                pictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
                                break;
                            default:
                                pictureEdit.Image = imageCollection.Images[0];
                                pictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
                                break;
                        }

                        fileNameTbox.EditValue = packingMaterialModelPack.FileName;
                    }

                    packingMaterialModelCompl = new PackingListMaterialsDTO();
                    packingMaterialModelCompl = packingListsService.GetPackingListMaterialsById(((PackingListsDTO)Item).PackingListComplectId);

                    if (packingMaterialModelCompl != null)
                    {
                        int stratIndex = packingMaterialModelCompl.FileName.IndexOf('.');
                        string typeFile = packingMaterialModelCompl.FileName.Substring(stratIndex);

                        switch (typeFile)
                        {
                            case ".pdf":

                                pictureComplEdit.Image = imageCollection.Images[1];
                                pictureComplEdit.Properties.SizeMode = PictureSizeMode.Clip;
                                break;
                            default:
                                pictureComplEdit.Image = imageCollection.Images[0];
                                pictureComplEdit.Properties.SizeMode = PictureSizeMode.Clip;
                                break;
                        }

                        fileNameComplTbox.EditValue = packingMaterialModelCompl.FileName;
                    }

                    packingDetailsBS.DataSource = packingListsService.GetPackingListDetailId(((PackingListsDTO)Item).Id);
                    customerOrdersGrid.DataSource = packingDetailsBS;
                    packingListDetailsList = ((List<PackingListDetailDTO>)packingDetailsBS.DataSource);

                    break;
                    
                default:
                    MessageBox.Show("При завантаженні форми " + this.Text + " виникла помилка. ", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            packingValidationProvider.Validate();

            splashScreenManager.CloseWaitForm();
        }

        #region Method's                                    

        private void LoadData()
        {

            packingListsService = Program.kernel.Get<IPackingListsService>();
            employeesService = Program.kernel.Get<IEmployeesService>();
            mtsSpecificationsService = Program.kernel.Get<IMtsSpecificationsService>();
            cityService = Program.kernel.Get<ICityService>();
            contractorsService = Program.kernel.Get<IContractorsService>();
        }

        private string GetLastNumber()
        {
            var allNumberPackingLists = packingListsService.GetPackingLists().OrderByDescending(x => Decimal.
                Parse(x.PackingNumber.Replace('.', ','))).FirstOrDefault(x => x.PackingDate.Year == DateTime.Now.Year);

            if (allNumberPackingLists != null)
            {
                decimal lastNumberPackingLists = Decimal.Parse(allNumberPackingLists.PackingNumber.Replace('.', ','));
                allNumberPackingLists.PackingNumber = (Math.Truncate(lastNumberPackingLists) + 1).ToString();
                return allNumberPackingLists.PackingNumber;
            }
            else
            {
                return "1";
            }
        }

        public PackingListsDTO Return()
        {
            return (PackingListsDTO)Item;
        }

        private bool SavePackingList()
        {
            try
            {
                packingListsService = Program.kernel.Get<IPackingListsService>();

                if (FindDublicate((PackingListsDTO)this.Item))
                {
                    MessageBox.Show("Пакувальний лист з таким номером вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                switch (operation)
                {
                    case Utils.Operation.Add:

                        if (packingMaterialModelPack.Scan != null)
                            ((PackingListsDTO)Item).PackingListMaterialsId = packingListsService.PackingListMaterialsCreate(packingMaterialModelPack);
                        if (packingMaterialModelCompl.Scan != null)
                            ((PackingListsDTO)Item).PackingListComplectId = packingListsService.PackingListMaterialsCreate(packingMaterialModelCompl);

                        ((PackingListsDTO)Item).Id = packingListsService.PackingListCreate((PackingListsDTO)Item);

                        packingListDetailsList.Select(s => { s.PackingListId = ((PackingListsDTO)Item).Id; return s; }).ToList();

                        foreach (var item in packingListDetailsList)
                        {
                            if (item.Id == 0)
                                packingListsService.PackingListDetailsCreate(item);
                        }


                        break;
                    case Utils.Operation.Update:



                        if (packingMaterialModelPack != null)
                        {
                            if (packingMaterialModelPack.Scan == null && packingMaterialModelPack.Id > 0)
                            {
                                packingListsService.PackingListMaterialsDeleteById(packingMaterialModelPack.Id);
                                ((PackingListsDTO)Item).PackingListMaterialsId = null;
                                
                            }
                            else if (packingMaterialModelPack.Scan != null && packingMaterialModelPack.Id == 0)
                            {
                                ((PackingListsDTO)Item).PackingListMaterialsId = packingListsService.PackingListMaterialsCreate(packingMaterialModelPack);
                            }
                            else
                            {
                                packingListsService.PackingListMaterialsUpdate(packingMaterialModelPack);
                            }
                        }

                        if (packingMaterialModelCompl != null)
                        {
                            if (packingMaterialModelCompl.Scan == null && packingMaterialModelCompl.Id > 0)
                            {
                                packingListsService.PackingListMaterialsDeleteById(packingMaterialModelCompl.Id);
                                ((PackingListsDTO)Item).PackingListComplectId = null;
                            }
                            else if (packingMaterialModelCompl.Scan != null && packingMaterialModelCompl.Id == 0)
                            {
                                ((PackingListsDTO)Item).PackingListComplectId = packingListsService.PackingListMaterialsCreate(packingMaterialModelCompl);
                            }
                            else
                            {
                                packingListsService.PackingListMaterialsUpdate(packingMaterialModelCompl);
                            }
                        }

                        packingListsService.PackingListUpdate((PackingListsDTO)packingBS.Current);

                        packingListDetailsList.Select(s => { s.PackingListId = ((PackingListsDTO)Item).Id; return s; }).ToList();

                        foreach (var item in packingListDetailsList)
                        {
                            if (item.Id == 0)
                                packingListsService.PackingListDetailsCreate(item);
                        }
                        //packingListsService.PackingListUpdate((PackingListsDTO)Item);

                        
                        break;

                    default:
                        break;
                }

                if (deletePackingListDetailsList.Count > 0)
                {
                    foreach (var item in deletePackingListDetailsList)
                    {
                        if (item.Id > 0)
                            packingListsService.PackingListDetailsDeleteById(item.Id);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool FindDublicate(PackingListsDTO model)
        {
            packingListsService = Program.kernel.Get<IPackingListsService>();
            return packingListsService.GetPackingLists().Any(s => s.PackingNumber == model.PackingNumber && s.PackingDate.Year == model.PackingDate.Year
                && s.Id != model.Id);
        }

        #endregion

        #region Event's                                     

        private void destinationEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
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

        private void contractorsEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Очистить
                    {
                        contractorsEdit.EditValue = null;
                        contractorsEdit.Properties.NullText = "Немає данних";

                        break;
                    }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();

            if (MessageBox.Show("Зберегти зміни?", "Збереження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (packingDetailsBS.Count == 0)
                {
                    MessageBox.Show("Необхідно додати номер проекту до пакувального листа", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (SavePackingList())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            if (packingMaterialModelPack == null)
                packingMaterialModelPack = new PackingListMaterialsDTO();

            string filePath = "";
            string fileName = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                fileName = ofd.SafeFileName;
            }
            if (filePath.Length > 0)
            {
                byte[] scan = System.IO.File.ReadAllBytes(@filePath);

                packingMaterialModelPack.Scan = scan;
                packingMaterialModelPack.FileName = fileName;
            }
            else
                return;

            try
            {
                Bitmap bitmap = new Bitmap(filePath);
                pictureEdit.Properties.SizeMode = PictureSizeMode.Zoom;
                pictureEdit.EditValue = bitmap;
                fileNameTbox.EditValue = fileName;
            }
            catch (Exception)
            {
                int stratIndex = filePath.IndexOf('.');
                string typeFile = filePath.Substring(stratIndex);

                switch (typeFile)
                {
                    case ".pdf":
                        fileNameTbox.EditValue = fileName;
                        pictureEdit.Image = imageCollection.Images[1];
                        pictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
                        break;
                    default:
                        fileNameTbox.EditValue = fileName;
                        pictureEdit.Image = imageCollection.Images[0];
                        pictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
                        break;
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            packingMaterialModelPack.Scan = null;
            packingMaterialModelPack.FileName = null;
            pictureEdit.EditValue = null;
            fileNameTbox.EditValue = null;
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            string fileName = (string)fileNameTbox.EditValue;
            byte[] scan = packingMaterialModelPack.Scan;
            if (fileName != null)
            {
                string puth = Utils.HomePath + @"\Temp";
                System.IO.File.WriteAllBytes(puth + fileName, scan);
                System.Diagnostics.Process.Start(puth + fileName);
            }
        }

        private void addOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            using (PackingListCustomerSelectFm packingListCustomerSelectFm = new PackingListCustomerSelectFm())
            {
                if (packingListCustomerSelectFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var returnList = packingListCustomerSelectFm.Return();

                    customerOrdersGridView.BeginDataUpdate();

                    var saveItems = returnList.Select(s => new PackingListDetailDTO()
                    {
                        Id = 0,
                        PackingListId = 0,
                        CustomerOrderId = s.Id,
                         CustomerOrdersNumber = s.OrderNumber,
                          OrderDate = s.OrderDate,   
                          ContractorName = s.ContractorName
                    });

                    packingListDetailsList.AddRange(saveItems);

                    packingDetailsBS.DataSource = packingListDetailsList;
                    customerOrdersGrid.DataSource = packingDetailsBS;
                    customerOrdersGridView.EndDataUpdate();
                }
            }
        }

        private void deleteOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customerOrdersGridView.PostEditor();

            customerOrdersGridView.BeginDataUpdate();

            var checkItems = packingListDetailsList.Where(t => t.Selected && t.Id != 0).Select(s => new PackingListDetailDTO()
            {
                Id = s.Id,
                CustomerOrderId = s.CustomerOrderId,
                PackingListId = s.PackingListId
            });

            deletePackingListDetailsList.AddRange(checkItems);
            packingListDetailsList.RemoveAll(s => s.Selected);

            packingDetailsBS.DataSource = packingListDetailsList;
            customerOrdersGrid.DataSource = packingDetailsBS;

            customerOrdersGridView.EndDataUpdate();
        }

        #endregion

        #region Validation                                  

        private bool ControlValidation()
        {
            return packingValidationProvider.Validate();
        }

        private void packingValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void packingValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (packingValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void packingNumberTBox_TextChanged(object sender, EventArgs e)
        {
            packingValidationProvider.Validate((Control)sender);
        }

        private void packingDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            packingValidationProvider.Validate((Control)sender);
        }

        private void orderNumberEdit_EditValueChanged(object sender, EventArgs e)
        {
            packingValidationProvider.Validate((Control)sender);
        }

        private void responsiblePersonEdit_EditValueChanged(object sender, EventArgs e)
        {
            packingValidationProvider.Validate((Control)sender);
        }

        private void assemblyEdit_EditValueChanged(object sender, EventArgs e)
        {
            packingValidationProvider.Validate((Control)sender);
        }

        private void otkPersonEdit_EditValueChanged(object sender, EventArgs e)
        {
            packingValidationProvider.Validate((Control)sender);
        }

        private void packingNumberTBox_EditValueChanged(object sender, EventArgs e)
        {
            packingValidationProvider.Validate((Control)sender);
        }

        private void contractorsEdit_EditValueChanged(object sender, EventArgs e)
        {
            packingValidationProvider.Validate((Control)sender);
        }

        private void destinationEdit_EditValueChanged(object sender, EventArgs e)
        {
            packingValidationProvider.Validate((Control)sender);
        }

        private void packingNumberPartTBox_TextChanged(object sender, EventArgs e)
        {
            packingValidationProvider.Validate((Control)sender);
        }

        #endregion

        private void openComplBtn_Click(object sender, EventArgs e)
        {
            if (packingMaterialModelCompl == null)
                packingMaterialModelCompl = new PackingListMaterialsDTO();

            string filePath = "";
            string fileName = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                fileName = ofd.SafeFileName;
            }
            if (filePath.Length > 0)
            {
                byte[] scan = System.IO.File.ReadAllBytes(@filePath);

                packingMaterialModelCompl.Scan = scan;
                packingMaterialModelCompl.FileName = fileName;
            }
            else
                return;

            try
            {
                Bitmap bitmap = new Bitmap(filePath);
                pictureComplEdit.Properties.SizeMode = PictureSizeMode.Zoom;
                pictureComplEdit.EditValue = bitmap;
                fileNameComplTbox.EditValue = fileName;
            }
            catch (Exception)
            {
                int stratIndex = filePath.IndexOf('.');
                string typeFile = filePath.Substring(stratIndex);

                switch (typeFile)
                {
                    case ".pdf":
                        fileNameComplTbox.EditValue = fileName;
                        pictureComplEdit.Image = imageCollection.Images[1];
                        pictureComplEdit.Properties.SizeMode = PictureSizeMode.Clip;
                        break;
                    default:
                        fileNameComplTbox.EditValue = fileName;
                        pictureComplEdit.Image = imageCollection.Images[0];
                        pictureComplEdit.Properties.SizeMode = PictureSizeMode.Clip;
                        break;
                }
            }
        }

        private void clearComplBtn_Click(object sender, EventArgs e)
        {
            packingMaterialModelCompl.Scan = null;
            packingMaterialModelCompl.FileName = null;
            pictureComplEdit.EditValue = null;
            fileNameComplTbox.EditValue = null;
        }

        private void showComplBtn_Click(object sender, EventArgs e)
        {
            string fileName = (string)fileNameComplTbox.EditValue;
            byte[] scan = packingMaterialModelCompl.Scan;
            if (fileName != null)
            {
                string puth = Utils.HomePath + @"\Temp";
                System.IO.File.WriteAllBytes(puth + fileName, scan);
                System.Diagnostics.Process.Start(puth + fileName);
            }
        }

    }
}