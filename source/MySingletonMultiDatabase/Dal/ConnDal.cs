using Dapper;
using MySingletonMultiDatabase.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySingletonMultiDatabase.Dal
{
    class ConnDal : DalBase
    {
        public IEnumerable<DbLogin> GetLoginList()
        {
            string sql = @"SELECT 
            DB_NAME(dbid) as DBName, 
                COUNT(dbid) as count,
                loginame as login
            FROM
                sys.sysprocesses
            WHERE
                dbid > 0
            GROUP BY
            dbid, loginame";
            var DbLoginList = conn.Query<DbLogin>(sql);
            return DbLoginList;
        }
    }
}
