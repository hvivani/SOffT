using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sofft.ViewComunes;
using Sueldos.Entidades;

namespace Sueldos.View
{
    public partial class frmPeriodosTrabajados : Form
    {
        private PeriodoTrabajadoEntity periodo;

        public PeriodoTrabajadoEntity Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }

        public frmPeriodosTrabajados()
        {
            InitializeComponent();
            this.cargarCombos();
            /*this.dtpDesde.Value = System.DateTime.Now.Date;
            this.dtpHasta.Value = System.DateTime.Now.Date;
            this.dtpDesde.Checked = false;
            this.dtpHasta.Checked = false;
            this.cmbCausaEgreso.SelectedValue = 0;*/
        }


        public void cargarDatos()
        {
            Controles.seteaDTPicker(this.dtpDesde, this.periodo.FechaInicio, true);
            Controles.seteaDTPicker(this.dtpHasta, this.periodo.FechaFin, true);
            this.cmbCausaEgreso.SelectedValue = this.periodo.IdCausaEgreso;
            this.txtObservaciones.Text = this.periodo.Observaciones;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPeriodosTrabajados_Load(object sender, EventArgs e)
        {
            //lo pongo en el load porque puede que los valores no estén disponibles 
            //como para ponerlo en el constructor.
            this.cargarDatos();
        }

        private void cargarCombos()
        {
            Controles.cargaComboBox(this.cmbCausaEgreso, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 11);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //esto es para manejar las fechas nulas en la base de datos. hvivani. 20080213
            //nulo fecha. fecha nula. null
            //System.Data.SqlTypes.SqlDateTime fInicio = System.Data.SqlTypes.SqlDateTime.Null;
            //System.Data.SqlTypes.SqlDateTime fFin = System.Data.SqlTypes.SqlDateTime.Null;
            DateTime fInicio = new DateTime(0);
            DateTime fFin = new DateTime(0);
            if (this.dtpDesde.Checked)
                fInicio = this.dtpDesde.Value.Date;
            if (this.dtpHasta.Checked)
                fFin = this.dtpHasta.Value.Date;
            //periodo = new PeriodoTrabajado();
            this.periodo.FechaInicio = fInicio;//this.dtpDesde.Value.Date;
            this.periodo.FechaFin = fFin;//this.dtpHasta.Value.Date;
            this.periodo.IdCausaEgreso = Convert.ToInt32(this.cmbCausaEgreso.SelectedValue);
            this.periodo.CausaEgreso = this.cmbCausaEgreso.Text;
            this.periodo.Observaciones = this.txtObservaciones.Text;
            /*     DB.ejecutarSp("periodosTrabajadosInsertar", "@legajo", this.legajo,"@fechaInicio",fInicio   ,"@fechaFin",fFin   ,"@idCausaEgreso",Convert.ToInt32(this.cmbCausaEgreso.SelectedValue)  ,"@observaciones",this.txtObservaciones.Text );
                 this.cargarGrillas();*/
            this.Close();
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}