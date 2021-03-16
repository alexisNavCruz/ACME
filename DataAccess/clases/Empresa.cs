using DataAccess.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Empresa
    {
        public int id { get; set; }
        public int? idProvCap { get; set; }
        public string Nombre { get; set; }
        public string Desc { get; set; }
        public string fecha { get; set; }

        public ProvCapDA ProvinciaCapital { get; set; }
        public Empresa()
        {
            ProvinciaCapital = new ProvCapDA();
        }
    }
}
