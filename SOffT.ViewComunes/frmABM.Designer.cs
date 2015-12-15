//
//  frmABM.Designer.cs
//
//  Author:
//       Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>
//
//  Copyright (c) 2015 Hamekoz
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
    partial class frmABM
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
            this.btnTodos = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.flpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.flpFiltros = new System.Windows.Forms.FlowLayoutPanel();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBoxBuqueda = new System.Windows.Forms.TextBox();
            this.flpBusquedas = new System.Windows.Forms.FlowLayoutPanel();
            this.grpBotones = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.gbBuscar.SuspendLayout();
            this.grpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(609, 178);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(97, 23);
            this.btnTodos.TabIndex = 4;
            this.btnTodos.Text = "Mostrar Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvDatos.ColumnHeadersHeight = 20;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatos.Location = new System.Drawing.Point(6, 178);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 21;
            this.dgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatos.RowTemplate.Height = 20;
            this.dgvDatos.RowTemplate.ReadOnly = true;
            this.dgvDatos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(571, 308);
            this.dgvDatos.TabIndex = 0;
            // 
            // flpBotones
            // 
            this.flpBotones.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpBotones.Location = new System.Drawing.Point(9, 16);
            this.flpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.flpBotones.Name = "flpBotones";
            this.flpBotones.Size = new System.Drawing.Size(103, 222);
            this.flpBotones.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(13, 241);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(97, 30);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.flpFiltros);
            this.gbFiltros.Location = new System.Drawing.Point(6, 76);
            this.gbFiltros.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(716, 99);
            this.gbFiltros.TabIndex = 2;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // flpFiltros
            // 
            this.flpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFiltros.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpFiltros.Location = new System.Drawing.Point(3, 16);
            this.flpFiltros.Margin = new System.Windows.Forms.Padding(0);
            this.flpFiltros.Name = "flpFiltros";
            this.flpFiltros.Size = new System.Drawing.Size(710, 80);
            this.flpFiltros.TabIndex = 0;
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Controls.Add(this.txtBoxBuqueda);
            this.gbBuscar.Controls.Add(this.flpBusquedas);
            this.gbBuscar.Location = new System.Drawing.Point(6, 3);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(716, 70);
            this.gbBuscar.TabIndex = 1;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar por";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(613, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBoxBuqueda
            // 
            this.txtBoxBuqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxBuqueda.Location = new System.Drawing.Point(8, 44);
            this.txtBoxBuqueda.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtBoxBuqueda.Name = "txtBoxBuqueda";
            this.txtBoxBuqueda.Size = new System.Drawing.Size(596, 20);
            this.txtBoxBuqueda.TabIndex = 1;
            // 
            // flpBusquedas
            // 
            this.flpBusquedas.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpBusquedas.Location = new System.Drawing.Point(3, 16);
            this.flpBusquedas.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.flpBusquedas.Name = "flpBusquedas";
            this.flpBusquedas.Size = new System.Drawing.Size(710, 23);
            this.flpBusquedas.TabIndex = 0;
            // 
            // grpBotones
            // 
            this.grpBotones.Controls.Add(this.flpBotones);
            this.grpBotones.Controls.Add(this.btnCerrar);
            this.grpBotones.Location = new System.Drawing.Point(596, 206);
            this.grpBotones.Name = "grpBotones";
            this.grpBotones.Size = new System.Drawing.Size(120, 280);
            this.grpBotones.TabIndex = 3;
            this.grpBotones.TabStop = false;
            // 
            // frmABM
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 500);
            this.Controls.Add(this.grpBotones);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.dgvDatos);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmABM";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.grpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.FlowLayoutPanel flpBotones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBoxBuqueda;
        private System.Windows.Forms.FlowLayoutPanel flpFiltros;
        private System.Windows.Forms.FlowLayoutPanel flpBusquedas;
        private System.Windows.Forms.GroupBox grpBotones;
    }
}