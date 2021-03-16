using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinnesLogic.clases;
using DataAccess.clases;

namespace BusinnesLogic.Interface
{
    public class ObtenerProvCapBL : IObtenerProvCapBL
    {
        public List<ProvCapBL> get_ProvCapBL(List<ProvCapDA> LstProvCapDA)
        {
            return Mapper.MapperProvCapBL.MapProvCapDAtoBL_tolist(LstProvCapDA);
        }
    }
}
