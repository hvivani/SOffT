using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;

namespace Sueldos.View
{
    public partial class frmGestionDatosRemotos : Form
    {
        public frmGestionDatosRemotos()
        {
            InitializeComponent();
        }

        public void abrir()
        {
            Model.DB.ProviderName = "MySql.Data.MySqlClient";
            Model.DB.CadenaConexion = "server=vivani.site40.net;user id=a4827405_soff;Password=Collote75;database=a4827405_sofft;Allow Zero Datetime=True";

            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.Texto, "select * from empresas");
            if (rs.Read())
                MessageBox.Show(rs["razonSocial"].ToString());
            else
                MessageBox.Show("sin datos");
            rs.Close();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGestionDatosRemotos_Load(object sender, EventArgs e)
        {

        }
    }
}
