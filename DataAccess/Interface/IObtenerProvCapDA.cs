using DataAccess.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    interface IObtenerProvCapDA
    {
        List<ProvCapDA> Get_provinciaCapital();
    }
}
