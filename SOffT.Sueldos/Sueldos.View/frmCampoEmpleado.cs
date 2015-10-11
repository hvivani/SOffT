using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sofft.Utils;
using Sofft.ViewComunes;
using Sueldos.Entidades;

namespace Sueldos.View
{
    public partial class frmCampoEmpleado : Form
    {

        public frmCampoEmpleado()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCampoEmpleado_Load(object sender, EventArgs e)
        {

        }

        public void abrirParaModificar(ref CampoEmpleadoEntity c)
        {
            this.txtCodigo.Enabled = false;
            this.cmbDescripcion.Enabled = false;
            Controles.cargaComboBox(this.cmbDescripcion, "descripcion", "indice", "tablasConsultarOtrosCamposEmpleado");
            Controles.cargaComboBox(this.cmbDetalle, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "EmpleadosSueldos", "@indice", c.Codigo);
            this.txtCodigo.Text = c.Codigo.ToString();
            this.txtValor.Text = c.Valor;
            this.cmbDescripcion.SelectedValue = c.Codigo;
            if (Varios.IsNumeric(c.Valor))
                this.cmbDetalle.SelectedValue = Convert.ToDouble(c.Valor);
            else
                this.cmbDetalle.SelectedValue = null;
            this.ShowDialog();
            c.Valor = this.txtValor.Text;
        }


        public void abrirParaNuevo(ref CampoEmpleadoEntity c)
        {
            this.txtCodigo.Enabled = false;
            this.cmbDescripcion.Enabled = true;
            Controles.cargaComboBox(this.cmbDescripcion, "descripcion", "indice", "tablasConsultarOtrosCamposEmpleado");
            Controles.cargaComboBox(this.cmbDetalle, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "EmpleadosSueldos", "@indice", c.Codigo);
            this.txtCodigo.Text = c.Codigo.ToString();
            this.txtValor.Text = c.Valor;
            this.cmbDescripcion.SelectedValue = c.Codigo;
            if (Varios.IsNumeric(c.Valor))
                this.cmbDetalle.SelectedValue = Convert.ToDouble(c.Valor);
            else
                this.cmbDetalle.SelectedValue = null;
            this.ShowDialog();
            c.Codigo = Convert.ToInt32(this.cmbDescripcion.SelectedValue);
            c.Descripcion = this.cmbDescripcion.Text;
            c.Valor = this.txtValor.Text;
            c.Detalle = this.cmbDetalle.Text;
        }

        private void cmbDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbDescripcion.SelectedValue != null)
                this.txtCodigo.Text = this.cmbDescripcion.SelectedValue.ToString();
       /*     if (cmbDetalle.Text.Length == 0)
                cmbDetalle.Enabled = false;
            else
                cmbDetalle.Enabled = true;*/
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text.Length>0)
                Controles.cargaComboBox(this.cmbDetalle, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "EmpleadosSueldos", "@indice", Convert.ToInt32(this.txtCodigo.Text));
            else
                Controles.cargaComboBox(this.cmbDetalle, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "EmpleadosSueldos", "@indice", 0);

        }

        private void cmbDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbDetalle.SelectedValue !=null)
                this.txtValor.Text = this.cmbDetalle.SelectedValue.ToString();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
        }

 
    }
}