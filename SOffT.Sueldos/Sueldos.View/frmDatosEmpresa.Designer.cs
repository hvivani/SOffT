/*  
    frmDatosEmpresa.cs

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
    partial class frmDatosEmpresa
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
            System.Windows.Forms.Label codigoActividadLabel;
            System.Windows.Forms.Label cUITLabel;
            System.Windows.Forms.Label cuotaFijaLRTLabel;
            System.Windows.Forms.Label domicilioLabel;
            System.Windows.Forms.Label localidadLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label porcentajeAlicuotaLRTLabel;
            System.Windows.Forms.Label provinciaLabel;
            System.Windows.Forms.Label razonSocialLabel;
            System.Windows.Forms.Label tipoEmpleadorLabel;
            System.Windows.Forms.Label ultimaRubricaLabel;
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtCUIT = new System.Windows.Forms.MaskedTextBox();
            this.empresaEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAsignarImagen = new System.Windows.Forms.Button();
            this.pbLogotipo = new System.Windows.Forms.PictureBox();
            this.codigoActividadComboBox = new System.Windows.Forms.ComboBox();
            this.correspondeReduccionCheckBox = new System.Windows.Forms.CheckBox();
            this.cuotaFijaLRTTextBox = new System.Windows.Forms.TextBox();
            this.domicilioTextBox = new System.Windows.Forms.TextBox();
            this.localidadTextBox = new System.Windows.Forms.TextBox();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.porcentajeAlicuotaLRTTextBox = new System.Windows.Forms.TextBox();
            this.provinciaTextBox = new System.Windows.Forms.TextBox();
            this.razonSocialTextBox = new System.Windows.Forms.TextBox();
            this.tipoEmpleadorComboBox = new System.Windows.Forms.ComboBox();
            this.ultimaRubricaTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialogImagen = new System.Windows.Forms.OpenFileDialog();
            codigoActividadLabel = new System.Windows.Forms.Label();
            cUITLabel = new System.Windows.Forms.Label();
            cuotaFijaLRTLabel = new System.Windows.Forms.Label();
            domicilioLabel = new System.Windows.Forms.Label();
            localidadLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            porcentajeAlicuotaLRTLabel = new System.Windows.Forms.Label();
            provinciaLabel = new System.Windows.Forms.Label();
            razonSocialLabel = new System.Windows.Forms.Label();
            tipoEmpleadorLabel = new System.Windows.Forms.Label();
            ultimaRubricaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empresaEntityBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoActividadLabel
            // 
            codigoActividadLabel.AutoSize = true;
            codigoActividadLabel.Location = new System.Drawing.Point(36, 214);
            codigoActividadLabel.Name = "codigoActividadLabel";
            codigoActividadLabel.Size = new System.Drawing.Size(90, 13);
            codigoActividadLabel.TabIndex = 0;
            codigoActividadLabel.Text = "Codigo Actividad:";
            // 
            // cUITLabel
            // 
            cUITLabel.AutoSize = true;
            cUITLabel.Location = new System.Drawing.Point(36, 58);
            cUITLabel.Name = "cUITLabel";
            cUITLabel.Size = new System.Drawing.Size(35, 13);
            cUITLabel.TabIndex = 4;
            cUITLabel.Text = "CUIT:";
            // 
            // cuotaFijaLRTLabel
            // 
            cuotaFijaLRTLabel.AutoSize = true;
            cuotaFijaLRTLabel.Location = new System.Drawing.Point(36, 294);
            cuotaFijaLRTLabel.Name = "cuotaFijaLRTLabel";
            cuotaFijaLRTLabel.Size = new System.Drawing.Size(81, 13);
            cuotaFijaLRTLabel.TabIndex = 6;
            cuotaFijaLRTLabel.Text = "Cuota Fija LRT:";
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Location = new System.Drawing.Point(36, 84);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new System.Drawing.Size(52, 13);
            domicilioLabel.TabIndex = 8;
            domicilioLabel.Text = "Domicilio:";
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Location = new System.Drawing.Point(36, 163);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new System.Drawing.Size(56, 13);
            localidadLabel.TabIndex = 12;
            localidadLabel.Text = "Localidad:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(36, 110);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(30, 13);
            paisLabel.TabIndex = 14;
            paisLabel.Text = "Pais:";
            // 
            // porcentajeAlicuotaLRTLabel
            // 
            porcentajeAlicuotaLRTLabel.AutoSize = true;
            porcentajeAlicuotaLRTLabel.Location = new System.Drawing.Point(36, 268);
            porcentajeAlicuotaLRTLabel.Name = "porcentajeAlicuotaLRTLabel";
            porcentajeAlicuotaLRTLabel.Size = new System.Drawing.Size(126, 13);
            porcentajeAlicuotaLRTLabel.TabIndex = 16;
            porcentajeAlicuotaLRTLabel.Text = "Porcentaje Alicuota LRT:";
            // 
            // provinciaLabel
            // 
            provinciaLabel.AutoSize = true;
            provinciaLabel.Location = new System.Drawing.Point(36, 137);
            provinciaLabel.Name = "provinciaLabel";
            provinciaLabel.Size = new System.Drawing.Size(54, 13);
            provinciaLabel.TabIndex = 18;
            provinciaLabel.Text = "Provincia:";
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.Location = new System.Drawing.Point(36, 32);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(73, 13);
            razonSocialLabel.TabIndex = 20;
            razonSocialLabel.Text = "Razon Social:";
            // 
            // tipoEmpleadorLabel
            // 
            tipoEmpleadorLabel.AutoSize = true;
            tipoEmpleadorLabel.Location = new System.Drawing.Point(36, 241);
            tipoEmpleadorLabel.Name = "tipoEmpleadorLabel";
            tipoEmpleadorLabel.Size = new System.Drawing.Size(84, 13);
            tipoEmpleadorLabel.TabIndex = 22;
            tipoEmpleadorLabel.Text = "Tipo Empleador:";
            // 
            // ultimaRubricaLabel
            // 
            ultimaRubricaLabel.AutoSize = true;
            ultimaRubricaLabel.Location = new System.Drawing.Point(36, 189);
            ultimaRubricaLabel.Name = "ultimaRubricaLabel";
            ultimaRubricaLabel.Size = new System.Drawing.Size(79, 13);
            ultimaRubricaLabel.TabIndex = 24;
            ultimaRubricaLabel.Text = "Ultima Rubrica:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(367, 356);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 25);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtCUIT
            // 
            this.txtCUIT.BackColor = System.Drawing.Color.White;
            this.txtCUIT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaEntityBindingSource, "CUIT", true));
            this.txtCUIT.Location = new System.Drawing.Point(168, 55);
            this.txtCUIT.Mask = "00-00000000-0";
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(86, 20);
            this.txtCUIT.TabIndex = 8;
            this.txtCUIT.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // empresaEntityBindingSource
            // 
            this.empresaEntityBindingSource.DataSource = typeof(Sueldos.Entidades.EmpresaEntity);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(142, 356);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(102, 25);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAsignarImagen);
            this.groupBox1.Controls.Add(this.pbLogotipo);
            this.groupBox1.Controls.Add(codigoActividadLabel);
            this.groupBox1.Controls.Add(this.codigoActividadComboBox);
            this.groupBox1.Controls.Add(this.correspondeReduccionCheckBox);
            this.groupBox1.Controls.Add(cUITLabel);
            this.groupBox1.Controls.Add(cuotaFijaLRTLabel);
            this.groupBox1.Controls.Add(this.cuotaFijaLRTTextBox);
            this.groupBox1.Controls.Add(domicilioLabel);
            this.groupBox1.Controls.Add(this.domicilioTextBox);
            this.groupBox1.Controls.Add(localidadLabel);
            this.groupBox1.Controls.Add(this.localidadTextBox);
            this.groupBox1.Controls.Add(paisLabel);
            this.groupBox1.Controls.Add(this.paisTextBox);
            this.groupBox1.Controls.Add(porcentajeAlicuotaLRTLabel);
            this.groupBox1.Controls.Add(this.porcentajeAlicuotaLRTTextBox);
            this.groupBox1.Controls.Add(provinciaLabel);
            this.groupBox1.Controls.Add(this.provinciaTextBox);
            this.groupBox1.Controls.Add(razonSocialLabel);
            this.groupBox1.Controls.Add(this.razonSocialTextBox);
            this.groupBox1.Controls.Add(tipoEmpleadorLabel);
            this.groupBox1.Controls.Add(this.tipoEmpleadorComboBox);
            this.groupBox1.Controls.Add(ultimaRubricaLabel);
            this.groupBox1.Controls.Add(this.txtCUIT);
            this.groupBox1.Controls.Add(this.ultimaRubricaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 324);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // btnAsignarImagen
            // 
            this.btnAsignarImagen.Location = new System.Drawing.Point(534, 77);
            this.btnAsignarImagen.Name = "btnAsignarImagen";
            this.btnAsignarImagen.Size = new System.Drawing.Size(27, 20);
            this.btnAsignarImagen.TabIndex = 27;
            this.btnAsignarImagen.Text = "...";
            this.btnAsignarImagen.UseVisualStyleBackColor = true;
            this.btnAsignarImagen.Click += new System.EventHandler(this.btnAsignarImagen_Click);
            // 
            // pbLogotipo
            // 
            this.pbLogotipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLogotipo.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.empresaEntityBindingSource, "Imagen", true));
            this.pbLogotipo.Location = new System.Drawing.Point(456, 21);
            this.pbLogotipo.Name = "pbLogotipo";
            this.pbLogotipo.Size = new System.Drawing.Size(105, 50);
            this.pbLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogotipo.TabIndex = 26;
            this.pbLogotipo.TabStop = false;
            // 
            // codigoActividadComboBox
            // 
            this.codigoActividadComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empresaEntityBindingSource, "CodigoActividad", true));
            this.codigoActividadComboBox.FormattingEnabled = true;
            this.codigoActividadComboBox.Location = new System.Drawing.Point(168, 211);
            this.codigoActividadComboBox.Name = "codigoActividadComboBox";
            this.codigoActividadComboBox.Size = new System.Drawing.Size(272, 21);
            this.codigoActividadComboBox.TabIndex = 1;
            // 
            // correspondeReduccionCheckBox
            // 
            this.correspondeReduccionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.empresaEntityBindingSource, "CorrespondeReduccion", true));
            this.correspondeReduccionCheckBox.Location = new System.Drawing.Point(305, 184);
            this.correspondeReduccionCheckBox.Name = "correspondeReduccionCheckBox";
            this.correspondeReduccionCheckBox.Size = new System.Drawing.Size(152, 24);
            this.correspondeReduccionCheckBox.TabIndex = 3;
            this.correspondeReduccionCheckBox.Text = "Corresponde Reduccion";
            this.correspondeReduccionCheckBox.UseVisualStyleBackColor = true;
            // 
            // cuotaFijaLRTTextBox
            // 
            this.cuotaFijaLRTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaEntityBindingSource, "CuotaFijaLRT", true));
            this.cuotaFijaLRTTextBox.Location = new System.Drawing.Point(168, 291);
            this.cuotaFijaLRTTextBox.Name = "cuotaFijaLRTTextBox";
            this.cuotaFijaLRTTextBox.Size = new System.Drawing.Size(64, 20);
            this.cuotaFijaLRTTextBox.TabIndex = 7;
            // 
            // domicilioTextBox
            // 
            this.domicilioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaEntityBindingSource, "Domicilio", true));
            this.domicilioTextBox.Location = new System.Drawing.Point(168, 81);
            this.domicilioTextBox.Name = "domicilioTextBox";
            this.domicilioTextBox.Size = new System.Drawing.Size(250, 20);
            this.domicilioTextBox.TabIndex = 9;
            // 
            // localidadTextBox
            // 
            this.localidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaEntityBindingSource, "Localidad", true));
            this.localidadTextBox.Location = new System.Drawing.Point(168, 160);
            this.localidadTextBox.Name = "localidadTextBox";
            this.localidadTextBox.Size = new System.Drawing.Size(121, 20);
            this.localidadTextBox.TabIndex = 13;
            // 
            // paisTextBox
            // 
            this.paisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaEntityBindingSource, "Pais", true));
            this.paisTextBox.Location = new System.Drawing.Point(168, 107);
            this.paisTextBox.Name = "paisTextBox";
            this.paisTextBox.Size = new System.Drawing.Size(121, 20);
            this.paisTextBox.TabIndex = 15;
            this.paisTextBox.TextChanged += new System.EventHandler(this.paisTextBox_TextChanged);
            // 
            // porcentajeAlicuotaLRTTextBox
            // 
            this.porcentajeAlicuotaLRTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaEntityBindingSource, "PorcentajeAlicuotaLRT", true));
            this.porcentajeAlicuotaLRTTextBox.Location = new System.Drawing.Point(168, 265);
            this.porcentajeAlicuotaLRTTextBox.Name = "porcentajeAlicuotaLRTTextBox";
            this.porcentajeAlicuotaLRTTextBox.Size = new System.Drawing.Size(64, 20);
            this.porcentajeAlicuotaLRTTextBox.TabIndex = 17;
            // 
            // provinciaTextBox
            // 
            this.provinciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaEntityBindingSource, "Provincia", true));
            this.provinciaTextBox.Location = new System.Drawing.Point(168, 134);
            this.provinciaTextBox.Name = "provinciaTextBox";
            this.provinciaTextBox.Size = new System.Drawing.Size(121, 20);
            this.provinciaTextBox.TabIndex = 19;
            // 
            // razonSocialTextBox
            // 
            this.razonSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaEntityBindingSource, "RazonSocial", true));
            this.razonSocialTextBox.Location = new System.Drawing.Point(168, 29);
            this.razonSocialTextBox.Name = "razonSocialTextBox";
            this.razonSocialTextBox.Size = new System.Drawing.Size(250, 20);
            this.razonSocialTextBox.TabIndex = 21;
            // 
            // tipoEmpleadorComboBox
            // 
            this.tipoEmpleadorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empresaEntityBindingSource, "TipoEmpleador", true));
            this.tipoEmpleadorComboBox.FormattingEnabled = true;
            this.tipoEmpleadorComboBox.Location = new System.Drawing.Point(168, 238);
            this.tipoEmpleadorComboBox.Name = "tipoEmpleadorComboBox";
            this.tipoEmpleadorComboBox.Size = new System.Drawing.Size(272, 21);
            this.tipoEmpleadorComboBox.TabIndex = 23;
            // 
            // ultimaRubricaTextBox
            // 
            this.ultimaRubricaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaEntityBindingSource, "UltimaRubrica", true));
            this.ultimaRubricaTextBox.Location = new System.Drawing.Point(168, 186);
            this.ultimaRubricaTextBox.Name = "ultimaRubricaTextBox";
            this.ultimaRubricaTextBox.Size = new System.Drawing.Size(64, 20);
            this.ultimaRubricaTextBox.TabIndex = 25;
            // 
            // openFileDialogImagen
            // 
            this.openFileDialogImagen.FileName = "openFileDialog1";
            // 
            // frmDatosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCerrar);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDatosEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Empresa";
            this.Load += new System.EventHandler(this.frmDatosEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empresaEntityBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogotipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.MaskedTextBox txtCUIT;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox codigoActividadComboBox;
        private System.Windows.Forms.BindingSource empresaEntityBindingSource;
        private System.Windows.Forms.CheckBox correspondeReduccionCheckBox;
        private System.Windows.Forms.TextBox cuotaFijaLRTTextBox;
        private System.Windows.Forms.TextBox domicilioTextBox;
        private System.Windows.Forms.TextBox localidadTextBox;
        private System.Windows.Forms.TextBox paisTextBox;
        private System.Windows.Forms.TextBox porcentajeAlicuotaLRTTextBox;
        private System.Windows.Forms.TextBox provinciaTextBox;
        private System.Windows.Forms.TextBox razonSocialTextBox;
        private System.Windows.Forms.ComboBox tipoEmpleadorComboBox;
        private System.Windows.Forms.TextBox ultimaRubricaTextBox;
        private System.Windows.Forms.PictureBox pbLogotipo;
        private System.Windows.Forms.Button btnAsignarImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagen;
    }
}