using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MetierONG;
namespace ApplicationONG
{
    public class DiverAppreciation
    {
        public static Boolean ExisteAppreciation(string pacticode)
        {
            Appreciation unAppreciation = new Appreciation(pacticode);
            if (unAppreciation.acticode == null)
            {
                return false;
            }
            else
            {
                if (unAppreciation.acticode.ToUpper() == pacticode.ToUpper())
                {
                    return true;
                }
                return false;
            }
        }
    }
}
