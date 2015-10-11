/*  
    frmAcreditaciones.cs

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
    partial class frmAcreditaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcreditaciones));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGenerarArchivo = new System.Windows.Forms.Button();
            this.saveFileDialogBancos = new System.Windows.Forms.SaveFileDialog();
            this.gbFechasDePago = new System.Windows.Forms.GroupBox();
            this.lstFechasDePago = new System.Windows.Forms.ListBox();
            this.cmbBancos = new System.Windows.Forms.ComboBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.liqCtrlAcreditaciones = new Sueldos.View.Control.LiquidacionesCtrl();
            this.chkConvenido = new System.Windows.Forms.CheckBox();
            this.cmbConvenio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFechasDePago.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(179, 342);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 25);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGenerarArchivo
            // 
            this.btnGenerarArchivo.Location = new System.Drawing.Point(19, 342);
            this.btnGenerarArchivo.Name = "btnGenerarArchivo";
            this.btnGenerarArchivo.Size = new System.Drawing.Size(94, 25);
            this.btnGenerarArchivo.TabIndex = 1;
            this.btnGenerarArchivo.Text = "Generar Archivo";
            this.btnGenerarArchivo.UseVisualStyleBackColor = true;
            this.btnGenerarArchivo.Click += new System.EventHandler(this.btnGenerarArchivo_Click);
            // 
            // gbFechasDePago
            // 
            this.gbFechasDePago.Controls.Add(this.lstFechasDePago);
            this.gbFechasDePago.Location = new System.Drawing.Point(92, 227);
            this.gbFechasDePago.Name = "gbFechasDePago";
            this.gbFechasDePago.Size = new System.Drawing.Size(107, 102);
            this.gbFechasDePago.TabIndex = 6;
            this.gbFechasDePago.TabStop = false;
            this.gbFechasDePago.Text = "Fechas de Pago";
            // 
            // lstFechasDePago
            // 
            this.lstFechasDePago.FormattingEnabled = true;
            this.lstFechasDePago.Location = new System.Drawing.Point(12, 23);
            this.lstFechasDePago.Name = "lstFechasDePago";
            this.lstFechasDePago.Size = new System.Drawing.Size(82, 69);
            this.lstFechasDePago.TabIndex = 37;
            // 
            // cmbBancos
            // 
            this.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBancos.FormattingEnabled = true;
            this.cmbBancos.Location = new System.Drawing.Point(72, 153);
            this.cmbBancos.Name = "cmbBancos";
            this.cmbBancos.Size = new System.Drawing.Size(189, 21);
            this.cmbBancos.TabIndex = 7;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(25, 156);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(41, 13);
            this.lblBanco.TabIndex = 8;
            this.lblBanco.Text = "Banco:";
            // 
            // liqCtrlAcreditaciones
            // 
            this.liqCtrlAcreditaciones.LiquidacionId = 0;
            this.liqCtrlAcreditaciones.Location = new System.Drawing.Point(19, 7);
            this.liqCtrlAcreditaciones.MaximumSize = new System.Drawing.Size(250, 200);
            this.liqCtrlAcreditaciones.MinimumSize = new System.Drawing.Size(120, 140);
            this.liqCtrlAcreditaciones.Name = "liqCtrlAcreditaciones";
            this.liqCtrlAcreditaciones.Padding = new System.Windows.Forms.Padding(3);
            this.liqCtrlAcreditaciones.Size = new System.Drawing.Size(250, 140);
            this.liqCtrlAcreditaciones.TabIndex = 2;
            // 
            // chkConvenido
            // 
            this.chkConvenido.AutoSize = true;
            this.chkConvenido.Checked = true;
            this.chkConvenido.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConvenido.Location = new System.Drawing.Point(86, 176);
            this.chkConvenido.Name = "chkConvenido";
            this.chkConvenido.Size = new System.Drawing.Size(56, 17);
            this.chkConvenido.TabIndex = 28;
            this.chkConvenido.Text = "Todos";
            this.chkConvenido.UseVisualStyleBackColor = true;
            this.chkConvenido.CheckedChanged += new System.EventHandler(this.chkConvenido_CheckedChanged);
            // 
            // cmbConvenio
            // 
            this.cmbConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConvenio.Enabled = false;
            this.cmbConvenio.FormattingEnabled = true;
            this.cmbConvenio.Location = new System.Drawing.Point(28, 197);
            this.cmbConvenio.Name = "cmbConvenio";
            this.cmbConvenio.Size = new System.Drawing.Size(233, 21);
            this.cmbConvenio.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Convenio:";
            // 
            // frmAcreditaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkConvenido);
            this.Controls.Add(this.cmbConvenio);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.cmbBancos);
            this.Controls.Add(this.gbFechasDePago);
            this.Controls.Add(this.liqCtrlAcreditaciones);
            this.Controls.Add(this.btnGenerarArchivo);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAcreditaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acreditaciones en Bancos";
            this.Load += new System.EventHandler(this.frmAcreditaciones_Load);
            this.gbFechasDePago.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGenerarArchivo;
        private Sueldos.View.Control.LiquidacionesCtrl liqCtrlAcreditaciones;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBancos;
        private System.Windows.Forms.GroupBox gbFechasDePago;
        private System.Windows.Forms.ListBox lstFechasDePago;
        private System.Windows.Forms.ComboBox cmbBancos;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.CheckBox chkConvenido;
        private System.Windows.Forms.ComboBox cmbConvenio;
        private System.Windows.Forms.Label label1;
    }
}