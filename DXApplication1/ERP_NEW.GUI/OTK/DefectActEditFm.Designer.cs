namespace ERP_NEW.GUI.OTK
{
    partial class DefectActEditFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefectActEditFm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.clearBtn = new DevExpress.XtraEditors.SimpleButton();
            this.fileNameTbox = new DevExpress.XtraEditors.TextEdit();
            this.showBtn = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.openFileBtn = new DevExpress.XtraEditors.SimpleButton();
            this.closeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.assemblyEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.detailsMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.actDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.actNumberTbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.defectActValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.orderNumberEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.assemblyDrawingCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.drawingNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateCreatedCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.designerNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerOrderNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameTbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actNumberTbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectActValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.clearBtn);
            this.panelControl2.Controls.Add(this.fileNameTbox);
            this.panelControl2.Controls.Add(this.showBtn);
            this.panelControl2.Controls.Add(this.pictureEdit);
            this.panelControl2.Controls.Add(this.openFileBtn);
            this.panelControl2.Location = new System.Drawing.Point(469, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(315, 326);
            this.panelControl2.TabIndex = 29;
            // 
            // clearBtn
            // 
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.Location = new System.Drawing.Point(247, 299);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(29, 23);
            this.clearBtn.TabIndex = 24;
            this.clearBtn.ToolTip = "Очистити";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // fileNameTbox
            // 
            this.fileNameTbox.Enabled = false;
            this.fileNameTbox.Location = new System.Drawing.Point(5, 301);
            this.fileNameTbox.Name = "fileNameTbox";
            this.fileNameTbox.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.fileNameTbox.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.fileNameTbox.Size = new System.Drawing.Size(208, 20);
            this.fileNameTbox.TabIndex = 21;
            // 
            // showBtn
            // 
            this.showBtn.Image = ((System.Drawing.Image)(resources.GetObject("showBtn.Image")));
            this.showBtn.Location = new System.Drawing.Point(279, 299);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(29, 23);
            this.showBtn.TabIndex = 23;
            this.showBtn.ToolTip = "Переглянути файл";
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // pictureEdit
            // 
            this.pictureEdit.Location = new System.Drawing.Point(5, 4);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit.Size = new System.Drawing.Size(303, 289);
            this.pictureEdit.TabIndex = 22;
            // 
            // openFileBtn
            // 
            this.openFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("openFileBtn.Image")));
            this.openFileBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.openFileBtn.Location = new System.Drawing.Point(216, 299);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(29, 23);
            this.openFileBtn.TabIndex = 4;
            this.openFileBtn.ToolTip = "Вибрати файл";
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(709, 340);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 31;
            this.closeBtn.Text = "Відміна";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Location = new System.Drawing.Point(628, 340);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 30;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.orderNumberEdit);
            this.panelControl1.Controls.Add(this.assemblyEdit);
            this.panelControl1.Controls.Add(this.labelControl12);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.detailsMemoEdit);
            this.panelControl1.Controls.Add(this.descriptionMemoEdit);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.actDateEdit);
            this.panelControl1.Controls.Add(this.actNumberTbox);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Location = new System.Drawing.Point(0, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(463, 326);
            this.panelControl1.TabIndex = 32;
            // 
            // assemblyEdit
            // 
            this.assemblyEdit.Location = new System.Drawing.Point(79, 40);
            this.assemblyEdit.Name = "assemblyEdit";
            this.assemblyEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.assemblyEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.assemblyEdit.Properties.ImmediatePopup = true;
            this.assemblyEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.assemblyEdit.Properties.PopupFormSize = new System.Drawing.Size(553, 0);
            this.assemblyEdit.Properties.View = this.gridLookUpEdit1View;
            this.assemblyEdit.Size = new System.Drawing.Size(379, 20);
            this.assemblyEdit.TabIndex = 41;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.assemblyDrawingCol,
            this.drawingNameCol,
            this.dateCreatedCol,
            this.designerNameCol,
            this.customerOrderNumberCol});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridLookUpEdit1View.OptionsFind.AlwaysVisible = true;
            this.gridLookUpEdit1View.OptionsFind.SearchInPreview = true;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl12
            // 
            this.labelControl12.AllowHtmlString = true;
            this.labelControl12.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl12.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl12.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl12.Location = new System.Drawing.Point(10, 215);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(45, 26);
            this.labelControl12.TabIndex = 38;
            this.labelControl12.Text = "Опис<br>дефекту";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(8, 95);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(47, 13);
            this.labelControl11.TabIndex = 37;
            this.labelControl11.Text = "Висновки";
            // 
            // detailsMemoEdit
            // 
            this.detailsMemoEdit.Location = new System.Drawing.Point(79, 214);
            this.detailsMemoEdit.Name = "detailsMemoEdit";
            this.detailsMemoEdit.Size = new System.Drawing.Size(379, 107);
            this.detailsMemoEdit.TabIndex = 36;
            // 
            // descriptionMemoEdit
            // 
            this.descriptionMemoEdit.Location = new System.Drawing.Point(79, 94);
            this.descriptionMemoEdit.Name = "descriptionMemoEdit";
            this.descriptionMemoEdit.Size = new System.Drawing.Size(379, 114);
            this.descriptionMemoEdit.TabIndex = 35;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(8, 43);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 13);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "Проект";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(302, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(15, 13);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "від";
            // 
            // actDateEdit
            // 
            this.actDateEdit.EditValue = null;
            this.actDateEdit.Location = new System.Drawing.Point(326, 11);
            this.actDateEdit.Name = "actDateEdit";
            this.actDateEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.actDateEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.actDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.actDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.actDateEdit.Size = new System.Drawing.Size(132, 20);
            this.actDateEdit.TabIndex = 31;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Дата акту обов\'язково для заповнення";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.defectActValidationProvider.SetValidationRule(this.actDateEdit, conditionValidationRule4);
            this.actDateEdit.EditValueChanged += new System.EventHandler(this.actDateEdit_EditValueChanged);
            // 
            // actNumberTbox
            // 
            this.actNumberTbox.Location = new System.Drawing.Point(79, 11);
            this.actNumberTbox.Name = "actNumberTbox";
            this.actNumberTbox.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.actNumberTbox.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.actNumberTbox.Size = new System.Drawing.Size(217, 20);
            this.actNumberTbox.TabIndex = 30;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Номер акту обов\'язково для заповнення";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.defectActValidationProvider.SetValidationRule(this.actNumberTbox, conditionValidationRule2);
            this.actNumberTbox.TextChanged += new System.EventHandler(this.actNumberTBox_TextChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 13);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "№ документу";
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
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(8, 345);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 33;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // defectActValidationProvider
            // 
            this.defectActValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            this.defectActValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.defectActValidationProviderValidationFailed);
            this.defectActValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.defectActValidationProvider_ValidationSucceeded);
            // 
            // orderNumberEdit
            // 
            this.orderNumberEdit.Location = new System.Drawing.Point(79, 66);
            this.orderNumberEdit.Name = "orderNumberEdit";
            this.orderNumberEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.orderNumberEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("orderNumberEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.orderNumberEdit.Properties.ImmediatePopup = true;
            this.orderNumberEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.orderNumberEdit.Properties.PopupFormSize = new System.Drawing.Size(1000, 0);
            this.orderNumberEdit.Properties.View = this.gridView1;
            this.orderNumberEdit.Size = new System.Drawing.Size(379, 22);
            this.orderNumberEdit.TabIndex = 169;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "Не вказано заказ";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule3.Value1 = 0;
            this.defectActValidationProvider.SetValidationRule(this.orderNumberEdit, conditionValidationRule3);
            this.orderNumberEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.orderNumberEdit_ButtonClick);
            this.orderNumberEdit.EditValueChanged += new System.EventHandler(this.orderNumberEdit_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.SearchInPreview = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 170;
            this.labelControl1.Text = "Заказ";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "№ заказу";
            this.gridColumn1.FieldName = "OrderNumber";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 84;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Дата";
            this.gridColumn2.FieldName = "OrderDate";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 87;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Контрагент";
            this.gridColumn3.FieldName = "ContractorName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 169;
            // 
            // assemblyDrawingCol
            // 
            this.assemblyDrawingCol.Caption = "Проект";
            this.assemblyDrawingCol.FieldName = "Drawing";
            this.assemblyDrawingCol.Name = "assemblyDrawingCol";
            this.assemblyDrawingCol.OptionsColumn.AllowEdit = false;
            this.assemblyDrawingCol.OptionsColumn.AllowFocus = false;
            this.assemblyDrawingCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.assemblyDrawingCol.Visible = true;
            this.assemblyDrawingCol.VisibleIndex = 0;
            // 
            // drawingNameCol
            // 
            this.drawingNameCol.Caption = "Найменування";
            this.drawingNameCol.FieldName = "Name";
            this.drawingNameCol.Name = "drawingNameCol";
            this.drawingNameCol.OptionsColumn.AllowEdit = false;
            this.drawingNameCol.OptionsColumn.AllowFocus = false;
            this.drawingNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.drawingNameCol.Visible = true;
            this.drawingNameCol.VisibleIndex = 1;
            // 
            // dateCreatedCol
            // 
            this.dateCreatedCol.Caption = "Дата реєстрації";
            this.dateCreatedCol.FieldName = "DateCreated";
            this.dateCreatedCol.Name = "dateCreatedCol";
            this.dateCreatedCol.OptionsColumn.AllowEdit = false;
            this.dateCreatedCol.OptionsColumn.AllowFocus = false;
            this.dateCreatedCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.dateCreatedCol.Visible = true;
            this.dateCreatedCol.VisibleIndex = 2;
            // 
            // designerNameCol
            // 
            this.designerNameCol.Caption = "Розробник";
            this.designerNameCol.FieldName = "DesignerName";
            this.designerNameCol.Name = "designerNameCol";
            this.designerNameCol.OptionsColumn.AllowEdit = false;
            this.designerNameCol.OptionsColumn.AllowFocus = false;
            this.designerNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.designerNameCol.Visible = true;
            this.designerNameCol.VisibleIndex = 3;
            // 
            // customerOrderNumberCol
            // 
            this.customerOrderNumberCol.Caption = "Номер заказу";
            this.customerOrderNumberCol.FieldName = "CustomerOrderNumber";
            this.customerOrderNumberCol.Name = "customerOrderNumberCol";
            this.customerOrderNumberCol.OptionsColumn.AllowEdit = false;
            this.customerOrderNumberCol.OptionsColumn.AllowFocus = false;
            this.customerOrderNumberCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.customerOrderNumberCol.Visible = true;
            this.customerOrderNumberCol.VisibleIndex = 4;
            // 
            // DefectActEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(787, 370);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefectActEditFm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагування гарантійного забов\'язання";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileNameTbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actNumberTbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectActValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton clearBtn;
        private DevExpress.XtraEditors.TextEdit fileNameTbox;
        private DevExpress.XtraEditors.SimpleButton showBtn;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private DevExpress.XtraEditors.SimpleButton openFileBtn;
        private DevExpress.XtraEditors.SimpleButton closeBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.MemoEdit detailsMemoEdit;
        private DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit actDateEdit;
        private DevExpress.XtraEditors.TextEdit actNumberTbox;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider defectActValidationProvider;
        private DevExpress.XtraEditors.GridLookUpEdit assemblyEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn assemblyDrawingCol;
        private DevExpress.XtraGrid.Columns.GridColumn drawingNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn dateCreatedCol;
        private DevExpress.XtraGrid.Columns.GridColumn designerNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn customerOrderNumberCol;
        private DevExpress.XtraEditors.GridLookUpEdit orderNumberEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl1;



    }
}