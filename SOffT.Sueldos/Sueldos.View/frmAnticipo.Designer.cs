/*  
    frmAnticipo.cs

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

namespace Sueldos.View
{
    partial class frmAnticipo
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
            this.gbLegajo = new System.Windows.Forms.GroupBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.cmbMeses = new System.Windows.Forms.ComboBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.cmbAnios = new System.Windows.Forms.ComboBox();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.lblCuota = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaComprobante = new System.Windows.Forms.Label();
            this.txtNroComprobante = new System.Windows.Forms.TextBox();
            this.lblNroComprobante = new System.Windows.Forms.Label();
            this.lblApellidoyNombres = new System.Windows.Forms.Label();
            this.cmbTipoAnticipo = new System.Windows.Forms.ComboBox();
            this.lblTipoAnticipo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.gbLegajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLegajo
            // 
            this.gbLegajo.Controls.Add(this.txtComentarios);
            this.gbLegajo.Controls.Add(this.lblComentarios);
            this.gbLegajo.Controls.Add(this.txtCuota);
            this.gbLegajo.Controls.Add(this.txtImporte);
            this.gbLegajo.Controls.Add(this.cmbMeses);
            this.gbLegajo.Controls.Add(this.lblAnio);
            this.gbLegajo.Controls.Add(this.lblMes);
            this.gbLegajo.Controls.Add(this.cmbAnios);
            this.gbLegajo.Controls.Add(this.cmbEmpleados);
            this.gbLegajo.Controls.Add(this.lblCuota);
            this.gbLegajo.Controls.Add(this.lblImporte);
            this.gbLegajo.Controls.Add(this.lblLegajo);
            this.gbLegajo.Controls.Add(this.txtLegajo);
            this.gbLegajo.Controls.Add(this.dtpFecha);
            this.gbLegajo.Controls.Add(this.lblFechaComprobante);
            this.gbLegajo.Controls.Add(this.txtNroComprobante);
            this.gbLegajo.Controls.Add(this.lblNroComprobante);
            this.gbLegajo.Controls.Add(this.lblApellidoyNombres);
            this.gbLegajo.Controls.Add(this.cmbTipoAnticipo);
            this.gbLegajo.Controls.Add(this.lblTipoAnticipo);
            this.gbLegajo.Location = new System.Drawing.Point(12, 12);
            this.gbLegajo.Name = "gbLegajo";
            this.gbLegajo.Size = new System.Drawing.Size(522, 138);
            this.gbLegajo.TabIndex = 0;
            this.gbLegajo.TabStop = false;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(9, 111);
            this.txtComentarios.MaxLength = 50;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(507, 20);
            this.txtComentarios.TabIndex = 19;
            this.txtComentarios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentarios_KeyDown);
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblComentarios.Location = new System.Drawing.Point(6, 95);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(76, 13);
            this.lblComentarios.TabIndex = 18;
            this.lblComentarios.Text = "Comentarios";
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(472, 72);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.ReadOnly = true;
            this.txtCuota.Size = new System.Drawing.Size(44, 20);
            this.txtCuota.TabIndex = 8;
            this.txtCuota.Text = "1";
            this.txtCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(396, 71);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(71, 20);
            this.txtImporte.TabIndex = 7;
            this.txtImporte.Text = "0.00";
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtImporte_KeyDown);
            // 
            // cmbMeses
            // 
            this.cmbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Location = new System.Drawing.Point(374, 32);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(142, 21);
            this.cmbMeses.TabIndex = 3;
            this.cmbMeses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMeses_KeyDown);
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAnio.Location = new System.Drawing.Point(288, 15);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(33, 13);
            this.lblAnio.TabIndex = 11;
            this.lblAnio.Text = "Año:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMes.Location = new System.Drawing.Point(371, 16);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(34, 13);
            this.lblMes.TabIndex = 12;
            this.lblMes.Text = "Mes:";
            // 
            // cmbAnios
            // 
            this.cmbAnios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnios.FormattingEnabled = true;
            this.cmbAnios.Location = new System.Drawing.Point(291, 31);
            this.cmbAnios.Name = "cmbAnios";
            this.cmbAnios.Size = new System.Drawing.Size(77, 21);
            this.cmbAnios.TabIndex = 2;
            this.cmbAnios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAnios_KeyDown);
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(59, 32);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(226, 21);
            this.cmbEmpleados.TabIndex = 1;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            this.cmbEmpleados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmpleados_KeyDown);
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCuota.Location = new System.Drawing.Point(469, 56);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(40, 13);
            this.lblCuota.TabIndex = 17;
            this.lblCuota.Text = "Cuota";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblImporte.Location = new System.Drawing.Point(393, 56);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(49, 13);
            this.lblImporte.TabIndex = 16;
            this.lblImporte.Text = "Importe";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLegajo.Location = new System.Drawing.Point(6, 16);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(45, 13);
            this.lblLegajo.TabIndex = 9;
            this.lblLegajo.Text = "Legajo";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(6, 32);
            this.txtLegajo.MaxLength = 8;
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(47, 20);
            this.txtLegajo.TabIndex = 0;
            this.txtLegajo.TextChanged += new System.EventHandler(this.txtLegajo_TextChanged);
            this.txtLegajo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLegajo_KeyDown);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(304, 72);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(86, 20);
            this.dtpFecha.TabIndex = 6;
            this.dtpFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFecha_KeyDown);
            // 
            // lblFechaComprobante
            // 
            this.lblFechaComprobante.AutoSize = true;
            this.lblFechaComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaComprobante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFechaComprobante.Location = new System.Drawing.Point(301, 56);
            this.lblFechaComprobante.Name = "lblFechaComprobante";
            this.lblFechaComprobante.Size = new System.Drawing.Size(77, 13);
            this.lblFechaComprobante.TabIndex = 15;
            this.lblFechaComprobante.Text = "Fecha Comp";
            // 
            // txtNroComprobante
            // 
            this.txtNroComprobante.Location = new System.Drawing.Point(165, 72);
            this.txtNroComprobante.MaxLength = 20;
            this.txtNroComprobante.Name = "txtNroComprobante";
            this.txtNroComprobante.ReadOnly = true;
            this.txtNroComprobante.Size = new System.Drawing.Size(133, 20);
            this.txtNroComprobante.TabIndex = 5;
            // 
            // lblNroComprobante
            // 
            this.lblNroComprobante.AutoSize = true;
            this.lblNroComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroComprobante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNroComprobante.Location = new System.Drawing.Point(162, 56);
            this.lblNroComprobante.Name = "lblNroComprobante";
            this.lblNroComprobante.Size = new System.Drawing.Size(105, 13);
            this.lblNroComprobante.TabIndex = 14;
            this.lblNroComprobante.Text = "Nro Comprobante";
            // 
            // lblApellidoyNombres
            // 
            this.lblApellidoyNombres.AutoSize = true;
            this.lblApellidoyNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoyNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblApellidoyNombres.Location = new System.Drawing.Point(57, 16);
            this.lblApellidoyNombres.Name = "lblApellidoyNombres";
            this.lblApellidoyNombres.Size = new System.Drawing.Size(115, 13);
            this.lblApellidoyNombres.TabIndex = 10;
            this.lblApellidoyNombres.Text = "Apellido y Nombres";
            // 
            // cmbTipoAnticipo
            // 
            this.cmbTipoAnticipo.FormattingEnabled = true;
            this.cmbTipoAnticipo.Location = new System.Drawing.Point(9, 71);
            this.cmbTipoAnticipo.Name = "cmbTipoAnticipo";
            this.cmbTipoAnticipo.Size = new System.Drawing.Size(150, 21);
            this.cmbTipoAnticipo.TabIndex = 4;
            this.cmbTipoAnticipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTipoAnticipo_KeyDown);
            // 
            // lblTipoAnticipo
            // 
            this.lblTipoAnticipo.AutoSize = true;
            this.lblTipoAnticipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAnticipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTipoAnticipo.Location = new System.Drawing.Point(6, 56);
            this.lblTipoAnticipo.Name = "lblTipoAnticipo";
            this.lblTipoAnticipo.Size = new System.Drawing.Size(104, 13);
            this.lblTipoAnticipo.TabIndex = 13;
            this.lblTipoAnticipo.Text = "Tipo de Anticipo:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(330, 156);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(236, 156);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(142, 156);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmAnticipo
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 191);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbLegajo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAnticipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAnticipo";
            this.gbLegajo.ResumeLayout(false);
            this.gbLegajo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLegajo;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.ComboBox cmbMeses;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox cmbAnios;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFechaComprobante;
        private System.Windows.Forms.TextBox txtNroComprobante;
        private System.Windows.Forms.Label lblNroComprobante;
        private System.Windows.Forms.Label lblApellidoyNombres;
        private System.Windows.Forms.ComboBox cmbTipoAnticipo;
        private System.Windows.Forms.Label lblTipoAnticipo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label lblComentarios;
    }
}