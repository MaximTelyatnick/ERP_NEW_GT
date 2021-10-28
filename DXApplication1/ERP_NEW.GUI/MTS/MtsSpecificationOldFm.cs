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

namespace ERP_NEW.GUI.MTS
{
    public partial class MtsSpecificationOldFm : DevExpress.XtraEditors.XtraForm
    {
        private UserTasksDTO userTaskDTO;

        private IMtsSpecificationsService mtsService;
        private IReportService reportService;
        private BindingSource specificBS = new BindingSource();
        private BindingSource detalsSpecificBS = new BindingSource();
        private BindingSource byusDetalsSpecificBS = new BindingSource();
        private BindingSource materialsSpecificBS = new BindingSource();
        private UserTasksDTO userTasksDTO;

        public MtsSpecificationOldFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            this.userTaskDTO = userTasksDTO;

            startDateItem.EditValue = new DateTime(DateTime.Now.Year - 1, 6, 5);
            endDateItem.EditValue = DateTime.Now;

            LoadData();
        }

        private void LoadData()
        {
            mtsService = Program.kernel.Get<IMtsSpecificationsService>();
            specificBS.DataSource = mtsService.GetAllSpecificationOldByPeriod((DateTime)startDateItem.EditValue, (DateTime)endDateItem.EditValue).OrderByDescending(ord => ord.ID).ToList();
            specificGrid.DataSource = specificBS;

            //if (specificBS.Count > 0)
            //{
            //    LoadSpecific(((MTSSpecificationsDTO)specificBS.Current).ID);
            //    LoadBuysDetalSpecific(((MTSSpecificationsDTO)specificBS.Current).ID);
            //    LoadMaterialsSpecific(((MTSSpecificationsDTO)specificBS.Current).ID);
            //}
            //else
            //{
            //    detalsSpecificGrid.DataSource = null;
            //    buysDetalsSpecificGrid.DataSource = null;
            //    materialsSpecificGrid.DataSource = null;
            //}
        }

        private void LoadSpecific(int detailId)
        {
            mtsService = Program.kernel.Get<IMtsSpecificationsService>();
            detalsSpecificBS.DataSource = mtsService.GetAllDetailsSpecific(detailId).OrderBy(ord => ord.ID).ToList();
            if (detalsSpecificBS.Count != 0)
                detalsSpecificGrid.DataSource = detalsSpecificBS;
            else
                detalsSpecificGrid.DataSource = null;
        }

        private void LoadBuysDetalSpecific(int detailId)
        {
            mtsService = Program.kernel.Get<IMtsSpecificationsService>();
            byusDetalsSpecificBS.DataSource = mtsService.GetBuysDetalSpecific(detailId).OrderBy(ord => ord.ID).ToList();
            if (byusDetalsSpecificBS.Count != 0)
                buysDetalsSpecificGrid.DataSource = byusDetalsSpecificBS;
            else
                buysDetalsSpecificGrid.DataSource = null;
        }
        private void LoadMaterialsSpecific(int detailId)
        {
            mtsService = Program.kernel.Get<IMtsSpecificationsService>();
            materialsSpecificBS.DataSource = mtsService.GetMaterialsSpecific(detailId).OrderBy(ord => ord.ID).ToList();
            if (materialsSpecificBS.Count != 0)
                materialsSpecificGrid.DataSource = materialsSpecificBS;
            else
                materialsSpecificGrid.DataSource = null;

        }

