using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.clases
{
    public class FechasBOE :Error.Error
    {
        public int Id { get; set; }
        public DateTime FechaDescargaBoe { get; set; }
    }
}
