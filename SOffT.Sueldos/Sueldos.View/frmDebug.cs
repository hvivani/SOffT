using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sueldos.View
{
    public partial class frmDebug : Form
    {
        public frmDebug()
        {
            InitializeComponent();
        }

        public frmDebug(string strDebug)
        {
            InitializeComponent();
            this.txtDebug.Text = strDebug;
            this.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDebug_Load(object sender, EventArgs e)
        {

        }
    }
}
