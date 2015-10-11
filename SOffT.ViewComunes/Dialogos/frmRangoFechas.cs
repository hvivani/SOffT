/*  
    frmRangoFechas.cs

    Author:
    Hernan Vivani <hernan@vivani.com.ar> - http://hvivani.com.ar

    Copyright © SOffT 2010 - http://www.sofft.com.ar

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sofft.ViewComunes.Dialogos
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