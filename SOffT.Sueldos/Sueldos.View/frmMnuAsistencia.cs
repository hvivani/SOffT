using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using Sofft.Utils;
using Sueldos.Entidades;
using Sueldos.Modelo;
using Reloj.Negocio;


namespace Sueldos.View
{
    public partial class frmMnuAsistencia : Sofft.ViewComunes.frmMenu 
    {
        private FichadasNegocio fichadasNegocio = new FichadasNegocio();

        Sofft.ViewComunes.Dialogos.frmRangoFechas frmRango;

        public frmMnuAsistencia()
        {
            InitializeComponent();
            this.creaBotones("ABM de Fichadas"
                           , "Consulta de Fichadas"
                           , "Captura de Fichadas"
                           , "Actualizar Fichadas"
                           , "Consulta de Ausencias"
                           , "Asistencia"
                           , "Impresión de Etiquetas"
                           , "Cálculo de Horas Extras"
                           , "Informe Horas Extras"
                           , "Impresión de Asistencia"
                           , "Gestión de Huellas Digitales"
                           , "Ausencias por Empleado"
                           , "Ausencias por Tipo"
                           , "Exportar Fichadas"
                           , "Fichadas por Reloj"
                           , "Llegadas Tarde"
                           );
            this.Text = "Reloj y Asistencia";
        }

        public void abrir()
        {
            this.ShowDialog();
        }

