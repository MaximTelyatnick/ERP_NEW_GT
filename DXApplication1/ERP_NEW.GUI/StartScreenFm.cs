using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Services;
using Ninject;
using System.Threading;

namespace ERP_NEW.GUI
{
    public partial class StartScreenFm : SplashScreen
    {
        private string processText;
        private IUserService userService = Program.kernel.Get<IUserService>();

        public StartScreenFm()
        {
            InitializeComponent();
        }
       
        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
            
            SplashScreenCommand command = (SplashScreenCommand)cmd;

            if (command == SplashScreenCommand.SetLabel)
            {
                processText = (string)arg;
                statusLbl.Text = processText;
            }
        }

        #endregion

        public enum SplashScreenCommand
        {
            SetLabel
        }
    }
}