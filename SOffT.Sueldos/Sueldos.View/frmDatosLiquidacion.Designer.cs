/*  
    frmDatosLiquidacion.cs

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
    partial class frmDatosLiquidacion
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblFechaLiquidacion = new System.Windows.Forms.Label();
            this.dtpFechaLiquidacion = new System.Windows.Forms.DateTimePicker();
            this.liquidacionDetalleEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.cmbAnios = new System.Windows.Forms.ComboBox();
            this.cmbMeses = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPeriodoLiquidado = new System.Windows.Forms.Label();
            this.txtPeriodoLiquidado = new System.Windows.Forms.TextBox();
            this.lblLugarDePago = new System.Windows.Forms.Label();
            this.txtLugarDePago = new System.Windows.Forms.TextBox();
            this.dtpFechaDePago = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDepositado = new System.Windows.Forms.Label();
            this.dtpFechaDepositado = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodoDepositado = new System.Windows.Forms.Label();
            this.txtPeriodoDepositado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.gbLiquidacion = new System.Windows.Forms.GroupBox();
            this.lblBancoDepositado = new System.Windows.Forms.Label();
            this.txtBancoDepositado = new System.Windows.Forms.TextBox();
            this.gbLiquidacion1 = new System.Windows.Forms.GroupBox();
            this.cmbTipoSalario = new System.Windows.Forms.ComboBox();
            this.lblTipoSalario = new System.Windows.Forms.Label();
            this.lblAplicacion = new System.Windows.Forms.Label();
            this.cmbAplicacion = new System.Windows.Forms.ComboBox();
            this.gbLiquidacion2 = new System.Windows.Forms.GroupBox();
            this.lstFechasDePago = new System.Windows.Forms.ListBox();
            this.gbTipoLiquidacion = new System.Windows.Forms.GroupBox();
            this.chkRecibosSeparados = new System.Windows.Forms.CheckBox();
            this.lstTiposLiquidaciones = new System.Windows.Forms.ListBox();
            this.gbFechasDePago = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionDetalleEntityBindingSource)).BeginInit();
            this.gbLiquidacion.SuspendLayout();
            this.gbLiquidacion1.SuspendLayout();
            this.gbLiquidacion2.SuspendLayout();
            this.gbTipoLiquidacion.SuspendLayout();
            this.gbFechasDePago.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(304, 431);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(107, 27);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblFechaLiquidacion
            // 
            this.lblFechaLiquidacion.AutoSize = true;
            this.lblFechaLiquidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaLiquidacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFechaLiquidacion.Location = new System.Drawing.Point(13, 117);
            this.lblFechaLiquidacion.Name = "lblFechaLiquidacion";
            this.lblFechaLiquidacion.Size = new System.Drawing.Size(115, 13);
            this.lblFechaLiquidacion.TabIndex = 11;
            this.lblFechaLiquidacion.Text = "Fecha Liquidación:";
            // 
            // dtpFechaLiquidacion
            // 
            this.dtpFechaLiquidacion.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.liquidacionDetalleEntityBindingSource, "FechaLiquidacion", true));
            this.dtpFechaLiquidacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLiquidacion.Location = new System.Drawing.Point(144, 117);
            this.dtpFechaLiquidacion.Name = "dtpFechaLiquidacion";
            this.dtpFechaLiquidacion.Size = new System.Drawing.Size(87, 20);
            this.dtpFechaLiquidacion.TabIndex = 10;
            this.dtpFechaLiquidacion.ValueChanged += new System.EventHandler(this.dtpFechaLiquidacion_ValueChanged);
            // 
            // liquidacionDetalleEntityBindingSource
            // 
            this.liquidacionDetalleEntityBindingSource.DataSource = typeof(Sueldos.Entidades.LiquidacionDetalleEntity);
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAnio.Location = new System.Drawing.Point(13, 27);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(33, 13);
            this.lblAnio.TabIndex = 13;
            this.lblAnio.Text = "Año:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMes.Location = new System.Drawing.Point(141, 27);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(34, 13);
            this.lblMes.TabIndex = 15;
            this.lblMes.Text = "Mes:";
            // 
            // cmbAnios
            // 
            this.cmbAnios.FormattingEnabled = true;
            this.cmbAnios.Location = new System.Drawing.Point(52, 24);
            this.cmbAnios.Name = "cmbAnios";
            this.cmbAnios.Size = new System.Drawing.Size(77, 21);
            this.cmbAnios.TabIndex = 16;
            this.cmbAnios.SelectedIndexChanged += new System.EventHandler(this.cmbAnios_SelectedIndexChanged);
            // 
            // cmbMeses
            // 
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Location = new System.Drawing.Point(181, 24);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(133, 21);
            this.cmbMeses.TabIndex = 17;
            this.cmbMeses.SelectedIndexChanged += new System.EventHandler(this.cmbMeses_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.liquidacionDetalleEntityBindingSource, "Descripcion", true));
            this.txtDescripcion.Location = new System.Drawing.Point(97, 59);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(284, 20);
            this.txtDescripcion.TabIndex = 18;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDescripcion.Location = new System.Drawing.Point(13, 62);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(78, 13);
            this.lblDescripcion.TabIndex = 19;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblPeriodoLiquidado
            // 
            this.lblPeriodoLiquidado.AutoSize = true;
            this.lblPeriodoLiquidado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodoLiquidado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPeriodoLiquidado.Location = new System.Drawing.Point(13, 91);
            this.lblPeriodoLiquidado.Name = "lblPeriodoLiquidado";
            this.lblPeriodoLiquidado.Size = new System.Drawing.Size(115, 13);
            this.lblPeriodoLiquidado.TabIndex = 21;
            this.lblPeriodoLiquidado.Text = "Período Liquidado:";
            // 
            // txtPeriodoLiquidado
            // 
            this.txtPeriodoLiquidado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.liquidacionDetalleEntityBindingSource, "PeriodoLiquidado", true));
            this.txtPeriodoLiquidado.Location = new System.Drawing.Point(125, 91);
            this.txtPeriodoLiquidado.Name = "txtPeriodoLiquidado";
            this.txtPeriodoLiquidado.Size = new System.Drawing.Size(153, 20);
            this.txtPeriodoLiquidado.TabIndex = 20;
            this.txtPeriodoLiquidado.TextChanged += new System.EventHandler(this.txtPeriodoLiquidado_TextChanged);
            // 
            // lblLugarDePago
            // 
            this.lblLugarDePago.AutoSize = true;
            this.lblLugarDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarDePago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLugarDePago.Location = new System.Drawing.Point(12, 34);
            this.lblLugarDePago.Name = "lblLugarDePago";
            this.lblLugarDePago.Size = new System.Drawing.Size(94, 13);
            this.lblLugarDePago.TabIndex = 23;
            this.lblLugarDePago.Text = "Lugar de Pago:";
            // 
            // txtLugarDePago
            // 
            this.txtLugarDePago.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.liquidacionDetalleEntityBindingSource, "LugarDePago", true));
            this.txtLugarDePago.Location = new System.Drawing.Point(141, 34);
            this.txtLugarDePago.Name = "txtLugarDePago";
            this.txtLugarDePago.Size = new System.Drawing.Size(153, 20);
            this.txtLugarDePago.TabIndex = 22;
            this.txtLugarDePago.TextChanged += new System.EventHandler(this.txtLugarDePago_TextChanged);
            // 
            // dtpFechaDePago
            // 
            this.dtpFechaDePago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDePago.Location = new System.Drawing.Point(6, 35);
            this.dtpFechaDePago.Name = "dtpFechaDePago";
            this.dtpFechaDePago.Size = new System.Drawing.Size(106, 20);
            this.dtpFechaDePago.TabIndex = 24;
            this.dtpFechaDePago.ValueChanged += new System.EventHandler(this.dtpFechaDePago_ValueChanged);
            // 
            // lblFechaDepositado
            // 
            this.lblFechaDepositado.AutoSize = true;
            this.lblFechaDepositado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDepositado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFechaDepositado.Location = new System.Drawing.Point(12, 116);
            this.lblFechaDepositado.Name = "lblFechaDepositado";
            this.lblFechaDepositado.Size = new System.Drawing.Size(114, 13);
            this.lblFechaDepositado.TabIndex = 29;
            this.lblFechaDepositado.Text = "Fecha Depositado:";
            // 
            // dtpFechaDepositado
            // 
            this.dtpFechaDepositado.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.liquidacionDetalleEntityBindingSource, "FechaDepositado", true));
            this.dtpFechaDepositado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDepositado.Location = new System.Drawing.Point(142, 116);
            this.dtpFechaDepositado.Name = "dtpFechaDepositado";
            this.dtpFechaDepositado.Size = new System.Drawing.Size(87, 20);
            this.dtpFechaDepositado.TabIndex = 28;
            this.dtpFechaDepositado.ValueChanged += new System.EventHandler(this.dtpFechaDepositado_ValueChanged);
            // 
            // lblPeriodoDepositado
            // 
            this.lblPeriodoDepositado.AutoSize = true;
            this.lblPeriodoDepositado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodoDepositado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPeriodoDepositado.Location = new System.Drawing.Point(12, 63);
            this.lblPeriodoDepositado.Name = "lblPeriodoDepositado";
            this.lblPeriodoDepositado.Size = new System.Drawing.Size(124, 13);
            this.lblPeriodoDepositado.TabIndex = 27;
            this.lblPeriodoDepositado.Text = "Período Depositado:";
            // 
            // txtPeriodoDepositado
            // 
            this.txtPeriodoDepositado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.liquidacionDetalleEntityBindingSource, "PeriodoDepositado", true));
            this.txtPeriodoDepositado.Location = new System.Drawing.Point(141, 60);
            this.txtPeriodoDepositado.Name = "txtPeriodoDepositado";
            this.txtPeriodoDepositado.Size = new System.Drawing.Size(153, 20);
            this.txtPeriodoDepositado.TabIndex = 26;
            this.txtPeriodoDepositado.TextChanged += new System.EventHandler(this.txtPeriodoDepositado_TextChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblEstado.Location = new System.Drawing.Point(12, 142);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 13);
            this.lblEstado.TabIndex = 31;
            this.lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(76, 142);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(153, 21);
            this.cmbEstado.TabIndex = 30;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(166, 431);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(107, 27);
            this.btnGrabar.TabIndex = 32;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // gbLiquidacion
            // 
            this.gbLiquidacion.Controls.Add(this.cmbMeses);
            this.gbLiquidacion.Controls.Add(this.lblAnio);
            this.gbLiquidacion.Controls.Add(this.lblMes);
            this.gbLiquidacion.Controls.Add(this.cmbAnios);
            this.gbLiquidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLiquidacion.ForeColor = System.Drawing.Color.MediumBlue;
            this.gbLiquidacion.Location = new System.Drawing.Point(12, 12);
            this.gbLiquidacion.Name = "gbLiquidacion";
            this.gbLiquidacion.Size = new System.Drawing.Size(331, 60);
            this.gbLiquidacion.TabIndex = 33;
            this.gbLiquidacion.TabStop = false;
            this.gbLiquidacion.Text = "Liquidación";
            // 
            // lblBancoDepositado
            // 
            this.lblBancoDepositado.AutoSize = true;
            this.lblBancoDepositado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBancoDepositado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBancoDepositado.Location = new System.Drawing.Point(12, 89);
            this.lblBancoDepositado.Name = "lblBancoDepositado";
            this.lblBancoDepositado.Size = new System.Drawing.Size(115, 13);
            this.lblBancoDepositado.TabIndex = 35;
            this.lblBancoDepositado.Text = "Banco Depositado:";
            // 
            // txtBancoDepositado
            // 
            this.txtBancoDepositado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.liquidacionDetalleEntityBindingSource, "BancoDepositado", true));
            this.txtBancoDepositado.Location = new System.Drawing.Point(141, 86);
            this.txtBancoDepositado.Name = "txtBancoDepositado";
            this.txtBancoDepositado.Size = new System.Drawing.Size(153, 20);
            this.txtBancoDepositado.TabIndex = 34;
            this.txtBancoDepositado.TextChanged += new System.EventHandler(this.txtBancoDepositado_TextChanged);
            // 
            // gbLiquidacion1
            // 
            this.gbLiquidacion1.Controls.Add(this.cmbTipoSalario);
            this.gbLiquidacion1.Controls.Add(this.lblTipoSalario);
            this.gbLiquidacion1.Controls.Add(this.lblAplicacion);
            this.gbLiquidacion1.Controls.Add(this.cmbAplicacion);
            this.gbLiquidacion1.Controls.Add(this.txtPeriodoLiquidado);
            this.gbLiquidacion1.Controls.Add(this.dtpFechaLiquidacion);
            this.gbLiquidacion1.Controls.Add(this.lblFechaLiquidacion);
            this.gbLiquidacion1.Controls.Add(this.txtDescripcion);
            this.gbLiquidacion1.Controls.Add(this.lblDescripcion);
            this.gbLiquidacion1.Controls.Add(this.lblPeriodoLiquidado);
            this.gbLiquidacion1.Location = new System.Drawing.Point(12, 78);
            this.gbLiquidacion1.Name = "gbLiquidacion1";
            this.gbLiquidacion1.Size = new System.Drawing.Size(399, 156);
            this.gbLiquidacion1.TabIndex = 36;
            this.gbLiquidacion1.TabStop = false;
            // 
            // cmbTipoSalario
            // 
            this.cmbTipoSalario.FormattingEnabled = true;
            this.cmbTipoSalario.Location = new System.Drawing.Point(182, 32);
            this.cmbTipoSalario.Name = "cmbTipoSalario";
            this.cmbTipoSalario.Size = new System.Drawing.Size(153, 21);
            this.cmbTipoSalario.TabIndex = 41;
            this.cmbTipoSalario.SelectedIndexChanged += new System.EventHandler(this.cmbTipoSalario_SelectedIndexChanged);
            // 
            // lblTipoSalario
            // 
            this.lblTipoSalario.AutoSize = true;
            this.lblTipoSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoSalario.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTipoSalario.Location = new System.Drawing.Point(179, 16);
            this.lblTipoSalario.Name = "lblTipoSalario";
            this.lblTipoSalario.Size = new System.Drawing.Size(97, 13);
            this.lblTipoSalario.TabIndex = 42;
            this.lblTipoSalario.Text = "Tipo de Salario:";
            // 
            // lblAplicacion
            // 
            this.lblAplicacion.AutoSize = true;
            this.lblAplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAplicacion.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblAplicacion.Location = new System.Drawing.Point(14, 16);
            this.lblAplicacion.Name = "lblAplicacion";
            this.lblAplicacion.Size = new System.Drawing.Size(70, 13);
            this.lblAplicacion.TabIndex = 40;
            this.lblAplicacion.Text = "Aplicación:";
            // 
            // cmbAplicacion
            // 
            this.cmbAplicacion.FormattingEnabled = true;
            this.cmbAplicacion.Location = new System.Drawing.Point(17, 32);
            this.cmbAplicacion.Name = "cmbAplicacion";
            this.cmbAplicacion.Size = new System.Drawing.Size(153, 21);
            this.cmbAplicacion.TabIndex = 39;
            this.cmbAplicacion.SelectedIndexChanged += new System.EventHandler(this.cmbAplicacion_SelectedIndexChanged);
            // 
            // gbLiquidacion2
            // 
            this.gbLiquidacion2.Controls.Add(this.txtLugarDePago);
            this.gbLiquidacion2.Controls.Add(this.lblBancoDepositado);
            this.gbLiquidacion2.Controls.Add(this.lblLugarDePago);
            this.gbLiquidacion2.Controls.Add(this.txtBancoDepositado);
            this.gbLiquidacion2.Controls.Add(this.txtPeriodoDepositado);
            this.gbLiquidacion2.Controls.Add(this.lblPeriodoDepositado);
            this.gbLiquidacion2.Controls.Add(this.lblEstado);
            this.gbLiquidacion2.Controls.Add(this.dtpFechaDepositado);
            this.gbLiquidacion2.Controls.Add(this.cmbEstado);
            this.gbLiquidacion2.Controls.Add(this.lblFechaDepositado);
            this.gbLiquidacion2.Location = new System.Drawing.Point(14, 240);
            this.gbLiquidacion2.Name = "gbLiquidacion2";
            this.gbLiquidacion2.Size = new System.Drawing.Size(312, 178);
            this.gbLiquidacion2.TabIndex = 37;
            this.gbLiquidacion2.TabStop = false;
            // 
            // lstFechasDePago
            // 
            this.lstFechasDePago.FormattingEnabled = true;
            this.lstFechasDePago.Location = new System.Drawing.Point(121, 35);
            this.lstFechasDePago.Name = "lstFechasDePago";
            this.lstFechasDePago.Size = new System.Drawing.Size(95, 121);
            this.lstFechasDePago.TabIndex = 36;
            this.lstFechasDePago.SelectedIndexChanged += new System.EventHandler(this.lstFechasDePago_SelectedIndexChanged);
            // 
            // gbTipoLiquidacion
            // 
            this.gbTipoLiquidacion.Controls.Add(this.chkRecibosSeparados);
            this.gbTipoLiquidacion.Controls.Add(this.lstTiposLiquidaciones);
            this.gbTipoLiquidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoLiquidacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbTipoLiquidacion.Location = new System.Drawing.Point(421, 12);
            this.gbTipoLiquidacion.Name = "gbTipoLiquidacion";
            this.gbTipoLiquidacion.Size = new System.Drawing.Size(160, 222);
            this.gbTipoLiquidacion.TabIndex = 38;
            this.gbTipoLiquidacion.TabStop = false;
            this.gbTipoLiquidacion.Text = "Tipo de Liquidación";
            // 
            // chkRecibosSeparados
            // 
            this.chkRecibosSeparados.AutoSize = true;
            this.chkRecibosSeparados.Checked = true;
            this.chkRecibosSeparados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecibosSeparados.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.liquidacionDetalleEntityBindingSource, "RecibosSeparados", true));
            this.chkRecibosSeparados.Location = new System.Drawing.Point(13, 195);
            this.chkRecibosSeparados.Name = "chkRecibosSeparados";
            this.chkRecibosSeparados.Size = new System.Drawing.Size(136, 17);
            this.chkRecibosSeparados.TabIndex = 1;
            this.chkRecibosSeparados.Text = "Recibos Separados";
            this.chkRecibosSeparados.UseVisualStyleBackColor = true;
            this.chkRecibosSeparados.CheckedChanged += new System.EventHandler(this.chkRecibosSeparados_CheckedChanged);
            // 
            // lstTiposLiquidaciones
            // 
            this.lstTiposLiquidaciones.FormattingEnabled = true;
            this.lstTiposLiquidaciones.Location = new System.Drawing.Point(13, 25);
            this.lstTiposLiquidaciones.Name = "lstTiposLiquidaciones";
            this.lstTiposLiquidaciones.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstTiposLiquidaciones.Size = new System.Drawing.Size(126, 160);
            this.lstTiposLiquidaciones.TabIndex = 0;
            this.lstTiposLiquidaciones.SelectedIndexChanged += new System.EventHandler(this.lstTiposLiquidaciones_SelectedIndexChanged);
            // 
            // gbFechasDePago
            // 
            this.gbFechasDePago.Controls.Add(this.btnEliminar);
            this.gbFechasDePago.Controls.Add(this.btnInsertar);
            this.gbFechasDePago.Controls.Add(this.lstFechasDePago);
            this.gbFechasDePago.Controls.Add(this.dtpFechaDePago);
            this.gbFechasDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFechasDePago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbFechasDePago.Location = new System.Drawing.Point(344, 240);
            this.gbFechasDePago.Name = "gbFechasDePago";
            this.gbFechasDePago.Size = new System.Drawing.Size(237, 178);
            this.gbFechasDePago.TabIndex = 39;
            this.gbFechasDePago.TabStop = false;
            this.gbFechasDePago.Text = "Fechas de Pago";
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(77, 106);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(35, 24);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.Text = "<--";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.ForeColor = System.Drawing.Color.Black;
            this.btnInsertar.Location = new System.Drawing.Point(77, 78);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(35, 24);
            this.btnInsertar.TabIndex = 37;
            this.btnInsertar.Text = "-->";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // frmDatosLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 470);
            this.Controls.Add(this.gbFechasDePago);
            this.Controls.Add(this.gbTipoLiquidacion);
            this.Controls.Add(this.gbLiquidacion2);
            this.Controls.Add(this.gbLiquidacion1);
            this.Controls.Add(this.gbLiquidacion);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCerrar);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDatosLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Liquidación";
            this.Load += new System.EventHandler(this.frmDatosLiquidacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionDetalleEntityBindingSource)).EndInit();
            this.gbLiquidacion.ResumeLayout(false);
            this.gbLiquidacion.PerformLayout();
            this.gbLiquidacion1.ResumeLayout(false);
            this.gbLiquidacion1.PerformLayout();
            this.gbLiquidacion2.ResumeLayout(false);
            this.gbLiquidacion2.PerformLayout();
            this.gbTipoLiquidacion.ResumeLayout(false);
            this.gbTipoLiquidacion.PerformLayout();
            this.gbFechasDePago.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblFechaLiquidacion;
        private System.Windows.Forms.DateTimePicker dtpFechaLiquidacion;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox cmbAnios;
        private System.Windows.Forms.ComboBox cmbMeses;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPeriodoLiquidado;
        private System.Windows.Forms.TextBox txtPeriodoLiquidado;
        private System.Windows.Forms.Label lblLugarDePago;
        private System.Windows.Forms.TextBox txtLugarDePago;
        private System.Windows.Forms.DateTimePicker dtpFechaDePago;
        private System.Windows.Forms.Label lblFechaDepositado;
        private System.Windows.Forms.DateTimePicker dtpFechaDepositado;
        private System.Windows.Forms.Label lblPeriodoDepositado;
        private System.Windows.Forms.TextBox txtPeriodoDepositado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.GroupBox gbLiquidacion;
        private System.Windows.Forms.Label lblBancoDepositado;
        private System.Windows.Forms.TextBox txtBancoDepositado;
        private System.Windows.Forms.GroupBox gbLiquidacion1;
        private System.Windows.Forms.GroupBox gbLiquidacion2;
        private System.Windows.Forms.ComboBox cmbTipoSalario;
        private System.Windows.Forms.Label lblTipoSalario;
        private System.Windows.Forms.Label lblAplicacion;
        private System.Windows.Forms.ComboBox cmbAplicacion;
        private System.Windows.Forms.GroupBox gbTipoLiquidacion;
        private System.Windows.Forms.ListBox lstTiposLiquidaciones;
        private System.Windows.Forms.CheckBox chkRecibosSeparados;
        private System.Windows.Forms.ListBox lstFechasDePago;
        private System.Windows.Forms.GroupBox gbFechasDePago;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.BindingSource liquidacionDetalleEntityBindingSource;
    }
}