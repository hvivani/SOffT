using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sofft.Utils;
using Sofft.ViewComunes;

namespace Sueldos.View
{
    public partial class frmABMConceptos : Form
    {

        private Concepto concepto = null;

        public frmABMConceptos()
        {
            InitializeComponent();
            this.dgvCalculo.Click += new EventHandler(dgvCalculo_Click);
            this.dgvCalculo.KeyDown += new KeyEventHandler(dgvCalculo_KeyDown);
        }

        void dgvCalculo_KeyDown(object sender, KeyEventArgs e)
        {
            this.cargaConcepto();
        }

        void dgvCalculo_Click(object sender, EventArgs e)
        {
            this.cargaConcepto();
        }





        private void mostrarDatosEnForm()
        {
            this.txtCodigo.Text = concepto.Codigo.ToString();
            this.txtOrdPro.Text = concepto.OrdenDeProceso.ToString();
            this.txtDescripcion.Text = concepto.Descripcion.ToString();
            this.cmbTipo.SelectedValue = concepto.Tipo;
            this.chkImprime.Checked = concepto.Imprime;
            this.chkImprimeCantidad.Checked = concepto.ImprimeCantidad;
            this.chkImprimeValorUnitario.Checked = concepto.ImprimeValorUnitario;
            this.chkDesactivado.Checked = concepto.Desactivado;
            this.txtFormula.Text = concepto.Formula;
            this.cmbTipoLiquidacion.SelectedValue = concepto.IdTipoLiquidacion;
            this.cmbAplicacion.SelectedValue = concepto.IdAplicacion;
            this.cmbCuentaContable.SelectedValue = concepto.IdCuentaContable;
        }

        private void chkImprimeValorUnitario_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void abrirParaSueldos()
        {
            this.Text = "ABM de Conceptos";
            this.cargarCombos();
            Controles.cargaComboBox(this.cmbTablas, "descripcion", "indice", "tablasConsultarParaSueldos", "@nombre", "Calculo");
            this.ShowDialog();
        }

        public void abrirParaIndice(int indice)
        {
            this.Text = "Edición de Formulas";
            this.cargarCombos();
            Controles.cargaComboBox(this.cmbTablas, "descripcion", "indice", "tablasConsultarPorIndice", "@nombre", "Calculo", "@indice", indice);
            this.ShowDialog();
        }

        public void abrirParaAsientosDeSueldos()
        {
            this.Text = "Formulas para Asientos de Sueldos";
            this.cargarCombos();
            Controles.cargaComboBox(this.cmbTablas, "descripcion", "indice", "tablasConsultarParaAsientos", "@nombre", "Calculo");
            this.ShowDialog();
        }


        private void dgvCalculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargaConcepto()
        {
            concepto = null;
            concepto = new Concepto(Convert.ToInt32(Controles.consultaCampoRenglon(this.dgvCalculo, 0)), Convert.ToInt32(this.cmbTablas.SelectedValue.ToString()));
            concepto.cargarDatosConcepto();
            this.mostrarDatosEnForm();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.accionModificar();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.accionCancelar();
            this.limpiaCampos();
            this.actualizaGrillaFormulas();
        }

        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.actualizaGrillaFormulas();
        }

        private void frmABMConceptos_Load(object sender, EventArgs e)
        {
            this.accionCancelar();           
        }

        private void cargarCombos()
        {
            Controles.cargaComboBox(this.cmbTipo, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "Varios", "indice", 50);
            Controles.cargaComboBox(this.cmbTipoLiquidacion, "descripcion", "indice", "tablasConsultar", "@nombre", "tiposDeLiquidacion");
            Controles.cargaComboBox(this.cmbAplicacion, "descripcion", "indice", "tablasConsultar", "@nombre", "aplicacionLiquida");
            Controles.cargaComboBox(this.cmbCuentaContable, "descripcion", "indice", "tablasConsultar", "@nombre", "CuentasContables");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.accionAgregar();
        }


        private void actualizaGrillaFormulas()
        {
            if (this.cmbTablas.SelectedValue != null)
            {
                Controles.cargaDataGridView(this.dgvCalculo, "calculoConsultarParaGrilla", "@idCalculo", this.cmbTablas.SelectedValue);
                Controles.setEstandarDataGridView(this.dgvCalculo);
            }
            else
                this.dgvCalculo.DataSource= "";

        }

        public virtual void accionAgregar()
        {
            this.cmbTablas.Enabled = false;
            this.txtOrdPro.Enabled = true;
            this.txtCodigo.Enabled = true;
            this.txtDescripcion.Enabled = true;
            this.gbFormula.Enabled = true;
            this.gbPropiedades.Enabled = true;

            this.btnAgregar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnGrabar.Enabled = true;
            this.btnCancelar.Enabled = true;
            this.btnModificar.Enabled = true;
            this.btnCerrar.Enabled = false;

            this.txtOrdPro.Focus();
        }


