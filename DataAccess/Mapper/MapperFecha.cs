using DataAccess.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public static class MapperFecha
    {
        public static FechasBOE MapFechaEntityToDA(FechasDescargaBOE EntidadFecha)
        {
            FechasBOE dt = new FechasBOE();
            dt.Id = EntidadFecha.CalendarID;
            dt.FechaDescargaBoe = EntidadFecha.fecha.Value;
            return dt;
        }
        public static List<FechasBOE> MapFechaEntityToDA_tolist(List<FechasDescargaBOE> EntidadFecha)
        {
            List<FechasBOE> lstFechasBOE = new List<FechasBOE>();
            foreach(FechasDescargaBOE f in EntidadFecha)
            {
                lstFechasBOE.Add(MapFechaEntityToDA(f));
            }
            return lstFechasBOE;
        }

        public static FechasDescargaBOE MapFechaDATOEntity(FechasBOE EntidadFecha)
        {
            FechasDescargaBOE dt = new FechasDescargaBOE();
            dt.CalendarID = EntidadFecha.Id;
            dt.fecha = EntidadFecha.FechaDescargaBoe;
            return dt;
        }
        public static List<FechasDescargaBOE> MapFechaDATOEntity_tolist(List<FechasBOE> EntidadFecha)
        {
            List<FechasDescargaBOE> lstFechasBOE = new List<FechasDescargaBOE>();
            foreach (FechasBOE f in EntidadFecha)
            {
                lstFechasBOE.Add(MapFechaDATOEntity(f));
            }
            return lstFechasBOE;
        }
    }
}
