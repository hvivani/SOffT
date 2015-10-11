/*  
    frmHorario.cs

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
    partial class frmHorario
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
            this.cmbDias = new System.Windows.Forms.ComboBox();
            this.cmbMovimientos = new System.Windows.Forms.ComboBox();
            this.v = new System.Windows.Forms.Label();
            this.lblMovimiento = new System.Windows.Forms.Label();
            this.mTBHora = new System.Windows.Forms.MaskedTextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtLimiteDia = new System.Windows.Forms.TextBox();
            this.lblLimiteDia = new System.Windows.Forms.Label();
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.lblTolerancia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDias
            // 
            this.cmbDias.FormattingEnabled = true;
            this.cmbDias.Location = new System.Drawing.Point(84, 16);
            this.cmbDias.Name = "cmbDias";
            this.cmbDias.Size = new System.Drawing.Size(121, 21);
            this.cmbDias.TabIndex = 25;
            // 
            // cmbMovimientos
            // 
            this.cmbMovimientos.FormattingEnabled = true;
            this.cmbMovimientos.Location = new System.Drawing.Point(84, 68);
            this.cmbMovimientos.Name = "cmbMovimientos";
            this.cmbMovimientos.Size = new System.Drawing.Size(121, 21);
            this.cmbMovimientos.TabIndex = 26;
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(50, 19);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(28, 13);
            this.v.TabIndex = 27;
            this.v.Text = "Día:";
            // 
            // lblMovimiento
            // 
            this.lblMovimiento.AutoSize = true;
            this.lblMovimiento.Location = new System.Drawing.Point(14, 71);
            this.lblMovimiento.Name = "lblMovimiento";
            this.lblMovimiento.Size = new System.Drawing.Size(64, 13);
            this.lblMovimiento.TabIndex = 28;
            this.lblMovimiento.Text = "Movimiento:";
            // 
            // mTBHora
            // 
            this.mTBHora.Location = new System.Drawing.Point(84, 97);
            this.mTBHora.Mask = "00:00";
            this.mTBHora.Name = "mTBHora";
            this.mTBHora.Size = new System.Drawing.Size(34, 20);
            this.mTBHora.TabIndex = 29;
            this.mTBHora.ValidatingType = typeof(System.DateTime);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(45, 100);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 30;
            this.lblHora.Text = "Hora:";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(39, 168);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(84, 24);
            this.btnGrabar.TabIndex = 32;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(129, 168);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(84, 24);
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtLimiteDia
            // 
            this.txtLimiteDia.Location = new System.Drawing.Point(84, 42);
            this.txtLimiteDia.MaxLength = 2;
            this.txtLimiteDia.Name = "txtLimiteDia";
            this.txtLimiteDia.Size = new System.Drawing.Size(22, 20);
            this.txtLimiteDia.TabIndex = 33;
            this.txtLimiteDia.Text = "0";
            this.txtLimiteDia.TextChanged += new System.EventHandler(this.txtLimiteDia_TextChanged);
            // 
            // lblLimiteDia
            // 
            this.lblLimiteDia.AutoSize = true;
            this.lblLimiteDia.Location = new System.Drawing.Point(18, 45);
            this.lblLimiteDia.Name = "lblLimiteDia";
            this.lblLimiteDia.Size = new System.Drawing.Size(60, 13);
            this.lblLimiteDia.TabIndex = 34;
            this.lblLimiteDia.Text = "Límite Día:";
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.Location = new System.Drawing.Point(84, 123);
            this.txtTolerancia.MaxLength = 2;
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(22, 20);
            this.txtTolerancia.TabIndex = 35;
            this.txtTolerancia.Text = "0";
            this.txtTolerancia.TextChanged += new System.EventHandler(this.txtTolerancia_TextChanged);
            // 
            // lblTolerancia
            // 
            this.lblTolerancia.AutoSize = true;
            this.lblTolerancia.Location = new System.Drawing.Point(18, 126);
            this.lblTolerancia.Name = "lblTolerancia";
            this.lblTolerancia.Size = new System.Drawing.Size(60, 13);
            this.lblTolerancia.TabIndex = 36;
            this.lblTolerancia.Text = "Tolerancia:";
            // 
            // frmHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 200);
            this.Controls.Add(this.lblTolerancia);
            this.Controls.Add(this.txtTolerancia);
            this.Controls.Add(this.lblLimiteDia);
            this.Controls.Add(this.txtLimiteDia);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.mTBHora);
            this.Controls.Add(this.lblMovimiento);
            this.Controls.Add(this.v);
            this.Controls.Add(this.cmbMovimientos);
            this.Controls.Add(this.cmbDias);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horario";
            this.Load += new System.EventHandler(this.frmHorario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDias;
        private System.Windows.Forms.ComboBox cmbMovimientos;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label lblMovimiento;
        private System.Windows.Forms.MaskedTextBox mTBHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtLimiteDia;
        private System.Windows.Forms.Label lblLimiteDia;
        private System.Windows.Forms.TextBox txtTolerancia;
        private System.Windows.Forms.Label lblTolerancia;
    }
}