using BusinnesLogic.clases;
using DataAccess.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLogic.Mapper
{
    public static class MapperProvCapBL
    {
        /// <summary>
        /// Mapea un listado tipo ProvCapBL a ProvCapDA
        /// </summary>
        /// <param name="pc"></param>
        /// <returns></returns>
        public static List<ProvCapBL> MapProvCapDAtoBL_tolist(List<ProvCapDA> pc)
        {
            List<ProvCapBL> lstProvCapBL = new List<ProvCapBL>();
            foreach (ProvCapDA item in pc)
            {
               lstProvCapBL.Add(MapProvCapDAtoBL(item));
            }

            return lstProvCapBL;
        }

        /// <summary>
        /// Mapea un objeto tipo ProvCapBL a ProvCapDA
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static ProvCapBL MapProvCapDAtoBL(ProvCapDA item)
        {
            ProvCapBL objProvCapBL = new ProvCapBL();
            objProvCapBL.IdProvCap = item.idProvCap;
            objProvCapBL.CapitalBL.IdCapitalBL = item.Capitales.idCapitalDA;
            objProvCapBL.CapitalBL.NombreCapitalBL = item.Capitales.NombreCapDA;
            objProvCapBL.ProvinciaBL.Id_ProvinciaBL = item.Provincias.IdProvinciaDA;
            objProvCapBL.ProvinciaBL.NombreProvinciaBL = item.Provincias.NombreProvDA;
            return objProvCapBL;
        }
    }
}
