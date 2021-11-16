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
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Services;
using ERP_NEW.BLL.DTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;

namespace ERP_NEW.GUI.MTS
{
    public partial class MtsDetailsEditOldFm : DevExpress.XtraEditors.XtraForm
    {
        private Utils.Operation operation;
        private IMtsSpecificationsService mtsSpecificationsService;
        private BindingSource detailsBS = new BindingSource();
        private BindingSource createDetailsBS = new BindingSource();
        private MTSSpecificationssDTO specificDTO = new MTSSpecificationssDTO();
        private MTSDetailsDTO detailDTO = new MTSDetailsDTO();

        private ObjectBase Item
        {
            get { return detailsBS.Current as ObjectBase; }
            set
            {
                detailsBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public MtsDetailsEditOldFm(Utils.Operation operation, MTSDetailsDTO modelDetail)
        {
            InitializeComponent();
            this.operation=operation;
            detailsBS.DataSource = modelDetail;
            //this.specificDTO = modelSpecific;
            //this.detailDTO = modelDetail;
            mtsSpecificationsService = Program.kernel.Get<IMtsSpecificationsService>();



            detalsProccesingLookUpEdit.DataBindings.Add("EditValue", detailsBS, "PROCESSING_ID", true, DataSourceUpdateMode.OnPropertyChanged);
            createDetailsBS.DataSource = mtsSpecificationsService.GetDetailsProccesing();
            detalsProccesingLookUpEdit.Properties.DataSource = createDetailsBS;
            detalsProccesingLookUpEdit.Properties.ValueMember = "ID";
            detalsProccesingLookUpEdit.Properties.DisplayMember = "NAME";
            detalsProccesingLookUpEdit.Properties.NullText = "Немає данних";

            numberDrawingEdit.DataBindings.Add("EditValue", detailsBS, "DRAWING", true, DataSourceUpdateMode.OnPropertyChanged);
            nameEdit.DataBindings.Add("EditValue", detailsBS, "NAME", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityEdit.DataBindings.Add("EditValue", detailsBS, "QUANTITY", true, DataSourceUpdateMode.OnPropertyChanged);
            nomenclatureNameEdit.DataBindings.Add("EditValue", detailsBS, "NOMENCLATURESNAME", true, DataSourceUpdateMode.OnPropertyChanged);
            guageEdit.DataBindings.Add("EditValue", detailsBS, "GUAEGENAME", true, DataSourceUpdateMode.OnPropertyChanged);
            heightEdit.DataBindings.Add("EditValue", detailsBS, "HEIGHT", true, DataSourceUpdateMode.OnPropertyChanged);
            widthEdit.DataBindings.Add("EditValue", detailsBS, "WIDTH", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityOfBlankEdit.DataBindings.Add("EditValue", detailsBS, "QUANTITY_OF_BLANKS", true, DataSourceUpdateMode.OnPropertyChanged);
           




            if(operation==Utils.Operation.Update)
            {
                //numberDrawingEdit.EditValue = model.DRAWING;
                //nameEdit.EditValue = model.NAME;
                //quantityEdit.EditValue = model.QUANTITY;
                //nomenclatureNameEdit.EditValue = model.NOMENCLATURESNAME;
                //guageEdit.EditValue = model.GUAEGENAME;
                //heightEdit.EditValue = model.HEIGHT;
                //widthEdit.EditValue = model.WIDTH;
                //quantityOfBlankEdit.EditValue = model.QUANTITY_OF_BLANKS;
                //detalsProccesingLookUpEdit.EditValue = model.DETALSPROCESSING;
            }
        }
        public MTSDetailsDTO Return()
        {
            return ((MTSDetailsDTO)Item);
        }
        private bool Save()
        {
            mtsSpecificationsService = Program.kernel.Get<IMtsSpecificationsService>();
            if (operation == Utils.Operation.Add)
            {
                if (((MTSDetailsDTO)Item).CREATED_DETAILS_ID != null)
                {
                    MTSCreateDetalsDTO updateCreateDetails = new MTSCreateDetalsDTO();
                    updateCreateDetails.ID = (int)((MTSDetailsDTO)Item).CREATED_DETAILS_ID;
                    updateCreateDetails.NOMENCLATURE_ID = (int)((MTSDetailsDTO)Item).NOMENCLATURE_ID;
                    updateCreateDetails.PROCESSING_ID = (int)((MTSDetailsDTO)Item).PROCESSING_ID;
                    updateCreateDetails.NAME = ((MTSDetailsDTO)Item).NAME;
                    updateCreateDetails.DRAWING = ((MTSDetailsDTO)Item).DRAWING;
                    updateCreateDetails.WIDTH = ((MTSDetailsDTO)Item).WIDTH;
                    updateCreateDetails.HEIGHT = ((MTSDetailsDTO)Item).HEIGHT;
                    mtsSpecificationsService.MTSCreateDetalsUpdate(updateCreateDetails);
                }
                else
                {
                    MTSCreateDetalsDTO createCreateDetails = new MTSCreateDetalsDTO();
                    createCreateDetails.NOMENCLATURE_ID = (int)((MTSDetailsDTO)Item).NOMENCLATURE_ID;
                    createCreateDetails.PROCESSING_ID = (int)((MTSDetailsDTO)Item).PROCESSING_ID;
                    createCreateDetails.NAME = ((MTSDetailsDTO)Item).NAME;

                    createCreateDetails.DRAWING = ((MTSDetailsDTO)Item).DRAWING;
                    createCreateDetails.WIDTH = ((MTSDetailsDTO)Item).WIDTH;
                    createCreateDetails.HEIGHT = ((MTSDetailsDTO)Item).HEIGHT;
                    ((MTSDetailsDTO)Item).CREATED_DETAILS_ID = mtsSpecificationsService.MTSCreateDetalsCreate(createCreateDetails);
                }
                mtsSpecificationsService.MTSDetailCreate((MTSDetailsDTO)Item);
                return true;
            }
            else
            {
                MTSCreateDetalsDTO updateCreateDetails = new MTSCreateDetalsDTO();
                updateCreateDetails.ID = (int)((MTSDetailsDTO)Item).CREATED_DETAILS_ID;
                updateCreateDetails.NOMENCLATURE_ID = (int)((MTSDetailsDTO)Item).NOMENCLATURE_ID;
                updateCreateDetails.PROCESSING_ID = (int)((MTSDetailsDTO)Item).PROCESSING_ID;
                updateCreateDetails.NAME = ((MTSDetailsDTO)Item).NAME;
                updateCreateDetails.DRAWING = ((MTSDetailsDTO)Item).DRAWING;
                updateCreateDetails.WIDTH = ((MTSDetailsDTO)Item).WIDTH;
                updateCreateDetails.HEIGHT = ((MTSDetailsDTO)Item).HEIGHT;
                mtsSpecificationsService.MTSCreateDetalsUpdate(updateCreateDetails);

                mtsSpecificationsService.MTSDetailUpdate((MTSDetailsDTO)Item);
                return true;
            }
            


                //MTSCreateDetalsDTO createDetailsItem = new MTSCreateDetalsDTO()
                //{
                //    NOMENCLATURE_ID = specificDTO.ID,//((MTSCreateDetalsDTO)Item).NOMENCLATURE_ID,
                //    PROCESSING_ID = ((MTSCreateDetalsDTO)Item).PROCESSING_ID,
                //    NAME = ((MTSCreateDetalsDTO)Item).NAME,
                //    DRAWING = ((MTSCreateDetalsDTO)Item).DRAWING,
                //    WIDTH = ((MTSCreateDetalsDTO)Item).WIDTH,
                //    HEIGHT = ((MTSCreateDetalsDTO)Item).HEIGHT,

                //    QUANTITY = ((MTSCreateDetalsDTO)Item).QUANTITY,
                //    NOMENCLATURESNAME = specificDTO.NAME,//((MTSCreateDetalsDTO)Item).NOMENCLATURESNAME,
                //    GUAEGENAME = ((MTSCreateDetalsDTO)Item).GUAEGENAME,
                //    CREATEDETALSNAME = ((MTSCreateDetalsDTO)Item).CREATEDETALSNAME,
                //    QUANTITY_OF_BLANKS = ((MTSCreateDetalsDTO)Item).QUANTITY_OF_BLANKS,
                //    DETALSPROCESSING = ((MTSCreateDetalsDTO)Item).DETALSPROCESSING,
                //    PROCCESINGNAME = ((MTSCreateDetalsDTO)Item).PROCCESINGNAME
                //};
                //mtsService.MTSCreateDetailsCreate(createDetailsItem);
               // ((MTSCreateDetalsDTO)Item).ID=mtsService.MTSCreateDetailsCreate(((MTSCreateDetalsDTO)Item));

                //MTSDetailsDTO detailItem = new MTSDetailsDTO()
                //{
                //    SPECIFICATIONS_ID = specificDTO.ID,
                //    CREATED_DETAILS_ID = createDetailsItem.ID,
                //    QUANTITY_OF_BLANKS = createDetailsItem.QUANTITY_OF_BLANKS,
                //    QUANTITY = createDetailsItem.QUANTITY
                //};
                //mtsService.MTSDetailCreate(detailItem);
            
        }



        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (Save())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        // MessageBox.Show("Не вірний номер.Такий номер вже існує.", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //numberAccountingEdit.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при збереженні " + ex.Message, "Збереження матеріалу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void AddDirectoryDetail(MTSNomenclaturesOldDTO model)
        {
            using (DirectoryBuyDetailEditOldFm directoryBuyDetailEditOldFm = new DirectoryBuyDetailEditOldFm(model))
            //   DirectoryBuyDetailEditOldFm directoryBuyDetailEditOldFm = new DirectoryBuyDetailEditOldFm(model);
            {
                if (directoryBuyDetailEditOldFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MTSNomenclaturesOldDTO r = directoryBuyDetailEditOldFm.Returnl();

                    //MTSNomenclatureGroupsOldDTO return_Id = directoryBuyDetailEditOldFm.Return();
                    nomenclatureNameEdit.EditValue = r.NAME;
                    guageEdit.EditValue = r.GUAGE;
                      

                }

            }
        }

        private void directoryBuyDetailBtn_Click(object sender, EventArgs e)
        {
            AddDirectoryDetail(new MTSNomenclaturesOldDTO());
        }

        private void numberDrawingEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
           // Utils.OnlyNumbers(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                CheckDetail(numberDrawingEdit.Text);
            }
        }

        private void CheckDetail(string drawingNumber)
        {
            mtsSpecificationsService = Program.kernel.Get<IMtsSpecificationsService>();

            if (operation == Utils.Operation.Add)
            {
                var detailByDrawingName = mtsSpecificationsService.GetCreateDetalsByDrawingNumber(drawingNumber);
                if (detailByDrawingName != null)
                {
                    nameEdit.EditValue = ((MTSCreateDetalsDTO)detailByDrawingName).NAME;
                    nomenclatureNameEdit.EditValue = ((MTSCreateDetalsDTO)detailByDrawingName).NOMENCLATURESNAME;
                    guageEdit.EditValue = ((MTSCreateDetalsDTO)detailByDrawingName).GUAEGENAME;
                    detalsProccesingLookUpEdit.EditValue = ((MTSCreateDetalsDTO)detailByDrawingName).PROCESSING_ID;
                    heightEdit.EditValue = ((MTSCreateDetalsDTO)detailByDrawingName).HEIGHT;
                    widthEdit.EditValue = ((MTSCreateDetalsDTO)detailByDrawingName).WIDTH;
                    quantityOfBlankEdit.EditValue = 1;

                    ((MTSDetailsDTO)Item).CREATED_DETAILS_ID = detailByDrawingName.ID;
                    ((MTSDetailsDTO)Item).NOMENCLATURE_ID = detailByDrawingName.NOMENCLATURE_ID;

                }
                else
                {
                    ((MTSDetailsDTO)Item).CREATED_DETAILS_ID = null;
                }

            }
            else
            {


            }
            //loger.Info("Номенклатура: " + Nomenclature);

            

            //if (nomenclatureSearch.Count != 0)
            //{
            //    LoadReceipts(((ExpedinturesAccountantDTO)Item).EXP_DATE, nomenclatureSearch[0]);
            //}
            //else
            //{
            //    ClearNomenclature();
            //    nomenclatureEdit.Focus();
            //    MessageBox.Show("Номенклатура відсутня в базі даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            DialogResult = DialogResult.None;
        }

        private void detalsProccesingLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            switch ((int)detalsProccesingLookUpEdit.EditValue)
            {
                case 1:
                    processLabel.Text = "Розмір";
                    xlabel.Visible = false;
                    widthEdit.Visible = false;
                    break;
                case 2:
                    processLabel.Text = "Розмір";
                    xlabel.Visible = true;
                    widthEdit.Visible = true;
                    break;
                case 3:
                    processLabel.Text = "Діаметр";
                    xlabel.Visible = false;
                    widthEdit.Visible = false;
                    break;
                default:
                    break;
            }
        }
    }
}