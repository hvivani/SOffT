/*  
    frmRecibo.cs

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
    partial class frmRecibo
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
            this.dgvRecibo = new System.Windows.Forms.DataGridView();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.gbDatosLiquidacion = new System.Windows.Forms.GroupBox();
            this.lblTipoLiquidacion = new System.Windows.Forms.Label();
            this.cmbTipoLiquidacion = new System.Windows.Forms.ComboBox();
            this.lblEstadoLiquidacion = new System.Windows.Forms.Label();
            this.cmbEstadoLiquidacion = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbLiquidacion = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.lblApellidoyNombres = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panelEdicion = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibo)).BeginInit();
            this.gbDatosLiquidacion.SuspendLayout();
            this.panelEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(679, 520);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvRecibo
            // 
            this.dgvRecibo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibo.Location = new System.Drawing.Point(12, 109);
            this.dgvRecibo.Name = "dgvRecibo";
            this.dgvRecibo.Size = new System.Drawing.Size(755, 398);
            this.dgvRecibo.TabIndex = 1;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(22, 72);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(49, 20);
            this.txtLegajo.TabIndex = 3;
            this.txtLegajo.Text = "1";
            this.txtLegajo.TextChanged += new System.EventHandler(this.txtLegajo_TextChanged);
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLegajo.Location = new System.Drawing.Point(19, 56);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(45, 13);
            this.lblLegajo.TabIndex = 4;
            this.lblLegajo.Text = "Legajo";
            // 
            // gbDatosLiquidacion
            // 
            this.gbDatosLiquidacion.Controls.Add(this.btnEliminar);
            this.gbDatosLiquidacion.Controls.Add(this.lblTipoLiquidacion);
            this.gbDatosLiquidacion.Controls.Add(this.cmbTipoLiquidacion);
            this.gbDatosLiquidacion.Controls.Add(this.lblEstadoLiquidacion);
            this.gbDatosLiquidacion.Controls.Add(this.cmbEstadoLiquidacion);
            this.gbDatosLiquidacion.Controls.Add(this.lblDescripcion);
            this.gbDatosLiquidacion.Controls.Add(this.cmbLiquidacion);
            this.gbDatosLiquidacion.Controls.Add(this.btnConsultar);
            this.gbDatosLiquidacion.Controls.Add(this.cmbEmpleados);
            this.gbDatosLiquidacion.Controls.Add(this.lblApellidoyNombres);
            this.gbDatosLiquidacion.Controls.Add(this.txtLegajo);
            this.gbDatosLiquidacion.Controls.Add(this.lblLegajo);
            this.gbDatosLiquidacion.Location = new System.Drawing.Point(12, 3);
            this.gbDatosLiquidacion.Name = "gbDatosLiquidacion";
            this.gbDatosLiquidacion.Size = new System.Drawing.Size(755, 100);
            this.gbDatosLiquidacion.TabIndex = 11;
            this.gbDatosLiquidacion.TabStop = false;
            this.gbDatosLiquidacion.Enter += new System.EventHandler(this.gbDatosLiquidacion_Enter);
            // 
            // lblTipoLiquidacion
            // 
            this.lblTipoLiquidacion.AutoSize = true;
            this.lblTipoLiquidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoLiquidacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTipoLiquidacion.Location = new System.Drawing.Point(465, 12);
            this.lblTipoLiquidacion.Name = "lblTipoLiquidacion";
            this.lblTipoLiquidacion.Size = new System.Drawing.Size(105, 13);
            this.lblTipoLiquidacion.TabIndex = 45;
            this.lblTipoLiquidacion.Text = "Tipo Liquidación:";
            // 
            // cmbTipoLiquidacion
            // 
            this.cmbTipoLiquidacion.FormattingEnabled = true;
            this.cmbTipoLiquidacion.Location = new System.Drawing.Point(468, 28);
            this.cmbTipoLiquidacion.Name = "cmbTipoLiquidacion";
            this.cmbTipoLiquidacion.Size = new System.Drawing.Size(134, 21);
            this.cmbTipoLiquidacion.TabIndex = 44;
            this.cmbTipoLiquidacion.SelectedIndexChanged += new System.EventHandler(this.cmbTipoLiquidacion_SelectedIndexChanged);
            // 
            // lblEstadoLiquidacion
            // 
            this.lblEstadoLiquidacion.AutoSize = true;
            this.lblEstadoLiquidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoLiquidacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblEstadoLiquidacion.Location = new System.Drawing.Point(325, 12);
            this.lblEstadoLiquidacion.Name = "lblEstadoLiquidacion";
            this.lblEstadoLiquidacion.Size = new System.Drawing.Size(50, 13);
            this.lblEstadoLiquidacion.TabIndex = 43;
            this.lblEstadoLiquidacion.Text = "Estado:";
            // 
            // cmbEstadoLiquidacion
            // 
            this.cmbEstadoLiquidacion.FormattingEnabled = true;
            this.cmbEstadoLiquidacion.Location = new System.Drawing.Point(328, 28);
            this.cmbEstadoLiquidacion.Name = "cmbEstadoLiquidacion";
            this.cmbEstadoLiquidacion.Size = new System.Drawing.Size(115, 21);
            this.cmbEstadoLiquidacion.TabIndex = 42;
            this.cmbEstadoLiquidacion.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoLiquidacion_SelectedIndexChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDescripcion.Location = new System.Drawing.Point(17, 12);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(76, 13);
            this.lblDescripcion.TabIndex = 41;
            this.lblDescripcion.Text = "Liquidación:";
            // 
            // cmbLiquidacion
            // 
            this.cmbLiquidacion.FormattingEnabled = true;
            this.cmbLiquidacion.Location = new System.Drawing.Point(20, 28);
            this.cmbLiquidacion.Name = "cmbLiquidacion";
            this.cmbLiquidacion.Size = new System.Drawing.Size(287, 21);
            this.cmbLiquidacion.TabIndex = 40;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(620, 25);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(85, 25);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(77, 72);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(275, 21);
            this.cmbEmpleados.TabIndex = 12;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            // 
            // lblApellidoyNombres
            // 
            this.lblApellidoyNombres.AutoSize = true;
            this.lblApellidoyNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoyNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblApellidoyNombres.Location = new System.Drawing.Point(70, 56);
            this.lblApellidoyNombres.Name = "lblApellidoyNombres";
            this.lblApellidoyNombres.Size = new System.Drawing.Size(115, 13);
            this.lblApellidoyNombres.TabIndex = 11;
            this.lblApellidoyNombres.Text = "Apellido y Nombres";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(3, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panelEdicion
            // 
            this.panelEdicion.Controls.Add(this.btnModificar);
            this.panelEdicion.Location = new System.Drawing.Point(12, 517);
            this.panelEdicion.Name = "panelEdicion";
            this.panelEdicion.Size = new System.Drawing.Size(661, 26);
            this.panelEdicion.TabIndex = 13;
            this.panelEdicion.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(620, 67);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 25);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 550);
            this.Controls.Add(this.panelEdicion);
            this.Controls.Add(this.gbDatosLiquidacion);
            this.Controls.Add(this.dgvRecibo);
            this.Controls.Add(this.btnCerrar);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRecibo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Recibo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibo)).EndInit();
            this.gbDatosLiquidacion.ResumeLayout(false);
            this.gbDatosLiquidacion.PerformLayout();
            this.panelEdicion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvRecibo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.GroupBox gbDatosLiquidacion;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Label lblApellidoyNombres;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbLiquidacion;
        private System.Windows.Forms.Label lblEstadoLiquidacion;
        private System.Windows.Forms.ComboBox cmbEstadoLiquidacion;
        private System.Windows.Forms.Label lblTipoLiquidacion;
        private System.Windows.Forms.ComboBox cmbTipoLiquidacion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panelEdicion;
        private System.Windows.Forms.Button btnEliminar;
    }
}