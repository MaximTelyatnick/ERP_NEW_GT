namespace ERP_NEW.GUI.BusinessCard
{
    partial class BusinessCardPhotoFm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cameraControl = new DevExpress.XtraEditors.Camera.CameraControl();
            this.cameraImageEdit = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraImageEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(476, 332);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 53;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Location = new System.Drawing.Point(396, 332);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 52;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cameraControl
            // 
            this.cameraControl.Location = new System.Drawing.Point(2, 2);
            this.cameraControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cameraControl.Name = "cameraControl";
            this.cameraControl.ShowSettingsButton = false;
            this.cameraControl.Size = new System.Drawing.Size(549, 325);
            this.cameraControl.TabIndex = 54;
            this.cameraControl.Text = "cameraControl";
            this.cameraControl.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Error;
            this.cameraControl.VideoStretchMode = DevExpress.XtraEditors.Camera.VideoStretchMode.Stretch;
            this.cameraControl.Click += new System.EventHandler(this.cameraControl_Click);
            // 
            // cameraImageEdit
            // 
            this.cameraImageEdit.Location = new System.Drawing.Point(2, 2);
            this.cameraImageEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cameraImageEdit.Name = "cameraImageEdit";
            this.cameraImageEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.cameraImageEdit.Properties.ZoomAccelerationFactor = 1D;
            this.cameraImageEdit.Size = new System.Drawing.Size(549, 325);
            this.cameraImageEdit.TabIndex = 55;
            this.cameraImageEdit.Click += new System.EventHandler(this.cameraImageEdit_Click);
            // 
            // BusinessCardPhotoFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 358);
            this.Controls.Add(this.cameraImageEdit);
            this.Controls.Add(this.cameraControl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusinessCardPhotoFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Фото візитки";
            ((System.ComponentModel.ISupportInitialize)(this.cameraImageEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.Camera.CameraControl cameraControl;
        private DevExpress.XtraEditors.PictureEdit cameraImageEdit;
    }
}