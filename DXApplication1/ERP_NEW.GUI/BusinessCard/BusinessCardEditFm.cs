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
using ERP_NEW.GUI.Contractors;
using ERP_NEW.GUI.Classifiers;

namespace ERP_NEW.GUI.BusinessCard
{
    public partial class BusinessCardEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IBusinessCardService businessCardService;
        private ICityService cityService;
        private IContractorsService contractorsService;

        private BindingSource businessCardBS = new BindingSource();
        private BindingSource businessCardPhotosBS = new BindingSource();
        private BindingSource citiesBS = new BindingSource();
        private BindingSource productCategoryBS = new BindingSource();

        private List<BusinessCardDTO> contactPersonNameList = new List<BusinessCardDTO>();
        private List<BusinessCardPhotosDTO> contactPersonCardPhotosList;
        private List<BusinessCardPhotosDTO> deleteContactPersonCardPhotosList = new List<BusinessCardPhotosDTO>();


        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return businessCardBS.Current as ObjectBase; }
            set
            {
                businessCardBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public BusinessCardEditFm(Utils.Operation operation, BusinessCardsFactoryDTO businessCardsFactoryDTO, BusinessCardDTO businessCardDTO, List<BusinessCardPhotosDTO> cardSource)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            LoadData();

            this.operation = operation;
            businessCardBS.DataSource = Item = businessCardDTO;

            contactPersonCardPhotosList = cardSource;
            businessCardPhotosBS.DataSource = contactPersonCardPhotosList;
            photoCardGrid.DataSource = businessCardPhotosBS;

            ((BusinessCardDTO)Item).BusinessCardsFactoryId = businessCardsFactoryDTO.Id;

            contractorEdit.DataBindings.Add("EditValue", businessCardBS, "ContactPersonName", true, DataSourceUpdateMode.OnPropertyChanged);

            contractorDataEdit.DataBindings.Add("EditValue", businessCardBS, "ContractorInfo", true, DataSourceUpdateMode.OnPropertyChanged);

            organisationEdit.Text = businessCardsFactoryDTO.Name;

            splashScreenManager.CloseWaitForm();
        }


        #region Method's
        
        #endregion


        private void LoadData()
        {
            businessCardService = Program.kernel.Get<IBusinessCardService>();
            cityService = Program.kernel.Get<ICityService>();
            contractorsService = Program.kernel.Get<IContractorsService>();

        }

        public static byte[] ConverterImageToByte(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }


        public BusinessCardDTO Return()
        {
            return ((BusinessCardDTO)Item);
        }

        private void addImageBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (BusinessCardPhotoFm businessCardPhotoFm = new BusinessCardPhotoFm())
            {
                if (businessCardPhotoFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Image image = businessCardPhotoFm.Return();
                    BusinessCardPhotosDTO usinessCardPhotosDTO = new BusinessCardPhotosDTO()
                    {
                         Photo = ConverterImageToByte(image),
                         Selected = false
                    };

                    contactPersonCardPhotosList.Add(usinessCardPhotosDTO);
                    photoCardGrid.DataSource = contactPersonCardPhotosList;

                }
            }
        }

        

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveBusinessCards())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private bool SaveBusinessCards()
        {
            this.Item.EndEdit();

            if (contactPersonCardPhotosList.Count == 0)
            {
                MessageBox.Show("Необхідно додати фото до візитки!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            try
            {
                if (deleteContactPersonCardPhotosList.Count > 0)
                {
                    businessCardService = Program.kernel.Get<IBusinessCardService>();
                    businessCardService.BusinessCardPhotosRemoveRange(deleteContactPersonCardPhotosList);
                }

                if (this.operation == Utils.Operation.Add)
                {
                    businessCardService = Program.kernel.Get<IBusinessCardService>();
                    int currentId = businessCardService.BusinessCardCreate((BusinessCardDTO)Item);

                    contactPersonCardPhotosList.Select(sp => { sp.BusinessCardId = currentId; return sp; }).ToList();
                    businessCardService.BusinessCardPhotoCreateRange(contactPersonCardPhotosList);
                }
                else
                {
                    businessCardService.BusinessCardUpdate((BusinessCardDTO)Item);

                    contactPersonCardPhotosList.Select(sp => { sp.BusinessCardId = ((BusinessCardDTO)Item).Id; return sp; }).ToList();

                    foreach (var item in contactPersonCardPhotosList)
                    {
                        if (item.Id == 0)
                            businessCardService.BusinessCardPhotoCreate(item);
                        else
                            businessCardService.BusinessCardPhotoUpdate(item);
                    }

                }

            
            }
            catch (Exception)
            {
                
                throw;
            }

            return true;
        }

        private void deleteImageBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            photoCardGridView.PostEditor();

            photoCardGridView.BeginDataUpdate();

            var checkItems = contactPersonCardPhotosList.Where(t => t.Selected && t.Id != 0).Select(s => new BusinessCardPhotosDTO()
            {

                Id = s.Id,
                BusinessCardId = s.BusinessCardId,
                Photo = s.Photo

            });

            deleteContactPersonCardPhotosList.AddRange(checkItems);

            contactPersonCardPhotosList.RemoveAll(s => s.Selected);

            businessCardPhotosBS.DataSource = contactPersonCardPhotosList;

            photoCardGrid.DataSource = businessCardPhotosBS;

            photoCardGridView.EndDataUpdate();
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

        private bool ControlValidation()
        {
            return dxValidationProvider.Validate();
            
        }

        private void contractorEdit_TextChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void organisationEdit_TextChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}