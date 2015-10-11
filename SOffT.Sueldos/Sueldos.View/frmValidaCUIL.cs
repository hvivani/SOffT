using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sofft.Utils;

namespace Sueldos.View
{
    public partial class frmValidaCUIL : Form
    {
        public frmValidaCUIL()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbValidar_Enter(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (CUIL.Validar(this.txtCUIL.Text))
                MessageBox.Show("CUIL CORRECTO");
            else
                MessageBox.Show("CUIL INVALIDO !!!");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string cuil = "";
            cuil=CUIL.generar(Convert.ToChar(Varios.Left(this.cmbSexo.Text, 1)), this.txtDNI.Text );
            MessageBox.Show("CUIL: " + cuil);
            this.txtDNI.Focus();
        }
        
        private void frmValidaCUIL_Load(object sender, EventArgs e)
        {
            this.cmbSexo.SelectedIndex = 0;
        }
    }
}