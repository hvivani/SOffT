//
//  frmPermisos.Designer.cs
//
//  Author:
//       Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>
//
//  Copyright (c) 2015 Hamekoz
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace Seguridad.View
{
    partial class frmPermisos
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
            this.treeViewPermisos = new System.Windows.Forms.TreeView();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.cbDocumentos = new System.Windows.Forms.CheckBox();
            this.cbSeguridad = new System.Windows.Forms.CheckBox();
            this.cbAsociarEmpleado = new System.Windows.Forms.CheckBox();
            this.cbDeshabilitar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // treeViewPermisos
            // 
            this.treeViewPermisos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewPermisos.CheckBoxes = true;
            this.treeViewPermisos.Location = new System.Drawing.Point(12, 12);
            this.treeViewPermisos.Name = "treeViewPermisos";
            this.treeViewPermisos.Size = new System.Drawing.Size(230, 319);
            this.treeViewPermisos.TabIndex = 5;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(329, 308);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(410, 308);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmpleados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleados.Enabled = false;
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(248, 168);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(233, 21);
            this.cmbEmpleados.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(315, 81);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(166, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(315, 55);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(166, 20);
            this.txtUsuario.TabIndex = 10;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(248, 58);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(248, 84);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 13);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Location = new System.Drawing.Point(248, 12);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(92, 13);
            this.lblUsuarios.TabIndex = 15;
            this.lblUsuarios.Text = "Nombre y Apellido";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUsuarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(248, 28);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(233, 21);
            this.cmbUsuarios.TabIndex = 16;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // cbDocumentos
            // 
            this.cbDocumentos.AutoSize = true;
            this.cbDocumentos.Location = new System.Drawing.Point(248, 195);
            this.cbDocumentos.Name = "cbDocumentos";
            this.cbDocumentos.Size = new System.Drawing.Size(86, 17);
            this.cbDocumentos.TabIndex = 17;
            this.cbDocumentos.Text = "Documentos";
            this.cbDocumentos.UseVisualStyleBackColor = true;
            // 
            // cbSeguridad
            // 
            this.cbSeguridad.AutoSize = true;
            this.cbSeguridad.Location = new System.Drawing.Point(248, 218);
            this.cbSeguridad.Name = "cbSeguridad";
            this.cbSeguridad.Size = new System.Drawing.Size(74, 17);
            this.cbSeguridad.TabIndex = 18;
            this.cbSeguridad.Text = "Seguridad";
            this.cbSeguridad.UseVisualStyleBackColor = true;
            // 
            // cbAsociarEmpleado
            // 
            this.cbAsociarEmpleado.AutoSize = true;
            this.cbAsociarEmpleado.Location = new System.Drawing.Point(248, 145);
            this.cbAsociarEmpleado.Name = "cbAsociarEmpleado";
            this.cbAsociarEmpleado.Size = new System.Drawing.Size(120, 17);
            this.cbAsociarEmpleado.TabIndex = 19;
            this.cbAsociarEmpleado.Text = "Empleado Asociado";
            this.cbAsociarEmpleado.UseVisualStyleBackColor = true;
            this.cbAsociarEmpleado.CheckedChanged += new System.EventHandler(this.cbAsociarEmpleado_CheckedChanged);
            // 
            // cbDeshabilitar
            // 
            this.cbDeshabilitar.AutoSize = true;
            this.cbDeshabilitar.Location = new System.Drawing.Point(248, 241);
            this.cbDeshabilitar.Name = "cbDeshabilitar";
            this.cbDeshabilitar.Size = new System.Drawing.Size(115, 17);
            this.cbDeshabilitar.TabIndex = 20;
            this.cbDeshabilitar.Text = "Dehabilitar Usuario";
            this.cbDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 339);
            this.Controls.Add(this.cbDeshabilitar);
            this.Controls.Add(this.cbAsociarEmpleado);
            this.Controls.Add(this.cbSeguridad);
            this.Controls.Add(this.cbDocumentos);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.treeViewPermisos);
            this.Name = "frmPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de Permisos";
            this.Load += new System.EventHandler(this.frmPermisos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewPermisos;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.CheckBox cbDocumentos;
        private System.Windows.Forms.CheckBox cbSeguridad;
        private System.Windows.Forms.CheckBox cbAsociarEmpleado;
        private System.Windows.Forms.CheckBox cbDeshabilitar;
    }
}