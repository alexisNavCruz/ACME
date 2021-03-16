using ACMEN.clases;
using BusinnesLogic.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEN.Mapper
{
    public static class MapProvCapBLtoUI
    {
        public static List<ProvCapUI> GetMapProvCapBLtUIL(List<ProvCapBL> pc)
        {
            List<ProvCapUI> lstProvCapUI = new List<ProvCapUI>();
            foreach (ProvCapBL item in pc)
            {
                ProvCapUI objProvCapUI = new ProvCapUI();
                objProvCapUI.idProvCap = item.IdProvCap;
                objProvCapUI.Capital.Id_cap = item.CapitalBL.IdCapitalBL;
                objProvCapUI.Capital.NombreCapital = item.CapitalBL.NombreCapitalBL;
                objProvCapUI.Provincia.idProv = item.ProvinciaBL.Id_ProvinciaBL;
                objProvCapUI.Provincia.NombreProv = item.ProvinciaBL.NombreProvinciaBL;
                lstProvCapUI.Add(objProvCapUI);
            }

            return lstProvCapUI;
        }
    }
}
