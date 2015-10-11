/*  
    frmABMnovedades.cs

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
    partial class frmABMnovedades
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMnovedades));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbDatosLiquidacion = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbLiquidacion = new System.Windows.Forms.ComboBox();
            this.gbDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.novedadEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbNovedad = new System.Windows.Forms.ComboBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblNovedad = new System.Windows.Forms.Label();
            this.lblApellidoyNombres = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.dgvNovedades = new System.Windows.Forms.DataGridView();
            this.gbConsultas = new System.Windows.Forms.GroupBox();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.rbPorNovedad = new System.Windows.Forms.RadioButton();
            this.rbPorLegajo = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbDatosLiquidacion.SuspendLayout();
            this.gbDatosEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.novedadEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNovedades)).BeginInit();
            this.gbConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(538, 386);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(89, 24);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbDatosLiquidacion
            // 
            this.gbDatosLiquidacion.Controls.Add(this.lblDescripcion);
            this.gbDatosLiquidacion.Controls.Add(this.cmbLiquidacion);
            this.gbDatosLiquidacion.Location = new System.Drawing.Point(12, 12);
            this.gbDatosLiquidacion.Name = "gbDatosLiquidacion";
            this.gbDatosLiquidacion.Size = new System.Drawing.Size(382, 68);
            this.gbDatosLiquidacion.TabIndex = 1;
            this.gbDatosLiquidacion.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDescripcion.Location = new System.Drawing.Point(8, 14);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(76, 13);
            this.lblDescripcion.TabIndex = 41;
            this.lblDescripcion.Text = "Liquidación:";
            // 
            // cmbLiquidacion
            // 
            this.cmbLiquidacion.FormattingEnabled = true;
            this.cmbLiquidacion.Location = new System.Drawing.Point(11, 30);
            this.cmbLiquidacion.Name = "cmbLiquidacion";
            this.cmbLiquidacion.Size = new System.Drawing.Size(321, 21);
            this.cmbLiquidacion.TabIndex = 40;
            this.cmbLiquidacion.SelectedIndexChanged += new System.EventHandler(this.cmbLiquidacion_SelectedIndexChanged);
            // 
            // gbDatosEmpleado
            // 
            this.gbDatosEmpleado.Controls.Add(this.cmbEmpleados);
            this.gbDatosEmpleado.Controls.Add(this.txtValor);
            this.gbDatosEmpleado.Controls.Add(this.cmbNovedad);
            this.gbDatosEmpleado.Controls.Add(this.txtLegajo);
            this.gbDatosEmpleado.Controls.Add(this.lblValor);
            this.gbDatosEmpleado.Controls.Add(this.lblNovedad);
            this.gbDatosEmpleado.Controls.Add(this.lblApellidoyNombres);
            this.gbDatosEmpleado.Controls.Add(this.lblLegajo);
            this.gbDatosEmpleado.Location = new System.Drawing.Point(12, 115);
            this.gbDatosEmpleado.Name = "gbDatosEmpleado";
            this.gbDatosEmpleado.Size = new System.Drawing.Size(615, 64);
            this.gbDatosEmpleado.TabIndex = 2;
            this.gbDatosEmpleado.TabStop = false;
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(68, 32);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(275, 21);
            this.cmbEmpleados.TabIndex = 9;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            // 
            // txtValor
            // 
            this.txtValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.novedadEntityBindingSource, "Valor", true));
            this.txtValor.Location = new System.Drawing.Point(557, 32);
            this.txtValor.MaxLength = 8;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(52, 20);
            this.txtValor.TabIndex = 8;
            // 
            // novedadEntityBindingSource
            // 
            this.novedadEntityBindingSource.DataSource = typeof(Sueldos.Entidades.NovedadEntity);
            // 
            // cmbNovedad
            // 
            this.cmbNovedad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.novedadEntityBindingSource, "Codigo", true));
            this.cmbNovedad.FormattingEnabled = true;
            this.cmbNovedad.Location = new System.Drawing.Point(349, 32);
            this.cmbNovedad.Name = "cmbNovedad";
            this.cmbNovedad.Size = new System.Drawing.Size(202, 21);
            this.cmbNovedad.TabIndex = 7;
            this.cmbNovedad.SelectedIndexChanged += new System.EventHandler(this.cmbNovedad_SelectedIndexChanged);
            // 
            // txtLegajo
            // 
            this.txtLegajo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.novedadEntityBindingSource, "Legajo", true));
            this.txtLegajo.Location = new System.Drawing.Point(11, 32);
            this.txtLegajo.MaxLength = 8;
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(47, 20);
            this.txtLegajo.TabIndex = 5;
            this.txtLegajo.TextChanged += new System.EventHandler(this.txtLegajo_TextChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblValor.Location = new System.Drawing.Point(554, 15);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(36, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor";
            // 
            // lblNovedad
            // 
            this.lblNovedad.AutoSize = true;
            this.lblNovedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNovedad.Location = new System.Drawing.Point(346, 16);
            this.lblNovedad.Name = "lblNovedad";
            this.lblNovedad.Size = new System.Drawing.Size(58, 13);
            this.lblNovedad.TabIndex = 3;
            this.lblNovedad.Text = "Novedad";
            // 
            // lblApellidoyNombres
            // 
            this.lblApellidoyNombres.AutoSize = true;
            this.lblApellidoyNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoyNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblApellidoyNombres.Location = new System.Drawing.Point(61, 16);
            this.lblApellidoyNombres.Name = "lblApellidoyNombres";
            this.lblApellidoyNombres.Size = new System.Drawing.Size(115, 13);
            this.lblApellidoyNombres.TabIndex = 2;
            this.lblApellidoyNombres.Text = "Apellido y Nombres";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLegajo.Location = new System.Drawing.Point(8, 16);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(45, 13);
            this.lblLegajo.TabIndex = 1;
            this.lblLegajo.Text = "Legajo";
            // 
            // dgvNovedades
            // 
            this.dgvNovedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNovedades.Location = new System.Drawing.Point(12, 185);
            this.dgvNovedades.Name = "dgvNovedades";
            this.dgvNovedades.Size = new System.Drawing.Size(615, 183);
            this.dgvNovedades.TabIndex = 3;
            // 
            // gbConsultas
            // 
            this.gbConsultas.Controls.Add(this.rbTodas);
            this.gbConsultas.Controls.Add(this.rbPorNovedad);
            this.gbConsultas.Controls.Add(this.rbPorLegajo);
            this.gbConsultas.Location = new System.Drawing.Point(511, 12);
            this.gbConsultas.Name = "gbConsultas";
            this.gbConsultas.Size = new System.Drawing.Size(116, 97);
            this.gbConsultas.TabIndex = 4;
            this.gbConsultas.TabStop = false;
            this.gbConsultas.Text = "Consultas";
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Location = new System.Drawing.Point(20, 66);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(55, 17);
            this.rbTodas.TabIndex = 2;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas";
            this.rbTodas.UseVisualStyleBackColor = true;
            this.rbTodas.CheckedChanged += new System.EventHandler(this.rbTodas_CheckedChanged);
            // 
            // rbPorNovedad
            // 
            this.rbPorNovedad.AutoSize = true;
            this.rbPorNovedad.Location = new System.Drawing.Point(20, 43);
            this.rbPorNovedad.Name = "rbPorNovedad";
            this.rbPorNovedad.Size = new System.Drawing.Size(88, 17);
            this.rbPorNovedad.TabIndex = 1;
            this.rbPorNovedad.TabStop = true;
            this.rbPorNovedad.Text = "Por Novedad";
            this.rbPorNovedad.UseVisualStyleBackColor = true;
            this.rbPorNovedad.CheckedChanged += new System.EventHandler(this.rbPorNovedad_CheckedChanged);
            // 
            // rbPorLegajo
            // 
            this.rbPorLegajo.AutoSize = true;
            this.rbPorLegajo.Location = new System.Drawing.Point(20, 20);
            this.rbPorLegajo.Name = "rbPorLegajo";
            this.rbPorLegajo.Size = new System.Drawing.Size(76, 17);
            this.rbPorLegajo.TabIndex = 0;
            this.rbPorLegajo.TabStop = true;
            this.rbPorLegajo.Text = "Por Legajo";
            this.rbPorLegajo.UseVisualStyleBackColor = true;
            this.rbPorLegajo.CheckedChanged += new System.EventHandler(this.rbPorLegajo_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 386);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 24);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(107, 386);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 24);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(202, 386);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(89, 24);
            this.btnGrabar.TabIndex = 7;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(297, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 24);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancela&r";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmABMnovedades
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 430);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbConsultas);
            this.Controls.Add(this.dgvNovedades);
            this.Controls.Add(this.gbDatosEmpleado);
            this.Controls.Add(this.gbDatosLiquidacion);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmABMnovedades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM de Novedades";
            this.Load += new System.EventHandler(this.frmABMnovedades_Load);
            this.gbDatosLiquidacion.ResumeLayout(false);
            this.gbDatosLiquidacion.PerformLayout();
            this.gbDatosEmpleado.ResumeLayout(false);
            this.gbDatosEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.novedadEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNovedades)).EndInit();
            this.gbConsultas.ResumeLayout(false);
            this.gbConsultas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbDatosLiquidacion;
        private System.Windows.Forms.GroupBox gbDatosEmpleado;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblNovedad;
        private System.Windows.Forms.Label lblApellidoyNombres;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cmbNovedad;
        private System.Windows.Forms.DataGridView dgvNovedades;
        private System.Windows.Forms.GroupBox gbConsultas;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.RadioButton rbPorNovedad;
        private System.Windows.Forms.RadioButton rbPorLegajo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbLiquidacion;
        private System.Windows.Forms.BindingSource novedadEntityBindingSource;
    }
}