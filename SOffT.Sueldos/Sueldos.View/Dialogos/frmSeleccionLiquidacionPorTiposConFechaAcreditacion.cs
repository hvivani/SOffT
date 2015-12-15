//
//  frmSeleccionLiquidacionPorTiposConFechaAcreditacion.cs
//
//  Author:
//       Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>
//
//  Copyright (c) 2010 Hamekoz
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

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
    /// <summary>
    /// Dialogo de seleccion de Liquidacion y Tipos de Liquidacion Activas
    /// </summary>
    public partial class frmSeleccionLiquidacionPorTiposConFechaAcreditacion : Form
    {
        public frmSeleccionLiquidacionPorTiposConFechaAcreditacion()
        {
            InitializeComponent();
            liquidacionesCtrl.LiquidacionId_Changed += new EventHandler(liquidacionesCtrl_LiquidacionId_Changed);
        }

        private void liquidacionesCtrl_LiquidacionId_Changed(object sender, EventArgs e)
        { Controles.cargaListBox(this.lstFechasDePago, "fechaDePago", "idLiquidacion", "fechasDePagoConsultar", "@idLiquidacion", this.liquidacionesCtrl.LiquidacionId); }

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
        { get { return this.liquidacionesCtrl.LiquidacionDescripcion; } }

        /// <summary>
        /// Obtiene o Establece la liquidacion seleccionada
        /// </summary>
        public int LiquidacionId
        {
            get { return this.liquidacionesCtrl.LiquidacionId; }
            set { this.liquidacionesCtrl.LiquidacionId = value; }
        }

        /// <summary>
        /// Obtiene la fecha de pago seleccionada
        /// </summary>
        public DateTime FechaPago
        { get { return Convert.ToDateTime(this.lstFechasDePago.Text); } }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmSeleccionLiquidacionPorTipos_Load(object sender, EventArgs e)
        { liquidacionesCtrl.LiquidacionesCargar(); }

        private void frmSeleccionLiquidacionPorTiposConFechaAcreditacion_Load(object sender, EventArgs e)
        { liquidacionesCtrl.LiquidacionesCargar(); }


    }
}