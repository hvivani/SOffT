/*  
    FrmReportes.cs

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

namespace Sueldos.Reportes.CrystalReport
{
    partial class FrmReportes : Form
    {

        public FrmReportes()
        {
            InitializeComponent();
        }

        public FrmReportes(CrystalDecisions.CrystalReports.Engine.ReportClass Reporte)
        {
            InitializeComponent();
            this.crvReportes.ReportSource = Reporte;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Genera Reportes automaticamente con vista previa.
        /// </summary>
        /// <param name="o">Objeto que representa la coleccion de datos a mostrar en el reporte</param>
        public void abrir(object o)
        {
            this.crvReportes.ReportSource = o;
            this.crvReportes.Refresh();
            this.crvReportes.Show();
            this.ShowDialog();
        }

        public void setReportSource(CrystalDecisions.CrystalReports.Engine.ReportClass Reporte)
        {
            this.crvReportes.ReportSource = Reporte;
        }
    }
}