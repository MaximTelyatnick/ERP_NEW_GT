using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using Ninject;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class StoreHouseFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IReportService reportService;

        private BindingSource accountClothesBS = new BindingSource();
        private BindingSource accountClothesMaterialsBS = new BindingSource();
        private UserTasksDTO _userTasksDTO;

        public StoreHouseFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            LoadDataAccountClothes();
            _userTasksDTO = userTasksDTO;
        }

        #region Method's                                     

        private void AuthorizatedUserAccess()
        {
            addCardBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editCardBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteCardBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            updateCardBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            printAccountClothesCardBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
        }

        private void LoadDataAccountClothes()
        {
            splashScreenManager.ShowWaitForm();

            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            accountClothesBS.DataSource = storeHouseService.GetAccountClothes();
            accountClothesGrid.DataSource = accountClothesBS;

            splashScreenManager.CloseWaitForm();
        }

        private void LoadDataAccountClothesMaterials(int id)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            accountClothesMaterialsBS.DataSource = storeHouseService.GetAccountClothesMaterials(id);
            accountsClothesMaterialsGrid.DataSource = accountClothesMaterialsBS;
        }

        private void EditStoreHouse(Utils.Operation operation, AccountClothesDTO model, List<AccountClothesMaterialsDTO> accountClothesMaterialsList)
        {
            using (StoreHouseEditFm storeHouseEditFm = new StoreHouseEditFm(operation, model, accountClothesMaterialsList))
            {
                if (storeHouseEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    AccountClothesDTO accountClothesDTO = storeHouseEditFm.Return();

                    accountClothesGridView.BeginDataUpdate();

                    LoadDataAccountClothes();

                    accountClothesGridView.EndDataUpdate();

                    int rowHandle = accountClothesGridView.LocateByValue("Id", accountClothesDTO.Id);
                    accountClothesGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void DeleteAccountClothes()
        {
            if (accountClothesBS.Count != 0)
            {
                if (MessageBox.Show("Видалити картку?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    storeHouseService = Program.kernel.Get<IStoreHouseService>();
                    int rowHandle = accountClothesGridView.FocusedRowHandle - 1;
                    accountClothesGridView.BeginDataUpdate();
                    storeHouseService.AccountClothesDelete(((AccountClothesInfoDTO)accountClothesBS.Current).Id);
                    LoadDataAccountClothes();
                    accountClothesGridView.EndDataUpdate();
                    accountClothesGridView.FocusedRowHandle = (accountClothesGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }

        #endregion

        #region Event's                                      
        
        private void accountClothesGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (accountClothesBS.Count > 0)
                LoadDataAccountClothesMaterials(((AccountClothesInfoDTO)accountClothesBS.Current).Id);
            else
                accountsClothesMaterialsGrid.DataSource = null;
        }

        private void addCardBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditStoreHouse(Utils.Operation.Add, new AccountClothesDTO(), new List<AccountClothesMaterialsDTO>());
        }

        private void editCardBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (accountClothesBS.Count > 0)
            {
                AccountClothesDTO modelAccountClothes = new AccountClothesDTO()
                {
                    Id = ((AccountClothesInfoDTO)accountClothesBS.Current).Id,
                    DocNumber = ((AccountClothesInfoDTO)accountClothesBS.Current).DocNumber,
                    DocDate = ((AccountClothesInfoDTO)accountClothesBS.Current).DocDate,
                    ResponsiblePersonId = ((AccountClothesInfoDTO)accountClothesBS.Current).ResponsiblePersonId,
                    ResponsibleFullName = ((AccountClothesInfoDTO)accountClothesBS.Current).ResponsibleFullName,
                    EmployeeId = ((AccountClothesInfoDTO)accountClothesBS.Current).EmployeeID,
                    EmployeeFullName = ((AccountClothesInfoDTO)accountClothesBS.Current).EmployeeFullName,
                    Profession = ((AccountClothesInfoDTO)accountClothesBS.Current).Profession,
                    Department = ((AccountClothesInfoDTO)accountClothesBS.Current).Department
                    
                };
                
                EditStoreHouse(Utils.Operation.Update, modelAccountClothes, (List<AccountClothesMaterialsDTO>)accountClothesMaterialsBS.DataSource);
            }
        }

        private void updateCardBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadDataAccountClothes();
        }

        private void deleteCardBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DeleteAccountClothes();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("При видаленні виникла помилка. " + ex.Message, "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accountClothesGridView_DoubleClick(object sender, System.EventArgs e)
        {
            if (accountClothesBS.Count > 0)
            {
                AccountClothesDTO modelAccountClothes = new AccountClothesDTO()
                {
                    Id = ((AccountClothesInfoDTO)accountClothesBS.Current).Id,
                    DocNumber = ((AccountClothesInfoDTO)accountClothesBS.Current).DocNumber,
                    DocDate = ((AccountClothesInfoDTO)accountClothesBS.Current).DocDate,
                    ResponsiblePersonId = ((AccountClothesInfoDTO)accountClothesBS.Current).ResponsiblePersonId,
                    ResponsibleFullName = ((AccountClothesInfoDTO)accountClothesBS.Current).ResponsibleFullName,
                    EmployeeFullName = ((AccountClothesInfoDTO)accountClothesBS.Current).EmployeeFullName,
                    Profession = ((AccountClothesInfoDTO)accountClothesBS.Current).Profession,
                    Department = ((AccountClothesInfoDTO)accountClothesBS.Current).Department,
                    EmployeeId = ((AccountClothesInfoDTO)accountClothesBS.Current).EmployeeID
                };
                
                EditStoreHouse(Utils.Operation.Update, modelAccountClothes, (List<AccountClothesMaterialsDTO>)accountClothesMaterialsBS.DataSource);
            }
        }

        private void accountClothesMaterialsGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Column.Name == "dateReturnCol")
            {
                var cellValue = accountClothesMaterialsGridView.GetRowCellValue(e.RowHandle, dateReturnCol);


                if (cellValue == null)
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                    e.Appearance.BackColor2 = Color.Tomato;
                }
            }

            if (e.RowHandle >= 0 && e.Column.Name == "quantityReturnCol")
            {
                var cellValue = accountClothesMaterialsGridView.GetRowCellValue(e.RowHandle, quantityReturnCol);

                if (cellValue == null)
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                    e.Appearance.BackColor2 = Color.Tomato;
                }
            }

            if (e.RowHandle >= 0 && e.Column.Name == "percentageReturnCol")
            {
                var cellValue = accountClothesMaterialsGridView.GetRowCellValue(e.RowHandle, percentageReturnCol);

                if (cellValue == null)
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                    e.Appearance.BackColor2 = Color.Tomato;
                }
            }
        }

        private void accountClothesMaterialsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            AccountClothesMaterialsDTO item = (AccountClothesMaterialsDTO)accountClothesMaterialsBS[e.ListSourceRowIndex];

            if (e.Column == returnStatusCol && e.IsGetData)
            {
                if (item != null)
                {
                    if (item.DateReturn != null && item.QuantityReturn != null && item.PercentageReturn != null)
                        e.Value = imageCollection.Images[0];
                    if (item.DateReturn == null || item.QuantityReturn == null || item.PercentageReturn == null)
                        e.Value = imageCollection.Images[1];
                    if (item.DateReturn == null && item.QuantityReturn == null && item.PercentageReturn == null)
                        e.Value = imageCollection.Images[2]; 
                }
            }
        }

        private void printAccountClothesCardBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (accountClothesBS.Count > 0)
            {
                reportService = Program.kernel.Get<IReportService>();

                reportService.PrintAccountClothesCard((AccountClothesInfoDTO)accountClothesBS.Current, (List<AccountClothesMaterialsDTO>)accountClothesMaterialsBS.DataSource);
            }
        }

        #endregion
    }
}