using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Alıştırma
{
     class ConnectClass
    {
        public string ConnectAdress = System.IO.File.ReadAllText(@"C:\Source.txt");
    }
}
