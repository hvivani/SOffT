/*  
    frmABManticipos.cs

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
    partial class frmABManticipos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvAnticipos = new System.Windows.Forms.DataGridView();
            this.gbLegajo = new System.Windows.Forms.GroupBox();
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
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnticipos)).BeginInit();
            this.gbLegajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(509, 298);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 24);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(258, 298);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(76, 24);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(340, 298);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 24);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(94, 298);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(76, 24);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 298);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(76, 24);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAgregar_KeyDown);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(176, 298);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 24);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvAnticipos
            // 
            this.dgvAnticipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnticipos.Location = new System.Drawing.Point(12, 121);
            this.dgvAnticipos.Name = "dgvAnticipos";
            this.dgvAnticipos.Size = new System.Drawing.Size(585, 171);
            this.dgvAnticipos.TabIndex = 6;
            // 
            // gbLegajo
            // 
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
            this.gbLegajo.Size = new System.Drawing.Size(585, 103);
            this.gbLegajo.TabIndex = 1;
            this.gbLegajo.TabStop = false;
            this.gbLegajo.Enter += new System.EventHandler(this.gbLegajo_Enter);
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(292, 77);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(39, 20);
            this.txtCuota.TabIndex = 8;
            this.txtCuota.Text = "1";
            this.txtCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCuota.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCuota_KeyDown);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(216, 76);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(70, 20);
            this.txtImporte.TabIndex = 7;
            this.txtImporte.Text = "0.00";
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtImporte_KeyDown);
            // 
            // cmbMeses
            // 
            this.cmbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Location = new System.Drawing.Point(325, 32);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(117, 21);
            this.cmbMeses.TabIndex = 3;
            this.cmbMeses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMeses_KeyDown);
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAnio.Location = new System.Drawing.Point(259, 16);
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
            this.lblMes.Location = new System.Drawing.Point(322, 16);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(34, 13);
            this.lblMes.TabIndex = 12;
            this.lblMes.Text = "Mes:";
            // 
            // cmbAnios
            // 
            this.cmbAnios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnios.FormattingEnabled = true;
            this.cmbAnios.Location = new System.Drawing.Point(262, 31);
            this.cmbAnios.Name = "cmbAnios";
            this.cmbAnios.Size = new System.Drawing.Size(57, 21);
            this.cmbAnios.TabIndex = 2;
            this.cmbAnios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAnios_KeyDown);
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(59, 32);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(197, 21);
            this.cmbEmpleados.TabIndex = 1;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            this.cmbEmpleados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmpleados_KeyDown);
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCuota.Location = new System.Drawing.Point(289, 61);
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
            this.lblImporte.Location = new System.Drawing.Point(213, 61);
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
            this.dtpFecha.Location = new System.Drawing.Point(124, 77);
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
            this.lblFechaComprobante.Location = new System.Drawing.Point(121, 61);
            this.lblFechaComprobante.Name = "lblFechaComprobante";
            this.lblFechaComprobante.Size = new System.Drawing.Size(77, 13);
            this.lblFechaComprobante.TabIndex = 15;
            this.lblFechaComprobante.Text = "Fecha Comp";
            // 
            // txtNroComprobante
            // 
            this.txtNroComprobante.Location = new System.Drawing.Point(6, 77);
            this.txtNroComprobante.MaxLength = 20;
            this.txtNroComprobante.Name = "txtNroComprobante";
            this.txtNroComprobante.Size = new System.Drawing.Size(102, 20);
            this.txtNroComprobante.TabIndex = 5;
            this.txtNroComprobante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNroComprobante_KeyDown);
            // 
            // lblNroComprobante
            // 
            this.lblNroComprobante.AutoSize = true;
            this.lblNroComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroComprobante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNroComprobante.Location = new System.Drawing.Point(3, 62);
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
            this.lblApellidoyNombres.Location = new System.Drawing.Point(56, 16);
            this.lblApellidoyNombres.Name = "lblApellidoyNombres";
            this.lblApellidoyNombres.Size = new System.Drawing.Size(115, 13);
            this.lblApellidoyNombres.TabIndex = 10;
            this.lblApellidoyNombres.Text = "Apellido y Nombres";
            // 
            // cmbTipoAnticipo
            // 
            this.cmbTipoAnticipo.FormattingEnabled = true;
            this.cmbTipoAnticipo.Location = new System.Drawing.Point(448, 31);
            this.cmbTipoAnticipo.Name = "cmbTipoAnticipo";
            this.cmbTipoAnticipo.Size = new System.Drawing.Size(124, 21);
            this.cmbTipoAnticipo.TabIndex = 4;
            this.cmbTipoAnticipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTipoAnticipo_KeyDown);
            // 
            // lblTipoAnticipo
            // 
            this.lblTipoAnticipo.AutoSize = true;
            this.lblTipoAnticipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAnticipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTipoAnticipo.Location = new System.Drawing.Point(448, 16);
            this.lblTipoAnticipo.Name = "lblTipoAnticipo";
            this.lblTipoAnticipo.Size = new System.Drawing.Size(104, 13);
            this.lblTipoAnticipo.TabIndex = 13;
            this.lblTipoAnticipo.Text = "Tipo de Anticipo:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(422, 299);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmABManticipos
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 332);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvAnticipos);
            this.Controls.Add(this.gbLegajo);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmABManticipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM de Anticipos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnticipos)).EndInit();
            this.gbLegajo.ResumeLayout(false);
            this.gbLegajo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvAnticipos;
        private System.Windows.Forms.GroupBox gbLegajo;
        private System.Windows.Forms.Label lblFechaComprobante;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblApellidoyNombres;
        private System.Windows.Forms.Label lblTipoAnticipo;
        private System.Windows.Forms.ComboBox cmbTipoAnticipo;
        private System.Windows.Forms.Label lblNroComprobante;
        private System.Windows.Forms.TextBox txtNroComprobante;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.ComboBox cmbMeses;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox cmbAnios;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Button btnImprimir;
    }
}