using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using System.IO;
using Sofft.Utils;
using Sofft.ViewComunes;
using Sueldos.Modelo;

namespace Sueldos.View
{
    public partial class frmLiquidacionTabla : Form
    {
        /// <summary>
        /// Lleva localmente la liquidacion seleccionada
        /// </summary>
        private Liquidacion liqui;

        /// <summary>
        /// Lleva localmente el id de la tabla de calculo a utilizar
        /// </summary>
        private int idTabla;

        public frmLiquidacionTabla()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLiquidacionCargas_Load(object sender, EventArgs e)
        {

        }

        public void abrirParaCargasSociales(int idTabla)
        {
            this.idTabla = idTabla;
            this.cargarCombos();
            this.btnGenerarArchivo.Visible = true;
            this.btnGenerarArchivo.Enabled = false;
            this.ShowDialog();
        }
       
        public void abrirParaExportarExcel(int idTabla)
        {
            this.idTabla = idTabla;
            this.cargarCombos();
            this.btnGenerarArchivo.Visible = false;
            this.btnGenerarArchivo.Enabled = false;
            this.btnExportar.Visible = true;
            this.btnExportar.Enabled = false;
            this.ShowDialog();
        }

        public void abrirParaTabla(int idTabla)
        {
            this.idTabla = idTabla;
            this.cargarCombos();
            this.btnGenerarArchivo.Visible = false;
            this.btnGenerarArchivo.Enabled = false;
            this.ShowDialog();
        }

        private void btnLiquidar_Click(object sender, EventArgs e)
        {
            //esto no debería ir acá
            if (this.idTabla == 101)
                Model.DB.ejecutarProceso(Model.TipoComando.SP, "asientoDeSueldosEliminar", "@anioMes", liqui.AnioMes);

            int totalRegistros = 0;
            totalRegistros = (int)Model.DB.ejecutarScalar(Model.TipoComando.SP, "liquidacionesConsultarTotalLegajosParaCargas", "@anioMes", liqui.AnioMes);
            this.pbProceso.Minimum = 0;
            this.pbProceso.Maximum = totalRegistros;
            this.recorrerEmpleados(1);

            this.pbProceso.Value = totalRegistros;
            MessageBox.Show("El proceso finalizó con éxito.");
            this.btnGenerarArchivo.Enabled = true;
            this.btnExportar.Enabled = true;
        }

        private void recorrerEmpleados(int idTipoLiquidacion)
        {
            int cantRegistros = 0;

            DbDataReader rsLegajos;
            rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesConsultarLegajosParaCargas", "@anioMes", liqui.AnioMes);
            while (rsLegajos.Read())
            {
                cantRegistros++;
                this.pbProceso.Value = cantRegistros;
                Calculo.Legajo = Convert.ToInt32(rsLegajos["legajo"]);
                this.txtLegajo.Text = Calculo.Legajo.ToString();
                this.txtLegajo.Refresh();
                Calculo.sigueCalculo(this.idTabla, idTipoLiquidacion, false);

                System.Windows.Forms.Application.DoEvents();
            }
            Model.DB.desconectarDB();
        }


        private void cmbLiquidacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            liqui = null;
            liqui = new Liquidacion(Convert.ToInt32(this.cmbLiquidacion.SelectedValue));
            Calculo.IdLiquidacion = Convert.ToInt32(this.cmbLiquidacion.SelectedValue);
            Calculo.AnioMes = liqui.AnioMes;
            Calculo.IdAplicacion = liqui.IdAplicacion;

        }

        private void cargarCombos()
        {
            Controles.cargaComboBox(this.cmbLiquidacion, "descripcion", "id", "liquidacionesDetalleConsultarParaCargas");
        }

