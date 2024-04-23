using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Threading;
using Ninject;
using ERP_NEW.BLL.Infrastructure;
using DevExpress.XtraEditors.Controls;
using System.Globalization;
using Telegram.Bot;
using System.Net.Http;
using System.Threading.Tasks;

namespace ERP_NEW.GUI
{
    static class Program
    {
        public static IKernel kernel = new StandardKernel(new ServiceModule());
        public static readonly HttpClient client = new HttpClient();


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-UA");

            Localizer.Active = Localizer.CreateDefaultLocalizer();
            bool flag = true;//false;
            Mutex mutex = new Mutex(false, "ERP", out flag);
            //var botClient = new TelegramBotClient("AAHbtumnbrUsXTG7D5LJqdtdTyyQkr5rKTk");
            //await botClient.SendTextMessageAsync(chatId: "7138161176", text: "Hello, Telegram API in C#!");

            //if (!flag)
            //{
            //    MessageBox.Show("Программа уже запущена!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            
            BonusSkins.Register();

            SkinManager.EnableFormSkins();


            

            try
            {
                TelegramMessage.SendMessageToTelegram();
                Application.Run(new MainTabFm());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникла помилка. " + ex.Message, "Інфо", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            mutex.Close();
        }


       
    }
}
