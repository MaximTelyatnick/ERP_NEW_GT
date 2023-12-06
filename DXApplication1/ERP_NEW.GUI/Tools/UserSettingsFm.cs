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

namespace ERP_NEW.GUI.Tools
{
    public partial class UserSettingsFm : DevExpress.XtraEditors.XtraForm
    {
        public UserSettingsFm()
        {
            InitializeComponent();
            //SkinHelper.InitSkinGallery(galleryControl1);
            UserLookAndFeel.Default.SkinName = Settings.Default["ApplicationSkinName"].ToString();
            useSimpleEmmloyeeSwitch.DataBindings.Add("EditValue", Properties.Settings.Default, "UserUsedSimpleEmployeeForm", true, DataSourceUpdateMode.OnPropertyChanged);
            userRouteFolderEdit.DataBindings.Add("EditValue", Properties.Settings.Default, "UserFolderRoute", true, DataSourceUpdateMode.OnPropertyChanged);


            //foreach (SkinContainer skin in SkinManager.Default.Skins)
            //    contextMenuStrip1.Items.Add(skin.SkinName);
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            string fileName = "";

            FolderBrowserDialog fbd = new FolderBrowserDialog();
           // OpenFileDialog ofd = new OpenFileDialog();
           // ofd.InitialDirectory = @"D:\";
            if (fbd.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.UserFolderRoute = fbd.SelectedPath;
        }

        private void UserSettingsFm_Load(object sender, EventArgs e)
        {
            popupMenu1.ItemLinks.Add(SkinsLink);
            
            SkinHelper.InitSkinPopupMenu(SkinsLink);
        }

        private void barSubItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void UserSettingsFm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default["ApplicationSkinName"] = UserLookAndFeel.Default.SkinName;
            Settings.Default.Save();
        }

        private void textEdit1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Покажіть PopupMenu при натисканні лівої кнопки миші
                popupMenu.ShowPopup(Control.MousePosition);
            }
        }
    }
}