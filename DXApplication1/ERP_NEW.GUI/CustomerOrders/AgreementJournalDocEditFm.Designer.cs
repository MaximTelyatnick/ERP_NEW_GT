namespace ERP_NEW.GUI.CustomerOrders
{
    partial class AgreementJournalDocEditFm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgreementJournalDocEditFm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.agreementEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.renameFileTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.deleteFileBut = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.addFileBut = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nameFileDocEdit = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.nameTypeDocumentLookUp = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.typeDocCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cancelBut = new DevExpress.XtraEditors.SimpleButton();
            this.saveBut = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.agreementJournalDocValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agreementEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renameFileTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameFileDocEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTypeDocumentLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreementJournalDocValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.agreementEdit);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.renameFileTextEdit);
            this.panelControl1.Controls.Add(this.deleteFileBut);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.addFileBut);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.nameFileDocEdit);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.nameTypeDocumentLookUp);
            this.panelControl1.Controls.Add(this.cancelBut);
            this.panelControl1.Controls.Add(this.saveBut);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(682, 239);
            this.panelControl1.TabIndex = 0;
            // 
            // agreementEdit
            // 
            this.agreementEdit.Location = new System.Drawing.Point(12, 31);
            this.agreementEdit.Name = "agreementEdit";
            this.agreementEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.agreementEdit.Properties.ImmediatePopup = true;
            this.agreementEdit.Properties.PopupFormSize = new System.Drawing.Size(463, 0);
            this.agreementEdit.Properties.ReadOnly = true;
            this.agreementEdit.Properties.View = this.gridView1;
            this.agreementEdit.Size = new System.Drawing.Size(470, 20);
            this.agreementEdit.TabIndex = 54;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameCol});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // nameCol
            // 
            this.nameCol.Caption = "Номер договору";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.OptionsColumn.AllowEdit = false;
            this.nameCol.OptionsColumn.AllowFocus = false;
            this.nameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 0;
            this.nameCol.Width = 1000;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.8F);
            this.labelControl4.Location = new System.Drawing.Point(5, 11);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 14);
            this.labelControl4.TabIndex = 53;
            this.labelControl4.Text = "Договір";
            // 
            // renameFileTextEdit
            // 
            this.renameFileTextEdit.Location = new System.Drawing.Point(12, 125);
            this.renameFileTextEdit.Name = "renameFileTextEdit";
            this.renameFileTextEdit.Properties.ReadOnly = true;
            this.renameFileTextEdit.Size = new System.Drawing.Size(470, 20);
            this.renameFileTextEdit.TabIndex = 5;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.agreementJournalDocValidationProvider.SetValidationRule(this.renameFileTextEdit, conditionValidationRule1);
            this.renameFileTextEdit.EditValueChanged += new System.EventHandler(this.renameFileTextEdit_EditValueChanged);
            // 
            // deleteFileBut
            // 
            this.deleteFileBut.Image = ((System.Drawing.Image)(resources.GetObject("deleteFileBut.Image")));
            this.deleteFileBut.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.deleteFileBut.Location = new System.Drawing.Point(453, 172);
            this.deleteFileBut.Name = "deleteFileBut";
            this.deleteFileBut.Size = new System.Drawing.Size(29, 29);
            this.deleteFileBut.TabIndex = 3;
            this.deleteFileBut.Click += new System.EventHandler(this.deleteFileBut_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Location = new System.Drawing.Point(5, 105);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 14);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = " Ім\'я документу";
            // 
            // addFileBut
            // 
            this.addFileBut.Image = ((System.Drawing.Image)(resources.GetObject("addFileBut.Image")));
            this.addFileBut.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.addFileBut.Location = new System.Drawing.Point(420, 172);
            this.addFileBut.Name = "addFileBut";
            this.addFileBut.Size = new System.Drawing.Size(27, 29);
            this.addFileBut.TabIndex = 2;
            this.addFileBut.Click += new System.EventHandler(this.addFileBut_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Location = new System.Drawing.Point(5, 151);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 14);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Вибір документу";
            // 
            // nameFileDocEdit
            // 
            this.nameFileDocEdit.Location = new System.Drawing.Point(12, 171);
            this.nameFileDocEdit.Name = "nameFileDocEdit";
            this.nameFileDocEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameFileDocEdit.Size = new System.Drawing.Size(402, 30);
            this.nameFileDocEdit.TabIndex = 1;
            this.nameFileDocEdit.EditValueChanged += new System.EventHandler(this.nameFileDocEdit_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Location = new System.Drawing.Point(5, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 14);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Тип документу";
            // 
            // nameTypeDocumentLookUp
            // 
            this.nameTypeDocumentLookUp.EditValue = "[Немає даних]";
            this.nameTypeDocumentLookUp.Location = new System.Drawing.Point(12, 77);
            this.nameTypeDocumentLookUp.Name = "nameTypeDocumentLookUp";
            this.nameTypeDocumentLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("nameTypeDocumentLookUp.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("nameTypeDocumentLookUp.Properties.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("nameTypeDocumentLookUp.Properties.Buttons2"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.nameTypeDocumentLookUp.Properties.View = this.gridLookUpEdit1View;
            this.nameTypeDocumentLookUp.Size = new System.Drawing.Size(470, 22);
            this.nameTypeDocumentLookUp.TabIndex = 9;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.agreementJournalDocValidationProvider.SetValidationRule(this.nameTypeDocumentLookUp, conditionValidationRule2);
            this.nameTypeDocumentLookUp.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.nameTypeDocumentLookUp_ButtonClick);
            this.nameTypeDocumentLookUp.EditValueChanged += new System.EventHandler(this.nameTypeDocumentLookUp_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.typeDocCol});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsFind.AlwaysVisible = true;
            this.gridLookUpEdit1View.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridLookUpEdit1View.OptionsFind.SearchInPreview = true;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // typeDocCol
            // 
            this.typeDocCol.Caption = "Типи документів";
            this.typeDocCol.FieldName = "TypeDocuments";
            this.typeDocCol.Name = "typeDocCol";
            this.typeDocCol.OptionsColumn.AllowEdit = false;
            this.typeDocCol.OptionsColumn.AllowFocus = false;
            this.typeDocCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.typeDocCol.Visible = true;
            this.typeDocCol.VisibleIndex = 0;
            // 
            // cancelBut
            // 
            this.cancelBut.Location = new System.Drawing.Point(584, 209);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(88, 23);
            this.cancelBut.TabIndex = 8;
            this.cancelBut.Text = "Відмінити";
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
            // 
            // saveBut
            // 
            this.saveBut.Location = new System.Drawing.Point(488, 209);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(90, 23);
            this.saveBut.TabIndex = 7;
            this.saveBut.Text = "Зберегти";
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pictureEdit);
            this.panelControl2.Location = new System.Drawing.Point(488, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(184, 196);
            this.panelControl2.TabIndex = 6;
            // 
            // pictureEdit
            // 
            this.pictureEdit.AllowDrop = true;
            this.pictureEdit.Location = new System.Drawing.Point(5, 5);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pictureEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.pictureEdit.Properties.Appearance.Options.UseFont = true;
            this.pictureEdit.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit.Properties.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureEdit.Properties.ErrorImage")));
            this.pictureEdit.Properties.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureEdit.Properties.InitialImage")));
            this.pictureEdit.Properties.NullText = "Документ не додано";
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit.Size = new System.Drawing.Size(172, 186);
            this.pictureEdit.TabIndex = 4;
            this.pictureEdit.ToolTip = "Для відкриття документу двічі натисніть на на файл";
            this.pictureEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            this.pictureEdit.EditValueChanged += new System.EventHandler(this.pictureEdit_EditValueChanged);
            this.pictureEdit.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureEdit_DragDrop);
            this.pictureEdit.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureEdit_DragEnter);
            this.pictureEdit.DoubleClick += new System.EventHandler(this.pictureEdit_DoubleClick);
            // 
            // agreementJournalDocValidationProvider
            // 
            this.agreementJournalDocValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.agreementJournalDocValidationProvider_ValidationFailed);
            this.agreementJournalDocValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.agreementJournalDocValidationProvider_ValidationSucceeded);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("sendpdf_32x32.png", "images/mail/sendpdf_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/sendpdf_32x32.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "sendpdf_32x32.png");
            this.imageCollection.InsertGalleryImage("open2_32x32.png", "images/actions/open2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/open2_32x32.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "open2_32x32.png");
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // AgreementJournalDocEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 239);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgreementJournalDocEditFm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редагувааня документа";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agreementEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renameFileTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameFileDocEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTypeDocumentLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreementJournalDocValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider agreementJournalDocValidationProvider;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton cancelBut;
        private DevExpress.XtraEditors.SimpleButton saveBut;
        private DevExpress.XtraEditors.SimpleButton deleteFileBut;
        private DevExpress.XtraEditors.SimpleButton addFileBut;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit nameTypeDocumentLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn typeDocCol;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit renameFileTextEdit;
        private DevExpress.XtraEditors.MemoEdit nameFileDocEdit;
        private DevExpress.XtraEditors.GridLookUpEdit agreementEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}