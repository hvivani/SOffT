/*  
    frmDatosEmpleado.cs

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
    partial class frmDatosEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosEmpleado));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tabEmpleado = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.grpFoto = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.gbFechas = new System.Windows.Forms.GroupBox();
            this.dtpFechaReconocimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaReconocimiento = new System.Windows.Forms.Label();
            this.dtpFechaReIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaReIngreso = new System.Windows.Forms.Label();
            this.dtpFechaEgreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.cmbCausaEgreso = new System.Windows.Forms.ComboBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblFechaEgreso = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCausaEgreso = new System.Windows.Forms.Label();
            this.gbIdentificacion = new System.Windows.Forms.GroupBox();
            this.cmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.cmbCentroDeCosto = new System.Windows.Forms.ComboBox();
            this.lblCentroDeCosto = new System.Windows.Forms.Label();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.cmbAFJP = new System.Windows.Forms.ComboBox();
            this.lblAFJP = new System.Windows.Forms.Label();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.txtCUIL = new System.Windows.Forms.MaskedTextBox();
            this.lblCUIL = new System.Windows.Forms.Label();
            this.gbPersona = new System.Windows.Forms.GroupBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.lblTelefonoMensajes = new System.Windows.Forms.Label();
            this.txtTelefonoMensajes = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtApellidoyNombres = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblApellidoyNombres = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tabRemuneraciones = new System.Windows.Forms.TabPage();
            this.gbSalario = new System.Windows.Forms.GroupBox();
            this.lblSindicato = new System.Windows.Forms.Label();
            this.cmbSindicato = new System.Windows.Forms.ComboBox();
            this.cmbContrato = new System.Windows.Forms.ComboBox();
            this.lblContrato = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblTipoLiquidacion = new System.Windows.Forms.Label();
            this.txtSueldoOjornal = new System.Windows.Forms.TextBox();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.lblSueldooJornal = new System.Windows.Forms.Label();
            this.cmbObraSocial = new System.Windows.Forms.ComboBox();
            this.cmbTipoLiquidacion = new System.Windows.Forms.ComboBox();
            this.cmbConvenio = new System.Windows.Forms.ComboBox();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.gbOtrosCampos = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvCampos = new System.Windows.Forms.DataGridView();
            this.gbBanco = new System.Windows.Forms.GroupBox();
            this.cmbFormaDePago = new System.Windows.Forms.ComboBox();
            this.lblFormaDePago = new System.Windows.Forms.Label();
            this.lblNumeroCuenta = new System.Windows.Forms.Label();
            this.cmbSucursalesBanco = new System.Windows.Forms.ComboBox();
            this.lblSucursalBanco = new System.Windows.Forms.Label();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.tabSIJP = new System.Windows.Forms.TabPage();
            this.gbSIJP = new System.Windows.Forms.GroupBox();
            this.lblCodigoDeSiniestrado = new System.Windows.Forms.Label();
            this.cmbCodigoDeSiniestrado = new System.Windows.Forms.ComboBox();
            this.lblModalidadDeContratacion = new System.Windows.Forms.Label();
            this.cmbModalidadDeContratacion = new System.Windows.Forms.ComboBox();
            this.lblCodigoDeActividad = new System.Windows.Forms.Label();
            this.cmbCodigoDeActividad = new System.Windows.Forms.ComboBox();
            this.lblCodigoDeCondicion = new System.Windows.Forms.Label();
            this.cmbCodigoDeCondicion = new System.Windows.Forms.ComboBox();
            this.lblSituacionDeRevista = new System.Windows.Forms.Label();
            this.cmbSituacionDeRevista = new System.Windows.Forms.ComboBox();
            this.tabFamiliares = new System.Windows.Forms.TabPage();
            this.gbFamiliares = new System.Windows.Forms.GroupBox();
            this.btnEliminarFamiliar = new System.Windows.Forms.Button();
            this.btnNuevoFamiliar = new System.Windows.Forms.Button();
            this.btnModificarFamiliar = new System.Windows.Forms.Button();
            this.dgvFamiliares = new System.Windows.Forms.DataGridView();
            this.tabVacaciones = new System.Windows.Forms.TabPage();
            this.btnEliminarVacaciones = new System.Windows.Forms.Button();
            this.btnNuevoVacaciones = new System.Windows.Forms.Button();
            this.btnModificarVacaciones = new System.Windows.Forms.Button();
            this.dgvVacaciones = new System.Windows.Forms.DataGridView();
            this.tabAsistencia = new System.Windows.Forms.TabPage();
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.tabAnticipos = new System.Windows.Forms.TabPage();
            this.dgvAnticipos = new System.Windows.Forms.DataGridView();
            this.tabPeriodosTrabajados = new System.Windows.Forms.TabPage();
            this.gbPeriodosTrabajados = new System.Windows.Forms.GroupBox();
            this.btnModificarPeriodoTrabajado = new System.Windows.Forms.Button();
            this.btnEliminarPeriodoTrabajado = new System.Windows.Forms.Button();
            this.btnNuevoPeriodoTrabajado = new System.Windows.Forms.Button();
            this.dgvPeriodos = new System.Windows.Forms.DataGridView();
            this.tabHorarios = new System.Windows.Forms.TabPage();
            this.gbHorarios = new System.Windows.Forms.GroupBox();
            this.gbHorariosPredefinidos = new System.Windows.Forms.GroupBox();
            this.chkEliminaExistentes = new System.Windows.Forms.CheckBox();
            this.btnAplicarHorarioPredefinido = new System.Windows.Forms.Button();
            this.cmbHorariosPlantillas = new System.Windows.Forms.ComboBox();
            this.btnModificarHorario = new System.Windows.Forms.Button();
            this.btnEliminarHorario = new System.Windows.Forms.Button();
            this.btnNuevoHorario = new System.Windows.Forms.Button();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.tabOtrosDatos = new System.Windows.Forms.TabPage();
            this.lblLegajoConyuge = new System.Windows.Forms.Label();
            this.txtLegajoConyuge = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.openFileDialogFoto = new System.Windows.Forms.OpenFileDialog();
            this.lblBanco = new System.Windows.Forms.Label();
            this.cmbBancos = new System.Windows.Forms.ComboBox();
            this.tabEmpleado.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            this.grpFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.gbFechas.SuspendLayout();
            this.gbIdentificacion.SuspendLayout();
            this.gbPersona.SuspendLayout();
            this.tabRemuneraciones.SuspendLayout();
            this.gbSalario.SuspendLayout();
            this.gbOtrosCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).BeginInit();
            this.gbBanco.SuspendLayout();
            this.tabSIJP.SuspendLayout();
            this.gbSIJP.SuspendLayout();
            this.tabFamiliares.SuspendLayout();
            this.gbFamiliares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliares)).BeginInit();
            this.tabVacaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacaciones)).BeginInit();
            this.tabAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            this.tabAnticipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnticipos)).BeginInit();
            this.tabPeriodosTrabajados.SuspendLayout();
            this.gbPeriodosTrabajados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodos)).BeginInit();
            this.tabHorarios.SuspendLayout();
            this.gbHorarios.SuspendLayout();
            this.gbHorariosPredefinidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.tabOtrosDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(434, 478);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(79, 24);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tabEmpleado
            // 
            this.tabEmpleado.Controls.Add(this.tabGeneral);
            this.tabEmpleado.Controls.Add(this.tabRemuneraciones);
            this.tabEmpleado.Controls.Add(this.tabSIJP);
            this.tabEmpleado.Controls.Add(this.tabFamiliares);
            this.tabEmpleado.Controls.Add(this.tabVacaciones);
            this.tabEmpleado.Controls.Add(this.tabAsistencia);
            this.tabEmpleado.Controls.Add(this.tabAnticipos);
            this.tabEmpleado.Controls.Add(this.tabPeriodosTrabajados);
            this.tabEmpleado.Controls.Add(this.tabHorarios);
            this.tabEmpleado.Controls.Add(this.tabOtrosDatos);
            this.tabEmpleado.Location = new System.Drawing.Point(3, 6);
            this.tabEmpleado.Name = "tabEmpleado";
            this.tabEmpleado.SelectedIndex = 0;
            this.tabEmpleado.Size = new System.Drawing.Size(718, 466);
            this.tabEmpleado.TabIndex = 1;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.gbCategoria);
            this.tabGeneral.Controls.Add(this.grpFoto);
            this.tabGeneral.Controls.Add(this.gbFechas);
            this.tabGeneral.Controls.Add(this.gbIdentificacion);
            this.tabGeneral.Controls.Add(this.gbPersona);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(710, 440);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.cmbArea);
            this.gbCategoria.Controls.Add(this.lblArea);
            this.gbCategoria.Controls.Add(this.cmbPuesto);
            this.gbCategoria.Controls.Add(this.lblPuesto);
            this.gbCategoria.Location = new System.Drawing.Point(18, 260);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(476, 61);
            this.gbCategoria.TabIndex = 22;
            this.gbCategoria.TabStop = false;
            // 
            // cmbArea
            // 
            this.cmbArea.BackColor = System.Drawing.Color.White;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(319, 19);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(143, 21);
            this.cmbArea.TabIndex = 20;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(284, 22);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 21;
            this.lblArea.Text = "Area:";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.BackColor = System.Drawing.Color.White;
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(105, 19);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(173, 21);
            this.cmbPuesto.TabIndex = 18;
            this.cmbPuesto.SelectedIndexChanged += new System.EventHandler(this.cmbPuesto_SelectedIndexChanged);
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(13, 22);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(88, 13);
            this.lblPuesto.TabIndex = 19;
            this.lblPuesto.Text = "Calif. Profesional:";
            // 
            // grpFoto
            // 
            this.grpFoto.Controls.Add(this.btnBuscar);
            this.grpFoto.Controls.Add(this.pbFoto);
            this.grpFoto.Location = new System.Drawing.Point(502, 260);
            this.grpFoto.Name = "grpFoto";
            this.grpFoto.Size = new System.Drawing.Size(192, 164);
            this.grpFoto.TabIndex = 21;
            this.grpFoto.TabStop = false;
            this.grpFoto.Text = "foto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(73, 139);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(58, 19);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(29, 15);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(140, 122);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // gbFechas
            // 
            this.gbFechas.Controls.Add(this.dtpFechaReconocimiento);
            this.gbFechas.Controls.Add(this.lblFechaReconocimiento);
            this.gbFechas.Controls.Add(this.dtpFechaReIngreso);
            this.gbFechas.Controls.Add(this.lblFechaReIngreso);
            this.gbFechas.Controls.Add(this.dtpFechaEgreso);
            this.gbFechas.Controls.Add(this.dtpFechaIngreso);
            this.gbFechas.Controls.Add(this.cmbCausaEgreso);
            this.gbFechas.Controls.Add(this.lblFechaIngreso);
            this.gbFechas.Controls.Add(this.lblFechaEgreso);
            this.gbFechas.Controls.Add(this.cmbEstado);
            this.gbFechas.Controls.Add(this.lblEstado);
            this.gbFechas.Controls.Add(this.lblCausaEgreso);
            this.gbFechas.Location = new System.Drawing.Point(18, 327);
            this.gbFechas.Name = "gbFechas";
            this.gbFechas.Size = new System.Drawing.Size(478, 97);
            this.gbFechas.TabIndex = 20;
            this.gbFechas.TabStop = false;
            // 
            // dtpFechaReconocimiento
            // 
            this.dtpFechaReconocimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReconocimiento.Location = new System.Drawing.Point(130, 40);
            this.dtpFechaReconocimiento.Name = "dtpFechaReconocimiento";
            this.dtpFechaReconocimiento.Size = new System.Drawing.Size(104, 20);
            this.dtpFechaReconocimiento.TabIndex = 23;
            this.dtpFechaReconocimiento.ValueChanged += new System.EventHandler(this.dtpFechaReconocimiento_ValueChanged);
            // 
            // lblFechaReconocimiento
            // 
            this.lblFechaReconocimiento.AutoSize = true;
            this.lblFechaReconocimiento.Location = new System.Drawing.Point(11, 43);
            this.lblFechaReconocimiento.Name = "lblFechaReconocimiento";
            this.lblFechaReconocimiento.Size = new System.Drawing.Size(120, 13);
            this.lblFechaReconocimiento.TabIndex = 22;
            this.lblFechaReconocimiento.Text = "Fecha Reconocimiento:";
            // 
            // dtpFechaReIngreso
            // 
            this.dtpFechaReIngreso.Enabled = false;
            this.dtpFechaReIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReIngreso.Location = new System.Drawing.Point(130, 68);
            this.dtpFechaReIngreso.Name = "dtpFechaReIngreso";
            this.dtpFechaReIngreso.ShowCheckBox = true;
            this.dtpFechaReIngreso.Size = new System.Drawing.Size(104, 20);
            this.dtpFechaReIngreso.TabIndex = 21;
            this.dtpFechaReIngreso.ValueChanged += new System.EventHandler(this.dtpFechaReIngreso_ValueChanged);
            // 
            // lblFechaReIngreso
            // 
            this.lblFechaReIngreso.AutoSize = true;
            this.lblFechaReIngreso.Location = new System.Drawing.Point(11, 72);
            this.lblFechaReIngreso.Name = "lblFechaReIngreso";
            this.lblFechaReIngreso.Size = new System.Drawing.Size(92, 13);
            this.lblFechaReIngreso.TabIndex = 20;
            this.lblFechaReIngreso.Text = "Fecha ReIngreso:";
            // 
            // dtpFechaEgreso
            // 
            this.dtpFechaEgreso.Enabled = false;
            this.dtpFechaEgreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEgreso.Location = new System.Drawing.Point(329, 68);
            this.dtpFechaEgreso.Name = "dtpFechaEgreso";
            this.dtpFechaEgreso.ShowCheckBox = true;
            this.dtpFechaEgreso.Size = new System.Drawing.Size(104, 20);
            this.dtpFechaEgreso.TabIndex = 19;
            this.dtpFechaEgreso.ValueChanged += new System.EventHandler(this.dtpFechaEgreso_ValueChanged);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Enabled = false;
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(130, 12);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(104, 20);
            this.dtpFechaIngreso.TabIndex = 18;
            this.dtpFechaIngreso.ValueChanged += new System.EventHandler(this.dtpFechaIngreso_ValueChanged);
            // 
            // cmbCausaEgreso
            // 
            this.cmbCausaEgreso.BackColor = System.Drawing.Color.White;
            this.cmbCausaEgreso.Enabled = false;
            this.cmbCausaEgreso.FormattingEnabled = true;
            this.cmbCausaEgreso.Location = new System.Drawing.Point(329, 41);
            this.cmbCausaEgreso.Name = "cmbCausaEgreso";
            this.cmbCausaEgreso.Size = new System.Drawing.Size(132, 21);
            this.cmbCausaEgreso.TabIndex = 12;
            this.cmbCausaEgreso.SelectedIndexChanged += new System.EventHandler(this.cmbCausaEgreso_SelectedIndexChanged);
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(11, 15);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(78, 13);
            this.lblFechaIngreso.TabIndex = 9;
            this.lblFechaIngreso.Text = "Fecha Ingreso:";
            // 
            // lblFechaEgreso
            // 
            this.lblFechaEgreso.AutoSize = true;
            this.lblFechaEgreso.Location = new System.Drawing.Point(251, 72);
            this.lblFechaEgreso.Name = "lblFechaEgreso";
            this.lblFechaEgreso.Size = new System.Drawing.Size(76, 13);
            this.lblFechaEgreso.TabIndex = 17;
            this.lblFechaEgreso.Text = "Fecha Egreso:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.White;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(329, 12);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(132, 21);
            this.cmbEstado.TabIndex = 10;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(284, 15);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCausaEgreso
            // 
            this.lblCausaEgreso.AutoSize = true;
            this.lblCausaEgreso.Location = new System.Drawing.Point(251, 44);
            this.lblCausaEgreso.Name = "lblCausaEgreso";
            this.lblCausaEgreso.Size = new System.Drawing.Size(76, 13);
            this.lblCausaEgreso.TabIndex = 13;
            this.lblCausaEgreso.Text = "Causa Egreso:";
            // 
            // gbIdentificacion
            // 
            this.gbIdentificacion.Controls.Add(this.cmbNacionalidad);
            this.gbIdentificacion.Controls.Add(this.lblNacionalidad);
            this.gbIdentificacion.Controls.Add(this.cmbCentroDeCosto);
            this.gbIdentificacion.Controls.Add(this.lblCentroDeCosto);
            this.gbIdentificacion.Controls.Add(this.cmbEstadoCivil);
            this.gbIdentificacion.Controls.Add(this.lblEstadoCivil);
            this.gbIdentificacion.Controls.Add(this.cmbAFJP);
            this.gbIdentificacion.Controls.Add(this.lblAFJP);
            this.gbIdentificacion.Controls.Add(this.txtNumeroDoc);
            this.gbIdentificacion.Controls.Add(this.lblNumero);
            this.gbIdentificacion.Controls.Add(this.cmbTipoDoc);
            this.gbIdentificacion.Controls.Add(this.lblTipoDocumento);
            this.gbIdentificacion.Controls.Add(this.txtCUIL);
            this.gbIdentificacion.Controls.Add(this.lblCUIL);
            this.gbIdentificacion.Location = new System.Drawing.Point(18, 172);
            this.gbIdentificacion.Name = "gbIdentificacion";
            this.gbIdentificacion.Size = new System.Drawing.Size(676, 82);
            this.gbIdentificacion.TabIndex = 19;
            this.gbIdentificacion.TabStop = false;
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.BackColor = System.Drawing.Color.White;
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Location = new System.Drawing.Point(546, 12);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(117, 21);
            this.cmbNacionalidad.TabIndex = 23;
            this.cmbNacionalidad.SelectedIndexChanged += new System.EventHandler(this.cmbNacionalidad_SelectedIndexChanged);
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(476, 15);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(72, 13);
            this.lblNacionalidad.TabIndex = 22;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // cmbCentroDeCosto
            // 
            this.cmbCentroDeCosto.BackColor = System.Drawing.Color.White;
            this.cmbCentroDeCosto.FormattingEnabled = true;
            this.cmbCentroDeCosto.Location = new System.Drawing.Point(458, 46);
            this.cmbCentroDeCosto.Name = "cmbCentroDeCosto";
            this.cmbCentroDeCosto.Size = new System.Drawing.Size(205, 21);
            this.cmbCentroDeCosto.TabIndex = 19;
            this.cmbCentroDeCosto.SelectedIndexChanged += new System.EventHandler(this.cmbCentroDeCosto_SelectedIndexChanged);
            // 
            // lblCentroDeCosto
            // 
            this.lblCentroDeCosto.AutoSize = true;
            this.lblCentroDeCosto.Location = new System.Drawing.Point(366, 49);
            this.lblCentroDeCosto.Name = "lblCentroDeCosto";
            this.lblCentroDeCosto.Size = new System.Drawing.Size(86, 13);
            this.lblCentroDeCosto.TabIndex = 18;
            this.lblCentroDeCosto.Text = "Centro de Costo:";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.BackColor = System.Drawing.Color.White;
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(77, 46);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(102, 21);
            this.cmbEstadoCivil.TabIndex = 17;
            this.cmbEstadoCivil.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoCivil_SelectedIndexChanged);
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(14, 49);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadoCivil.TabIndex = 16;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // cmbAFJP
            // 
            this.cmbAFJP.BackColor = System.Drawing.Color.White;
            this.cmbAFJP.FormattingEnabled = true;
            this.cmbAFJP.Location = new System.Drawing.Point(229, 46);
            this.cmbAFJP.Name = "cmbAFJP";
            this.cmbAFJP.Size = new System.Drawing.Size(131, 21);
            this.cmbAFJP.TabIndex = 15;
            this.cmbAFJP.SelectedIndexChanged += new System.EventHandler(this.cmbAFJP_SelectedIndexChanged);
            // 
            // lblAFJP
            // 
            this.lblAFJP.AutoSize = true;
            this.lblAFJP.Location = new System.Drawing.Point(188, 49);
            this.lblAFJP.Name = "lblAFJP";
            this.lblAFJP.Size = new System.Drawing.Size(35, 13);
            this.lblAFJP.TabIndex = 14;
            this.lblAFJP.Text = "AFJP:";
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.BackColor = System.Drawing.Color.White;
            this.txtNumeroDoc.Location = new System.Drawing.Point(213, 13);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(104, 20);
            this.txtNumeroDoc.TabIndex = 12;
            this.txtNumeroDoc.TextChanged += new System.EventHandler(this.txtNumeroDoc_TextChanged);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(160, 16);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 13;
            this.lblNumero.Text = "Numero:";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.BackColor = System.Drawing.Color.White;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(77, 13);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(77, 21);
            this.cmbTipoDoc.TabIndex = 11;
            this.cmbTipoDoc.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDoc_SelectedIndexChanged);
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(14, 16);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(57, 13);
            this.lblTipoDocumento.TabIndex = 8;
            this.lblTipoDocumento.Text = "Tipo Doc.:";
            // 
            // txtCUIL
            // 
            this.txtCUIL.BackColor = System.Drawing.Color.White;
            this.txtCUIL.Location = new System.Drawing.Point(366, 13);
            this.txtCUIL.Mask = "00-00000000-0";
            this.txtCUIL.Name = "txtCUIL";
            this.txtCUIL.Size = new System.Drawing.Size(86, 20);
            this.txtCUIL.TabIndex = 6;
            this.txtCUIL.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCUIL.TextChanged += new System.EventHandler(this.txtCUIL_TextChanged);
            // 
            // lblCUIL
            // 
            this.lblCUIL.AutoSize = true;
            this.lblCUIL.Location = new System.Drawing.Point(326, 16);
            this.lblCUIL.Name = "lblCUIL";
            this.lblCUIL.Size = new System.Drawing.Size(34, 13);
            this.lblCUIL.TabIndex = 7;
            this.lblCUIL.Text = "CUIL:";
            // 
            // gbPersona
            // 
            this.gbPersona.Controls.Add(this.cmbSexo);
            this.gbPersona.Controls.Add(this.lblSexo);
            this.gbPersona.Controls.Add(this.lblFechaNacimiento);
            this.gbPersona.Controls.Add(this.lblCP);
            this.gbPersona.Controls.Add(this.dtpFechaNacimiento);
            this.gbPersona.Controls.Add(this.txtCP);
            this.gbPersona.Controls.Add(this.lblLocalidad);
            this.gbPersona.Controls.Add(this.lblProvincia);
            this.gbPersona.Controls.Add(this.lblPais);
            this.gbPersona.Controls.Add(this.cmbLocalidad);
            this.gbPersona.Controls.Add(this.cmbProvincia);
            this.gbPersona.Controls.Add(this.cmbPais);
            this.gbPersona.Controls.Add(this.lblTelefonoMensajes);
            this.gbPersona.Controls.Add(this.txtTelefonoMensajes);
            this.gbPersona.Controls.Add(this.txtLegajo);
            this.gbPersona.Controls.Add(this.lblLegajo);
            this.gbPersona.Controls.Add(this.txtApellidoyNombres);
            this.gbPersona.Controls.Add(this.txtDomicilio);
            this.gbPersona.Controls.Add(this.txtTelefono);
            this.gbPersona.Controls.Add(this.lblApellidoyNombres);
            this.gbPersona.Controls.Add(this.lblDomicilio);
            this.gbPersona.Controls.Add(this.lblTelefono);
            this.gbPersona.Location = new System.Drawing.Point(18, 12);
            this.gbPersona.Name = "gbPersona";
            this.gbPersona.Size = new System.Drawing.Size(676, 154);
            this.gbPersona.TabIndex = 18;
            this.gbPersona.TabStop = false;
            // 
            // cmbSexo
            // 
            this.cmbSexo.BackColor = System.Drawing.Color.White;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(546, 93);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(117, 21);
            this.cmbSexo.TabIndex = 21;
            this.cmbSexo.SelectedIndexChanged += new System.EventHandler(this.cmbSexo_SelectedIndexChanged);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(515, 96);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 20;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(567, 49);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(96, 13);
            this.lblFechaNacimiento.TabIndex = 19;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(568, 123);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(30, 13);
            this.lblCP.TabIndex = 17;
            this.lblCP.Text = "C.P.:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(570, 66);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(93, 20);
            this.dtpFechaNacimiento.TabIndex = 18;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // txtCP
            // 
            this.txtCP.BackColor = System.Drawing.Color.White;
            this.txtCP.Location = new System.Drawing.Point(604, 120);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(59, 20);
            this.txtCP.TabIndex = 16;
            this.txtCP.TextChanged += new System.EventHandler(this.txtCP_TextChanged);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(362, 104);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 15;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(188, 104);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 14;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(14, 104);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(32, 13);
            this.lblPais.TabIndex = 13;
            this.lblPais.Text = "País:";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.BackColor = System.Drawing.Color.White;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(363, 120);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(151, 21);
            this.cmbLocalidad.TabIndex = 12;
            this.cmbLocalidad.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidad_SelectedIndexChanged);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.BackColor = System.Drawing.Color.White;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(191, 120);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(151, 21);
            this.cmbProvincia.TabIndex = 11;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cbProvincia_SelectedIndexChanged);
            // 
            // cmbPais
            // 
            this.cmbPais.BackColor = System.Drawing.Color.White;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(17, 120);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(151, 21);
            this.cmbPais.TabIndex = 10;
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // lblTelefonoMensajes
            // 
            this.lblTelefonoMensajes.AutoSize = true;
            this.lblTelefonoMensajes.Location = new System.Drawing.Point(260, 74);
            this.lblTelefonoMensajes.Name = "lblTelefonoMensajes";
            this.lblTelefonoMensajes.Size = new System.Drawing.Size(100, 13);
            this.lblTelefonoMensajes.TabIndex = 9;
            this.lblTelefonoMensajes.Text = "Telefono Mensajes:";
            // 
            // txtTelefonoMensajes
            // 
            this.txtTelefonoMensajes.BackColor = System.Drawing.Color.White;
            this.txtTelefonoMensajes.Location = new System.Drawing.Point(366, 71);
            this.txtTelefonoMensajes.Name = "txtTelefonoMensajes";
            this.txtTelefonoMensajes.Size = new System.Drawing.Size(124, 20);
            this.txtTelefonoMensajes.TabIndex = 8;
            this.txtTelefonoMensajes.TextChanged += new System.EventHandler(this.txtTelefonoMensajes_TextChanged);
            // 
            // txtLegajo
            // 
            this.txtLegajo.BackColor = System.Drawing.Color.White;
            this.txtLegajo.Location = new System.Drawing.Point(607, 19);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(56, 20);
            this.txtLegajo.TabIndex = 7;
            this.txtLegajo.TextChanged += new System.EventHandler(this.txtLegajo_TextChanged);
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(567, 22);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(42, 13);
            this.lblLegajo.TabIndex = 6;
            this.lblLegajo.Text = "Legajo:";
            // 
            // txtApellidoyNombres
            // 
            this.txtApellidoyNombres.BackColor = System.Drawing.Color.White;
            this.txtApellidoyNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoyNombres.Location = new System.Drawing.Point(123, 19);
            this.txtApellidoyNombres.Name = "txtApellidoyNombres";
            this.txtApellidoyNombres.Size = new System.Drawing.Size(367, 20);
            this.txtApellidoyNombres.TabIndex = 0;
            this.txtApellidoyNombres.TextChanged += new System.EventHandler(this.txtApellidoyNombres_TextChanged);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BackColor = System.Drawing.Color.White;
            this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDomicilio.Location = new System.Drawing.Point(123, 45);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(367, 20);
            this.txtDomicilio.TabIndex = 1;
            this.txtDomicilio.TextChanged += new System.EventHandler(this.txtDomicilio_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(123, 71);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(124, 20);
            this.txtTelefono.TabIndex = 2;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // lblApellidoyNombres
            // 
            this.lblApellidoyNombres.AutoSize = true;
            this.lblApellidoyNombres.Location = new System.Drawing.Point(14, 22);
            this.lblApellidoyNombres.Name = "lblApellidoyNombres";
            this.lblApellidoyNombres.Size = new System.Drawing.Size(100, 13);
            this.lblApellidoyNombres.TabIndex = 3;
            this.lblApellidoyNombres.Text = "Apellido y Nombres:";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(14, 48);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(52, 13);
            this.lblDomicilio.TabIndex = 4;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(14, 74);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono:";
            // 
            // tabRemuneraciones
            // 
            this.tabRemuneraciones.Controls.Add(this.gbSalario);
            this.tabRemuneraciones.Controls.Add(this.gbOtrosCampos);
            this.tabRemuneraciones.Controls.Add(this.gbBanco);
            this.tabRemuneraciones.Location = new System.Drawing.Point(4, 22);
            this.tabRemuneraciones.Name = "tabRemuneraciones";
            this.tabRemuneraciones.Size = new System.Drawing.Size(710, 440);
            this.tabRemuneraciones.TabIndex = 2;
            this.tabRemuneraciones.Text = "Remuneraciones";
            this.tabRemuneraciones.UseVisualStyleBackColor = true;
            this.tabRemuneraciones.Click += new System.EventHandler(this.tabRemuneraciones_Click);
            // 
            // gbSalario
            // 
            this.gbSalario.Controls.Add(this.lblSindicato);
            this.gbSalario.Controls.Add(this.cmbSindicato);
            this.gbSalario.Controls.Add(this.cmbContrato);
            this.gbSalario.Controls.Add(this.lblContrato);
            this.gbSalario.Controls.Add(this.cmbCategoria);
            this.gbSalario.Controls.Add(this.lblCategoria);
            this.gbSalario.Controls.Add(this.lblTipoLiquidacion);
            this.gbSalario.Controls.Add(this.txtSueldoOjornal);
            this.gbSalario.Controls.Add(this.lblObraSocial);
            this.gbSalario.Controls.Add(this.lblSueldooJornal);
            this.gbSalario.Controls.Add(this.cmbObraSocial);
            this.gbSalario.Controls.Add(this.cmbTipoLiquidacion);
            this.gbSalario.Controls.Add(this.cmbConvenio);
            this.gbSalario.Controls.Add(this.lblConvenio);
            this.gbSalario.Location = new System.Drawing.Point(15, 3);
            this.gbSalario.Name = "gbSalario";
            this.gbSalario.Size = new System.Drawing.Size(691, 114);
            this.gbSalario.TabIndex = 25;
            this.gbSalario.TabStop = false;
            // 
            // lblSindicato
            // 
            this.lblSindicato.AutoSize = true;
            this.lblSindicato.Location = new System.Drawing.Point(407, 53);
            this.lblSindicato.Name = "lblSindicato";
            this.lblSindicato.Size = new System.Drawing.Size(54, 13);
            this.lblSindicato.TabIndex = 29;
            this.lblSindicato.Text = "Sindicato:";
            // 
            // cmbSindicato
            // 
            this.cmbSindicato.BackColor = System.Drawing.Color.White;
            this.cmbSindicato.FormattingEnabled = true;
            this.cmbSindicato.Location = new System.Drawing.Point(467, 50);
            this.cmbSindicato.Name = "cmbSindicato";
            this.cmbSindicato.Size = new System.Drawing.Size(165, 21);
            this.cmbSindicato.TabIndex = 28;
            this.cmbSindicato.SelectedIndexChanged += new System.EventHandler(this.cmbSindicato_SelectedIndexChanged);
            // 
            // cmbContrato
            // 
            this.cmbContrato.BackColor = System.Drawing.Color.White;
            this.cmbContrato.FormattingEnabled = true;
            this.cmbContrato.Location = new System.Drawing.Point(333, 76);
            this.cmbContrato.Name = "cmbContrato";
            this.cmbContrato.Size = new System.Drawing.Size(164, 21);
            this.cmbContrato.TabIndex = 26;
            this.cmbContrato.SelectedIndexChanged += new System.EventHandler(this.cmbContrato_SelectedIndexChanged);
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Location = new System.Drawing.Point(272, 79);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(50, 13);
            this.lblContrato.TabIndex = 27;
            this.lblContrato.Text = "Contrato:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.White;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(95, 76);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(164, 21);
            this.cmbCategoria.TabIndex = 24;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(34, 79);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 25;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblTipoLiquidacion
            // 
            this.lblTipoLiquidacion.AutoSize = true;
            this.lblTipoLiquidacion.Location = new System.Drawing.Point(6, 26);
            this.lblTipoLiquidacion.Name = "lblTipoLiquidacion";
            this.lblTipoLiquidacion.Size = new System.Drawing.Size(66, 13);
            this.lblTipoLiquidacion.TabIndex = 13;
            this.lblTipoLiquidacion.Text = "Tipo Salario:";
            // 
            // txtSueldoOjornal
            // 
            this.txtSueldoOjornal.BackColor = System.Drawing.Color.White;
            this.txtSueldoOjornal.Location = new System.Drawing.Point(95, 50);
            this.txtSueldoOjornal.Name = "txtSueldoOjornal";
            this.txtSueldoOjornal.Size = new System.Drawing.Size(107, 20);
            this.txtSueldoOjornal.TabIndex = 1;
            this.txtSueldoOjornal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSueldoOjornal.TextChanged += new System.EventHandler(this.txtSueldoOjornal_TextChanged);
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Location = new System.Drawing.Point(217, 26);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(65, 13);
            this.lblObraSocial.TabIndex = 23;
            this.lblObraSocial.Text = "Obra Social:";
            // 
            // lblSueldooJornal
            // 
            this.lblSueldooJornal.AutoSize = true;
            this.lblSueldooJornal.Location = new System.Drawing.Point(6, 53);
            this.lblSueldooJornal.Name = "lblSueldooJornal";
            this.lblSueldooJornal.Size = new System.Drawing.Size(83, 13);
            this.lblSueldooJornal.TabIndex = 4;
            this.lblSueldooJornal.Text = "Sueldo o Jornal:";
            // 
            // cmbObraSocial
            // 
            this.cmbObraSocial.BackColor = System.Drawing.Color.White;
            this.cmbObraSocial.FormattingEnabled = true;
            this.cmbObraSocial.Location = new System.Drawing.Point(288, 23);
            this.cmbObraSocial.Name = "cmbObraSocial";
            this.cmbObraSocial.Size = new System.Drawing.Size(209, 21);
            this.cmbObraSocial.TabIndex = 22;
            this.cmbObraSocial.SelectedIndexChanged += new System.EventHandler(this.cmbObraSocial_SelectedIndexChanged);
            // 
            // cmbTipoLiquidacion
            // 
            this.cmbTipoLiquidacion.BackColor = System.Drawing.Color.White;
            this.cmbTipoLiquidacion.FormattingEnabled = true;
            this.cmbTipoLiquidacion.Location = new System.Drawing.Point(95, 23);
            this.cmbTipoLiquidacion.Name = "cmbTipoLiquidacion";
            this.cmbTipoLiquidacion.Size = new System.Drawing.Size(107, 21);
            this.cmbTipoLiquidacion.TabIndex = 12;
            this.cmbTipoLiquidacion.SelectedIndexChanged += new System.EventHandler(this.cmbTipoLiquidacion_SelectedIndexChanged);
            // 
            // cmbConvenio
            // 
            this.cmbConvenio.BackColor = System.Drawing.Color.White;
            this.cmbConvenio.FormattingEnabled = true;
            this.cmbConvenio.Location = new System.Drawing.Point(288, 50);
            this.cmbConvenio.Name = "cmbConvenio";
            this.cmbConvenio.Size = new System.Drawing.Size(107, 21);
            this.cmbConvenio.TabIndex = 19;
            this.cmbConvenio.SelectedIndexChanged += new System.EventHandler(this.cmbConvenio_SelectedIndexChanged);
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Location = new System.Drawing.Point(226, 53);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(55, 13);
            this.lblConvenio.TabIndex = 20;
            this.lblConvenio.Text = "Convenio:";
            // 
            // gbOtrosCampos
            // 
            this.gbOtrosCampos.Controls.Add(this.btnEliminar);
            this.gbOtrosCampos.Controls.Add(this.btnNuevo);
            this.gbOtrosCampos.Controls.Add(this.btnModificar);
            this.gbOtrosCampos.Controls.Add(this.dgvCampos);
            this.gbOtrosCampos.Location = new System.Drawing.Point(15, 123);
            this.gbOtrosCampos.Name = "gbOtrosCampos";
            this.gbOtrosCampos.Size = new System.Drawing.Size(651, 234);
            this.gbOtrosCampos.TabIndex = 24;
            this.gbOtrosCampos.TabStop = false;
            this.gbOtrosCampos.Text = "Otros Campos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(546, 137);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(546, 79);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 23);
            this.btnNuevo.TabIndex = 20;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(546, 108);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 23);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvCampos
            // 
            this.dgvCampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampos.Location = new System.Drawing.Point(9, 19);
            this.dgvCampos.Name = "dgvCampos";
            this.dgvCampos.Size = new System.Drawing.Size(515, 202);
            this.dgvCampos.TabIndex = 18;
            this.dgvCampos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCampos_CellContentClick);
            // 
            // gbBanco
            // 
            this.gbBanco.Controls.Add(this.cmbBancos);
            this.gbBanco.Controls.Add(this.lblBanco);
            this.gbBanco.Controls.Add(this.cmbFormaDePago);
            this.gbBanco.Controls.Add(this.lblFormaDePago);
            this.gbBanco.Controls.Add(this.lblNumeroCuenta);
            this.gbBanco.Controls.Add(this.cmbSucursalesBanco);
            this.gbBanco.Controls.Add(this.lblSucursalBanco);
            this.gbBanco.Controls.Add(this.txtNumeroCuenta);
            this.gbBanco.Location = new System.Drawing.Point(15, 363);
            this.gbBanco.Name = "gbBanco";
            this.gbBanco.Size = new System.Drawing.Size(651, 73);
            this.gbBanco.TabIndex = 21;
            this.gbBanco.TabStop = false;
            // 
            // cmbFormaDePago
            // 
            this.cmbFormaDePago.BackColor = System.Drawing.Color.White;
            this.cmbFormaDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaDePago.FormattingEnabled = true;
            this.cmbFormaDePago.Location = new System.Drawing.Point(95, 19);
            this.cmbFormaDePago.Name = "cmbFormaDePago";
            this.cmbFormaDePago.Size = new System.Drawing.Size(205, 21);
            this.cmbFormaDePago.TabIndex = 18;
            this.cmbFormaDePago.SelectedIndexChanged += new System.EventHandler(this.cmbFormaDePago_SelectedIndexChanged);
            // 
            // lblFormaDePago
            // 
            this.lblFormaDePago.AutoSize = true;
            this.lblFormaDePago.Location = new System.Drawing.Point(9, 22);
            this.lblFormaDePago.Name = "lblFormaDePago";
            this.lblFormaDePago.Size = new System.Drawing.Size(82, 13);
            this.lblFormaDePago.TabIndex = 19;
            this.lblFormaDePago.Text = "Forma de Pago:";
            // 
            // lblNumeroCuenta
            // 
            this.lblNumeroCuenta.AutoSize = true;
            this.lblNumeroCuenta.Location = new System.Drawing.Point(317, 49);
            this.lblNumeroCuenta.Name = "lblNumeroCuenta";
            this.lblNumeroCuenta.Size = new System.Drawing.Size(59, 13);
            this.lblNumeroCuenta.TabIndex = 17;
            this.lblNumeroCuenta.Text = "Nº Cuenta:";
            // 
            // cmbSucursalesBanco
            // 
            this.cmbSucursalesBanco.BackColor = System.Drawing.Color.White;
            this.cmbSucursalesBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursalesBanco.FormattingEnabled = true;
            this.cmbSucursalesBanco.Location = new System.Drawing.Point(95, 46);
            this.cmbSucursalesBanco.Name = "cmbSucursalesBanco";
            this.cmbSucursalesBanco.Size = new System.Drawing.Size(187, 21);
            this.cmbSucursalesBanco.TabIndex = 14;
            this.cmbSucursalesBanco.SelectedIndexChanged += new System.EventHandler(this.cmbBanco_SelectedIndexChanged);
            // 
            // lblSucursalBanco
            // 
            this.lblSucursalBanco.AutoSize = true;
            this.lblSucursalBanco.Location = new System.Drawing.Point(38, 49);
            this.lblSucursalBanco.Name = "lblSucursalBanco";
            this.lblSucursalBanco.Size = new System.Drawing.Size(51, 13);
            this.lblSucursalBanco.TabIndex = 15;
            this.lblSucursalBanco.Text = "Sucursal:";
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.BackColor = System.Drawing.Color.White;
            this.txtNumeroCuenta.Location = new System.Drawing.Point(382, 46);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(109, 20);
            this.txtNumeroCuenta.TabIndex = 16;
            this.txtNumeroCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroCuenta.TextChanged += new System.EventHandler(this.txtNumeroCuenta_TextChanged);
            // 
            // tabSIJP
            // 
            this.tabSIJP.Controls.Add(this.gbSIJP);
            this.tabSIJP.Location = new System.Drawing.Point(4, 22);
            this.tabSIJP.Name = "tabSIJP";
            this.tabSIJP.Size = new System.Drawing.Size(710, 440);
            this.tabSIJP.TabIndex = 9;
            this.tabSIJP.Text = "SiCOSS";
            this.tabSIJP.UseVisualStyleBackColor = true;
            // 
            // gbSIJP
            // 
            this.gbSIJP.Controls.Add(this.lblCodigoDeSiniestrado);
            this.gbSIJP.Controls.Add(this.cmbCodigoDeSiniestrado);
            this.gbSIJP.Controls.Add(this.lblModalidadDeContratacion);
            this.gbSIJP.Controls.Add(this.cmbModalidadDeContratacion);
            this.gbSIJP.Controls.Add(this.lblCodigoDeActividad);
            this.gbSIJP.Controls.Add(this.cmbCodigoDeActividad);
            this.gbSIJP.Controls.Add(this.lblCodigoDeCondicion);
            this.gbSIJP.Controls.Add(this.cmbCodigoDeCondicion);
            this.gbSIJP.Controls.Add(this.lblSituacionDeRevista);
            this.gbSIJP.Controls.Add(this.cmbSituacionDeRevista);
            this.gbSIJP.Location = new System.Drawing.Point(21, 26);
            this.gbSIJP.Name = "gbSIJP";
            this.gbSIJP.Size = new System.Drawing.Size(666, 244);
            this.gbSIJP.TabIndex = 0;
            this.gbSIJP.TabStop = false;
            // 
            // lblCodigoDeSiniestrado
            // 
            this.lblCodigoDeSiniestrado.AutoSize = true;
            this.lblCodigoDeSiniestrado.Location = new System.Drawing.Point(23, 198);
            this.lblCodigoDeSiniestrado.Name = "lblCodigoDeSiniestrado";
            this.lblCodigoDeSiniestrado.Size = new System.Drawing.Size(113, 13);
            this.lblCodigoDeSiniestrado.TabIndex = 33;
            this.lblCodigoDeSiniestrado.Text = "Codigo de Siniestrado:";
            // 
            // cmbCodigoDeSiniestrado
            // 
            this.cmbCodigoDeSiniestrado.BackColor = System.Drawing.Color.White;
            this.cmbCodigoDeSiniestrado.FormattingEnabled = true;
            this.cmbCodigoDeSiniestrado.Location = new System.Drawing.Point(137, 198);
            this.cmbCodigoDeSiniestrado.Name = "cmbCodigoDeSiniestrado";
            this.cmbCodigoDeSiniestrado.Size = new System.Drawing.Size(270, 21);
            this.cmbCodigoDeSiniestrado.TabIndex = 32;
            this.cmbCodigoDeSiniestrado.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoDeSiniestrado_SelectedIndexChanged);
            // 
            // lblModalidadDeContratacion
            // 
            this.lblModalidadDeContratacion.AutoSize = true;
            this.lblModalidadDeContratacion.Location = new System.Drawing.Point(23, 156);
            this.lblModalidadDeContratacion.Name = "lblModalidadDeContratacion";
            this.lblModalidadDeContratacion.Size = new System.Drawing.Size(137, 13);
            this.lblModalidadDeContratacion.TabIndex = 31;
            this.lblModalidadDeContratacion.Text = "Modalidad de Contratación:";
            // 
            // cmbModalidadDeContratacion
            // 
            this.cmbModalidadDeContratacion.BackColor = System.Drawing.Color.White;
            this.cmbModalidadDeContratacion.FormattingEnabled = true;
            this.cmbModalidadDeContratacion.Location = new System.Drawing.Point(166, 153);
            this.cmbModalidadDeContratacion.Name = "cmbModalidadDeContratacion";
            this.cmbModalidadDeContratacion.Size = new System.Drawing.Size(270, 21);
            this.cmbModalidadDeContratacion.TabIndex = 30;
            this.cmbModalidadDeContratacion.SelectedIndexChanged += new System.EventHandler(this.cmbModalidadDeContratacion_SelectedIndexChanged);
            // 
            // lblCodigoDeActividad
            // 
            this.lblCodigoDeActividad.AutoSize = true;
            this.lblCodigoDeActividad.Location = new System.Drawing.Point(23, 116);
            this.lblCodigoDeActividad.Name = "lblCodigoDeActividad";
            this.lblCodigoDeActividad.Size = new System.Drawing.Size(105, 13);
            this.lblCodigoDeActividad.TabIndex = 29;
            this.lblCodigoDeActividad.Text = "Codigo de Actividad:";
            // 
            // cmbCodigoDeActividad
            // 
            this.cmbCodigoDeActividad.BackColor = System.Drawing.Color.White;
            this.cmbCodigoDeActividad.FormattingEnabled = true;
            this.cmbCodigoDeActividad.Location = new System.Drawing.Point(137, 113);
            this.cmbCodigoDeActividad.Name = "cmbCodigoDeActividad";
            this.cmbCodigoDeActividad.Size = new System.Drawing.Size(270, 21);
            this.cmbCodigoDeActividad.TabIndex = 28;
            this.cmbCodigoDeActividad.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoDeActividad_SelectedIndexChanged);
            // 
            // lblCodigoDeCondicion
            // 
            this.lblCodigoDeCondicion.AutoSize = true;
            this.lblCodigoDeCondicion.Location = new System.Drawing.Point(23, 78);
            this.lblCodigoDeCondicion.Name = "lblCodigoDeCondicion";
            this.lblCodigoDeCondicion.Size = new System.Drawing.Size(108, 13);
            this.lblCodigoDeCondicion.TabIndex = 27;
            this.lblCodigoDeCondicion.Text = "Código de Condición:";
            // 
            // cmbCodigoDeCondicion
            // 
            this.cmbCodigoDeCondicion.BackColor = System.Drawing.Color.White;
            this.cmbCodigoDeCondicion.FormattingEnabled = true;
            this.cmbCodigoDeCondicion.Location = new System.Drawing.Point(137, 75);
            this.cmbCodigoDeCondicion.Name = "cmbCodigoDeCondicion";
            this.cmbCodigoDeCondicion.Size = new System.Drawing.Size(270, 21);
            this.cmbCodigoDeCondicion.TabIndex = 26;
            this.cmbCodigoDeCondicion.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoDeCondicion_SelectedIndexChanged);
            // 
            // lblSituacionDeRevista
            // 
            this.lblSituacionDeRevista.AutoSize = true;
            this.lblSituacionDeRevista.Location = new System.Drawing.Point(23, 40);
            this.lblSituacionDeRevista.Name = "lblSituacionDeRevista";
            this.lblSituacionDeRevista.Size = new System.Drawing.Size(108, 13);
            this.lblSituacionDeRevista.TabIndex = 25;
            this.lblSituacionDeRevista.Text = "Situación de Revista:";
            // 
            // cmbSituacionDeRevista
            // 
            this.cmbSituacionDeRevista.BackColor = System.Drawing.Color.White;
            this.cmbSituacionDeRevista.FormattingEnabled = true;
            this.cmbSituacionDeRevista.Location = new System.Drawing.Point(137, 37);
            this.cmbSituacionDeRevista.Name = "cmbSituacionDeRevista";
            this.cmbSituacionDeRevista.Size = new System.Drawing.Size(270, 21);
            this.cmbSituacionDeRevista.TabIndex = 24;
            this.cmbSituacionDeRevista.SelectedIndexChanged += new System.EventHandler(this.cmbSituacionDeRevista_SelectedIndexChanged);
            // 
            // tabFamiliares
            // 
            this.tabFamiliares.Controls.Add(this.gbFamiliares);
            this.tabFamiliares.Location = new System.Drawing.Point(4, 22);
            this.tabFamiliares.Name = "tabFamiliares";
            this.tabFamiliares.Size = new System.Drawing.Size(710, 440);
            this.tabFamiliares.TabIndex = 3;
            this.tabFamiliares.Text = "Familiares";
            this.tabFamiliares.UseVisualStyleBackColor = true;
            // 
            // gbFamiliares
            // 
            this.gbFamiliares.Controls.Add(this.btnEliminarFamiliar);
            this.gbFamiliares.Controls.Add(this.btnNuevoFamiliar);
            this.gbFamiliares.Controls.Add(this.btnModificarFamiliar);
            this.gbFamiliares.Controls.Add(this.dgvFamiliares);
            this.gbFamiliares.Location = new System.Drawing.Point(5, 26);
            this.gbFamiliares.Name = "gbFamiliares";
            this.gbFamiliares.Size = new System.Drawing.Size(701, 289);
            this.gbFamiliares.TabIndex = 25;
            this.gbFamiliares.TabStop = false;
            this.gbFamiliares.Text = "Familiares";
            // 
            // btnEliminarFamiliar
            // 
            this.btnEliminarFamiliar.Location = new System.Drawing.Point(605, 152);
            this.btnEliminarFamiliar.Name = "btnEliminarFamiliar";
            this.btnEliminarFamiliar.Size = new System.Drawing.Size(86, 23);
            this.btnEliminarFamiliar.TabIndex = 21;
            this.btnEliminarFamiliar.Text = "&Eliminar";
            this.btnEliminarFamiliar.UseVisualStyleBackColor = true;
            this.btnEliminarFamiliar.Click += new System.EventHandler(this.btnEliminarFamiliar_Click);
            // 
            // btnNuevoFamiliar
            // 
            this.btnNuevoFamiliar.Location = new System.Drawing.Point(605, 94);
            this.btnNuevoFamiliar.Name = "btnNuevoFamiliar";
            this.btnNuevoFamiliar.Size = new System.Drawing.Size(86, 23);
            this.btnNuevoFamiliar.TabIndex = 20;
            this.btnNuevoFamiliar.Text = "&Nuevo";
            this.btnNuevoFamiliar.UseVisualStyleBackColor = true;
            this.btnNuevoFamiliar.Click += new System.EventHandler(this.btnNuevoFamiliar_Click);
            // 
            // btnModificarFamiliar
            // 
            this.btnModificarFamiliar.Location = new System.Drawing.Point(605, 123);
            this.btnModificarFamiliar.Name = "btnModificarFamiliar";
            this.btnModificarFamiliar.Size = new System.Drawing.Size(86, 23);
            this.btnModificarFamiliar.TabIndex = 19;
            this.btnModificarFamiliar.Text = "Modificar";
            this.btnModificarFamiliar.UseVisualStyleBackColor = true;
            this.btnModificarFamiliar.Click += new System.EventHandler(this.btnModificarFamiliar_Click);
            // 
            // dgvFamiliares
            // 
            this.dgvFamiliares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamiliares.Location = new System.Drawing.Point(9, 32);
            this.dgvFamiliares.Name = "dgvFamiliares";
            this.dgvFamiliares.Size = new System.Drawing.Size(578, 244);
            this.dgvFamiliares.TabIndex = 18;
            // 
            // tabVacaciones
            // 
            this.tabVacaciones.Controls.Add(this.btnEliminarVacaciones);
            this.tabVacaciones.Controls.Add(this.btnNuevoVacaciones);
            this.tabVacaciones.Controls.Add(this.btnModificarVacaciones);
            this.tabVacaciones.Controls.Add(this.dgvVacaciones);
            this.tabVacaciones.Location = new System.Drawing.Point(4, 22);
            this.tabVacaciones.Name = "tabVacaciones";
            this.tabVacaciones.Size = new System.Drawing.Size(710, 440);
            this.tabVacaciones.TabIndex = 4;
            this.tabVacaciones.Text = "Vacaciones";
            this.tabVacaciones.UseVisualStyleBackColor = true;
            this.tabVacaciones.Click += new System.EventHandler(this.tabVacaciones_Click);
            // 
            // btnEliminarVacaciones
            // 
            this.btnEliminarVacaciones.Location = new System.Drawing.Point(512, 184);
            this.btnEliminarVacaciones.Name = "btnEliminarVacaciones";
            this.btnEliminarVacaciones.Size = new System.Drawing.Size(86, 23);
            this.btnEliminarVacaciones.TabIndex = 24;
            this.btnEliminarVacaciones.Text = "&Eliminar";
            this.btnEliminarVacaciones.UseVisualStyleBackColor = true;
            this.btnEliminarVacaciones.Click += new System.EventHandler(this.btnEliminarVacaciones_Click);
            // 
            // btnNuevoVacaciones
            // 
            this.btnNuevoVacaciones.Location = new System.Drawing.Point(512, 126);
            this.btnNuevoVacaciones.Name = "btnNuevoVacaciones";
            this.btnNuevoVacaciones.Size = new System.Drawing.Size(86, 23);
            this.btnNuevoVacaciones.TabIndex = 23;
            this.btnNuevoVacaciones.Text = "&Nuevo";
            this.btnNuevoVacaciones.UseVisualStyleBackColor = true;
            this.btnNuevoVacaciones.Click += new System.EventHandler(this.btnNuevoVacaciones_Click);
            // 
            // btnModificarVacaciones
            // 
            this.btnModificarVacaciones.Location = new System.Drawing.Point(512, 155);
            this.btnModificarVacaciones.Name = "btnModificarVacaciones";
            this.btnModificarVacaciones.Size = new System.Drawing.Size(86, 23);
            this.btnModificarVacaciones.TabIndex = 22;
            this.btnModificarVacaciones.Text = "Modificar";
            this.btnModificarVacaciones.UseVisualStyleBackColor = true;
            this.btnModificarVacaciones.Click += new System.EventHandler(this.btnModificarVacaciones_Click);
            // 
            // dgvVacaciones
            // 
            this.dgvVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacaciones.Location = new System.Drawing.Point(24, 52);
            this.dgvVacaciones.Name = "dgvVacaciones";
            this.dgvVacaciones.Size = new System.Drawing.Size(482, 253);
            this.dgvVacaciones.TabIndex = 0;
            // 
            // tabAsistencia
            // 
            this.tabAsistencia.Controls.Add(this.dgvAsistencia);
            this.tabAsistencia.Location = new System.Drawing.Point(4, 22);
            this.tabAsistencia.Name = "tabAsistencia";
            this.tabAsistencia.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsistencia.Size = new System.Drawing.Size(710, 440);
            this.tabAsistencia.TabIndex = 1;
            this.tabAsistencia.Text = "Asistencia";
            this.tabAsistencia.UseVisualStyleBackColor = true;
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencia.Location = new System.Drawing.Point(24, 52);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.Size = new System.Drawing.Size(482, 253);
            this.dgvAsistencia.TabIndex = 1;
            // 
            // tabAnticipos
            // 
            this.tabAnticipos.Controls.Add(this.dgvAnticipos);
            this.tabAnticipos.Location = new System.Drawing.Point(4, 22);
            this.tabAnticipos.Name = "tabAnticipos";
            this.tabAnticipos.Size = new System.Drawing.Size(710, 440);
            this.tabAnticipos.TabIndex = 6;
            this.tabAnticipos.Text = "Anticipos de Sueldo";
            this.tabAnticipos.UseVisualStyleBackColor = true;
            // 
            // dgvAnticipos
            // 
            this.dgvAnticipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnticipos.Location = new System.Drawing.Point(24, 52);
            this.dgvAnticipos.Name = "dgvAnticipos";
            this.dgvAnticipos.Size = new System.Drawing.Size(552, 253);
            this.dgvAnticipos.TabIndex = 2;
            // 
            // tabPeriodosTrabajados
            // 
            this.tabPeriodosTrabajados.Controls.Add(this.gbPeriodosTrabajados);
            this.tabPeriodosTrabajados.Location = new System.Drawing.Point(4, 22);
            this.tabPeriodosTrabajados.Name = "tabPeriodosTrabajados";
            this.tabPeriodosTrabajados.Size = new System.Drawing.Size(710, 440);
            this.tabPeriodosTrabajados.TabIndex = 7;
            this.tabPeriodosTrabajados.Text = "Periodos Trabajados";
            this.tabPeriodosTrabajados.UseVisualStyleBackColor = true;
            // 
            // gbPeriodosTrabajados
            // 
            this.gbPeriodosTrabajados.Controls.Add(this.btnModificarPeriodoTrabajado);
            this.gbPeriodosTrabajados.Controls.Add(this.btnEliminarPeriodoTrabajado);
            this.gbPeriodosTrabajados.Controls.Add(this.btnNuevoPeriodoTrabajado);
            this.gbPeriodosTrabajados.Controls.Add(this.dgvPeriodos);
            this.gbPeriodosTrabajados.Location = new System.Drawing.Point(16, 37);
            this.gbPeriodosTrabajados.Name = "gbPeriodosTrabajados";
            this.gbPeriodosTrabajados.Size = new System.Drawing.Size(665, 310);
            this.gbPeriodosTrabajados.TabIndex = 3;
            this.gbPeriodosTrabajados.TabStop = false;
            this.gbPeriodosTrabajados.Text = "Periodos Trabajados";
            // 
            // btnModificarPeriodoTrabajado
            // 
            this.btnModificarPeriodoTrabajado.Location = new System.Drawing.Point(555, 130);
            this.btnModificarPeriodoTrabajado.Name = "btnModificarPeriodoTrabajado";
            this.btnModificarPeriodoTrabajado.Size = new System.Drawing.Size(86, 23);
            this.btnModificarPeriodoTrabajado.TabIndex = 25;
            this.btnModificarPeriodoTrabajado.Text = "Modificar";
            this.btnModificarPeriodoTrabajado.UseVisualStyleBackColor = true;
            this.btnModificarPeriodoTrabajado.Click += new System.EventHandler(this.btnModificarPeriodoTrabajado_Click);
            // 
            // btnEliminarPeriodoTrabajado
            // 
            this.btnEliminarPeriodoTrabajado.Location = new System.Drawing.Point(555, 159);
            this.btnEliminarPeriodoTrabajado.Name = "btnEliminarPeriodoTrabajado";
            this.btnEliminarPeriodoTrabajado.Size = new System.Drawing.Size(86, 23);
            this.btnEliminarPeriodoTrabajado.TabIndex = 24;
            this.btnEliminarPeriodoTrabajado.Text = "&Eliminar";
            this.btnEliminarPeriodoTrabajado.UseVisualStyleBackColor = true;
            this.btnEliminarPeriodoTrabajado.Click += new System.EventHandler(this.btnEliminarPeriodoTrabajado_Click);
            // 
            // btnNuevoPeriodoTrabajado
            // 
            this.btnNuevoPeriodoTrabajado.Location = new System.Drawing.Point(555, 101);
            this.btnNuevoPeriodoTrabajado.Name = "btnNuevoPeriodoTrabajado";
            this.btnNuevoPeriodoTrabajado.Size = new System.Drawing.Size(86, 23);
            this.btnNuevoPeriodoTrabajado.TabIndex = 23;
            this.btnNuevoPeriodoTrabajado.Text = "&Nuevo";
            this.btnNuevoPeriodoTrabajado.UseVisualStyleBackColor = true;
            this.btnNuevoPeriodoTrabajado.Click += new System.EventHandler(this.btnNuevoPeriodoTrabajado_Click);
            // 
            // dgvPeriodos
            // 
            this.dgvPeriodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriodos.Location = new System.Drawing.Point(15, 44);
            this.dgvPeriodos.Name = "dgvPeriodos";
            this.dgvPeriodos.Size = new System.Drawing.Size(523, 207);
            this.dgvPeriodos.TabIndex = 2;
            // 
            // tabHorarios
            // 
            this.tabHorarios.Controls.Add(this.gbHorarios);
            this.tabHorarios.Location = new System.Drawing.Point(4, 22);
            this.tabHorarios.Name = "tabHorarios";
            this.tabHorarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabHorarios.Size = new System.Drawing.Size(710, 440);
            this.tabHorarios.TabIndex = 8;
            this.tabHorarios.Text = "Horarios";
            this.tabHorarios.UseVisualStyleBackColor = true;
            // 
            // gbHorarios
            // 
            this.gbHorarios.Controls.Add(this.gbHorariosPredefinidos);
            this.gbHorarios.Controls.Add(this.btnModificarHorario);
            this.gbHorarios.Controls.Add(this.btnEliminarHorario);
            this.gbHorarios.Controls.Add(this.btnNuevoHorario);
            this.gbHorarios.Controls.Add(this.dgvHorarios);
            this.gbHorarios.Location = new System.Drawing.Point(16, 37);
            this.gbHorarios.Name = "gbHorarios";
            this.gbHorarios.Size = new System.Drawing.Size(665, 381);
            this.gbHorarios.TabIndex = 0;
            this.gbHorarios.TabStop = false;
            this.gbHorarios.Text = "Horarios";
            // 
            // gbHorariosPredefinidos
            // 
            this.gbHorariosPredefinidos.Controls.Add(this.chkEliminaExistentes);
            this.gbHorariosPredefinidos.Controls.Add(this.btnAplicarHorarioPredefinido);
            this.gbHorariosPredefinidos.Controls.Add(this.cmbHorariosPlantillas);
            this.gbHorariosPredefinidos.Location = new System.Drawing.Point(15, 307);
            this.gbHorariosPredefinidos.Name = "gbHorariosPredefinidos";
            this.gbHorariosPredefinidos.Size = new System.Drawing.Size(626, 55);
            this.gbHorariosPredefinidos.TabIndex = 30;
            this.gbHorariosPredefinidos.TabStop = false;
            this.gbHorariosPredefinidos.Text = "Horarios Predefinidos";
            // 
            // chkEliminaExistentes
            // 
            this.chkEliminaExistentes.AutoSize = true;
            this.chkEliminaExistentes.Checked = true;
            this.chkEliminaExistentes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEliminaExistentes.Location = new System.Drawing.Point(493, 19);
            this.chkEliminaExistentes.Name = "chkEliminaExistentes";
            this.chkEliminaExistentes.Size = new System.Drawing.Size(110, 17);
            this.chkEliminaExistentes.TabIndex = 31;
            this.chkEliminaExistentes.Text = "E&limina Existentes";
            this.chkEliminaExistentes.UseVisualStyleBackColor = true;
            // 
            // btnAplicarHorarioPredefinido
            // 
            this.btnAplicarHorarioPredefinido.Location = new System.Drawing.Point(396, 19);
            this.btnAplicarHorarioPredefinido.Name = "btnAplicarHorarioPredefinido";
            this.btnAplicarHorarioPredefinido.Size = new System.Drawing.Size(91, 20);
            this.btnAplicarHorarioPredefinido.TabIndex = 30;
            this.btnAplicarHorarioPredefinido.Text = "&Aplicar";
            this.btnAplicarHorarioPredefinido.UseVisualStyleBackColor = true;
            this.btnAplicarHorarioPredefinido.Click += new System.EventHandler(this.btnAplicarHorarioPredefinido_Click);
            // 
            // cmbHorariosPlantillas
            // 
            this.cmbHorariosPlantillas.FormattingEnabled = true;
            this.cmbHorariosPlantillas.Location = new System.Drawing.Point(18, 19);
            this.cmbHorariosPlantillas.Name = "cmbHorariosPlantillas";
            this.cmbHorariosPlantillas.Size = new System.Drawing.Size(368, 21);
            this.cmbHorariosPlantillas.TabIndex = 29;
            // 
            // btnModificarHorario
            // 
            this.btnModificarHorario.Location = new System.Drawing.Point(555, 130);
            this.btnModificarHorario.Name = "btnModificarHorario";
            this.btnModificarHorario.Size = new System.Drawing.Size(86, 23);
            this.btnModificarHorario.TabIndex = 28;
            this.btnModificarHorario.Text = "Modificar";
            this.btnModificarHorario.UseVisualStyleBackColor = true;
            this.btnModificarHorario.Click += new System.EventHandler(this.btnModificarHorario_Click);
            // 
            // btnEliminarHorario
            // 
            this.btnEliminarHorario.Location = new System.Drawing.Point(555, 159);
            this.btnEliminarHorario.Name = "btnEliminarHorario";
            this.btnEliminarHorario.Size = new System.Drawing.Size(86, 23);
            this.btnEliminarHorario.TabIndex = 27;
            this.btnEliminarHorario.Text = "&Eliminar";
            this.btnEliminarHorario.UseVisualStyleBackColor = true;
            this.btnEliminarHorario.Click += new System.EventHandler(this.btnEliminarHorario_Click);
            // 
            // btnNuevoHorario
            // 
            this.btnNuevoHorario.Location = new System.Drawing.Point(555, 101);
            this.btnNuevoHorario.Name = "btnNuevoHorario";
            this.btnNuevoHorario.Size = new System.Drawing.Size(86, 23);
            this.btnNuevoHorario.TabIndex = 26;
            this.btnNuevoHorario.Text = "&Nuevo";
            this.btnNuevoHorario.UseVisualStyleBackColor = true;
            this.btnNuevoHorario.Click += new System.EventHandler(this.btnNuevoHorario_Click);
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Location = new System.Drawing.Point(15, 31);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.Size = new System.Drawing.Size(523, 256);
            this.dgvHorarios.TabIndex = 0;
            // 
            // tabOtrosDatos
            // 
            this.tabOtrosDatos.Controls.Add(this.lblLegajoConyuge);
            this.tabOtrosDatos.Controls.Add(this.txtLegajoConyuge);
            this.tabOtrosDatos.Location = new System.Drawing.Point(4, 22);
            this.tabOtrosDatos.Name = "tabOtrosDatos";
            this.tabOtrosDatos.Size = new System.Drawing.Size(710, 440);
            this.tabOtrosDatos.TabIndex = 5;
            this.tabOtrosDatos.Text = "Otros Datos";
            this.tabOtrosDatos.UseVisualStyleBackColor = true;
            // 
            // lblLegajoConyuge
            // 
            this.lblLegajoConyuge.AutoSize = true;
            this.lblLegajoConyuge.Location = new System.Drawing.Point(34, 33);
            this.lblLegajoConyuge.Name = "lblLegajoConyuge";
            this.lblLegajoConyuge.Size = new System.Drawing.Size(104, 13);
            this.lblLegajoConyuge.TabIndex = 6;
            this.lblLegajoConyuge.Text = "Legajo del Conyuge:";
            // 
            // txtLegajoConyuge
            // 
            this.txtLegajoConyuge.Location = new System.Drawing.Point(140, 30);
            this.txtLegajoConyuge.Name = "txtLegajoConyuge";
            this.txtLegajoConyuge.Size = new System.Drawing.Size(107, 20);
            this.txtLegajoConyuge.TabIndex = 5;
            this.txtLegajoConyuge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLegajoConyuge.TextChanged += new System.EventHandler(this.txtLegajoConyuge_TextChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(329, 478);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(79, 24);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(216, 478);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(79, 24);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // openFileDialogFoto
            // 
            this.openFileDialogFoto.FileName = "openFileDialog1";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(335, 22);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(41, 13);
            this.lblBanco.TabIndex = 20;
            this.lblBanco.Text = "Banco:";
            // 
            // cmbBancos
            // 
            this.cmbBancos.BackColor = System.Drawing.Color.White;
            this.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBancos.FormattingEnabled = true;
            this.cmbBancos.Location = new System.Drawing.Point(382, 19);
            this.cmbBancos.Name = "cmbBancos";
            this.cmbBancos.Size = new System.Drawing.Size(217, 21);
            this.cmbBancos.TabIndex = 21;
            this.cmbBancos.SelectedIndexChanged += new System.EventHandler(this.cmbBancos_SelectedIndexChanged);
            // 
            // frmDatosEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 514);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.tabEmpleado);
            this.Controls.Add(this.btnCerrar);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDatosEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Empleado";
            this.Load += new System.EventHandler(this.FrmDatosEmpleado_Load);
            this.tabEmpleado.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            this.grpFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.gbFechas.ResumeLayout(false);
            this.gbFechas.PerformLayout();
            this.gbIdentificacion.ResumeLayout(false);
            this.gbIdentificacion.PerformLayout();
            this.gbPersona.ResumeLayout(false);
            this.gbPersona.PerformLayout();
            this.tabRemuneraciones.ResumeLayout(false);
            this.gbSalario.ResumeLayout(false);
            this.gbSalario.PerformLayout();
            this.gbOtrosCampos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).EndInit();
            this.gbBanco.ResumeLayout(false);
            this.gbBanco.PerformLayout();
            this.tabSIJP.ResumeLayout(false);
            this.gbSIJP.ResumeLayout(false);
            this.gbSIJP.PerformLayout();
            this.tabFamiliares.ResumeLayout(false);
            this.gbFamiliares.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliares)).EndInit();
            this.tabVacaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacaciones)).EndInit();
            this.tabAsistencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            this.tabAnticipos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnticipos)).EndInit();
            this.tabPeriodosTrabajados.ResumeLayout(false);
            this.gbPeriodosTrabajados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodos)).EndInit();
            this.tabHorarios.ResumeLayout(false);
            this.gbHorarios.ResumeLayout(false);
            this.gbHorariosPredefinidos.ResumeLayout(false);
            this.gbHorariosPredefinidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.tabOtrosDatos.ResumeLayout(false);
            this.tabOtrosDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TabControl tabEmpleado;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabAsistencia;
        private System.Windows.Forms.TabPage tabRemuneraciones;
        private System.Windows.Forms.TabPage tabFamiliares;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblApellidoyNombres;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtApellidoyNombres;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblCUIL;
        private System.Windows.Forms.MaskedTextBox txtCUIL;
        private System.Windows.Forms.Label lblSueldooJornal;
        private System.Windows.Forms.TextBox txtSueldoOjornal;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTipoLiquidacion;
        private System.Windows.Forms.ComboBox cmbTipoLiquidacion;
        private System.Windows.Forms.Label lblCausaEgreso;
        private System.Windows.Forms.ComboBox cmbCausaEgreso;
        private System.Windows.Forms.Label lblFechaEgreso;
        private System.Windows.Forms.GroupBox gbFechas;
        private System.Windows.Forms.GroupBox gbIdentificacion;
        private System.Windows.Forms.GroupBox gbPersona;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblTelefonoMensajes;
        private System.Windows.Forms.TextBox txtTelefonoMensajes;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtNumeroDoc;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cmbAFJP;
        private System.Windows.Forms.Label lblAFJP;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbCentroDeCosto;
        private System.Windows.Forms.Label lblCentroDeCosto;
        private System.Windows.Forms.DateTimePicker dtpFechaEgreso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.GroupBox grpFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNumeroCuenta;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.Label lblSucursalBanco;
        private System.Windows.Forms.ComboBox cmbSucursalesBanco;
        private System.Windows.Forms.DataGridView dgvCampos;
        private System.Windows.Forms.GroupBox gbBanco;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.ComboBox cmbConvenio;
        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.ComboBox cmbObraSocial;
        private System.Windows.Forms.GroupBox gbOtrosCampos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TabPage tabVacaciones;
        private System.Windows.Forms.DataGridView dgvVacaciones;
        private System.Windows.Forms.GroupBox gbFamiliares;
        private System.Windows.Forms.Button btnEliminarFamiliar;
        private System.Windows.Forms.Button btnNuevoFamiliar;
        private System.Windows.Forms.Button btnModificarFamiliar;
        private System.Windows.Forms.DataGridView dgvFamiliares;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbNacionalidad;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.TabPage tabOtrosDatos;
        private System.Windows.Forms.Label lblLegajoConyuge;
        private System.Windows.Forms.TextBox txtLegajoConyuge;
        private System.Windows.Forms.DataGridView dgvAsistencia;
        private System.Windows.Forms.TabPage tabAnticipos;
        private System.Windows.Forms.DataGridView dgvAnticipos;
        private System.Windows.Forms.GroupBox gbSalario;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbContrato;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.DateTimePicker dtpFechaReIngreso;
        private System.Windows.Forms.Label lblFechaReIngreso;
        private System.Windows.Forms.Label lblSindicato;
        private System.Windows.Forms.ComboBox cmbSindicato;
        private System.Windows.Forms.TabPage tabPeriodosTrabajados;
        private System.Windows.Forms.DataGridView dgvPeriodos;
        private System.Windows.Forms.GroupBox gbPeriodosTrabajados;
        private System.Windows.Forms.Button btnEliminarPeriodoTrabajado;
        private System.Windows.Forms.Button btnNuevoPeriodoTrabajado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnModificarPeriodoTrabajado;
        private System.Windows.Forms.DateTimePicker dtpFechaReconocimiento;
        private System.Windows.Forms.Label lblFechaReconocimiento;
        private System.Windows.Forms.ComboBox cmbFormaDePago;
        private System.Windows.Forms.Label lblFormaDePago;
        private System.Windows.Forms.OpenFileDialog openFileDialogFoto;
        private System.Windows.Forms.TabPage tabHorarios;
        private System.Windows.Forms.GroupBox gbHorarios;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.Button btnModificarHorario;
        private System.Windows.Forms.Button btnEliminarHorario;
        private System.Windows.Forms.Button btnNuevoHorario;
        private System.Windows.Forms.ComboBox cmbHorariosPlantillas;
        private System.Windows.Forms.GroupBox gbHorariosPredefinidos;
        private System.Windows.Forms.Button btnAplicarHorarioPredefinido;
        private System.Windows.Forms.CheckBox chkEliminaExistentes;
        private System.Windows.Forms.TabPage tabSIJP;
        private System.Windows.Forms.GroupBox gbSIJP;
        private System.Windows.Forms.Label lblSituacionDeRevista;
        private System.Windows.Forms.ComboBox cmbSituacionDeRevista;
        private System.Windows.Forms.Label lblModalidadDeContratacion;
        private System.Windows.Forms.ComboBox cmbModalidadDeContratacion;
        private System.Windows.Forms.Label lblCodigoDeActividad;
        private System.Windows.Forms.ComboBox cmbCodigoDeActividad;
        private System.Windows.Forms.Label lblCodigoDeCondicion;
        private System.Windows.Forms.ComboBox cmbCodigoDeCondicion;
        private System.Windows.Forms.Label lblCodigoDeSiniestrado;
        private System.Windows.Forms.ComboBox cmbCodigoDeSiniestrado;
        private System.Windows.Forms.Button btnEliminarVacaciones;
        private System.Windows.Forms.Button btnNuevoVacaciones;
        private System.Windows.Forms.Button btnModificarVacaciones;
        private System.Windows.Forms.ComboBox cmbBancos;
        private System.Windows.Forms.Label lblBanco;
    }
}