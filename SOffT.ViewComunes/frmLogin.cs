/*  
    frmLogin.cs

    Author:
    Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>
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
using System.IO;
using Sofft.Utils;


namespace Sofft.ViewComunes
{
    /// <summary>
    /// Fomulario utilizado para verificar usuario
    /// </summary>
    public partial class frmLogin : Form
    {


        public frmLogin ()
        {
        	InitializeComponent ();
        	this.picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
			string pathLogo = Application.StartupPath + Path.DirectorySeparatorChar + Modulo.pathImagenes + Path.DirectorySeparatorChar + Modulo.nombreLogo;
            this.picLogo.Image = Controles.cargarImagen(pathLogo);
            ///TODO: verificar si valida login o no
            //Modulo.ValidaLogin = false; 
            this.leeArchivoLogin();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int idUsuario;
            Usuario usuario = new Usuario();
            idUsuario=usuario.consultarExisteUsuario (txtUsuario.Text,txtPwd.Text);
            if (idUsuario > 0)
            {
                usuario.IdUsuario=idUsuario;
                usuario.Login =txtUsuario.Text;
                usuario.Password = txtPwd.Text;
                Modulo.Usuario=usuario;
                this.escribeArchivoLogin();
            }
            else
                MessageBox.Show("Usuario inexistente - Consulte con el administrador");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                txtPwd.Focus();
                e.Handled = true; //No Beep}
            }           
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                //this.btnAceptar_Click(sender , e);
                btnAceptar.Focus();
                e.Handled = true; //No Beep}
            }
        }

        private void leeArchivoLogin()
        {
            try
            {
                string strLine;
                StreamReader objReader = new StreamReader("C:\\lastusr.dat");
                strLine = objReader.ReadLine();
                if (strLine != null)
                {
                    this.txtUsuario.Text = strLine;
                    this.txtPwd.Focus();
                }
                objReader.Close();
            }catch 
            {
                Console.WriteLine("no se encontró archivo login.");
            }
        }

        private void escribeArchivoLogin()
        {
            try
            {
                StreamWriter objWriter = new StreamWriter("C:\\lastusr.dat");
                if (this.txtUsuario.Text.Length>0)
                    objWriter.WriteLine(this.txtUsuario.Text);
                objWriter.Close();
            }
            catch
            {
                Console.WriteLine("no pudo crear archivo login.");
            }
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}