        public override void boton_Click(int indice)
        {
            //frmReportes visor;
            switch (indice)
            {
                case 0: //ABM de Fichadas
                    frmABMfichadas abmFichadas = new frmABMfichadas();
                    //this.pasaAsistencia();
                    break;
                case 1: //Consulta de Fichadas
                    frmRango = new Sofft.ViewComunes.Dialogos.frmRangoFechas();
                    if (frmRango.ShowDialog(this) == DialogResult.OK)
                    {
                      /*  Reportes.CRRelojFichadasEntreFechas crRel = new Sueldos.View.Reportes.CRRelojFichadasEntreFechas();
                        crRel.SetDataSource(Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteRelojConsultarFechas", "@desde", frmRango.FechaDesde, "@hasta", frmRango.FechaHasta));
                        EmpresaEntity emp = new ConsultaEmpresas().getEmpresa(1);
                        crRel.SetParameterValue(crRel.Parameter_empresa.ParameterFieldName, emp.RazonSocial);
                        crRel.SetParameterValue(crRel.Parameter_soft.ParameterFieldName, "SOffT " + Modulo.version);
                        frmRepo = new frmReportes();
                        frmRepo.abrir(crRel);*/
                        EmpresaEntity emp = new ConsultaEmpresas().getById(1);
                        DataSet ds=Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteRelojConsultarFechas", "@desde", frmRango.FechaDesde, "@hasta", frmRango.FechaHasta);
                        Sueldos.Reportes.CrystalReport.ReportesCreador.ConsultaDeFichadas(ds, emp.RazonSocial,Application.ProductVersion);
                    }
                    break;
                case 2: //Captura de Fichadas 
                    Reloj.View.frmReloj frmRel = new Reloj.View.frmReloj();
                    //frmReloj frmRel = new frmReloj();
                    frmRel.ShowDialog();
                    break;
                case 3: //Actualizar Fichadas
                    frmActualizarFichadas frmActF = new frmActualizarFichadas();
                    frmActF.ShowDialog();
                    break;

                case 4: //Consulta de Ausencias
                    frmRango = new Sofft.ViewComunes.Dialogos.frmRangoFechas();
                    if (frmRango.ShowDialog(this) == DialogResult.OK)
                    {
                        /*Reportes.CRAusencias crAus = new Sueldos.View.Reportes.CRAusencias();
                        crAus.SetDataSource(Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteAusencias", "@desde", frmRango.FechaDesde, "@hasta", frmRango.FechaHasta));
                        crAus.SetParameterValue(0, frmRango.FechaDesde);
                        crAus.SetParameterValue(1, frmRango.FechaHasta);
                        EmpresaEntity emp = new ConsultaEmpresas().getEmpresa(1);
                        crAus.SetParameterValue(crAus.Parameter_empresa.ParameterFieldName, emp.RazonSocial);
                        crAus.SetParameterValue(crAus.Parameter_soft.ParameterFieldName, "SOffT " + Modulo.version);
                        frmRepo = new frmReportes();
                        frmRepo.abrir(crAus);*/
                        EmpresaEntity emp = new ConsultaEmpresas().getById(1);
                        DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteAusencias", "@desde", frmRango.FechaDesde, "@hasta", frmRango.FechaHasta);
                        Sueldos.Reportes.CrystalReport.ReportesCreador.ConsultaDeAusencias(ds,frmRango.FechaDesde,frmRango.FechaHasta, emp.RazonSocial, Application.ProductVersion);
                    }
                    break;
                case 5: //Asistencia
                    frmAsistencia frmAs = new frmAsistencia();
                    frmAs.abrir();
                    break;
                case 6: //Impresión de Etiquetas
                    frmBarcode FrmBarcode = new frmBarcode();
                    //FrmBarcode.ShowDialog();
                    //MessageBox.Show("no implementado");
                    break;
                case 7: //Cálculo de Horas Extras
                    frmHorasExtras frmHH = new frmHorasExtras();
                    frmHH.ShowDialog();
                    break;
                case 8: //Informe Horas Extras
                    frmRango = new Sofft.ViewComunes.Dialogos.frmRangoFechas();
                    if (frmRango.ShowDialog(this) == DialogResult.OK)
                    {
                     /*   Reportes.CRHorasExtras crHoras = new Sueldos.View.Reportes.CRHorasExtras();
                        crHoras.SetDataSource(Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteRelojConsultarFechasHorasExtra", "@desde", frmRango.FechaDesde, "@hasta", frmRango.FechaHasta));
                        EmpresaEntity emp = new ConsultaEmpresas().getEmpresa(1);
                        crHoras.SetParameterValue(crHoras.Parameter_empresa.ParameterFieldName, emp.RazonSocial);
                        crHoras.SetParameterValue(crHoras.Parameter_soft.ParameterFieldName, "SOffT " + Modulo.version);
                        frmRepo = new frmReportes();
                        frmRepo.abrir(crHoras);*/
                        EmpresaEntity emp = new ConsultaEmpresas().getById(1);
                        DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteRelojConsultarFechasHorasExtra", "@desde", frmRango.FechaDesde, "@hasta", frmRango.FechaHasta);
                        Sueldos.Reportes.CrystalReport.ReportesCreador.InformeDeHorasExtra(ds, emp.RazonSocial,  Application.ProductVersion);
                    }
                    break;
                case 9:
                    Sofft.ViewComunes.Dialogos.frmSeleccionFecha fecha = new Sofft.ViewComunes.Dialogos.frmSeleccionFecha();
                    if (fecha.ShowDialog() == DialogResult.OK)
                    {
                       /* Reportes.CRTablaAsistencia reporte = new Reportes.CRTablaAsistencia();

                        reporte.SetDataSource(Model.DB.ejecutarDataSet(Model.TipoComando.SP, "asistenciaConsultarConNovedades", "fecha", fecha.Fecha.Year * 100 + fecha.Fecha.Month));
                        reporte.SetParameterValue(reporte.Parameter_anio.ParameterFieldName, fecha.Fecha.Year);
                        reporte.SetParameterValue(reporte.Parameter_mes.ParameterFieldName, fecha.Fecha.Month);
                        reporte.SetParameterValue(reporte.Parameter_Fecha.ParameterFieldName, fecha.Fecha);
                        visor = new frmReportes(reporte);
                        visor.ShowDialog(this); */
                        DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "asistenciaConsultarConNovedades", "fecha", fecha.Fecha.Year * 100 + fecha.Fecha.Month);
                        Sueldos.Reportes.CrystalReport.ReportesCreador.ImpresionDeAsistencia(ds, fecha.Fecha);
                    }
                    break;
                case 10: //Gestión de Huellas Digitales
                    Reloj.View.frmFingerPrintUtils  FrmFingerUtls  = new Reloj.View.frmFingerPrintUtils();
                    FrmFingerUtls.ShowDialog();
                    break;
                case 11: //Ausencias por Empleado
                    frmRango = new Sofft.ViewComunes.Dialogos.frmRangoFechas();
                    if (frmRango.ShowDialog(this) == DialogResult.OK)
                    {
                        EmpresaEntity emp = new ConsultaEmpresas().getById(1);
                        DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteAusenciasCantidad", "@desde", frmRango.FechaDesde, "@hasta", frmRango.FechaHasta);
                        Sueldos.Reportes.CrystalReport.ReportesCreador.ConsultaDeAusenciasPorEmpleado(ds, frmRango.FechaDesde, frmRango.FechaHasta, emp.RazonSocial, Application.ProductVersion);
                    }
                    break;
                case 12: //Ausencias por Tipo
                    frmRango = new Sofft.ViewComunes.Dialogos.frmRangoFechas();
                    if (frmRango.ShowDialog(this) == DialogResult.OK)
                    {
                        EmpresaEntity emp = new ConsultaEmpresas().getById(1);
                        DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteAusenciasCantidad", "@desde", frmRango.FechaDesde, "@hasta", frmRango.FechaHasta);
                        Sueldos.Reportes.CrystalReport.ReportesCreador.ConsultaDeAusenciasPorTipo(ds, frmRango.FechaDesde, frmRango.FechaHasta, emp.RazonSocial, Application.ProductVersion);
                    } break;
                case 13: //exportar fichadas
                    DataSet fichadas = null;
                    frmRango = new  Sofft.ViewComunes.Dialogos.frmRangoFechas();
                    if (frmRango.ShowDialog(this) == DialogResult.OK)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        //Cargo lista de fichadas            
                        fichadas = fichadasNegocio.getAll(frmRango.FechaDesde , frmRango.FechaHasta );
                        //Model.DataSetTo.CSV(fichadas, Model.Delimitador.PuntoComa);
                        Model.DataSetTo.XLS(fichadas, "Fichadas");
                        //Sofft.Utils.Excel.ExcelUtils.ExportToExcel(fichadas);
                        fichadas.Dispose();
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case 14: //Consulta de Fichadas Por Reloj
                    frmRango = new Sofft.ViewComunes.Dialogos.frmRangoFechas();
                    if (frmRango.ShowDialog(this) == DialogResult.OK)
                    {
                        /*  Reportes.CRRelojFichadasEntreFechas crRel = new Sueldos.View.Reportes.CRRelojFichadasEntreFechas();
                          crRel.SetDataSource(Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteRelojConsultarFechas", "@desde", frmRango.FechaDesde, "@hasta", frmRango.FechaHasta));
                          EmpresaEntity emp = new ConsultaEmpresas().getEmpresa(1);
                          crRel.SetParameterValue(crRel.Parameter_empresa.ParameterFieldName, emp.RazonSocial);
                          crRel.SetParameterValue(crRel.Parameter_soft.ParameterFieldName, "SOffT " + Modulo.version);
                          frmRepo = new frmReportes();
                          frmRepo.abrir(crRel);*/
                        EmpresaEntity emp = new ConsultaEmpresas().getById(1);
                        DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteRelojConsultarFechas", "@desde", frmRango.FechaDesde, "@hasta", frmRango.FechaHasta);
                        Sueldos.Reportes.CrystalReport.ReportesCreador.ConsultaDeFichadasPorReloj(ds, emp.RazonSocial, Application.ProductVersion);
                    }
                break;
                case 15: //Consulta de Llegadas tarde
                frmRango = new Sofft.ViewComunes.Dialogos.frmRangoFechas();
                if (frmRango.ShowDialog(this) == DialogResult.OK)
                {
                    /*  Reportes.CRRelojFichadasEntreFechas crRel = new Sueldos.View.Reportes.CRRelojFichadasEntreFechas();
                      crRel.SetDataSource(Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteRelojConsultarFechas", "@desde", frmRango.FechaDesde, "@hasta", frmRango.FechaHasta));
                      EmpresaEntity emp = new ConsultaEmpresas().getEmpresa(1);
                      crRel.SetParameterValue(crRel.Parameter_empresa.ParameterFieldName, emp.RazonSocial);
                      crRel.SetParameterValue(crRel.Parameter_soft.ParameterFieldName, "SOffT " + Modulo.version);
                      frmRepo = new frmReportes();
                      frmRepo.abrir(crRel);*/
                    EmpresaEntity emp = new ConsultaEmpresas().getById(1);
                    DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteRelojConsultarFechasLlegadasTarde", "@desde", frmRango.FechaDesde, "@hasta", frmRango.FechaHasta);
                    ds.Tables[0].TableName = "reporteRelojConsultarFechas";
                    Sueldos.Reportes.CrystalReport.ReportesCreador.ConsultaDeFichadas(ds, emp.RazonSocial, Application.ProductVersion);
                }
                break;
            }

        }