        private void SpecificationCheckMark()
        {

            mtsService = Program.kernel.Get<IMtsSpecificationsService>();
            MTSSpecificationsDTO update = (MTSSpecificationsDTO)specificBS.Current;
            int rowHandle = specificGridView.FocusedRowHandle - 1;

            

            specificGridView.BeginDataUpdate();

            if (((MTSSpecificationsDTO)specificBS.Current).SET_COLOR == 0)
            {
                ((MTSSpecificationsDTO)specificBS.Current).SET_COLOR = 1;
                mtsService.MTSSpecificationUpdate((MTSSpecificationsDTO)specificBS.Current);
            }
            else
            {
                ((MTSSpecificationsDTO)specificBS.Current).SET_COLOR = 0;
                mtsService.MTSSpecificationUpdate((MTSSpecificationsDTO)specificBS.Current);
            }

            specificGridView.FocusedRowHandle = (specificGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;

            specificGridView.EndDataUpdate();
        }

        private void specificGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // var model = (MTSSpecificationsDTO)specificGridView.GetRow(e.FocusedRowHandle) ?? null;

            if (((MTSSpecificationsDTO)specificBS.Current).SET_COLOR == 1)
            {
                enableColorSpecificBtn.LargeGlyph = imageCollection.Images[0];
                enableColorSpecificBtn.Caption = "Зняти виділення";
                disableLabelMenuBtn.Enabled = true;
                enableLabelMenuBtn.Enabled = false;
            }
            else
            {
                enableColorSpecificBtn.LargeGlyph = imageCollection.Images[1];
                enableColorSpecificBtn.Caption = "Виділити";
                disableLabelMenuBtn.Enabled = false;
                enableLabelMenuBtn.Enabled = true;
            }
            if (specificBS.Count > 0)
            {
                LoadSpecific(((MTSSpecificationsDTO)specificBS.Current).ID);
                LoadBuysDetalSpecific(((MTSSpecificationsDTO)specificBS.Current).ID);
                LoadMaterialsSpecific(((MTSSpecificationsDTO)specificBS.Current).ID);

            }
            else
                materialsSpecificGrid.DataSource = null;
        }

        private ObjectBase ItemSpecification
        {
            get { return specificBS.Current as ObjectBase; }
            set
            {
                specificBS.DataSource = value;
                value.BeginEdit();
            }
        }

        private ObjectBase ItemDetail
        {
            get { return detalsSpecificBS.Current as ObjectBase; }
            set
            {
                detalsSpecificBS.DataSource = value;
                value.BeginEdit();
            }
        }



        private void AddSpecification(Utils.Operation operation, MTSSpecificationsDTO model, UserTasksDTO userTaskDTO)
        {
            using (MtsSpecificationOldEditFm mtsSpecificationOldEditFm = new MtsSpecificationOldEditFm(operation, model, userTaskDTO))
            {
                if (mtsSpecificationOldEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MTSSpecificationsDTO return_Id = mtsSpecificationOldEditFm.Return();
                    specificGridView.BeginDataUpdate();
                    LoadData();
                    specificGridView.EndDataUpdate();
                }
            }
        }

        private void AddSpecificationDetails(MTSSpecificationsDTO model, Utils.Operation operation)
        {
            using (MtsSpecificationOldDetailsFm mtsSpecificationOldDetailsFm = new MtsSpecificationOldDetailsFm(model, operation))
            {
                if (mtsSpecificationOldDetailsFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MTSSpecificationsDTO return_Id = mtsSpecificationOldDetailsFm.Return();
                    specificGridView.BeginDataUpdate();
                    LoadData();
                    specificGridView.EndDataUpdate();
                }
            }
        }

