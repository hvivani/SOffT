using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sofft.Utils;
using Sofft.ViewComunes;

namespace Sueldos.View
{
    public partial class frmAnticipo : Form
    {
        private int idAnticipo;

        public frmAnticipo()
        {
            InitializeComponent();
            this.cargarCombos();
        }

        public void abrirParaConsultar()
        {
            this.gbLegajo.Enabled = false;
            this.btnImprimir.Enabled = true;
            this.ShowDialog();
        }

        public void abrirParaNuevo()
        {
            this.gbLegajo.Enabled = true;
            this.btnImprimir.Enabled = false;
            this.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        { this.Close(); }

        private void cargarCombos()
        {
            Controles.cargaComboBox(this.cmbEmpleados, "Apellido y Nombres", "legajo", "empleadosConsultarParaCombo");
            cmbEmpleados.Text = "";
            Controles.cargaComboBox(this.cmbTipoAnticipo, "descripcion", "indice", "tablasConsultarIndiceDescripcion", "@tabla", "tiposDeAnticipo");
            Controles.cargaComboBox(this.cmbAnios, "contenido", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "calendario", "indice", 1);
            this.cmbAnios.SelectedValue = DateTime.Now.Year;
            Controles.cargaComboBox(this.cmbMeses, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "calendario", "indice", 2);
            this.cmbMeses.SelectedValue = DateTime.Now.Month;
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbEmpleados.SelectedValue != null)
            { this.txtLegajo.Text = this.cmbEmpleados.SelectedValue.ToString(); }
        }

        private void txtLegajo_TextChanged(object sender, EventArgs e)
        {
            if (Varios.IsNumeric(this.txtLegajo.Text))
            {
                this.cmbEmpleados.SelectedValue = this.txtLegajo.Text;
                this.txtNroComprobante.Text = "";
                this.dtpFecha.Value = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
                this.txtImporte.Text = "0.00";
                this.txtCuota.Text = "1";
            }
            else
                this.cmbEmpleados.SelectedValue = 0;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            this.idAnticipo = Convert.ToInt32(Model.DB.ejecutarScalar(Model.TipoComando.SP, "anticiposActualizar",
                "@idAnticipo", 0,
                "@legajo", Convert.ToInt32(this.cmbEmpleados.SelectedValue),
                "@anioMes", Convert.ToInt32(this.cmbAnios.SelectedValue) * 100 + Convert.ToInt32(this.cmbMeses.SelectedValue),
                "@idTipoAnticipo", Convert.ToInt32(this.cmbTipoAnticipo.SelectedValue),
                "@nroComprobante", this.txtNroComprobante.Text,
                "@fechaComprobante", this.dtpFecha.Value.ToShortDateString(),
                "@importe", this.txtImporte.Text,
                "@cuota", Convert.ToInt32(this.txtCuota.Text),
                "@comentarios", txtComentarios.Text));
            this.btnGrabar.Enabled = false;
            this.btnImprimir.Enabled = true;
            this.btnImprimir.Focus();
        }

        private void txtAnioMes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { this.cmbTipoAnticipo.Focus(); }
        }

        private void cmbTipoAnticipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { this.dtpFecha.Focus(); }
        }

        private void dtpFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtImporte.Focus();
                this.txtImporte.SelectAll();
            }
        }

        private void txtImporte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Varios.IsNumeric(txtImporte.Text))
                {
                    txtComentarios.SelectAll();
                    txtComentarios.Focus();
                }
                else
                { txtImporte.SelectAll(); }
            }
        }

        private void txtLegajo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { this.cmbAnios.Focus(); }
        }

        private void cmbEmpleados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { this.cmbAnios.Focus(); }
            if (e.KeyCode == Keys.Escape)
            {
                this.txtLegajo.Focus();
                this.txtLegajo.SelectAll();
            }
        }

        private void cmbAnios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { this.cmbMeses.Focus(); }
        }

        private void cmbMeses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { this.cmbTipoAnticipo.Focus(); }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
          /*  Reportes.CRAnticipoVale anticipoVale = new Sueldos.View.Reportes.CRAnticipoVale();
            anticipoVale.SetDataSource(Model.DB.ejecutarDataSet(Model.TipoComando.SP, "anticiposConsultarParaVale",
                "idAnticipo", this.idAnticipo));
            frmReportes visor = new frmReportes(anticipoVale);
            visor.ShowDialog();*/

            DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "anticiposConsultarParaVale", "idAnticipo", this.idAnticipo);
            Sueldos.Reportes.CrystalReport.ReportesCreador.ValeAnticipo(ds);
        }

        private void txtComentarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnGrabar.Enabled = true;
                this.btnGrabar.Focus();
            }
        }
    }
}