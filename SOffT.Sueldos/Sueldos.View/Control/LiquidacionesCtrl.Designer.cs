/*  
    LiquidacionesCtrl.cs

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

namespace Sueldos.View.Control
{
    partial class LiquidacionesCtrl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxLiquidaciones = new System.Windows.Forms.ComboBox();
            this.listBoxTiposLiquidacion = new System.Windows.Forms.ListBox();
            this.labelLiquidacion = new System.Windows.Forms.Label();
            this.labelTipoLiquidacion = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxLiquidaciones
            // 
            this.comboBoxLiquidaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLiquidaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLiquidaciones.DropDownWidth = 250;
            this.comboBoxLiquidaciones.FormattingEnabled = true;
            this.comboBoxLiquidaciones.Location = new System.Drawing.Point(6, 59);
            this.comboBoxLiquidaciones.Name = "comboBoxLiquidaciones";
            this.comboBoxLiquidaciones.Size = new System.Drawing.Size(108, 21);
            this.comboBoxLiquidaciones.TabIndex = 0;
            this.comboBoxLiquidaciones.SelectedIndexChanged += new System.EventHandler(this.comboBoxLiquidaciones_SelectedIndexChanged);
            // 
            // listBoxTiposLiquidacion
            // 
            this.listBoxTiposLiquidacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTiposLiquidacion.FormattingEnabled = true;
            this.listBoxTiposLiquidacion.Location = new System.Drawing.Point(6, 99);
            this.listBoxTiposLiquidacion.Name = "listBoxTiposLiquidacion";
            this.listBoxTiposLiquidacion.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTiposLiquidacion.Size = new System.Drawing.Size(108, 82);
            this.listBoxTiposLiquidacion.TabIndex = 1;
            // 
            // labelLiquidacion
            // 
            this.labelLiquidacion.AutoSize = true;
            this.labelLiquidacion.Location = new System.Drawing.Point(3, 43);
            this.labelLiquidacion.Name = "labelLiquidacion";
            this.labelLiquidacion.Size = new System.Drawing.Size(61, 13);
            this.labelLiquidacion.TabIndex = 2;
            this.labelLiquidacion.Text = "Liquidacion";
            // 
            // labelTipoLiquidacion
            // 
            this.labelTipoLiquidacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTipoLiquidacion.AutoSize = true;
            this.labelTipoLiquidacion.Location = new System.Drawing.Point(3, 83);
            this.labelTipoLiquidacion.Name = "labelTipoLiquidacion";
            this.labelTipoLiquidacion.Size = new System.Drawing.Size(105, 13);
            this.labelTipoLiquidacion.TabIndex = 3;
            this.labelTipoLiquidacion.Text = "Tipos de Liquidacion";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(6, 3);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 5;
            this.labelEstado.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.DropDownWidth = 250;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(6, 19);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(108, 21);
            this.comboBoxEstado.TabIndex = 4;
            this.comboBoxEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstado_SelectedIndexChanged);
            // 
            // LiquidacionesCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.labelTipoLiquidacion);
            this.Controls.Add(this.labelLiquidacion);
            this.Controls.Add(this.listBoxTiposLiquidacion);
            this.Controls.Add(this.comboBoxLiquidaciones);
            this.MaximumSize = new System.Drawing.Size(250, 200);
            this.MinimumSize = new System.Drawing.Size(120, 140);
            this.Name = "LiquidacionesCtrl";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(120, 186);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLiquidaciones;
        private System.Windows.Forms.ListBox listBoxTiposLiquidacion;
        private System.Windows.Forms.Label labelLiquidacion;
        private System.Windows.Forms.Label labelTipoLiquidacion;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
    }
}
