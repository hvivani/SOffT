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
using Sueldos.Modelo;
using Sueldos.Entidades;

namespace Sueldos.View
{
    public partial class frmCargaMasivaNovedades : Form
    {
        private int anioMes;
        private ConsultaTablas consutab = new ConsultaTablas();

        public frmCargaMasivaNovedades()
        {
            InitializeComponent();
        }

        private void CargaMasivaNovedades_Load(object sender, EventArgs e)
        {

        }
        
        public void abrir()
        {
            this.cargaCombos();
            this.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargaCombos()
        {
            Controles.cargaComboBox(this.cmbLiquidacion, "descripcion", "id", "liquidacionesDetalleConsultarParaLiquidar");
            Controles.cargaComboBox(this.cmbConvenio, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 13);
            Controles.cargaComboBox(this.cmbTipoLiquidacion, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 41);
            //Controles.cargaComboBox(this.cmbNovedad, "descripcion", "indice", "tablasConsultarCodigosNovedades");
            Controles.cargaComboBox(this.cmbNovedad, "descripcion", "indice", consutab.getByNombre("novedades", "descripcion"));
        }

        private void cmbLiquidacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP,"liquidacionesDetalleConsultar", "@id", this.cmbLiquidacion.SelectedValue);
            if (rs.Read())
                this.anioMes = Convert.ToInt32(rs["anioMes"]);
            Model.DB.desconectarDB();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Varios.IsNumeric(this.txtValor.Text))
            {
                int cant = 0;
                DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP,"empleadosConsultarParaCargaMasiva", "@idConvenio", this.cmbConvenio.SelectedValue, "@idTipoLiquidacion", this.cmbTipoLiquidacion.SelectedValue);
                while (rs.Read())
                {
                    Model.DB.ejecutarProceso(Model.TipoComando.SP, "novedadesActualizar", "@idLiquidacion", this.cmbLiquidacion.SelectedValue, "@legajo", Convert.ToInt32(rs["legajo"]), "@codigo", this.cmbNovedad.SelectedValue, "@valor", Convert.ToDouble(this.txtValor.Text));
                    cant++;
                }
                MessageBox.Show("Se actualizaron " + cant + " legajos.");
                this.btnGrabar.Enabled = false;
            }
            else
            {
                MessageBox.Show("El valor debe ser numérico !!");
                this.txtValor.Focus();
            }
        }
    }
}