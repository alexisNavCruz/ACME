using DataAccess.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public static class MapperProvinciaCapital
    {
        public static List<ProvCapDA> MapEntityToProvCapDA(List<ProvCap> provCap)
        {
            List<ProvCapDA> lstProvCap = new List<ProvCapDA>();
            foreach (ProvCap item in provCap)
            {
                ProvCapDA objProvCapDA = new ProvCapDA();
                objProvCapDA.idProvCap = item.id;
                objProvCapDA.Provincias.IdProvinciaDA = item.Provincias.id_Provincia;
                objProvCapDA.Provincias.NombreProvDA = item.Provincias.NombreProvincia;
                objProvCapDA.Capitales.idCapitalDA = item.Capitales.id_capital;
                objProvCapDA.Capitales.NombreCapDA = item.Capitales.NombreCapital;
                lstProvCap.Add(objProvCapDA);

            }

            return lstProvCap;
        }
    }
}
