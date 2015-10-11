using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sueldos.View.Dialogos
{
    /// <summary>
    /// Dialogo de seleccion de Liquidacion y Tipos de Liquidacion Activas
    /// </summary>
    public partial class frmSeleccionLiquidacionPorTipos : Form
    {
        public frmSeleccionLiquidacionPorTipos()
        { InitializeComponent(); }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.liquidacionesCtrl.TiposSeleccionados.Count > 0)
            {
                liquidacionesCtrl.GrabarTipoSeleccionados();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            { MessageBox.Show("Debe seleccionar al menos un tipo de liquidación"); }
        }

        /// <summary>
        /// Obtiene la descripcion de la liquidacion seleccionada
        /// </summary>
        public string LiquidacionDescripcion
        {
            get { return this.liquidacionesCtrl.LiquidacionDescripcion; }
        }

        /// <summary>
        /// Obtiene o Establece la liquidacion seleccionada
        /// </summary>
        public int LiquidacionId
        {
            get { return this.liquidacionesCtrl.LiquidacionId; }
            set { this.liquidacionesCtrl.LiquidacionId = value; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmSeleccionLiquidacionPorTipos_Load(object sender, EventArgs e)
        { liquidacionesCtrl.LiquidacionesCargar(); }
    }
}