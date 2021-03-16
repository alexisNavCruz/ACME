using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.clases;

namespace DataAccess.Interface
{
    public class ObtenerProvCapDA : IObtenerProvCapDA
    {
        public List<ProvCapDA> Get_provinciaCapital()
        {
            using (DataAccess.ACMEEntities db = new ACMEEntities())
            {
                return Mapper.MapperProvinciaCapital.MapEntityToProvCapDA(db.ProvCap.ToList());
            }
        }
    }
}
