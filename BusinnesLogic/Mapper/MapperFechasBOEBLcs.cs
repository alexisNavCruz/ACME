using BusinnesLogic.clases;
using DataAccess.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLogic.Mapper
{
    public static class MapperFechasBOEBLcs
    {
        public static FechasBOEBL MapFechaDAToBL(FechasBOE fechaDA)
        {
            FechasBOEBL dt = new FechasBOEBL();
            dt.idCalendar = fechaDA.Id;
            dt.fecha = fechaDA.FechaDescargaBoe;
            return dt;
        }
        public static List<FechasBOEBL> MapFechaDAToBL_tolist(List<FechasBOE> listado)
        {
            List<FechasBOEBL> lstFechasBOEbl = new List<FechasBOEBL>();
            foreach (FechasBOE f in listado)
            {
                lstFechasBOEbl.Add(MapFechaDAToBL(f));
            }
            return lstFechasBOEbl;
        }

        public static FechasBOE MapFechaBLToDA(FechasBOEBL fechas)
        {
            FechasBOE dt = new FechasBOE();
            dt.Id = fechas.idCalendar;
            dt.FechaDescargaBoe = fechas.fecha;
            return dt;
        }
        public static List<FechasBOE> MapFechaBLToDA_tolist(List<FechasBOEBL> listado)
        {
            List<FechasBOE> lstFechas = new List<FechasBOE>();
            foreach (FechasBOEBL f in listado)
            {
                lstFechas.Add(MapFechaBLToDA(f));
            }
            return lstFechas;
        }
    }
}
