namespace ERP_NEW.GUI.Classifiers
{
    partial class LogFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogFm));
            this.logGridControl = new DevExpress.XtraGrid.GridControl();
            this.logGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RecDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TaskCaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OperationType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.addButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.EditButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.DelButtonItem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.logGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // logGridControl
            // 
            this.logGridControl.Location = new System.Drawing.Point(0, 92);
            this.logGridControl.MainView = this.logGridView;
            this.logGridControl.Name = "logGridControl";
            this.logGridControl.Size = new System.Drawing.Size(855, 372);
            this.logGridControl.TabIndex = 1;
            this.logGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.logGridView});
            // 
            // logGridView
            // 
            this.logGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EmployeeName,
            this.RecDate,
            this.TaskCaption,
            this.OperationType});
            this.logGridView.GridControl = this.logGridControl;
            this.logGridView.Name = "logGridView";
            this.logGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Caption = "Користувач";
            this.EmployeeName.FieldName = "EmployeeName";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Visible = true;
            this.EmployeeName.VisibleIndex = 0;
            // 
            // RecDate
            // 
            this.RecDate.Caption = "Дата";
            this.RecDate.FieldName = "RecDate";
            this.RecDate.Name = "RecDate";
            this.RecDate.Visible = true;
            this.RecDate.VisibleIndex = 1;
            // 
            // TaskCaption
            // 
            this.TaskCaption.Caption = "Режим";
            this.TaskCaption.FieldName = "TaskCaption";
            this.TaskCaption.Name = "TaskCaption";
            this.TaskCaption.Visible = true;
            this.TaskCaption.VisibleIndex = 2;
            // 
            // OperationType
            // 
            this.OperationType.Caption = "Операции";
            this.OperationType.FieldName = "OperationType";
            this.OperationType.Name = "OperationType";
            this.OperationType.Visible = true;
            this.OperationType.VisibleIndex = 3;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addButtonItem,
            this.EditButtonItem,
            this.DelButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(855, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.addButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.EditButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.DelButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // addButtonItem
            // 
            this.addButtonItem.Caption = "Додати";
            this.addButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("addButtonItem.Glyph")));
            this.addButtonItem.Id = 1;
            this.addButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addButtonItem.LargeGlyph")));
            this.addButtonItem.Name = "addButtonItem";
            this.addButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // EditButtonItem
            // 
            this.EditButtonItem.Caption = "Редагувати";
            this.EditButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("EditButtonItem.Glyph")));
            this.EditButtonItem.Id = 2;
            this.EditButtonItem.Name = "EditButtonItem";
            this.EditButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.EditButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditButtonItem_ItemClick);
            // 
            // DelButtonItem
            // 
            this.DelButtonItem.Caption = "Видалити";
            this.DelButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("DelButtonItem.Glyph")));
            this.DelButtonItem.Id = 3;
            this.DelButtonItem.Name = "DelButtonItem";
            this.DelButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.DelButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // LogFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 424);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.logGridControl);
            this.Name = "LogFm";
            this.Text = "Log";
            ((System.ComponentModel.ISupportInitialize)(this.logGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl logGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView logGridView;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn RecDate;
        private DevExpress.XtraGrid.Columns.GridColumn TaskCaption;
        private DevExpress.XtraGrid.Columns.GridColumn OperationType;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem addButtonItem;
        private DevExpress.XtraBars.BarButtonItem EditButtonItem;
        private DevExpress.XtraBars.BarButtonItem DelButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}