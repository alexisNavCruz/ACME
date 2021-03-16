using DataAccess.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    interface IDescargaBOE
    {
        bool GetListadoFechas(out List<FechasBOE> lst,out Error.Error err);
        bool save(FechasBOE fecha, out Error.Error err);
    }
}
