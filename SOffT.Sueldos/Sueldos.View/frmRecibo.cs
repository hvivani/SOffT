using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sofft.Utils;
using Sofft.ViewComunes;

namespace Sueldos.View
{
    public partial class frmRecibo : Form
    {
        /// <summary>
        /// Abre el formulario de Recibos para consultar
        /// </summary>
        public void abrirParaConsultar()
        {
            this.panelEdicion.Visible = false;
            this.Text = "Consulta de Recibos";
            this.ShowDialog();
        }

        /// <summary>
        /// Abre el fomulario de Recibos para modificar
        /// </summary>
        /// 
        public void abrirParaModificar()
        {
            this.panelEdicion.Visible = true;
            this.Text = "Modificación de Recibos";
            this.ShowDialog();
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public frmRecibo()
        {
            InitializeComponent();
            this.txtLegajo.GotFocus += new EventHandler(txtLegajo_GotFocus);
            this.txtLegajo.KeyDown += new KeyEventHandler(txtLegajo_KeyDown);

            this.carcarCombos();
            this.txtLegajo.Focus();
        }

        void txtLegajo_GotFocus(object sender, EventArgs e)
        {            this.txtLegajo.SelectAll();        }

        /// <summary>
        /// Constructor con idLiquidacion para abrir directamente con 
        /// dicho id.
        /// </summary>
        /// <param name="idLiquidacion"></param>
        public frmRecibo(int idLiquidacion)
        {
            InitializeComponent();
            this.txtLegajo.KeyDown += new KeyEventHandler(txtLegajo_KeyDown);

            this.carcarCombos();
            this.txtLegajo.Focus();
            this.cmbLiquidacion.SelectedValue = idLiquidacion;
        }

        /// <summary>
        /// Constructor con idLiquidacion y legajo para abrir directamente con 
        /// dicho id y legajo.
        /// </summary>
        /// <param name="idLiquidacion"></param>
        /// <param name="legajo"></param>
        public frmRecibo(int idLiquidacion, int legajo)
        {
            InitializeComponent();
            this.txtLegajo.KeyDown += new KeyEventHandler(txtLegajo_KeyDown);

            this.carcarCombos();
            this.txtLegajo.Focus();
            this.cmbLiquidacion.SelectedValue = idLiquidacion;
            this.cmbEmpleados.SelectedValue = legajo;
            this.btnConsultar_Click(null, null);
        }

        void txtLegajo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnConsultar_Click(sender, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {            this.Close();        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbEmpleados.SelectedValue != null)
                this.txtLegajo.Text = this.cmbEmpleados.SelectedValue.ToString();
        }

        private void txtLegajo_TextChanged(object sender, EventArgs e)
        {
            if (Varios.IsNumeric(this.txtLegajo.Text))
                this.cmbEmpleados.SelectedValue = this.txtLegajo.Text;
        }

        private void carcarCombos()
        {
            Controles.cargaComboBox(this.cmbEmpleados, "Apellido y Nombres", "legajo", "empleadosConsultarParaComboTodos");
            Controles.cargaComboBox(this.cmbLiquidacion, "descripcion", "id", "liquidacionesDetalleConsultarParaRecibos", "@estado", 0);
            Controles.cargaComboBox(this.cmbEstadoLiquidacion, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "LiquidacionesDetalle", "indice", 0);
            Controles.cargaComboBox(this.cmbTipoLiquidacion, "descripcion", "indice", "tablasConsultarTiposDeLiquidacion");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (this.cmbLiquidacion.SelectedValue != null)
            {
                Controles.cargaDataGridView(this.dgvRecibo, "liquidacionesConsultarParaRecibo", "legajo", this.txtLegajo.Text, "@idLiquidacion", this.cmbLiquidacion.SelectedValue, "@idTipoLiquidacion", this.cmbTipoLiquidacion.SelectedValue);
                Controles.setEstandarDataGridView(this.dgvRecibo);
            }
        }

        private void cmbEstadoLiquidacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controles.cargaComboBox(this.cmbLiquidacion, "descripcion", "id", "liquidacionesDetalleConsultarParaRecibos", "@estado", this.cmbEstadoLiquidacion.SelectedValue);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(this.dgvRecibo.SelectedRows[0].Cells["Codigo"].Value.ToString());
            if (codigo < 999998)
            {
                frmRenglonRecibo renglon = new frmRenglonRecibo();
                renglon.Modificar(
                    Convert.ToInt32(this.cmbLiquidacion.SelectedValue),
                    Convert.ToInt32(this.cmbTipoLiquidacion.SelectedValue),
                    Convert.ToInt32(this.txtLegajo.Text),
                    codigo
                );
                btnConsultar_Click(sender, e);
            }
        }

        private void gbDatosLiquidacion_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro de eliminar la liquidación completa del legajo " + this.txtLegajo.Text + " ?", "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Model.DB.ejecutarProceso(Model.TipoComando.SP, "liquidacionesEliminar", "idLiquidacion", this.cmbLiquidacion.SelectedValue, "@legajo", this.txtLegajo.Text );
                MessageBox.Show("Se eliminó la liquidación del legajo " + this.txtLegajo.Text);
            }       
        }

        private void cmbTipoLiquidacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnConsultar_Click(sender, e);
        }
    }
}