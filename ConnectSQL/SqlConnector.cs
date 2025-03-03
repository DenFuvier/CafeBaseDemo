using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBase.ConnectSQL
{
    class SqlConnector
    {
        public string server = "localhost";
        public string userid = "root";
        public string password = "vertrigo";
        public string database = "CafeBase";

        public string Getconnect()
        {
            return $"server={server};userid={userid};password={password};database={database}";
        }
    }
   
}
