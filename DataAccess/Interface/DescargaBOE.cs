using DataAccess.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public class DescargaBOE : IDescargaBOE
    {
        public bool GetListadoFechas(out List<FechasBOE> lst,out Error.Error err)
        {
            Error.Error error = new Error.Error();
            List<FechasBOE> lstResult = new List<FechasBOE>();
            try
            {
                using (DataAccess.ACMEEntities db = new ACMEEntities())
                {
                    lstResult = Mapper.MapperFecha.MapFechaEntityToDA_tolist(db.FechasDescargaBOE.ToList());
                }
                error.mensaje = "Fechas obtenidas con exito";
                error.ok = true;
            }
            catch (Exception e)
            {
                error.mensaje = "Error al obtener las fechas de descarga del BOE"+e.Message;
                error.ok = false;

            }
            err = error;
            lst = lstResult;
            return err.ok;
        }


        public bool save(FechasBOE fecha, out Error.Error err)
        {
            Error.Error error = new Error.Error();
            try
            {
                using (DataAccess.ACMEEntities db = new ACMEEntities())
                {
                    FechasDescargaBOE ent = Mapper.MapperFecha.MapFechaDATOEntity(fecha);
                    db.FechasDescargaBOE.Add(ent);
                    db.SaveChanges();
                }
                error.ok = true;
                error.mensaje = "fecha añadida con exito";
            }
            catch (Exception e)
            {
                error.ok = false;
                error.mensaje = "Error al añadir fecha";
                Console.WriteLine(e.Message);
            }
            err = error;
            return error.ok;
        }
    }
}
