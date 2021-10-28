namespace ERP_NEW.GUI.Classifiers
{
    partial class WeldStampsFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeldStampsFm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.weldStampsGrid = new DevExpress.XtraGrid.GridControl();
            this.weldStampsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.addItem = new DevExpress.XtraBars.BarButtonItem();
            this.editItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteItem = new DevExpress.XtraBars.BarButtonItem();
            this.stampNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stampDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldStampsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldStampsGridView)).BeginInit();
            this.SuspendLayout();
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
            this.addItem,
            this.editItem,
            this.deleteItem});
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.addItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.editItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.deleteItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.Text = "Tools";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(765, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 435);
            this.barDockControlBottom.Size = new System.Drawing.Size(765, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 404);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(765, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 404);
            // 
            // weldStampsGrid
            // 
            this.weldStampsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weldStampsGrid.Location = new System.Drawing.Point(0, 31);
            this.weldStampsGrid.MainView = this.weldStampsGridView;
            this.weldStampsGrid.Name = "weldStampsGrid";
            this.weldStampsGrid.Size = new System.Drawing.Size(765, 404);
            this.weldStampsGrid.TabIndex = 4;
            this.weldStampsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.weldStampsGridView});
            // 
            // weldStampsGridView
            // 
            this.weldStampsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.stampNumberCol,
            this.stampDate});
            this.weldStampsGridView.GridControl = this.weldStampsGrid;
            this.weldStampsGridView.Name = "weldStampsGridView";
            this.weldStampsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.weldStampsGridView.OptionsView.ShowAutoFilterRow = true;
            this.weldStampsGridView.DoubleClick += new System.EventHandler(this.weldStampsGridView_DoubleClick);
            // 
            // addItem
            // 
            this.addItem.Caption = "Додати";
            this.addItem.Glyph = ((System.Drawing.Image)(resources.GetObject("addItem.Glyph")));
            this.addItem.Id = 0;
            this.addItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addItem.LargeGlyph")));
            this.addItem.Name = "addItem";
            this.addItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addItem_ItemClick);
            // 
            // editItem
            // 
            this.editItem.Caption = "Редагувати";
            this.editItem.Glyph = ((System.Drawing.Image)(resources.GetObject("editItem.Glyph")));
            this.editItem.Id = 1;
            this.editItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editItem.LargeGlyph")));
            this.editItem.Name = "editItem";
            this.editItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editItem_ItemClick);
            // 
            // deleteItem
            // 
            this.deleteItem.Caption = "Видалити";
            this.deleteItem.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteItem.Glyph")));
            this.deleteItem.Id = 2;
            this.deleteItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteItem.LargeGlyph")));
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteItem_ItemClick);
            // 
            // stampNumberCol
            // 
            this.stampNumberCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.stampNumberCol.AppearanceCell.Options.UseFont = true;
            this.stampNumberCol.AppearanceCell.Options.UseTextOptions = true;
            this.stampNumberCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.stampNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.stampNumberCol.AppearanceHeader.Options.UseFont = true;
            this.stampNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.stampNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.stampNumberCol.Caption = "Номер";
            this.stampNumberCol.FieldName = "StampNumber";
            this.stampNumberCol.Name = "stampNumberCol";
            this.stampNumberCol.OptionsColumn.AllowEdit = false;
            this.stampNumberCol.OptionsColumn.AllowFocus = false;
            this.stampNumberCol.Visible = true;
            this.stampNumberCol.VisibleIndex = 0;
            // 
            // stampDate
            // 
            this.stampDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.stampDate.AppearanceHeader.Options.UseFont = true;
            this.stampDate.AppearanceHeader.Options.UseTextOptions = true;
            this.stampDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.stampDate.Caption = "Дата прийняття";
            this.stampDate.FieldName = "StampDate";
            this.stampDate.Name = "stampDate";
            this.stampDate.OptionsColumn.AllowEdit = false;
            this.stampDate.OptionsColumn.AllowFocus = false;
            this.stampDate.Visible = true;
            this.stampDate.VisibleIndex = 1;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // WeldStampsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 435);
            this.Controls.Add(this.weldStampsGrid);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "WeldStampsFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Довідник клейм";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldStampsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldStampsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl weldStampsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView weldStampsGridView;
        private DevExpress.XtraBars.BarButtonItem addItem;
        private DevExpress.XtraBars.BarButtonItem editItem;
        private DevExpress.XtraBars.BarButtonItem deleteItem;
        private DevExpress.XtraGrid.Columns.GridColumn stampNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn stampDate;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}