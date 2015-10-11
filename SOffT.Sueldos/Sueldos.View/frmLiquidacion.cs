using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using Sofft.Utils;
using Sofft.ViewComunes;

namespace Sueldos.View
{
    public partial class frmLiquidacion : Form
    {
        //stringwriter para manejo de mensajes/salida console.writeln
        private System.IO.StringWriter sw = new System.IO.StringWriter();

        public frmLiquidacion()
        {
            InitializeComponent();
            this.txtLegajoDesde.GotFocus += new EventHandler(txtLegajoDesde_GotFocus);
            this.txtLegajoHasta.GotFocus += new EventHandler(txtLegajoHasta_GotFocus);
            this.txtLegajoDesde.KeyDown += new KeyEventHandler(txtLegajoDesde_KeyDown);
        }

        void txtLegajoHasta_GotFocus(object sender, EventArgs e)
        {
            this.txtLegajoHasta.SelectAll();
        }

        void txtLegajoDesde_GotFocus(object sender, EventArgs e)
        {
            this.txtLegajoDesde.SelectAll();
        }

        void txtLegajoDesde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtLegajoHasta.Focus();
        }

        /// <summary>
        /// Lleva localmente la liquidacion seleccionada
        /// </summary>
        private Liquidacion liqui;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLiquidacion_Load(object sender, EventArgs e)
        {
        }


        public void abrirParaSueldos()
        {
            this.cargarCombos();
           // this.cmbAnios.SelectedValue = System.DateTime.Now.Year;
           // this.cmbMeses.SelectedValue = System.DateTime.Now.Month;
            this.ShowDialog();
        }


        public void abrirParaCargasSociales()
        {
           // this.idTipoLiq = 5;
           // this.cargarCombos();
           // this.cmbAnios.SelectedValue = System.DateTime.Now.Year;
           // this.cmbMeses.SelectedValue = System.DateTime.Now.Month;
            this.ShowDialog();
        }
        
        private void btnRecibos_Click(object sender, EventArgs e)
        {
            frmRecibo frmc = new frmRecibo(Convert.ToInt32(this.cmbLiquidacion.SelectedValue),Convert.ToInt32(this.txtLegajoDesde.Text) );
            frmc.abrirParaConsultar();
        }

        private void btnLiquidar_Click(object sender, EventArgs e)
        {
            ////consola a variable            
            Console.SetOut(sw);
            ////

            int totalRegistros;
            //Considero el aguinaldo como tipo de liquidacion para bajas.  
            int hayTipoBajas=0;         //seteo en 1 si verifico que se liquida aguinaldo. 
            int hayBajasLegajos = 0;    

            this.inicializaControles();
            this.txtHoraInicio.Text = System.DateTime.Now.ToLongTimeString();
            this.txtHoraInicio.Refresh();

            //revisar, debe calcular el total a liquidar en base a los filtros.
            totalRegistros = (int)Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosConsultarTotalALiquidar", "@legajoDesde", Convert.ToInt32(this.txtLegajoDesde.Text), "legajoHasta", Convert.ToInt32(this.txtLegajoHasta.Text), "idTipoSalario", Convert.ToInt32(this.cmbTipoSalario.SelectedValue));
            this.pbProceso.Minimum = 0;
            this.pbProceso.Maximum = totalRegistros;

            //si hay liquidaciones con recibos separados
            DbDataReader rsLiquidaciones;
            if (liqui.RecibosSeparados)
            {
                rsLiquidaciones = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesPorTipoConsultar", "@idLiquidacion", liqui.Id);
                while (rsLiquidaciones.Read())
                {
                    if (Convert.ToInt32(rsLiquidaciones["idTipoLiquidacion"]) == 4) //aguinaldo
                        hayTipoBajas = 1;
                    this.recorrerEmpleados(Convert.ToInt32(rsLiquidaciones["idTipoLiquidacion"]));
                }
                //si hay legajos con fecha de baja y no se especificó liquidación de aguinaldo,
                //se liquida y separa explicitamente.
                hayBajasLegajos = (int)Model.DB.ejecutarScalar(Model.TipoComando.SP, "periodosTrabajadosConsultaBajas", "@idLiquidacion", liqui.Id);
                if (hayTipoBajas == 0 && hayBajasLegajos > 0) /////////////////////////
                {
                    this.recorrerEmpleados(4);
                    Model.DB.ejecutarProceso(Model.TipoComando.SP, "liquidacionesPorTipoActualizar", "@idLiquidacion", Convert.ToInt32(this.cmbLiquidacion.SelectedValue), "@idTipoLiquidacion", 4);
                }
            }
            else //si todo va en el mismo recibo es de tipo 'normal'
                this.recorrerEmpleados(1);    


            this.pbProceso.Value = totalRegistros;
            Model.DB.desconectarDB();
            this.txtHoraFin.Text = System.DateTime.Now.ToLongTimeString();
            this.txtHoraFin.Refresh();
            this.txtDuracion.Text = Convert.ToString(Convert.ToDateTime(this.txtHoraFin.Text) - Convert.ToDateTime(this.txtHoraInicio.Text));

        }


