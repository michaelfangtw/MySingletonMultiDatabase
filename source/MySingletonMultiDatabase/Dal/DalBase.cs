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
    class DalBase
    {
        public SqlConnection conn = null;
        private string ConnnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            }
        }


        public DalBase()
        {
            conn = new SqlConnection(ConnnectionString);
        }
        public DalBase(string connectionString)
        {
            conn = new SqlConnection(connectionString);
        }

        public string GetPID()
        {
            string sql = "SELECT @@SPID ";
            var pid = conn.QuerySingle<string>(sql);
            return pid.ToString();
        }
    }
}
