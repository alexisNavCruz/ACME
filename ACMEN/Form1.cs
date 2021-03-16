
using ACMEN.clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using BusinnesLogic.clases;

namespace ACMEN
{
    public partial class Form1 : Form
    {
        #region Variables
        private BusinnesLogic.Metodos serv = null;
        Error.Error error = null;
        EmpresaUI empresa = new EmpresaUI();
        #endregion
        public Form1()
        {
            InitializeComponent();
            IncializarVariables();
            Limpiar();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarFechasBOE();
            CargarCombos();
        }
        private void CargarFechasBOE()
        {
            List<FechasBOEUI> lstFechas = new List<FechasBOEUI>();
            List<FechasBOEBL> lstBL = new List<FechasBOEBL>();
            if(serv.GetFechas(out lstBL,out error))
            {
               lstFechas = Mapper.MapperFechasBOEUI.MapFechaBLtoUI_tolist(lstBL);
                this.calendarDescarga.BoldedDates = lstFechas.Select(x => x.fecha).ToArray();
            }
            else
            {
                MessageBox.Show(error.mensaje);
            }
        }
        private void CargarCombos()
        {
            List<ProvCapUI> lst = Mapper.MapProvCapBLtoUI.GetMapProvCapBLtUIL(serv.GetProvCapBL());
            CargarCmbCapitales(lst);
            CargarCmbProvincias(lst);
            CargarCmbCapitlesBuscar(lst);
            CargarCmbProvinciasBuscar(lst);
        }
        private void CargarCmbCapitales(List<ProvCapUI> lst)
        {
            this.cmbCapitales.SelectedIndexChanged -= new EventHandler(cmbCapitales_SelectedIndexChanged);
            List<CapitalesUI> lstCapitalesUI = ObtenerListadoCapitales(lst);
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = lstCapitalesUI;
            cmbCapitales.DataSource = bindingSource1.DataSource;
            cmbCapitales.DisplayMember = "NombreCapital";
            cmbCapitales.ValueMember = "Id_cap";
            this.cmbCapitales.SelectedIndexChanged += new EventHandler(cmbCapitales_SelectedIndexChanged);
        }
        private void CargarCmbProvincias(List<ProvCapUI> lst)
        {
            this.cmbProinvincia.SelectedIndexChanged -= new EventHandler(cmbProinvincia_SelectedIndexChanged);
            List<ProvinciasUI> lstProvinciasUI = ObtenerListadoProvincias(lst);
            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = lstProvinciasUI;
            cmbProinvincia.DataSource = bindingSource2.DataSource;
            cmbProinvincia.DisplayMember = "NombreProv";
            this.cmbProinvincia.SelectedIndexChanged += new EventHandler(cmbProinvincia_SelectedIndexChanged);
            cmbProinvincia.ValueMember = "idProv";
        }
        private void CargarCmbCapitlesBuscar(List<ProvCapUI> lst)
        {
            this.cmbCapBuscar.SelectedIndexChanged -= new EventHandler(cmbCapBuscar_SelectedIndexChanged);
            List<CapitalesUI> lstCapitalesUI = ObtenerListadoCapitales(lst);
            var bindingSource3 = new BindingSource();
            bindingSource3.DataSource = lstCapitalesUI;
            cmbCapBuscar.DataSource = bindingSource3.DataSource;
            cmbCapBuscar.DisplayMember = "NombreCapital";
            cmbCapBuscar.ValueMember = "Id_cap";
            this.cmbCapBuscar.SelectedIndexChanged += new EventHandler(cmbCapBuscar_SelectedIndexChanged);
        }
        private void CargarCmbProvinciasBuscar(List<ProvCapUI> lst)
        {
            this.cmbProvBuscar.SelectedIndexChanged -= new EventHandler(cmbProvBuscar_SelectedIndexChanged);
            List<ProvinciasUI> lstProvinciasUI = ObtenerListadoProvincias(lst);
            var bindingSource4 = new BindingSource();
            bindingSource4.DataSource = lstProvinciasUI;
            cmbProvBuscar.DataSource = bindingSource4.DataSource;
            cmbProvBuscar.DisplayMember = "NombreProv";
            cmbProvBuscar.ValueMember = "idProv";
            this.cmbProvBuscar.SelectedIndexChanged += new EventHandler(cmbProvBuscar_SelectedIndexChanged);
        }

       
        private List<ProvinciasUI> ObtenerListadoProvincias(List<ProvCapUI> lst)
        {
            List<ProvinciasUI> lstProvinciasUI = new List<ProvinciasUI>();
            foreach (ProvCapUI obj in lst)
            {
                ProvinciasUI prov = new ProvinciasUI();
                prov.idProv = obj.Provincia.idProv;
                prov.NombreProv = obj.Provincia.NombreProv;
                lstProvinciasUI.Add(prov);
            }
            return lstProvinciasUI;
        }
        private List<CapitalesUI> ObtenerListadoCapitales(List<ProvCapUI> lst)
        {
            List<CapitalesUI> lstCapitalesUI = new List<CapitalesUI>();
            foreach (ProvCapUI obj in lst)
            {
                CapitalesUI cap = new CapitalesUI();
                cap.Id_cap = obj.Capital.Id_cap;
                cap.NombreCapital = obj.Capital.NombreCapital;
                lstCapitalesUI.Add(cap);
            }
            return lstCapitalesUI;
        }
        private void IncializarVariables()
        {
            serv = new BusinnesLogic.Metodos();
            lblmensajetab1.Text = string.Empty;
            error = new Error.Error();
        }

