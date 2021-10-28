using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;


namespace ERP_NEW.BLL.Infrastructure
{
    public class DefinitionPathToServer
    {
        public static string DefinitionPath()
        {
            string homePath = "";
            FbConnectionStringBuilder csb;
            string rezDefinitionSaveToServer = "";
            csb = new FbConnectionStringBuilder()
            {
                DataSource = "server-asup",
                Database = "TVM_DB",
                UserID = "sysdba",
                Password = "masterkey",
                Charset = "UTF8",
                Pooling = true,
                ConnectionLifeTime = 900

            };
#if DEBUG
            csb = new FbConnectionStringBuilder()
            {
                DataSource = "server-tfs",
                Database = "TVM_DB",
                UserID = "sysdba",
                Password = "masterkey",
                Charset = "UTF8",
                Pooling = true,
                ConnectionLifeTime = 900
            };
#endif
            homePath = "";
            rezDefinitionSaveToServer = csb.DataSource.ToString();
            homePath = rezDefinitionSaveToServer;
            //if (rezDefinitionSaveToServer == "server-asup")
            //    homePath = @"\\SERVER-TFS\Data\Journal\";
            //if (rezDefinitionSaveToServer == "server-tfs")
            //    homePath = @"\\SERVER-TFS\Data\DebugJournal\";
            return  homePath;
        }
    }
}
