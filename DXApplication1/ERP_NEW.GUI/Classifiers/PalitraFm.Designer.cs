namespace ERP_NEW.GUI.Classifiers
{
    partial class PalitraFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PalitraFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.delBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PalitraRibbon = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.palitraGrid = new DevExpress.XtraGrid.GridControl();
            this.palitraGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameRusCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorCodeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.додатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palitraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palitraGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addBtn,
            this.editBtn,
            this.delBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1135, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Додати";
            this.addBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addBtn.Glyph")));
            this.addBtn.Id = 1;
            this.addBtn.Name = "addBtn";
            this.addBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.addBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBtn_ItemClick);
            // 
            // editBtn
            // 
            this.editBtn.Caption = "Редагувати";
            this.editBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editBtn.Glyph")));
            this.editBtn.Id = 2;
            this.editBtn.Name = "editBtn";
            this.editBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.editBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBtn_ItemClick);
            // 
            // delBtn
            // 
            this.delBtn.Caption = "Видалити";
            this.delBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("delBtn.Glyph")));
            this.delBtn.Id = 3;
            this.delBtn.Name = "delBtn";
            this.delBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.delBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.delBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PalitraRibbon});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // PalitraRibbon
            // 
            this.PalitraRibbon.ItemLinks.Add(this.addBtn);
            this.PalitraRibbon.ItemLinks.Add(this.editBtn);
            this.PalitraRibbon.ItemLinks.Add(this.delBtn);
            this.PalitraRibbon.Name = "PalitraRibbon";
            this.PalitraRibbon.Text = "Кольори";
            // 
            // palitraGrid
            // 
            this.palitraGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palitraGrid.Location = new System.Drawing.Point(0, 95);
            this.palitraGrid.MainView = this.palitraGridView;
            this.palitraGrid.Name = "palitraGrid";
            this.palitraGrid.Size = new System.Drawing.Size(1135, 391);
            this.palitraGrid.TabIndex = 1;
            this.palitraGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.palitraGridView});
            // 
            // palitraGridView
            // 
            this.palitraGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameRusCol,
            this.colorCodeCol});
            this.palitraGridView.GridControl = this.palitraGrid;
            this.palitraGridView.Name = "palitraGridView";
            this.palitraGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.palitraGridView.OptionsView.ShowFooter = true;
            this.palitraGridView.OptionsView.ShowGroupPanel = false;
            this.palitraGridView.RowHeight = 30;
            this.palitraGridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.PalitraGridView_RowCellStyle);
            // 
            // nameRusCol
            // 
            this.nameRusCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.nameRusCol.AppearanceHeader.Options.UseFont = true;
            this.nameRusCol.Caption = "Назва";
            this.nameRusCol.FieldName = "Name_Rus";
            this.nameRusCol.Name = "nameRusCol";
            this.nameRusCol.OptionsColumn.AllowEdit = false;
            this.nameRusCol.OptionsColumn.AllowFocus = false;
            this.nameRusCol.OptionsColumn.FixedWidth = true;
            this.nameRusCol.Visible = true;
            this.nameRusCol.VisibleIndex = 0;
            this.nameRusCol.Width = 145;
            // 
            // colorCodeCol
            // 
            this.colorCodeCol.AppearanceCell.ForeColor = System.Drawing.Color.Transparent;
            this.colorCodeCol.AppearanceCell.Options.UseForeColor = true;
            this.colorCodeCol.Caption = "Колір";
            this.colorCodeCol.Name = "colorCodeCol";
            this.colorCodeCol.OptionsColumn.AllowEdit = false;
            this.colorCodeCol.OptionsColumn.AllowFocus = false;
            this.colorCodeCol.OptionsColumn.FixedWidth = true;
            this.colorCodeCol.Visible = true;
            this.colorCodeCol.VisibleIndex = 1;
            this.colorCodeCol.Width = 972;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиToolStripMenuItem,
            this.редагуватиToolStripMenuItem,
            this.видалитиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 70);
            // 
            // додатиToolStripMenuItem
            // 
            this.додатиToolStripMenuItem.Image = global::ERP_NEW.GUI.Accounting.Resources.Add_16x16;
            this.додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            this.додатиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.додатиToolStripMenuItem.Text = "Додати";
            this.додатиToolStripMenuItem.Click += new System.EventHandler(this.додатиToolStripMenuItem_Click);
            // 
            // редагуватиToolStripMenuItem
            // 
            this.редагуватиToolStripMenuItem.Image = global::ERP_NEW.GUI.Accounting.Resources.paint;
            this.редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            this.редагуватиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.редагуватиToolStripMenuItem.Text = "Редагувати";
            this.редагуватиToolStripMenuItem.Click += new System.EventHandler(this.редагуватиToolStripMenuItem_Click);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Image = global::ERP_NEW.GUI.Accounting.Resources.Cancel_16x16;
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click);
            // 
            // PalitraFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 486);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.palitraGrid);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PalitraFm";
            this.ShowIcon = false;
            this.Text = "Палітра кольорів";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palitraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palitraGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraBars.BarButtonItem editBtn;
        private DevExpress.XtraBars.BarButtonItem delBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PalitraRibbon;
        private DevExpress.XtraGrid.GridControl palitraGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView palitraGridView;
        private DevExpress.XtraGrid.Columns.GridColumn nameRusCol;
        private DevExpress.XtraGrid.Columns.GridColumn colorCodeCol;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem додатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
    }
}