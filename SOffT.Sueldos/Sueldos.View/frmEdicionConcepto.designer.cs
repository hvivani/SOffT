/*  
    frmEdicionConcepto.cs

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
    partial class frmEdicionConcepto
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
            this.textBoxConcepto = new System.Windows.Forms.TextBox();
            this.btnSI = new System.Windows.Forms.Button();
            this.btnEntonces = new System.Windows.Forms.Button();
            this.btnSino = new System.Windows.Forms.Button();
            this.btnAccion = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnPor = new System.Windows.Forms.Button();
            this.btnDividido = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnDistinto = new System.Windows.Forms.Button();
            this.btnMenor = new System.Windows.Forms.Button();
            this.btnMenorIgual = new System.Windows.Forms.Button();
            this.btnMayor = new System.Windows.Forms.Button();
            this.btnMayorIgual = new System.Windows.Forms.Button();
            this.btnParentesisAbierto = new System.Windows.Forms.Button();
            this.btnParentesisCerrado = new System.Windows.Forms.Button();
            this.comboBoxOperandoEmpleado = new System.Windows.Forms.ComboBox();
            this.radioButtonVariable = new System.Windows.Forms.RadioButton();
            this.radioButtonAcumulador = new System.Windows.Forms.RadioButton();
            this.radioButtonCampo = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.radioButtonValor = new System.Windows.Forms.RadioButton();
            this.radioButtonNovedad = new System.Windows.Forms.RadioButton();
            this.radioButtonFecha = new System.Windows.Forms.RadioButton();
            this.radioButtonAcumuladoEmpleado = new System.Windows.Forms.RadioButton();
            this.listBoxAccion = new System.Windows.Forms.ListBox();
            this.btnY = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.groupBoxOperacionesAritmeticas = new System.Windows.Forms.GroupBox();
            this.groupBoxOperacionesLogicas = new System.Windows.Forms.GroupBox();
            this.panelYO = new System.Windows.Forms.Panel();
            this.panelOperadoresLogicos = new System.Windows.Forms.Panel();
            this.listBoxFunciones = new System.Windows.Forms.ListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAgregarAccion = new System.Windows.Forms.Button();
            this.btnAgregarFuncion = new System.Windows.Forms.Button();
            this.btnSiguienteParametro = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.groupBoxGrupos = new System.Windows.Forms.GroupBox();
            this.radioButtonTabla = new System.Windows.Forms.RadioButton();
            this.comboBoxTabla = new System.Windows.Forms.ComboBox();
            this.comboBoxOperandosGeneral = new System.Windows.Forms.ComboBox();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.radioButtonAsistencia = new System.Windows.Forms.RadioButton();
            this.radioButtonConstante = new System.Windows.Forms.RadioButton();
            this.groupBoxOperandos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonConcepto = new System.Windows.Forms.RadioButton();
            this.groupBoxFuncion = new System.Windows.Forms.GroupBox();
            this.groupBoxAccion = new System.Windows.Forms.GroupBox();
            this.labelAyuda = new System.Windows.Forms.Label();
            this.groupBoxAyuda = new System.Windows.Forms.GroupBox();
            this.buttonCoseptoCompilar = new System.Windows.Forms.Button();
            this.textBoxConceptoCompilador = new System.Windows.Forms.TextBox();
            this.groupBoxOperacionesAritmeticas.SuspendLayout();
            this.groupBoxOperacionesLogicas.SuspendLayout();
            this.panelYO.SuspendLayout();
            this.panelOperadoresLogicos.SuspendLayout();
            this.groupBoxGrupos.SuspendLayout();
            this.groupBoxOperandos.SuspendLayout();
            this.groupBoxFuncion.SuspendLayout();
            this.groupBoxAccion.SuspendLayout();
            this.groupBoxAyuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxConcepto
            // 
            this.textBoxConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConcepto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxConcepto.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxConcepto.Location = new System.Drawing.Point(11, 404);
            this.textBoxConcepto.Multiline = true;
            this.textBoxConcepto.Name = "textBoxConcepto";
            this.textBoxConcepto.ReadOnly = true;
            this.textBoxConcepto.Size = new System.Drawing.Size(559, 52);
            this.textBoxConcepto.TabIndex = 12;
            // 
            // btnSI
            // 
            this.btnSI.Location = new System.Drawing.Point(92, 13);
            this.btnSI.Name = "btnSI";
            this.btnSI.Size = new System.Drawing.Size(75, 23);
            this.btnSI.TabIndex = 1;
            this.btnSI.Text = "Si";
            this.btnSI.UseVisualStyleBackColor = true;
            this.btnSI.Click += new System.EventHandler(this.btnSI_Click);
            // 
            // btnEntonces
            // 
            this.btnEntonces.Enabled = false;
            this.btnEntonces.Location = new System.Drawing.Point(173, 13);
            this.btnEntonces.Name = "btnEntonces";
            this.btnEntonces.Size = new System.Drawing.Size(75, 23);
            this.btnEntonces.TabIndex = 7;
            this.btnEntonces.Text = "Entonces";
            this.btnEntonces.UseVisualStyleBackColor = true;
            this.btnEntonces.Click += new System.EventHandler(this.btnEntonces_Click);
            // 
            // btnSino
            // 
            this.btnSino.Enabled = false;
            this.btnSino.Location = new System.Drawing.Point(254, 13);
            this.btnSino.Name = "btnSino";
            this.btnSino.Size = new System.Drawing.Size(75, 23);
            this.btnSino.TabIndex = 8;
            this.btnSino.Text = "Sino";
            this.btnSino.UseVisualStyleBackColor = true;
            this.btnSino.Click += new System.EventHandler(this.btnSino_Click);
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(11, 12);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(75, 23);
            this.btnAccion.TabIndex = 0;
            this.btnAccion.Text = "Accion";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // btnMas
            // 
            this.btnMas.Location = new System.Drawing.Point(6, 19);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(31, 23);
            this.btnMas.TabIndex = 0;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.OperacionAritmetica_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(43, 19);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(32, 23);
            this.btnMenos.TabIndex = 1;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.OperacionAritmetica_Click);
            // 
            // btnPor
            // 
            this.btnPor.Location = new System.Drawing.Point(81, 19);
            this.btnPor.Name = "btnPor";
            this.btnPor.Size = new System.Drawing.Size(31, 23);
            this.btnPor.TabIndex = 2;
            this.btnPor.Text = "*";
            this.btnPor.UseVisualStyleBackColor = true;
            this.btnPor.Click += new System.EventHandler(this.OperacionAritmetica_Click);
            // 
            // btnDividido
            // 
            this.btnDividido.Location = new System.Drawing.Point(118, 19);
            this.btnDividido.Name = "btnDividido";
            this.btnDividido.Size = new System.Drawing.Size(32, 23);
            this.btnDividido.TabIndex = 3;
            this.btnDividido.Text = "/";
            this.btnDividido.UseVisualStyleBackColor = true;
            this.btnDividido.Click += new System.EventHandler(this.OperacionAritmetica_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(3, 3);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(85, 22);
            this.btnIgual.TabIndex = 0;
            this.btnIgual.Text = "Igual";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.OperadorLogico_Click);
            // 
            // btnDistinto
            // 
            this.btnDistinto.Location = new System.Drawing.Point(3, 31);
            this.btnDistinto.Name = "btnDistinto";
            this.btnDistinto.Size = new System.Drawing.Size(85, 22);
            this.btnDistinto.TabIndex = 3;
            this.btnDistinto.Text = "Distinto";
            this.btnDistinto.UseVisualStyleBackColor = true;
            this.btnDistinto.Click += new System.EventHandler(this.OperadorLogico_Click);
            // 
            // btnMenor
            // 
            this.btnMenor.Location = new System.Drawing.Point(94, 3);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(85, 22);
            this.btnMenor.TabIndex = 1;
            this.btnMenor.Text = "Menor";
            this.btnMenor.UseVisualStyleBackColor = true;
            this.btnMenor.Click += new System.EventHandler(this.OperadorLogico_Click);
            // 
            // btnMenorIgual
            // 
            this.btnMenorIgual.Location = new System.Drawing.Point(94, 31);
            this.btnMenorIgual.Name = "btnMenorIgual";
            this.btnMenorIgual.Size = new System.Drawing.Size(85, 22);
            this.btnMenorIgual.TabIndex = 4;
            this.btnMenorIgual.Text = "Menor o Igual";
            this.btnMenorIgual.UseVisualStyleBackColor = true;
            this.btnMenorIgual.Click += new System.EventHandler(this.OperadorLogico_Click);
            // 
            // btnMayor
            // 
            this.btnMayor.Location = new System.Drawing.Point(185, 3);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(85, 23);
            this.btnMayor.TabIndex = 2;
            this.btnMayor.Text = "Mayor";
            this.btnMayor.UseVisualStyleBackColor = true;
            this.btnMayor.Click += new System.EventHandler(this.OperadorLogico_Click);
            // 
            // btnMayorIgual
            // 
            this.btnMayorIgual.Location = new System.Drawing.Point(185, 31);
            this.btnMayorIgual.Name = "btnMayorIgual";
            this.btnMayorIgual.Size = new System.Drawing.Size(85, 23);
            this.btnMayorIgual.TabIndex = 5;
            this.btnMayorIgual.Text = "Mayor o Igual";
            this.btnMayorIgual.UseVisualStyleBackColor = true;
            this.btnMayorIgual.Click += new System.EventHandler(this.OperadorLogico_Click);
            // 
            // btnParentesisAbierto
            // 
            this.btnParentesisAbierto.Location = new System.Drawing.Point(6, 19);
            this.btnParentesisAbierto.Name = "btnParentesisAbierto";
            this.btnParentesisAbierto.Size = new System.Drawing.Size(28, 23);
            this.btnParentesisAbierto.TabIndex = 0;
            this.btnParentesisAbierto.Text = "(";
            this.btnParentesisAbierto.UseVisualStyleBackColor = true;
            this.btnParentesisAbierto.Click += new System.EventHandler(this.btnParentesisAbierto_Click);
            // 
            // btnParentesisCerrado
            // 
            this.btnParentesisCerrado.Enabled = false;
            this.btnParentesisCerrado.Location = new System.Drawing.Point(40, 19);
            this.btnParentesisCerrado.Name = "btnParentesisCerrado";
            this.btnParentesisCerrado.Size = new System.Drawing.Size(31, 23);
            this.btnParentesisCerrado.TabIndex = 1;
            this.btnParentesisCerrado.Text = ")";
            this.btnParentesisCerrado.UseVisualStyleBackColor = true;
            this.btnParentesisCerrado.Click += new System.EventHandler(this.btnParentesisCerrado_Click);
            // 
            // comboBoxOperandoEmpleado
            // 
            this.comboBoxOperandoEmpleado.DisplayMember = "indice";
            this.comboBoxOperandoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperandoEmpleado.Enabled = false;
            this.comboBoxOperandoEmpleado.FormattingEnabled = true;
            this.comboBoxOperandoEmpleado.Location = new System.Drawing.Point(14, 169);
            this.comboBoxOperandoEmpleado.Name = "comboBoxOperandoEmpleado";
            this.comboBoxOperandoEmpleado.Size = new System.Drawing.Size(309, 21);
            this.comboBoxOperandoEmpleado.TabIndex = 17;
            this.comboBoxOperandoEmpleado.ValueMember = "indice";
            // 
            // radioButtonVariable
            // 
            this.radioButtonVariable.AutoSize = true;
            this.radioButtonVariable.Checked = true;
            this.radioButtonVariable.Location = new System.Drawing.Point(14, 32);
            this.radioButtonVariable.Name = "radioButtonVariable";
            this.radioButtonVariable.Size = new System.Drawing.Size(63, 17);
            this.radioButtonVariable.TabIndex = 1;
            this.radioButtonVariable.TabStop = true;
            this.radioButtonVariable.Text = "Variable";
            this.radioButtonVariable.UseVisualStyleBackColor = true;
            this.radioButtonVariable.CheckedChanged += new System.EventHandler(this.radioButtonOperandos_CheckedChanged);
            // 
            // radioButtonAcumulador
            // 
            this.radioButtonAcumulador.AutoSize = true;
            this.radioButtonAcumulador.Location = new System.Drawing.Point(83, 32);
            this.radioButtonAcumulador.Name = "radioButtonAcumulador";
            this.radioButtonAcumulador.Size = new System.Drawing.Size(81, 17);
            this.radioButtonAcumulador.TabIndex = 2;
            this.radioButtonAcumulador.Text = "Acumulador";
            this.radioButtonAcumulador.UseVisualStyleBackColor = true;
            this.radioButtonAcumulador.CheckedChanged += new System.EventHandler(this.radioButtonOperandos_CheckedChanged);
            // 
            // radioButtonCampo
            // 
            this.radioButtonCampo.AutoSize = true;
            this.radioButtonCampo.Location = new System.Drawing.Point(14, 146);
            this.radioButtonCampo.Name = "radioButtonCampo";
            this.radioButtonCampo.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCampo.TabIndex = 13;
            this.radioButtonCampo.Text = "Campo";
            this.radioButtonCampo.UseVisualStyleBackColor = true;
            this.radioButtonCampo.CheckedChanged += new System.EventHandler(this.radioButtonOperandos_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(329, 169);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 23);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValor.Enabled = false;
            this.textBoxValor.Location = new System.Drawing.Point(72, 80);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(376, 20);
            this.textBoxValor.TabIndex = 8;
            // 
            // radioButtonValor
            // 
            this.radioButtonValor.AutoSize = true;
            this.radioButtonValor.Location = new System.Drawing.Point(14, 81);
            this.radioButtonValor.Name = "radioButtonValor";
            this.radioButtonValor.Size = new System.Drawing.Size(49, 17);
            this.radioButtonValor.TabIndex = 7;
            this.radioButtonValor.Text = "Valor";
            this.radioButtonValor.UseVisualStyleBackColor = true;
            this.radioButtonValor.CheckedChanged += new System.EventHandler(this.radioButtonOperandos_CheckedChanged);
            // 
            // radioButtonNovedad
            // 
            this.radioButtonNovedad.AutoSize = true;
            this.radioButtonNovedad.Location = new System.Drawing.Point(78, 146);
            this.radioButtonNovedad.Name = "radioButtonNovedad";
            this.radioButtonNovedad.Size = new System.Drawing.Size(69, 17);
            this.radioButtonNovedad.TabIndex = 14;
            this.radioButtonNovedad.Text = "Novedad";
            this.radioButtonNovedad.UseVisualStyleBackColor = true;
            this.radioButtonNovedad.CheckedChanged += new System.EventHandler(this.radioButtonOperandos_CheckedChanged);
            // 
            // radioButtonFecha
            // 
            this.radioButtonFecha.AutoSize = true;
            this.radioButtonFecha.Location = new System.Drawing.Point(153, 146);
            this.radioButtonFecha.Name = "radioButtonFecha";
            this.radioButtonFecha.Size = new System.Drawing.Size(55, 17);
            this.radioButtonFecha.TabIndex = 15;
            this.radioButtonFecha.Text = "Fecha";
            this.radioButtonFecha.UseVisualStyleBackColor = true;
            this.radioButtonFecha.CheckedChanged += new System.EventHandler(this.radioButtonOperandos_CheckedChanged);
            // 
            // radioButtonAcumuladoEmpleado
            // 
            this.radioButtonAcumuladoEmpleado.AutoSize = true;
            this.radioButtonAcumuladoEmpleado.Location = new System.Drawing.Point(214, 146);
            this.radioButtonAcumuladoEmpleado.Name = "radioButtonAcumuladoEmpleado";
            this.radioButtonAcumuladoEmpleado.Size = new System.Drawing.Size(78, 17);
            this.radioButtonAcumuladoEmpleado.TabIndex = 16;
            this.radioButtonAcumuladoEmpleado.Text = "Acumulado";
            this.radioButtonAcumuladoEmpleado.UseVisualStyleBackColor = true;
            this.radioButtonAcumuladoEmpleado.CheckedChanged += new System.EventHandler(this.radioButtonOperandos_CheckedChanged);
            // 
            // listBoxAccion
            // 
            this.listBoxAccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAccion.FormattingEnabled = true;
            this.listBoxAccion.Items.AddRange(new object[] {
            "Guardar",
            "Guardar Acumulado",
            "Acumular",
            "Actualizar Campo Empleado",
            "Seguir",
            "Saltar"});
            this.listBoxAccion.Location = new System.Drawing.Point(6, 19);
            this.listBoxAccion.Name = "listBoxAccion";
            this.listBoxAccion.Size = new System.Drawing.Size(165, 82);
            this.listBoxAccion.TabIndex = 0;
            this.listBoxAccion.Click += new System.EventHandler(this.listBoxAccion_Click);
            // 
            // btnY
            // 
            this.btnY.Location = new System.Drawing.Point(3, 3);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(31, 23);
            this.btnY.TabIndex = 0;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnO
            // 
            this.btnO.Location = new System.Drawing.Point(3, 31);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(31, 23);
            this.btnO.TabIndex = 1;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // groupBoxOperacionesAritmeticas
            // 
            this.groupBoxOperacionesAritmeticas.Controls.Add(this.btnMas);
            this.groupBoxOperacionesAritmeticas.Controls.Add(this.btnMenos);
            this.groupBoxOperacionesAritmeticas.Controls.Add(this.btnPor);
            this.groupBoxOperacionesAritmeticas.Controls.Add(this.btnDividido);
            this.groupBoxOperacionesAritmeticas.Enabled = false;
            this.groupBoxOperacionesAritmeticas.Location = new System.Drawing.Point(195, 131);
            this.groupBoxOperacionesAritmeticas.Name = "groupBoxOperacionesAritmeticas";
            this.groupBoxOperacionesAritmeticas.Size = new System.Drawing.Size(155, 52);
            this.groupBoxOperacionesAritmeticas.TabIndex = 6;
            this.groupBoxOperacionesAritmeticas.TabStop = false;
            this.groupBoxOperacionesAritmeticas.Text = "Operadores Aritmeticos";
            // 
            // groupBoxOperacionesLogicas
            // 
            this.groupBoxOperacionesLogicas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxOperacionesLogicas.Controls.Add(this.panelYO);
            this.groupBoxOperacionesLogicas.Controls.Add(this.panelOperadoresLogicos);
            this.groupBoxOperacionesLogicas.Enabled = false;
            this.groupBoxOperacionesLogicas.Location = new System.Drawing.Point(195, 42);
            this.groupBoxOperacionesLogicas.Name = "groupBoxOperacionesLogicas";
            this.groupBoxOperacionesLogicas.Size = new System.Drawing.Size(323, 83);
            this.groupBoxOperacionesLogicas.TabIndex = 5;
            this.groupBoxOperacionesLogicas.TabStop = false;
            this.groupBoxOperacionesLogicas.Text = "Operadores Logicos";
            // 
            // panelYO
            // 
            this.panelYO.AutoSize = true;
            this.panelYO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelYO.Controls.Add(this.btnO);
            this.panelYO.Controls.Add(this.btnY);
            this.panelYO.Enabled = false;
            this.panelYO.Location = new System.Drawing.Point(6, 19);
            this.panelYO.Name = "panelYO";
            this.panelYO.Size = new System.Drawing.Size(37, 57);
            this.panelYO.TabIndex = 0;
            // 
            // panelOperadoresLogicos
            // 
            this.panelOperadoresLogicos.AutoSize = true;
            this.panelOperadoresLogicos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelOperadoresLogicos.Controls.Add(this.btnDistinto);
            this.panelOperadoresLogicos.Controls.Add(this.btnIgual);
            this.panelOperadoresLogicos.Controls.Add(this.btnMenor);
            this.panelOperadoresLogicos.Controls.Add(this.btnMayor);
            this.panelOperadoresLogicos.Controls.Add(this.btnMenorIgual);
            this.panelOperadoresLogicos.Controls.Add(this.btnMayorIgual);
            this.panelOperadoresLogicos.Location = new System.Drawing.Point(46, 19);
            this.panelOperadoresLogicos.Name = "panelOperadoresLogicos";
            this.panelOperadoresLogicos.Size = new System.Drawing.Size(273, 57);
            this.panelOperadoresLogicos.TabIndex = 1;
            // 
            // listBoxFunciones
            // 
            this.listBoxFunciones.FormattingEnabled = true;
            this.listBoxFunciones.Items.AddRange(new object[] {
            "Redondear",
            "Buscar Importe",
            "Dias entre Fechas",
            "Años",
            "Total Concepto Importe",
            "Acumulado Mayor Entre Fechas",
            "Asistencia Empleado Entre Dias"});
            this.listBoxFunciones.Location = new System.Drawing.Point(6, 16);
            this.listBoxFunciones.Name = "listBoxFunciones";
            this.listBoxFunciones.Size = new System.Drawing.Size(165, 147);
            this.listBoxFunciones.TabIndex = 0;
            this.listBoxFunciones.SelectedIndexChanged += new System.EventHandler(this.listBoxFunciones_SelectedIndexChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(577, 433);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAgregarAccion
            // 
            this.btnAgregarAccion.Enabled = false;
            this.btnAgregarAccion.Location = new System.Drawing.Point(96, 106);
            this.btnAgregarAccion.Name = "btnAgregarAccion";
            this.btnAgregarAccion.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarAccion.TabIndex = 1;
            this.btnAgregarAccion.Text = "Agregar";
            this.btnAgregarAccion.UseVisualStyleBackColor = true;
            this.btnAgregarAccion.Click += new System.EventHandler(this.btnAgregarAccion_Click);
            // 
            // btnAgregarFuncion
            // 
            this.btnAgregarFuncion.Enabled = false;
            this.btnAgregarFuncion.Location = new System.Drawing.Point(96, 169);
            this.btnAgregarFuncion.Name = "btnAgregarFuncion";
            this.btnAgregarFuncion.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarFuncion.TabIndex = 1;
            this.btnAgregarFuncion.Text = "Agregar";
            this.btnAgregarFuncion.UseVisualStyleBackColor = true;
            this.btnAgregarFuncion.Click += new System.EventHandler(this.btnAgregarFuncion_Click);
            // 
            // btnSiguienteParametro
            // 
            this.btnSiguienteParametro.Enabled = false;
            this.btnSiguienteParametro.Location = new System.Drawing.Point(329, 140);
            this.btnSiguienteParametro.Name = "btnSiguienteParametro";
            this.btnSiguienteParametro.Size = new System.Drawing.Size(119, 23);
            this.btnSiguienteParametro.TabIndex = 18;
            this.btnSiguienteParametro.Text = "Siguiente Parametro";
            this.btnSiguienteParametro.UseVisualStyleBackColor = true;
            this.btnSiguienteParametro.Click += new System.EventHandler(this.btnSiguienteParametro_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabar.Enabled = false;
            this.btnGrabar.Location = new System.Drawing.Point(577, 403);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 9;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // groupBoxGrupos
            // 
            this.groupBoxGrupos.Controls.Add(this.btnParentesisAbierto);
            this.groupBoxGrupos.Controls.Add(this.btnParentesisCerrado);
            this.groupBoxGrupos.Enabled = false;
            this.groupBoxGrupos.Location = new System.Drawing.Point(440, 131);
            this.groupBoxGrupos.Name = "groupBoxGrupos";
            this.groupBoxGrupos.Size = new System.Drawing.Size(78, 52);
            this.groupBoxGrupos.TabIndex = 4;
            this.groupBoxGrupos.TabStop = false;
            this.groupBoxGrupos.Text = "Grupos";
            // 
            // radioButtonTabla
            // 
            this.radioButtonTabla.AutoSize = true;
            this.radioButtonTabla.Location = new System.Drawing.Point(14, 107);
            this.radioButtonTabla.Name = "radioButtonTabla";
            this.radioButtonTabla.Size = new System.Drawing.Size(52, 17);
            this.radioButtonTabla.TabIndex = 9;
            this.radioButtonTabla.Text = "Tabla";
            this.radioButtonTabla.UseVisualStyleBackColor = true;
            this.radioButtonTabla.CheckedChanged += new System.EventHandler(this.radioButtonOperandos_CheckedChanged);
            // 
            // comboBoxTabla
            // 
            this.comboBoxTabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTabla.DisplayMember = "nombre";
            this.comboBoxTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTabla.Enabled = false;
            this.comboBoxTabla.FormattingEnabled = true;
            this.comboBoxTabla.Location = new System.Drawing.Point(72, 106);
            this.comboBoxTabla.Name = "comboBoxTabla";
            this.comboBoxTabla.Size = new System.Drawing.Size(179, 21);
            this.comboBoxTabla.TabIndex = 10;
            this.comboBoxTabla.ValueMember = "nombre";
            this.comboBoxTabla.SelectedIndexChanged += new System.EventHandler(this.comboBoxTabla_SelectedIndexChanged);
            // 
            // comboBoxOperandosGeneral
            // 
            this.comboBoxOperandosGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOperandosGeneral.DisplayMember = "indice";
            this.comboBoxOperandosGeneral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperandosGeneral.FormattingEnabled = true;
            this.comboBoxOperandosGeneral.Location = new System.Drawing.Point(14, 53);
            this.comboBoxOperandosGeneral.Name = "comboBoxOperandosGeneral";
            this.comboBoxOperandosGeneral.Size = new System.Drawing.Size(434, 21);
            this.comboBoxOperandosGeneral.TabIndex = 6;
            this.comboBoxOperandosGeneral.ValueMember = "indice";
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCampo.DisplayMember = "indice";
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.Enabled = false;
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(257, 106);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(191, 21);
            this.comboBoxCampo.TabIndex = 11;
            this.comboBoxCampo.ValueMember = "indice";
            // 
            // radioButtonAsistencia
            // 
            this.radioButtonAsistencia.AutoSize = true;
            this.radioButtonAsistencia.Location = new System.Drawing.Point(167, 32);
            this.radioButtonAsistencia.Name = "radioButtonAsistencia";
            this.radioButtonAsistencia.Size = new System.Drawing.Size(73, 17);
            this.radioButtonAsistencia.TabIndex = 3;
            this.radioButtonAsistencia.Text = "Asistencia";
            this.radioButtonAsistencia.UseVisualStyleBackColor = true;
            this.radioButtonAsistencia.CheckedChanged += new System.EventHandler(this.radioButtonOperandos_CheckedChanged);
            // 
            // radioButtonConstante
            // 
            this.radioButtonConstante.AutoSize = true;
            this.radioButtonConstante.Location = new System.Drawing.Point(246, 32);
            this.radioButtonConstante.Name = "radioButtonConstante";
            this.radioButtonConstante.Size = new System.Drawing.Size(73, 17);
            this.radioButtonConstante.TabIndex = 4;
            this.radioButtonConstante.Text = "Constante";
            this.radioButtonConstante.UseVisualStyleBackColor = true;
            this.radioButtonConstante.CheckedChanged += new System.EventHandler(this.radioButtonOperandos_CheckedChanged);
            // 
            // groupBoxOperandos
            // 
            this.groupBoxOperandos.Controls.Add(this.label2);
            this.groupBoxOperandos.Controls.Add(this.label1);
            this.groupBoxOperandos.Controls.Add(this.radioButtonVariable);
            this.groupBoxOperandos.Controls.Add(this.radioButtonAcumulador);
            this.groupBoxOperandos.Controls.Add(this.radioButtonAsistencia);
            this.groupBoxOperandos.Controls.Add(this.radioButtonConstante);
            this.groupBoxOperandos.Controls.Add(this.radioButtonConcepto);
            this.groupBoxOperandos.Controls.Add(this.comboBoxOperandosGeneral);
            this.groupBoxOperandos.Controls.Add(this.radioButtonValor);
            this.groupBoxOperandos.Controls.Add(this.textBoxValor);
            this.groupBoxOperandos.Controls.Add(this.radioButtonTabla);
            this.groupBoxOperandos.Controls.Add(this.comboBoxTabla);
            this.groupBoxOperandos.Controls.Add(this.comboBoxCampo);
            this.groupBoxOperandos.Controls.Add(this.radioButtonCampo);
            this.groupBoxOperandos.Controls.Add(this.radioButtonNovedad);
            this.groupBoxOperandos.Controls.Add(this.radioButtonFecha);
            this.groupBoxOperandos.Controls.Add(this.radioButtonAcumuladoEmpleado);
            this.groupBoxOperandos.Controls.Add(this.comboBoxOperandoEmpleado);
            this.groupBoxOperandos.Controls.Add(this.btnSiguienteParametro);
            this.groupBoxOperandos.Controls.Add(this.btnAgregar);
            this.groupBoxOperandos.Location = new System.Drawing.Point(195, 189);
            this.groupBoxOperandos.Name = "groupBoxOperandos";
            this.groupBoxOperandos.Size = new System.Drawing.Size(454, 203);
            this.groupBoxOperandos.TabIndex = 1;
            this.groupBoxOperandos.TabStop = false;
            this.groupBoxOperandos.Text = "Operador General";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "General";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Empleado";
            // 
            // radioButtonConcepto
            // 
            this.radioButtonConcepto.AutoSize = true;
            this.radioButtonConcepto.Location = new System.Drawing.Point(325, 32);
            this.radioButtonConcepto.Name = "radioButtonConcepto";
            this.radioButtonConcepto.Size = new System.Drawing.Size(70, 17);
            this.radioButtonConcepto.TabIndex = 5;
            this.radioButtonConcepto.Text = "Consepto";
            this.radioButtonConcepto.UseVisualStyleBackColor = true;
            this.radioButtonConcepto.CheckedChanged += new System.EventHandler(this.radioButtonOperandos_CheckedChanged);
            // 
            // groupBoxFuncion
            // 
            this.groupBoxFuncion.Controls.Add(this.listBoxFunciones);
            this.groupBoxFuncion.Controls.Add(this.btnAgregarFuncion);
            this.groupBoxFuncion.Location = new System.Drawing.Point(12, 189);
            this.groupBoxFuncion.Name = "groupBoxFuncion";
            this.groupBoxFuncion.Size = new System.Drawing.Size(177, 203);
            this.groupBoxFuncion.TabIndex = 0;
            this.groupBoxFuncion.TabStop = false;
            this.groupBoxFuncion.Text = "Funcion";
            // 
            // groupBoxAccion
            // 
            this.groupBoxAccion.Controls.Add(this.listBoxAccion);
            this.groupBoxAccion.Controls.Add(this.btnAgregarAccion);
            this.groupBoxAccion.Enabled = false;
            this.groupBoxAccion.Location = new System.Drawing.Point(12, 42);
            this.groupBoxAccion.Name = "groupBoxAccion";
            this.groupBoxAccion.Size = new System.Drawing.Size(177, 141);
            this.groupBoxAccion.TabIndex = 2;
            this.groupBoxAccion.TabStop = false;
            this.groupBoxAccion.Text = "Accion";
            // 
            // labelAyuda
            // 
            this.labelAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAyuda.Location = new System.Drawing.Point(3, 16);
            this.labelAyuda.Name = "labelAyuda";
            this.labelAyuda.Size = new System.Drawing.Size(125, 122);
            this.labelAyuda.TabIndex = 0;
            // 
            // groupBoxAyuda
            // 
            this.groupBoxAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAyuda.Controls.Add(this.labelAyuda);
            this.groupBoxAyuda.Location = new System.Drawing.Point(524, 42);
            this.groupBoxAyuda.Name = "groupBoxAyuda";
            this.groupBoxAyuda.Size = new System.Drawing.Size(131, 141);
            this.groupBoxAyuda.TabIndex = 11;
            this.groupBoxAyuda.TabStop = false;
            this.groupBoxAyuda.Text = "Ayuda";
            // 
            // buttonCoseptoCompilar
            // 
            this.buttonCoseptoCompilar.Location = new System.Drawing.Point(555, 12);
            this.buttonCoseptoCompilar.Name = "buttonCoseptoCompilar";
            this.buttonCoseptoCompilar.Size = new System.Drawing.Size(75, 23);
            this.buttonCoseptoCompilar.TabIndex = 13;
            this.buttonCoseptoCompilar.Text = "button1";
            this.buttonCoseptoCompilar.UseVisualStyleBackColor = true;
            this.buttonCoseptoCompilar.Visible = false;
            this.buttonCoseptoCompilar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxConceptoCompilador
            // 
            this.textBoxConceptoCompilador.Location = new System.Drawing.Point(336, 6);
            this.textBoxConceptoCompilador.Multiline = true;
            this.textBoxConceptoCompilador.Name = "textBoxConceptoCompilador";
            this.textBoxConceptoCompilador.Size = new System.Drawing.Size(213, 30);
            this.textBoxConceptoCompilador.TabIndex = 14;
            this.textBoxConceptoCompilador.Visible = false;
            // 
            // frmEdicionConcepto
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(664, 468);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.btnSI);
            this.Controls.Add(this.btnEntonces);
            this.Controls.Add(this.btnSino);
            this.Controls.Add(this.groupBoxAccion);
            this.Controls.Add(this.groupBoxFuncion);
            this.Controls.Add(this.groupBoxOperacionesLogicas);
            this.Controls.Add(this.groupBoxOperacionesAritmeticas);
            this.Controls.Add(this.groupBoxGrupos);
            this.Controls.Add(this.groupBoxOperandos);
            this.Controls.Add(this.groupBoxAyuda);
            this.Controls.Add(this.textBoxConceptoCompilador);
            this.Controls.Add(this.buttonCoseptoCompilar);
            this.Controls.Add(this.textBoxConcepto);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCerrar);
            this.Name = "frmEdicionConcepto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Formulas";
            this.groupBoxOperacionesAritmeticas.ResumeLayout(false);
            this.groupBoxOperacionesLogicas.ResumeLayout(false);
            this.groupBoxOperacionesLogicas.PerformLayout();
            this.panelYO.ResumeLayout(false);
            this.panelOperadoresLogicos.ResumeLayout(false);
            this.groupBoxGrupos.ResumeLayout(false);
            this.groupBoxOperandos.ResumeLayout(false);
            this.groupBoxOperandos.PerformLayout();
            this.groupBoxFuncion.ResumeLayout(false);
            this.groupBoxAccion.ResumeLayout(false);
            this.groupBoxAyuda.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConcepto;
        private System.Windows.Forms.Button btnSI;
        private System.Windows.Forms.Button btnEntonces;
        private System.Windows.Forms.Button btnSino;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnPor;
        private System.Windows.Forms.Button btnDividido;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnDistinto;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.Button btnMenorIgual;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.Button btnMayorIgual;
        private System.Windows.Forms.Button btnParentesisAbierto;
        private System.Windows.Forms.Button btnParentesisCerrado;
        private System.Windows.Forms.ComboBox comboBoxOperandoEmpleado;
        private System.Windows.Forms.RadioButton radioButtonVariable;
        private System.Windows.Forms.RadioButton radioButtonAcumulador;
        private System.Windows.Forms.RadioButton radioButtonCampo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.RadioButton radioButtonValor;
        private System.Windows.Forms.ListBox listBoxAccion;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.GroupBox groupBoxOperacionesAritmeticas;
        private System.Windows.Forms.GroupBox groupBoxOperacionesLogicas;
        private System.Windows.Forms.ListBox listBoxFunciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAgregarAccion;
        private System.Windows.Forms.Button btnAgregarFuncion;
        private System.Windows.Forms.Button btnSiguienteParametro;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.GroupBox groupBoxGrupos;
        private System.Windows.Forms.RadioButton radioButtonTabla;
        private System.Windows.Forms.ComboBox comboBoxTabla;
        private System.Windows.Forms.RadioButton radioButtonNovedad;
        private System.Windows.Forms.ComboBox comboBoxOperandosGeneral;
        private System.Windows.Forms.RadioButton radioButtonFecha;
        private System.Windows.Forms.RadioButton radioButtonAcumuladoEmpleado;
        private System.Windows.Forms.RadioButton radioButtonAsistencia;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.RadioButton radioButtonConstante;
        private System.Windows.Forms.GroupBox groupBoxOperandos;
        private System.Windows.Forms.GroupBox groupBoxFuncion;
        private System.Windows.Forms.GroupBox groupBoxAccion;
        private System.Windows.Forms.RadioButton radioButtonConcepto;
        private System.Windows.Forms.Panel panelOperadoresLogicos;
        private System.Windows.Forms.Label labelAyuda;
        private System.Windows.Forms.GroupBox groupBoxAyuda;
        private System.Windows.Forms.Panel panelYO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCoseptoCompilar;
        private System.Windows.Forms.TextBox textBoxConceptoCompilador;
    }
}