        private void DeleteSpecification()
        {
            if (specificBS.Count != 0)
            {
                if (MessageBox.Show("Видалити запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mtsService = Program.kernel.Get<IMtsSpecificationsService>();
                    if (mtsService.MTSSpecificationDelete(((MTSSpecificationsDTO)specificBS.Current).ID))
                    {
                        int rowHandle = specificGridView.FocusedRowHandle - 1;
                        specificGridView.BeginDataUpdate();
                        LoadData();
                        specificGridView.EndDataUpdate();
                        specificGridView.FocusedRowHandle = (specificGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                    }
                }
            }
        }


        //EditPrepayment(Utils.Operation.Add, new CashPrepaymentsDTO() { UserId = _userTasksDTO.UserId });


        //MtsBuyDetailEditOldFm mtsBuyDetailEditOldFm;
        private void EditBuyDetail(Utils.Operation operation, MTSPurchasedProductsDTO model)
        {
            switch (operation)
            {
                case Utils.Operation.Add:
                    using (DirectoryBuyDetailEditOldFm directoryBuyDetailEditOldFm = new DirectoryBuyDetailEditOldFm(new MTSNomenclaturesOldDTO()))
                    {
                        if (directoryBuyDetailEditOldFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            //MTSNomenclatureGroupsOldDTO return_Id = directoryBuyDetailEditOldFm.Return();
                            // =new MtsBuyDetailEditOldFm(Utils.Operation.Add,MTSNomenclaturesOldDTO nom);
                            MTSNomenclaturesOldDTO selectNomenclature = directoryBuyDetailEditOldFm.Returnl();

                            model.NOMENCLATURES_ID = selectNomenclature.ID;
                            model.GUAEGENAME = selectNomenclature.GUAGE;
                            model.NOMENCLATURESNAME = selectNomenclature.NAME;
                            model.CHANGES = ((MTSSpecificationsDTO)specificBS.Current).SET_COLOR == 0 ? 0 : 1;

                            using (MtsBuyDetailEditOldFm mtsBuyDetailEditOldFm = new MtsBuyDetailEditOldFm(operation, model))
                            //   DirectoryBuyDetailEditOldFm directoryBuyDetailEditOldFm = new DirectoryBuyDetailEditOldFm(model);
                            {
                                if (mtsBuyDetailEditOldFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                {
                                    MTSPurchasedProductsDTO returnMtsPurchasedProduct = mtsBuyDetailEditOldFm.Return();
                                    buysDetalsSpecificGridView.BeginDataUpdate();
                                    LoadData();
                                    buysDetalsSpecificGridView.EndDataUpdate();
                                    int rowHandle = buysDetalsSpecificGridView.LocateByValue("ID", returnMtsPurchasedProduct.ID);
                                    buysDetalsSpecificGridView.FocusedRowHandle = rowHandle;
                                }
                            }
                        }
                    }

                    break;
                case Utils.Operation.Update:
                    using (MtsBuyDetailEditOldFm mtsBuyDetailEditOldFm = new MtsBuyDetailEditOldFm(operation, model))
                    //   DirectoryBuyDetailEditOldFm directoryBuyDetailEditOldFm = new DirectoryBuyDetailEditOldFm(model);
                    {
                        if (mtsBuyDetailEditOldFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            MTSPurchasedProductsDTO returnMtsPurchasedProduct = mtsBuyDetailEditOldFm.Return();
                            buysDetalsSpecificGridView.BeginDataUpdate();
                            LoadData();
                            buysDetalsSpecificGridView.EndDataUpdate();
                            int rowHandle = buysDetalsSpecificGridView.LocateByValue("ID", returnMtsPurchasedProduct.ID);
                            buysDetalsSpecificGridView.FocusedRowHandle = rowHandle;
                        }
                    }
                    break;

                default:
                    break;
            }


        }

        private void EditMaterial(Utils.Operation operation, MTSMaterialsDTO model)
        {
            switch (operation)
            {
                case Utils.Operation.Add:
                    using (DirectoryBuyDetailEditOldFm directoryBuyDetailEditOldFm = new DirectoryBuyDetailEditOldFm(new MTSNomenclaturesOldDTO()))
                    {
                        if (directoryBuyDetailEditOldFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            //MTSNomenclatureGroupsOldDTO return_Id = directoryBuyDetailEditOldFm.Return();
                            // =new MtsBuyDetailEditOldFm(Utils.Operation.Add,MTSNomenclaturesOldDTO nom);
                            MTSNomenclaturesOldDTO selectNomenclature = directoryBuyDetailEditOldFm.Returnl();

                            model.NOMENCLATURES_ID = selectNomenclature.ID;
                            model.GUAGENAME = selectNomenclature.GUAGE;
                            model.NOMENCLATURESNAME = selectNomenclature.NAME;
                            model.CHANGES = ((MTSSpecificationsDTO)specificBS.Current).SET_COLOR == 0 ? 0 : 1;

                            using (MtsMaterialEditOldFm mtsMaterialEditOldFm = new MtsMaterialEditOldFm(operation, model))
                            //   DirectoryBuyDetailEditOldFm directoryBuyDetailEditOldFm = new DirectoryBuyDetailEditOldFm(model);
                            {
                                if (mtsMaterialEditOldFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                {
                                    MTSMaterialsDTO returnMtsMaterials = mtsMaterialEditOldFm.Return();
                                    materialsSpecificGridView.BeginDataUpdate();
                                    LoadData();
                                    materialsSpecificGridView.EndDataUpdate();
                                    int rowHandle = materialsSpecificGridView.LocateByValue("ID", returnMtsMaterials.ID);
                                    materialsSpecificGridView.FocusedRowHandle = rowHandle;
                                }
                            }
                        }
                    }

                    break;
                case Utils.Operation.Update:
                    using (MtsMaterialEditOldFm mtsMaterialEditOldFm = new MtsMaterialEditOldFm(operation, model))
                    //   DirectoryBuyDetailEditOldFm directoryBuyDetailEditOldFm = new DirectoryBuyDetailEditOldFm(model);
                    {
                        if (mtsMaterialEditOldFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            MTSMaterialsDTO returnMtsMaterials = mtsMaterialEditOldFm.Return();
                            materialsSpecificGridView.BeginDataUpdate();
                            LoadData();
                            materialsSpecificGridView.EndDataUpdate();
                            int rowHandle = materialsSpecificGridView.LocateByValue("ID", returnMtsMaterials.ID);
                            materialsSpecificGridView.FocusedRowHandle = rowHandle;
                        }
                    }
                    break;

                default:
                    break;
            }


        }

        private void EditDetailSpecific(Utils.Operation operation, MTSDetailsDTO model)
        {

            model.CHANGES = ((MTSSpecificationsDTO)specificBS.Current).SET_COLOR == 0 ? 0 : 1;

            using (MtsDetailsEditOldFm mtsDetailsEditOldFm = new MtsDetailsEditOldFm(operation, model))
            {
                if (mtsDetailsEditOldFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MTSDetailsDTO return_Id = mtsDetailsEditOldFm.Return();
                    detalsSpecificGridView.BeginDataUpdate();
                    LoadData();//LoadSpecific(modelSpecific.ID);
                    detalsSpecificGridView.EndDataUpdate();
                }
            }
        }

        //private void DeleteDetail()
        //{
        //    if (specificBS.Count != 0)
        //    {
        //        if (MessageBox.Show("Видалити запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            mtsService = Program.kernel.Get<IMtsSpecificationsService>();
        //            if (mtsService.MTSCreateDetailsDelete(((MTSCreateDetalsDTO)detalsSpecificBS.Current).ID))
        //            {
        //                int rowHandle = detalsSpecificGridView.FocusedRowHandle - 1;
        //                detalsSpecificGridView.BeginDataUpdate();
        //                LoadData();
        //                detalsSpecificGridView.EndDataUpdate();
        //                detalsSpecificGridView.FocusedRowHandle = (detalsSpecificGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
        //            }
        //        }
        //    }
        //}

        #region Event's

        private void showBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void addSpecificBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddSpecification(Utils.Operation.Add, new MTSSpecificationsDTO(), userTaskDTO);
        }
        private void editSpecificBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (specificBS.Count > 0)
            {
                MTSSpecificationsDTO model = new MTSSpecificationsDTO()
                {
                    ID = ((MTSSpecificationsDTO)ItemSpecification).ID,
                    AUTHORIZATION_USERS_ID = ((MTSSpecificationsDTO)ItemSpecification).AUTHORIZATION_USERS_ID,
                    NAME = ((MTSSpecificationsDTO)ItemSpecification).NAME,
                    QUANTITY = ((MTSSpecificationsDTO)ItemSpecification).QUANTITY,
                    WEIGHT = ((MTSSpecificationsDTO)ItemSpecification).WEIGHT,
                    CREATION_DATE = ((MTSSpecificationsDTO)ItemSpecification).CREATION_DATE,
                    DRAWING = ((MTSSpecificationsDTO)ItemSpecification).DRAWING,
                    AUTHORIZATION_USERS_NAME = ((MTSSpecificationsDTO)ItemSpecification).AUTHORIZATION_USERS_NAME
                     
                     
                };
                AddSpecification(Utils.Operation.Update, (MTSSpecificationsDTO)model,userTaskDTO);
            }
            else MessageBox.Show("Помилка редагування специфікації! Створіть спочатку специфікацію!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void addAllSpeficBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddSpecificationDetails(new MTSSpecificationsDTO(), Utils.Operation.Add);
        }

        private void deleteSpecificBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (specificBS.Count > 0)
                DeleteSpecification();
            else MessageBox.Show("Помилка видалення специфікації! Створіть спочатку специфікацію!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        private void DeleteDetail(int detailId)
        {
            if (MessageBox.Show("Видалити деталь?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mtsService = Program.kernel.Get<IMtsSpecificationsService>();

                mtsService.MTSCreateDetailsDelete(detailId);

                detalsSpecificGridView.PostEditor();
                detalsSpecificGridView.BeginDataUpdate();
                LoadSpecific(((MTSSpecificationsDTO)specificBS.Current).ID);
                detalsSpecificGridView.EndDataUpdate();
            }
        }

        private void DeleteBuyDetail(int detailId)
        {
            if (MessageBox.Show("Видалити деталь?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mtsService = Program.kernel.Get<IMtsSpecificationsService>();

                mtsService.MTSPurchasedProductsDelete(detailId);

                buysDetalsSpecificGridView.PostEditor();
                buysDetalsSpecificGridView.BeginDataUpdate();
                LoadBuysDetalSpecific(((MTSSpecificationsDTO)specificBS.Current).ID);
                buysDetalsSpecificGridView.EndDataUpdate();
            }
        }

        #endregion

        #region Event's CRUD for MTSCreateDetails

        private void addDetailBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditDetailSpecific(Utils.Operation.Add, new MTSDetailsDTO() { SPECIFICATIONS_ID = ((MTSSpecificationsDTO)specificBS.Current).ID, PROCESSING_ID = 1 });
        }

        private void editDetailBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            //if (detalsSpecificBS.Count > 0)
            //{
            //    MTSCreateDetalsDTO model = new MTSCreateDetalsDTO()
            //    {
            //        ID = ((MTSCreateDetalsDTO)ItemDetail).ID,
            //        DRAWING = ((MTSCreateDetalsDTO)ItemDetail).DRAWING,
            //        NAME = ((MTSCreateDetalsDTO)ItemDetail).NAME,
            //        QUANTITY = ((MTSCreateDetalsDTO)ItemDetail).QUANTITY,
            //        HEIGHT = ((MTSCreateDetalsDTO)ItemDetail).HEIGHT,
            //        WIDTH = ((MTSCreateDetalsDTO)ItemDetail).WIDTH,
            //        CREATEDETALSNAME = ((MTSCreateDetalsDTO)ItemDetail).CREATEDETALSNAME,
            //        GUAEGENAME = ((MTSCreateDetalsDTO)ItemDetail).GUAEGENAME,
            //        QUANTITY_OF_BLANKS = ((MTSCreateDetalsDTO)ItemDetail).QUANTITY_OF_BLANKS,
            //        DETALSPROCESSING = ((MTSCreateDetalsDTO)ItemDetail).DETALSPROCESSING,
            //        PROCCESINGNAME = ((MTSCreateDetalsDTO)ItemDetail).PROCCESINGNAME,
            //        NOMENCLATURESNAME = ((MTSCreateDetalsDTO)ItemDetail).NOMENCLATURESNAME,
            //        PROCESSING_ID = ((MTSCreateDetalsDTO)ItemDetail).PROCESSING_ID

            //    };
            //    MTSDetailsDTO modelDetail = new MTSDetailsDTO()
            //    {
            //        SPECIFICATIONS_ID = 11//((MTSSpecificationsDTO)Item).ID
            //    };

            //    AddDetailSpecific(Utils.Operation.Update, (MTSCreateDetalsDTO)model, (MTSSpecificationsDTO)specificBS.Current, (MTSDetailsDTO)modelDetail);
            //}
            //else MessageBox.Show("Помилка редагування деталі! Створіть спочатку деталь!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            EditDetailSpecific(Utils.Operation.Update, ((MTSDetailsDTO)detalsSpecificBS.Current));

        }

        private void deleteDetailBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (detalsSpecificBS.Count > 0)
                DeleteDetail(((MTSCreateDetalsDTO)detalsSpecificBS.Current).ID);
            else
                MessageBox.Show("Помилка видалення деталі! Створіть спочатку деталі!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void addDetailBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditDetailSpecific(Utils.Operation.Add, new MTSDetailsDTO() { SPECIFICATIONS_ID = ((MTSSpecificationsDTO)specificBS.Current).ID, PROCESSING_ID = 1 });
        }

        private void editDetailBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditDetailSpecific(Utils.Operation.Update, ((MTSDetailsDTO)detalsSpecificBS.Current));
        }

        private void deleteDetailBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (detalsSpecificBS.Count > 0)
                DeleteDetail(((MTSCreateDetalsDTO)detalsSpecificBS.Current).ID);
            else
                MessageBox.Show("Помилка видалення деталі! Створіть спочатку деталі!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void додатиЗаписToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditDetailSpecific(Utils.Operation.Add, new MTSDetailsDTO() { SPECIFICATIONS_ID = ((MTSSpecificationsDTO)specificBS.Current).ID, PROCESSING_ID = 1 });
        }

        private void редагуватиЗаписToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditDetailSpecific(Utils.Operation.Update, ((MTSDetailsDTO)detalsSpecificBS.Current));
        }

        private void видалитиЗаписToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (detalsSpecificBS.Count > 0)
                DeleteDetail(((MTSCreateDetalsDTO)detalsSpecificBS.Current).ID);
            else
                MessageBox.Show("Помилка видалення деталі! Створіть спочатку деталі!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region Event's CRUD for MTSPurchasedProducts

        private void addBuyDetailBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditBuyDetail(Utils.Operation.Add, new MTSPurchasedProductsDTO() { SPECIFICATIONS_ID = ((MTSSpecificationsDTO)specificBS.Current).ID });
        }

        private void editBuyDetailBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditBuyDetail(Utils.Operation.Update, ((MTSPurchasedProductsDTO)byusDetalsSpecificBS.Current));
        }

        private void deleteBuyDetailBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (byusDetalsSpecificBS.Count > 0)
                DeleteBuyDetail(((MTSPurchasedProductsDTO)byusDetalsSpecificBS.Current).ID);
        }

