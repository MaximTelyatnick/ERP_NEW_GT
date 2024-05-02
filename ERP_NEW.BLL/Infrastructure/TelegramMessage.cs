using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Infrastructure
{
    public static class TelegramMessage
    {

        public static string SendMessageToTelegram()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try 
	        {
                Task.Run(async () => {
                    using (var httpClient = new HttpClient())
                    {
                        var a = await httpClient.GetStringAsync("https://api.telegram.org/bot7138161176:AAHbtumnbrUsXTG7D5LJqdtdTyyQkr5rKTk/sendMessage?chat_id=@techvagonmash_loger&text=test");
                    }
                });
                return string.Empty;
            }
	        catch (Exception ex)
	        {
                return ex.Message;
            }    
        }    
    }
}
