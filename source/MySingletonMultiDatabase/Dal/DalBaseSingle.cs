using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySingletonMultiDatabase.Dal
{
    class DalBaseSingle
    {
        public SqlConnection conn = null;
        private string ConnnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            }
        }


        public DalBaseSingle()
        {
            conn = SingletonDb.Instance.GetConnection(ConnnectionString);
        }
        public DalBaseSingle(string connectionString)
        {
            conn = SingletonDb.Instance.GetConnection(connectionString);
        }

        public string GetPID()
        {
            string sql = "SELECT @@SPID ";
            var pid = conn.QuerySingle<string>(sql);
            return pid;
        }
    }
}