        private void cmbProvBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCapBuscar.SelectedValue = cmbProvBuscar.SelectedValue;
            Limpiar();
            cmbCapBuscar.Enabled = false;
            dateTimePickerBuscar.Enabled = false;
        }

        private void cmbProinvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCapitales.SelectedValue = cmbProinvincia.SelectedValue !=null? cmbProinvincia.SelectedValue:0;

        }
        private void cmbCapitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProinvincia.SelectedValue = cmbCapitales.SelectedValue;
        }
        private void cmbCapBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProvBuscar.SelectedValue = cmbCapBuscar.SelectedValue;
            Limpiar();
            cmbProvBuscar.Enabled = false;
            dateTimePickerBuscar.Enabled = false;
        }

        private void gvEmpresas_DoubleClick(object sender, EventArgs e)
        {

            if (gvEmpresas.CurrentRow.Index != -1)
            {
                empresa.id = Convert.ToInt32(gvEmpresas.CurrentRow.Cells["id"].Value);
                empresa = Mapper.MapperEmpresaUI.MapEmpBLtoEmpUI(serv.getEmpresaBL(empresa.id));
                txtEmpTab2.Text = empresa.Nombre;
                txtDescTab2.Text = empresa.Desc;

            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            empresa.Nombre = txtEmpTab2.Text.Trim();
            empresa.Desc = txtDescTab2.Text.Trim();
            if (serv.UpdateEmpresa(Mapper.MapperEmpresaUI.MapEmpUItoEmpBL(empresa), out error))
            {
                MessageBox.Show(error.mensaje);
                BuscarEmpresa();
            }
            
        }
        public void BuscarEmpresa()
        {
            string fecha = string.Empty;            
            int id=-1;
            if (!dateTimePickerBuscar.Enabled)
            {
                id= cmbCapBuscar.Enabled==false? (int)cmbProvBuscar.SelectedValue: (int)cmbCapBuscar.SelectedValue;
            }
            else
            {
                fecha = dateTimePickerBuscar.Value.ToString("yyyy-MM-dd");
            }
            
            List<EmpresaBL> lstEmpresaBL = new List<EmpresaBL>();
            if (serv.GetEmpresas(fecha, id, out lstEmpresaBL, out error))
            {
                gvEmpresas.DataSource = Mapper.MapperEmpresaUI.MapEntityToEmpresa(lstEmpresaBL);
                gvEmpresas.Columns[2].Width = 150;
                gvEmpresas.Columns[3].Width = 300;
                //gvEmpresas.Columns["ProvCap"].DataPropertyName = Mapper.MapperEmpresaUI.MapEntityToEmpresa(lstEmpresaBL).Select(x => x.ProvCap.Capital.NombreCapital).FirstOrDefault();
            }
            else
            {
                MessageBox.Show(error.mensaje);
            }

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarEmpresa();
        }
        private void dateTimePickerBuscar_ValueChanged(object sender, EventArgs e)
        {
            BloquearCampos();

        }
        private void BloquearCampos()
        {
            cmbProvBuscar.Enabled = false;
            cmbCapBuscar.Enabled = false;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            cmbProvBuscar.Enabled = true;
            cmbCapBuscar.Enabled = true;
            dateTimePickerBuscar.Enabled = true;
        }
        private void btnMarcarDescargaBOE_Click(object sender, EventArgs e)
        {
            DateTime dt = calendarDescarga.SelectionRange.Start;
            FechasBOEUI fecha = new FechasBOEUI();
            fecha.fecha = dt;
            if (serv.saveFecha(Mapper.MapperFechasBOEUI.MapFechaUItoBL(fecha), out error))
            {
                CargarFechasBOE();
            }

            MessageBox.Show(error.mensaje);
        }
        private void btnAdNuevaEmpresa_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            List<EmpresaUI> lst = new List<EmpresaUI>();
            EmpresaUI emp = new EmpresaUI();
            emp.Nombre = txtNombreEmpresa.Text.ToString();
            emp.Desc = txtDescEmpresa.Text.ToString();
            emp.fecha = DateTime.Now.ToString("yyyy-MM-dd");
            emp.idProvCap = (int)cmbCapitales.SelectedValue;
            lst.Add(emp);
            if (serv.SaveEmpresa(Mapper.MapperEmpresaUI.MapEmpresaUIToEmpresaBL(lst), out error))
            {

            }
            MessageBox.Show(error.mensaje);
        }
    }
}
