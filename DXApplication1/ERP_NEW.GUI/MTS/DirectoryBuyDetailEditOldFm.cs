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
using ERP_NEW.BLL.DTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Services;

namespace ERP_NEW.GUI.MTS
{
    public partial class DirectoryBuyDetailEditOldFm : DevExpress.XtraEditors.XtraForm
    {
       // private Utils.Operation operation;
        private IMtsSpecificationsService mtsService;
        private BindingSource nomenclatureGroupsBS = new BindingSource();
        private BindingSource nomenclatureBS = new BindingSource();

        private ObjectBase Item
        {
            get { return nomenclatureBS.Current as ObjectBase; }
            set
            {
                nomenclatureBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public DirectoryBuyDetailEditOldFm(MTSNomenclaturesOldDTO model)
        {
            InitializeComponent();
           // this.operation = operation;

            nomenclatureBS.DataSource = Item = model;

            LoadNomenclatureGroups();
        }
        private void LoadNomenclatureGroups()
        {
            mtsService = Program.kernel.Get<IMtsSpecificationsService>();
            nomenclatureGroupsBS.DataSource = mtsService.GetAllNomenclatureGroupsOld();
            nomenclatureGroupsGrid.DataSource = nomenclatureGroupsBS;
            if (nomenclatureGroupsBS.Count == 0)
                nomenclatureGrid.DataSource = null;
            else 
            {
                nomenclatureGrid.DataSource = nomenclatureBS;
                LoadNomenclature(((MTSNomenclatureGroupsOldDTO)nomenclatureGroupsBS.Current).ID);
            }

        }
        private void LoadNomenclature(int nomenGroupId)
        {
            mtsService = Program.kernel.Get<IMtsSpecificationsService>();
            nomenclatureBS.DataSource = mtsService.GetAllNomenclatures(nomenGroupId);
            nomenclatureGrid.DataSource = nomenclatureBS;


        }
        public MTSNomenclaturesOldDTO Returnl()
        {
            return ((MTSNomenclaturesOldDTO)Item);
        }

        

        public MTSNomenclatureGroupsOldDTO Return()
        {
            return ((MTSNomenclatureGroupsOldDTO)Item);
        }

        //private void AddBuyMaterial(Utils.Operation operation, MTSNomenclaturesOldDTO buyDetails)
        //{
            
        //   // using (MtsBuyDetailEditOldFm mtsBuyDetailEditOldFm = new MtsBuyDetailEditOldFm(operation, buyDetails))
        //    MtsBuyDetailEditOldFm mtsBuyDetailEditOldFm = new MtsBuyDetailEditOldFm(operation, buyDetails);
           
        //        if (mtsBuyDetailEditOldFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //        {
        //            MTSNomenclaturesOldDTO getBuyMaterial = mtsBuyDetailEditOldFm.Return();
                    
        //        }
           
            
        //}
        private void nomenclatureGroupsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (nomenclatureGroupsBS.Count > 0)
                LoadNomenclature(((MTSNomenclatureGroupsOldDTO)nomenclatureGroupsBS.Current).ID);
        }
        
        private void nomenclatureGridView_DoubleClick(object sender, EventArgs e)
        {
         //   this.Item.EndEdit();
            MTSNomenclaturesOldDTO item = (MTSNomenclaturesOldDTO)nomenclatureBS.Current;   
            MTSNomenclaturesOldDTO model = new MTSNomenclaturesOldDTO()
            {
                ID = item.ID,
                NAME = item.NAME,
                GUAGE = item.GUAGE
            };
            DialogResult = DialogResult.OK;
            this.Close();
            
         //   AddBuyMaterial(Utils.Operation.Update, model);//(MTSNomenclaturesOldDTO)nomenclatureBS.Current);

        }

        private void DirectoryBuyDetailEditOldFm_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}