//
//  frmSeleccionItem.cs
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

namespace Sueldos.View.Dialogos
{
    /// <summary>
    /// Formulario de dialogo para seleccionar un item de una lista de opciones
    /// </summary>
    public partial class frmSeleccionItem : Form
    {
        #region Variables internas
   
        private int id = -1;
        private string descripcion = "TODO";
       
        #endregion
        
        #region Propiedades
        /// <summary>
        /// Obtiene el valor del id del elemento seleccinado en la lista.
        /// </summary>
        public int SelectedID
        {
            get
            {
                return id;
            }
        }

        /// <summary>
        /// Obtiene el texto descriptivo del elemento seleccionado en la lista
        /// </summary>
        public string SelectedDescripcion
        {
            get
            {
                return descripcion;
            }
        }
        
        /// <summary>
        /// Obtiene o establece el nombre descriptivo de la lista
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.lblDescripcion.Text;
            }
            set
            {
                this.lblDescripcion.Text = value;
            }
        }

        /// <summary>
        /// Establece el origen de datos de la lista.
        /// </summary>
        public DataSet Lista
        {
            set
            {
                cbLista.ValueMember = value.Tables[0].Columns[0].Caption;
                cbLista.DisplayMember = value.Tables[0].Columns[1].Caption;
                cbLista.DataSource = value.Tables[0];
            }
        }

        /// <summary>
        /// Establece si se encuentra habilitada la opcion Todos del formulario.
        /// </summary>
        public Boolean HabilitarTodos
        {
            set
            {
                chBTodos.Enabled = value;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Crea una instancia del Formulario para seleccion de item de una lista de opciones
        /// </summary>
        public frmSeleccionItem()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (chBTodos.Checked)
            {
                this.id = -1;
                this.descripcion = "TODO";
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
           this.id = int.Parse(cbLista.SelectedValue.ToString());
           this.descripcion = cbLista.Text;
        }

        private void chBTodos_CheckedChanged(object sender, EventArgs e)
        {
            cbLista.Enabled = !chBTodos.Checked;
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}