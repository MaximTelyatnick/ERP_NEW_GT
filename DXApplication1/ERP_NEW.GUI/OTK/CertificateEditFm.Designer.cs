namespace ERP_NEW.GUI.OTK
{
    partial class CertificateEditFm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CertificateEditFm));
            this.certificateNumberTbox = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.checkDateEdit = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.certificateDateEndTbox = new DevExpress.XtraEditors.DateEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.manufacturerInfoMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.certificateDateTbox = new DevExpress.XtraEditors.DateEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.clearBtn = new DevExpress.XtraEditors.SimpleButton();
            this.fileNameTbox = new DevExpress.XtraEditors.TextEdit();
            this.showBtn = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.openFileBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.closeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.clearTwoBtn = new DevExpress.XtraEditors.SimpleButton();
            this.fileNameTwoTBox = new DevExpress.XtraEditors.TextEdit();
            this.showTwoBtn = new DevExpress.XtraEditors.SimpleButton();
            this.pictureTwoEdit = new DevExpress.XtraEditors.PictureEdit();
            this.openFileTwoBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumberTbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateDateEndTbox.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateDateEndTbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerInfoMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateDateTbox.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateDateTbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameTbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameTwoTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTwoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // certificateNumberTbox
            // 
            this.certificateNumberTbox.Location = new System.Drawing.Point(110, 34);
            this.certificateNumberTbox.Name = "certificateNumberTbox";
            this.certificateNumberTbox.Size = new System.Drawing.Size(542, 20);
            this.certificateNumberTbox.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.checkDateEdit);
            this.panelControl1.Controls.Add(this.labelControl13);
            this.panelControl1.Controls.Add(this.certificateDateEndTbox);
            this.panelControl1.Controls.Add(this.labelControl12);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.descriptionMemoEdit);
            this.panelControl1.Controls.Add(this.manufacturerInfoMemoEdit);
            this.panelControl1.Controls.Add(this.separatorControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.certificateDateTbox);
            this.panelControl1.Controls.Add(this.certificateNumberTbox);
            this.panelControl1.Location = new System.Drawing.Point(2, 7);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(672, 224);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // checkDateEdit
            // 
            this.checkDateEdit.Location = new System.Drawing.Point(251, 86);
            this.checkDateEdit.Name = "checkDateEdit";
            this.checkDateEdit.Properties.Caption = "Безстроковий сертифікат";
            this.checkDateEdit.Size = new System.Drawing.Size(244, 19);
            this.checkDateEdit.TabIndex = 27;
            this.checkDateEdit.CheckedChanged += new System.EventHandler(this.checkDateEdit_CheckedChanged);
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(9, 88);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(90, 13);
            this.labelControl13.TabIndex = 26;
            this.labelControl13.Text = "Дата завершення";
            // 
            // certificateDateEndTbox
            // 
            this.certificateDateEndTbox.EditValue = null;
            this.certificateDateEndTbox.Location = new System.Drawing.Point(110, 86);
            this.certificateDateEndTbox.Name = "certificateDateEndTbox";
            this.certificateDateEndTbox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.certificateDateEndTbox.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.certificateDateEndTbox.Size = new System.Drawing.Size(135, 20);
            this.certificateDateEndTbox.TabIndex = 25;
            // 
            // labelControl12
            // 
            this.labelControl12.AllowHtmlString = true;
            this.labelControl12.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl12.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl12.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl12.Location = new System.Drawing.Point(6, 166);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(57, 26);
            this.labelControl12.TabIndex = 24;
            this.labelControl12.Text = "Додаткова<br>інформація";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(8, 114);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(48, 13);
            this.labelControl11.TabIndex = 23;
            this.labelControl11.Text = "Виробник";
            // 
            // descriptionMemoEdit
            // 
            this.descriptionMemoEdit.Location = new System.Drawing.Point(110, 165);
            this.descriptionMemoEdit.Name = "descriptionMemoEdit";
            this.descriptionMemoEdit.Size = new System.Drawing.Size(555, 47);
            this.descriptionMemoEdit.TabIndex = 3;
            // 
            // manufacturerInfoMemoEdit
            // 
            this.manufacturerInfoMemoEdit.Location = new System.Drawing.Point(110, 112);
            this.manufacturerInfoMemoEdit.Name = "manufacturerInfoMemoEdit";
            this.manufacturerInfoMemoEdit.Size = new System.Drawing.Size(555, 47);
            this.manufacturerInfoMemoEdit.TabIndex = 2;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(6, 5);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(659, 23);
            this.separatorControl1.TabIndex = 20;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Дата початку";
            // 
            // labelControl1
            // 
            this.labelControl1.AllowHtmlString = true;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.Location = new System.Drawing.Point(10, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 26);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "№ сертифікату/<br>паспорту";
            // 
            // certificateDateTbox
            // 
            this.certificateDateTbox.EditValue = null;
            this.certificateDateTbox.Location = new System.Drawing.Point(110, 60);
            this.certificateDateTbox.Name = "certificateDateTbox";
            this.certificateDateTbox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.certificateDateTbox.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.certificateDateTbox.Size = new System.Drawing.Size(135, 20);
            this.certificateDateTbox.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.clearBtn);
            this.panelControl2.Controls.Add(this.fileNameTbox);
            this.panelControl2.Controls.Add(this.showBtn);
            this.panelControl2.Controls.Add(this.pictureEdit);
            this.panelControl2.Controls.Add(this.openFileBtn);
            this.panelControl2.Location = new System.Drawing.Point(10, 237);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(329, 224);
            this.panelControl2.TabIndex = 2;
            // 
            // clearBtn
            // 
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.Location = new System.Drawing.Point(254, 193);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(29, 23);
            this.clearBtn.TabIndex = 24;
            this.clearBtn.ToolTip = "Очистити";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // fileNameTbox
            // 
            this.fileNameTbox.Enabled = false;
            this.fileNameTbox.Location = new System.Drawing.Point(5, 193);
            this.fileNameTbox.Name = "fileNameTbox";
            this.fileNameTbox.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.fileNameTbox.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.fileNameTbox.Size = new System.Drawing.Size(208, 20);
            this.fileNameTbox.TabIndex = 21;
            // 
            // showBtn
            // 
            this.showBtn.Image = ((System.Drawing.Image)(resources.GetObject("showBtn.Image")));
            this.showBtn.Location = new System.Drawing.Point(289, 193);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(29, 23);
            this.showBtn.TabIndex = 23;
            this.showBtn.ToolTip = "Переглянути файл";
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // pictureEdit
            // 
            this.pictureEdit.Location = new System.Drawing.Point(5, 5);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit.Size = new System.Drawing.Size(317, 182);
            this.pictureEdit.TabIndex = 22;
            // 
            // openFileBtn
            // 
            this.openFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("openFileBtn.Image")));
            this.openFileBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.openFileBtn.Location = new System.Drawing.Point(219, 193);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(29, 23);
            this.openFileBtn.TabIndex = 4;
            this.openFileBtn.ToolTip = "Вибрати файл";
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Location = new System.Drawing.Point(350, 467);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(169, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(525, 467);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(149, 23);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Відміна";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("attach_32x32.png", "images/mail/attach_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/attach_32x32.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "attach_32x32.png");
            this.imageCollection.InsertGalleryImage("sendpdf_32x32.png", "images/mail/sendpdf_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/sendpdf_32x32.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "sendpdf_32x32.png");
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.clearTwoBtn);
            this.panelControl3.Controls.Add(this.fileNameTwoTBox);
            this.panelControl3.Controls.Add(this.showTwoBtn);
            this.panelControl3.Controls.Add(this.pictureTwoEdit);
            this.panelControl3.Controls.Add(this.openFileTwoBtn);
            this.panelControl3.Location = new System.Drawing.Point(345, 237);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(329, 224);
            this.panelControl3.TabIndex = 4;
            // 
            // clearTwoBtn
            // 
            this.clearTwoBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearTwoBtn.Image")));
            this.clearTwoBtn.Location = new System.Drawing.Point(258, 193);
            this.clearTwoBtn.Name = "clearTwoBtn";
            this.clearTwoBtn.Size = new System.Drawing.Size(29, 23);
            this.clearTwoBtn.TabIndex = 24;
            this.clearTwoBtn.ToolTip = "Очистити";
            this.clearTwoBtn.Click += new System.EventHandler(this.clearTwoBtn_Click);
            // 
            // fileNameTwoTBox
            // 
            this.fileNameTwoTBox.Enabled = false;
            this.fileNameTwoTBox.Location = new System.Drawing.Point(5, 193);
            this.fileNameTwoTBox.Name = "fileNameTwoTBox";
            this.fileNameTwoTBox.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.fileNameTwoTBox.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.fileNameTwoTBox.Size = new System.Drawing.Size(208, 20);
            this.fileNameTwoTBox.TabIndex = 21;
            // 
            // showTwoBtn
            // 
            this.showTwoBtn.Image = ((System.Drawing.Image)(resources.GetObject("showTwoBtn.Image")));
            this.showTwoBtn.Location = new System.Drawing.Point(293, 193);
            this.showTwoBtn.Name = "showTwoBtn";
            this.showTwoBtn.Size = new System.Drawing.Size(29, 23);
            this.showTwoBtn.TabIndex = 23;
            this.showTwoBtn.ToolTip = "Переглянути файл";
            this.showTwoBtn.Click += new System.EventHandler(this.showTwoBtn_Click);
            // 
            // pictureTwoEdit
            // 
            this.pictureTwoEdit.Location = new System.Drawing.Point(5, 5);
            this.pictureTwoEdit.Name = "pictureTwoEdit";
            this.pictureTwoEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureTwoEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureTwoEdit.Properties.ZoomAccelerationFactor = 1D;
            this.pictureTwoEdit.Size = new System.Drawing.Size(317, 182);
            this.pictureTwoEdit.TabIndex = 22;
            // 
            // openFileTwoBtn
            // 
            this.openFileTwoBtn.Image = ((System.Drawing.Image)(resources.GetObject("openFileTwoBtn.Image")));
            this.openFileTwoBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.openFileTwoBtn.Location = new System.Drawing.Point(219, 193);
            this.openFileTwoBtn.Name = "openFileTwoBtn";
            this.openFileTwoBtn.Size = new System.Drawing.Size(29, 23);
            this.openFileTwoBtn.TabIndex = 4;
            this.openFileTwoBtn.ToolTip = "Вибрати файл";
            this.openFileTwoBtn.Click += new System.EventHandler(this.openFileTwoBtn_Click);
            // 
            // CertificateEditFm
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 497);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CertificateEditFm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сертифікат/паспорт";
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumberTbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateDateEndTbox.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateDateEndTbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerInfoMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateDateTbox.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateDateTbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileNameTbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileNameTwoTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTwoEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit certificateNumberTbox;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit certificateDateTbox;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.SimpleButton closeBtn;
        private DevExpress.XtraEditors.SimpleButton openFileBtn;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private DevExpress.XtraEditors.SimpleButton showBtn;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraEditors.TextEdit fileNameTbox;
        private DevExpress.XtraEditors.SimpleButton clearBtn;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
        private DevExpress.XtraEditors.MemoEdit manufacturerInfoMemoEdit;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton clearTwoBtn;
        private DevExpress.XtraEditors.TextEdit fileNameTwoTBox;
        private DevExpress.XtraEditors.SimpleButton showTwoBtn;
        private DevExpress.XtraEditors.PictureEdit pictureTwoEdit;
        private DevExpress.XtraEditors.SimpleButton openFileTwoBtn;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.DateEdit certificateDateEndTbox;
        private DevExpress.XtraEditors.CheckEdit checkDateEdit;
    }
}