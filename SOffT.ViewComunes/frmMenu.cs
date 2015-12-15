/*  
    frmMenu.cs

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
    public partial class frmMenu : Form //, IPermisible
    {
        public frmMenu()
        {
            InitializeComponent();
            this.Icon = Modulo.cargaIcono();
        }

        /// <summary>
        /// Arreglo de Botones para manejar los indices de los permisos.
        /// 20061011. hvivani
        /// </summary>
        private Button[] botones;

        private void btnCerrar_Click(object sender, EventArgs e)
        { this.Close(); }

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
                botones[i].Width = flpBotones.Width - botones[i].Margin.Horizontal;
                flpBotones.Controls.Add(botones[i]);
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
        { MessageBox.Show("Es necesario redefinir este metodo en la nueva instancia"); }

        /// <summary>
        /// el subIndice hace referencia al numero de boton (indiceboton + 1) que se está usando para acceder a
        /// este formulario.
        /// </summary>
        /// <param name="subIndice"></param>
        public void aplicaPermisos(int indice)
        { Usuario.setPermisosSubIndices(ref botones, indice); }

        #region Miembros de IPermisible

        private string nivel;
        /// <summary>
        /// Obtinene el nivel de profundidad del formulario. Recorrido de indices desde el fomulario principal hasta el formulario actual. 
        /// </summary>
        public string Nivel
        {
            get { return this.nivel; }
        }

        /// <summary>
        /// Abre el formulario y aplica los permisos correspondientes al nivel e indice.
        /// Es necesario invocar este metodo desde las redefiniciones abrir en los formularios heredados.
        /// La llamda en la redefinicion debe estar al final del metodo
        /// </summary>
        /// <param name="nivel">Nivel del fomulario invocador</param>
        /// <param name="indice">Indice del boton invocador</param>
        public virtual void abrir(string nivel, int indice)
        {
            this.nivel = string.Concat(nivel, ".", indice.ToString());
            Usuario.setPermisos(ref this.botones, this.Nivel);
            this.ShowDialog();
        }

        #endregion
    }
}