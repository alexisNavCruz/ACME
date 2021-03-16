using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEN.clases
{
    public class EmpresaUI
    {
        public int id { get; set; }
        public int? idProvCap { get; set; }
        public string Nombre { get; set; }
        public string Desc { get; set; }
        public string fecha { get; set; }
        public ProvCapUI ProvCap { get; set; }

        public EmpresaUI()
        {
            ProvCap = new ProvCapUI();
        }
    }
}
