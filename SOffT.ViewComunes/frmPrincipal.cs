/*  
    frmPrincipal.cs

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
using Sofft.Utils;


namespace Sofft.ViewComunes
{
    /// <summary>
    /// Formulario Principal de Modulos, Heredable, con metodos redefinibles.
    /// </summary>
    public partial class frmPrincipal : Form
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public frmPrincipal()
        { 
            InitializeComponent();
            this.pictureBoxEmpresa.Image = Controles.cargarImagen(Application.StartupPath + @"/imagenes/logoGrande.jpg");
        }

        /// <summary>
        /// Arreglo de Botones para manejar los indices de los permisos.
        /// 20061011. hvivani
        /// </summary>
        private Button[] botones;

        private void btnCerrar_Click(object sender, EventArgs e)
        { this.Close(); }

        /// <summary>
        /// Llama al login y verifica los datos ingresados.
        /// hvivani. 20061011.
        /// </summary>
        public void verificaLogin()
        {
            frmLogin f = new frmLogin(); //llamo al login
            f.ShowDialog();
            if (Modulo.Usuario != null)
            {
                //this.lblSistemaGestion.Text = Modulo.NombreSistema;
                //this.lblModulo.Text = Modulo.NombreModulo;
                //Usuario.setPermisosIndices(ref botones);
                Usuario.setPermisos(ref botones, this.Nivel);
                //actualizarDatosDocumentoModulo Me
                //administrarPermisosIndices Me
            }
        }

        /// <summary>
        /// Setea los datos de inicialización del modulo: servidor, db, nombreModulo, tituloModulo.
        /// 20061011. hvivani
        /// </summary>
        public void setDatos(string servidor, string DB, string nombreModulo, string nombreSistema, Icon icono, string version)
        {
            //seteo datos del modulo*/
            Modulo.ServidorDB = servidor;
            Modulo.DB = DB;
            Modulo.NombreModulo = nombreModulo;
            Modulo.NombreSistema = nombreSistema;
            Modulo.IdModulo = 2;
            Modulo.FechaActual = Varios.consultarFechaActual();
            this.Icon = Modulo.cargaIcono();
            this.lblVersion.Text = version;
            this.lblSistemaGestion.Text = Modulo.NombreSistema;
            this.lblModulo.Text = Modulo.NombreModulo;
        }

        /// <summary>
        /// Crea los botones en array a agregar en el frm.
        /// hvivani. 20061011.
        /// </summary>
        /// <param name="cantidad">Lista de nombre para los botones a crear</param>
        public void creaBotones(params string[] nombresBotones)
        {
            botones = new Button[nombresBotones.Length];
            for (int i = 0; i < nombresBotones.Length; i++)
            {
                botones[i] = new Button();
                ///TODO: Pasar esta opcion a false
                if (Modulo.ValidaLogin)
                    botones[i].Enabled = false;
                else
                    botones[i].Enabled = true;
                botones[i].TabIndex = i;
                botones[i].Text = nombresBotones[i];
                botones[i].Width = fLPBotones.Width - fLPBotones.Margin.All;
                fLPBotones.Controls.Add(botones[i]);
                botones[i].Click += new EventHandler(botones_Click);
            }
        }

        /// <summary>
        /// Evento único para el panel de botones. Detecta la pulsacion de un boton
        /// hvivani. 20061011.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botones_Click(object sender, System.EventArgs e)
        {
            Button b = (Button)sender;
            this.boton_Click(b.TabIndex);
        }
        /// <summary>
        /// Metodo para definir la accion de cada boton pulsado
        /// </summary>
        /// <param name="boton">Boton pulsado</param>
        /// <param name="indice">Indice del boton pulsado</param>
        public virtual void boton_Click(int indice)
        {
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //si se esta validando el usuario y no se obtuvo uno valido. cierro.
            if (Modulo.ValidaLogin && Modulo.Usuario == null || this.Nivel == null)
                this.Close();
        }

        #region Miembros de IPermisible

        public string Nivel
        {
            get { return Modulo.IdModulo.ToString(); }
        }

        public void abrir(string nivel, int indice)
        { throw new Exception("The method or operation is not implemented."); }

        #endregion
    }
}