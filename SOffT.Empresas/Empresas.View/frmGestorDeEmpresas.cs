/*  
    frmGestorEmpresas.cs

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
using System.Diagnostics;

namespace Empresas.View
{
    public partial class frmGestorDeEmpresas : Form
    {
        public frmGestorDeEmpresas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGestorDeEmpresas_Load(object sender, EventArgs e)
        {
            Model.DB.ConnectionName = "empresas.Properties.Settings.sueldosConnectionStringDefault";
            Model.DB.CadenaConexion = "Data Source=" + System.Configuration.ConfigurationManager.AppSettings["NombreServidorDB"]  + ";Initial Catalog=MASTER;Integrated Security=True";

            //carga combo empresas
            this.cbEmpresas.ValueMember= "dbid";
            this.cbEmpresas.DisplayMember = "DB_NAME";
            this.cbEmpresas.DataSource = (Model.DB.ejecutarDataSet(Model.TipoComando.Texto, "USE master SELECT     dbid, DB_NAME(dbid) AS DB_NAME FROM sysdatabases WHERE dbid > 6 ORDER BY dbid")).Tables[0];
            this.cbEmpresas.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Model.DB.CadenaConexion = "Data Source=" + System.Configuration.ConfigurationManager.AppSettings["NombreServidorDB"] + ";Initial Catalog=" + this.cbEmpresas.Text + ";Integrated Security=True";
            new Sueldos.View.frmSueldos().ShowDialog(); 
            this.Visible = true;
        }
    }
}