using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraBars.Helpers;
using DevExpress.LookAndFeel;
using ERP_NEW.GUI.Properties;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Skins;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using Ninject;

namespace ERP_NEW.GUI.Tools
{
    public partial class UserSettingsFm : DevExpress.XtraEditors.XtraForm
    {
        private ILogService logService;
        public UserTasksDTO userTasksDTO;
        public UserSettingsFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            logService = Program.kernel.Get<ILogService>();
            this.userTasksDTO = userTasksDTO;

            UserLookAndFeel.Default.SkinName = Settings.Default["ApplicationSkinName"].ToString();
            useSimpleEmmloyeeSwitch.DataBindings.Add("EditValue", Properties.Settings.Default, "UserUsedSimpleEmployeeForm", true, DataSourceUpdateMode.OnPropertyChanged);
            useSuperUserSwitch.DataBindings.Add("EditValue", Properties.Settings.Default, "SuperUser", true, DataSourceUpdateMode.OnPropertyChanged);
            userRouteFolderEdit.DataBindings.Add("EditValue", Properties.Settings.Default, "UserFolderRoute", true, DataSourceUpdateMode.OnPropertyChanged);
            appSkinEdit.DataBindings.Add("EditValue", Properties.Settings.Default, "ApplicationSkinName", true, DataSourceUpdateMode.OnPropertyChanged);
            changeUserBtn.Visible = Properties.Settings.Default.SuperUser;

            if (logService.CheckTable("Log"))
                logerTableCheck.EditValue = true;


        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            //string folderPath = "";
            //string fileName = "";

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.UserFolderRoute = fbd.SelectedPath;
        }

        private void UserSettingsFm_Load(object sender, EventArgs e)
        {
            styleMenu.ItemLinks.Add(SkinsLink);
            
            SkinHelper.InitSkinPopupMenu(SkinsLink);
        }

        private void UserSettingsFm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default["ApplicationSkinName"] = UserLookAndFeel.Default.SkinName;
            Settings.Default.Save();
        }

        private void appSkinEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            styleMenu.ShowPopup(Control.MousePosition);
        }

        private void barManager1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Settings.Default["ApplicationSkinName"] = UserLookAndFeel.Default.SkinName;
            Settings.Default.Save();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void createLogerTableBtn_Click(object sender, EventArgs e)
        {
            logService.CreateTable();
            if (logService.CheckTable("Log"))
            {
                MessageBox.Show("Таблицю \"Log\" створено");
                logerTableCheck.EditValue = true;
                logService.CreateLogRecord("Створено таблицю Log", BLL.Infrastructure.Utils.Level.Info, userTasksDTO, "UserSettingsFm");
            }
            else
            {
                MessageBox.Show("Таблицю \"Log\" не створено");
                logerTableCheck.EditValue = false;
                logService.CreateLogRecord("Створено таблицю Log не створено", BLL.Infrastructure.Utils.Level.Info, userTasksDTO, "UserSettingsFm");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

        }

        private void useSuperUserSwitch_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void activeSuperUserBtn_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.SuperUser)
            {
                try
                {
                    using (UserAuthFm userAuthFm = new UserAuthFm("SuperUser"))
                    {
                        if (userAuthFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            changeUserBtn.Visible = Properties.Settings.Default.SuperUser;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час авторизації", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                changeUserBtn.Visible = Properties.Settings.Default.SuperUser;
            }
            else if(Properties.Settings.Default.SuperUser)
            {
                Properties.Settings.Default.SuperUser = false;
                //changeUserBtn.Visible = Properties.Settings.Default.SuperUser;

            }
        }

        private void useSuperUserSwitch_EditValueChanged_1(object sender, EventArgs e)
        {
            if ((bool)useSuperUserSwitch.EditValue)
            {
                activeSuperUserBtn.Text = "Деактивувати";
            }
            else
            {
                activeSuperUserBtn.Text = "Активувати";
            }
            changeUserBtn.Visible = Properties.Settings.Default.SuperUser;
        }

        private void changeUserBtn_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SuperUser)
            {
                try
                {
                    using (UserAuthFm userAuthFm = new UserAuthFm(""))
                    {
                        DialogResult ret = userAuthFm.ShowDialog();
                        if (ret == System.Windows.Forms.DialogResult.OK)
                        {
                            changeUserBtn.Visible = Properties.Settings.Default.SuperUser;

                        }
                        else if(ret == System.Windows.Forms.DialogResult.Cancel)
                        {
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час авторизації", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                changeUserBtn.Visible = Properties.Settings.Default.SuperUser;
            }
        }
    }
}