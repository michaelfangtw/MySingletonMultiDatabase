using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySingletonMultiDatabase.Model
{
        public class ConnList
        {
            public string DBName            {get; set;}
            int NumberOfConnections         {get; set;}
            string LoginName                { get; set; }
        }
}
