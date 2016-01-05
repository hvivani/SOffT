//
//  frmPrincipal.designer.cs
//
//  Author:
//       Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>
//
//  Copyright (c) 2010 Hamekoz
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace Sofft.ViewComunes
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelDescripcion = new System.Windows.Forms.Panel();
            this.lblModulo = new System.Windows.Forms.Label();
            this.lblSistemaGestion = new System.Windows.Forms.Label();
            this.lblProcedimiento = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fLPBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pictureBoxEmpresa = new System.Windows.Forms.PictureBox();
            this.panelDescripcion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDescripcion
            // 
            this.panelDescripcion.BackgroundImage = global::Sofft.ViewComunes.Properties.Resources.Logo_sofft_horizontal;
            this.panelDescripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDescripcion.Controls.Add(this.pictureBoxEmpresa);
            this.panelDescripcion.Location = new System.Drawing.Point(40, 35);
            this.panelDescripcion.Name = "panelDescripcion";
            this.panelDescripcion.Size = new System.Drawing.Size(329, 108);
            this.panelDescripcion.TabIndex = 0;
            // 
            // lblModulo
            // 
            this.lblModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.ForeColor = System.Drawing.Color.Navy;
            this.lblModulo.Location = new System.Drawing.Point(39, 29);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(330, 56);
            this.lblModulo.TabIndex = 0;
            this.lblModulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSistemaGestion
            // 
            this.lblSistemaGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaGestion.ForeColor = System.Drawing.Color.Navy;
            this.lblSistemaGestion.Location = new System.Drawing.Point(40, 11);
            this.lblSistemaGestion.Name = "lblSistemaGestion";
            this.lblSistemaGestion.Size = new System.Drawing.Size(329, 18);
            this.lblSistemaGestion.TabIndex = 1;
            this.lblSistemaGestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcedimiento
            // 
            this.lblProcedimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedimiento.Location = new System.Drawing.Point(41, 80);
            this.lblProcedimiento.Name = "lblProcedimiento";
            this.lblProcedimiento.Size = new System.Drawing.Size(329, 18);
            this.lblProcedimiento.TabIndex = 2;
            this.lblProcedimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(448, 342);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(153, 25);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProcedimiento);
            this.groupBox1.Controls.Add(this.lblModulo);
            this.groupBox1.Controls.Add(this.lblSistemaGestion);
            this.groupBox1.Location = new System.Drawing.Point(20, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 137);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelDescripcion);
            this.groupBox2.Location = new System.Drawing.Point(20, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 181);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // fLPBotones
            // 
            this.fLPBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPBotones.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLPBotones.Location = new System.Drawing.Point(3, 16);
            this.fLPBotones.Margin = new System.Windows.Forms.Padding(10);
            this.fLPBotones.Name = "fLPBotones";
            this.fLPBotones.Size = new System.Drawing.Size(165, 305);
            this.fLPBotones.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fLPBotones);
            this.groupBox3.Location = new System.Drawing.Point(438, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 324);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.Navy;
            this.lblVersion.Location = new System.Drawing.Point(18, 352);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(51, 12);
            this.lblVersion.TabIndex = 13;
            this.lblVersion.Text = "v 0.0.0.0";
            // 
            // pictureBoxEmpresa
            // 
            this.pictureBoxEmpresa.Location = new System.Drawing.Point(0, -2);
            this.pictureBoxEmpresa.Name = "pictureBoxEmpresa";
            this.pictureBoxEmpresa.Size = new System.Drawing.Size(329, 108);
            this.pictureBoxEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmpresa.TabIndex = 0;
            this.pictureBoxEmpresa.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(616, 370);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrar);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelDescripcion.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDescripcion;
        private System.Windows.Forms.Label lblProcedimiento;
        private System.Windows.Forms.Label lblSistemaGestion;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel fLPBotones;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox pictureBoxEmpresa;

    }
}