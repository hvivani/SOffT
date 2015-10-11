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
    public partial class frmCargaAcumulados : Form
    {
        Acumulados acumulados;
        Acumulado acumulado;


        public frmCargaAcumulados()
        {
            InitializeComponent();
            this.txtLegajo.KeyDown += new KeyEventHandler(txtLegajo_KeyDown);
            this.txtLegajo.GotFocus += new EventHandler(txtLegajo_GotFocus);
            this.cmbEmpleados.KeyDown += new KeyEventHandler(cmbEmpleados_KeyDown);
            this.cmbTablasIndice.KeyDown += new KeyEventHandler(cmbTablasIndice_KeyDown);
            this.cmbAnios.KeyDown += new KeyEventHandler(cmbAnios_KeyDown);
            this.cmbMeses.KeyDown += new KeyEventHandler(cmbMeses_KeyDown);
            this.txtValor.KeyDown += new KeyEventHandler(txtValor_KeyDown);
            this.txtValor.GotFocus += new EventHandler(txtValor_GotFocus);
            this.acumulados = new Acumulados();
            this.cargarCombos();
            this.ShowDialog();
        }

        void txtValor_GotFocus(object sender, EventArgs e)
        {
            this.txtValor.SelectAll();
        }

        void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnGrabar.Focus();
            }
        }

        void cmbMeses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtValor.Focus();
        }

        void cmbAnios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.cmbMeses.Focus();
        }

        void cmbTablasIndice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.cmbAnios.Focus();
        }

        void cmbEmpleados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.cmbTablasIndice.Focus();
        }

        void txtLegajo_GotFocus(object sender, EventArgs e)
        {
            this.txtLegajo.SelectAll();
        }

        void txtLegajo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.cmbEmpleados.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarCombos()
        {
            Controles.cargaComboBox(this.cmbEmpleados, "Apellido y Nombres", "legajo", "empleadosConsultarParaCombo");
            Controles.cargaComboBox(this.cmbTablasIndice, "descripcion", "indice", "tablasConsultarIndiceDescripcion", "@tabla", "acumulados");
            Controles.cargaComboBox(this.cmbAnios, "contenido", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "calendario", "indice", 1);
            this.cmbAnios.SelectedValue = DateTime.Now.Year;
            Controles.cargaComboBox(this.cmbMeses, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "calendario", "indice", 2);
            this.cmbMeses.SelectedValue = DateTime.Now.Month;
        }

        private void txtLegajo_TextChanged(object sender, EventArgs e)
        {
            if (Varios.IsNumeric(this.txtLegajo.Text))
                this.cmbEmpleados.SelectedValue = this.txtLegajo.Text;
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbEmpleados.SelectedValue != null)
                this.txtLegajo.Text = this.cmbEmpleados.SelectedValue.ToString();

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(this.cmbEmpleados.SelectedValue) > 0 && Convert.ToInt32(this.cmbTablasIndice.SelectedValue) > 0)
            {
                //si es el acumlado de bruto para sac (cod. 15) se actualiza sobre indice 2 (tipo liq sac)
                if (Convert.ToInt32(this.cmbTablasIndice.SelectedValue)==15)
                    acumulado = new Acumulado(Convert.ToInt32(this.cmbAnios.SelectedValue.ToString() + this.cmbMeses.SelectedValue.ToString().PadLeft(2, '0')), 2, Convert.ToInt32(this.cmbEmpleados.SelectedValue), Convert.ToInt32(this.cmbTablasIndice.SelectedValue), this.cmbTablasIndice.Text ,Convert.ToDouble(this.txtValor.Text));
                else 
                    acumulado = new Acumulado(Convert.ToInt32(this.cmbAnios.SelectedValue.ToString() + this.cmbMeses.SelectedValue.ToString().PadLeft(2, '0')), 0, Convert.ToInt32(this.cmbEmpleados.SelectedValue), Convert.ToInt32(this.cmbTablasIndice.SelectedValue), this.cmbTablasIndice.Text ,Convert.ToDouble(this.txtValor.Text));
                acumulados.Insert(0, acumulado);

                this.dgvAcumulados.DataSource = null;
                this.dgvAcumulados.DataSource = this.acumulados;

                //formatea DGV
                this.dgvAcumulados.Columns["anioMes"].DisplayIndex = 0;
                this.dgvAcumulados.Columns["legajo"].DisplayIndex = 1;
                this.dgvAcumulados.Columns["codigo"].DisplayIndex = 2;
                this.dgvAcumulados.Columns["descripcion"].DisplayIndex = 3;
                this.dgvAcumulados.Columns["valor"].DisplayIndex = 4;
                Controles.setEstandarDataGridView(this.dgvAcumulados);

                //graba datos del registro
                Model.DB.ejecutarProceso(Model.TipoComando.SP, "acumuladosActualizar", "@anioMes", acumulado.AnioMes , "@indice", acumulado.Indice , "@legajo", acumulado.Legajo ,"@codigo", acumulado.Codigo, "@valor",acumulado.Valor);
            }
            else
                MessageBox.Show("Hay datos invalidos. Verifique !!");
            this.txtLegajo.Focus();

        }

    }
}