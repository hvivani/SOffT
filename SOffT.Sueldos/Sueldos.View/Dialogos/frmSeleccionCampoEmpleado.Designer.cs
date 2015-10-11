/*  
    frmSeleccionCampoEmpleado.cs

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

namespace Sueldos.View.Dialogos
{
    partial class frmSeleccionCampoEmpleado
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
            this.gbCampos = new System.Windows.Forms.GroupBox();
            this.cmbCampoEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbCampoEmpleadoDetalle = new System.Windows.Forms.ComboBox();
            this.cbFiltroDetalle = new System.Windows.Forms.CheckBox();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.cmbEstadoEmpleado = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbLiquidaciones = new System.Windows.Forms.ComboBox();
            this.cbHistorico = new System.Windows.Forms.CheckBox();
            this.gbCampos.SuspendLayout();
            this.gbEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCampos
            // 
            this.gbCampos.Controls.Add(this.cmbLiquidaciones);
            this.gbCampos.Controls.Add(this.cbHistorico);
            this.gbCampos.Controls.Add(this.cmbCampoEmpleado);
            this.gbCampos.Controls.Add(this.cmbCampoEmpleadoDetalle);
            this.gbCampos.Controls.Add(this.cbFiltroDetalle);
            this.gbCampos.Location = new System.Drawing.Point(13, 65);
            this.gbCampos.Name = "gbCampos";
            this.gbCampos.Size = new System.Drawing.Size(191, 150);
            this.gbCampos.TabIndex = 37;
            this.gbCampos.TabStop = false;
            this.gbCampos.Text = "Campo Empleado";
            // 
            // cmbCampoEmpleado
            // 
            this.cmbCampoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampoEmpleado.FormattingEnabled = true;
            this.cmbCampoEmpleado.Location = new System.Drawing.Point(6, 19);
            this.cmbCampoEmpleado.Name = "cmbCampoEmpleado";
            this.cmbCampoEmpleado.Size = new System.Drawing.Size(179, 21);
            this.cmbCampoEmpleado.TabIndex = 27;
            this.cmbCampoEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbCampoEmpleado_SelectedIndexChanged);
            // 
            // cmbCampoEmpleadoDetalle
            // 
            this.cmbCampoEmpleadoDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampoEmpleadoDetalle.Enabled = false;
            this.cmbCampoEmpleadoDetalle.FormattingEnabled = true;
            this.cmbCampoEmpleadoDetalle.Location = new System.Drawing.Point(6, 69);
            this.cmbCampoEmpleadoDetalle.Name = "cmbCampoEmpleadoDetalle";
            this.cmbCampoEmpleadoDetalle.Size = new System.Drawing.Size(179, 21);
            this.cmbCampoEmpleadoDetalle.TabIndex = 28;
            // 
            // cbFiltroDetalle
            // 
            this.cbFiltroDetalle.AutoSize = true;
            this.cbFiltroDetalle.Enabled = false;
            this.cbFiltroDetalle.Location = new System.Drawing.Point(6, 46);
            this.cbFiltroDetalle.Name = "cbFiltroDetalle";
            this.cbFiltroDetalle.Size = new System.Drawing.Size(57, 17);
            this.cbFiltroDetalle.TabIndex = 29;
            this.cbFiltroDetalle.Text = "Detalle";
            this.cbFiltroDetalle.UseVisualStyleBackColor = true;
            this.cbFiltroDetalle.CheckedChanged += new System.EventHandler(this.cbFiltroDetalle_CheckedChanged);
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.cmbEstadoEmpleado);
            this.gbEstado.Location = new System.Drawing.Point(13, 12);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(191, 47);
            this.gbEstado.TabIndex = 36;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado";
            // 
            // cmbEstadoEmpleado
            // 
            this.cmbEstadoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoEmpleado.FormattingEnabled = true;
            this.cmbEstadoEmpleado.Location = new System.Drawing.Point(6, 19);
            this.cmbEstadoEmpleado.Name = "cmbEstadoEmpleado";
            this.cmbEstadoEmpleado.Size = new System.Drawing.Size(179, 21);
            this.cmbEstadoEmpleado.TabIndex = 30;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(111, 221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(30, 221);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 34;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbLiquidaciones
            // 
            this.cmbLiquidaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLiquidaciones.Enabled = false;
            this.cmbLiquidaciones.FormattingEnabled = true;
            this.cmbLiquidaciones.Location = new System.Drawing.Point(6, 119);
            this.cmbLiquidaciones.Name = "cmbLiquidaciones";
            this.cmbLiquidaciones.Size = new System.Drawing.Size(179, 21);
            this.cmbLiquidaciones.TabIndex = 42;
            // 
            // cbHistorico
            // 
            this.cbHistorico.AutoSize = true;
            this.cbHistorico.Location = new System.Drawing.Point(6, 96);
            this.cbHistorico.Name = "cbHistorico";
            this.cbHistorico.Size = new System.Drawing.Size(122, 17);
            this.cbHistorico.TabIndex = 43;
            this.cbHistorico.Text = "Histórico Liquidacion";
            this.cbHistorico.UseVisualStyleBackColor = true;
            this.cbHistorico.CheckedChanged += new System.EventHandler(this.cbHistorico_CheckedChanged);
            // 
            // frmSeleccionCampoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 255);
            this.ControlBox = false;
            this.Controls.Add(this.gbCampos);
            this.Controls.Add(this.gbEstado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSeleccionCampoEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selección de campo";
            this.Load += new System.EventHandler(this.frmSeleccionCampoEmpleado_Load);
            this.gbCampos.ResumeLayout(false);
            this.gbCampos.PerformLayout();
            this.gbEstado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCampos;
        private System.Windows.Forms.ComboBox cmbCampoEmpleado;
        private System.Windows.Forms.ComboBox cmbCampoEmpleadoDetalle;
        private System.Windows.Forms.CheckBox cbFiltroDetalle;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.ComboBox cmbEstadoEmpleado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbLiquidaciones;
        private System.Windows.Forms.CheckBox cbHistorico;
    }
}