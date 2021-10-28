namespace ERP_NEW.GUI.MTS
{
    partial class MtsSelectMaterialsEditFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MtsSelectMaterialsEditFm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.okBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.materialsGrid = new DevExpress.XtraGrid.GridControl();
            this.materialsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.selCheckedCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.selNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selGostNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selGaugeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selUnitNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selNoteCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selGroupNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.quantityCol = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.cancelBtn);
            this.panelControl1.Controls.Add(this.okBtn);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 676);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1120, 48);
            this.panelControl1.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(1033, 13);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Відмінити";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(952, 13);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 16;
            this.okBtn.Text = "Вибрати";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.materialsGrid);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 30);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1120, 646);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Вибрані матеріали";
            // 
            // materialsGrid
            // 
            this.materialsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialsGrid.Location = new System.Drawing.Point(2, 20);
            this.materialsGrid.MainView = this.materialsGridView;
            this.materialsGrid.Name = "materialsGrid";
            this.materialsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.materialsGrid.Size = new System.Drawing.Size(1116, 624);
            this.materialsGrid.TabIndex = 18;
            this.materialsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.materialsGridView});
            // 
            // materialsGridView
            // 
            this.materialsGridView.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.materialsGridView.Appearance.FooterPanel.Options.UseFont = true;
            this.materialsGridView.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.materialsGridView.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.materialsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.selCheckedCol,
            this.quantityCol,
            this.selNameCol,
            this.selGostNameCol,
            this.selGaugeCol,
            this.selUnitNameCol,
            this.selNoteCol,
            this.selGroupNameCol});
            this.materialsGridView.GridControl = this.materialsGrid;
            this.materialsGridView.Name = "materialsGridView";
            this.materialsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.materialsGridView.OptionsView.ShowAutoFilterRow = true;
            this.materialsGridView.OptionsView.ShowFooter = true;
            this.materialsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // selCheckedCol
            // 
            this.selCheckedCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.selCheckedCol.AppearanceHeader.Options.UseFont = true;
            this.selCheckedCol.AppearanceHeader.Options.UseTextOptions = true;
            this.selCheckedCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.selCheckedCol.Caption = "*";
            this.selCheckedCol.ColumnEdit = this.repositoryItemCheckEdit2;
            this.selCheckedCol.FieldName = "CheckForSelected";
            this.selCheckedCol.Image = ((System.Drawing.Image)(resources.GetObject("selCheckedCol.Image")));
            this.selCheckedCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.selCheckedCol.Name = "selCheckedCol";
            this.selCheckedCol.OptionsColumn.ShowCaption = false;
            this.selCheckedCol.Visible = true;
            this.selCheckedCol.VisibleIndex = 0;
            this.selCheckedCol.Width = 30;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // selNameCol
            // 
            this.selNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.selNameCol.AppearanceHeader.Options.UseFont = true;
            this.selNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.selNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.selNameCol.Caption = "Найменування";
            this.selNameCol.FieldName = "Name";
            this.selNameCol.Name = "selNameCol";
            this.selNameCol.OptionsColumn.AllowEdit = false;
            this.selNameCol.OptionsColumn.AllowFocus = false;
            this.selNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.selNameCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", "Всього вибрано: {0}")});
            this.selNameCol.Visible = true;
            this.selNameCol.VisibleIndex = 2;
            this.selNameCol.Width = 372;
            // 
            // selGostNameCol
            // 
            this.selGostNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.selGostNameCol.AppearanceHeader.Options.UseFont = true;
            this.selGostNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.selGostNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.selGostNameCol.Caption = "Гост";
            this.selGostNameCol.FieldName = "GostName";
            this.selGostNameCol.Name = "selGostNameCol";
            this.selGostNameCol.OptionsColumn.AllowEdit = false;
            this.selGostNameCol.OptionsColumn.AllowFocus = false;
            this.selGostNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.selGostNameCol.Visible = true;
            this.selGostNameCol.VisibleIndex = 3;
            this.selGostNameCol.Width = 136;
            // 
            // selGaugeCol
            // 
            this.selGaugeCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.selGaugeCol.AppearanceHeader.Options.UseFont = true;
            this.selGaugeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.selGaugeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.selGaugeCol.Caption = "Сортамент";
            this.selGaugeCol.FieldName = "Gauge";
            this.selGaugeCol.Name = "selGaugeCol";
            this.selGaugeCol.OptionsColumn.AllowEdit = false;
            this.selGaugeCol.OptionsColumn.AllowFocus = false;
            this.selGaugeCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.selGaugeCol.Visible = true;
            this.selGaugeCol.VisibleIndex = 4;
            this.selGaugeCol.Width = 136;
            // 
            // selUnitNameCol
            // 
            this.selUnitNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.selUnitNameCol.AppearanceHeader.Options.UseFont = true;
            this.selUnitNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.selUnitNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.selUnitNameCol.Caption = "Од. вим.";
            this.selUnitNameCol.FieldName = "UnitName";
            this.selUnitNameCol.Name = "selUnitNameCol";
            this.selUnitNameCol.OptionsColumn.AllowEdit = false;
            this.selUnitNameCol.OptionsColumn.AllowFocus = false;
            this.selUnitNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.selUnitNameCol.Visible = true;
            this.selUnitNameCol.VisibleIndex = 5;
            this.selUnitNameCol.Width = 59;
            // 
            // selNoteCol
            // 
            this.selNoteCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.selNoteCol.AppearanceHeader.Options.UseFont = true;
            this.selNoteCol.AppearanceHeader.Options.UseTextOptions = true;
            this.selNoteCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.selNoteCol.Caption = "Примітка";
            this.selNoteCol.FieldName = "Note";
            this.selNoteCol.Name = "selNoteCol";
            this.selNoteCol.OptionsColumn.AllowEdit = false;
            this.selNoteCol.OptionsColumn.AllowFocus = false;
            this.selNoteCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.selNoteCol.Visible = true;
            this.selNoteCol.VisibleIndex = 6;
            this.selNoteCol.Width = 170;
            // 
            // selGroupNameCol
            // 
            this.selGroupNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.selGroupNameCol.AppearanceHeader.Options.UseFont = true;
            this.selGroupNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.selGroupNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.selGroupNameCol.Caption = "Група матеріалів";
            this.selGroupNameCol.FieldName = "GroupName";
            this.selGroupNameCol.Name = "selGroupNameCol";
            this.selGroupNameCol.OptionsColumn.AllowEdit = false;
            this.selGroupNameCol.OptionsColumn.AllowFocus = false;
            this.selGroupNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.selGroupNameCol.Visible = true;
            this.selGroupNameCol.VisibleIndex = 7;
            this.selGroupNameCol.Width = 195;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addBtn,
            this.editBtn,
            this.deleteBtn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1120, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 724);
            this.barDockControlBottom.Size = new System.Drawing.Size(1120, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 700);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1120, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 700);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.addBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.editBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.deleteBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Додати";
            this.addBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addBtn.Glyph")));
            this.addBtn.Id = 0;
            this.addBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addBtn.LargeGlyph")));
            this.addBtn.Name = "addBtn";
            this.addBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBtn_ItemClick);
            // 
            // editBtn
            // 
            this.editBtn.Caption = "Редагувати";
            this.editBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editBtn.Glyph")));
            this.editBtn.Id = 1;
            this.editBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editBtn.LargeGlyph")));
            this.editBtn.Name = "editBtn";
            this.editBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Видалити";
            this.deleteBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Glyph")));
            this.deleteBtn.Id = 2;
            this.deleteBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteBtn.LargeGlyph")));
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // quantityCol
            // 
            this.quantityCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.quantityCol.AppearanceHeader.Options.UseFont = true;
            this.quantityCol.AppearanceHeader.Options.UseTextOptions = true;
            this.quantityCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.quantityCol.Caption = "Кількість";
            this.quantityCol.FieldName = "Quantity";
            this.quantityCol.Name = "quantityCol";
            this.quantityCol.Visible = true;
            this.quantityCol.VisibleIndex = 1;
            // 
            // MtsSelectMaterialsEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 724);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MtsSelectMaterialsEditFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Матеріали";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton okBtn;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl materialsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView materialsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn selCheckedCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn selNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn selGostNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn selGaugeCol;
        private DevExpress.XtraGrid.Columns.GridColumn selUnitNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn selNoteCol;
        private DevExpress.XtraGrid.Columns.GridColumn selGroupNameCol;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraBars.BarButtonItem editBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn quantityCol;
    }
}