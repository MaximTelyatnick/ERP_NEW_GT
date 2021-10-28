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
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.BusinessCard
{
    public partial class BusinessCardFm : DevExpress.XtraEditors.XtraForm
    {
        public IBusinessCardService businessCardService;
        public IEmployeesService employeesService;
        public BindingSource businessCardFactoryBS = new BindingSource();
        public BindingSource businessCardContractorBS = new BindingSource();
        public BindingSource photoBusinessCardBS = new BindingSource();
        public List<BusinessCardDTO> businessCards = new List<BusinessCardDTO>();

        public string currentSearchText = "";

        public UserTasksDTO _userTasksDTO;

        public BusinessCardFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            LoadData();

            _userTasksDTO = userTasksDTO;

            AuthorizatedUserAccess();

            splashScreenManager.CloseWaitForm();
        }
        
        #region Method's

        public void AuthorizatedUserAccess()
        {
            addFactoryBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editFactoryBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteFactoryBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            addBusinessCard.Enabled = (_userTasksDTO.AccessRightId == 2);
            editBusinessCard.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteBusinessCard.Enabled = (_userTasksDTO.AccessRightId == 2);
        }

        public void LoadData()
        {
            businessCardService = Program.kernel.Get<IBusinessCardService>();

            var businessCardFactory = businessCardService.GetBusinessCardFactory();
            businessCardFactoryBS.DataSource = businessCardFactory.OrderBy(bdsm => bdsm.CountryName).ThenBy(bdsm => bdsm.CityName);
            businessCardFactoryGrid.DataSource = businessCardFactoryBS;

            if (businessCardFactoryBS.Count > 0)
            {
                LoadDataContractor(((BusinessCardsFactoryDTO)businessCardFactoryBS.Current).Id);
            }
            else
            {
                businessCardFactoryBS.DataSource = null;
            }

            searchContractorNameEdit.EditValue = null;

           
        }

        public void LoadDataContractor(int id)
        {
            contractorGridView.BeginUpdate();

            businessCardService = Program.kernel.Get<IBusinessCardService>();
            var businessCardsContractor = businessCardService.GetContractorNameByFactoryId(id);
            businessCardContractorBS.DataSource = businessCardsContractor;

            contractorGrid.DataSource = businessCardContractorBS;

            if (businessCardContractorBS.Count > 0)
                LoadCardPhotos(((BusinessCardDTO)businessCardContractorBS.Current).Id);

            contractorGridView.EndUpdate();
        }

        public void LoadCardPhotos(int id)
        {
            photoCardGridView.BeginUpdate();

            businessCardService = Program.kernel.Get<IBusinessCardService>();
            var businessCardsPhotos = businessCardService.GetCardPhotoById(id);
            photoBusinessCardBS.DataSource = businessCardsPhotos;

            photoCardGrid.DataSource = photoBusinessCardBS;

            photoCardGridView.EndUpdate();
        }

        public void EditBusinessCard(Utils.Operation operation, BusinessCardsFactoryDTO businessCardsFactoryDTO, BusinessCardDTO businessCardDTO, List<BusinessCardPhotosDTO> cardPhotoList)
        {
            using (BusinessCardEditFm businessCardEditFm = new BusinessCardEditFm(operation, businessCardsFactoryDTO, businessCardDTO, cardPhotoList))
            {
                if (businessCardEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    BusinessCardDTO returnModel = businessCardEditFm.Return();

                    businessCardFactoryGridView.BeginDataUpdate();

                    LoadData();

                    businessCardFactoryGridView.EndDataUpdate();

                    int rowHandle = businessCardFactoryGridView.LocateByValue("Id", returnModel.Id);
                    businessCardFactoryGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        public void EditOrganisation(Utils.Operation operation, BusinessCardsFactoryDTO model)
        {
            using (BusinessCardFactoryEditFm businessCardFactoryEditFm = new BusinessCardFactoryEditFm(operation, model))
            {
                if (businessCardFactoryEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    BusinessCardsFactoryDTO returnModel = businessCardFactoryEditFm.Return();

                    businessCardFactoryGridView.BeginDataUpdate();

                    LoadData();

                    businessCardFactoryGridView.EndDataUpdate();

                    int rowHandle = businessCardFactoryGridView.LocateByValue("Id", returnModel.Id);
                    businessCardFactoryGridView.FocusedRowHandle = rowHandle;
                }
            }
        }


        public void SearchContractor()
        {
            if (searchContractorNameEdit.EditValue != null)
            {
                string[] searchname = { searchContractorNameEdit.EditValue.ToString() };

                var idCardsFactoryList = businessCardService.GetBusinessCard().Where(name => searchname.Any(searchFor => name.ContactPersonName.Contains(searchFor)));

                List<BusinessCardDTO> businesCardTempList = idCardsFactoryList.ToList();

                if (businesCardTempList.Count > 0)
                {

                    splashScreenManager.ShowWaitForm();

                    List<BusinessCardsFactoryDTO> businessCardFactoryTempList = businessCardService.GetBusinessCardFactory().ToList();

                    var sortList = businessCardFactoryTempList.Where(name => businesCardTempList.Any(searchFor => name.Id.Equals(searchFor.BusinessCardsFactoryId)));

                    businessCardFactoryBS.DataSource = sortList;

                    businessCardFactoryGrid.DataSource = businessCardFactoryBS;

                    LoadDataContractor(((BusinessCardsFactoryDTO)businessCardFactoryBS.Current).Id);

                    splashScreenManager.CloseWaitForm();
                }
                else
                {
                    businessCardContractorBS.DataSource = null;
                    businessCardFactoryBS.DataSource = null;
                    photoBusinessCardBS.DataSource = null;

                    MessageBox.Show("Не знайдено контрагентів, які б відповідали критерію пошуку...", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                splashScreenManager.ShowWaitForm();

                LoadData();

                splashScreenManager.CloseWaitForm();
            }
        }

        #endregion

        #region Event's

        private void contractorGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (businessCardContractorBS.Count > 0)
            {
                LoadCardPhotos(((BusinessCardDTO)businessCardContractorBS.Current).Id);
            }
        }

        private void businessCardFactoryGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (businessCardFactoryBS.Count > 0)
            {
                LoadDataContractor(((BusinessCardsFactoryDTO)businessCardFactoryBS.Current).Id);
            }
        }

        private void addBusinessCard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditBusinessCard(Utils.Operation.Add, (BusinessCardsFactoryDTO)businessCardFactoryBS.Current, new BusinessCardDTO(), new List<BusinessCardPhotosDTO>());
        }

        private void editBusinessCard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (businessCardContractorBS.Count > 0)
                EditBusinessCard(Utils.Operation.Update, (BusinessCardsFactoryDTO)businessCardFactoryBS.Current, (BusinessCardDTO)businessCardContractorBS.Current, (List<BusinessCardPhotosDTO>)photoBusinessCardBS.DataSource);
        }

        private void deleteBusinessCard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Видалити візитку?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                businessCardService = Program.kernel.Get<IBusinessCardService>();

                businessCardFactoryGridView.BeginUpdate();

                if (businessCardService.BusinessCardDelete(((BusinessCardDTO)businessCardContractorBS.Current).Id))
                {
                    LoadData();
                }

                businessCardFactoryGridView.EndUpdate();
            }
        }

        private void addFactoryBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOrganisation(Utils.Operation.Add, new BusinessCardsFactoryDTO());
        }

        private void editFactoryBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOrganisation(Utils.Operation.Update, (BusinessCardsFactoryDTO)businessCardFactoryBS.Current);
        }

        private void deleteFactoryBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Видалити організацію", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                businessCardService = Program.kernel.Get<IBusinessCardService>();

                businessCardFactoryGridView.BeginUpdate();

                if (businessCardService.BusinessCardFactoryDelete(((BusinessCardsFactoryDTO)businessCardFactoryBS.Current).Id))
                {
                    LoadData();
                }

                businessCardFactoryGridView.EndUpdate();
            }
        }

        private void updateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager.ShowWaitForm();

            LoadData();

            searchContractorNameEdit.EditValue = null;

            splashScreenManager.CloseWaitForm();
        }

        private void businessCardFactoryGridView_DoubleClick(object sender, EventArgs e)
        {
            EditOrganisation(Utils.Operation.Update, (BusinessCardsFactoryDTO)businessCardFactoryBS.Current);
        }

        private void contractorGridView_DoubleClick(object sender, EventArgs e)
        {
            if (businessCardContractorBS.Count > 0)
                EditBusinessCard(Utils.Operation.Update, (BusinessCardsFactoryDTO)businessCardFactoryBS.Current, (BusinessCardDTO)businessCardContractorBS.Current, (List<BusinessCardPhotosDTO>)photoBusinessCardBS.DataSource);
        }

        private void searchContractorBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SearchContractor();
        }

   

        #endregion


     

       

    }
}