        private void btnGenerarArchivo_Click(object sender, EventArgs e)
        {
            int legajo = 0;
            int totalRegistros = 0;
            int cantRegistros = 0;
            string contenido = "";
            string registro = "";
            DbDataReader rsCampos;
            DbDataReader rsLegajos;

            totalRegistros = (int)Model.DB.ejecutarScalar(Model.TipoComando.SP, "liquidacionesConsultarTotalLegajosParaCargas", "@anioMes", liqui.AnioMes);
            this.pbProceso.Minimum = 0;
            this.pbProceso.Maximum = totalRegistros;

            this.saveFileDialogCargas.Filter = "Texto TXT (*.txt)|*.txt";
            this.saveFileDialogCargas.FileName = "SIJP";
            this.Refresh();

            if (saveFileDialogCargas.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(this.saveFileDialogCargas.FileName);
               
                rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "sijpConsultarLegajos", "@anioMes", liqui.AnioMes);
                while (rsLegajos.Read())  //para cada legajo recorro todos los campos definidos en tablas
                {
                    cantRegistros++;
                    if (cantRegistros<=pbProceso.Maximum)
                        this.pbProceso.Value = cantRegistros;

                    registro = "";
                    legajo = Convert.ToInt32(rsLegajos["legajo"]);
                    this.txtLegajo.Text = legajo.ToString();
                    this.txtLegajo.Refresh();

                    rsCampos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "tablasConsultarFormatosExportacion", "@tabla", "sijp");
                    while (rsCampos.Read())
                    {
                        //////campos explicitos para sijp//////
                        if (Convert.ToInt32(rsCampos["posicion"]) == 1)
                        {
                            contenido = CUIL.Limpiar(Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "@legajo", legajo, "@codigo", 18).ToString());
                        }
                        else
                        {
                            if (Convert.ToInt32(rsCampos["posicion"]) == 12)
                            {///elimino caracteres especiales en el nombre por problemas en importacion
                                contenido = Varios.Left(ConsultaEmpleados.consultarApellidoYnombresConBajas(legajo),30);
                                contenido = contenido.Replace('Ñ', 'N');
                                contenido = contenido.Replace('Á', 'A');
                                contenido = contenido.Replace('É', 'E');
                                contenido = contenido.Replace('Í', 'I');
                                contenido = contenido.Replace('Ó', 'O');
                                contenido = contenido.Replace('Ú', 'U');
                            }
                            else
                            {
                                contenido = Model.DB.ejecutarScalar(Model.TipoComando.SP, "sijpConsultarValorLegajo", "@anioMes", liqui.AnioMes, "legajo", legajo, "codigo", Convert.ToInt32(rsCampos["posicion"])).ToString();
                                //contenido = contenido.Replace('.', ',');
                            }
                        }

                        if (rsCampos["tipoCampo"].ToString()=="9")  //si es numerico completa con ceros.
                            registro = registro + contenido.PadLeft(Convert.ToInt32(rsCampos["longitud"]),'0');
                        else                                        //si es texto completa con espacios.
                            registro = registro + contenido.PadRight(Convert.ToInt32(rsCampos["longitud"]), ' ');
                    }
                    sw.WriteLine(registro);
                    Console.WriteLine(registro);

                    System.Windows.Forms.Application.DoEvents();
                }
                sw.Close();
                Model.DB.desconectarDB();

                this.pbProceso.Value = totalRegistros;
                MessageBox.Show("El archivo se generó con éxito.");
            }

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            DataSet dataset = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "cargasSocialesExcelExportar", "@anioMes", liqui.AnioMes, "@idCalculo", idTabla);
            dataset.DataSetName = "CargasSociales" + liqui.AnioMes.ToString();
            Model.DataSetTo.CSVPivot(dataset, Model.Delimitador.PuntoComa, 0, 1);
/*          CPEREYRA comentado el codigo de exportacion a excel para reemplazarlo con exportacion a CSV
            this.saveFileDialogCargas.Filter = "Planilla de Calculos (*.xls)|*.xls";
            this.saveFileDialogCargas.FileName = "CargasSociales";
            this.Refresh();

            if (saveFileDialogCargas.ShowDialog() == DialogResult.OK)
            {
                sueldos.exportarAexcel.exportarCeldaACeldaPivot(Model.DB.ejecutarDataSet(Model.TipoComando.SP, "cargasSocialesExcelExportar", "@anioMes", liqui.AnioMes, "@idCalculo", idTabla), this.saveFileDialogCargas.FileName, 0, 2, 1);
            }
*/          
        }
    }
}