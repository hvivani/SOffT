/*  
    frmValidaCUIL.cs

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
    partial class frmValidaCUIL
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
            this.gbValidar = new System.Windows.Forms.GroupBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblCUIL = new System.Windows.Forms.Label();
            this.txtCUIL = new System.Windows.Forms.TextBox();
            this.gbGenerar = new System.Windows.Forms.GroupBox();
            this.lblRecuerde = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.gbValidar.SuspendLayout();
            this.gbGenerar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(323, 286);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(72, 26);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbValidar
            // 
            this.gbValidar.Controls.Add(this.btnValidar);
            this.gbValidar.Controls.Add(this.lblCUIL);
            this.gbValidar.Controls.Add(this.txtCUIL);
            this.gbValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbValidar.Location = new System.Drawing.Point(12, 12);
            this.gbValidar.Name = "gbValidar";
            this.gbValidar.Size = new System.Drawing.Size(384, 102);
            this.gbValidar.TabIndex = 1;
            this.gbValidar.TabStop = false;
            this.gbValidar.Text = "Validar";
            this.gbValidar.Enter += new System.EventHandler(this.gbValidar_Enter);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(236, 25);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(87, 20);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "&Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblCUIL
            // 
            this.lblCUIL.AutoSize = true;
            this.lblCUIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCUIL.Location = new System.Drawing.Point(26, 28);
            this.lblCUIL.Name = "lblCUIL";
            this.lblCUIL.Size = new System.Drawing.Size(39, 13);
            this.lblCUIL.TabIndex = 1;
            this.lblCUIL.Text = "CUIL:";
            // 
            // txtCUIL
            // 
            this.txtCUIL.Location = new System.Drawing.Point(66, 25);
            this.txtCUIL.MaxLength = 13;
            this.txtCUIL.Name = "txtCUIL";
            this.txtCUIL.Size = new System.Drawing.Size(87, 20);
            this.txtCUIL.TabIndex = 0;
            // 
            // gbGenerar
            // 
            this.gbGenerar.Controls.Add(this.lblRecuerde);
            this.gbGenerar.Controls.Add(this.lblDNI);
            this.gbGenerar.Controls.Add(this.txtDNI);
            this.gbGenerar.Controls.Add(this.btnGenerar);
            this.gbGenerar.Controls.Add(this.lblSexo);
            this.gbGenerar.Controls.Add(this.cmbSexo);
            this.gbGenerar.Location = new System.Drawing.Point(14, 130);
            this.gbGenerar.Name = "gbGenerar";
            this.gbGenerar.Size = new System.Drawing.Size(381, 150);
            this.gbGenerar.TabIndex = 2;
            this.gbGenerar.TabStop = false;
            this.gbGenerar.Text = "Generar";
            // 
            // lblRecuerde
            // 
            this.lblRecuerde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecuerde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRecuerde.Location = new System.Drawing.Point(11, 89);
            this.lblRecuerde.Name = "lblRecuerde";
            this.lblRecuerde.Size = new System.Drawing.Size(358, 49);
            this.lblRecuerde.TabIndex = 17;
            this.lblRecuerde.Text = "Recuerde que la generación de CUIL, debe realizarse ante un organismo autorizado " +
                "(ANSES).  Este generador solo provee un número de CUIL estimado.";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDNI.Location = new System.Drawing.Point(24, 59);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(33, 13);
            this.lblDNI.TabIndex = 16;
            this.lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(64, 56);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(68, 20);
            this.txtDNI.TabIndex = 15;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(234, 28);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(87, 20);
            this.btnGenerar.TabIndex = 14;
            this.btnGenerar.Text = "&Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSexo.Location = new System.Drawing.Point(24, 32);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 13);
            this.lblSexo.TabIndex = 13;
            this.lblSexo.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.BackColor = System.Drawing.Color.White;
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cmbSexo.Location = new System.Drawing.Point(64, 29);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(110, 21);
            this.cmbSexo.TabIndex = 12;
            // 
            // frmValidaCUIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 324);
            this.Controls.Add(this.gbGenerar);
            this.Controls.Add(this.gbValidar);
            this.Controls.Add(this.btnCerrar);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmValidaCUIL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validador de CUIL";
            this.Load += new System.EventHandler(this.frmValidaCUIL_Load);
            this.gbValidar.ResumeLayout(false);
            this.gbValidar.PerformLayout();
            this.gbGenerar.ResumeLayout(false);
            this.gbGenerar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbValidar;
        private System.Windows.Forms.GroupBox gbGenerar;
        private System.Windows.Forms.Label lblCUIL;
        private System.Windows.Forms.TextBox txtCUIL;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblRecuerde;
    }
}