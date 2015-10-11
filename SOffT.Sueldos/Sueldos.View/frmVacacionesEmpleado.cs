using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using Sofft.Utils;
using Sofft.ViewComunes;
using Sueldos.Entidades;

namespace Sueldos.View
{
    public partial class frmVacacionesEmpleado : Form
    {
        private bool ok;

        public bool Ok
        {
            get { return ok; }
            set { ok = value; }
        }
        private bool asistencia = false;
        private VacacionEntity vacacion;
        
        private int anioMes;
        

        public frmVacacionesEmpleado()
        {
            InitializeComponent();
        }

        public bool abrirParaCargar(string anio, string mes, string aTomar, int legajo, DateTime fDesde, int codigo)
        {
            this.vacacion = new VacacionEntity();
            this.asistencia = true;
            
            this.vacacion.Legajo = legajo;
            this.vacacion.Codigo = codigo;
            this.vacacion.AnioVacaciones = Convert.ToInt32(anio);
            this.vacacion.Fecha = fDesde;

            this.txtDiasATomar.Text = aTomar;
            this.dtpFechaOtorgada.Value = vacacion.Fecha;
            this.dtpFechaOtorgada.Enabled = false;
            this.txtAnioVacaciones.Text = Model.DB.ejecutarScalar(Model.TipoComando.SP, "vacacionesCalculaAnio", "legajo", legajo).ToString();
            this.txtDiasALiquidar.Text = Model.DB.ejecutarScalar(Model.TipoComando.SP, "vacacionesCalculaDias", "legajo", legajo, "anioVac", this.txtAnioVacaciones.Text).ToString();
            this.cargarCombos();
      //      DB.cargaComboBox(this.cmbTipoLiquidacion, "descripcion", "indice", "tablasConsultarCalculoConvenio", "@idConvenio", DB.ejecutarSpScalarStr("empleadosSueldosConsultarValorLegajo", "@legajo", this.legajo , "@codigo", 13));
            this.ShowDialog();
            return ok;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        { //al grabar novedades a liquidar hay que poner el indice del legajo del empleado
            this.vacacion.Fecha = dtpFechaOtorgada.Value.Date;
            this.vacacion.DiasTomados = Convert.ToInt32(txtDiasATomar.Text);
            this.vacacion.AnioVacaciones = Convert.ToInt32(txtAnioVacaciones.Text);
            this.vacacion.TotalDias = Convert.ToInt32(txtDiasVacaciones.Text);
            if (asistencia)
            {
                if (Varios.IsNumeric(this.txtDiasATomar.Text) && Convert.ToInt32(this.txtDiasATomar.Text) > 0)
                    Model.DB.ejecutarProceso(Model.TipoComando.SP, "vacacionesActualizar", "@legajo", this.vacacion.Legajo, "@fecha", this.vacacion.Fecha, "@codigo", this.vacacion.Codigo, "@diasTomados", this.txtDiasATomar.Text, "@anioVacaciones", this.txtAnioVacaciones.Text, "@totalDias", this.txtDiasVacaciones.Text);
                if (Varios.IsNumeric(this.txtDiasALiquidar.Text) && Convert.ToInt32(this.txtDiasALiquidar.Text) > 0)
                    Model.DB.ejecutarProceso(Model.TipoComando.SP, "novedadesActualizar", "@idLiquidacion", this.cmbLiquidacion.SelectedValue, "@legajo", this.vacacion.Legajo, "@codigo", 45, "@valor", this.txtDiasALiquidar.Text);
            }
            ok = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ok = false;
            this.Close();
        }

        private void txtAnioVacaciones_TextChanged(object sender, EventArgs e)
        {
            if (Varios.IsNumeric(this.txtAnioVacaciones.Text) && Convert.ToInt32(this.txtAnioVacaciones.Text) > 1950)
            {
                this.txtDiasVacaciones.Text = Model.DB.ejecutarScalar(Model.TipoComando.SP, "vacacionesCalculaDias", "legajo", this.vacacion.Legajo, "anioVac", this.txtAnioVacaciones.Text).ToString();
                this.txtDiasALiquidar.Text = this.txtDiasVacaciones.Text;
            }
            else
            {
                this.txtDiasVacaciones.Text = "";
                this.txtDiasALiquidar.Text = "0";
            }
        }

        private void cargarCombos()
        {
            txtDiasALiquidar.Enabled = asistencia;
            this.gbLiquidacion.Enabled = asistencia;
            Controles.cargaComboBox(this.cmbLiquidacion, "descripcion", "id", "liquidacionesDetalleConsultarParaRecibos", "@estado", 0);
        }

        private void cmbLiquidacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP,"liquidacionesDetalleConsultar", "@id", this.cmbLiquidacion.SelectedValue);
            if (rs.Read())
                this.anioMes = Convert.ToInt32(rs["anioMes"]);
            Model.DB.desconectarDB();
        }

        public void abrirParaNuevo(ref VacacionEntity vacacion)
        {
            this.vacacion = vacacion;
            this.dtpFechaOtorgada.Value = DateTime.Now.Date;
            this.txtAnioVacaciones.Text = Model.DB.ejecutarScalar(Model.TipoComando.SP, "vacacionesCalculaAnio", "legajo", this.vacacion.Legajo).ToString();
            this.txtDiasALiquidar.Text = Model.DB.ejecutarScalar(Model.TipoComando.SP, "vacacionesCalculaDias", "legajo", this.vacacion.Legajo, "anioVac", this.txtAnioVacaciones.Text).ToString();
            this.cargarCombos();
            this.ShowDialog();
        }

        public void abrirParaModificar(ref VacacionEntity vacacion)
        {
            this.vacacion = vacacion;
            this.dtpFechaOtorgada.Value = vacacion.Fecha;
            this.txtDiasATomar.Text = vacacion.DiasTomados.ToString();
            this.txtDiasVacaciones.Text = vacacion.TotalDias.ToString();
            this.txtAnioVacaciones.Text = vacacion.AnioVacaciones.ToString();
            this.cargarCombos();
            this.ShowDialog();
        }

        private void txtDiasALiquidar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}