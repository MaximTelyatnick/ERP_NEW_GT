namespace ERP_NEW.GUI.GodMode
{
    partial class GodModeFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GodModeFm));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.employeesBtn = new DevExpress.XtraBars.Navigation.NavButton();
            this.parserBtn = new DevExpress.XtraBars.Navigation.NavButton();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane1.Buttons.Add(this.employeesBtn);
            this.tileNavPane1.Buttons.Add(this.parserBtn);
            // 
            // tileNavCategory1
            // 
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            this.tileNavPane1.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.DefaultCategory.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane1.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Size = new System.Drawing.Size(1053, 68);
            this.tileNavPane1.TabIndex = 0;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // employeesBtn
            // 
            this.employeesBtn.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.employeesBtn.Appearance.Options.UseTextOptions = true;
            this.employeesBtn.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.employeesBtn.AppearanceSelected.BackColor = System.Drawing.Color.Gainsboro;
            this.employeesBtn.AppearanceSelected.ForeColor = System.Drawing.Color.Transparent;
            this.employeesBtn.AppearanceSelected.Options.UseBackColor = true;
            this.employeesBtn.AppearanceSelected.Options.UseForeColor = true;
            this.employeesBtn.Caption = "Співробітники";
            this.employeesBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("employeesBtn.Glyph")));
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.employeesBtn_ElementClick);
            // 
            // parserBtn
            // 
            this.parserBtn.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.parserBtn.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.parserBtn.AppearanceSelected.BackColor = System.Drawing.Color.Gainsboro;
            this.parserBtn.AppearanceSelected.ForeColor = System.Drawing.Color.Transparent;
            this.parserBtn.AppearanceSelected.Options.UseBackColor = true;
            this.parserBtn.AppearanceSelected.Options.UseForeColor = true;
            this.parserBtn.Caption = "Парсеры";
            this.parserBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("parserBtn.Glyph")));
            this.parserBtn.Name = "parserBtn";
            this.parserBtn.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.parserBtn_ElementClick);
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.View = this.tabbedView1;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.RootContainer.Element = null;
            // 
            // GodModeFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 491);
            this.Controls.Add(this.tileNavPane1);
            this.Name = "GodModeFm";
            this.ShowIcon = false;
            this.Text = "Форма разработчика";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton employeesBtn;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Navigation.NavButton parserBtn;
    }
}