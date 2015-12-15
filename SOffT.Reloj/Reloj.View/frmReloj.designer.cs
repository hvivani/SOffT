//
//  frmReloj.designer.cs
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

namespace Reloj.View
{
    partial class frmReloj
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReloj));
            this.panelEmpresa = new System.Windows.Forms.Panel();
            this.pictureBoxEmpresa = new System.Windows.Forms.PictureBox();
            this.groupBoxUltimaFichada = new System.Windows.Forms.GroupBox();
            this.labelUltimaFichadaApellidoNombre = new System.Windows.Forms.Label();
            this.labelUltimaFichadaFecha = new System.Windows.Forms.Label();
            this.labelUltimaFichadaHora = new System.Windows.Forms.Label();
            this.labelUltimaFichadaLegajo = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.pictureBoxUltimaFichadaFoto = new System.Windows.Forms.PictureBox();
            this.groupBoxSistema = new System.Windows.Forms.GroupBox();
            this.labelSistemaFecha = new System.Windows.Forms.Label();
            this.labelSistemaHora = new System.Windows.Forms.Label();
            this.HistorialFichadas = new System.Windows.Forms.GroupBox();
            this.lstFichadas = new System.Windows.Forms.ListBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.textBoxStringTarjeta = new System.Windows.Forms.TextBox();
            this.timerHuella = new System.Windows.Forms.Timer(this.components);
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.panelEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpresa)).BeginInit();
            this.groupBoxUltimaFichada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUltimaFichadaFoto)).BeginInit();
            this.groupBoxSistema.SuspendLayout();
            this.HistorialFichadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEmpresa
            // 
            this.panelEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelEmpresa.Controls.Add(this.pictureBoxEmpresa);
            this.panelEmpresa.Location = new System.Drawing.Point(12, 12);
            this.panelEmpresa.Name = "panelEmpresa";
            this.panelEmpresa.Size = new System.Drawing.Size(766, 120);
            this.panelEmpresa.TabIndex = 0;
            // 
            // pictureBoxEmpresa
            // 
            this.pictureBoxEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxEmpresa.InitialImage = null;
            this.pictureBoxEmpresa.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEmpresa.Name = "pictureBoxEmpresa";
            this.pictureBoxEmpresa.Size = new System.Drawing.Size(766, 120);
            this.pictureBoxEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmpresa.TabIndex = 0;
            this.pictureBoxEmpresa.TabStop = false;
            // 
            // groupBoxUltimaFichada
            // 
            this.groupBoxUltimaFichada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxUltimaFichada.Controls.Add(this.btnExportar);
            this.groupBoxUltimaFichada.Controls.Add(this.labelUltimaFichadaApellidoNombre);
            this.groupBoxUltimaFichada.Controls.Add(this.labelUltimaFichadaFecha);
            this.groupBoxUltimaFichada.Controls.Add(this.labelUltimaFichadaHora);
            this.groupBoxUltimaFichada.Controls.Add(this.labelUltimaFichadaLegajo);
            this.groupBoxUltimaFichada.Controls.Add(this.labelHora);
            this.groupBoxUltimaFichada.Controls.Add(this.labelFecha);
            this.groupBoxUltimaFichada.Controls.Add(this.pictureBoxUltimaFichadaFoto);
            this.groupBoxUltimaFichada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxUltimaFichada.Location = new System.Drawing.Point(505, 199);
            this.groupBoxUltimaFichada.Name = "groupBoxUltimaFichada";
            this.groupBoxUltimaFichada.Size = new System.Drawing.Size(273, 302);
            this.groupBoxUltimaFichada.TabIndex = 1;
            this.groupBoxUltimaFichada.TabStop = false;
            this.groupBoxUltimaFichada.Text = "Ultima Fichada";
            // 
            // labelUltimaFichadaApellidoNombre
            // 
            this.labelUltimaFichadaApellidoNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUltimaFichadaApellidoNombre.BackColor = System.Drawing.SystemColors.Window;
            this.labelUltimaFichadaApellidoNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUltimaFichadaApellidoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelUltimaFichadaApellidoNombre.Location = new System.Drawing.Point(6, 203);
            this.labelUltimaFichadaApellidoNombre.Name = "labelUltimaFichadaApellidoNombre";
            this.labelUltimaFichadaApellidoNombre.Size = new System.Drawing.Size(261, 20);
            this.labelUltimaFichadaApellidoNombre.TabIndex = 10;
            this.labelUltimaFichadaApellidoNombre.Text = "Apellido y Nombre";
            this.labelUltimaFichadaApellidoNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUltimaFichadaFecha
            // 
            this.labelUltimaFichadaFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUltimaFichadaFecha.BackColor = System.Drawing.SystemColors.Window;
            this.labelUltimaFichadaFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUltimaFichadaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelUltimaFichadaFecha.Location = new System.Drawing.Point(72, 233);
            this.labelUltimaFichadaFecha.Name = "labelUltimaFichadaFecha";
            this.labelUltimaFichadaFecha.Size = new System.Drawing.Size(142, 29);
            this.labelUltimaFichadaFecha.TabIndex = 9;
            this.labelUltimaFichadaFecha.Text = "Fecha";
            this.labelUltimaFichadaFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUltimaFichadaHora
            // 
            this.labelUltimaFichadaHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUltimaFichadaHora.BackColor = System.Drawing.SystemColors.Window;
            this.labelUltimaFichadaHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUltimaFichadaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelUltimaFichadaHora.ForeColor = System.Drawing.Color.Red;
            this.labelUltimaFichadaHora.Location = new System.Drawing.Point(72, 268);
            this.labelUltimaFichadaHora.Name = "labelUltimaFichadaHora";
            this.labelUltimaFichadaHora.Size = new System.Drawing.Size(142, 29);
            this.labelUltimaFichadaHora.TabIndex = 8;
            this.labelUltimaFichadaHora.Text = "Hora";
            this.labelUltimaFichadaHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUltimaFichadaLegajo
            // 
            this.labelUltimaFichadaLegajo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUltimaFichadaLegajo.BackColor = System.Drawing.SystemColors.Window;
            this.labelUltimaFichadaLegajo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUltimaFichadaLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelUltimaFichadaLegajo.Location = new System.Drawing.Point(6, 177);
            this.labelUltimaFichadaLegajo.Name = "labelUltimaFichadaLegajo";
            this.labelUltimaFichadaLegajo.Size = new System.Drawing.Size(100, 20);
            this.labelUltimaFichadaLegajo.TabIndex = 7;
            this.labelUltimaFichadaLegajo.Text = "Legajo";
            this.labelUltimaFichadaLegajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHora
            // 
            this.labelHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(31, 278);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(34, 13);
            this.labelHora.TabIndex = 6;
            this.labelHora.Text = "Hora";
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(24, 243);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(42, 13);
            this.labelFecha.TabIndex = 5;
            this.labelFecha.Text = "Fecha";
            // 
            // pictureBoxUltimaFichadaFoto
            // 
            this.pictureBoxUltimaFichadaFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxUltimaFichadaFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxUltimaFichadaFoto.Location = new System.Drawing.Point(53, 19);
            this.pictureBoxUltimaFichadaFoto.Name = "pictureBoxUltimaFichadaFoto";
            this.pictureBoxUltimaFichadaFoto.Size = new System.Drawing.Size(172, 155);
            this.pictureBoxUltimaFichadaFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUltimaFichadaFoto.TabIndex = 0;
            this.pictureBoxUltimaFichadaFoto.TabStop = false;
            this.pictureBoxUltimaFichadaFoto.Click += new System.EventHandler(this.pictureBoxUltimaFichadaFoto_Click);
            // 
            // groupBoxSistema
            // 
            this.groupBoxSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSistema.Controls.Add(this.labelSistemaFecha);
            this.groupBoxSistema.Controls.Add(this.labelSistemaHora);
            this.groupBoxSistema.Location = new System.Drawing.Point(12, 138);
            this.groupBoxSistema.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxSistema.Name = "groupBoxSistema";
            this.groupBoxSistema.Size = new System.Drawing.Size(766, 58);
            this.groupBoxSistema.TabIndex = 2;
            this.groupBoxSistema.TabStop = false;
            this.groupBoxSistema.Text = "Fecha y Hora del Sistema";
            // 
            // labelSistemaFecha
            // 
            this.labelSistemaFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSistemaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelSistemaFecha.Location = new System.Drawing.Point(6, 16);
            this.labelSistemaFecha.Name = "labelSistemaFecha";
            this.labelSistemaFecha.Size = new System.Drawing.Size(478, 39);
            this.labelSistemaFecha.TabIndex = 12;
            this.labelSistemaFecha.Text = "Fecha";
            this.labelSistemaFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSistemaHora
            // 
            this.labelSistemaHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSistemaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.labelSistemaHora.ForeColor = System.Drawing.Color.Firebrick;
            this.labelSistemaHora.Location = new System.Drawing.Point(491, 16);
            this.labelSistemaHora.Name = "labelSistemaHora";
            this.labelSistemaHora.Size = new System.Drawing.Size(269, 39);
            this.labelSistemaHora.TabIndex = 11;
            this.labelSistemaHora.Text = "Hora";
            this.labelSistemaHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HistorialFichadas
            // 
            this.HistorialFichadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.HistorialFichadas.Controls.Add(this.lstFichadas);
            this.HistorialFichadas.Location = new System.Drawing.Point(12, 199);
            this.HistorialFichadas.Name = "HistorialFichadas";
            this.HistorialFichadas.Size = new System.Drawing.Size(487, 352);
            this.HistorialFichadas.TabIndex = 3;
            this.HistorialFichadas.TabStop = false;
            this.HistorialFichadas.Text = "Historial de Fichadas";
            // 
            // lstFichadas
            // 
            this.lstFichadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFichadas.FormattingEnabled = true;
            this.lstFichadas.Location = new System.Drawing.Point(10, 20);
            this.lstFichadas.Name = "lstFichadas";
            this.lstFichadas.Size = new System.Drawing.Size(463, 316);
            this.lstFichadas.TabIndex = 0;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciar.Location = new System.Drawing.Point(505, 507);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetener.Enabled = false;
            this.btnDetener.Location = new System.Drawing.Point(605, 507);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 23);
            this.btnDetener.TabIndex = 2;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(703, 507);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // timerReloj
            // 
            this.timerReloj.Enabled = true;
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            // 
            // textBoxStringTarjeta
            // 
            this.textBoxStringTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStringTarjeta.Enabled = false;
            this.textBoxStringTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxStringTarjeta.Location = new System.Drawing.Point(505, 536);
            this.textBoxStringTarjeta.Name = "textBoxStringTarjeta";
            this.textBoxStringTarjeta.Size = new System.Drawing.Size(273, 20);
            this.textBoxStringTarjeta.TabIndex = 0;
            // 
            // timerHuella
            // 
            this.timerHuella.Interval = 2000;
            this.timerHuella.Tick += new System.EventHandler(this.timerHuella_Tick);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.Navy;
            this.lblVersion.Location = new System.Drawing.Point(12, 554);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(51, 12);
            this.lblVersion.TabIndex = 14;
            this.lblVersion.Text = "v 0.0.0.0";
            // 
            // btnExportar
            // 
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.Location = new System.Drawing.Point(237, 268);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(30, 28);
            this.btnExportar.TabIndex = 11;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmReloj
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(790, 568);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.groupBoxSistema);
            this.Controls.Add(this.textBoxStringTarjeta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.HistorialFichadas);
            this.Controls.Add(this.groupBoxUltimaFichada);
            this.Controls.Add(this.panelEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmReloj";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Ingresos y Egresos del Personal";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmReloj_Load);
            this.Shown += new System.EventHandler(this.FormReloj_Shown);
            this.panelEmpresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpresa)).EndInit();
            this.groupBoxUltimaFichada.ResumeLayout(false);
            this.groupBoxUltimaFichada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUltimaFichadaFoto)).EndInit();
            this.groupBoxSistema.ResumeLayout(false);
            this.HistorialFichadas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEmpresa;
        private System.Windows.Forms.GroupBox groupBoxUltimaFichada;
        private System.Windows.Forms.GroupBox groupBoxSistema;
        private System.Windows.Forms.GroupBox HistorialFichadas;
        private System.Windows.Forms.PictureBox pictureBoxEmpresa;
        private System.Windows.Forms.PictureBox pictureBoxUltimaFichadaFoto;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Timer timerReloj;
        private System.Windows.Forms.TextBox textBoxStringTarjeta;
        private System.Windows.Forms.Label labelSistemaHora;
        private System.Windows.Forms.Label labelSistemaFecha;
        private System.Windows.Forms.Label labelUltimaFichadaApellidoNombre;
        private System.Windows.Forms.Label labelUltimaFichadaFecha;
        private System.Windows.Forms.Label labelUltimaFichadaHora;
        private System.Windows.Forms.Label labelUltimaFichadaLegajo;
        private System.Windows.Forms.ListBox lstFichadas;
        private System.Windows.Forms.Timer timerHuella;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnExportar;
    }
}

