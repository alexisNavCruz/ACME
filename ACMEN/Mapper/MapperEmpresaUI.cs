using ACMEN.clases;
using BusinnesLogic.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEN.Mapper
{
    public static class MapperEmpresaUI
    {
        public static EmpresaBL MapEmpUItoEmpBL(EmpresaUI item)
        {

            EmpresaBL objEmpresa = new EmpresaBL();
            objEmpresa.id = item.id;
            objEmpresa.Nombre = item.Nombre;
            objEmpresa.Desc = item.Desc;
            objEmpresa.idProvCap = item.idProvCap;
            objEmpresa.fecha = item.fecha;

            return objEmpresa;
        }
        public static EmpresaUI MapEmpBLtoEmpUI(EmpresaBL item)
        {

            EmpresaUI objEmpresa = new EmpresaUI();
            objEmpresa.id = item.id;
            objEmpresa.Nombre = item.Nombre;
            objEmpresa.Desc = item.Desc;
            objEmpresa.idProvCap = item.idProvCap;
            objEmpresa.fecha = item.fecha;

            objEmpresa.ProvCap.Provincia.idProv = item.ProvCap.ProvinciaBL.Id_ProvinciaBL;
            objEmpresa.ProvCap.Provincia.NombreProv = item.ProvCap.ProvinciaBL.NombreProvinciaBL;
            objEmpresa.ProvCap.Capital.Id_cap = item.ProvCap.CapitalBL.IdCapitalBL;
            objEmpresa.ProvCap.Capital.NombreCapital= item.ProvCap.CapitalBL.NombreCapitalBL;

            return objEmpresa;
        }

        public static List<EmpresaUI> MapEntityToEmpresa(List<EmpresaBL> emp)
        {
            List<EmpresaUI> lstEmpresa = new List<EmpresaUI>();
            foreach (EmpresaBL item in emp)
            {
                EmpresaUI objEmpresa = new EmpresaUI();
                objEmpresa.id = item.id;
                objEmpresa.Nombre = item.Nombre;
                objEmpresa.Desc = item.Desc;
                objEmpresa.idProvCap = item.idProvCap;
                objEmpresa.fecha = item.fecha;
                lstEmpresa.Add(objEmpresa);
            }

            return lstEmpresa;
        }

        public static List<EmpresaBL> MapEmpresaUIToEmpresaBL(List<EmpresaUI> emp)
        {
            List<EmpresaBL> lstEmpresa = new List<EmpresaBL>();
            foreach (EmpresaUI item in emp)
            {
                EmpresaBL objEmpresa = new EmpresaBL();

                objEmpresa.Nombre = item.Nombre;
                objEmpresa.Desc = item.Desc;
                objEmpresa.idProvCap = item.idProvCap;
                objEmpresa.fecha = item.fecha;
                lstEmpresa.Add(objEmpresa);
            }

            return lstEmpresa;
        }




    }
}

