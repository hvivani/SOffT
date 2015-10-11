/*  
    frmLiquidacionTabla.cs

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
    partial class frmLiquidacionTabla
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLiquidar = new System.Windows.Forms.Button();
            this.gbProceso = new System.Windows.Forms.GroupBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.pbProceso = new System.Windows.Forms.ProgressBar();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbLiquidacion = new System.Windows.Forms.ComboBox();
            this.btnGenerarArchivo = new System.Windows.Forms.Button();
            this.saveFileDialogCargas = new System.Windows.Forms.SaveFileDialog();
            this.btnExportar = new System.Windows.Forms.Button();
            this.gbProceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(456, 214);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLiquidar
            // 
            this.btnLiquidar.Location = new System.Drawing.Point(244, 215);
            this.btnLiquidar.Name = "btnLiquidar";
            this.btnLiquidar.Size = new System.Drawing.Size(75, 23);
            this.btnLiquidar.TabIndex = 8;
            this.btnLiquidar.Text = "&Liquidar";
            this.btnLiquidar.UseVisualStyleBackColor = true;
            this.btnLiquidar.Click += new System.EventHandler(this.btnLiquidar_Click);
            // 
            // gbProceso
            // 
            this.gbProceso.Controls.Add(this.txtLegajo);
            this.gbProceso.Controls.Add(this.lblLegajo);
            this.gbProceso.Controls.Add(this.pbProceso);
            this.gbProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbProceso.Location = new System.Drawing.Point(12, 84);
            this.gbProceso.Name = "gbProceso";
            this.gbProceso.Size = new System.Drawing.Size(519, 110);
            this.gbProceso.TabIndex = 15;
            this.gbProceso.TabStop = false;
            this.gbProceso.Text = "Proceso";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Enabled = false;
            this.txtLegajo.ForeColor = System.Drawing.Color.White;
            this.txtLegajo.Location = new System.Drawing.Point(74, 66);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(60, 20);
            this.txtLegajo.TabIndex = 15;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(15, 69);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(49, 13);
            this.lblLegajo.TabIndex = 14;
            this.lblLegajo.Text = "Legajo:";
            // 
            // pbProceso
            // 
            this.pbProceso.Location = new System.Drawing.Point(26, 29);
            this.pbProceso.Name = "pbProceso";
            this.pbProceso.Size = new System.Drawing.Size(465, 24);
            this.pbProceso.TabIndex = 13;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDescripcion.Location = new System.Drawing.Point(9, 20);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(76, 13);
            this.lblDescripcion.TabIndex = 41;
            this.lblDescripcion.Text = "Liquidación:";
            // 
            // cmbLiquidacion
            // 
            this.cmbLiquidacion.FormattingEnabled = true;
            this.cmbLiquidacion.Location = new System.Drawing.Point(12, 36);
            this.cmbLiquidacion.Name = "cmbLiquidacion";
            this.cmbLiquidacion.Size = new System.Drawing.Size(321, 21);
            this.cmbLiquidacion.TabIndex = 40;
            this.cmbLiquidacion.SelectedIndexChanged += new System.EventHandler(this.cmbLiquidacion_SelectedIndexChanged);
            // 
            // btnGenerarArchivo
            // 
            this.btnGenerarArchivo.Location = new System.Drawing.Point(12, 214);
            this.btnGenerarArchivo.Name = "btnGenerarArchivo";
            this.btnGenerarArchivo.Size = new System.Drawing.Size(101, 23);
            this.btnGenerarArchivo.TabIndex = 42;
            this.btnGenerarArchivo.Text = "&Generar Archivo";
            this.btnGenerarArchivo.UseVisualStyleBackColor = true;
            this.btnGenerarArchivo.Click += new System.EventHandler(this.btnGenerarArchivo_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(119, 214);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(108, 23);
            this.btnExportar.TabIndex = 43;
            this.btnExportar.Text = "Exportar Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Visible = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmLiquidacionTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 254);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnGenerarArchivo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.cmbLiquidacion);
            this.Controls.Add(this.gbProceso);
            this.Controls.Add(this.btnLiquidar);
            this.Controls.Add(this.btnCerrar);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLiquidacionTabla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liquidación Cargas Sociales";
            this.Load += new System.EventHandler(this.frmLiquidacionCargas_Load);
            this.gbProceso.ResumeLayout(false);
            this.gbProceso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLiquidar;
        private System.Windows.Forms.GroupBox gbProceso;
        private System.Windows.Forms.ProgressBar pbProceso;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbLiquidacion;
        private System.Windows.Forms.Button btnGenerarArchivo;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCargas;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Button btnExportar;
    }
}