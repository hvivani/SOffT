/*  
    frmABMConceptos.cs

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
    partial class frmABMConceptos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMConceptos));
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.lblFormula = new System.Windows.Forms.Label();
            this.dgvCalculo = new System.Windows.Forms.DataGridView();
            this.gbBotones = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.gbConcepto = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblOrdPro = new System.Windows.Forms.Label();
            this.txtOrdPro = new System.Windows.Forms.TextBox();
            this.gbFormulas = new System.Windows.Forms.GroupBox();
            this.gbPropiedades = new System.Windows.Forms.GroupBox();
            this.lblCuentaContable = new System.Windows.Forms.Label();
            this.cmbCuentaContable = new System.Windows.Forms.ComboBox();
            this.btnEdicionFomula = new System.Windows.Forms.Button();
            this.lblTipoLiquidacion = new System.Windows.Forms.Label();
            this.lblAplicacion = new System.Windows.Forms.Label();
            this.cmbTipoLiquidacion = new System.Windows.Forms.ComboBox();
            this.cmbAplicacion = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipoConcepto = new System.Windows.Forms.Label();
            this.chkDesactivado = new System.Windows.Forms.CheckBox();
            this.chkImprimeValorUnitario = new System.Windows.Forms.CheckBox();
            this.chkImprimeCantidad = new System.Windows.Forms.CheckBox();
            this.chkImprime = new System.Windows.Forms.CheckBox();
            this.cmbTablas = new System.Windows.Forms.ComboBox();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.gbFormula = new System.Windows.Forms.GroupBox();
            this.btnConsultarTablas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalculo)).BeginInit();
            this.gbBotones.SuspendLayout();
            this.gbConcepto.SuspendLayout();
            this.gbFormulas.SuspendLayout();
            this.gbPropiedades.SuspendLayout();
            this.gbFormula.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFormula
            // 
            this.txtFormula.Location = new System.Drawing.Point(7, 30);
            this.txtFormula.Multiline = true;
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(758, 58);
            this.txtFormula.TabIndex = 8;
            this.txtFormula.TextChanged += new System.EventHandler(this.txtFormula_TextChanged);
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFormula.Location = new System.Drawing.Point(6, 14);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(55, 13);
            this.lblFormula.TabIndex = 9;
            this.lblFormula.Text = "Formula:";
            // 
            // dgvCalculo
            // 
            this.dgvCalculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalculo.Location = new System.Drawing.Point(7, 10);
            this.dgvCalculo.Name = "dgvCalculo";
            this.dgvCalculo.Size = new System.Drawing.Size(760, 243);
            this.dgvCalculo.TabIndex = 17;
            this.dgvCalculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalculo_CellContentClick);
            // 
            // gbBotones
            // 
            this.gbBotones.Controls.Add(this.btnEliminar);
            this.gbBotones.Controls.Add(this.btnModificar);
            this.gbBotones.Controls.Add(this.btnCerrar);
            this.gbBotones.Controls.Add(this.btnCancelar);
            this.gbBotones.Controls.Add(this.btnAgregar);
            this.gbBotones.Controls.Add(this.btnGrabar);
            this.gbBotones.Location = new System.Drawing.Point(12, 514);
            this.gbBotones.Name = "gbBotones";
            this.gbBotones.Size = new System.Drawing.Size(774, 53);
            this.gbBotones.TabIndex = 18;
            this.gbBotones.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(108, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 24);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(298, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 24);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(676, 19);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(89, 24);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(393, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 24);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancela&r";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(13, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 24);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(203, 19);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(89, 24);
            this.btnGrabar.TabIndex = 11;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // gbConcepto
            // 
            this.gbConcepto.Controls.Add(this.lblDescripcion);
            this.gbConcepto.Controls.Add(this.txtDescripcion);
            this.gbConcepto.Controls.Add(this.lblCodigo);
            this.gbConcepto.Controls.Add(this.txtCodigo);
            this.gbConcepto.Controls.Add(this.lblOrdPro);
            this.gbConcepto.Controls.Add(this.txtOrdPro);
            this.gbConcepto.Location = new System.Drawing.Point(12, 53);
            this.gbConcepto.Name = "gbConcepto";
            this.gbConcepto.Size = new System.Drawing.Size(317, 88);
            this.gbConcepto.TabIndex = 19;
            this.gbConcepto.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDescripcion.Location = new System.Drawing.Point(9, 54);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(78, 13);
            this.lblDescripcion.TabIndex = 13;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(93, 54);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(212, 20);
            this.txtDescripcion.TabIndex = 12;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCodigo.Location = new System.Drawing.Point(153, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 13);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(205, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(43, 20);
            this.txtCodigo.TabIndex = 10;
            // 
            // lblOrdPro
            // 
            this.lblOrdPro.AutoSize = true;
            this.lblOrdPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdPro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblOrdPro.Location = new System.Drawing.Point(9, 25);
            this.lblOrdPro.Name = "lblOrdPro";
            this.lblOrdPro.Size = new System.Drawing.Size(95, 13);
            this.lblOrdPro.TabIndex = 9;
            this.lblOrdPro.Text = "Orden Proceso:";
            // 
            // txtOrdPro
            // 
            this.txtOrdPro.Location = new System.Drawing.Point(104, 22);
            this.txtOrdPro.Name = "txtOrdPro";
            this.txtOrdPro.Size = new System.Drawing.Size(43, 20);
            this.txtOrdPro.TabIndex = 8;
            // 
            // gbFormulas
            // 
            this.gbFormulas.Controls.Add(this.dgvCalculo);
            this.gbFormulas.Location = new System.Drawing.Point(12, 249);
            this.gbFormulas.Name = "gbFormulas";
            this.gbFormulas.Size = new System.Drawing.Size(776, 259);
            this.gbFormulas.TabIndex = 20;
            this.gbFormulas.TabStop = false;
            // 
            // gbPropiedades
            // 
            this.gbPropiedades.Controls.Add(this.lblCuentaContable);
            this.gbPropiedades.Controls.Add(this.cmbCuentaContable);
            this.gbPropiedades.Controls.Add(this.btnEdicionFomula);
            this.gbPropiedades.Controls.Add(this.lblTipoLiquidacion);
            this.gbPropiedades.Controls.Add(this.lblAplicacion);
            this.gbPropiedades.Controls.Add(this.cmbTipoLiquidacion);
            this.gbPropiedades.Controls.Add(this.cmbAplicacion);
            this.gbPropiedades.Controls.Add(this.cmbTipo);
            this.gbPropiedades.Controls.Add(this.lblTipoConcepto);
            this.gbPropiedades.Controls.Add(this.chkDesactivado);
            this.gbPropiedades.Controls.Add(this.chkImprimeValorUnitario);
            this.gbPropiedades.Controls.Add(this.chkImprimeCantidad);
            this.gbPropiedades.Controls.Add(this.chkImprime);
            this.gbPropiedades.Location = new System.Drawing.Point(378, 3);
            this.gbPropiedades.Name = "gbPropiedades";
            this.gbPropiedades.Size = new System.Drawing.Size(408, 146);
            this.gbPropiedades.TabIndex = 25;
            this.gbPropiedades.TabStop = false;
            // 
            // lblCuentaContable
            // 
            this.lblCuentaContable.AutoSize = true;
            this.lblCuentaContable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaContable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCuentaContable.Location = new System.Drawing.Point(203, 102);
            this.lblCuentaContable.Name = "lblCuentaContable";
            this.lblCuentaContable.Size = new System.Drawing.Size(105, 13);
            this.lblCuentaContable.TabIndex = 34;
            this.lblCuentaContable.Text = "Cuenta Contable:";
            // 
            // cmbCuentaContable
            // 
            this.cmbCuentaContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbCuentaContable.FormattingEnabled = true;
            this.cmbCuentaContable.Location = new System.Drawing.Point(206, 117);
            this.cmbCuentaContable.Name = "cmbCuentaContable";
            this.cmbCuentaContable.Size = new System.Drawing.Size(193, 21);
            this.cmbCuentaContable.TabIndex = 33;
            this.cmbCuentaContable.SelectedIndexChanged += new System.EventHandler(this.cmbCuentaContable_SelectedIndexChanged);
            // 
            // btnEdicionFomula
            // 
            this.btnEdicionFomula.Enabled = false;
            this.btnEdicionFomula.Location = new System.Drawing.Point(296, 23);
            this.btnEdicionFomula.Name = "btnEdicionFomula";
            this.btnEdicionFomula.Size = new System.Drawing.Size(103, 35);
            this.btnEdicionFomula.TabIndex = 10;
            this.btnEdicionFomula.Text = "Asistente de formula";
            this.btnEdicionFomula.UseVisualStyleBackColor = true;
            this.btnEdicionFomula.Visible = false;
            this.btnEdicionFomula.Click += new System.EventHandler(this.btnEdicionFomula_Click);
            // 
            // lblTipoLiquidacion
            // 
            this.lblTipoLiquidacion.AutoSize = true;
            this.lblTipoLiquidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoLiquidacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTipoLiquidacion.Location = new System.Drawing.Point(14, 102);
            this.lblTipoLiquidacion.Name = "lblTipoLiquidacion";
            this.lblTipoLiquidacion.Size = new System.Drawing.Size(105, 13);
            this.lblTipoLiquidacion.TabIndex = 30;
            this.lblTipoLiquidacion.Text = "Tipo Liquidación:";
            // 
            // lblAplicacion
            // 
            this.lblAplicacion.AutoSize = true;
            this.lblAplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAplicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAplicacion.Location = new System.Drawing.Point(203, 64);
            this.lblAplicacion.Name = "lblAplicacion";
            this.lblAplicacion.Size = new System.Drawing.Size(70, 13);
            this.lblAplicacion.TabIndex = 32;
            this.lblAplicacion.Text = "Aplicación:";
            // 
            // cmbTipoLiquidacion
            // 
            this.cmbTipoLiquidacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbTipoLiquidacion.FormattingEnabled = true;
            this.cmbTipoLiquidacion.Location = new System.Drawing.Point(17, 119);
            this.cmbTipoLiquidacion.Name = "cmbTipoLiquidacion";
            this.cmbTipoLiquidacion.Size = new System.Drawing.Size(153, 21);
            this.cmbTipoLiquidacion.TabIndex = 29;
            this.cmbTipoLiquidacion.SelectedIndexChanged += new System.EventHandler(this.cmbTipoLiquidacion_SelectedIndexChanged);
            // 
            // cmbAplicacion
            // 
            this.cmbAplicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbAplicacion.FormattingEnabled = true;
            this.cmbAplicacion.Location = new System.Drawing.Point(206, 80);
            this.cmbAplicacion.Name = "cmbAplicacion";
            this.cmbAplicacion.Size = new System.Drawing.Size(153, 21);
            this.cmbAplicacion.TabIndex = 31;
            this.cmbAplicacion.SelectedIndexChanged += new System.EventHandler(this.cmbAplicacion_SelectedIndexChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(17, 80);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(153, 21);
            this.cmbTipo.TabIndex = 29;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // lblTipoConcepto
            // 
            this.lblTipoConcepto.AutoSize = true;
            this.lblTipoConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConcepto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTipoConcepto.Location = new System.Drawing.Point(16, 64);
            this.lblTipoConcepto.Name = "lblTipoConcepto";
            this.lblTipoConcepto.Size = new System.Drawing.Size(112, 13);
            this.lblTipoConcepto.TabIndex = 30;
            this.lblTipoConcepto.Text = "Tipo de Concepto:";
            // 
            // chkDesactivado
            // 
            this.chkDesactivado.AutoSize = true;
            this.chkDesactivado.Location = new System.Drawing.Point(152, 39);
            this.chkDesactivado.Name = "chkDesactivado";
            this.chkDesactivado.Size = new System.Drawing.Size(84, 17);
            this.chkDesactivado.TabIndex = 28;
            this.chkDesactivado.Text = "Desactivado";
            this.chkDesactivado.UseVisualStyleBackColor = true;
            // 
            // chkImprimeValorUnitario
            // 
            this.chkImprimeValorUnitario.AutoSize = true;
            this.chkImprimeValorUnitario.Location = new System.Drawing.Point(152, 13);
            this.chkImprimeValorUnitario.Name = "chkImprimeValorUnitario";
            this.chkImprimeValorUnitario.Size = new System.Drawing.Size(126, 17);
            this.chkImprimeValorUnitario.TabIndex = 27;
            this.chkImprimeValorUnitario.Text = "Imprime Valor Unitario";
            this.chkImprimeValorUnitario.UseVisualStyleBackColor = true;
            // 
            // chkImprimeCantidad
            // 
            this.chkImprimeCantidad.AutoSize = true;
            this.chkImprimeCantidad.Location = new System.Drawing.Point(17, 39);
            this.chkImprimeCantidad.Name = "chkImprimeCantidad";
            this.chkImprimeCantidad.Size = new System.Drawing.Size(105, 17);
            this.chkImprimeCantidad.TabIndex = 26;
            this.chkImprimeCantidad.Text = "Imprime Cantidad";
            this.chkImprimeCantidad.UseVisualStyleBackColor = true;
            this.chkImprimeCantidad.CheckedChanged += new System.EventHandler(this.chkImprimeCantidad_CheckedChanged);
            // 
            // chkImprime
            // 
            this.chkImprime.AutoSize = true;
            this.chkImprime.Location = new System.Drawing.Point(17, 13);
            this.chkImprime.Name = "chkImprime";
            this.chkImprime.Size = new System.Drawing.Size(109, 17);
            this.chkImprime.TabIndex = 25;
            this.chkImprime.Text = "Imprime Concepto";
            this.chkImprime.UseVisualStyleBackColor = true;
            // 
            // cmbTablas
            // 
            this.cmbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(12, 26);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(153, 21);
            this.cmbTablas.TabIndex = 26;
            this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvenio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblConvenio.Location = new System.Drawing.Point(9, 10);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(64, 13);
            this.lblConvenio.TabIndex = 27;
            this.lblConvenio.Text = "Convenio:";
            // 
            // gbFormula
            // 
            this.gbFormula.Controls.Add(this.txtFormula);
            this.gbFormula.Controls.Add(this.lblFormula);
            this.gbFormula.Location = new System.Drawing.Point(12, 155);
            this.gbFormula.Name = "gbFormula";
            this.gbFormula.Size = new System.Drawing.Size(776, 98);
            this.gbFormula.TabIndex = 28;
            this.gbFormula.TabStop = false;
            this.gbFormula.Enter += new System.EventHandler(this.gbFormula_Enter);
            // 
            // btnConsultarTablas
            // 
            this.btnConsultarTablas.Location = new System.Drawing.Point(226, 24);
            this.btnConsultarTablas.Name = "btnConsultarTablas";
            this.btnConsultarTablas.Size = new System.Drawing.Size(103, 22);
            this.btnConsultarTablas.TabIndex = 33;
            this.btnConsultarTablas.Text = "Consulta&r Tablas";
            this.btnConsultarTablas.UseVisualStyleBackColor = true;
            this.btnConsultarTablas.Click += new System.EventHandler(this.btnConsultarTablas_Click);
            // 
            // frmABMConceptos
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 568);
            this.Controls.Add(this.gbFormula);
            this.Controls.Add(this.btnConsultarTablas);
            this.Controls.Add(this.cmbTablas);
            this.Controls.Add(this.lblConvenio);
            this.Controls.Add(this.gbPropiedades);
            this.Controls.Add(this.gbFormulas);
            this.Controls.Add(this.gbConcepto);
            this.Controls.Add(this.gbBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmABMConceptos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM de Conceptos";
            this.Load += new System.EventHandler(this.frmABMConceptos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalculo)).EndInit();
            this.gbBotones.ResumeLayout(false);
            this.gbConcepto.ResumeLayout(false);
            this.gbConcepto.PerformLayout();
            this.gbFormulas.ResumeLayout(false);
            this.gbPropiedades.ResumeLayout(false);
            this.gbPropiedades.PerformLayout();
            this.gbFormula.ResumeLayout(false);
            this.gbFormula.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.DataGridView dgvCalculo;
        private System.Windows.Forms.GroupBox gbBotones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.GroupBox gbConcepto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblOrdPro;
        private System.Windows.Forms.TextBox txtOrdPro;
        private System.Windows.Forms.GroupBox gbFormulas;
        private System.Windows.Forms.GroupBox gbPropiedades;
        private System.Windows.Forms.CheckBox chkDesactivado;
        private System.Windows.Forms.CheckBox chkImprimeValorUnitario;
        private System.Windows.Forms.CheckBox chkImprimeCantidad;
        private System.Windows.Forms.CheckBox chkImprime;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbTablas;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.GroupBox gbFormula;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipoConcepto;
        private System.Windows.Forms.ComboBox cmbTipoLiquidacion;
        private System.Windows.Forms.ComboBox cmbAplicacion;
        private System.Windows.Forms.Label lblTipoLiquidacion;
        private System.Windows.Forms.Label lblAplicacion;
        private System.Windows.Forms.Button btnEdicionFomula;
        private System.Windows.Forms.Button btnConsultarTablas;
        private System.Windows.Forms.Label lblCuentaContable;
        private System.Windows.Forms.ComboBox cmbCuentaContable;
    }
}