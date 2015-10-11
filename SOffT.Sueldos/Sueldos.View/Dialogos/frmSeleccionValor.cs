using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sueldos.View.Dialogos
{
    public partial class frmSeleccionValor : Form
    {
        public string Texto
        { get { return this.txtValor.Text; } }

        public int Valor
        {
            get
            {
                try
                { return Convert.ToInt32(this.txtValor.Text); }
                catch (Exception)
                { return 0; }
            }
        }

        public frmSeleccionValor(string descripcion)
        {
            InitializeComponent();
            this.lblDescripcion.Text = descripcion;
            this.ShowDialog();
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAceptar.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}