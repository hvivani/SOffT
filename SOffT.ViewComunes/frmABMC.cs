/*  
    frmABMC.cs

    Author:
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
using System.Windows.Forms;

namespace Sofft.ViewComunes 
{
    public partial class frmABMC : Form 
    {

        protected string CodigoBusqueda = string.Empty;
        System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();

        public frmABMC() {
            InitializeComponent();
            this.btnBuscar.MouseHover += new EventHandler(btnBuscar_MouseHover);
            this.btnCerrar.MouseHover += new EventHandler(btnCerrar_MouseHover);
            this.Text = "A.B.M. de Clientes";
        }

        void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            ToolTip1.SetToolTip(this.btnCerrar, "Cerrar");
        }

        void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            ToolTip1.SetToolTip(this.btnBuscar, "Buscar...");
        }

        /*public frmABMC(string con, string textoABM) : base(con) {
            InitializeComponent();
            base.con = con;
            this.Text = textoABM;
        }*/

        protected virtual void frmABM_Load(object sender, EventArgs e) {
            this.habilitaEliminar();
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e) {
            this.habilitaGrabar();
            this.limpiaControles();
        }

        protected virtual void habilitaGrabar() {
            //habilito los controles dentro de gbdatos.
            this.habilitaControles();

            this.btnBuscar.Enabled = false;

            this.btnAgregar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.btnGrabar.Enabled = true;
            this.btnCancelar.Enabled = true;
            this.btnCerrar.Enabled = false;
        }

        private void habilitaControles() {
            foreach (Control cont in this.gbDatos.Controls) {
                if (cont is TextBox)
                    ((TextBox)cont).Enabled = true;
                if (cont is ComboBox)
                    ((ComboBox)cont).Enabled = true;
                if (cont is ListBox)
                    ((ListBox)cont).Enabled = true;
                if (cont is Button)
                    ((Button)cont).Enabled = true;
                if (cont is CheckBox)
                    ((CheckBox)cont).Enabled = true;
                if (cont is DateTimePicker)
                    ((DateTimePicker)cont).Enabled = true;
                if (cont is GroupBox)
                    ((GroupBox)cont).Enabled = true;
                if (cont is MaskedTextBox )
                    ((MaskedTextBox)cont).Enabled = true;

                //en los tabcontrol debo recorrer cada solapa y dentro de ellas cada control.
                //en los tabcontrol solo deshabilito los GroupBox
                if (cont is TabControl)
                {
                    foreach (Control contr in ((TabControl)cont).Controls)
                    {
                        foreach (Control contro in ((TabPage)contr).Controls)
                        {
                            if (contro is GroupBox)
                                ((GroupBox)contro).Enabled = true;
                        }
                    }
                }
            }
        }

        private void limpiaControles() {
            foreach (Control cont in this.gbDatos.Controls) {
                if (cont is TextBox)
                    ((TextBox)cont).Text = "";
                if (cont is ListBox) {
                    ((ListBox)cont).DataSource = null;
                    ((ListBox)cont).Items.Clear();
                }
                if (cont is ComboBox)
                    ((ComboBox)cont).SelectedValue = -1;
                if (cont is CheckBox)
                    ((CheckBox)cont).Checked = false;
            }
        }

        private void deshabilitaControles() {
            foreach (Control cont in this.gbDatos.Controls) {
                if (cont is TextBox) {
                    ((TextBox)cont).Enabled = false;
                    ((TextBox)cont).Text = string.Empty;
                }
                if (cont is ComboBox) {
                    ((ComboBox)cont).Enabled = false;
                    ((ComboBox)cont).SelectedValue = -1;
                }
                if (cont is ListBox) {
                    ((ListBox)cont).Enabled = false;
                    ((ListBox)cont).DataSource = null;
                    ((ListBox)cont).Items.Clear();
                }
                if (cont is Button) {
                    ((Button)cont).Enabled = false;
                }
                if (cont is CheckBox) {
                    ((CheckBox)cont).Enabled = false;
                    ((CheckBox)cont).Checked = false;
                }
                if (cont is DateTimePicker)
                    ((DateTimePicker)cont).Enabled = false;

                if (cont is GroupBox)
                    ((GroupBox)cont).Enabled = false;

                if (cont is MaskedTextBox)
                {
                    ((MaskedTextBox)cont).Enabled = false;
                    ((MaskedTextBox)cont).Text = string.Empty;
                }
                //en los tabcontrol debo recorrer cada solapa y dentro de ellas cada control.
                //en los tabcontrol solo deshabilito los GroupBox
                if (cont is TabControl)
                {
                    foreach (Control contr in ((TabControl)cont).Controls)
                    {
                        foreach (Control contro in ((TabPage)contr).Controls)
                        {
                            if (contro is GroupBox)
                                ((GroupBox)contro).Enabled = false;
                        }
                    }
                }
            }
        }



        protected virtual void habilitaEliminar() {
            //deshabilito los controles dentro de gbdatos.
            this.deshabilitaControles();

            this.btnBuscar.Enabled = true;
            this.btnAgregar.Enabled = true;
            this.btnEliminar.Enabled = true; //siempre deshabilitado, se maneja con campo activo
            this.btnModificar.Enabled = true;
            this.btnGrabar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.btnCerrar.Enabled = true;
            this.btnAgregar.Focus();
        }

        protected virtual void btnCancelar_Click(object sender, EventArgs e) {
            this.habilitaEliminar();
        }

        protected virtual void btnGrabar_Click(object sender, EventArgs e) {
            this.habilitaEliminar();
            this.btnAgregar.Focus();
        }

        protected virtual void btnEliminar_Click(object sender, EventArgs e) {

        }

        protected virtual void btnModificar_Click(object sender, EventArgs e) {
            this.habilitaGrabar();
        }

        protected virtual void btnBuscar_Click(object sender, EventArgs e) {

        }


    }
}
