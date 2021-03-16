using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error
{
    public class Error
    {
        public bool ok { get; set; }
        public string mensaje { get; set; }

        public Error()
        {
            this.ok = true;
            this.mensaje = string.Empty;
        }
    }
}