        private void recorrerEmpleados(int idTipoLiquidacion)
        {
            int existeLegajo;
            int cantRegistros = 0;

            DbDataReader rsLegajos;
            rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "empleadosConsultarParaLiquidar", "@legajoDesde", Convert.ToInt32(this.txtLegajoDesde.Text), "@legajoHasta", Convert.ToInt32(this.txtLegajoHasta.Text),"idTiposalario",Convert.ToInt32(this.cmbTipoSalario.SelectedValue));
            while (rsLegajos.Read())
            {
                cantRegistros++;
                this.pbProceso.Value = cantRegistros;
                Calculo.Legajo = Convert.ToInt32(rsLegajos["legajo"]);
                Console.WriteLine("Liquidando Legajo: " + Calculo.Legajo + " idTipoLiquidacion: " + idTipoLiquidacion);
                this.txtLegajoActual.Text = Calculo.Legajo.ToString();
                this.txtLegajoActual.Refresh();
                existeLegajo = (int)Model.DB.ejecutarScalar(Model.TipoComando.SP, "liquidacionesConsultarSiExiste", "idLiquidacion", liqui.Id , "idTipoLiquidacion", idTipoLiquidacion, "legajo", Calculo.Legajo);
                if (existeLegajo > 0)
                {
                    if (chkBoxReliquidarTodos.Checked == false)
                    {
                        DialogResult result = MessageBox.Show("Ya existe una liquidación para el legajo " + Calculo.Legajo + ". Reliquida?", "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Model.DB.ejecutarProceso(Model.TipoComando.SP, "liquidacionesEliminar", "idLiquidacion", liqui.Id, "@legajo", Calculo.Legajo);
                            Console.WriteLine("Se elimina Liquidación Legajo: " + Calculo.Legajo + " idTipoLiquidacion: " + idTipoLiquidacion);
                            Calculo.sigueCalculo(Convert.ToInt32(rsLegajos["idConvenio"]), idTipoLiquidacion, liqui.RecibosSeparados);
                        }
                        else
                            MessageBox.Show("No se liquidará el legajo " + Calculo.Legajo);
                    }
                    else
                    {
                        Model.DB.ejecutarProceso(Model.TipoComando.SP, "liquidacionesEliminar", "idLiquidacion", liqui.Id, "@legajo", Calculo.Legajo);
                        Console.WriteLine("Se elimina Liquidación Legajo: " + Calculo.Legajo + " idTipoLiquidacion: " + idTipoLiquidacion);
                        Calculo.sigueCalculo(Convert.ToInt32(rsLegajos["idConvenio"]), idTipoLiquidacion, liqui.RecibosSeparados);
                    }
                }else
                    Calculo.sigueCalculo(Convert.ToInt32(rsLegajos["idConvenio"]),idTipoLiquidacion, liqui.RecibosSeparados );

                System.Windows.Forms.Application.DoEvents();
            }
        }




        private void txtLegajoDesde_TextChanged(object sender, EventArgs e)
        {
            this.inicializaControles();
        }

        private void txtLegajoHasta_TextChanged(object sender, EventArgs e)
        {
            this.inicializaControles();
        }

        private void cmbTipoLiquidacion_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void inicializaControles()
        {
            this.pbProceso.Value = 0;
            this.txtHoraInicio.Text = "";
            this.txtHoraInicio.Refresh();
            this.txtHoraFin.Text = "";
            this.txtHoraFin.Refresh();
            this.txtDuracion.Text = "";
            this.txtDuracion.Refresh();
            this.txtLegajoActual.Text = "";
            this.txtLegajoActual.Refresh();
        }

        private void cmbAnios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculo.AnioMes = Convert.ToInt32(Varios.anioMes(Convert.ToInt32(this.cmbAnios.SelectedValue), Convert.ToByte(this.cmbMeses.SelectedValue)));
        }

        private void cmbMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculo.AnioMes = Convert.ToInt32(Varios.anioMes(Convert.ToInt32(this.cmbAnios.SelectedValue), Convert.ToByte(this.cmbMeses.SelectedValue)));
        }

        private void cargarCombos()
        {
            Controles.cargaComboBox(this.cmbAnios, "contenido", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "calendario", "indice", 1);
            Controles.cargaComboBox(this.cmbMeses, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "calendario", "indice", 2);
            //Controles.cargaComboBox(this.cmbTipoLiquidacion, "descripcion", "indice", "tablasConsultar", "@nombre", "tiposDeLiquidacion");
            Controles.cargaComboBox(this.cmbAplicacion, "descripcion", "indice", "tablasConsultarAplicacionParaLiquidar");
            Controles.cargaComboBox(this.cmbTipoSalario, "descripcion", "indice", "tablasConsultar", "@nombre", "tiposDeSalario");
            Controles.cargaComboBox(this.cmbLiquidacion, "descripcion", "id", "liquidacionesDetalleConsultarParaLiquidar");
        }

        private void cmbAplicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculo.IdAplicacion = Convert.ToInt32(this.cmbAplicacion.SelectedValue);

        }

        private void gbLiquidacion_Enter(object sender, EventArgs e)
        {

        }

        private void cmbTipoSalario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLiquidacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            liqui = null;
            liqui = new Liquidacion(Convert.ToInt32(this.cmbLiquidacion.SelectedValue));
            Calculo.IdLiquidacion = Convert.ToInt32(this.cmbLiquidacion.SelectedValue );
            this.mostrarDatosEnForm();
        }



        private void mostrarDatosEnForm()
        {
            this.cmbAnios.SelectedValue = Varios.Left(liqui.AnioMes.ToString(), 4);
            this.cmbMeses.SelectedValue = Varios.Right(liqui.AnioMes.ToString(), 2);
    //        this.cmbTipoLiquidacion.SelectedValue = liqui.IdTipoLiquidacion;
            this.cmbAplicacion.SelectedValue = liqui.IdAplicacion;
            this.cmbTipoSalario.SelectedValue = liqui.IdTipoSalario;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void btnLiquidarCargas_Click(object sender, EventArgs e)
        {

        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            frmDebug FrmDebug = new frmDebug(this.sw.ToString());
        }
    }
}