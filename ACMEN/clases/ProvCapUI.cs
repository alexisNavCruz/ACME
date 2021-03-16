using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEN.clases
{
    public class ProvCapUI
    {
        public int idProvCap { get; set; }
        public ProvinciasUI Provincia{ get; set; }
        public CapitalesUI Capital { get; set; }

        public ProvCapUI()
        {
            Provincia = new ProvinciasUI();
            Capital = new CapitalesUI();
        }
    }
}