        private void addBuyDetailBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditBuyDetail(Utils.Operation.Add, new MTSPurchasedProductsDTO() { SPECIFICATIONS_ID = ((MTSSpecificationsDTO)specificBS.Current).ID });
        }

        private void editBuyDetailBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditBuyDetail(Utils.Operation.Update, ((MTSPurchasedProductsDTO)byusDetalsSpecificBS.Current));
        }

        private void deleteBuyDetailBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (byusDetalsSpecificBS.Count > 0)
                DeleteBuyDetail(((MTSPurchasedProductsDTO)byusDetalsSpecificBS.Current).ID);
        }

        private void додатиЗаписToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditBuyDetail(Utils.Operation.Add, new MTSPurchasedProductsDTO() { SPECIFICATIONS_ID = ((MTSSpecificationsDTO)specificBS.Current).ID });
        }

        private void редагуватиЗаписToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditBuyDetail(Utils.Operation.Update, ((MTSPurchasedProductsDTO)byusDetalsSpecificBS.Current));
        }

        private void видалитиЗаписToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (byusDetalsSpecificBS.Count > 0)
                DeleteBuyDetail(((MTSPurchasedProductsDTO)byusDetalsSpecificBS.Current).ID);
        }

        #endregion

        #region Event's CRUD for MTSMaterials

        private void addMaterialBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditMaterial(Utils.Operation.Add, new MTSMaterialsDTO() { SPECIFICATIONS_ID = ((MTSSpecificationsDTO)specificBS.Current).ID });
        }

        private void editMaterialBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditMaterial(Utils.Operation.Update, ((MTSMaterialsDTO)materialsSpecificBS.Current));
        }

        private void deleteMaterialBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (materialsSpecificBS.Count > 0)
                DeleteBuyDetail(((MTSMaterialsDTO)materialsSpecificBS.Current).ID);
        }

        private void addMaterialDetailBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditMaterial(Utils.Operation.Add, new MTSMaterialsDTO() { SPECIFICATIONS_ID = ((MTSSpecificationsDTO)specificBS.Current).ID });
        }

        private void editMaterialDetailBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditMaterial(Utils.Operation.Update, ((MTSMaterialsDTO)materialsSpecificBS.Current));
        }

        private void deleteMaterialDetailBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (materialsSpecificBS.Count > 0)
                DeleteBuyDetail(((MTSMaterialsDTO)materialsSpecificBS.Current).ID);
        }

        private void додатиЗаписToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditMaterial(Utils.Operation.Add, new MTSMaterialsDTO() { SPECIFICATIONS_ID = ((MTSSpecificationsDTO)specificBS.Current).ID });
        }

        private void редагуватиЗаписToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditMaterial(Utils.Operation.Update, ((MTSMaterialsDTO)materialsSpecificBS.Current));
        }

        private void видалитиЗаписToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (materialsSpecificBS.Count > 0)
                DeleteBuyDetail(((MTSMaterialsDTO)materialsSpecificBS.Current).ID);
        }

        #endregion

        #region Report's

        private void mapRouteTechProcessBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (detalsSpecificBS.Count > 0)
            {
                reportService = Program.kernel.Get<IReportService>();

                reportService.PrintMapRouteTechProcess(((MTSSpecificationsDTO)specificBS.Current), (List<MTSDetailsDTO>)detalsSpecificBS.DataSource);
            }
        }

        private void showSpecificInFileBtb_ItemClick(object sender, ItemClickEventArgs e)
        {
            //SpecificationProcess(MTSSpecificationsDTO mtsSpecification, List<MTSDetailsDTO> mtsDetailsList, List<MTSPurchasedProductsDTO> mtsBuyDetailsList, List<MTSMaterialsDTO> mtsMaterialsList);
            reportService = Program.kernel.Get<IReportService>();
            reportService.SpecificationProcess(((MTSSpecificationsDTO)specificBS.Current), (List<MTSDetailsDTO>)detalsSpecificBS.DataSource, (List<MTSPurchasedProductsDTO>)byusDetalsSpecificBS.DataSource, (List<MTSMaterialsDTO>)materialsSpecificBS.DataSource);
        }


        private void PrintSummaryMapTechProcess()
        {




        }

        #endregion

        private void MtsSpecificationOldFm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                switch (xtraTabControl1.SelectedTabPageIndex)
                {
                    case 0:
                        EditDetailSpecific(Utils.Operation.Add, new MTSDetailsDTO() { SPECIFICATIONS_ID = ((MTSSpecificationsDTO)specificBS.Current).ID, PROCESSING_ID = 1 });
                        break;
                    case 1:
                        EditBuyDetail(Utils.Operation.Add, new MTSPurchasedProductsDTO() { SPECIFICATIONS_ID = ((MTSSpecificationsDTO)specificBS.Current).ID });
                        break;
                    case 2:
                        EditMaterial(Utils.Operation.Add, new MTSMaterialsDTO() { SPECIFICATIONS_ID = ((MTSSpecificationsDTO)specificBS.Current).ID });
                        break;
                    default:
                        break;
                }
            }
        }

        private void добавитьСпецификациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSpecification(Utils.Operation.Add, new MTSSpecificationsDTO(),userTaskDTO);
        }

        private void добавитьСводнуюСпецификациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSpecificationDetails(new MTSSpecificationsDTO(), Utils.Operation.Add);
        }

        private void редагуватиСпецифікаціюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (specificBS.Count > 0)
            {
                MTSSpecificationsDTO model = new MTSSpecificationsDTO()
                {
                    ID = ((MTSSpecificationsDTO)ItemSpecification).ID,
                    AUTHORIZATION_USERS_ID = ((MTSSpecificationsDTO)ItemSpecification).AUTHORIZATION_USERS_ID,
                    NAME = ((MTSSpecificationsDTO)ItemSpecification).NAME,
                    QUANTITY = ((MTSSpecificationsDTO)ItemSpecification).QUANTITY,
                    WEIGHT = ((MTSSpecificationsDTO)ItemSpecification).WEIGHT,
                    CREATION_DATE = ((MTSSpecificationsDTO)ItemSpecification).CREATION_DATE,
                    DRAWING = ((MTSSpecificationsDTO)ItemSpecification).DRAWING
                };
                AddSpecification(Utils.Operation.Update, (MTSSpecificationsDTO)model,userTaskDTO);
            }
            else MessageBox.Show("Помилка редагування специфікації! Створіть спочатку специфікацію!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void видалитиСпецифікаціюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (specificBS.Count > 0)
                DeleteSpecification();
            else MessageBox.Show("Помилка видалення специфікації! Створіть спочатку специфікацію!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void відобразитиСпецифікаціюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            reportService.SpecificationProcess(((MTSSpecificationsDTO)specificBS.Current), (List<MTSDetailsDTO>)detalsSpecificBS.DataSource, (List<MTSPurchasedProductsDTO>)byusDetalsSpecificBS.DataSource, (List<MTSMaterialsDTO>)materialsSpecificBS.DataSource);
        }

        private void mapTechProcessBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            reportService.MapTechProcess(((MTSSpecificationsDTO)specificBS.Current), (List<MTSDetailsDTO>)detalsSpecificBS.DataSource, false);

        }

        private void enableColorSpecificBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            SpecificationCheckMark();
        }

        #region RowMarker

        private void specificGridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle > -1)
            {
                MTSSpecificationsDTO item = (MTSSpecificationsDTO)specificGridView.GetRow(e.RowHandle);
                if (item.SET_COLOR == 1)
                    e.Appearance.BackColor = Color.PaleTurquoise;
            }
        }

        private void detalsSpecificGridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle > -1)
            {
                MTSDetailsDTO item = (MTSDetailsDTO)detalsSpecificGridView.GetRow(e.RowHandle);
                if (item.CHANGES == 1)
                    e.Appearance.BackColor = Color.PaleTurquoise;
            }
        }

        private void buysDetalsSpecificGridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle > -1)
            {
                MTSPurchasedProductsDTO item = (MTSPurchasedProductsDTO)buysDetalsSpecificGridView.GetRow(e.RowHandle);
                if (item.CHANGES == 1)
                    e.Appearance.BackColor = Color.PaleTurquoise;
            }
        }

        private void materialsSpecificGridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle > -1)
            {
                MTSMaterialsDTO item = (MTSMaterialsDTO)materialsSpecificGridView.GetRow(e.RowHandle);
                if (item.CHANGES == 1)
                    e.Appearance.BackColor = Color.PaleTurquoise;
            }
        }

        #endregion

        private void disableLabelMenuBtn_Click(object sender, EventArgs e)
        {
            SpecificationCheckMark();
        }

        private void enableLabelMenuBtn_Click(object sender, EventArgs e)
        {
            SpecificationCheckMark();
        }

        private void materialsSpecificGrid_Click(object sender, EventArgs e)
        {

        }

        private void mapTechProcessByDateBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            reportService.MapTechProcess(((MTSSpecificationsDTO)specificBS.Current), (List<MTSDetailsDTO>)detalsSpecificBS.DataSource, true);
        }

        private void mapAllTechProcessBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (MtsSpecificationQuantityOldEditFm mtsSpecificationQuantityOldEditFm = new MtsSpecificationQuantityOldEditFm())
            {
                if (mtsSpecificationQuantityOldEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int quantitySummaryItems = mtsSpecificationQuantityOldEditFm.Return();
                    reportService = Program.kernel.Get<IReportService>();
                    reportService.MapTechProcess(((MTSSpecificationsDTO)specificBS.Current), (List<MTSDetailsDTO>)detalsSpecificBS.DataSource, true, quantitySummaryItems);
                }
            }
        }
    }
}