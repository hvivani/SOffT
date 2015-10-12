namespace Reloj.View
{
    partial class frmFingerPrintUtils
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
            this.components = new System.ComponentModel.Container();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEnrolar = new System.Windows.Forms.Button();
            this.btnIdentificar = new System.Windows.Forms.Button();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cmbHuella = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rbMeniqueIzq = new System.Windows.Forms.RadioButton();
            this.rbAnularIzq = new System.Windows.Forms.RadioButton();
            this.pbManoDerecha = new System.Windows.Forms.PictureBox();
            this.pbManoIzquierda = new System.Windows.Forms.PictureBox();
            this.pbHuella = new System.Windows.Forms.PictureBox();
            this.rbMayorIzq = new System.Windows.Forms.RadioButton();
            this.rbIndiceIzq = new System.Windows.Forms.RadioButton();
            this.rbPulgarIzq = new System.Windows.Forms.RadioButton();
            this.rbMeniqueDer = new System.Windows.Forms.RadioButton();
            this.rbAnularDer = new System.Windows.Forms.RadioButton();
            this.rbMayorDer = new System.Windows.Forms.RadioButton();
            this.rbIndiceDer = new System.Windows.Forms.RadioButton();
            this.rbPulgarDer = new System.Windows.Forms.RadioButton();
            this.btnEliminarTodas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbManoDerecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManoIzquierda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuella)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(616, 320);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 21);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEnrolar
            // 
            this.btnEnrolar.Location = new System.Drawing.Point(450, 320);
            this.btnEnrolar.Name = "btnEnrolar";
            this.btnEnrolar.Size = new System.Drawing.Size(93, 22);
            this.btnEnrolar.TabIndex = 2;
            this.btnEnrolar.Text = "&Enrolar";
            this.btnEnrolar.UseVisualStyleBackColor = true;
            this.btnEnrolar.Click += new System.EventHandler(this.btnEnrolar_Click);
            // 
            // btnIdentificar
            // 
            this.btnIdentificar.Location = new System.Drawing.Point(261, 319);
            this.btnIdentificar.Name = "btnIdentificar";
            this.btnIdentificar.Size = new System.Drawing.Size(93, 22);
            this.btnIdentificar.TabIndex = 3;
            this.btnIdentificar.Text = "&Identificar";
            this.btnIdentificar.UseVisualStyleBackColor = true;
            this.btnIdentificar.Click += new System.EventHandler(this.btnIdentificar_Click);
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMensajes.Location = new System.Drawing.Point(27, 288);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(81, 16);
            this.lblMensajes.TabIndex = 4;
            this.lblMensajes.Text = "lblMensajes";
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(258, 31);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(275, 21);
            this.cmbEmpleados.TabIndex = 10;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblEmpleado.Location = new System.Drawing.Point(258, 18);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(66, 13);
            this.lblEmpleado.TabIndex = 11;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // cmbHuella
            // 
            this.cmbHuella.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbHuella.Enabled = false;
            this.cmbHuella.FormattingEnabled = true;
            this.cmbHuella.Location = new System.Drawing.Point(488, 283);
            this.cmbHuella.Name = "cmbHuella";
            this.cmbHuella.Size = new System.Drawing.Size(221, 21);
            this.cmbHuella.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rbMeniqueIzq
            // 
            this.rbMeniqueIzq.AutoSize = true;
            this.rbMeniqueIzq.Location = new System.Drawing.Point(450, 84);
            this.rbMeniqueIzq.Name = "rbMeniqueIzq";
            this.rbMeniqueIzq.Size = new System.Drawing.Size(14, 13);
            this.rbMeniqueIzq.TabIndex = 15;
            this.rbMeniqueIzq.TabStop = true;
            this.rbMeniqueIzq.UseVisualStyleBackColor = true;
            this.rbMeniqueIzq.CheckedChanged += new System.EventHandler(this.rbMeniqueIzq_CheckedChanged);
            // 
            // rbAnularIzq
            // 
            this.rbAnularIzq.AutoSize = true;
            this.rbAnularIzq.Location = new System.Drawing.Point(450, 122);
            this.rbAnularIzq.Name = "rbAnularIzq";
            this.rbAnularIzq.Size = new System.Drawing.Size(14, 13);
            this.rbAnularIzq.TabIndex = 17;
            this.rbAnularIzq.TabStop = true;
            this.rbAnularIzq.UseVisualStyleBackColor = true;
            this.rbAnularIzq.CheckedChanged += new System.EventHandler(this.rbAnularIzq_CheckedChanged);
            // 
            // pbManoDerecha
            // 
            this.pbManoDerecha.Image = global::Reloj.View.Properties.Resources.mano001;
            this.pbManoDerecha.Location = new System.Drawing.Point(488, 65);
            this.pbManoDerecha.Name = "pbManoDerecha";
            this.pbManoDerecha.Size = new System.Drawing.Size(221, 212);
            this.pbManoDerecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbManoDerecha.TabIndex = 16;
            this.pbManoDerecha.TabStop = false;
            // 
            // pbManoIzquierda
            // 
            this.pbManoIzquierda.Image = global::Reloj.View.Properties.Resources.mano011;
            this.pbManoIzquierda.Location = new System.Drawing.Point(261, 65);
            this.pbManoIzquierda.Name = "pbManoIzquierda";
            this.pbManoIzquierda.Size = new System.Drawing.Size(221, 212);
            this.pbManoIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbManoIzquierda.TabIndex = 14;
            this.pbManoIzquierda.TabStop = false;
            // 
            // pbHuella
            // 
            this.pbHuella.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHuella.Location = new System.Drawing.Point(30, 16);
            this.pbHuella.Name = "pbHuella";
            this.pbHuella.Size = new System.Drawing.Size(204, 267);
            this.pbHuella.TabIndex = 1;
            this.pbHuella.TabStop = false;
            // 
            // rbMayorIzq
            // 
            this.rbMayorIzq.AutoSize = true;
            this.rbMayorIzq.Location = new System.Drawing.Point(450, 160);
            this.rbMayorIzq.Name = "rbMayorIzq";
            this.rbMayorIzq.Size = new System.Drawing.Size(14, 13);
            this.rbMayorIzq.TabIndex = 18;
            this.rbMayorIzq.TabStop = true;
            this.rbMayorIzq.UseVisualStyleBackColor = true;
            this.rbMayorIzq.CheckedChanged += new System.EventHandler(this.rbMayorIzq_CheckedChanged);
            // 
            // rbIndiceIzq
            // 
            this.rbIndiceIzq.AutoSize = true;
            this.rbIndiceIzq.Location = new System.Drawing.Point(450, 198);
            this.rbIndiceIzq.Name = "rbIndiceIzq";
            this.rbIndiceIzq.Size = new System.Drawing.Size(14, 13);
            this.rbIndiceIzq.TabIndex = 19;
            this.rbIndiceIzq.TabStop = true;
            this.rbIndiceIzq.UseVisualStyleBackColor = true;
            this.rbIndiceIzq.CheckedChanged += new System.EventHandler(this.rbIndiceIzq_CheckedChanged);
            // 
            // rbPulgarIzq
            // 
            this.rbPulgarIzq.AutoSize = true;
            this.rbPulgarIzq.Location = new System.Drawing.Point(450, 235);
            this.rbPulgarIzq.Name = "rbPulgarIzq";
            this.rbPulgarIzq.Size = new System.Drawing.Size(14, 13);
            this.rbPulgarIzq.TabIndex = 20;
            this.rbPulgarIzq.TabStop = true;
            this.rbPulgarIzq.UseVisualStyleBackColor = true;
            this.rbPulgarIzq.CheckedChanged += new System.EventHandler(this.rbPulgarIzq_CheckedChanged);
            // 
            // rbMeniqueDer
            // 
            this.rbMeniqueDer.AutoSize = true;
            this.rbMeniqueDer.Location = new System.Drawing.Point(505, 84);
            this.rbMeniqueDer.Name = "rbMeniqueDer";
            this.rbMeniqueDer.Size = new System.Drawing.Size(14, 13);
            this.rbMeniqueDer.TabIndex = 21;
            this.rbMeniqueDer.TabStop = true;
            this.rbMeniqueDer.UseVisualStyleBackColor = true;
            this.rbMeniqueDer.CheckedChanged += new System.EventHandler(this.rbMeniqueDer_CheckedChanged);
            // 
            // rbAnularDer
            // 
            this.rbAnularDer.AutoSize = true;
            this.rbAnularDer.Location = new System.Drawing.Point(505, 122);
            this.rbAnularDer.Name = "rbAnularDer";
            this.rbAnularDer.Size = new System.Drawing.Size(14, 13);
            this.rbAnularDer.TabIndex = 22;
            this.rbAnularDer.TabStop = true;
            this.rbAnularDer.UseVisualStyleBackColor = true;
            this.rbAnularDer.CheckedChanged += new System.EventHandler(this.rbAnularDer_CheckedChanged);
            // 
            // rbMayorDer
            // 
            this.rbMayorDer.AutoSize = true;
            this.rbMayorDer.Location = new System.Drawing.Point(505, 160);
            this.rbMayorDer.Name = "rbMayorDer";
            this.rbMayorDer.Size = new System.Drawing.Size(14, 13);
            this.rbMayorDer.TabIndex = 23;
            this.rbMayorDer.TabStop = true;
            this.rbMayorDer.UseVisualStyleBackColor = true;
            this.rbMayorDer.CheckedChanged += new System.EventHandler(this.rbMayorDer_CheckedChanged);
            // 
            // rbIndiceDer
            // 
            this.rbIndiceDer.AutoSize = true;
            this.rbIndiceDer.Location = new System.Drawing.Point(505, 198);
            this.rbIndiceDer.Name = "rbIndiceDer";
            this.rbIndiceDer.Size = new System.Drawing.Size(14, 13);
            this.rbIndiceDer.TabIndex = 24;
            this.rbIndiceDer.TabStop = true;
            this.rbIndiceDer.UseVisualStyleBackColor = true;
            this.rbIndiceDer.CheckedChanged += new System.EventHandler(this.rbIndiceDer_CheckedChanged);
            // 
            // rbPulgarDer
            // 
            this.rbPulgarDer.AutoSize = true;
            this.rbPulgarDer.Location = new System.Drawing.Point(505, 235);
            this.rbPulgarDer.Name = "rbPulgarDer";
            this.rbPulgarDer.Size = new System.Drawing.Size(14, 13);
            this.rbPulgarDer.TabIndex = 25;
            this.rbPulgarDer.TabStop = true;
            this.rbPulgarDer.UseVisualStyleBackColor = true;
            this.rbPulgarDer.CheckedChanged += new System.EventHandler(this.rbPulgarDer_CheckedChanged);
            // 
            // btnEliminarTodas
            // 
            this.btnEliminarTodas.Location = new System.Drawing.Point(616, 29);
            this.btnEliminarTodas.Name = "btnEliminarTodas";
            this.btnEliminarTodas.Size = new System.Drawing.Size(93, 22);
            this.btnEliminarTodas.TabIndex = 26;
            this.btnEliminarTodas.Text = "&Eliminar Todas";
            this.btnEliminarTodas.UseVisualStyleBackColor = true;
            this.btnEliminarTodas.Click += new System.EventHandler(this.btnEliminarTodas_Click);
            // 
            // frmFingerPrintUtils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 352);
            this.Controls.Add(this.btnEliminarTodas);
            this.Controls.Add(this.rbPulgarDer);
            this.Controls.Add(this.rbIndiceDer);
            this.Controls.Add(this.rbMayorDer);
            this.Controls.Add(this.rbAnularDer);
            this.Controls.Add(this.rbMeniqueDer);
            this.Controls.Add(this.rbPulgarIzq);
            this.Controls.Add(this.rbIndiceIzq);
            this.Controls.Add(this.rbMayorIzq);
            this.Controls.Add(this.rbAnularIzq);
            this.Controls.Add(this.pbManoDerecha);
            this.Controls.Add(this.rbMeniqueIzq);
            this.Controls.Add(this.pbManoIzquierda);
            this.Controls.Add(this.cmbHuella);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.lblMensajes);
            this.Controls.Add(this.btnIdentificar);
            this.Controls.Add(this.btnEnrolar);
            this.Controls.Add(this.pbHuella);
            this.Controls.Add(this.btnCerrar);
            this.Name = "frmFingerPrintUtils";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FingerPrintUtils Wison OR200N";
            this.Load += new System.EventHandler(this.frmFingerPrintUtils_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbManoDerecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManoIzquierda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuella)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbHuella;
        private System.Windows.Forms.Button btnEnrolar;
        private System.Windows.Forms.Button btnIdentificar;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cmbHuella;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbManoIzquierda;
        private System.Windows.Forms.RadioButton rbMeniqueIzq;
        private System.Windows.Forms.PictureBox pbManoDerecha;
        private System.Windows.Forms.RadioButton rbAnularIzq;
        private System.Windows.Forms.RadioButton rbMayorIzq;
        private System.Windows.Forms.RadioButton rbIndiceIzq;
        private System.Windows.Forms.RadioButton rbPulgarIzq;
        private System.Windows.Forms.RadioButton rbMeniqueDer;
        private System.Windows.Forms.RadioButton rbAnularDer;
        private System.Windows.Forms.RadioButton rbMayorDer;
        private System.Windows.Forms.RadioButton rbIndiceDer;
        private System.Windows.Forms.RadioButton rbPulgarDer;
        private System.Windows.Forms.Button btnEliminarTodas;
    }
}