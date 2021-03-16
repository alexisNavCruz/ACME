using BusinnesLogic.clases;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLogic.Mapper
{
    public static class MapperEmpresaBL
    {
        /// <summary>
        /// Mapea una objeto tipo empresa DataAcces a empresa BusinnesLogic
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static EmpresaBL MapDAtoBL(Empresa item)
        {
            EmpresaBL objEmpresa = new EmpresaBL();
            objEmpresa.id = item.id;
            objEmpresa.Nombre = item.Nombre;
            objEmpresa.Desc = item.Desc;
            objEmpresa.idProvCap = item.idProvCap;
            objEmpresa.fecha = item.fecha;

            objEmpresa.ProvCap.ProvinciaBL.Id_ProvinciaBL = item.ProvinciaCapital.Provincias.IdProvinciaDA;
            objEmpresa.ProvCap.ProvinciaBL.NombreProvinciaBL = item.ProvinciaCapital.Provincias.NombreProvDA;
            objEmpresa.ProvCap.CapitalBL.NombreCapitalBL = item.ProvinciaCapital.Capitales.NombreCapDA;
            objEmpresa.ProvCap.CapitalBL.IdCapitalBL = item.ProvinciaCapital.Capitales.idCapitalDA;
            return objEmpresa;
        }

        /// <summary>
        /// Mapea una un listado tipo empresa DataAcces a empresa BusinnesLogic
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public static List<EmpresaBL> MapDAtoBL_Tolist(List<Empresa> emp)
        {
            List<EmpresaBL> lstEmpresa = new List<EmpresaBL>();
            foreach (Empresa item in emp)
            {
                lstEmpresa.Add(MapDAtoBL(item));
            }

            return lstEmpresa;
        }

        /// <summary>
        /// Mapea un listado tipo empresa BusinnesLogic a empresa DataAcces
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public static List<Empresa> MapEmpresaBLToEmpresaDA_Tolist(List<EmpresaBL> emp)
        {
            List<Empresa> lstEmpresa = new List<Empresa>();
            foreach (EmpresaBL item in emp)
            {
                lstEmpresa.Add(MapEmpresaBLToEmpresaDAsingle(item));
            }

            return lstEmpresa;
        }

        /// <summary>
        /// Mapea un objet tipo empresa BusinnesLogic a empresa DataAcces
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static Empresa MapEmpresaBLToEmpresaDAsingle(EmpresaBL item)
        {
            Empresa objEmpresa = new Empresa();
            objEmpresa.Nombre = item.Nombre;
            objEmpresa.Desc = item.Desc;
            objEmpresa.idProvCap = item.idProvCap;
            objEmpresa.fecha = item.fecha;
            objEmpresa.id = item.id;
            objEmpresa.idProvCap = item.idProvCap;

            return objEmpresa;
        }
    }
}
