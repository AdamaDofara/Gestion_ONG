using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MetierONG;
namespace ApplicationONG
{
    public class DiversAgen
    {
        public static Boolean ExisteAgence(string pagenCode)
        {
            Agence unAgence = new Agence(pagenCode);
            if (unAgence.agencode == null)
            {
                return false;
            }
            else
            {
                if (unAgence.agencode.ToUpper() == pagenCode.ToUpper())
                {
                    return true;
                }
                return false;
            }
        }
    }
}
