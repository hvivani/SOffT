namespace Sofft.ViewComunes
{
    partial class frmABMC
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
            this.gbBotones = new System.Windows.Forms.GroupBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBotones
            // 
            this.gbBotones.Controls.Add(this.btnGrabar);
            this.gbBotones.Controls.Add(this.btnEliminar);
            this.gbBotones.Controls.Add(this.btnCancelar);
            this.gbBotones.Controls.Add(this.btnAgregar);
            this.gbBotones.Controls.Add(this.btnModificar);
            this.gbBotones.Location = new System.Drawing.Point(10, 136);
            this.gbBotones.Name = "gbBotones";
            this.gbBotones.Size = new System.Drawing.Size(619, 65);
            this.gbBotones.TabIndex = 61;
            this.gbBotones.TabStop = false;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::Sofft.ViewComunes.Properties.Resources.Save;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(103, 17);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(91, 37);
            this.btnGrabar.TabIndex = 61;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Sofft.ViewComunes.Properties.Resources.Trash32x32;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(200, 17);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 37);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Sofft.ViewComunes.Properties.Resources.Cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(394, 17);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 37);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Sofft.ViewComunes.Properties.Resources.Plus32x321;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(6, 17);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 37);
            this.btnAgregar.TabIndex = 57;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::Sofft.ViewComunes.Properties.Resources.Edit32x32;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(297, 17);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(91, 37);
            this.btnModificar.TabIndex = 59;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.ForeColor = System.Drawing.Color.Navy;
            this.gbDatos.Location = new System.Drawing.Point(11, 37);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(619, 83);
            this.gbDatos.TabIndex = 79;
            this.gbDatos.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Image = global::Sofft.ViewComunes.Properties.Resources.Magnifier32x32;
            this.btnBuscar.Location = new System.Drawing.Point(569, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(28, 28);
            this.btnBuscar.TabIndex = 95;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Image = global::Sofft.ViewComunes.Properties.Resources.Standby32x32;
            this.btnCerrar.Location = new System.Drawing.Point(603, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 28);
            this.btnCerrar.TabIndex = 56;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmABMC
            // 
            this.ClientSize = new System.Drawing.Size(641, 218);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gbBotones);
            this.Controls.Add(this.btnCerrar);
            this.MaximizeBox = false;
            this.Name = "frmABMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM ";
            this.Load += new System.EventHandler(this.frmABM_Load);
            this.gbBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.GroupBox gbBotones; //protected para poder cambiarle la posicion
        protected System.Windows.Forms.GroupBox gbDatos; //protected para poder cambiarle la posicion
        private System.Windows.Forms.Button btnGrabar;
        protected System.Windows.Forms.Button btnBuscar;
    }
}
