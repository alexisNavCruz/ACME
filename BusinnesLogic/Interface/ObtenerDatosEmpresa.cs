using BusinnesLogic.clases;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLogic.Interface
{
    public class ObtenerDatosEmpresa : IObtenerDatosEmpresa
    {
        public EmpresaBL Delete()
        {
            throw new NotImplementedException();
        }

      
        public List<EmpresaBL> Get(List<Empresa> lstEmpresaDA)
        {
            return Mapper.MapperEmpresaBL.MapDAtoBL_Tolist(lstEmpresaDA);
        }

        public EmpresaBL Save()
        {
            throw new NotImplementedException();
        }

        public EmpresaBL Update()
        {
            throw new NotImplementedException();
        }
    }
}
