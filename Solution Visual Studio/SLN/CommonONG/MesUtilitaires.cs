using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonONG
{
    public class MesUtilitaires
    {
        public static string GetConnectString()
        {
            return @"Data Source=NWCL118-HP\SQLEXPRESS;Initial Catalog=bdONGBinome03;Integrated Security=True";
        }
    }
}
