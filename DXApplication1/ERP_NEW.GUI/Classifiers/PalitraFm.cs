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
using Ninject;
using ERP_NEW.BLL.Interfaces;
using DevExpress.XtraGrid.Views.Grid;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.Classifiers
{
    public partial class PalitraFm : DevExpress.XtraEditors.XtraForm
    {
        private IInfrastructureService infrastructureService;
        private List<ColorsDTO> colorsPallete = new List<ColorsDTO>();

        private BindingSource colorsBS = new BindingSource();
        public PalitraFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            //infrastructureService = Program.kernel.Get<IInfrastructureService>();
            //colorsBS.DataSource = infrastructureService.GetColorsAll();
            //palitraGrid.DataSource = colorsBS;
            LoadData();
            //palitraGrid.
        }
        private void LoadData()
        {
            infrastructureService = Program.kernel.Get<IInfrastructureService>();
           colorsBS.DataSource = infrastructureService.GetColorsAll();
            palitraGrid.DataSource = colorsBS;
        
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void PalitraGridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView gv = sender as GridView;

            if (e.Column.Name == "colorCodeCol")
            {

                string currentRowColor = gv.GetRowCellValue(e.RowHandle, "Name").ToString();
                e.Appearance.BackColor = Color.FromName(currentRowColor);
                //bool? cellValue = Convert.ToBoolean(gv.GetRowCellValue(e.RowHandle, "Correction"));
                //if (cellValue == true)
                //    e.Appearance.BackColor = Color.Orange;
            }

        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (PalitraEditFm palitraEditFm = new PalitraEditFm(Utils.Operation.Add, new ColorsDTO()))
            {
                if (palitraEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                   ColorsDTO return_Id = palitraEditFm.Return();
                    palitraGridView.BeginDataUpdate();
                    LoadData();
                    palitraGridView.EndDataUpdate();
                    int rowHandle = palitraGridView.LocateByValue("Id", return_Id);
                    palitraGridView.FocusedRowHandle = rowHandle;

                }
            }
          
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (PalitraEditFm palitraEditFm = new PalitraEditFm(Utils.Operation.Update, (ColorsDTO)colorsBS.Current))
            {
                if (palitraEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ColorsDTO return_Id = palitraEditFm.Return();
                    palitraGridView.BeginDataUpdate();
                    LoadData();
                    palitraGridView.EndDataUpdate();
                    int rowHandle = palitraGridView.LocateByValue("Id", return_Id);
                    palitraGridView.FocusedRowHandle = rowHandle;
                }
            }
           
        }

        private void delBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            colorDelete();
        }
        private void colorDelete()
        {
             
            if (colorsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити колір?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    infrastructureService = Program.kernel.Get<IInfrastructureService>();
                    int rowHandle = palitraGridView.FocusedRowHandle - 1;
                    palitraGridView.BeginDataUpdate();

                  //  if ((((ColorsDTO)colorsBS.Current).Id) != null) 
                        infrastructureService.ColorsDelete(((ColorsDTO)colorsBS.Current).Id);
                    LoadData();
                    palitraGridView.EndDataUpdate();
                    palitraGridView.FocusedRowHandle = (palitraGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }

        private void додатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PalitraEditFm palitraEditFm = new PalitraEditFm(Utils.Operation.Add, new ColorsDTO()))
            {
                if (palitraEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ColorsDTO return_Id = palitraEditFm.Return();
                    palitraGridView.BeginDataUpdate();
                    LoadData();
                    palitraGridView.EndDataUpdate();
                    int rowHandle = palitraGridView.LocateByValue("Id", return_Id);
                    palitraGridView.FocusedRowHandle = rowHandle;

                }
            }
        }

        private void редагуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PalitraEditFm palitraEditFm = new PalitraEditFm(Utils.Operation.Update, (ColorsDTO)colorsBS.Current))
            {
                if (palitraEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ColorsDTO return_Id = palitraEditFm.Return();
                    palitraGridView.BeginDataUpdate();
                    LoadData();
                    palitraGridView.EndDataUpdate();
                    int rowHandle = palitraGridView.LocateByValue("Id", return_Id);
                    palitraGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити колір?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    infrastructureService = Program.kernel.Get<IInfrastructureService>();
                    int rowHandle = palitraGridView.FocusedRowHandle - 1;
                    palitraGridView.BeginDataUpdate();

                    //  if ((((ColorsDTO)colorsBS.Current).Id) != null) 
                    infrastructureService.ColorsDelete(((ColorsDTO)colorsBS.Current).Id);
                    LoadData();
                    palitraGridView.EndDataUpdate();
                    palitraGridView.FocusedRowHandle = (palitraGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }
        
    }
}