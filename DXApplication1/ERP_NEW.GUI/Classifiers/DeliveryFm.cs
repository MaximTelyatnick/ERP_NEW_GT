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
using Ninject;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System.IO;
using DevExpress.XtraBars;
using System.Diagnostics;
using ERP_NEW.BLL.Infrastructure;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace ERP_NEW.GUI.Classifiers
{
    public partial class DeliveryFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService deliveryService;
        private BindingSource deliveryBS = new BindingSource();

        public ObjectBase Item
        {
            get { return deliveryBS.Current as ObjectBase; }
            set
            {
                deliveryBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public DeliveryFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            LoadDelivery();

        }
        #region Method's     

        private void LoadDelivery()
        {
            deliveryService = Program.kernel.Get<IStoreHouseService>();
            deliveryBS.DataSource = deliveryService.GetDelivery();
            deliveryGrid.DataSource = deliveryBS;
        }
       
        private void EditDelivery(Utils.Operation operation, DeliveryDTO model)
        {
            using (DeliveryEditFm deliveryEditFm = new DeliveryEditFm(operation, model))
            {
                if (deliveryEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DeliveryDTO return_Id = deliveryEditFm.Return();

                    deliveryGridView.BeginDataUpdate();

                    LoadDelivery();

                    deliveryGridView.EndDataUpdate();

                    int rowHandle = deliveryGridView.LocateByValue("Id", return_Id.Id);

                    deliveryGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void DeleteDelivery()
        {
            if (deliveryBS.Count != 0)
            {
                if (MessageBox.Show("Видалити запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    deliveryService = Program.kernel.Get<IStoreHouseService>();
                    int rowHandle = deliveryGridView.FocusedRowHandle - 1;
                    if ((((DeliveryDTO)deliveryBS.Current).Id) != 0)
                    {
                        if (deliveryService.DeliveryDelete(((DeliveryDTO)deliveryBS.Current).Id))
                        {
                            deliveryGridView.BeginDataUpdate();
                            LoadDelivery();
                        }
                    }
                    else
                    {
                        deliveryService.DeliveryDelete(((DeliveryDTO)deliveryBS.Current).Id);
                    }

                    deliveryGridView.EndDataUpdate();
                    deliveryGridView.FocusedRowHandle = (deliveryGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }
        #endregion

        #region Event's   
        
        private void addBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditDelivery(Utils.Operation.Add, new DeliveryDTO());
        }

        private void editBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditDelivery(Utils.Operation.Update, (DeliveryDTO)deliveryBS.Current);
        }

        private void deleteBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteDelivery();
        }
        #endregion
    }
}