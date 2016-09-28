using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySingletonMultiDatabase.Dal
{
    public sealed class SingletonDb
    {
        private static volatile SingletonDb instance;
        private static object syncRoot = new Object();
        static SqlConnection conn=null;
        //constructor must be private
        private SingletonDb()
        {

        }

        public static SingletonDb Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new SingletonDb();
                    }
                }

                return instance;
            }
        }

        public SqlConnection GetConnection(string connnectionString)
        {
            if (conn == null) {
                conn = new SqlConnection(connnectionString);
                conn.Open();
            }
            else
            {
                if (conn.State != ConnectionState.Open) conn.Open();
            }
            return conn;
        }      


      
    }
}
