namespace Sofft.ViewComunes
{
    partial class FrmDatos
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
            this.aceptarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aceptarButton
            // 
            this.aceptarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.aceptarButton.Image = global::Sofft.ViewComunes.Properties.Resources.CheckMark32x322;
            this.aceptarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aceptarButton.Location = new System.Drawing.Point(101, 238);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(103, 37);
            this.aceptarButton.TabIndex = 4;
            this.aceptarButton.Text = "&Aceptar";
            this.aceptarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelarButton.Image = global::Sofft.ViewComunes.Properties.Resources.Cancel;
            this.cancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarButton.Location = new System.Drawing.Point(210, 238);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(103, 37);
            this.cancelarButton.TabIndex = 3;
            this.cancelarButton.Text = "&Cancelar";
            this.cancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // FrmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(410, 298);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.cancelarButton);
            this.Name = "FrmDatos";
            this.Text = "frmDatos";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button aceptarButton;
        protected System.Windows.Forms.Button cancelarButton;
    }
}
