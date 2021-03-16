using ACMEN.clases;
using BusinnesLogic.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEN.Mapper
{
    public static class MapperFechasBOEUI
    {
        public static FechasBOEUI MapFechaBLtoUI(FechasBOEBL fechaBL)
        {
            FechasBOEUI dt = new FechasBOEUI();
            dt.idCalendar = fechaBL.idCalendar;
            dt.fecha = fechaBL.fecha;
            return dt;
        }
        public static List<FechasBOEUI> MapFechaBLtoUI_tolist(List<FechasBOEBL> listado)
        {
            List<FechasBOEUI> lstFechasBOEUI = new List<FechasBOEUI>();
            foreach (FechasBOEBL f in listado)
            {
                lstFechasBOEUI.Add(MapFechaBLtoUI(f));
            }
            return lstFechasBOEUI;
        }

        public static FechasBOEBL MapFechaUItoBL(FechasBOEUI  fechaBL)
        {
            FechasBOEBL dt = new FechasBOEBL();
            dt.idCalendar = fechaBL.idCalendar;
            dt.fecha = fechaBL.fecha;
            return dt;
        }
        public static List<FechasBOEBL> MapFechaUItoBL_tolist(List<FechasBOEUI> listado)
        {
            List<FechasBOEBL> lstFechasBOEbl = new List<FechasBOEBL>();
            foreach (FechasBOEUI f in listado)
            {
                lstFechasBOEbl.Add(MapFechaUItoBL(f));
            }
            return lstFechasBOEbl;
        }
    }
}
