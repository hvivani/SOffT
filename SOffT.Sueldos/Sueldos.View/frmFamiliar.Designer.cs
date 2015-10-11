/*  
    frmFamiliar.cs

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
    partial class frmFamiliar
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
            this.txtApellidoYNombres = new System.Windows.Forms.TextBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblApellidoYNombres = new System.Windows.Forms.Label();
            this.lblParentesco = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNumeroDoc = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaBaja = new System.Windows.Forms.DateTimePicker();
            this.lblFechaBaja = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.cmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cmbParentesco = new System.Windows.Forms.ComboBox();
            this.chkGeneraSalario = new System.Windows.Forms.CheckBox();
            this.chkDeclaradoParaGanancias = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtApellidoYNombres
            // 
            this.txtApellidoYNombres.Location = new System.Drawing.Point(113, 19);
            this.txtApellidoYNombres.Name = "txtApellidoYNombres";
            this.txtApellidoYNombres.Size = new System.Drawing.Size(310, 20);
            this.txtApellidoYNombres.TabIndex = 1;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(109, 77);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(87, 21);
            this.cmbTipoDocumento.TabIndex = 2;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(255, 78);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(135, 20);
            this.txtNumeroDocumento.TabIndex = 3;
            // 
            // lblApellidoYNombres
            // 
            this.lblApellidoYNombres.AutoSize = true;
            this.lblApellidoYNombres.Location = new System.Drawing.Point(7, 22);
            this.lblApellidoYNombres.Name = "lblApellidoYNombres";
            this.lblApellidoYNombres.Size = new System.Drawing.Size(100, 13);
            this.lblApellidoYNombres.TabIndex = 4;
            this.lblApellidoYNombres.Text = "Apellido y Nombres:";
            // 
            // lblParentesco
            // 
            this.lblParentesco.AutoSize = true;
            this.lblParentesco.Location = new System.Drawing.Point(7, 51);
            this.lblParentesco.Name = "lblParentesco";
            this.lblParentesco.Size = new System.Drawing.Size(64, 13);
            this.lblParentesco.TabIndex = 5;
            this.lblParentesco.Text = "Parentesco:";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(7, 80);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(89, 13);
            this.lblTipoDoc.TabIndex = 6;
            this.lblTipoDoc.Text = "Tipo Documento:";
            // 
            // lblNumeroDoc
            // 
            this.lblNumeroDoc.AutoSize = true;
            this.lblNumeroDoc.Location = new System.Drawing.Point(202, 80);
            this.lblNumeroDoc.Name = "lblNumeroDoc";
            this.lblNumeroDoc.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroDoc.TabIndex = 7;
            this.lblNumeroDoc.Text = "Numero:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(109, 116);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(87, 20);
            this.dtpFechaNacimiento.TabIndex = 8;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(7, 120);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(96, 13);
            this.lblFechaNacimiento.TabIndex = 9;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(233, 120);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(61, 13);
            this.lblFechaAlta.TabIndex = 10;
            this.lblFechaAlta.Text = "Fecha Alta:";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlta.Location = new System.Drawing.Point(303, 116);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(87, 20);
            this.dtpFechaAlta.TabIndex = 11;
            // 
            // dtpFechaBaja
            // 
            this.dtpFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaBaja.Location = new System.Drawing.Point(303, 151);
            this.dtpFechaBaja.Name = "dtpFechaBaja";
            this.dtpFechaBaja.Size = new System.Drawing.Size(87, 20);
            this.dtpFechaBaja.TabIndex = 13;
            // 
            // lblFechaBaja
            // 
            this.lblFechaBaja.AutoSize = true;
            this.lblFechaBaja.Location = new System.Drawing.Point(233, 155);
            this.lblFechaBaja.Name = "lblFechaBaja";
            this.lblFechaBaja.Size = new System.Drawing.Size(64, 13);
            this.lblFechaBaja.TabIndex = 12;
            this.lblFechaBaja.Text = "Fecha Baja:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(7, 174);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 15;
            this.lblSexo.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(56, 171);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(140, 21);
            this.cmbSexo.TabIndex = 14;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(7, 211);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(72, 13);
            this.lblNacionalidad.TabIndex = 17;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Location = new System.Drawing.Point(85, 208);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(140, 21);
            this.cmbNacionalidad.TabIndex = 16;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(7, 238);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadoCivil.TabIndex = 19;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(85, 235);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(140, 21);
            this.cmbEstadoCivil.TabIndex = 18;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(184, 280);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(99, 25);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cmbParentesco
            // 
            this.cmbParentesco.FormattingEnabled = true;
            this.cmbParentesco.Location = new System.Drawing.Point(77, 48);
            this.cmbParentesco.Name = "cmbParentesco";
            this.cmbParentesco.Size = new System.Drawing.Size(140, 21);
            this.cmbParentesco.TabIndex = 21;
            // 
            // chkGeneraSalario
            // 
            this.chkGeneraSalario.AutoSize = true;
            this.chkGeneraSalario.Location = new System.Drawing.Point(288, 210);
            this.chkGeneraSalario.Name = "chkGeneraSalario";
            this.chkGeneraSalario.Size = new System.Drawing.Size(96, 17);
            this.chkGeneraSalario.TabIndex = 22;
            this.chkGeneraSalario.Text = "Genera Salario";
            this.chkGeneraSalario.UseVisualStyleBackColor = true;
            this.chkGeneraSalario.CheckedChanged += new System.EventHandler(this.chkGeneraSalario_CheckedChanged);
            // 
            // chkDeclaradoParaGanancias
            // 
            this.chkDeclaradoParaGanancias.AutoSize = true;
            this.chkDeclaradoParaGanancias.Location = new System.Drawing.Point(288, 233);
            this.chkDeclaradoParaGanancias.Name = "chkDeclaradoParaGanancias";
            this.chkDeclaradoParaGanancias.Size = new System.Drawing.Size(153, 17);
            this.chkDeclaradoParaGanancias.TabIndex = 23;
            this.chkDeclaradoParaGanancias.Text = "Declarado para Ganancias";
            this.chkDeclaradoParaGanancias.UseVisualStyleBackColor = true;
            // 
            // frmFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 317);
            this.Controls.Add(this.chkDeclaradoParaGanancias);
            this.Controls.Add(this.chkGeneraSalario);
            this.Controls.Add(this.cmbParentesco);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.cmbEstadoCivil);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.cmbNacionalidad);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.dtpFechaBaja);
            this.Controls.Add(this.lblFechaBaja);
            this.Controls.Add(this.dtpFechaAlta);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblNumeroDoc);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblParentesco);
            this.Controls.Add(this.lblApellidoYNombres);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.txtApellidoYNombres);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFamiliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Familiar";
            this.Load += new System.EventHandler(this.frmFamiliar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellidoYNombres;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label lblApellidoYNombres;
        private System.Windows.Forms.Label lblParentesco;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblNumeroDoc;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.DateTimePicker dtpFechaBaja;
        private System.Windows.Forms.Label lblFechaBaja;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.ComboBox cmbNacionalidad;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cmbParentesco;
        private System.Windows.Forms.CheckBox chkGeneraSalario;
        private System.Windows.Forms.CheckBox chkDeclaradoParaGanancias;
    }
}