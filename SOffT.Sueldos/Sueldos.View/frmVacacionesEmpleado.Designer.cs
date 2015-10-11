/*  
    frmVacacionesEmpleado.cs

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
    partial class frmVacacionesEmpleado
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblAnioVacaciones = new System.Windows.Forms.Label();
            this.gbLiquidacion = new System.Windows.Forms.GroupBox();
            this.txtDiasALiquidar = new System.Windows.Forms.TextBox();
            this.lblDiasALiquidar = new System.Windows.Forms.Label();
            this.cmbLiquidacion = new System.Windows.Forms.ComboBox();
            this.lblDiasATomar = new System.Windows.Forms.Label();
            this.txtDiasATomar = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtAnioVacaciones = new System.Windows.Forms.TextBox();
            this.txtDiasVacaciones = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.dtpFechaOtorgada = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLiquidacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(45, 165);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 30);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblAnioVacaciones
            // 
            this.lblAnioVacaciones.AutoSize = true;
            this.lblAnioVacaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioVacaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAnioVacaciones.Location = new System.Drawing.Point(9, 35);
            this.lblAnioVacaciones.Name = "lblAnioVacaciones";
            this.lblAnioVacaciones.Size = new System.Drawing.Size(107, 13);
            this.lblAnioVacaciones.TabIndex = 2;
            this.lblAnioVacaciones.Text = "Año Vacaciones: ";
            // 
            // gbLiquidacion
            // 
            this.gbLiquidacion.Controls.Add(this.txtDiasALiquidar);
            this.gbLiquidacion.Controls.Add(this.lblDiasALiquidar);
            this.gbLiquidacion.Controls.Add(this.cmbLiquidacion);
            this.gbLiquidacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbLiquidacion.Location = new System.Drawing.Point(12, 88);
            this.gbLiquidacion.Name = "gbLiquidacion";
            this.gbLiquidacion.Size = new System.Drawing.Size(250, 71);
            this.gbLiquidacion.TabIndex = 6;
            this.gbLiquidacion.TabStop = false;
            this.gbLiquidacion.Text = "A liquidar en:";
            // 
            // txtDiasALiquidar
            // 
            this.txtDiasALiquidar.Location = new System.Drawing.Point(111, 13);
            this.txtDiasALiquidar.MaxLength = 2;
            this.txtDiasALiquidar.Name = "txtDiasALiquidar";
            this.txtDiasALiquidar.Size = new System.Drawing.Size(26, 20);
            this.txtDiasALiquidar.TabIndex = 15;
            this.txtDiasALiquidar.TextChanged += new System.EventHandler(this.txtDiasALiquidar_TextChanged);
            // 
            // lblDiasALiquidar
            // 
            this.lblDiasALiquidar.AutoSize = true;
            this.lblDiasALiquidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasALiquidar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDiasALiquidar.Location = new System.Drawing.Point(6, 16);
            this.lblDiasALiquidar.Name = "lblDiasALiquidar";
            this.lblDiasALiquidar.Size = new System.Drawing.Size(100, 13);
            this.lblDiasALiquidar.TabIndex = 14;
            this.lblDiasALiquidar.Text = "Dias a Liquidar: ";
            // 
            // cmbLiquidacion
            // 
            this.cmbLiquidacion.FormattingEnabled = true;
            this.cmbLiquidacion.Location = new System.Drawing.Point(9, 39);
            this.cmbLiquidacion.Name = "cmbLiquidacion";
            this.cmbLiquidacion.Size = new System.Drawing.Size(228, 21);
            this.cmbLiquidacion.TabIndex = 10;
            this.cmbLiquidacion.SelectedIndexChanged += new System.EventHandler(this.cmbLiquidacion_SelectedIndexChanged);
            // 
            // lblDiasATomar
            // 
            this.lblDiasATomar.AutoSize = true;
            this.lblDiasATomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasATomar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDiasATomar.Location = new System.Drawing.Point(9, 65);
            this.lblDiasATomar.Name = "lblDiasATomar";
            this.lblDiasATomar.Size = new System.Drawing.Size(90, 13);
            this.lblDiasATomar.TabIndex = 8;
            this.lblDiasATomar.Text = "Dias a Tomar: ";
            // 
            // txtDiasATomar
            // 
            this.txtDiasATomar.Location = new System.Drawing.Point(114, 62);
            this.txtDiasATomar.MaxLength = 2;
            this.txtDiasATomar.Name = "txtDiasATomar";
            this.txtDiasATomar.Size = new System.Drawing.Size(26, 20);
            this.txtDiasATomar.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(141, 165);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 30);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancela&r";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtAnioVacaciones
            // 
            this.txtAnioVacaciones.Location = new System.Drawing.Point(114, 32);
            this.txtAnioVacaciones.MaxLength = 4;
            this.txtAnioVacaciones.Name = "txtAnioVacaciones";
            this.txtAnioVacaciones.Size = new System.Drawing.Size(42, 20);
            this.txtAnioVacaciones.TabIndex = 15;
            this.txtAnioVacaciones.TextChanged += new System.EventHandler(this.txtAnioVacaciones_TextChanged);
            // 
            // txtDiasVacaciones
            // 
            this.txtDiasVacaciones.Location = new System.Drawing.Point(208, 32);
            this.txtDiasVacaciones.MaxLength = 2;
            this.txtDiasVacaciones.Name = "txtDiasVacaciones";
            this.txtDiasVacaciones.Size = new System.Drawing.Size(26, 20);
            this.txtDiasVacaciones.TabIndex = 16;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDias.Location = new System.Drawing.Point(162, 35);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(40, 13);
            this.lblDias.TabIndex = 17;
            this.lblDias.Text = "Dias: ";
            // 
            // dtpFechaOtorgada
            // 
            this.dtpFechaOtorgada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaOtorgada.Location = new System.Drawing.Point(114, 5);
            this.dtpFechaOtorgada.Name = "dtpFechaOtorgada";
            this.dtpFechaOtorgada.Size = new System.Drawing.Size(88, 20);
            this.dtpFechaOtorgada.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha Otorgada:";
            // 
            // frmVacacionesEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 204);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaOtorgada);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.txtDiasVacaciones);
            this.Controls.Add(this.txtAnioVacaciones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDiasATomar);
            this.Controls.Add(this.lblDiasATomar);
            this.Controls.Add(this.gbLiquidacion);
            this.Controls.Add(this.lblAnioVacaciones);
            this.Controls.Add(this.btnAceptar);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVacacionesEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacaciones de Empleado";
            this.gbLiquidacion.ResumeLayout(false);
            this.gbLiquidacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblAnioVacaciones;
        private System.Windows.Forms.GroupBox gbLiquidacion;
        private System.Windows.Forms.Label lblDiasATomar;
        private System.Windows.Forms.TextBox txtDiasATomar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbLiquidacion;
        private System.Windows.Forms.TextBox txtAnioVacaciones;
        private System.Windows.Forms.TextBox txtDiasVacaciones;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.DateTimePicker dtpFechaOtorgada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiasALiquidar;
        private System.Windows.Forms.Label lblDiasALiquidar;
    }
}