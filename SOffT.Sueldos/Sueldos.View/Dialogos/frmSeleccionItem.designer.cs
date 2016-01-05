/*  
    frmSeleccionItem.cs

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


namespace Sueldos.View.Dialogos
{
    partial class frmSeleccionItem
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbLista = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chBTodos = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbLista
            // 
            this.cbLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLista.FormattingEnabled = true;
            this.cbLista.Location = new System.Drawing.Point(15, 25);
            this.cbLista.Name = "cbLista";
            this.cbLista.Size = new System.Drawing.Size(330, 21);
            this.cbLista.TabIndex = 0;
            this.cbLista.SelectedIndexChanged += new System.EventHandler(this.cbLista_SelectedIndexChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDescripcion.Location = new System.Drawing.Point(12, 9);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 22;
            this.lblDescripcion.Text = "Elemento:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.Location = new System.Drawing.Point(93, 52);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chBTodos
            // 
            this.chBTodos.AutoSize = true;
            this.chBTodos.Location = new System.Drawing.Point(291, 5);
            this.chBTodos.Name = "chBTodos";
            this.chBTodos.Size = new System.Drawing.Size(54, 17);
            this.chBTodos.TabIndex = 24;
            this.chBTodos.Text = "Todos";
            this.chBTodos.UseVisualStyleBackColor = true;
            this.chBTodos.CheckedChanged += new System.EventHandler(this.chBTodos_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(189, 52);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmSeleccionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 83);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.chBTodos);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.cbLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSeleccionItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione un elemento de la lista";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLista;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chBTodos;
        private System.Windows.Forms.Button btnCancelar;
    }
}