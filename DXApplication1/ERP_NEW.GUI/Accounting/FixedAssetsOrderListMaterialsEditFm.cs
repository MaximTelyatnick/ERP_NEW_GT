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
using ERP_NEW.BLL.Services;
using ERP_NEW.BLL.DTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraBars;
using Ninject;
using System.IO;
using System.Diagnostics;
using ERP_NEW.BLL.Infrastructure;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ERP_NEW.BLL;
using DevExpress.Data.Filtering;
using System.Reflection;
using System.Collections;
using ERP_NEW.BLL.DTO.ReportsDTO;
using System.Globalization;

namespace ERP_NEW.GUI.Accounting
{
    public partial class FixedAssetsOrderListMaterialsEditFm : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource materialsBS = new BindingSource();
        private BindingSource materialsJournalBS = new BindingSource();
        private IFixedAssetsOrderService fixedAssetsOrderService;
        private Utils.Operation operation;
        private int clickBtnMaterial;
        private ObjectBase Item
        {
            get { return materialsBS.Current as ObjectBase; }
            set
            {
                materialsBS.DataSource = value;
                value.BeginEdit();
            }
        }



        public FixedAssetsOrderListMaterialsEditFm(Utils.Operation operation, FixedAssetsMaterialsDTO material, int clickBtn)//, FixedAssetsOrderListMaterialsJournalDTO modelJournal)
        {
            InitializeComponent();
            this.operation = operation;
            materialsBS.DataSource = Item = material;

            beginDateEdit.EditValue = new DateTime(2012, 7, 20);
            endDateEdit.EditValue = DateTime.Now;
            LoadMaterials();

            clickBtnMaterial = clickBtn;

        }
        #region Method's

        private void LoadMaterials()
        {
            splashScreenManager.ShowWaitForm();
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            materialsJournalBS.DataSource = fixedAssetsOrderService.GetExpendituresForFixedAssetsMaterials((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
            expendituresForFixedAssetsGrid.DataSource = materialsJournalBS;
            expendituresForFixedAssetsGrid.EndUpdate();
            splashScreenManager.CloseWaitForm();
        }
        public int ReturnInt()
        {
            return ((FixedAssetsMaterialsDTO)Item).Id;
        }
        public FixedAssetsMaterialsDTO Return()
        {
            return ((FixedAssetsMaterialsDTO)Item);
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            LoadMaterials();
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();

            if (operation == Utils.Operation.Add && clickBtnMaterial == 1)
            {
                ((FixedAssetsMaterialsDTO)Item).Expenditures_Id = ((FixedAssetsOrderListMaterialsJournalDTO)materialsJournalBS.Current).Id;
                ((FixedAssetsMaterialsDTO)Item).FixedPrice = ((FixedAssetsOrderListMaterialsJournalDTO)materialsJournalBS.Current).Price;
                ((FixedAssetsMaterialsDTO)Item).Name = ((FixedAssetsOrderListMaterialsJournalDTO)materialsJournalBS.Current).NameNomenclature;
                ((FixedAssetsMaterialsDTO)Item).Nomenclature = ((FixedAssetsOrderListMaterialsJournalDTO)materialsJournalBS.Current).Nomenclature;
                ((FixedAssetsMaterialsDTO)Item).Flag = 0;
                ((FixedAssetsMaterialsDTO)Item).ExpDate = ((FixedAssetsOrderListMaterialsJournalDTO)materialsJournalBS.Current).Exp_Date;
                ((FixedAssetsMaterialsDTO)Item).MaterialsDate = ((FixedAssetsOrderListMaterialsJournalDTO)materialsJournalBS.Current).Order_Date;
               // ((FixedAssetsMaterialsDTO)Item).Id = ((FixedAssetsOrderListMaterialsJournalDTO)materialsJournalBS.Current).Id;
                ((FixedAssetsMaterialsDTO)Item).FixedAssetsOrder_Id = -1;
           //     ((FixedAssetsMaterialsDTO)Item).AccountNum = ((FixedAssetsOrderListMaterialsJournalDTO)materialsJournalBS.Current).Debit_Num;              
            }
            else
            {
                ((FixedAssetsMaterialsDTO)Item).Expenditures_Id = ((FixedAssetsOrderListMaterialsJournalDTO)materialsJournalBS.Current).Id;
                ((FixedAssetsMaterialsDTO)Item).FixedPrice = ((FixedAssetsOrderListMaterialsJournalDTO)materialsJournalBS.Current).Price;
                ((FixedAssetsMaterialsDTO)Item).Name = ((FixedAssetsOrderListMaterialsJournalDTO)materialsJournalBS.Current).NameNomenclature;
                ((FixedAssetsMaterialsDTO)Item).Nomenclature = ((FixedAssetsOrderListMaterialsJournalDTO)materialsJournalBS.Current).Nomenclature;
                ((FixedAssetsMaterialsDTO)Item).Flag = 1;
                ((FixedAssetsMaterialsDTO)Item).ExpDate = ((FixedAssetsOrderListMaterialsJournalDTO)materialsJournalBS.Current).Exp_Date;
                ((FixedAssetsMaterialsDTO)Item).MaterialsDate = ((FixedAssetsOrderListMaterialsJournalDTO)materialsJournalBS.Current).Order_Date;
              //  ((FixedAssetsMaterialsDTO)Item).AccountNum = ((FixedAssetsOrderListMaterialsJournalDTO)materialsJournalBS.Current).Debit_Num;
             //   ((FixedAssetsMaterialsDTO)Item).Id = ((FixedAssetsOrderListMaterialsJournalDTO)materialsJournalBS.Current).Id;
             //   ((FixedAssetsMaterialsDTO)Item).FixedAssetsOrder_Id = ((FixedAssetsOrderListMaterialsJournalDTO)materialsJournalBS.Current).FixedAssetsOrder_Id;

            }
                return true;
        }
        #endregion

        #region Event's
        
       
        private void showBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMaterials();
        }

        private void expendituresForFixedAssetsGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Column.Name == "setPriceCol")
            {
                var cellValue = expendituresForFixedAssetsGridView.GetRowCellValue(e.RowHandle, setPriceCol);
                e.Appearance.BackColor = Color.Beige;
               
            }
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
                    else
                    {
                        // MessageBox.Show("Не вірний номер податкової.Такий номер вже існує.", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //numberAccountingEdit.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message, "Збереження матеріалу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

    }
}