using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using Sofft.ViewComunes;

namespace Sueldos.View
{
    public partial class frmRenglonRecibo : Form
    {
        public frmRenglonRecibo()
        {            InitializeComponent();        }

        private ReciboRenglon renglon;

        public void Nuevo(int idLiquidacion, int idTipoLiquidacion, int legajo)
        {
            Controles.cargaComboBox(this.cmbConceptos, "", "", "calculoConsultarParaCombo", "idCalculo", 1, "idTipoLiquidacion", idTipoLiquidacion);
            renglon = new ReciboRenglon();
            renglon.IdLiquidacion = idLiquidacion;
            renglon.IdTipoLiquidacion = idTipoLiquidacion;
            renglon.Legajo = legajo;
        }

        public void Modificar(int idLiquidacion, int idTipoLiquidacion, int legajo, int codigo)
        {
            Controles.cargaComboBox(this.cmbConceptos, "Descripcion", "Codigo", "calculoConsultarParaCombo", "idCalculo", 1, "idTipoLiquidacion", idTipoLiquidacion);
            cmbConceptos.Enabled = false;

            renglon = new ReciboRenglon();
            renglon.IdLiquidacion = idLiquidacion;
            renglon.IdTipoLiquidacion = idTipoLiquidacion;
            renglon.Legajo = legajo;
            renglon.Codigo = codigo;

            renglon.CargarDatos();

            this.txtVU.Text = renglon.VU.ToString();
            this.txtCantidad.Text = renglon.Cantidad.ToString();
            this.txtImporte.Text = renglon.Importe.ToString();
            this.cmbConceptos.SelectedValue = codigo;

            this.ShowDialog();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            renglon.Actualizar();
            MessageBox.Show("El concepto se actualizo con exito");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        { this.Close(); }

        private void txtVU_TextChanged(object sender, EventArgs e)
        { renglon.VU = Convert.ToDouble(txtVU.Text); }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        { renglon.Cantidad = Convert.ToDouble(txtCantidad.Text); }

        private void txtImporte_TextChanged(object sender, EventArgs e)
        { renglon.Importe = Convert.ToDouble(txtImporte.Text); }

        private void cmbConceptos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.renglon.Codigo = Convert.ToInt32(this.cmbConceptos.SelectedValue);
        }
    }
}