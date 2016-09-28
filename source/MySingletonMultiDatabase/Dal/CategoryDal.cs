using MySingletonMultiDatabase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;

namespace MySingletonMultiDatabase.Dal
{
    class CategoryDal:DalBase
    {
        public IEnumerable<Category> GetCategory()
        {
            string sql = "select * from categories";
            var categoryList = conn.Query<Category>(sql);
            return categoryList;
        }
    }
}
