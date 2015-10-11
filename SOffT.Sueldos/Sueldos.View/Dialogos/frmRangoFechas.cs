using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sueldos.View
{
    /// <summary>
    /// Formulario de dialogo para seleccion de fechas
    /// </summary>
    public partial class frmRangoFechas : Form
    {
        #region Variables Internas

        #endregion

        #region Propiedades

        /// <summary>
        /// Obtiene o establece fecha inicial del rango. Por defecto fecha actual
        /// </summary>
        public DateTime FechaDesde
        {
            get
            {
                return this.dtpDesde.Value.Date;
            }
            set
            {
                this.dtpDesde.Value = value;
            }
        }

        /// <summary>
        /// Obtiene o establece fecha final del rango. Por defecto fecha actual
        /// </summary>
        public DateTime FechaHasta
        {
            get
            {
                return this.dtpHasta.Value.Date;
            }
            set
            {
                this.dtpDesde.Value = value;
            }
        }

        /// <summary>
        /// Establece si el dialogo es para un rago de fechas (por defecto) o solo para una fecha Hasta.
        /// </summary>
        public Boolean HabilitarRango
        {
            set
            {
                this.dtpDesde.Enabled = value;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Crea una instancia del formulario de dialogo para seleccion de fechas
        /// </summary>
        public frmRangoFechas()
        {
            InitializeComponent();
            this.dtpDesde.Value = DateTime.Now.Date;
            this.dtpDesde.Value = DateTime.Now.Date;
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpDesde.Value > this.dtpHasta.Value)
                this.dtpDesde.Value = this.dtpHasta.Value;
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpHasta.Value < this.dtpDesde.Value)
                this.dtpHasta.Value = this.dtpDesde.Value;
        }

        #endregion

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
    }
}