//
//  frmSeleccionAnioMes.cs
//
//  Author:
//       Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>
//
//  Copyright (c) 2015 Hamekoz
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
    /// Formulario para la seleccion de Año y Mes definidos en tablas, utilizando combos
    /// </summary>
    public partial class frmSeleccionAnioMes : Form
    {
        /// <summary>
        /// Crea una nueva instancia del formulario de dialog
        /// </summary>
        public frmSeleccionAnioMes()
        { InitializeComponent(); }

        /// <summary>
        /// Obtiene el numero de Año seleccionado
        /// </summary>
        public int Anio
        { get { return Convert.ToInt32(this.cmbAnios.SelectedValue); } }

        /// <summary>
        /// Obtiene el número de Mes seleccionado
        /// </summary>
        public int Mes
        { get { return Convert.ToInt32(this.cmbMeses.SelectedValue); } }

        /// <summary>
        /// Obtiene el nombre del Mes seleccionado
        /// </summary>
        public int MesDescripcion
        { get { return Convert.ToInt32(this.cmbMeses.Text); } }

        /// <summary>
        /// Obtiene el Año y Mes en formato numerico AAAAMM
        /// </summary>
        public int AnioMes
        { get { return Convert.ToInt32(this.cmbAnios.SelectedValue) * 100 + Convert.ToInt32(this.cmbMeses.SelectedValue); } }

        /// <summary>
        /// Obtiene el Año y Mes en formato texto Mes y Año
        /// </summary>
        public string AnioMesDescripcion
        { get { return this.cmbMeses.Text + " " + this.cmbAnios.Text; } }

        private void frmSeleccionAnioMes_Load(object sender, EventArgs e)
        {
            Controles.cargaComboBox(this.cmbAnios, "contenido", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "calendario", "indice", 1);
            this.cmbAnios.SelectedValue = DateTime.Now.Year;
            Controles.cargaComboBox(this.cmbMeses, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "calendario", "indice", 2);
            this.cmbMeses.SelectedValue = DateTime.Now.Month;
        }

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