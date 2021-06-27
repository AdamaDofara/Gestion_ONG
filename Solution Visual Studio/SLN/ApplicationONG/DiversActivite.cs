using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MetierONG;
namespace ApplicationONG
{
    public class DiversActivite
    {
        public static Boolean ExisteActivite(string pacticode)
        {
            Activite unActivite = new Activite(pacticode);
            if (unActivite.acticode == null)
            {
                return false;
            }
            else
            {
                if (unActivite.acticode.ToUpper() == pacticode.ToUpper())
                {
                    return true;
                }
                return false;
            }
        }
    }
}
