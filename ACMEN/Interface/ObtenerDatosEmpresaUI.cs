using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACMEN.clases;
using BusinnesLogic.clases;

namespace ACMEN.Interface
{
    class ObtenerDatosEmpresaUI : IObtenerDatosEmpresaUI
    {
        public List<EmpresaUI> Get(List<EmpresaBL> lstEmpresasBL)
        {
            return Mapper.MapperEmpresaUI.MapEntityToEmpresa(lstEmpresasBL);
        }
    }
}
