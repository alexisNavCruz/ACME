using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public static class MapperEmpresa
    {
        public static List<Empresa> MapEntityToEmpresa_tolist(List<Empresas> emp)
        {
            List<Empresa> lstEmpresa = new List<Empresa>();
            foreach(Empresas item in emp)
            {
               lstEmpresa.Add(MapEntityToEmpresa(item));
            }

            return lstEmpresa;
        }
        public static Empresa MapEntityToEmpresa(Empresas item)
        {
            Empresa objEmpresa = new Empresa();

                objEmpresa.id = item.id_Empresa;
                objEmpresa.Nombre = item.Nombre;
                objEmpresa.Desc = item.Descripcion;
                objEmpresa.idProvCap = item.id_ProvCap;
                objEmpresa.fecha = item.FechaAltaEmpresa;

                objEmpresa.ProvinciaCapital.Capitales.idCapitalDA = item.ProvCap.Capitales.id_capital;
                objEmpresa.ProvinciaCapital.Capitales.NombreCapDA = item.ProvCap.Capitales.NombreCapital;
                objEmpresa.ProvinciaCapital.Provincias.IdProvinciaDA = item.ProvCap.Provincias.id_Provincia;
                objEmpresa.ProvinciaCapital.Provincias.NombreProvDA = item.ProvCap.Provincias.NombreProvincia;

           return objEmpresa;
        }

        public static List<Empresas> MapEmpresaToEntity_tolist(List<Empresa> emp)
        {
            List<Empresas> lstEmpresa = new List<Empresas>();
            foreach (Empresa item in emp)
            {
                Empresas objEmpresa = new Empresas();
                objEmpresa.Nombre = item.Nombre;
                objEmpresa.Descripcion = item.Desc;
                objEmpresa.id_ProvCap = item.idProvCap;
                objEmpresa.FechaAltaEmpresa = item.fecha;
                lstEmpresa.Add(objEmpresa);
            }

            return lstEmpresa;
        }

        public static Empresas MapSingleEmpresaToEntity(Empresa item)
        {
            Empresas objEmpresa = new Empresas();

            objEmpresa.Nombre = item.Nombre;
            objEmpresa.Descripcion = item.Desc;
            objEmpresa.id_ProvCap = item.idProvCap;
            objEmpresa.FechaAltaEmpresa = item.fecha;
            objEmpresa.id_Empresa = item.id;

            return objEmpresa;

        }
    }
}
