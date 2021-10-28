namespace ERP_NEW.GUI.StoreHouse
{
    partial class ToolActMatarialsEditFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolActMatarialsEditFm));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager = new DevExpress.XtraBars.BarManager();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.beginDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.endDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.showBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.materialsGrid = new DevExpress.XtraGrid.GridControl();
            this.materialsGridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.selectedCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.materialRepository = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.nomenclatureCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.nomenclatureNameCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.unitLocalNameCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.invoiceDateCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.invoiceNumberCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.requiredQuantityCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.orderDateCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.receiptNumCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.unitPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.okBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialRepository)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "MainMenu";
            // 
            // bar2
            // 
            this.bar2.BarName = "MainMenu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "MainMenu";
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.beginDateEdit,
            this.endDateEdit,
            this.showBtn});
            this.barManager.MainMenu = this.bar3;
            this.barManager.MaxItemId = 3;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            // 
            // bar3
            // 
            this.bar3.BarName = "MainMenu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.beginDateEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.endDateEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.showBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.DrawBorder = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "MainMenu";
            // 
            // beginDateEdit
            // 
            this.beginDateEdit.Caption = "З";
            this.beginDateEdit.Edit = this.repositoryItemDateEdit1;
            this.beginDateEdit.EditWidth = 100;
            this.beginDateEdit.Id = 0;
            this.beginDateEdit.Name = "beginDateEdit";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemDateEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemDateEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // endDateEdit
            // 
            this.endDateEdit.Caption = "По";
            this.endDateEdit.Edit = this.repositoryItemDateEdit2;
            this.endDateEdit.EditWidth = 100;
            this.endDateEdit.Id = 1;
            this.endDateEdit.Name = "endDateEdit";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // showBtn
            // 
            this.showBtn.Caption = "Показати";
            this.showBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("showBtn.Glyph")));
            this.showBtn.Id = 2;
            this.showBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showBtn.LargeGlyph")));
            this.showBtn.Name = "showBtn";
            this.showBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showBtn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1070, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 592);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1070, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 562);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1070, 30);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 562);
            // 
            // materialsGrid
            // 
            this.materialsGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialsGrid.Location = new System.Drawing.Point(12, 31);
            this.materialsGrid.MainView = this.materialsGridView;
            this.materialsGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialsGrid.Name = "materialsGrid";
            this.materialsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.materialRepository});
            this.materialsGrid.Size = new System.Drawing.Size(1050, 512);
            this.materialsGrid.TabIndex = 6;
            this.materialsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.materialsGridView});
            // 
            // materialsGridView
            // 
            this.materialsGridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand3,
            this.gridBand1,
            this.gridBand2});
            this.materialsGridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.selectedCol,
            this.nomenclatureCol,
            this.nomenclatureNameCol,
            this.unitLocalNameCol,
            this.invoiceNumberCol,
            this.invoiceDateCol,
            this.requiredQuantityCol,
            this.receiptNumCol,
            this.orderDateCol,
            this.unitPriceCol});
            this.materialsGridView.GridControl = this.materialsGrid;
            this.materialsGridView.Name = "materialsGridView";
            this.materialsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.materialsGridView.OptionsView.ShowAutoFilterRow = true;
            this.materialsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Матеріал";
            this.gridBand3.Columns.Add(this.selectedCol);
            this.gridBand3.Columns.Add(this.nomenclatureCol);
            this.gridBand3.Columns.Add(this.nomenclatureNameCol);
            this.gridBand3.Columns.Add(this.unitLocalNameCol);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 0;
            this.gridBand3.Width = 431;
            // 
            // selectedCol
            // 
            this.selectedCol.AppearanceCell.Options.UseTextOptions = true;
            this.selectedCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.selectedCol.AppearanceHeader.Options.UseTextOptions = true;
            this.selectedCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.selectedCol.ColumnEdit = this.materialRepository;
            this.selectedCol.FieldName = "Selected";
            this.selectedCol.Image = ((System.Drawing.Image)(resources.GetObject("selectedCol.Image")));
            this.selectedCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.selectedCol.Name = "selectedCol";
            this.selectedCol.OptionsColumn.ShowCaption = false;
            this.selectedCol.Visible = true;
            this.selectedCol.Width = 34;
            // 
            // materialRepository
            // 
            this.materialRepository.AutoHeight = false;
            this.materialRepository.Name = "materialRepository";
            // 
            // nomenclatureCol
            // 
            this.nomenclatureCol.AppearanceCell.Options.UseTextOptions = true;
            this.nomenclatureCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureCol.Caption = "Ном./номер";
            this.nomenclatureCol.FieldName = "Nomenclature";
            this.nomenclatureCol.Name = "nomenclatureCol";
            this.nomenclatureCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nomenclatureCol.Visible = true;
            this.nomenclatureCol.Width = 85;
            // 
            // nomenclatureNameCol
            // 
            this.nomenclatureNameCol.AppearanceCell.Options.UseTextOptions = true;
            this.nomenclatureNameCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureNameCol.Caption = "Найменування";
            this.nomenclatureNameCol.FieldName = "NomenclatureName";
            this.nomenclatureNameCol.Name = "nomenclatureNameCol";
            this.nomenclatureNameCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureNameCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nomenclatureNameCol.Visible = true;
            this.nomenclatureNameCol.Width = 239;
            // 
            // unitLocalNameCol
            // 
            this.unitLocalNameCol.AppearanceCell.Options.UseTextOptions = true;
            this.unitLocalNameCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unitLocalNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.unitLocalNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unitLocalNameCol.Caption = "Од.вим.";
            this.unitLocalNameCol.FieldName = "UnitLocalName";
            this.unitLocalNameCol.Name = "unitLocalNameCol";
            this.unitLocalNameCol.OptionsColumn.AllowEdit = false;
            this.unitLocalNameCol.OptionsColumn.AllowFocus = false;
            this.unitLocalNameCol.Visible = true;
            this.unitLocalNameCol.Width = 73;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Вимога";
            this.gridBand1.Columns.Add(this.invoiceDateCol);
            this.gridBand1.Columns.Add(this.invoiceNumberCol);
            this.gridBand1.Columns.Add(this.requiredQuantityCol);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 1;
            this.gridBand1.Width = 201;
            // 
            // invoiceDateCol
            // 
            this.invoiceDateCol.AppearanceCell.Options.UseTextOptions = true;
            this.invoiceDateCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.invoiceDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.invoiceDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.invoiceDateCol.Caption = "Дата";
            this.invoiceDateCol.FieldName = "Date";
            this.invoiceDateCol.Name = "invoiceDateCol";
            this.invoiceDateCol.OptionsColumn.AllowEdit = false;
            this.invoiceDateCol.OptionsColumn.AllowFocus = false;
            this.invoiceDateCol.Visible = true;
            this.invoiceDateCol.Width = 62;
            // 
            // invoiceNumberCol
            // 
            this.invoiceNumberCol.AppearanceCell.Options.UseTextOptions = true;
            this.invoiceNumberCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.invoiceNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.invoiceNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.invoiceNumberCol.Caption = "Номер";
            this.invoiceNumberCol.FieldName = "Number";
            this.invoiceNumberCol.Name = "invoiceNumberCol";
            this.invoiceNumberCol.OptionsColumn.AllowEdit = false;
            this.invoiceNumberCol.OptionsColumn.AllowFocus = false;
            this.invoiceNumberCol.Visible = true;
            this.invoiceNumberCol.Width = 64;
            // 
            // requiredQuantityCol
            // 
            this.requiredQuantityCol.AppearanceCell.Options.UseTextOptions = true;
            this.requiredQuantityCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.requiredQuantityCol.AppearanceHeader.Options.UseTextOptions = true;
            this.requiredQuantityCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.requiredQuantityCol.Caption = "К-сть";
            this.requiredQuantityCol.FieldName = "RequiredQuantity";
            this.requiredQuantityCol.Name = "requiredQuantityCol";
            this.requiredQuantityCol.OptionsColumn.AllowEdit = false;
            this.requiredQuantityCol.OptionsColumn.AllowFocus = false;
            this.requiredQuantityCol.Visible = true;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Надходження";
            this.gridBand2.Columns.Add(this.orderDateCol);
            this.gridBand2.Columns.Add(this.receiptNumCol);
            this.gridBand2.Columns.Add(this.unitPriceCol);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 2;
            this.gridBand2.Width = 225;
            // 
            // orderDateCol
            // 
            this.orderDateCol.AppearanceCell.Options.UseTextOptions = true;
            this.orderDateCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderDateCol.Caption = "Дата";
            this.orderDateCol.FieldName = "OrderDate";
            this.orderDateCol.Name = "orderDateCol";
            this.orderDateCol.OptionsColumn.AllowEdit = false;
            this.orderDateCol.OptionsColumn.AllowFocus = false;
            this.orderDateCol.Visible = true;
            // 
            // receiptNumCol
            // 
            this.receiptNumCol.AppearanceCell.Options.UseTextOptions = true;
            this.receiptNumCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.receiptNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.receiptNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.receiptNumCol.Caption = "Номер";
            this.receiptNumCol.FieldName = "ReceiptNum";
            this.receiptNumCol.Name = "receiptNumCol";
            this.receiptNumCol.OptionsColumn.AllowEdit = false;
            this.receiptNumCol.OptionsColumn.AllowFocus = false;
            this.receiptNumCol.Visible = true;
            // 
            // unitPriceCol
            // 
            this.unitPriceCol.AppearanceCell.Options.UseTextOptions = true;
            this.unitPriceCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unitPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.unitPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unitPriceCol.Caption = "Ціна за од.";
            this.unitPriceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.unitPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.unitPriceCol.FieldName = "UnitPrice";
            this.unitPriceCol.Name = "unitPriceCol";
            this.unitPriceCol.OptionsColumn.AllowEdit = false;
            this.unitPriceCol.OptionsColumn.AllowFocus = false;
            this.unitPriceCol.Visible = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(971, 551);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(87, 28);
            this.cancelBtn.TabIndex = 21;
            this.cancelBtn.Text = "Відмінити";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(881, 551);
            this.okBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(87, 28);
            this.okBtn.TabIndex = 20;
            this.okBtn.Text = "Вибрати";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // ToolActMatarialsEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 592);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.materialsGrid);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolActMatarialsEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перелік матеріалів у вимогах";
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialRepository)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarEditItem beginDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem endDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem showBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl materialsGrid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView materialsGridView;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn selectedCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit materialRepository;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn nomenclatureCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn nomenclatureNameCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn unitLocalNameCol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn invoiceDateCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn invoiceNumberCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn requiredQuantityCol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn orderDateCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn receiptNumCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn unitPriceCol;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton okBtn;
    }
}