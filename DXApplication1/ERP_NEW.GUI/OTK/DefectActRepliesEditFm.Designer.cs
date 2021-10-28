namespace ERP_NEW.GUI.OTK
{
    partial class DefectActRepliesEditFm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefectActRepliesEditFm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.defectActValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            this.documentDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.documentNumberTbox = new DevExpress.XtraEditors.TextEdit();
            this.documentTypeEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.imageCollection = new DevExpress.Utils.ImageCollection();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.detailsMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.clearBtn = new DevExpress.XtraEditors.SimpleButton();
            this.fileNameTbox = new DevExpress.XtraEditors.TextEdit();
            this.showBtn = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.openFileBtn = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.defectActValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentNumberTbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameTbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // defectActValidationProvider
            // 
            this.defectActValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            this.defectActValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.defectActValidationProviderValidationFailed);
            this.defectActValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.defectActValidationProvider_ValidationSucceeded);
            // 
            // documentDateEdit
            // 
            this.documentDateEdit.EditValue = null;
            this.documentDateEdit.Location = new System.Drawing.Point(326, 18);
            this.documentDateEdit.Name = "documentDateEdit";
            this.documentDateEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.documentDateEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.documentDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.documentDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.documentDateEdit.Size = new System.Drawing.Size(132, 20);
            this.documentDateEdit.TabIndex = 31;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Дата акту обов\'язково для заповнення";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.defectActValidationProvider.SetValidationRule(this.documentDateEdit, conditionValidationRule1);
            this.documentDateEdit.EditValueChanged += new System.EventHandler(this.documentDateEdit_EditValueChanged);
            // 
            // documentNumberTbox
            // 
            this.documentNumberTbox.Location = new System.Drawing.Point(79, 18);
            this.documentNumberTbox.Name = "documentNumberTbox";
            this.documentNumberTbox.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.documentNumberTbox.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.documentNumberTbox.Size = new System.Drawing.Size(217, 20);
            this.documentNumberTbox.TabIndex = 30;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Номер акту обов\'язково для заповнення";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.defectActValidationProvider.SetValidationRule(this.documentNumberTbox, conditionValidationRule2);
            this.documentNumberTbox.EditValueChanged += new System.EventHandler(this.documentNumberTBox_TextChanged);
            // 
            // documentTypeEdit
            // 
            this.documentTypeEdit.Location = new System.Drawing.Point(79, 44);
            this.documentTypeEdit.Name = "documentTypeEdit";
            this.documentTypeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("documentTypeEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("documentTypeEdit.Properties.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("documentTypeEdit.Properties.Buttons2"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("documentTypeEdit.Properties.Buttons3"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.documentTypeEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DocumentTypeName", "Тип документів")});
            this.documentTypeEdit.Properties.ShowHeader = false;
            this.documentTypeEdit.Size = new System.Drawing.Size(379, 22);
            this.documentTypeEdit.TabIndex = 42;
            this.documentTypeEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.documentTypeEdit_ButtonClick);
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(15, 286);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 38;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
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
            // labelControl12
            // 
            this.labelControl12.AllowHtmlString = true;
            this.labelControl12.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl12.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl12.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl12.Location = new System.Drawing.Point(6, 160);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(45, 26);
            this.labelControl12.TabIndex = 38;
            this.labelControl12.Text = "Опис<br>дефекту";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(6, 77);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(47, 13);
            this.labelControl11.TabIndex = 37;
            this.labelControl11.Text = "Висновки";
            // 
            // detailsMemoEdit
            // 
            this.detailsMemoEdit.Location = new System.Drawing.Point(79, 159);
            this.detailsMemoEdit.Name = "detailsMemoEdit";
            this.detailsMemoEdit.Size = new System.Drawing.Size(379, 80);
            this.detailsMemoEdit.TabIndex = 36;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(703, 281);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 36;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Location = new System.Drawing.Point(622, 281);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 35;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // descriptionMemoEdit
            // 
            this.descriptionMemoEdit.Location = new System.Drawing.Point(79, 72);
            this.descriptionMemoEdit.Name = "descriptionMemoEdit";
            this.descriptionMemoEdit.Size = new System.Drawing.Size(379, 81);
            this.descriptionMemoEdit.TabIndex = 35;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(302, 19);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(15, 13);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "від";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 13);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "№ документу";
            // 
            // clearBtn
            // 
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.Location = new System.Drawing.Point(247, 218);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(29, 23);
            this.clearBtn.TabIndex = 24;
            this.clearBtn.ToolTip = "Очистити";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // fileNameTbox
            // 
            this.fileNameTbox.Enabled = false;
            this.fileNameTbox.Location = new System.Drawing.Point(5, 220);
            this.fileNameTbox.Name = "fileNameTbox";
            this.fileNameTbox.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.fileNameTbox.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.fileNameTbox.Size = new System.Drawing.Size(208, 20);
            this.fileNameTbox.TabIndex = 21;
            // 
            // showBtn
            // 
            this.showBtn.Image = ((System.Drawing.Image)(resources.GetObject("showBtn.Image")));
            this.showBtn.Location = new System.Drawing.Point(279, 218);
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
            this.pictureEdit.Size = new System.Drawing.Size(303, 208);
            this.pictureEdit.TabIndex = 22;
            // 
            // openFileBtn
            // 
            this.openFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("openFileBtn.Image")));
            this.openFileBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.openFileBtn.Location = new System.Drawing.Point(216, 218);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(29, 23);
            this.openFileBtn.TabIndex = 4;
            this.openFileBtn.ToolTip = "Вибрати файл";
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.documentTypeEdit);
            this.panelControl1.Controls.Add(this.labelControl12);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.detailsMemoEdit);
            this.panelControl1.Controls.Add(this.descriptionMemoEdit);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.documentDateEdit);
            this.panelControl1.Controls.Add(this.documentNumberTbox);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Location = new System.Drawing.Point(4, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(463, 253);
            this.panelControl1.TabIndex = 37;
            // 
            // labelControl2
            // 
            this.labelControl2.AllowHtmlString = true;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.Location = new System.Drawing.Point(6, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 26);
            this.labelControl2.TabIndex = 43;
            this.labelControl2.Text = "Тип<br>документу";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.clearBtn);
            this.panelControl2.Controls.Add(this.fileNameTbox);
            this.panelControl2.Controls.Add(this.showBtn);
            this.panelControl2.Controls.Add(this.pictureEdit);
            this.panelControl2.Controls.Add(this.openFileBtn);
            this.panelControl2.Location = new System.Drawing.Point(473, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(315, 253);
            this.panelControl2.TabIndex = 34;
            // 
            // DefectActRepliesEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(790, 317);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefectActRepliesEditFm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Документи";
            ((System.ComponentModel.ISupportInitialize)(this.defectActValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentNumberTbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameTbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider defectActValidationProvider;
        private DevExpress.XtraEditors.DateEdit documentDateEdit;
        private DevExpress.XtraEditors.TextEdit documentNumberTbox;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.MemoEdit detailsMemoEdit;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton clearBtn;
        private DevExpress.XtraEditors.TextEdit fileNameTbox;
        private DevExpress.XtraEditors.SimpleButton showBtn;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private DevExpress.XtraEditors.SimpleButton openFileBtn;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit documentTypeEdit;
    }
}