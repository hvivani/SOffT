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