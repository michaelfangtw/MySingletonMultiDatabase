using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySingletonMultiDatabase.Model;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace MySingletonMultiDatabase.Dal
{
    class CustomerDal : DalBase
    {
        public CustomerDal()
        {
        }
      
        public IEnumerable<Customer> GetCustomer()
        {
            string sql= "select * from customers";
            var customerList=conn.Query<Customer>(sql);
            return customerList;
       }

    }
}