        private void pasaAsistencia()
        {
            DbDataReader rs = null;
            rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "asistenciaConsultarEstructuraVieja"/*, "@anio", 2008, "@mes",1*/);
            while (rs.Read())
            {
                if (Convert.ToInt32(rs["novman"]) == Convert.ToInt32(rs["novtar"]))
                    Model.DB.ejecutarProceso(Model.TipoComando.SP, "asistenciaActualizar", "@fecha", Convert.ToDateTime(rs["fecha"]).ToShortDateString(), "@legajo", rs["legajo"], "@codigo", rs["novman"], "@cantidad", 1, "@turno", 0);
                if (Convert.ToInt32(rs["novman"]) != Convert.ToInt32(rs["novtar"]))
                {
                    Model.DB.ejecutarProceso(Model.TipoComando.SP, "asistenciaActualizar", "@fecha", Convert.ToDateTime(rs["fecha"]).ToShortDateString(), "@legajo", rs["legajo"], "@codigo", rs["novman"], "@cantidad", 0.5, "@turno", 1);
                    Model.DB.ejecutarProceso(Model.TipoComando.SP, "asistenciaActualizar", "@fecha", Convert.ToDateTime(rs["fecha"]).ToShortDateString(), "@legajo", rs["legajo"], "@codigo", rs["novtar"], "@cantidad", 0.5, "@turno", 2);
                }
            }
            Model.DB.desconectarDB();
        }

    }
}

