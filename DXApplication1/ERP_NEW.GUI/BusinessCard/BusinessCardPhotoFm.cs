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

namespace ERP_NEW.GUI.BusinessCard
{
    public partial class BusinessCardPhotoFm : DevExpress.XtraEditors.XtraForm
    {

        
        Image captureImage;

        public BusinessCardPhotoFm()
        {
            InitializeComponent();
            cameraImageEdit.Visible = false;
        }

        private void cameraControl_Click(object sender, EventArgs e)
        {
            captureImage = cameraControl.TakeSnapshot();
            cameraImageEdit.Image = captureImage;
            //cameraControl.Stop();
            cameraControl.Visible = false;
            cameraImageEdit.Visible = true;

            //cameraControl.Start();


        }

        private void cameraImageEdit_Click(object sender, EventArgs e)
        {
            //cameraControl.Start();
            cameraControl.Visible = true;
            cameraImageEdit.Visible = false;
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            captureImage = cameraControl.TakeSnapshot();
            cameraImageEdit.Image = captureImage;
            //cameraControl.Stop();

            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cameraControl.Stop();
            
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public Image Return()
        {
            return cameraImageEdit.Image;
        }  
    }
}