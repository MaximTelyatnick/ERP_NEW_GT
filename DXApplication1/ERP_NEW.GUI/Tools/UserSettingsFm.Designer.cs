namespace ERP_NEW.GUI.Tools
{
    partial class UserSettingsFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettingsFm));
            this.useSimpleEmmloyeeSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuButton3 = new ERP_NEW.GUI.CustomGUI.MenuButton();
            this.menuButton2 = new ERP_NEW.GUI.CustomGUI.MenuButton();
            this.galleryControl1 = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.menuButton1 = new ERP_NEW.GUI.CustomGUI.MenuButton();
            this.clearBtn = new DevExpress.XtraEditors.SimpleButton();
            this.userRouteFolderEdit = new DevExpress.XtraEditors.TextEdit();
            this.openFileBtn = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.PopupContainerEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.SkinsLink = new DevExpress.XtraBars.BarLinkContainerItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.s = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.useSimpleEmmloyeeSwitch.Properties)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).BeginInit();
            this.galleryControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userRouteFolderEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // useSimpleEmmloyeeSwitch
            // 
            this.useSimpleEmmloyeeSwitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.useSimpleEmmloyeeSwitch.Location = new System.Drawing.Point(457, 5);
            this.useSimpleEmmloyeeSwitch.Name = "useSimpleEmmloyeeSwitch";
            this.useSimpleEmmloyeeSwitch.Properties.OffText = "Off";
            this.useSimpleEmmloyeeSwitch.Properties.OnText = "On";
            this.useSimpleEmmloyeeSwitch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.useSimpleEmmloyeeSwitch.Size = new System.Drawing.Size(95, 24);
            this.useSimpleEmmloyeeSwitch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Використовувати спрощену форму Співробітники";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(220, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(563, 395);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.menuButton3);
            this.tabPage1.Controls.Add(this.menuButton2);
            this.tabPage1.Controls.Add(this.galleryControl1);
            this.tabPage1.Controls.Add(this.menuButton1);
            this.tabPage1.Controls.Add(this.clearBtn);
            this.tabPage1.Controls.Add(this.userRouteFolderEdit);
            this.tabPage1.Controls.Add(this.openFileBtn);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.useSimpleEmmloyeeSwitch);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textEdit1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(555, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Налаштування форм";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // menuButton3
            // 
            this.menuButton3.Location = new System.Drawing.Point(81, 115);
            this.menuButton3.Name = "menuButton3";
            this.menuButton3.Size = new System.Drawing.Size(75, 23);
            this.menuButton3.TabIndex = 82;
            this.menuButton3.Text = "menuButton3";
            this.menuButton3.UseVisualStyleBackColor = true;
            // 
            // menuButton2
            // 
            this.menuButton2.Location = new System.Drawing.Point(207, 90);
            this.menuButton2.Name = "menuButton2";
            this.barManager1.SetPopupContextMenu(this.menuButton2, this.popupMenu1);
            this.menuButton2.Size = new System.Drawing.Size(75, 23);
            this.menuButton2.TabIndex = 81;
            this.menuButton2.Text = "menuButton2";
            this.menuButton2.UseVisualStyleBackColor = true;
            // 
            // galleryControl1
            // 
            this.galleryControl1.Controls.Add(this.galleryControlClient1);
            this.galleryControl1.DesignGalleryGroupIndex = 0;
            this.galleryControl1.DesignGalleryItemIndex = 0;
            this.galleryControl1.Location = new System.Drawing.Point(127, 187);
            this.galleryControl1.Name = "galleryControl1";
            this.galleryControl1.Size = new System.Drawing.Size(120, 95);
            this.galleryControl1.TabIndex = 80;
            this.galleryControl1.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl1;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(99, 91);
            // 
            // menuButton1
            // 
            this.menuButton1.Location = new System.Drawing.Point(138, 144);
            this.menuButton1.Name = "menuButton1";
            this.barManager1.SetPopupContextMenu(this.menuButton1, this.popupMenu1);
            this.menuButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuButton1.Size = new System.Drawing.Size(144, 23);
            this.menuButton1.TabIndex = 79;
            this.menuButton1.Text = "menuButton1";
            this.menuButton1.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.Location = new System.Drawing.Point(519, 35);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(29, 23);
            this.clearBtn.TabIndex = 78;
            this.clearBtn.ToolTip = "Очистити";
            // 
            // userRouteFolderEdit
            // 
            this.userRouteFolderEdit.Enabled = false;
            this.userRouteFolderEdit.Location = new System.Drawing.Point(127, 37);
            this.userRouteFolderEdit.Name = "userRouteFolderEdit";
            this.userRouteFolderEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.userRouteFolderEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.userRouteFolderEdit.Size = new System.Drawing.Size(351, 20);
            this.userRouteFolderEdit.TabIndex = 77;
            // 
            // openFileBtn
            // 
            this.openFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("openFileBtn.Image")));
            this.openFileBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.openFileBtn.Location = new System.Drawing.Point(484, 35);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(29, 23);
            this.openFileBtn.TabIndex = 76;
            this.openFileBtn.ToolTip = "Вибрати файл";
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Папка звітів";
            // 
            // textEdit1
            // 
            this.textEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textEdit1.Location = new System.Drawing.Point(182, 297);
            this.textEdit1.MenuManager = this.barManager1;
            this.textEdit1.Name = "textEdit1";
            this.barManager1.SetPopupContextMenu(this.textEdit1, this.popupMenu1);
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 83;
            this.textEdit1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textEdit1_MouseDown);
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
            this.s,
            this.barSubItem1,
            this.SkinsLink});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, DevExpress.XtraBars.BarItemPaintStyle.Standard)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Кольорова схема";
            this.barSubItem1.Id = 1;
            this.barSubItem1.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barSubItem1.ItemAppearance.Hovered.Options.UseFont = true;
            this.barSubItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barSubItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barSubItem1.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barSubItem1.ItemAppearance.Pressed.Options.UseFont = true;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.SkinsLink)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // SkinsLink
            // 
            this.SkinsLink.Caption = "Skins";
            this.SkinsLink.Id = 2;
            this.SkinsLink.Name = "SkinsLink";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(587, 23);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 419);
            this.barDockControlBottom.Size = new System.Drawing.Size(587, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 23);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 396);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(587, 23);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 396);
            // 
            // s
            // 
            this.s.Caption = "barButtonItem1";
            this.s.Id = 0;
            this.s.Name = "s";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(555, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserSettingsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 419);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserSettingsFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Налаштування користувача";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserSettingsFm_FormClosing);
            this.Load += new System.EventHandler(this.UserSettingsFm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.useSimpleEmmloyeeSwitch.Properties)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).EndInit();
            this.galleryControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userRouteFolderEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ToggleSwitch useSimpleEmmloyeeSwitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private DevExpress.XtraEditors.SimpleButton clearBtn;
        private DevExpress.XtraEditors.TextEdit userRouteFolderEdit;
        private DevExpress.XtraEditors.SimpleButton openFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private CustomGUI.MenuButton menuButton1;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl1;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarLinkContainerItem SkinsLink;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem s;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private CustomGUI.MenuButton menuButton2;
        private CustomGUI.MenuButton menuButton3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.PopupContainerEdit textEdit1;
    }
}