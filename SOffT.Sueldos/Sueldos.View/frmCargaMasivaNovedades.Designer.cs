/*  
    frmCargaMasivaNovedades.cs

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
    partial class frmCargaMasivaNovedades
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
            this.gbDatosLiquidacion = new System.Windows.Forms.GroupBox();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbConvenio = new System.Windows.Forms.ComboBox();
            this.cmbLiquidacion = new System.Windows.Forms.ComboBox();
            this.lblTipoLiquidacion = new System.Windows.Forms.Label();
            this.cmbTipoLiquidacion = new System.Windows.Forms.ComboBox();
            this.cmbNovedad = new System.Windows.Forms.ComboBox();
            this.lblNovedad = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.gbDatosLiquidacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(233, 236);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(116, 25);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbDatosLiquidacion
            // 
            this.gbDatosLiquidacion.Controls.Add(this.lblConvenio);
            this.gbDatosLiquidacion.Controls.Add(this.lblDescripcion);
            this.gbDatosLiquidacion.Controls.Add(this.cmbConvenio);
            this.gbDatosLiquidacion.Controls.Add(this.cmbLiquidacion);
            this.gbDatosLiquidacion.Controls.Add(this.lblTipoLiquidacion);
            this.gbDatosLiquidacion.Controls.Add(this.cmbTipoLiquidacion);
            this.gbDatosLiquidacion.Location = new System.Drawing.Point(12, 12);
            this.gbDatosLiquidacion.Name = "gbDatosLiquidacion";
            this.gbDatosLiquidacion.Size = new System.Drawing.Size(415, 112);
            this.gbDatosLiquidacion.TabIndex = 3;
            this.gbDatosLiquidacion.TabStop = false;
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvenio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblConvenio.Location = new System.Drawing.Point(11, 71);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(64, 13);
            this.lblConvenio.TabIndex = 24;
            this.lblConvenio.Text = "Convenio:";
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
            // cmbConvenio
            // 
            this.cmbConvenio.FormattingEnabled = true;
            this.cmbConvenio.Location = new System.Drawing.Point(81, 68);
            this.cmbConvenio.Name = "cmbConvenio";
            this.cmbConvenio.Size = new System.Drawing.Size(107, 21);
            this.cmbConvenio.TabIndex = 23;
            // 
            // cmbLiquidacion
            // 
            this.cmbLiquidacion.FormattingEnabled = true;
            this.cmbLiquidacion.Location = new System.Drawing.Point(11, 30);
            this.cmbLiquidacion.Name = "cmbLiquidacion";
            this.cmbLiquidacion.Size = new System.Drawing.Size(378, 21);
            this.cmbLiquidacion.TabIndex = 40;
            this.cmbLiquidacion.SelectedIndexChanged += new System.EventHandler(this.cmbLiquidacion_SelectedIndexChanged);
            // 
            // lblTipoLiquidacion
            // 
            this.lblTipoLiquidacion.AutoSize = true;
            this.lblTipoLiquidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoLiquidacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTipoLiquidacion.Location = new System.Drawing.Point(197, 71);
            this.lblTipoLiquidacion.Name = "lblTipoLiquidacion";
            this.lblTipoLiquidacion.Size = new System.Drawing.Size(79, 13);
            this.lblTipoLiquidacion.TabIndex = 22;
            this.lblTipoLiquidacion.Text = "Tipo Salario:";
            // 
            // cmbTipoLiquidacion
            // 
            this.cmbTipoLiquidacion.FormattingEnabled = true;
            this.cmbTipoLiquidacion.Location = new System.Drawing.Point(282, 68);
            this.cmbTipoLiquidacion.Name = "cmbTipoLiquidacion";
            this.cmbTipoLiquidacion.Size = new System.Drawing.Size(107, 21);
            this.cmbTipoLiquidacion.TabIndex = 21;
            // 
            // cmbNovedad
            // 
            this.cmbNovedad.FormattingEnabled = true;
            this.cmbNovedad.Location = new System.Drawing.Point(86, 141);
            this.cmbNovedad.Name = "cmbNovedad";
            this.cmbNovedad.Size = new System.Drawing.Size(202, 21);
            this.cmbNovedad.TabIndex = 43;
            // 
            // lblNovedad
            // 
            this.lblNovedad.AutoSize = true;
            this.lblNovedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNovedad.Location = new System.Drawing.Point(20, 144);
            this.lblNovedad.Name = "lblNovedad";
            this.lblNovedad.Size = new System.Drawing.Size(62, 13);
            this.lblNovedad.TabIndex = 42;
            this.lblNovedad.Text = "Novedad:";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(102, 236);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(102, 25);
            this.btnGrabar.TabIndex = 44;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(86, 177);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(97, 20);
            this.txtValor.TabIndex = 45;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblValor.Location = new System.Drawing.Point(20, 180);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(40, 13);
            this.lblValor.TabIndex = 46;
            this.lblValor.Text = "Valor:";
            // 
            // frmCargaMasivaNovedades
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 273);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.cmbNovedad);
            this.Controls.Add(this.lblNovedad);
            this.Controls.Add(this.gbDatosLiquidacion);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCargaMasivaNovedades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CargaMasivaNovedades";
            this.Load += new System.EventHandler(this.CargaMasivaNovedades_Load);
            this.gbDatosLiquidacion.ResumeLayout(false);
            this.gbDatosLiquidacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbDatosLiquidacion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbLiquidacion;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.ComboBox cmbConvenio;
        private System.Windows.Forms.Label lblTipoLiquidacion;
        private System.Windows.Forms.ComboBox cmbTipoLiquidacion;
        private System.Windows.Forms.ComboBox cmbNovedad;
        private System.Windows.Forms.Label lblNovedad;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
    }
}