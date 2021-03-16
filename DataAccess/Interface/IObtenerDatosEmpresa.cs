using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    interface IObtenerDatosEmpresa
    {
        bool Get(string fecha,int id, out List<Empresa> lstEmpresa,out Error.Error err);

        Empresa GetOne(int id);
        bool Save(List<Empresa> emp, out Error.Error err);
        Empresa Delete();
        bool Update(Empresa emp, out Error.Error err);
        
    }
}
