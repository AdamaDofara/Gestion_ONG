using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MetierONG;
namespace ApplicationONG
{
    public class Divers
    {
        public static Boolean ExisteResponsable(string prespoCode)
        {
            Responsable unResponsable = new Responsable(prespoCode);
            if (unResponsable.respocode == null)
            {
                return false;
            }
            else
            {
                if (unResponsable.respocode.ToUpper() == prespoCode.ToUpper())
                {
                    return true;
                }
                return false;
            }
        }
    }
}
