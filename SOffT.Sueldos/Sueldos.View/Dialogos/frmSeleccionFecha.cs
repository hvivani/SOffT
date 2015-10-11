using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sueldos.View.Dialogos
{
    public partial class frmSeleccionFecha : Form
    {
        public frmSeleccionFecha()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
        }

        /// <summary>
        /// Obtiene el la fecha seleccionada
        /// </summary>
        public DateTime Fecha
        {
            get { return dateTimePicker1.Value; }
        }

        /// <summary>
        /// Obtiene el Año y Mes seleccionado en formato numerico AAAAMM
        /// </summary>
        public int AnioMes
        {
            get { return dateTimePicker1.Value.Year * 100 + dateTimePicker1.Value.Month; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}