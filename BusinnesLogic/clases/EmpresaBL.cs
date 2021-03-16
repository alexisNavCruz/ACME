using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLogic.clases
{
    public class EmpresaBL
    {
        public int id { get; set; }
        public int? idProvCap { get; set; }
        public string Nombre { get; set; }
        public string Desc { get; set; }
        public string fecha { get; set; }
        public ProvCapBL ProvCap { get; set; }

        public EmpresaBL()
        {
            ProvCap = new ProvCapBL();
        }
    }
}
