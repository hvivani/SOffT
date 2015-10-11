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
    public partial class frmABManticipos : Form
    {
        private int idAnticipo;

        public frmABManticipos()
        {
            InitializeComponent();
            this.txtLegajo.GotFocus += new EventHandler(txtLegajo_GotFocus);
            this.dtpFecha.Value = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
            this.cargarCombos();
            this.habilitaEliminar();
            this.ShowDialog();
        }

        void txtLegajo_GotFocus(object sender, EventArgs e)
        {
            this.txtLegajo.SelectAll();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.cmbEmpleados.SelectedValue) > 0)
            {
                this.habilitaGrabar();
                this.idAnticipo = 0;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarCombos()
        {
            Controles.cargaComboBox(this.cmbEmpleados, "Apellido y Nombres", "legajo", "empleadosConsultarParaCombo");
            Controles.cargaComboBox(this.cmbTipoAnticipo, "descripcion", "indice", "tablasConsultarIndiceDescripcion", "@tabla", "tiposDeAnticipo");
            Controles.cargaComboBox(this.cmbAnios, "contenido", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "calendario", "indice", 1);
            this.cmbAnios.SelectedValue = DateTime.Now.Year;
            Controles.cargaComboBox(this.cmbMeses, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "calendario", "indice", 2);
            this.cmbMeses.SelectedValue = DateTime.Now.Month;
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbEmpleados.SelectedValue != null)
            {
                this.txtLegajo.Text = this.cmbEmpleados.SelectedValue.ToString();
                this.actualizarGrilla();
            }
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

        private void actualizarGrilla()
        {
            Controles.cargaDataGridView(this.dgvAnticipos, "anticiposConsultarPorLegajo", "@legajo", this.cmbEmpleados.SelectedValue);
            Controles.setEstandarDataGridView(this.dgvAnticipos);
            dgvAnticipos.Columns[0].Visible = false;
            dgvAnticipos.Columns[3].Visible = false;
        }

        private void habilitaGrabar()
        {
            this.cmbAnios.Enabled = true;
            this.cmbMeses.Enabled = true;
            this.cmbTipoAnticipo.Enabled = true;
            this.txtNroComprobante.Enabled = true;
            this.dtpFecha.Enabled = true;
            this.txtImporte.Enabled = true;
            this.txtCuota.Enabled = true;

            this.btnAgregar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnGrabar.Enabled = true;
            this.btnModificar.Enabled = false;
            this.btnCancelar.Enabled = true;
            this.btnImprimir.Enabled = false;
            this.btnCerrar.Enabled = false;
            this.gbLegajo.Enabled = true;
            this.txtLegajo.Focus();
        }

        private void habilitaEliminar()
        {
            //this.gbLegajo.Enabled = false;
            this.cmbAnios.Enabled = false;
            this.cmbMeses.Enabled = false;
            this.cmbTipoAnticipo.Enabled = false;
            this.txtNroComprobante.Enabled = false;
            this.dtpFecha.Enabled = false;
            this.txtImporte.Enabled = false;
            this.txtCuota.Enabled = false;

            this.btnAgregar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnGrabar.Enabled = false;
            this.btnModificar.Enabled = true;
            this.btnCancelar.Enabled = false;
            this.btnImprimir.Enabled = true;
            this.btnCerrar.Enabled = true;
            this.txtLegajo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.habilitaEliminar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAnticipos.RowCount > 0)
            {
                if (Varios.IsNumeric(Controles.consultaCampoRenglon(this.dgvAnticipos, 0)) && Convert.ToInt32(Controles.consultaCampoRenglon(this.dgvAnticipos, 0)) > 0)
                {
                    if (Varios.confirmaEliminarRegistro())
                    {
                        Model.DB.ejecutarProceso(Model.TipoComando.SP, "anticipoEliminar", "@idAnticipo", Controles.consultaCampoRenglon(this.dgvAnticipos, 0));
                        this.actualizarGrilla();
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvAnticipos.RowCount > 0)
            {
                if (Varios.IsNumeric(Controles.consultaCampoRenglon(this.dgvAnticipos, 0)) && Convert.ToInt32(Controles.consultaCampoRenglon(this.dgvAnticipos, 0)) > 0)
                {
                    this.habilitaGrabar();
                    this.idAnticipo = Convert.ToInt32(Controles.consultaCampoRenglon(this.dgvAnticipos, 0));
                    this.cmbAnios.SelectedValue = Convert.ToInt32(Controles.consultaCampoRenglon(this.dgvAnticipos, 2)) / 100;
                    this.cmbMeses.SelectedValue = Convert.ToInt32(Controles.consultaCampoRenglon(this.dgvAnticipos, 2)) % 100;
                    this.cmbTipoAnticipo.SelectedValue = Controles.consultaCampoRenglon(this.dgvAnticipos, 3);
                    this.txtNroComprobante.Text = Controles.consultaCampoRenglon(this.dgvAnticipos, 5);
                    this.dtpFecha.Value = Convert.ToDateTime(Controles.consultaCampoRenglon(this.dgvAnticipos, 6));
                    this.txtImporte.Text = Controles.consultaCampoRenglon(this.dgvAnticipos, 7);
                    this.txtCuota.Text = Controles.consultaCampoRenglon(this.dgvAnticipos, 8);
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            if (datosValidos())
            {
                Model.DB.ejecutarProceso(Model.TipoComando.SP, "anticiposActualizar",
                    "@idAnticipo", this.idAnticipo,
                    "@legajo", Convert.ToInt32(this.cmbEmpleados.SelectedValue),
                    "@anioMes", Convert.ToInt32(this.cmbAnios.SelectedValue) * 100 + Convert.ToInt32(this.cmbMeses.SelectedValue),
                    "@idTipoAnticipo", Convert.ToInt32(this.cmbTipoAnticipo.SelectedValue),
                    "@nroComprobante", this.txtNroComprobante.Text,
                    "@fechaComprobante", this.dtpFecha.Value.ToShortDateString(),
                    "@importe", this.txtImporte.Text,
                    "@cuota", Convert.ToInt32(this.txtCuota.Text),
                    "@comentarios", "");
                this.actualizarGrilla();
                this.habilitaEliminar();
                this.btnAgregar.Focus();
            }
        }

        private bool datosValidos()
        {
            Boolean ok = true;
            if (Convert.ToDouble(this.txtImporte.Text) <= 0)
            {
                ok = false;
                MessageBox.Show("El importe debe ser mayor a cero.");
                this.txtImporte.Focus();
            }
            else
            {
                if (this.txtNroComprobante.Text.Length == 0)
                {
                    ok = false;
                    MessageBox.Show("Debe ingresar un número de comprobante");
                    this.txtNroComprobante.Focus();
                }
                else
                {
                    if (this.txtCuota.Text.Length == 0 || Convert.ToDouble(this.txtCuota.Text) <= 0 || Convert.ToDouble(this.txtCuota.Text) > 64)
                    {
                        ok = false;
                        MessageBox.Show("El número de cuotas es erróneo");
                        this.txtCuota.Focus();
                    }
                }
            }

            return ok;
        }


        private void txtAnioMes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { this.cmbTipoAnticipo.Focus(); }
        }

        private void cmbTipoAnticipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtNroComprobante.Focus();
                this.txtNroComprobante.SelectAll();
            }
        }

        private void txtNroComprobante_KeyDown(object sender, KeyEventArgs e)
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
                    this.txtCuota.Focus();
                    this.txtCuota.SelectAll();
                }
                else
                { txtImporte.SelectAll(); }
            }
        }

        private void txtCuota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Varios.IsNumeric(txtCuota.Text))
                { this.btnGrabar.Focus(); }
                else
                { this.txtCuota.SelectAll(); }
            }
        }
        private void txtLegajo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { this.cmbAnios.Focus(); }
        }

        private void btnAgregar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.txtLegajo.Focus();
                this.txtLegajo.SelectAll();
            }
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
            if (dgvAnticipos.RowCount > 0)
            {
                if (Varios.IsNumeric(Controles.consultaCampoRenglon(this.dgvAnticipos, 0)) && Convert.ToInt32(Controles.consultaCampoRenglon(this.dgvAnticipos, 0)) > 0)
                {
                    this.idAnticipo = Convert.ToInt32(Controles.consultaCampoRenglon(this.dgvAnticipos, 0));
                 /*   Reportes.CRAnticipoVale anticipoVale = new Sueldos.View.Reportes.CRAnticipoVale();
                    anticipoVale.SetDataSource(Model.DB.ejecutarDataSet(Model.TipoComando.SP, "anticiposConsultarParaVale",
                        "idAnticipo", this.idAnticipo));
                    frmReportes visor = new frmReportes(anticipoVale);
                    visor.ShowDialog();*/

                    //EmpresaEntity emp = new ConsultaEmpresas().getEmpresa(1);
                    DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "anticiposConsultarParaVale", "idAnticipo", this.idAnticipo);
                    Sueldos.Reportes.CrystalReport.ReportesCreador.ValeAnticipo(ds);
                }
            }
        }

        private void gbLegajo_Enter(object sender, EventArgs e)
        {

        }
    }
}