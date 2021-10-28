namespace ERP_NEW.GUI.Marketing
{
    partial class ShipmentListEditFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipmentListEditFm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.closeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.orderNumberEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.orderDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.clearBtn = new DevExpress.XtraEditors.SimpleButton();
            this.showBtn = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.openFileBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.fileNameTbox = new DevExpress.XtraEditors.TextEdit();
            this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.documentTypeEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.shipmentDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.shipmentNumberTbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.shipmentValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.orderNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contractorCol = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameTbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentNumberTbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(714, 281);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 36;
            this.closeBtn.Text = "Відміна";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // orderNumberEdit
            // 
            this.orderNumberEdit.Location = new System.Drawing.Point(79, 9);
            this.orderNumberEdit.Name = "orderNumberEdit";
            this.orderNumberEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.orderNumberEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderNumberEdit.Properties.ImmediatePopup = true;
            this.orderNumberEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.orderNumberEdit.Properties.PopupFormSize = new System.Drawing.Size(553, 0);
            this.orderNumberEdit.Properties.View = this.gridLookUpEdit1View;
            this.orderNumberEdit.Size = new System.Drawing.Size(217, 20);
            this.orderNumberEdit.TabIndex = 41;
            conditionValidationRule1.CaseSensitive = true;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Виберіть номер заказу";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.shipmentValidationProvider.SetValidationRule(this.orderNumberEdit, conditionValidationRule1);
            this.orderNumberEdit.EditValueChanged += new System.EventHandler(this.orderNumberEdit_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.orderNumberCol,
            this.orderDateCol,
            this.contractorCol});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridLookUpEdit1View.OptionsFind.AlwaysVisible = true;
            this.gridLookUpEdit1View.OptionsFind.SearchInPreview = true;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(302, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 13);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "від";
            // 
            // orderDateEdit
            // 
            this.orderDateEdit.EditValue = null;
            this.orderDateEdit.Enabled = false;
            this.orderDateEdit.Location = new System.Drawing.Point(326, 9);
            this.orderDateEdit.Name = "orderDateEdit";
            this.orderDateEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.orderDateEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.orderDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderDateEdit.Size = new System.Drawing.Size(132, 20);
            this.orderDateEdit.TabIndex = 39;
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
            this.pictureEdit.Location = new System.Drawing.Point(24, 5);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit.Size = new System.Drawing.Size(271, 208);
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
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(8, 131);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(57, 13);
            this.labelControl11.TabIndex = 37;
            this.labelControl11.Text = "Додатково";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.clearBtn);
            this.panelControl2.Controls.Add(this.fileNameTbox);
            this.panelControl2.Controls.Add(this.showBtn);
            this.panelControl2.Controls.Add(this.pictureEdit);
            this.panelControl2.Controls.Add(this.openFileBtn);
            this.panelControl2.Location = new System.Drawing.Point(476, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(315, 253);
            this.panelControl2.TabIndex = 34;
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
            // descriptionMemoEdit
            // 
            this.descriptionMemoEdit.Location = new System.Drawing.Point(79, 129);
            this.descriptionMemoEdit.Name = "descriptionMemoEdit";
            this.descriptionMemoEdit.Size = new System.Drawing.Size(379, 47);
            this.descriptionMemoEdit.TabIndex = 35;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.documentTypeEdit);
            this.panelControl1.Controls.Add(this.orderNumberEdit);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.orderDateEdit);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.descriptionMemoEdit);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.shipmentDateEdit);
            this.panelControl1.Controls.Add(this.shipmentNumberTbox);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Location = new System.Drawing.Point(7, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(463, 253);
            this.panelControl1.TabIndex = 37;
            // 
            // labelControl2
            // 
            this.labelControl2.AllowHtmlString = true;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.Location = new System.Drawing.Point(8, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 26);
            this.labelControl2.TabIndex = 45;
            this.labelControl2.Text = "Тип<br>документу";
            // 
            // documentTypeEdit
            // 
            this.documentTypeEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.documentTypeEdit.Location = new System.Drawing.Point(79, 47);
            this.documentTypeEdit.Name = "documentTypeEdit";
            this.documentTypeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("documentTypeEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("documentTypeEdit.Properties.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("documentTypeEdit.Properties.Buttons2"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.documentTypeEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DocumentTypeName", "Тип документів")});
            this.documentTypeEdit.Properties.ShowHeader = false;
            this.documentTypeEdit.Size = new System.Drawing.Size(379, 22);
            this.documentTypeEdit.TabIndex = 44;
            conditionValidationRule2.CaseSensitive = true;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule2.ErrorText = "Виберіть тип документу";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule2.Value1 = 0;
            this.shipmentValidationProvider.SetValidationRule(this.documentTypeEdit, conditionValidationRule2);
            this.documentTypeEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.documentTypeEdit_ButtonClick);
            this.documentTypeEdit.EditValueChanged += new System.EventHandler(this.documentTypesEdit_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(8, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(29, 13);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "Заказ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(302, 91);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(15, 13);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "від";
            // 
            // shipmentDateEdit
            // 
            this.shipmentDateEdit.EditValue = null;
            this.shipmentDateEdit.Location = new System.Drawing.Point(326, 90);
            this.shipmentDateEdit.Name = "shipmentDateEdit";
            this.shipmentDateEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.shipmentDateEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.shipmentDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shipmentDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shipmentDateEdit.Size = new System.Drawing.Size(132, 20);
            this.shipmentDateEdit.TabIndex = 31;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.shipmentValidationProvider.SetValidationRule(this.shipmentDateEdit, conditionValidationRule3);
            this.shipmentDateEdit.EditValueChanged += new System.EventHandler(this.shipmentDateEdit_EditValueChanged);
            // 
            // shipmentNumberTbox
            // 
            this.shipmentNumberTbox.Location = new System.Drawing.Point(79, 90);
            this.shipmentNumberTbox.Name = "shipmentNumberTbox";
            this.shipmentNumberTbox.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.shipmentNumberTbox.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.shipmentNumberTbox.Size = new System.Drawing.Size(217, 20);
            this.shipmentNumberTbox.TabIndex = 30;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Номер документу обов\'язково заповніть";
            this.shipmentValidationProvider.SetValidationRule(this.shipmentNumberTbox, conditionValidationRule4);
            this.shipmentNumberTbox.TextChanged += new System.EventHandler(this.shipmentNumberTBox_TextChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 91);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 13);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "№ документу";
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Location = new System.Drawing.Point(633, 281);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 35;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(17, 286);
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
            // shipmentValidationProvider
            // 
            this.shipmentValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            this.shipmentValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.shipmentValidationProvider_ValidationFailed);
            this.shipmentValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.shipmentValidationProvider_ValidationSucceeded);
            // 
            // orderNumberCol
            // 
            this.orderNumberCol.Caption = "№ заказу";
            this.orderNumberCol.FieldName = "OrderNumber";
            this.orderNumberCol.Name = "orderNumberCol";
            this.orderNumberCol.OptionsColumn.AllowEdit = false;
            this.orderNumberCol.OptionsColumn.AllowFocus = false;
            this.orderNumberCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.orderNumberCol.Visible = true;
            this.orderNumberCol.VisibleIndex = 0;
            this.orderNumberCol.Width = 150;
            // 
            // orderDateCol
            // 
            this.orderDateCol.Caption = "Дата";
            this.orderDateCol.FieldName = "OrderDate";
            this.orderDateCol.Name = "orderDateCol";
            this.orderDateCol.OptionsColumn.AllowEdit = false;
            this.orderDateCol.OptionsColumn.AllowFocus = false;
            this.orderDateCol.Visible = true;
            this.orderDateCol.VisibleIndex = 1;
            this.orderDateCol.Width = 155;
            // 
            // contractorCol
            // 
            this.contractorCol.Caption = "Контрагент";
            this.contractorCol.FieldName = "ContractorName";
            this.contractorCol.Name = "contractorCol";
            this.contractorCol.OptionsColumn.AllowEdit = false;
            this.contractorCol.OptionsColumn.AllowFocus = false;
            this.contractorCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.contractorCol.Visible = true;
            this.contractorCol.VisibleIndex = 2;
            this.contractorCol.Width = 300;
            // 
            // ShipmentListEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(794, 320);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.validateLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShipmentListEditFm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Документ";
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileNameTbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentNumberTbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton closeBtn;
        private DevExpress.XtraEditors.GridLookUpEdit orderNumberEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn orderNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn orderDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn contractorCol;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit orderDateEdit;
        private DevExpress.XtraEditors.SimpleButton clearBtn;
        private DevExpress.XtraEditors.SimpleButton showBtn;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private DevExpress.XtraEditors.SimpleButton openFileBtn;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit fileNameTbox;
        private DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit shipmentDateEdit;
        private DevExpress.XtraEditors.TextEdit shipmentNumberTbox;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit documentTypeEdit;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider shipmentValidationProvider;
    }
}