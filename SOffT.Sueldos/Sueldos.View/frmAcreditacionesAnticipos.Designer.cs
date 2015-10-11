/*  
    frmAcreditacionesAnticipos.cs

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
    partial class frmAcreditacionesAnticipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcreditacionesAnticipos));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbAnioMes = new System.Windows.Forms.GroupBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.cmbBancos = new System.Windows.Forms.ComboBox();
            this.lblFechaAcreditacion = new System.Windows.Forms.Label();
            this.dtpFechaAcreditacion = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoAnticipo = new System.Windows.Forms.ComboBox();
            this.lblTipoAnticipo = new System.Windows.Forms.Label();
            this.cmbMeses = new System.Windows.Forms.ComboBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.cmbAnios = new System.Windows.Forms.ComboBox();
            this.btnGenerarArchivo = new System.Windows.Forms.Button();
            this.saveFileDialogBancos = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbConvenio = new System.Windows.Forms.ComboBox();
            this.chkConvenido = new System.Windows.Forms.CheckBox();
            this.gbAnioMes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(143, 249);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbAnioMes
            // 
            this.gbAnioMes.Controls.Add(this.chkConvenido);
            this.gbAnioMes.Controls.Add(this.label1);
            this.gbAnioMes.Controls.Add(this.cmbConvenio);
            this.gbAnioMes.Controls.Add(this.lblBanco);
            this.gbAnioMes.Controls.Add(this.cmbBancos);
            this.gbAnioMes.Controls.Add(this.lblFechaAcreditacion);
            this.gbAnioMes.Controls.Add(this.dtpFechaAcreditacion);
            this.gbAnioMes.Controls.Add(this.cmbTipoAnticipo);
            this.gbAnioMes.Controls.Add(this.lblTipoAnticipo);
            this.gbAnioMes.Controls.Add(this.cmbMeses);
            this.gbAnioMes.Controls.Add(this.lblAnio);
            this.gbAnioMes.Controls.Add(this.lblMes);
            this.gbAnioMes.Controls.Add(this.cmbAnios);
            this.gbAnioMes.Location = new System.Drawing.Point(13, 12);
            this.gbAnioMes.Name = "gbAnioMes";
            this.gbAnioMes.Size = new System.Drawing.Size(237, 231);
            this.gbAnioMes.TabIndex = 1;
            this.gbAnioMes.TabStop = false;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBanco.Location = new System.Drawing.Point(8, 153);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(47, 13);
            this.lblBanco.TabIndex = 22;
            this.lblBanco.Text = "Banco:";
            // 
            // cmbBancos
            // 
            this.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBancos.FormattingEnabled = true;
            this.cmbBancos.Location = new System.Drawing.Point(55, 150);
            this.cmbBancos.Name = "cmbBancos";
            this.cmbBancos.Size = new System.Drawing.Size(175, 21);
            this.cmbBancos.TabIndex = 21;
            // 
            // lblFechaAcreditacion
            // 
            this.lblFechaAcreditacion.AutoSize = true;
            this.lblFechaAcreditacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAcreditacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFechaAcreditacion.Location = new System.Drawing.Point(3, 114);
            this.lblFechaAcreditacion.Name = "lblFechaAcreditacion";
            this.lblFechaAcreditacion.Size = new System.Drawing.Size(139, 13);
            this.lblFechaAcreditacion.TabIndex = 20;
            this.lblFechaAcreditacion.Text = "Fecha de Acreditación:";
            // 
            // dtpFechaAcreditacion
            // 
            this.dtpFechaAcreditacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAcreditacion.Location = new System.Drawing.Point(142, 110);
            this.dtpFechaAcreditacion.Name = "dtpFechaAcreditacion";
            this.dtpFechaAcreditacion.Size = new System.Drawing.Size(89, 20);
            this.dtpFechaAcreditacion.TabIndex = 19;
            // 
            // cmbTipoAnticipo
            // 
            this.cmbTipoAnticipo.FormattingEnabled = true;
            this.cmbTipoAnticipo.Location = new System.Drawing.Point(6, 75);
            this.cmbTipoAnticipo.Name = "cmbTipoAnticipo";
            this.cmbTipoAnticipo.Size = new System.Drawing.Size(225, 21);
            this.cmbTipoAnticipo.TabIndex = 17;
            // 
            // lblTipoAnticipo
            // 
            this.lblTipoAnticipo.AutoSize = true;
            this.lblTipoAnticipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAnticipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTipoAnticipo.Location = new System.Drawing.Point(3, 59);
            this.lblTipoAnticipo.Name = "lblTipoAnticipo";
            this.lblTipoAnticipo.Size = new System.Drawing.Size(104, 13);
            this.lblTipoAnticipo.TabIndex = 18;
            this.lblTipoAnticipo.Text = "Tipo de Anticipo:";
            // 
            // cmbMeses
            // 
            this.cmbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Location = new System.Drawing.Point(89, 32);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(142, 21);
            this.cmbMeses.TabIndex = 14;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAnio.Location = new System.Drawing.Point(3, 16);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(33, 13);
            this.lblAnio.TabIndex = 15;
            this.lblAnio.Text = "Año:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMes.Location = new System.Drawing.Point(86, 16);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(34, 13);
            this.lblMes.TabIndex = 16;
            this.lblMes.Text = "Mes:";
            // 
            // cmbAnios
            // 
            this.cmbAnios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnios.FormattingEnabled = true;
            this.cmbAnios.Location = new System.Drawing.Point(6, 32);
            this.cmbAnios.Name = "cmbAnios";
            this.cmbAnios.Size = new System.Drawing.Size(77, 21);
            this.cmbAnios.TabIndex = 13;
            // 
            // btnGenerarArchivo
            // 
            this.btnGenerarArchivo.Location = new System.Drawing.Point(23, 249);
            this.btnGenerarArchivo.Name = "btnGenerarArchivo";
            this.btnGenerarArchivo.Size = new System.Drawing.Size(88, 23);
            this.btnGenerarArchivo.TabIndex = 2;
            this.btnGenerarArchivo.Text = "&Generar";
            this.btnGenerarArchivo.UseVisualStyleBackColor = true;
            this.btnGenerarArchivo.Click += new System.EventHandler(this.btnGenerarArchivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(8, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Convenio:";
            // 
            // cmbConvenio
            // 
            this.cmbConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConvenio.Enabled = false;
            this.cmbConvenio.FormattingEnabled = true;
            this.cmbConvenio.Location = new System.Drawing.Point(11, 204);
            this.cmbConvenio.Name = "cmbConvenio";
            this.cmbConvenio.Size = new System.Drawing.Size(219, 21);
            this.cmbConvenio.TabIndex = 23;
            // 
            // chkConvenido
            // 
            this.chkConvenido.AutoSize = true;
            this.chkConvenido.Checked = true;
            this.chkConvenido.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConvenido.Location = new System.Drawing.Point(78, 187);
            this.chkConvenido.Name = "chkConvenido";
            this.chkConvenido.Size = new System.Drawing.Size(56, 17);
            this.chkConvenido.TabIndex = 25;
            this.chkConvenido.Text = "Todos";
            this.chkConvenido.UseVisualStyleBackColor = true;
            this.chkConvenido.CheckedChanged += new System.EventHandler(this.chkConvenido_CheckedChanged);
            // 
            // frmAcreditacionesAnticipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 284);
            this.Controls.Add(this.btnGenerarArchivo);
            this.Controls.Add(this.gbAnioMes);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAcreditacionesAnticipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acreditación de Anticipos";
            this.gbAnioMes.ResumeLayout(false);
            this.gbAnioMes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbAnioMes;
        private System.Windows.Forms.ComboBox cmbMeses;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox cmbAnios;
        private System.Windows.Forms.ComboBox cmbTipoAnticipo;
        private System.Windows.Forms.Label lblTipoAnticipo;
        private System.Windows.Forms.Button btnGenerarArchivo;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBancos;
        private System.Windows.Forms.Label lblFechaAcreditacion;
        private System.Windows.Forms.DateTimePicker dtpFechaAcreditacion;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.ComboBox cmbBancos;
        private System.Windows.Forms.CheckBox chkConvenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbConvenio;
    }
}