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
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.useSimpleEmmloyeeSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.userRouteFolderEdit = new DevExpress.XtraEditors.TextEdit();
            this.openFileBtn = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.appSkinEdit = new DevExpress.XtraEditors.PopupContainerEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.styleMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.s = new DevExpress.XtraBars.BarButtonItem();
            this.SkinsLink = new DevExpress.XtraBars.BarLinkContainerItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearBtn = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.mainTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.testBdBtn = new DevExpress.XtraEditors.SimpleButton();
            this.connectDbSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.label7 = new System.Windows.Forms.Label();
            this.activeSuperUserBtn = new DevExpress.XtraEditors.SimpleButton();
            this.changeUserBtn = new DevExpress.XtraEditors.SimpleButton();
            this.useSuperUserSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.label6 = new System.Windows.Forms.Label();
            this.useHolidaySwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logerTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.logerTableCheck = new DevExpress.XtraEditors.CheckEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.createLogerTableBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.useSimpleEmmloyeeSwitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRouteFolderEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appSkinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.mainTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectDbSwitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useSuperUserSwitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useHolidaySwitch.Properties)).BeginInit();
            this.logerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logerTableCheck.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // useSimpleEmmloyeeSwitch
            // 
            this.useSimpleEmmloyeeSwitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.useSimpleEmmloyeeSwitch.Location = new System.Drawing.Point(486, 19);
            this.useSimpleEmmloyeeSwitch.Name = "useSimpleEmmloyeeSwitch";
            this.useSimpleEmmloyeeSwitch.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.useSimpleEmmloyeeSwitch.Properties.OffText = "Викл";
            this.useSimpleEmmloyeeSwitch.Properties.OnText = "Вкл";
            this.useSimpleEmmloyeeSwitch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.useSimpleEmmloyeeSwitch.Size = new System.Drawing.Size(95, 24);
            this.useSimpleEmmloyeeSwitch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Використовувати спрощену форму Співробітники";
            // 
            // userRouteFolderEdit
            // 
            this.userRouteFolderEdit.Enabled = false;
            this.userRouteFolderEdit.Location = new System.Drawing.Point(138, 78);
            this.userRouteFolderEdit.Name = "userRouteFolderEdit";
            this.userRouteFolderEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.userRouteFolderEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.userRouteFolderEdit.Size = new System.Drawing.Size(343, 20);
            this.userRouteFolderEdit.TabIndex = 77;
            // 
            // openFileBtn
            // 
            this.openFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("openFileBtn.Image")));
            this.openFileBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.openFileBtn.Location = new System.Drawing.Point(487, 76);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(29, 23);
            this.openFileBtn.TabIndex = 76;
            this.openFileBtn.ToolTip = "Вибрати файл";
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Папка звітів";
            // 
            // appSkinEdit
            // 
            this.appSkinEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.appSkinEdit.Location = new System.Drawing.Point(138, 104);
            this.appSkinEdit.MenuManager = this.barManager1;
            this.appSkinEdit.Name = "appSkinEdit";
            this.barManager1.SetPopupContextMenu(this.appSkinEdit, this.styleMenu);
            this.appSkinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.appSkinEdit.Size = new System.Drawing.Size(413, 20);
            this.appSkinEdit.TabIndex = 83;
            this.appSkinEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.appSkinEdit_ButtonClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.s,
            this.SkinsLink});
            this.barManager1.MaxItemId = 3;
            this.barManager1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barManager1_ItemClick);
            // 
            // styleMenu
            // 
            this.styleMenu.Manager = this.barManager1;
            this.styleMenu.Name = "styleMenu";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(594, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 416);
            this.barDockControlBottom.Size = new System.Drawing.Size(594, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 416);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(594, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 416);
            // 
            // s
            // 
            this.s.Caption = "barButtonItem1";
            this.s.Id = 0;
            this.s.Name = "s";
            // 
            // SkinsLink
            // 
            this.SkinsLink.Caption = "Skins";
            this.SkinsLink.Id = 2;
            this.SkinsLink.Name = "SkinsLink";
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
            // clearBtn
            // 
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.Location = new System.Drawing.Point(522, 76);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(29, 23);
            this.clearBtn.TabIndex = 78;
            this.clearBtn.ToolTip = "Очистити";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.mainTabPage;
            this.xtraTabControl1.Size = new System.Drawing.Size(594, 416);
            this.xtraTabControl1.TabIndex = 7;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.mainTabPage,
            this.logerTabPage});
            // 
            // mainTabPage
            // 
            this.mainTabPage.Controls.Add(this.testBdBtn);
            this.mainTabPage.Controls.Add(this.connectDbSwitch);
            this.mainTabPage.Controls.Add(this.label7);
            this.mainTabPage.Controls.Add(this.activeSuperUserBtn);
            this.mainTabPage.Controls.Add(this.changeUserBtn);
            this.mainTabPage.Controls.Add(this.useSuperUserSwitch);
            this.mainTabPage.Controls.Add(this.label6);
            this.mainTabPage.Controls.Add(this.useHolidaySwitch);
            this.mainTabPage.Controls.Add(this.label4);
            this.mainTabPage.Controls.Add(this.label3);
            this.mainTabPage.Controls.Add(this.clearBtn);
            this.mainTabPage.Controls.Add(this.appSkinEdit);
            this.mainTabPage.Controls.Add(this.openFileBtn);
            this.mainTabPage.Controls.Add(this.userRouteFolderEdit);
            this.mainTabPage.Controls.Add(this.useSimpleEmmloyeeSwitch);
            this.mainTabPage.Controls.Add(this.label1);
            this.mainTabPage.Controls.Add(this.label2);
            this.mainTabPage.Image = ((System.Drawing.Image)(resources.GetObject("mainTabPage.Image")));
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.Size = new System.Drawing.Size(588, 385);
            this.mainTabPage.Text = "Налаштування додатку";
            // 
            // testBdBtn
            // 
            this.testBdBtn.Location = new System.Drawing.Point(350, 160);
            this.testBdBtn.Name = "testBdBtn";
            this.testBdBtn.Size = new System.Drawing.Size(130, 24);
            this.testBdBtn.TabIndex = 94;
            this.testBdBtn.Text = "Test";
            this.testBdBtn.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.testBdBtn.Click += new System.EventHandler(this.testBdBtn_Click);
            // 
            // connectDbSwitch
            // 
            this.connectDbSwitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.connectDbSwitch.Location = new System.Drawing.Point(486, 160);
            this.connectDbSwitch.Name = "connectDbSwitch";
            this.connectDbSwitch.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.connectDbSwitch.Properties.OffText = "Викл";
            this.connectDbSwitch.Properties.OnText = "Вкл";
            this.connectDbSwitch.Properties.ReadOnly = true;
            this.connectDbSwitch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.connectDbSwitch.Size = new System.Drawing.Size(95, 24);
            this.connectDbSwitch.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "Підключення до БД";
            // 
            // activeSuperUserBtn
            // 
            this.activeSuperUserBtn.Location = new System.Drawing.Point(350, 130);
            this.activeSuperUserBtn.Name = "activeSuperUserBtn";
            this.activeSuperUserBtn.Size = new System.Drawing.Size(130, 24);
            this.activeSuperUserBtn.TabIndex = 91;
            this.activeSuperUserBtn.Text = "Активувати ";
            this.activeSuperUserBtn.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.activeSuperUserBtn.Click += new System.EventHandler(this.activeSuperUserBtn_Click);
            // 
            // changeUserBtn
            // 
            this.changeUserBtn.Location = new System.Drawing.Point(214, 130);
            this.changeUserBtn.Name = "changeUserBtn";
            this.changeUserBtn.Size = new System.Drawing.Size(130, 24);
            this.changeUserBtn.TabIndex = 90;
            this.changeUserBtn.Text = "Змінити користувача";
            this.changeUserBtn.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.changeUserBtn.Click += new System.EventHandler(this.changeUserBtn_Click);
            // 
            // useSuperUserSwitch
            // 
            this.useSuperUserSwitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.useSuperUserSwitch.Location = new System.Drawing.Point(486, 130);
            this.useSuperUserSwitch.Name = "useSuperUserSwitch";
            this.useSuperUserSwitch.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.useSuperUserSwitch.Properties.OffText = "Викл";
            this.useSuperUserSwitch.Properties.OnText = "Вкл";
            this.useSuperUserSwitch.Properties.ReadOnly = true;
            this.useSuperUserSwitch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.useSuperUserSwitch.Size = new System.Drawing.Size(95, 24);
            this.useSuperUserSwitch.TabIndex = 87;
            this.useSuperUserSwitch.EditValueChanged += new System.EventHandler(this.useSuperUserSwitch_EditValueChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 88;
            this.label6.Text = "Режим суперкористувача";
            // 
            // useHolidaySwitch
            // 
            this.useHolidaySwitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.useHolidaySwitch.Location = new System.Drawing.Point(486, 47);
            this.useHolidaySwitch.Name = "useHolidaySwitch";
            this.useHolidaySwitch.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.useHolidaySwitch.Properties.OffText = "Викл";
            this.useHolidaySwitch.Properties.OnText = "Вкл";
            this.useHolidaySwitch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.useHolidaySwitch.Size = new System.Drawing.Size(95, 24);
            this.useHolidaySwitch.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 86;
            this.label4.Text = "Свята у табелі";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Стиль програми";
            // 
            // logerTabPage
            // 
            this.logerTabPage.Controls.Add(this.logerTableCheck);
            this.logerTabPage.Controls.Add(this.label5);
            this.logerTabPage.Controls.Add(this.createLogerTableBtn);
            this.logerTabPage.Image = ((System.Drawing.Image)(resources.GetObject("logerTabPage.Image")));
            this.logerTabPage.Name = "logerTabPage";
            this.logerTabPage.PageVisible = false;
            this.logerTabPage.Size = new System.Drawing.Size(588, 385);
            this.logerTabPage.Text = "Налаштування логеру";
            // 
            // logerTableCheck
            // 
            this.logerTableCheck.Location = new System.Drawing.Point(446, 17);
            this.logerTableCheck.MenuManager = this.barManager1;
            this.logerTableCheck.Name = "logerTableCheck";
            this.logerTableCheck.Properties.Caption = "";
            this.logerTableCheck.Properties.ReadOnly = true;
            this.logerTableCheck.Size = new System.Drawing.Size(17, 19);
            this.logerTableCheck.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Створити таблицю для логування ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // createLogerTableBtn
            // 
            this.createLogerTableBtn.Location = new System.Drawing.Point(469, 15);
            this.createLogerTableBtn.Name = "createLogerTableBtn";
            this.createLogerTableBtn.Size = new System.Drawing.Size(100, 23);
            this.createLogerTableBtn.TabIndex = 0;
            this.createLogerTableBtn.Text = "Create";
            this.createLogerTableBtn.Click += new System.EventHandler(this.createLogerTableBtn_Click);
            // 
            // UserSettingsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 416);
            this.Controls.Add(this.xtraTabControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.userRouteFolderEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appSkinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.mainTabPage.ResumeLayout(false);
            this.mainTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectDbSwitch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useSuperUserSwitch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useHolidaySwitch.Properties)).EndInit();
            this.logerTabPage.ResumeLayout(false);
            this.logerTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logerTableCheck.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ToggleSwitch useSimpleEmmloyeeSwitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private DevExpress.XtraEditors.TextEdit userRouteFolderEdit;
        private DevExpress.XtraEditors.SimpleButton openFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarLinkContainerItem SkinsLink;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem s;
        private DevExpress.XtraBars.PopupMenu styleMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.PopupContainerEdit appSkinEdit;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage mainTabPage;
        private DevExpress.XtraEditors.SimpleButton clearBtn;
        private DevExpress.XtraTab.XtraTabPage logerTabPage;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ToggleSwitch useHolidaySwitch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton createLogerTableBtn;
        private DevExpress.XtraEditors.CheckEdit logerTableCheck;
        private DevExpress.XtraEditors.ToggleSwitch useSuperUserSwitch;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton changeUserBtn;
        private DevExpress.XtraEditors.SimpleButton activeSuperUserBtn;
        private DevExpress.XtraEditors.SimpleButton testBdBtn;
        private DevExpress.XtraEditors.ToggleSwitch connectDbSwitch;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}