        public virtual void accionCancelar()
        {
            this.cmbTablas.Enabled = true;
            this.txtOrdPro.Enabled = false;
            this.txtCodigo.Enabled = false;
            this.txtDescripcion.Enabled = false ;
            this.gbPropiedades.Enabled = false;
            this.gbFormula.Enabled = false;

            this.btnAgregar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnGrabar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.btnModificar.Enabled = true;
            this.btnCerrar.Enabled = true;
        }


        public virtual void accionModificar()
        {
            this.cmbTablas.Enabled = false;
            this.txtOrdPro.Enabled = false;
            this.txtCodigo.Enabled = false;
            this.txtDescripcion.Enabled = true;
            this.gbPropiedades.Enabled = true;
            this.gbFormula.Enabled = true;

            this.btnAgregar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnGrabar.Enabled = true;
            this.btnCancelar.Enabled = true;
            this.btnModificar.Enabled = false;
            this.btnCerrar.Enabled = false;
        }

        private void limpiaCampos()
        {
            this.txtOrdPro.Text = "0";
            this.txtCodigo.Text = "0";
            this.txtDescripcion.Text = "";
            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (this.datosValidos())
            {
                Model.DB.ejecutarProceso(Model.TipoComando.SP, "calculoActualizar", "@idCalculo", Convert.ToInt32(this.cmbTablas.SelectedValue), "@ordenProceso", Convert.ToInt32(this.txtOrdPro.Text), "@codigo", Convert.ToInt32(this.txtCodigo.Text), "@descripcion", this.txtDescripcion.Text, "@formula", this.txtFormula.Text, "@tipo", Convert.ToInt32(this.cmbTipo.SelectedValue), "@imprime", this.chkImprime.Checked, "@imprimeCantidad", this.chkImprimeCantidad.Checked, "@imprimeVU", this.chkImprimeValorUnitario.Checked, "@desactivado", this.chkDesactivado.Checked, "idTipoLiquidacion", Convert.ToInt32(this.cmbTipoLiquidacion.SelectedValue), "idAplicacion", Convert.ToInt32(this.cmbAplicacion.SelectedValue), "idCuentaContable", Convert.ToInt32(this.cmbCuentaContable.SelectedValue));
                this.btnCancelar_Click(sender, e);
            }
        }



        private bool datosValidos()
        {
            Boolean ok = true;
            if (!Varios.IsNumeric(this.txtCodigo.Text) || Convert.ToInt32(this.txtCodigo.Text) < 0)
            {
                MessageBox.Show("Debe ingresar un Codigo valido");
                ok = false;
                this.txtCodigo.Focus();
            }
            else
            {
                if (this.txtDescripcion.Text.Length == 0)
                {
                    MessageBox.Show("Debe ingresar una descripcion valida");
                    ok = false;
                    this.txtDescripcion.Focus();
                }
                else
                {
                    if (!Varios.IsNumeric(this.txtOrdPro.Text) || Convert.ToInt32(this.txtOrdPro.Text) < 0)
                    {
                        MessageBox.Show("Debe ingresar un Orden de Proceso valido");
                        ok = false;
                        this.txtOrdPro.Focus();
                    }
                }
            }
            return ok;
        }

        private void gbFormula_Enter(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Varios.confirmaEliminarRegistro())
            {
                Model.DB.ejecutarProceso(Model.TipoComando.SP, "calculoEliminar", "@idCalculo", Convert.ToInt32(this.cmbTablas.SelectedValue), "@ordenProceso", Convert.ToInt32(this.txtOrdPro.Text), "@codigo", Convert.ToInt32(this.txtCodigo.Text));
                MessageBox.Show("el registro se elimino con éxito");
                this.btnCancelar_Click(sender, e);
            }
        }

        private void txtFormula_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoLiquidacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Controles.cargaComboBox(this.cmbTablas, "descripcion", "indice", "calculoConsultarTablasPorTipoLiquidacion", "@idTipoLiquidacion", this.cmbTipoLiquidacion.SelectedValue);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkImprimeCantidad_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbAplicacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdicionFomula_Click(object sender, EventArgs e)
        {
            frmEdicionConcepto frmec = new frmEdicionConcepto(Convert.ToInt32(this.cmbTablas.SelectedValue));
            frmec.ShowDialog();
            txtFormula.Text = frmec.FormulaCompilador;
        }

        private void btnConsultarTablas_Click(object sender, EventArgs e)
        {
            frmABMTablas FrmABMTablas = new frmABMTablas();
            //FrmABMTablas.abrirParaConsultar();
        }

        private void cmbCuentaContable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}