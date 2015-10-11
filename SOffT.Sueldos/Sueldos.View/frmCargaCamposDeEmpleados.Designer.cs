/*  
    frmCargaCamposDeEmpleados.cs

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
    partial class frmCargaCamposDeEmpleados
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
            this.gbDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.lblTablasDetalle = new System.Windows.Forms.Label();
            this.cmbTablasDetalle = new System.Windows.Forms.ComboBox();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cmbTablasIndice = new System.Windows.Forms.ComboBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTablasIndice = new System.Windows.Forms.Label();
            this.lblApellidoyNombres = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.dgvCamposEmpleado = new System.Windows.Forms.DataGridView();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.gbDatosEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamposEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(660, 339);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 22);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbDatosEmpleado
            // 
            this.gbDatosEmpleado.Controls.Add(this.lblTablasDetalle);
            this.gbDatosEmpleado.Controls.Add(this.cmbTablasDetalle);
            this.gbDatosEmpleado.Controls.Add(this.cmbEmpleados);
            this.gbDatosEmpleado.Controls.Add(this.txtValor);
            this.gbDatosEmpleado.Controls.Add(this.cmbTablasIndice);
            this.gbDatosEmpleado.Controls.Add(this.txtLegajo);
            this.gbDatosEmpleado.Controls.Add(this.lblValor);
            this.gbDatosEmpleado.Controls.Add(this.lblTablasIndice);
            this.gbDatosEmpleado.Controls.Add(this.lblApellidoyNombres);
            this.gbDatosEmpleado.Controls.Add(this.lblLegajo);
            this.gbDatosEmpleado.Location = new System.Drawing.Point(1, 12);
            this.gbDatosEmpleado.Name = "gbDatosEmpleado";
            this.gbDatosEmpleado.Size = new System.Drawing.Size(745, 64);
            this.gbDatosEmpleado.TabIndex = 3;
            this.gbDatosEmpleado.TabStop = false;
            // 
            // lblTablasDetalle
            // 
            this.lblTablasDetalle.AutoSize = true;
            this.lblTablasDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablasDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTablasDetalle.Location = new System.Drawing.Point(434, 15);
            this.lblTablasDetalle.Name = "lblTablasDetalle";
            this.lblTablasDetalle.Size = new System.Drawing.Size(47, 13);
            this.lblTablasDetalle.TabIndex = 11;
            this.lblTablasDetalle.Text = "Detalle";
            // 
            // cmbTablasDetalle
            // 
            this.cmbTablasDetalle.FormattingEnabled = true;
            this.cmbTablasDetalle.Location = new System.Drawing.Point(437, 32);
            this.cmbTablasDetalle.Name = "cmbTablasDetalle";
            this.cmbTablasDetalle.Size = new System.Drawing.Size(202, 21);
            this.cmbTablasDetalle.TabIndex = 10;
            this.cmbTablasDetalle.SelectedIndexChanged += new System.EventHandler(this.cmbTablasDetalle_SelectedIndexChanged);
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(68, 32);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(196, 21);
            this.cmbEmpleados.TabIndex = 9;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(645, 33);
            this.txtValor.MaxLength = 15;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(87, 20);
            this.txtValor.TabIndex = 8;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // cmbTablasIndice
            // 
            this.cmbTablasIndice.FormattingEnabled = true;
            this.cmbTablasIndice.Location = new System.Drawing.Point(270, 32);
            this.cmbTablasIndice.Name = "cmbTablasIndice";
            this.cmbTablasIndice.Size = new System.Drawing.Size(161, 21);
            this.cmbTablasIndice.TabIndex = 7;
            this.cmbTablasIndice.SelectedIndexChanged += new System.EventHandler(this.cmbTablasIndice_SelectedIndexChanged);
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(11, 32);
            this.txtLegajo.MaxLength = 8;
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(47, 20);
            this.txtLegajo.TabIndex = 5;
            this.txtLegajo.TextChanged += new System.EventHandler(this.txtLegajo_TextChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblValor.Location = new System.Drawing.Point(642, 16);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(36, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor";
            // 
            // lblTablasIndice
            // 
            this.lblTablasIndice.AutoSize = true;
            this.lblTablasIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablasIndice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTablasIndice.Location = new System.Drawing.Point(267, 16);
            this.lblTablasIndice.Name = "lblTablasIndice";
            this.lblTablasIndice.Size = new System.Drawing.Size(46, 13);
            this.lblTablasIndice.TabIndex = 3;
            this.lblTablasIndice.Text = "Código";
            // 
            // lblApellidoyNombres
            // 
            this.lblApellidoyNombres.AutoSize = true;
            this.lblApellidoyNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoyNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblApellidoyNombres.Location = new System.Drawing.Point(61, 16);
            this.lblApellidoyNombres.Name = "lblApellidoyNombres";
            this.lblApellidoyNombres.Size = new System.Drawing.Size(115, 13);
            this.lblApellidoyNombres.TabIndex = 2;
            this.lblApellidoyNombres.Text = "Apellido y Nombres";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLegajo.Location = new System.Drawing.Point(8, 16);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(45, 13);
            this.lblLegajo.TabIndex = 1;
            this.lblLegajo.Text = "Legajo";
            // 
            // dgvCamposEmpleado
            // 
            this.dgvCamposEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamposEmpleado.Location = new System.Drawing.Point(1, 82);
            this.dgvCamposEmpleado.Name = "dgvCamposEmpleado";
            this.dgvCamposEmpleado.Size = new System.Drawing.Size(745, 240);
            this.dgvCamposEmpleado.TabIndex = 4;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(559, 339);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(95, 21);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // frmCargaCamposDeEmpleados
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 379);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.dgvCamposEmpleado);
            this.Controls.Add(this.gbDatosEmpleado);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCargaCamposDeEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Campos De Empleados";
            this.gbDatosEmpleado.ResumeLayout(false);
            this.gbDatosEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamposEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbDatosEmpleado;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cmbTablasIndice;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblTablasIndice;
        private System.Windows.Forms.Label lblApellidoyNombres;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.DataGridView dgvCamposEmpleado;
        private System.Windows.Forms.Label lblTablasDetalle;
        private System.Windows.Forms.ComboBox cmbTablasDetalle;
        private System.Windows.Forms.Button btnGrabar;
    }
}