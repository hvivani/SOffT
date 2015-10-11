using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sofft.ViewComunes;

namespace Sueldos.View.Dialogos
{
    public partial class frmSeleccionCampoEmpleado : Form
    {
        public frmSeleccionCampoEmpleado()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Obtiene el indice de la tabla de tablas seleccionado
        /// </summary>
        public int Indice
        { get { return Convert.ToInt32(this.cmbCampoEmpleado.SelectedValue); } }

        /// <summary>
        /// Obtiene el texto descriptivo del Indice seleccionado
        /// </summary>
        public string IndiceDescripcion
        { get { return this.cmbCampoEmpleado.Text; } }

        /// <summary>
        /// Obtiene el valor de contenido de la tabla de tablas seleccionado
        /// </summary>
        public int Contenido
        {
            get
            {
                if (this.cbFiltroDetalle.Checked)
                { return Convert.ToInt32(cmbCampoEmpleadoDetalle.SelectedValue); }
                else
                { return 0; }
            }
        }

        /// <summary>
        /// Obtiene el texto descriptivo del Contenido seleccionado
        /// </summary>
        public string ContenidoDescripcion
        {
            get
            {
                if (this.cbFiltroDetalle.Checked)
                { return cmbCampoEmpleadoDetalle.Text; }
                else
                { return ""; }
            }
        }
        /// <summary>
        /// Obtiene el valor del Estado de empleado seleccionado
        /// </summary>
        public int Estado
        {
            get { return Convert.ToInt32(this.cmbEstadoEmpleado.SelectedValue); }
        }

        /// <summary>
        /// Obtiene el texto descriptivo del Estado de empleado seleccionado
        /// </summary>
        public string EstadoDescripcion
        {
            get { return this.cmbEstadoEmpleado.Text; }
        }

        /// <summary>
        /// Indica si se decea filtrar la el resultado segun un valor especifico
        /// </summary>
        public Boolean Filtrado
        { get { return this.cbFiltroDetalle.Checked; } }

        private Boolean tipo;
        public Boolean Tipo
        { get { return tipo; } }

        /// <summary>
        /// Indica si se debe obtener del historico
        /// </summary>
        public Boolean Historico
        { get { return this.cbHistorico.Checked; } }

        /// <summary>
        /// Obtiene el id de la liquidacion seleccionada para el historico
        /// </summary>
        public int LiquidacionID
        { get { return Convert.ToInt32(this.cmbLiquidaciones.SelectedValue); } }
        /// <summary>
        /// Obtiene la descripcion de la liquidacion seleccionada para el historico
        /// </summary>
        public string LiquidacionDescripcion
        {
            get
            {
                if (this.cbHistorico.Checked)
                    return this.cmbLiquidaciones.Text;
                else
                    return "";
            }
        }

        private void cbFiltroDetalle_CheckedChanged(object sender, EventArgs e)
        { cmbCampoEmpleadoDetalle.Enabled = cbFiltroDetalle.Checked; }

        //TODO completar consulta
        private void cmbCampoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Aca realizo la consulta para llenar el combo especifico si es que tiene valore tabulados
            cmbCampoEmpleadoDetalle.Enabled = false;
            cbFiltroDetalle.Checked = false;
            DataRowView dr = (DataRowView)cmbCampoEmpleado.SelectedItem;
            this.tipo = Convert.ToBoolean(dr["Tipo"]);
            cbFiltroDetalle.Enabled = this.Tipo;
            if (cbFiltroDetalle.Enabled)
            {
                Controles.cargaComboBox(cmbCampoEmpleadoDetalle, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", this.cmbCampoEmpleado.SelectedValue);
            }
        }

        //Completar codigo de validacion
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //TODO carga inicial de los combos
        private void frmSeleccionCampoEmpleado_Load(object sender, EventArgs e)
        {
            Controles.cargaComboBox(cmbEstadoEmpleado,"detalle", "contenido", "tablasConsultarContenidoyDetalleParaCombo", "tabla", "empleadosSueldos", "indice", 10);
            Controles.cargaComboBox(cmbCampoEmpleado, "descripcion", "indice", "tablasConsultarDetalleParaCombo");
            Controles.cargaComboBox(cmbLiquidaciones, "descripcion", "id", "liquidacionesDetalleParaCombo","estado", 1);
        }

        private void cbHistorico_CheckedChanged(object sender, EventArgs e)
        { 
            cmbLiquidaciones.Enabled = cbHistorico.Checked;
            this.cmbEstadoEmpleado.Enabled = !cbHistorico.Checked;
        }
    }
}