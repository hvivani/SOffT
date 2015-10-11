using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sueldos.View
{
    public partial class frmMnuCargasSociales : Sofft.ViewComunes.frmMenu 
    {
        public frmMnuCargasSociales()
        {
            InitializeComponent();
            this.creaBotones("Formulas Cargas Sociales", "Liquidar Cargas Sociales", "Importar Datos SIJP", "Formulas Excel Cargas", "Excel Cargas", "Fondo de Desempleo (txt)", "Fondo de Desempleo (XLS)", "DDJJ UOCRA");
            this.Text = "Cargas Sociales";
        }

        public void abrir()
        {
            this.ShowDialog();
        }


        public override void boton_Click(int indice)
        {
            switch (indice)
            {
                case 0: //Formulas Cargas Sociales
                    frmABMConceptos frmFormulasCargas = new frmABMConceptos();
                    frmFormulasCargas.abrirParaIndice(100);
                    break;
                case 1: //Liquidar Cargas Sociales
                    frmLiquidacionTabla frmLiqui = new frmLiquidacionTabla();
                    frmLiqui.abrirParaCargasSociales(100);
                    break;
                case 2: //Importar Datos SIJP
                    frmImportarSIJP frmImporta = new frmImportarSIJP();
                    frmImporta.ShowDialog();
                    break;
                case 3: //Formulas Excel Cargas Cargas 
                    frmABMConceptos frmFormulasExcel = new frmABMConceptos();
                    frmFormulasExcel.abrirParaIndice(102);
                    break;
                case 4: //Liquidar Excel Cargas
                    frmLiquidacionTabla frmExcelCargas = new frmLiquidacionTabla();
                    frmExcelCargas.abrirParaExportarExcel(102);
                    break;
                case 5: //Fondo Desempleo (txt)
                    Dialogos.frmSeleccionAnioMes frmSeleccion = new Sueldos.View.Dialogos.frmSeleccionAnioMes();
                    if (frmSeleccion.ShowDialog() == DialogResult.OK)
                    {
                        //*****************//
                        this.saveFileDialogFondoDesempleo.Filter = "Texto TXT (*.txt)|*.txt";
                        this.saveFileDialogFondoDesempleo.FileName = "ACREFD.TXT";
                        if (saveFileDialogFondoDesempleo.ShowDialog() == DialogResult.OK)
                        {
                            FondoDesempleo.generaArchivo(frmSeleccion.AnioMes, saveFileDialogFondoDesempleo.FileName);
                            //DataSet resultado = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteNetoPorLegajoAreaConvenioAnioMes", "anioMes", frmFecha.AnioMes);
                            //resultado.DataSetName = "reporteNetoPorLegajoAreaConvenioAnioMes";
                            //Model.DataSetTo.CSV(resultado, Model.Delimitador.PuntoComa);
                            //resultado.Dispose();
                            MessageBox.Show("El archivo se generó correctamente.");
                        }
                    }
                    break;
                case 6:
                    Dialogos.frmSeleccionAnioMes frmFecha = new Sueldos.View.Dialogos.frmSeleccionAnioMes();
                    if (frmFecha.ShowDialog() == DialogResult.OK)
                    {
                        DataSet resultado = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "fondoDesempleoConsultar", "anioMes", frmFecha.AnioMes);
                        resultado.DataSetName = "fondoDesempleoConsultar";
                        Model.DataSetTo.CSV(resultado, Model.Delimitador.PuntoComa);
                        resultado.Dispose();
                    }
                    break;
                case 7: //DDJJ UOCRA
                    Dialogos.frmSeleccionAnioMes frmSeleccion1 = new Sueldos.View.Dialogos.frmSeleccionAnioMes();
                    if (frmSeleccion1.ShowDialog() == DialogResult.OK)
                    {
                        //*****************//
                        this.saveFileDialogFondoDesempleo.Filter = "Texto UOC (*.UOC)|*.UOC";
                        this.saveFileDialogFondoDesempleo.FileName = "DDJJUOCRA.UOC";
                        if (saveFileDialogFondoDesempleo.ShowDialog() == DialogResult.OK)
                        {
                            DDJJUOCRA.generaArchivo(frmSeleccion1.AnioMes, saveFileDialogFondoDesempleo.FileName);
                            //DataSet resultado = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteNetoPorLegajoAreaConvenioAnioMes", "anioMes", frmFecha.AnioMes);
                            //resultado.DataSetName = "reporteNetoPorLegajoAreaConvenioAnioMes";
                            //Model.DataSetTo.CSV(resultado, Model.Delimitador.PuntoComa);
                            //resultado.Dispose();
                            MessageBox.Show("El archivo se generó correctamente.");
                        }
                    }
                    break;
            }
        }
    }
}

