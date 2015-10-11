/*  
    frmAsistencia.cs

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
    partial class frmAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsistencia));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.flp15Dias = new System.Windows.Forms.FlowLayoutPanel();
            this.flpRestoDias = new System.Windows.Forms.FlowLayoutPanel();
            this.grpDias = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTarde = new System.Windows.Forms.Label();
            this.lblManana = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.grpEmpleados = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblApellidoyNombres = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.grpNovedades = new System.Windows.Forms.GroupBox();
            this.gbCodigo = new System.Windows.Forms.GroupBox();
            this.lblDescripcionCodigo = new System.Windows.Forms.Label();
            this.cmbNovedades = new System.Windows.Forms.ComboBox();
            this.gbTurnoHasta = new System.Windows.Forms.GroupBox();
            this.rbtMananaHasta = new System.Windows.Forms.RadioButton();
            this.rbtTardeHasta = new System.Windows.Forms.RadioButton();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.gbTurnoDesde = new System.Windows.Forms.GroupBox();
            this.rbtMananaDesde = new System.Windows.Forms.RadioButton();
            this.rbtTardeDesde = new System.Windows.Forms.RadioButton();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.grpDias.SuspendLayout();
            this.grpEmpleados.SuspendLayout();
            this.grpNovedades.SuspendLayout();
            this.gbCodigo.SuspendLayout();
            this.gbTurnoHasta.SuspendLayout();
            this.gbTurnoDesde.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(704, 392);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(81, 24);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // flp15Dias
            // 
            this.flp15Dias.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp15Dias.Location = new System.Drawing.Point(57, 19);
            this.flp15Dias.Name = "flp15Dias";
            this.flp15Dias.Size = new System.Drawing.Size(704, 75);
            this.flp15Dias.TabIndex = 1;
            this.flp15Dias.Paint += new System.Windows.Forms.PaintEventHandler(this.flp15Dias_Paint);
            // 
            // flpRestoDias
            // 
            this.flpRestoDias.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpRestoDias.Location = new System.Drawing.Point(57, 114);
            this.flpRestoDias.Name = "flpRestoDias";
            this.flpRestoDias.Size = new System.Drawing.Size(733, 75);
            this.flpRestoDias.TabIndex = 2;
            // 
            // grpDias
            // 
            this.grpDias.Controls.Add(this.label1);
            this.grpDias.Controls.Add(this.label2);
            this.grpDias.Controls.Add(this.lblTarde);
            this.grpDias.Controls.Add(this.lblManana);
            this.grpDias.Controls.Add(this.flp15Dias);
            this.grpDias.Controls.Add(this.flpRestoDias);
            this.grpDias.Location = new System.Drawing.Point(1, 101);
            this.grpDias.Name = "grpDias";
            this.grpDias.Size = new System.Drawing.Size(795, 195);
            this.grpDias.TabIndex = 3;
            this.grpDias.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(2, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tarde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(3, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mañana:";
            // 
            // lblTarde
            // 
            this.lblTarde.AutoSize = true;
            this.lblTarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTarde.Location = new System.Drawing.Point(2, 69);
            this.lblTarde.Name = "lblTarde";
            this.lblTarde.Size = new System.Drawing.Size(44, 13);
            this.lblTarde.TabIndex = 4;
            this.lblTarde.Text = "Tarde:";
            // 
            // lblManana
            // 
            this.lblManana.AutoSize = true;
            this.lblManana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblManana.Location = new System.Drawing.Point(3, 44);
            this.lblManana.Name = "lblManana";
            this.lblManana.Size = new System.Drawing.Size(56, 13);
            this.lblManana.TabIndex = 3;
            this.lblManana.Text = "Mañana:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(63, 28);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(91, 20);
            this.dtpFecha.TabIndex = 0;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // grpEmpleados
            // 
            this.grpEmpleados.Controls.Add(this.btnConsultar);
            this.grpEmpleados.Controls.Add(this.lblApellidoyNombres);
            this.grpEmpleados.Controls.Add(this.lblLegajo);
            this.grpEmpleados.Controls.Add(this.cmbEmpleados);
            this.grpEmpleados.Controls.Add(this.txtLegajo);
            this.grpEmpleados.Controls.Add(this.lblFecha);
            this.grpEmpleados.Controls.Add(this.dtpFecha);
            this.grpEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmpleados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpEmpleados.Location = new System.Drawing.Point(1, 16);
            this.grpEmpleados.Name = "grpEmpleados";
            this.grpEmpleados.Size = new System.Drawing.Size(795, 70);
            this.grpEmpleados.TabIndex = 5;
            this.grpEmpleados.TabStop = false;
            this.grpEmpleados.Enter += new System.EventHandler(this.grpEmpleados_Enter);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(699, 30);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(81, 19);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblApellidoyNombres
            // 
            this.lblApellidoyNombres.AutoSize = true;
            this.lblApellidoyNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoyNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblApellidoyNombres.Location = new System.Drawing.Point(287, 31);
            this.lblApellidoyNombres.Name = "lblApellidoyNombres";
            this.lblApellidoyNombres.Size = new System.Drawing.Size(119, 13);
            this.lblApellidoyNombres.TabIndex = 9;
            this.lblApellidoyNombres.Text = "Apellido y Nombres:";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLegajo.Location = new System.Drawing.Point(178, 31);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(49, 13);
            this.lblLegajo.TabIndex = 8;
            this.lblLegajo.Text = "Legajo:";
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(412, 29);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(275, 21);
            this.cmbEmpleados.TabIndex = 7;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(233, 29);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(46, 20);
            this.txtLegajo.TabIndex = 6;
            this.txtLegajo.TextChanged += new System.EventHandler(this.txtLegajo_TextChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFecha.Location = new System.Drawing.Point(12, 32);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha:";
            // 
            // grpNovedades
            // 
            this.grpNovedades.Controls.Add(this.gbCodigo);
            this.grpNovedades.Controls.Add(this.gbTurnoHasta);
            this.grpNovedades.Controls.Add(this.gbTurnoDesde);
            this.grpNovedades.Controls.Add(this.btnGrabar);
            this.grpNovedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNovedades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpNovedades.Location = new System.Drawing.Point(1, 302);
            this.grpNovedades.Name = "grpNovedades";
            this.grpNovedades.Size = new System.Drawing.Size(635, 114);
            this.grpNovedades.TabIndex = 6;
            this.grpNovedades.TabStop = false;
            this.grpNovedades.Text = "Selección";
            // 
            // gbCodigo
            // 
            this.gbCodigo.Controls.Add(this.lblDescripcionCodigo);
            this.gbCodigo.Controls.Add(this.cmbNovedades);
            this.gbCodigo.Location = new System.Drawing.Point(308, 24);
            this.gbCodigo.Name = "gbCodigo";
            this.gbCodigo.Size = new System.Drawing.Size(291, 50);
            this.gbCodigo.TabIndex = 18;
            this.gbCodigo.TabStop = false;
            this.gbCodigo.Text = "Codigo";
            // 
            // lblDescripcionCodigo
            // 
            this.lblDescripcionCodigo.AutoSize = true;
            this.lblDescripcionCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCodigo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescripcionCodigo.Location = new System.Drawing.Point(87, 24);
            this.lblDescripcionCodigo.Name = "lblDescripcionCodigo";
            this.lblDescripcionCodigo.Size = new System.Drawing.Size(35, 13);
            this.lblDescripcionCodigo.TabIndex = 1;
            this.lblDescripcionCodigo.Text = "label3";
            // 
            // cmbNovedades
            // 
            this.cmbNovedades.FormattingEnabled = true;
            this.cmbNovedades.Location = new System.Drawing.Point(18, 21);
            this.cmbNovedades.Name = "cmbNovedades";
            this.cmbNovedades.Size = new System.Drawing.Size(63, 21);
            this.cmbNovedades.TabIndex = 0;
            this.cmbNovedades.SelectedIndexChanged += new System.EventHandler(this.cmbNovedades_SelectedIndexChanged);
            // 
            // gbTurnoHasta
            // 
            this.gbTurnoHasta.Controls.Add(this.rbtMananaHasta);
            this.gbTurnoHasta.Controls.Add(this.rbtTardeHasta);
            this.gbTurnoHasta.Controls.Add(this.dtpHasta);
            this.gbTurnoHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTurnoHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbTurnoHasta.Location = new System.Drawing.Point(157, 24);
            this.gbTurnoHasta.Name = "gbTurnoHasta";
            this.gbTurnoHasta.Size = new System.Drawing.Size(135, 75);
            this.gbTurnoHasta.TabIndex = 17;
            this.gbTurnoHasta.TabStop = false;
            this.gbTurnoHasta.Text = "Hasta";
            // 
            // rbtMananaHasta
            // 
            this.rbtMananaHasta.AutoSize = true;
            this.rbtMananaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMananaHasta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtMananaHasta.Location = new System.Drawing.Point(6, 26);
            this.rbtMananaHasta.Name = "rbtMananaHasta";
            this.rbtMananaHasta.Size = new System.Drawing.Size(64, 17);
            this.rbtMananaHasta.TabIndex = 15;
            this.rbtMananaHasta.TabStop = true;
            this.rbtMananaHasta.Text = "Mañana";
            this.rbtMananaHasta.UseVisualStyleBackColor = true;
            this.rbtMananaHasta.CheckedChanged += new System.EventHandler(this.rbtMananaHasta_CheckedChanged);
            // 
            // rbtTardeHasta
            // 
            this.rbtTardeHasta.AutoSize = true;
            this.rbtTardeHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTardeHasta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtTardeHasta.Location = new System.Drawing.Point(72, 26);
            this.rbtTardeHasta.Name = "rbtTardeHasta";
            this.rbtTardeHasta.Size = new System.Drawing.Size(53, 17);
            this.rbtTardeHasta.TabIndex = 14;
            this.rbtTardeHasta.TabStop = true;
            this.rbtTardeHasta.Text = "Tarde";
            this.rbtTardeHasta.UseVisualStyleBackColor = true;
            this.rbtTardeHasta.CheckedChanged += new System.EventHandler(this.rbtTardeHasta_CheckedChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(24, 49);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(91, 20);
            this.dtpHasta.TabIndex = 13;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // gbTurnoDesde
            // 
            this.gbTurnoDesde.Controls.Add(this.rbtMananaDesde);
            this.gbTurnoDesde.Controls.Add(this.rbtTardeDesde);
            this.gbTurnoDesde.Controls.Add(this.dtpDesde);
            this.gbTurnoDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTurnoDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbTurnoDesde.Location = new System.Drawing.Point(10, 24);
            this.gbTurnoDesde.Name = "gbTurnoDesde";
            this.gbTurnoDesde.Size = new System.Drawing.Size(135, 75);
            this.gbTurnoDesde.TabIndex = 16;
            this.gbTurnoDesde.TabStop = false;
            this.gbTurnoDesde.Text = "Desde";
            // 
            // rbtMananaDesde
            // 
            this.rbtMananaDesde.AutoSize = true;
            this.rbtMananaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMananaDesde.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtMananaDesde.Location = new System.Drawing.Point(6, 26);
            this.rbtMananaDesde.Name = "rbtMananaDesde";
            this.rbtMananaDesde.Size = new System.Drawing.Size(64, 17);
            this.rbtMananaDesde.TabIndex = 15;
            this.rbtMananaDesde.TabStop = true;
            this.rbtMananaDesde.Text = "Mañana";
            this.rbtMananaDesde.UseVisualStyleBackColor = true;
            this.rbtMananaDesde.CheckedChanged += new System.EventHandler(this.rbtMananaDesde_CheckedChanged);
            // 
            // rbtTardeDesde
            // 
            this.rbtTardeDesde.AutoSize = true;
            this.rbtTardeDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTardeDesde.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtTardeDesde.Location = new System.Drawing.Point(76, 26);
            this.rbtTardeDesde.Name = "rbtTardeDesde";
            this.rbtTardeDesde.Size = new System.Drawing.Size(53, 17);
            this.rbtTardeDesde.TabIndex = 14;
            this.rbtTardeDesde.TabStop = true;
            this.rbtTardeDesde.Text = "Tarde";
            this.rbtTardeDesde.UseVisualStyleBackColor = true;
            this.rbtTardeDesde.CheckedChanged += new System.EventHandler(this.rbtTardeDesde_CheckedChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(20, 49);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(91, 20);
            this.dtpDesde.TabIndex = 12;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGrabar.Location = new System.Drawing.Point(429, 80);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(58, 19);
            this.btnGrabar.TabIndex = 11;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // frmAsistencia
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 428);
            this.Controls.Add(this.grpNovedades);
            this.Controls.Add(this.grpEmpleados);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.grpDias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novedades de Asistencia";
            this.Load += new System.EventHandler(this.frmAsistencia_Load);
            this.grpDias.ResumeLayout(false);
            this.grpDias.PerformLayout();
            this.grpEmpleados.ResumeLayout(false);
            this.grpEmpleados.PerformLayout();
            this.grpNovedades.ResumeLayout(false);
            this.gbCodigo.ResumeLayout(false);
            this.gbCodigo.PerformLayout();
            this.gbTurnoHasta.ResumeLayout(false);
            this.gbTurnoHasta.PerformLayout();
            this.gbTurnoDesde.ResumeLayout(false);
            this.gbTurnoDesde.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.FlowLayoutPanel flp15Dias;
        private System.Windows.Forms.FlowLayoutPanel flpRestoDias;
        private System.Windows.Forms.GroupBox grpDias;
        private System.Windows.Forms.Label lblManana;
        private System.Windows.Forms.Label lblTarde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpEmpleados;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblApellidoyNombres;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox grpNovedades;
        private System.Windows.Forms.ComboBox cmbNovedades;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.RadioButton rbtMananaDesde;
        private System.Windows.Forms.RadioButton rbtTardeDesde;
        private System.Windows.Forms.GroupBox gbTurnoDesde;
        private System.Windows.Forms.GroupBox gbTurnoHasta;
        private System.Windows.Forms.RadioButton rbtMananaHasta;
        private System.Windows.Forms.RadioButton rbtTardeHasta;
        private System.Windows.Forms.GroupBox gbCodigo;
        private System.Windows.Forms.Label lblDescripcionCodigo;
    }
}