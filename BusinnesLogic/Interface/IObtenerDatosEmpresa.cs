using BusinnesLogic.clases;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLogic.Interface
{
    interface IObtenerDatosEmpresa
    {
        List<EmpresaBL> Get(List<Empresa> lstEmpresaDA);
        EmpresaBL Save();
        EmpresaBL Delete();
        EmpresaBL Update();
    }
}
