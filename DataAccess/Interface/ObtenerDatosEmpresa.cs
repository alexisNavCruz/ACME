using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public class ObtenerDatosEmpresa : IObtenerDatosEmpresa
    {
        public Empresa Delete()
        {
            throw new NotImplementedException();
        }

        public bool Get(string fecha, int id, out List<Empresa> lstEmpresa, out Error.Error err)
        {
            Error.Error error = new Error.Error();
            List<Empresa> lst = new List<Empresa>();
            try
            {
                using (DataAccess.ACMEEntities db = new ACMEEntities())
                {
                    if (fecha.Equals(string.Empty))
                    {
                        lst = Mapper.MapperEmpresa.MapEntityToEmpresa_tolist(db.Empresas.Where(x => x.id_ProvCap == id).ToList());
                    }
                    else
                    {
                        lst = Mapper.MapperEmpresa.MapEntityToEmpresa_tolist(db.Empresas.Where(x => x.FechaAltaEmpresa == fecha).ToList());
                    }
                    }
                error.ok = true;
                error.mensaje = "Exito al obtener empresas";
            }
            catch (Exception e)
            {
                error.ok = false;
                error.mensaje = "error al obtener datos" + e.Message;
            }
            err = error;
            lstEmpresa = lst;
            return error.ok;
        }

        public Empresa GetOne(int id)
        {
            using (DataAccess.ACMEEntities db = new ACMEEntities())
            {

                Empresas empEntity = db.Empresas.ToList().Where(x => x.id_Empresa == id).FirstOrDefault();
                Empresa empDA = new Empresa();
                empDA.Nombre = empEntity.Nombre;
                empDA.Desc = empEntity.Descripcion;
                empDA.id = empEntity.id_Empresa;
                empDA.idProvCap = empEntity.id_ProvCap;
                empDA.fecha = empEntity.FechaAltaEmpresa;
                return empDA;
            }
        }

        public bool Save(List<Empresa> lst, out Error.Error err)
        {
            Error.Error error = new Error.Error();
            try
            {
                using (DataAccess.ACMEEntities db = new ACMEEntities())
                {
                    List<Empresas> em = Mapper.MapperEmpresa.MapEmpresaToEntity_tolist(lst);
                    db.Empresas.Add(em[0]);
                    db.SaveChanges();
                }
                error.mensaje = "Empresa añadida con exito";
                error.ok = true;
            }
            catch (Exception e)
            {
                error.ok = false;
                error.mensaje = "Error al añadir empresa"+e.Message;
             
            }
            err = error;
            return error.ok;
        }

        public bool Update(Empresa emp, out Error.Error err)
        {
            Error.Error error = new Error.Error();
            try
            {
                using (DataAccess.ACMEEntities db = new ACMEEntities())
                {
                    Empresas objEmpresa = Mapper.MapperEmpresa.MapSingleEmpresaToEntity(emp);
                    db.Entry(objEmpresa).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                error.mensaje = "Edición realizada con exito.";
                error.ok = true;
            }
            catch (Exception e)
            {
                error.ok = false;
                error.mensaje = "error al editar empresa " + e.Message;
            }
            err = error;
            return err.ok;
        }
    }
}
