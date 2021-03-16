using BusinnesLogic.clases;
using DataAccess;
using DataAccess.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLogic
{
    public  class Metodos
    {
        public bool GetEmpresas(string fecha,int id,out List<EmpresaBL> lstEmpresaBL,out Error.Error err)
        {
            DataAccess.Interface.ObtenerDatosEmpresa objEmpresa = new DataAccess.Interface.ObtenerDatosEmpresa();
            List<Empresa> lstEmpresa = new List<Empresa>();
            bool resul = objEmpresa.Get(fecha, id, out lstEmpresa, out err);
            lstEmpresaBL = Mapper.MapperEmpresaBL.MapDAtoBL_Tolist(lstEmpresa);

            return resul;
        }

        public List<ProvCapBL> GetProvCapBL()
        {
            List<ProvCapBL> lstProvCapBL = new List<ProvCapBL>();
            DataAccess.Interface.ObtenerProvCapDA objProvCapDA = new DataAccess.Interface.ObtenerProvCapDA();
            lstProvCapBL = Mapper.MapperProvCapBL.MapProvCapDAtoBL_tolist(objProvCapDA.Get_provinciaCapital());

            return lstProvCapBL;
        }

        public bool SaveEmpresa(List<EmpresaBL> lst,out Error.Error err)
        {
            List<Empresa> lstEmpresaDA = new List<Empresa>();
            DataAccess.Interface.ObtenerDatosEmpresa objEmpresa = new DataAccess.Interface.ObtenerDatosEmpresa();
            lstEmpresaDA = Mapper.MapperEmpresaBL.MapEmpresaBLToEmpresaDA_Tolist(lst);
            return objEmpresa.Save(lstEmpresaDA,out err);

        }

        public EmpresaBL getEmpresaBL(int id)
        {
            DataAccess.Interface.ObtenerDatosEmpresa objEmpresa = new DataAccess.Interface.ObtenerDatosEmpresa();
            return Mapper.MapperEmpresaBL.MapDAtoBL(objEmpresa.GetOne(id));
                    
        }

        public bool UpdateEmpresa(EmpresaBL emp, out Error.Error err)
        {
           DataAccess.Interface.ObtenerDatosEmpresa objEmpresa = new DataAccess.Interface.ObtenerDatosEmpresa();
            Empresa empresaDA = Mapper.MapperEmpresaBL.MapEmpresaBLToEmpresaDAsingle(emp);
            return objEmpresa.Update(empresaDA,out err);
        }

        public bool GetFechas(out List<FechasBOEBL> lstFechas,out Error.Error err)
        {
            List<FechasBOE> lst = new List<FechasBOE>();
            DataAccess.Interface.DescargaBOE objFechasBOE = new DataAccess.Interface.DescargaBOE();
            bool result = objFechasBOE.GetListadoFechas(out lst, out err);
            lstFechas = Mapper.MapperFechasBOEBLcs.MapFechaDAToBL_tolist(lst);

            return result;
        }

        public bool saveFecha(FechasBOEBL fecha,out Error.Error err)
        {
            DataAccess.Interface.DescargaBOE objFechasBOE = new DataAccess.Interface.DescargaBOE();
           return objFechasBOE.save(Mapper.MapperFechasBOEBLcs.MapFechaBLToDA(fecha),out err);
            

        }
    }
}
