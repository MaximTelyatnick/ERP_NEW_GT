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
using DevExpress.XtraEditors.Controls;
using Ninject;
using System.Web;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.GUI.Classifiers;

namespace ERP_NEW.GUI.MTS
{
    public partial class MtsSelectMaterialsEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IMtsNomenclaturesService mtsNomenclatureService;

        private BindingSource materialsBS = new BindingSource();

        private List<MtsNomenclaturesDTO> selectedList = new List<MtsNomenclaturesDTO>();

        public MtsSelectMaterialsEditFm(List<MtsNomenclaturesDTO> source)
        {
            InitializeComponent();

            materialsBS.DataSource = source;
            materialsGrid.DataSource = materialsBS;
        }

        #region Method's

        public List<MtsNomenclaturesDTO> Return()
        {
            return selectedList;
        }

        private MtsNomenclaturesDTO GetSingleMtsNomenclature(long id)
        {
            mtsNomenclatureService = Program.kernel.Get<IMtsNomenclaturesService>();
            return mtsNomenclatureService.GetNomenclarures().SingleOrDefault(n => n.Id == id);
        }

        private void EditMtsNomenclature(Utils.Operation operation, MtsNomenclaturesDTO model)
        {
            using (MtsNomenclatureEditFm mtsNomenclatureEditFm = new MtsNomenclatureEditFm(operation, model))
            {
                if (mtsNomenclatureEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    long return_Id = mtsNomenclatureEditFm.Return();
                    
                    materialsGridView.BeginDataUpdate();

                    var currMaterial = GetSingleMtsNomenclature(return_Id);

                    if (operation == Utils.Operation.Add)
                    {
                        materialsBS.Add(currMaterial);
                    }
                    else
                    {
                        ((MtsNomenclaturesDTO)materialsBS.Current).Name = currMaterial.Name;
                        ((MtsNomenclaturesDTO)materialsBS.Current).AdditCalculationActive = currMaterial.AdditCalculationActive;
                        ((MtsNomenclaturesDTO)materialsBS.Current).AdditUnitLocalName = currMaterial.AdditUnitLocalName;
                        ((MtsNomenclaturesDTO)materialsBS.Current).Gauge = currMaterial.Gauge;
                        ((MtsNomenclaturesDTO)materialsBS.Current).GostName = currMaterial.GostName;
                        ((MtsNomenclaturesDTO)materialsBS.Current).GroupName = currMaterial.GroupName;
                        ((MtsNomenclaturesDTO)materialsBS.Current).MtsGostId = currMaterial.MtsGostId;
                        ((MtsNomenclaturesDTO)materialsBS.Current).MtsNomenclatureGroupId = currMaterial.MtsNomenclatureGroupId;
                        ((MtsNomenclaturesDTO)materialsBS.Current).Note = currMaterial.Note;
                        ((MtsNomenclaturesDTO)materialsBS.Current).Price = currMaterial.Price;
                        ((MtsNomenclaturesDTO)materialsBS.Current).RatioOfWaste = currMaterial.RatioOfWaste;
                        ((MtsNomenclaturesDTO)materialsBS.Current).UnitId = currMaterial.UnitId;
                        ((MtsNomenclaturesDTO)materialsBS.Current).UnitLocalName = currMaterial.UnitLocalName;
                        ((MtsNomenclaturesDTO)materialsBS.Current).Weight = currMaterial.Weight;
                    }

                    materialsBS.EndEdit();
                    materialsGridView.EndDataUpdate();
                    
                    int rowHandle = materialsGridView.LocateByValue("Id", return_Id);
                    materialsGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        public void DeleteMaterial()
        {
            if (MessageBox.Show("Видалити матеріал із довідника?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mtsNomenclatureService = Program.kernel.Get<IMtsNomenclaturesService>();

                if (mtsNomenclatureService.NomenclarureDelete(((MtsNomenclaturesDTO)materialsBS.Current).Id))
                {
                    int rowHandle = materialsGridView.FocusedRowHandle - 1;
                    
                    materialsGridView.BeginDataUpdate();
                    materialsBS.RemoveCurrent();
                    materialsBS.EndEdit();
                    materialsGridView.EndDataUpdate();
                }
            }
        }

        #endregion

        #region Event's

        private void okBtn_Click(object sender, EventArgs e)
        {
            materialsGridView.CloseEditor();

            selectedList = ((List<MtsNomenclaturesDTO>)materialsBS.DataSource).Where(s => s.CheckForSelected).ToList();

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditMtsNomenclature(Utils.Operation.Add, new MtsNomenclaturesDTO());
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (materialsBS.Count > 0)
                EditMtsNomenclature(Utils.Operation.Update, (MtsNomenclaturesDTO)materialsBS.Current);
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (materialsBS.Count > 0)
                DeleteMaterial();
        }

        #endregion
    }
}