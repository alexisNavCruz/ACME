using BusinnesLogic.clases;
using DataAccess.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLogic.Interface
{
    interface IObtenerProvCapBL
    {
        List<ProvCapBL> get_ProvCapBL(List<ProvCapDA> LstProvCapDA);
    }
}
