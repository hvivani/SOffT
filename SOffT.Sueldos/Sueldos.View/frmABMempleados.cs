using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sofft.ViewComunes;

namespace Sueldos.View
{
    public partial class frmABMempleados : Sofft.ViewComunes.frmABM 
    {
        public frmABMempleados()
        {
            InitializeComponent();

            this.creaBotones();
            this.Text = "ABM de Empleados";
            this.cargaGrilla("EmpleadosConsultarParaGrilla");
            //this.actualizarGrilla(this,null);
            this.creaBusquedas(1, 2);

            ComboBox cbEstado = new ComboBox();
            Controles.cargaComboBox(cbEstado, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 10);
            ComboBox cbConvenio = new ComboBox();
            Controles.cargaComboBox(cbConvenio, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 13);
            ComboBox cbContrato = new ComboBox();
            Controles.cargaComboBox(cbContrato, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 12);

            this.creaFiltros(cbEstado, cbConvenio, cbContrato);
            this.nombrarFiltros(3, 4, 5);

            //this.aplicaPermisos(1);

            //this.aplicarFiltros();
            //base.abrir();
            //this.ShowDialog();
        }


        private void frmABMempleados_Load(object sender, EventArgs e)
        {
            //this.aplicarFiltros(sender,e );
            this.btnTodos_Click(sender, e);
            this.lblEmpleadosNomina.Text = Convert.ToString(Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosConsultarEnNomina"));
        }

        protected override void Consultar()
        {
            frmDatosEmpleado frmDE = new frmDatosEmpleado();
            frmDE.abrirParaConsultar(Convert.ToInt32(this.consultaCampoRenglon(0)));

        }

        protected override void Modificar(object sender, EventArgs e)
        {
            frmDatosEmpleado frmDE = new frmDatosEmpleado();
            frmDE.abrirParaModificar(Convert.ToInt32(this.consultaCampoRenglon(0)));
            this.actualizarGrilla(sender, e);
        }

        protected override void Nuevo(object sender, EventArgs e)
        {
            frmDatosEmpleado frmDE = new frmDatosEmpleado();
            frmDE.abrirParaNuevo();
            this.actualizarGrilla(sender, e);
        }

        protected override void Eliminar(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro de eliminar el empleado \n" + this.consultaCampoRenglon(2) + " ?", "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Model.DB.ejecutarProceso(Model.TipoComando.SP, "empleadosEliminar", "@legajo", this.consultaCampoRenglon(1));
                MessageBox.Show("el empleado se elimino con éxito");
                this.actualizarGrilla(sender, e);
            }

        }

        private void actualizarGrilla(object sender, EventArgs e)
        {
            this.cargaGrilla("EmpleadosConsultarParaGrilla");
            this.aplicarFiltros(sender, e);
            this.lblEmpleadosNomina.Text = Convert.ToString(Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosConsultarEnNomina"));
        }

        protected override void Listar()
        {
           /* Sueldos.View.Reportes.CRListaDeEmpleados lista = new Sueldos.View.Reportes.CRListaDeEmpleados();
            lista.SetDataSource(this.Lista);
            frmReportes visor = new frmReportes(lista);
            visor.ShowDialog(this);*/

            DataTable dt=this.Lista;
            Sueldos.Reportes.CrystalReport.ReportesCreador.ListaEmpleados(dt);

        }
    }
}

