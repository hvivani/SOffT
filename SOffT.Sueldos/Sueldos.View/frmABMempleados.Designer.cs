/*  
    frmABMempleados.cs

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
    partial class frmABMempleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMempleados));
            this.lblEmpleadosNominaDesc = new System.Windows.Forms.Label();
            this.lblEmpleadosNomina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmpleadosNominaDesc
            // 
            this.lblEmpleadosNominaDesc.AutoSize = true;
            this.lblEmpleadosNominaDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblEmpleadosNominaDesc.Location = new System.Drawing.Point(6, 497);
            this.lblEmpleadosNominaDesc.Name = "lblEmpleadosNominaDesc";
            this.lblEmpleadosNominaDesc.Size = new System.Drawing.Size(151, 13);
            this.lblEmpleadosNominaDesc.TabIndex = 5;
            this.lblEmpleadosNominaDesc.Text = "Empleados activos en nómina:";
            // 
            // lblEmpleadosNomina
            // 
            this.lblEmpleadosNomina.AutoSize = true;
            this.lblEmpleadosNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadosNomina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblEmpleadosNomina.Location = new System.Drawing.Point(165, 498);
            this.lblEmpleadosNomina.Name = "lblEmpleadosNomina";
            this.lblEmpleadosNomina.Size = new System.Drawing.Size(14, 13);
            this.lblEmpleadosNomina.TabIndex = 6;
            this.lblEmpleadosNomina.Text = "0";
            // 
            // frmABMempleados
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(726, 520);
            this.Controls.Add(this.lblEmpleadosNominaDesc);
            this.Controls.Add(this.lblEmpleadosNomina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmABMempleados";
            this.Load += new System.EventHandler(this.frmABMempleados_Load);
            this.Controls.SetChildIndex(this.lblEmpleadosNomina, 0);
            this.Controls.SetChildIndex(this.lblEmpleadosNominaDesc, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleadosNominaDesc;
        private System.Windows.Forms.Label lblEmpleadosNomina;

    }
}
