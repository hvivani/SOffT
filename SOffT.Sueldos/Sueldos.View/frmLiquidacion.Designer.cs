/*  
    frmLiquidacion.cs

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
    partial class frmLiquidacion
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
            this.btnLiquidar = new System.Windows.Forms.Button();
            this.lblLegajoHasta = new System.Windows.Forms.Label();
            this.lblLegajoDesde = new System.Windows.Forms.Label();
            this.txtLegajoHasta = new System.Windows.Forms.TextBox();
            this.txtLegajoDesde = new System.Windows.Forms.TextBox();
            this.btnRecibos = new System.Windows.Forms.Button();
            this.pbProceso = new System.Windows.Forms.ProgressBar();
            this.gbProceso = new System.Windows.Forms.GroupBox();
            this.gbTiempo = new System.Windows.Forms.GroupBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtLegajoActual = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.txtHoraFin = new System.Windows.Forms.TextBox();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.cmbMeses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAnios = new System.Windows.Forms.ComboBox();
            this.lblAplicacion = new System.Windows.Forms.Label();
            this.cmbAplicacion = new System.Windows.Forms.ComboBox();
            this.lblTipoSalario = new System.Windows.Forms.Label();
            this.cmbTipoSalario = new System.Windows.Forms.ComboBox();
            this.gbLegajos = new System.Windows.Forms.GroupBox();
            this.gbSeleccionLiquidacion = new System.Windows.Forms.GroupBox();
            this.gbDatosLiq = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbLiquidacion = new System.Windows.Forms.ComboBox();
            this.btnDebug = new System.Windows.Forms.Button();
            this.chkBoxReliquidarTodos = new System.Windows.Forms.CheckBox();
            this.gbProceso.SuspendLayout();
            this.gbTiempo.SuspendLayout();
            this.gbLegajos.SuspendLayout();
            this.gbSeleccionLiquidacion.SuspendLayout();
            this.gbDatosLiq.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(456, 465);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLiquidar
            // 
            this.btnLiquidar.Location = new System.Drawing.Point(240, 465);
            this.btnLiquidar.Name = "btnLiquidar";
            this.btnLiquidar.Size = new System.Drawing.Size(75, 23);
            this.btnLiquidar.TabIndex = 7;
            this.btnLiquidar.Text = "&Liquidar";
            this.btnLiquidar.UseVisualStyleBackColor = true;
            this.btnLiquidar.Click += new System.EventHandler(this.btnLiquidar_Click);
            // 
            // lblLegajoHasta
            // 
            this.lblLegajoHasta.AutoSize = true;
            this.lblLegajoHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajoHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLegajoHasta.Location = new System.Drawing.Point(161, 22);
            this.lblLegajoHasta.Name = "lblLegajoHasta";
            this.lblLegajoHasta.Size = new System.Drawing.Size(44, 13);
            this.lblLegajoHasta.TabIndex = 11;
            this.lblLegajoHasta.Text = "Hasta:";
            // 
            // lblLegajoDesde
            // 
            this.lblLegajoDesde.AutoSize = true;
            this.lblLegajoDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajoDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLegajoDesde.Location = new System.Drawing.Point(48, 22);
            this.lblLegajoDesde.Name = "lblLegajoDesde";
            this.lblLegajoDesde.Size = new System.Drawing.Size(47, 13);
            this.lblLegajoDesde.TabIndex = 10;
            this.lblLegajoDesde.Text = "Desde:";
            // 
            // txtLegajoHasta
            // 
            this.txtLegajoHasta.Location = new System.Drawing.Point(205, 19);
            this.txtLegajoHasta.Name = "txtLegajoHasta";
            this.txtLegajoHasta.Size = new System.Drawing.Size(57, 20);
            this.txtLegajoHasta.TabIndex = 9;
            this.txtLegajoHasta.Text = "999999";
            this.txtLegajoHasta.TextChanged += new System.EventHandler(this.txtLegajoHasta_TextChanged);
            // 
            // txtLegajoDesde
            // 
            this.txtLegajoDesde.Location = new System.Drawing.Point(95, 19);
            this.txtLegajoDesde.Name = "txtLegajoDesde";
            this.txtLegajoDesde.Size = new System.Drawing.Size(43, 20);
            this.txtLegajoDesde.TabIndex = 8;
            this.txtLegajoDesde.Text = "1";
            this.txtLegajoDesde.TextChanged += new System.EventHandler(this.txtLegajoDesde_TextChanged);
            // 
            // btnRecibos
            // 
            this.btnRecibos.Location = new System.Drawing.Point(22, 465);
            this.btnRecibos.Name = "btnRecibos";
            this.btnRecibos.Size = new System.Drawing.Size(75, 23);
            this.btnRecibos.TabIndex = 12;
            this.btnRecibos.Text = "&Recibos";
            this.btnRecibos.UseVisualStyleBackColor = true;
            this.btnRecibos.Click += new System.EventHandler(this.btnRecibos_Click);
            // 
            // pbProceso
            // 
            this.pbProceso.Location = new System.Drawing.Point(26, 29);
            this.pbProceso.Name = "pbProceso";
            this.pbProceso.Size = new System.Drawing.Size(465, 24);
            this.pbProceso.TabIndex = 13;
            // 
            // gbProceso
            // 
            this.gbProceso.Controls.Add(this.pbProceso);
            this.gbProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbProceso.Location = new System.Drawing.Point(12, 286);
            this.gbProceso.Name = "gbProceso";
            this.gbProceso.Size = new System.Drawing.Size(519, 77);
            this.gbProceso.TabIndex = 14;
            this.gbProceso.TabStop = false;
            this.gbProceso.Text = "Proceso";
            // 
            // gbTiempo
            // 
            this.gbTiempo.Controls.Add(this.lblLegajo);
            this.gbTiempo.Controls.Add(this.txtLegajoActual);
            this.gbTiempo.Controls.Add(this.lblDuracion);
            this.gbTiempo.Controls.Add(this.txtDuracion);
            this.gbTiempo.Controls.Add(this.lblHoraFin);
            this.gbTiempo.Controls.Add(this.lblHoraInicio);
            this.gbTiempo.Controls.Add(this.txtHoraFin);
            this.gbTiempo.Controls.Add(this.txtHoraInicio);
            this.gbTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbTiempo.Location = new System.Drawing.Point(12, 369);
            this.gbTiempo.Name = "gbTiempo";
            this.gbTiempo.Size = new System.Drawing.Size(519, 81);
            this.gbTiempo.TabIndex = 15;
            this.gbTiempo.TabStop = false;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(212, 51);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(49, 13);
            this.lblLegajo.TabIndex = 16;
            this.lblLegajo.Text = "Legajo:";
            // 
            // txtLegajoActual
            // 
            this.txtLegajoActual.Enabled = false;
            this.txtLegajoActual.Location = new System.Drawing.Point(277, 48);
            this.txtLegajoActual.Name = "txtLegajoActual";
            this.txtLegajoActual.Size = new System.Drawing.Size(96, 20);
            this.txtLegajoActual.TabIndex = 15;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(24, 48);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(62, 13);
            this.lblDuracion.TabIndex = 14;
            this.lblDuracion.Text = "Duración:";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Enabled = false;
            this.txtDuracion.Location = new System.Drawing.Point(103, 45);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(96, 20);
            this.txtDuracion.TabIndex = 13;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(212, 22);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(59, 13);
            this.lblHoraFin.TabIndex = 12;
            this.lblHoraFin.Text = "Hora Fin:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(24, 22);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(73, 13);
            this.lblHoraInicio.TabIndex = 11;
            this.lblHoraInicio.Text = "Hora Inicio:";
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Enabled = false;
            this.txtHoraFin.Location = new System.Drawing.Point(277, 19);
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.Size = new System.Drawing.Size(96, 20);
            this.txtHoraFin.TabIndex = 1;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Enabled = false;
            this.txtHoraInicio.Location = new System.Drawing.Point(103, 19);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(96, 20);
            this.txtHoraInicio.TabIndex = 0;
            // 
            // cmbMeses
            // 
            this.cmbMeses.Enabled = false;
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Location = new System.Drawing.Point(105, 40);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(133, 21);
            this.cmbMeses.TabIndex = 17;
            this.cmbMeses.SelectedIndexChanged += new System.EventHandler(this.cmbMeses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(2, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Año:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(102, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mes:";
            // 
            // cmbAnios
            // 
            this.cmbAnios.Enabled = false;
            this.cmbAnios.FormattingEnabled = true;
            this.cmbAnios.Location = new System.Drawing.Point(4, 40);
            this.cmbAnios.Name = "cmbAnios";
            this.cmbAnios.Size = new System.Drawing.Size(77, 21);
            this.cmbAnios.TabIndex = 16;
            this.cmbAnios.SelectedIndexChanged += new System.EventHandler(this.cmbAnios_SelectedIndexChanged);
            // 
            // lblAplicacion
            // 
            this.lblAplicacion.AutoSize = true;
            this.lblAplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAplicacion.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblAplicacion.Location = new System.Drawing.Point(2, 75);
            this.lblAplicacion.Name = "lblAplicacion";
            this.lblAplicacion.Size = new System.Drawing.Size(70, 13);
            this.lblAplicacion.TabIndex = 36;
            this.lblAplicacion.Text = "Aplicación:";
            // 
            // cmbAplicacion
            // 
            this.cmbAplicacion.Enabled = false;
            this.cmbAplicacion.FormattingEnabled = true;
            this.cmbAplicacion.Location = new System.Drawing.Point(4, 91);
            this.cmbAplicacion.Name = "cmbAplicacion";
            this.cmbAplicacion.Size = new System.Drawing.Size(153, 21);
            this.cmbAplicacion.TabIndex = 35;
            this.cmbAplicacion.SelectedIndexChanged += new System.EventHandler(this.cmbAplicacion_SelectedIndexChanged);
            // 
            // lblTipoSalario
            // 
            this.lblTipoSalario.AutoSize = true;
            this.lblTipoSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoSalario.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTipoSalario.Location = new System.Drawing.Point(165, 75);
            this.lblTipoSalario.Name = "lblTipoSalario";
            this.lblTipoSalario.Size = new System.Drawing.Size(97, 13);
            this.lblTipoSalario.TabIndex = 38;
            this.lblTipoSalario.Text = "Tipo de Salario:";
            // 
            // cmbTipoSalario
            // 
            this.cmbTipoSalario.Enabled = false;
            this.cmbTipoSalario.FormattingEnabled = true;
            this.cmbTipoSalario.Location = new System.Drawing.Point(168, 91);
            this.cmbTipoSalario.Name = "cmbTipoSalario";
            this.cmbTipoSalario.Size = new System.Drawing.Size(153, 21);
            this.cmbTipoSalario.TabIndex = 37;
            this.cmbTipoSalario.SelectedIndexChanged += new System.EventHandler(this.cmbTipoSalario_SelectedIndexChanged);
            // 
            // gbLegajos
            // 
            this.gbLegajos.Controls.Add(this.txtLegajoHasta);
            this.gbLegajos.Controls.Add(this.txtLegajoDesde);
            this.gbLegajos.Controls.Add(this.lblLegajoDesde);
            this.gbLegajos.Controls.Add(this.lblLegajoHasta);
            this.gbLegajos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLegajos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbLegajos.Location = new System.Drawing.Point(12, 227);
            this.gbLegajos.Name = "gbLegajos";
            this.gbLegajos.Size = new System.Drawing.Size(316, 47);
            this.gbLegajos.TabIndex = 40;
            this.gbLegajos.TabStop = false;
            this.gbLegajos.Text = "Legajos";
            // 
            // gbSeleccionLiquidacion
            // 
            this.gbSeleccionLiquidacion.Controls.Add(this.gbDatosLiq);
            this.gbSeleccionLiquidacion.Controls.Add(this.lblDescripcion);
            this.gbSeleccionLiquidacion.Controls.Add(this.cmbLiquidacion);
            this.gbSeleccionLiquidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSeleccionLiquidacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbSeleccionLiquidacion.Location = new System.Drawing.Point(12, 12);
            this.gbSeleccionLiquidacion.Name = "gbSeleccionLiquidacion";
            this.gbSeleccionLiquidacion.Size = new System.Drawing.Size(519, 204);
            this.gbSeleccionLiquidacion.TabIndex = 41;
            this.gbSeleccionLiquidacion.TabStop = false;
            // 
            // gbDatosLiq
            // 
            this.gbDatosLiq.Controls.Add(this.lblAplicacion);
            this.gbDatosLiq.Controls.Add(this.cmbAnios);
            this.gbDatosLiq.Controls.Add(this.cmbTipoSalario);
            this.gbDatosLiq.Controls.Add(this.cmbAplicacion);
            this.gbDatosLiq.Controls.Add(this.lblTipoSalario);
            this.gbDatosLiq.Controls.Add(this.label2);
            this.gbDatosLiq.Controls.Add(this.cmbMeses);
            this.gbDatosLiq.Controls.Add(this.label1);
            this.gbDatosLiq.Location = new System.Drawing.Point(10, 56);
            this.gbDatosLiq.Name = "gbDatosLiq";
            this.gbDatosLiq.Size = new System.Drawing.Size(500, 137);
            this.gbDatosLiq.TabIndex = 40;
            this.gbDatosLiq.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDescripcion.Location = new System.Drawing.Point(7, 13);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(76, 13);
            this.lblDescripcion.TabIndex = 39;
            this.lblDescripcion.Text = "Liquidación:";
            this.lblDescripcion.Click += new System.EventHandler(this.lblDescripcion_Click);
            // 
            // cmbLiquidacion
            // 
            this.cmbLiquidacion.FormattingEnabled = true;
            this.cmbLiquidacion.Location = new System.Drawing.Point(10, 29);
            this.cmbLiquidacion.Name = "cmbLiquidacion";
            this.cmbLiquidacion.Size = new System.Drawing.Size(321, 21);
            this.cmbLiquidacion.TabIndex = 6;
            this.cmbLiquidacion.SelectedIndexChanged += new System.EventHandler(this.cmbLiquidacion_SelectedIndexChanged);
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(479, 244);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(52, 23);
            this.btnDebug.TabIndex = 42;
            this.btnDebug.Text = "&Debug";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // chkBoxReliquidarTodos
            // 
            this.chkBoxReliquidarTodos.AutoSize = true;
            this.chkBoxReliquidarTodos.Location = new System.Drawing.Point(352, 246);
            this.chkBoxReliquidarTodos.Name = "chkBoxReliquidarTodos";
            this.chkBoxReliquidarTodos.Size = new System.Drawing.Size(106, 17);
            this.chkBoxReliquidarTodos.TabIndex = 43;
            this.chkBoxReliquidarTodos.Text = "&Reliquidar Todos";
            this.chkBoxReliquidarTodos.UseVisualStyleBackColor = true;
            // 
            // frmLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 507);
            this.Controls.Add(this.chkBoxReliquidarTodos);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.gbSeleccionLiquidacion);
            this.Controls.Add(this.gbLegajos);
            this.Controls.Add(this.gbTiempo);
            this.Controls.Add(this.gbProceso);
            this.Controls.Add(this.btnRecibos);
            this.Controls.Add(this.btnLiquidar);
            this.Controls.Add(this.btnCerrar);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liquidacion";
            this.Load += new System.EventHandler(this.frmLiquidacion_Load);
            this.gbProceso.ResumeLayout(false);
            this.gbTiempo.ResumeLayout(false);
            this.gbTiempo.PerformLayout();
            this.gbLegajos.ResumeLayout(false);
            this.gbLegajos.PerformLayout();
            this.gbSeleccionLiquidacion.ResumeLayout(false);
            this.gbSeleccionLiquidacion.PerformLayout();
            this.gbDatosLiq.ResumeLayout(false);
            this.gbDatosLiq.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLiquidar;
        private System.Windows.Forms.Label lblLegajoHasta;
        private System.Windows.Forms.Label lblLegajoDesde;
        private System.Windows.Forms.TextBox txtLegajoHasta;
        private System.Windows.Forms.TextBox txtLegajoDesde;
        private System.Windows.Forms.Button btnRecibos;
        private System.Windows.Forms.ProgressBar pbProceso;
        private System.Windows.Forms.GroupBox gbProceso;
        private System.Windows.Forms.GroupBox gbTiempo;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.TextBox txtHoraFin;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajoActual;
        private System.Windows.Forms.ComboBox cmbMeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAnios;
        private System.Windows.Forms.Label lblAplicacion;
        private System.Windows.Forms.ComboBox cmbAplicacion;
        private System.Windows.Forms.Label lblTipoSalario;
        private System.Windows.Forms.ComboBox cmbTipoSalario;
        private System.Windows.Forms.GroupBox gbLegajos;
        private System.Windows.Forms.GroupBox gbSeleccionLiquidacion;
        private System.Windows.Forms.ComboBox cmbLiquidacion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.GroupBox gbDatosLiq;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.CheckBox chkBoxReliquidarTodos;
    }
}