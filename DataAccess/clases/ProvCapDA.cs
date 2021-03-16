using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.clases
{
    public class ProvCapDA
    {
        public int idProvCap { get; set; }
        public CapitalesDA Capitales { get; set; }
        public ProvinciasDA Provincias { get; set; }

        public ProvCapDA()
        {
            Capitales = new clases.CapitalesDA();
            Provincias = new clases.ProvinciasDA();
        }
    }
}
