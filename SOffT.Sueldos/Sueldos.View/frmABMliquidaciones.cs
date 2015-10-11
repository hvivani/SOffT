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
using Sueldos.Modelo;

namespace Sueldos.View
{
    public partial class frmABMliquidaciones : Sofft.ViewComunes.frmABM 
    {
        private ConsultaLiquidacionDetalle consuliqdet = new ConsultaLiquidacionDetalle();
        private ConsultaTablas consutab = new ConsultaTablas();

        public frmABMliquidaciones()
        {
            InitializeComponent();

            this.creaBotones();
            this.Text = "ABM de Liquidaciones";
            this.cargaGrilla(consuliqdet.getAllGrilla());
            this.ocultarColumna(1);
            this.ocultarColumna(3);
            this.ocultarColumna(5);
            this.creaBusquedas(2);

            ComboBox cbEstado = new ComboBox();
            Controles.cargaComboBox(cbEstado , "detalle", "contenido", consutab.getContenidoYdetalle("liquidacionesDetalle", 0));            
            this.creaFiltros(cbEstado);
            this.nombrarFiltros(15);
        }

        protected override void Consultar()
        {
            frmDatosLiquidacion frmlm = new frmDatosLiquidacion();
            frmlm.abrirParaConsultar(Convert.ToInt32(this.consultaCampoRenglon(0)));
        }

        protected override void Modificar(object sender, EventArgs e)
        {
            frmDatosLiquidacion frmlm = new frmDatosLiquidacion();
            frmlm.abrirParaModificar(Convert.ToInt32(this.consultaCampoRenglon(0)));
            this.refrescaGrilla();
        }

        protected override void Nuevo(object sender, EventArgs e)
        {
            frmDatosLiquidacion frml = new frmDatosLiquidacion();
            frml.abrirParaAgregar();
            this.refrescaGrilla();
        }

        protected override void Eliminar(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro de eliminar la liquidación? \n" + this.consultaCampoRenglon(2) + " ?", "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LiquidacionDetalleEntity liqdet=new LiquidacionDetalleEntity(Convert.ToInt32(this.consultaCampoRenglon(0)));
                consuliqdet.delete(liqdet);
                MessageBox.Show("la liquidación se elimino con éxito");
                this.refrescaGrilla();
            }
        }

        private void frmABMliquidaciones_Load(object sender, EventArgs e)
        {
            this.aplicarFiltros(sender, e);
        }

        private void refrescaGrilla()
        {
            this.cargaGrilla(consuliqdet.getAllGrilla());
            this.aplicarFiltros(null, null);
        }

    }
}

