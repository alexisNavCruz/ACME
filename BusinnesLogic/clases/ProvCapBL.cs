using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLogic.clases
{
    public class ProvCapBL
    {
        public int IdProvCap { get; set; }
        public CapitalesBL CapitalBL { get; set; }
        public ProvinciasBL ProvinciaBL { get; set; }

        public ProvCapBL()
        {
            CapitalBL = new CapitalesBL();
            ProvinciaBL = new ProvinciasBL();
        }
    }
}
