using ACMEN.clases;
using BusinnesLogic.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEN.Interface
{
    interface IObtenerDatosEmpresaUI
    {
        List<EmpresaUI> Get(List<EmpresaBL> lstEmpresasBL);
    }
}
