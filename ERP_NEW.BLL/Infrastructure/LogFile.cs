using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Common;
using System.IO;

namespace ERP_NEW.BLL.Infrastructure
{
    public class LoggerInfo 
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        //private StreamWriter InnerWriter;
        public void Main()
        {
            Logger.Trace("User - {0}", Environment.UserName);
        }

        public void Info()
        {
            Logger.Info("User - {0}", Environment.UserName);
        }

        public void Info(string ex)
        {
            Logger.Info("User - {0}", Environment.UserName + " " + ex);
        }

        public void Error(string ex)
        {
            Logger.Error("User - {0}",Environment.UserName +" " + ex);
        }


    }
}  
           



