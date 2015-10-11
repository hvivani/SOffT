/*  
    ReportesCreador.cs

    Author:
    Hernan Vivani <hernan@vivani.com.ar> - http://hvivani.com.ar

    Copyright © SOffT 2010 - http://www.sofft.com.ar

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Data;


namespace Sueldos.Reportes.CrystalReport
{
    public class ReportesCreador
    {
        #region Asistencia
        
        public static void ConsultaDeFichadas(DataSet fuente, String empresa, String version)
        {
            FrmReportes frmRepo = new FrmReportes();
            CRRelojFichadasEntreFechas crRel = new CRRelojFichadasEntreFechas();
            crRel.SetDataSource(fuente);
            crRel.SetParameterValue(crRel.Parameter_empresa.ParameterFieldName, empresa);
            crRel.SetParameterValue(crRel.Parameter_soft.ParameterFieldName, "SOffT " + version);
            frmRepo = new FrmReportes();
            frmRepo.abrir(crRel);
        }

        public static void ConsultaDeFichadasPorReloj(DataSet fuente, String empresa, String version)
        {
            FrmReportes frmRepo = new FrmReportes();
            CRRelojFichadasPorRelojEntreFechas crRel = new CRRelojFichadasPorRelojEntreFechas();
            crRel.SetDataSource(fuente);
            crRel.SetParameterValue(crRel.Parameter_empresa.ParameterFieldName, empresa);
            crRel.SetParameterValue(crRel.Parameter_soft.ParameterFieldName, "SOffT " + version);
            frmRepo = new FrmReportes();
            frmRepo.abrir(crRel);
        }

        public static void ConsultaDeAusencias(DataSet fuente, DateTime fechaDesde, DateTime fechaHasta, String empresa, String version)
        {
            CRAusencias crAus = new CRAusencias();
            crAus.SetDataSource(fuente);
            crAus.SetParameterValue(0, fechaDesde);
            crAus.SetParameterValue(1, fechaHasta);
            crAus.SetParameterValue(crAus.Parameter_empresa.ParameterFieldName, empresa);
            crAus.SetParameterValue(crAus.Parameter_soft.ParameterFieldName, "SOffT " + version);
            FrmReportes frmRepo = new FrmReportes();
            frmRepo.abrir(crAus);
        }

        public static void ConsultaDeAusenciasPorEmpleado(DataSet fuente, DateTime fechaDesde, DateTime fechaHasta, String empresa, String version)
        {
            CRAusenciasPorEmpleado crAusenciasPorEmpleado = new CRAusenciasPorEmpleado();
            crAusenciasPorEmpleado.SetDataSource(fuente);
            crAusenciasPorEmpleado.SetParameterValue(0, fechaDesde);
            crAusenciasPorEmpleado.SetParameterValue(1, fechaHasta);
            crAusenciasPorEmpleado.SetParameterValue(crAusenciasPorEmpleado.Parameter_empresa.ParameterFieldName, empresa);
            crAusenciasPorEmpleado.SetParameterValue(crAusenciasPorEmpleado.Parameter_soft.ParameterFieldName, "SOffT " + version);
            FrmReportes frmRepo = new FrmReportes();
            frmRepo.abrir(crAusenciasPorEmpleado);
        }

        public static void ConsultaDeAusenciasPorTipo(DataSet fuente, DateTime fechaDesde, DateTime fechaHasta, String empresa, String version)
        {
            CRAusenciasPorTipo crAusenciasPorTipo = new CRAusenciasPorTipo();
            crAusenciasPorTipo.SetDataSource(fuente);
            crAusenciasPorTipo.SetParameterValue(0, fechaDesde);
            crAusenciasPorTipo.SetParameterValue(1, fechaHasta);
            crAusenciasPorTipo.SetParameterValue(crAusenciasPorTipo.Parameter_empresa.ParameterFieldName, empresa);
            crAusenciasPorTipo.SetParameterValue(crAusenciasPorTipo.Parameter_soft.ParameterFieldName, "SOffT " + version);
            FrmReportes frmRepo = new FrmReportes();
            frmRepo.abrir(crAusenciasPorTipo);
        }


        public static void InformeDeHorasExtra(DataSet fuente, String empresa, String version)
        {
            CRHorasExtras crHoras = new CRHorasExtras();
            crHoras.SetDataSource(fuente);
            crHoras.SetParameterValue(crHoras.Parameter_empresa.ParameterFieldName, empresa);
            crHoras.SetParameterValue(crHoras.Parameter_soft.ParameterFieldName, "SOffT " + version);
            FrmReportes frmRepo = new FrmReportes();
            frmRepo.abrir(crHoras);
        }

        public static void ImpresionDeAsistencia(DataSet fuente, DateTime fecha)
        {
            CRTablaAsistencia reporte = new CRTablaAsistencia();
            reporte.SetDataSource(fuente);
            reporte.SetParameterValue(reporte.Parameter_anio.ParameterFieldName, fecha.Year);
            reporte.SetParameterValue(reporte.Parameter_mes.ParameterFieldName, fecha.Month);
            reporte.SetParameterValue(reporte.Parameter_Fecha.ParameterFieldName, fecha);
            FrmReportes visor = new FrmReportes(reporte);
            visor.ShowDialog();
        }

        #endregion

        #region Liquidaciones
        public static void BorradorDeLiquidacion(DataSet fuente, String titulo, String empresa, String cuit, String domicilio, String actividad)
        {
            CRLiquidacionesParaRecibosBorrador reporteLiquidacionesBorrador = new CRLiquidacionesParaRecibosBorrador();
            reporteLiquidacionesBorrador.SetDataSource(fuente);
            reporteLiquidacionesBorrador.SetParameterValue(reporteLiquidacionesBorrador.Parameter_Titulo.ParameterFieldName, titulo);
            reporteLiquidacionesBorrador.SetParameterValue(reporteLiquidacionesBorrador.Parameter_Definitivo.ParameterFieldName, false);
            reporteLiquidacionesBorrador.SetParameterValue(reporteLiquidacionesBorrador.Parameter_AgrupadoPorConvenio.ParameterFieldName, false);
            reporteLiquidacionesBorrador.SetParameterValue(reporteLiquidacionesBorrador.Parameter_empresa.ParameterFieldName, empresa);
            reporteLiquidacionesBorrador.SetParameterValue(reporteLiquidacionesBorrador.Parameter_cuit.ParameterFieldName, cuit);
            reporteLiquidacionesBorrador.SetParameterValue(reporteLiquidacionesBorrador.Parameter_Domicilio.ParameterFieldName, domicilio);
            reporteLiquidacionesBorrador.SetParameterValue(reporteLiquidacionesBorrador.Parameter_Actividad.ParameterFieldName, actividad);
            FrmReportes frmRepo = new FrmReportes(reporteLiquidacionesBorrador);
            frmRepo.ShowDialog();
        }

        public static void BorradorDeLiquidacionPorConvenio(DataSet fuente, String titulo, String empresa, String cuit, String domicilio, String actividad)
        {
            CRLiquidacionesParaRecibosBorrador reporteLiquidacionesBorrador = new CRLiquidacionesParaRecibosBorrador();
            reporteLiquidacionesBorrador.SetDataSource(fuente);
            reporteLiquidacionesBorrador.SetParameterValue(reporteLiquidacionesBorrador.Parameter_Titulo.ParameterFieldName, titulo);
            reporteLiquidacionesBorrador.SetParameterValue(reporteLiquidacionesBorrador.Parameter_Definitivo.ParameterFieldName, false);
            reporteLiquidacionesBorrador.SetParameterValue(reporteLiquidacionesBorrador.Parameter_AgrupadoPorConvenio.ParameterFieldName, true);
            reporteLiquidacionesBorrador.SetParameterValue(reporteLiquidacionesBorrador.Parameter_empresa.ParameterFieldName, empresa);
            reporteLiquidacionesBorrador.SetParameterValue(reporteLiquidacionesBorrador.Parameter_cuit.ParameterFieldName, cuit);
            reporteLiquidacionesBorrador.SetParameterValue(reporteLiquidacionesBorrador.Parameter_Domicilio.ParameterFieldName, domicilio);
            reporteLiquidacionesBorrador.SetParameterValue(reporteLiquidacionesBorrador.Parameter_Actividad.ParameterFieldName, actividad);
            FrmReportes frmRepo = new FrmReportes(reporteLiquidacionesBorrador);
            frmRepo.ShowDialog();
        }

        public static void RecibosDeSueldo(DataSet fuente, String fechaAcreditacion)
        {
            FrmReportes frmRepo = new FrmReportes();
            //EN MODO DEBUG GENERA RECIBOS SEPARADOS HOJA ENTERA EN A4
            #if DEBUG
                CRRecibosSueldo reporteRecibosSueldo = new CRRecibosSueldo();
            #else
                CRRecibosSueldo_Nuevo reporteRecibosSueldo = new CRRecibosSueldo_Nuevo();
            #endif
            reporteRecibosSueldo.SetDataSource(fuente);
            #if DEBUG
                //Muestra originales
                reporteRecibosSueldo.SetParameterValue(reporteRecibosSueldo.Parameter_fechaAcreditacion.ParameterFieldName, DateTime.Parse(fechaAcreditacion));
                reporteRecibosSueldo.SetParameterValue(reporteRecibosSueldo.Parameter_Original.ParameterFieldName, true);
                frmRepo.setReportSource(reporteRecibosSueldo);
                frmRepo.ShowDialog();

                //Muestra duplicados
                reporteRecibosSueldo.SetParameterValue(reporteRecibosSueldo.Parameter_Original.ParameterFieldName, false);
                frmRepo.setReportSource(reporteRecibosSueldo);
                frmRepo.ShowDialog();
            #else
                reporteRecibosSueldo.SetParameterValue(reporteRecibosSueldo.Parameter_fechaAcreditacion.ParameterFieldName, DateTime.Parse(fechaAcreditacion));
                reporteRecibosSueldo.SetParameterValue(reporteRecibosSueldo.Parameter_notaAlPie.ParameterFieldName, string.Empty);
                frmRepo.setReportSource(reporteRecibosSueldo);
                frmRepo.ShowDialog();
            #endif
        }

        public static void LibroLey(DataSet fuente, String titulo, String empresa, String cuit, String domicilio, String actividad)
        {
            CRLiquidacionesParaRecibosBorrador reporteLibroLey = new CRLiquidacionesParaRecibosBorrador();
            reporteLibroLey.SetDataSource(fuente);
            reporteLibroLey.SetParameterValue(reporteLibroLey.Parameter_Titulo.ParameterFieldName, titulo);
            reporteLibroLey.SetParameterValue(reporteLibroLey.Parameter_Definitivo.ParameterFieldName, true);
            reporteLibroLey.SetParameterValue(reporteLibroLey.Parameter_AgrupadoPorConvenio.ParameterFieldName, false);
            reporteLibroLey.SetParameterValue(reporteLibroLey.Parameter_empresa.ParameterFieldName, empresa);
            reporteLibroLey.SetParameterValue(reporteLibroLey.Parameter_cuit.ParameterFieldName, cuit);
            reporteLibroLey.SetParameterValue(reporteLibroLey.Parameter_Domicilio.ParameterFieldName, domicilio);
            reporteLibroLey.SetParameterValue(reporteLibroLey.Parameter_Actividad.ParameterFieldName, actividad);
            FrmReportes frmRepo = new FrmReportes(reporteLibroLey);
            frmRepo.ShowDialog();
        }

        public static void RubricasLibroLey(DataSet fuente)
        {
            CRRubricasLibroLey reporteRubricasLibroLey = new CRRubricasLibroLey();
            reporteRubricasLibroLey.SetDataSource(fuente);
            FrmReportes visor = new FrmReportes(reporteRubricasLibroLey);
            visor.ShowDialog();
        }

        public static void NetosPorLegajo(DataSet fuente, String titulo, String empresa, String version)
        {
            CRLiquidacionesNetosPorLegajo reporteLiquidacionesNetosPorLegajo = new CRLiquidacionesNetosPorLegajo();
            reporteLiquidacionesNetosPorLegajo.SetDataSource(fuente);
            reporteLiquidacionesNetosPorLegajo.SetParameterValue(reporteLiquidacionesNetosPorLegajo.Parameter_Titulo.ParameterFieldName, titulo);
            reporteLiquidacionesNetosPorLegajo.SetParameterValue(reporteLiquidacionesNetosPorLegajo.Parameter_empresa.ParameterFieldName, empresa);
            reporteLiquidacionesNetosPorLegajo.SetParameterValue(reporteLiquidacionesNetosPorLegajo.Parameter_soft.ParameterFieldName, "SOffT " + version);
            FrmReportes visor = new FrmReportes(reporteLiquidacionesNetosPorLegajo);
            visor.ShowDialog();
        }

        public static void NetosPorFormaDePago(DataSet fuente, String titulo, String empresa, String version)
        {
            CRLiquidacionesNetosPorFormaDePago reporteLiquidacionesNetosPorFormaDePago = new CRLiquidacionesNetosPorFormaDePago();
            reporteLiquidacionesNetosPorFormaDePago.SetDataSource(fuente);
            reporteLiquidacionesNetosPorFormaDePago.SetParameterValue(reporteLiquidacionesNetosPorFormaDePago.Parameter_Titulo.ParameterFieldName, titulo);
            reporteLiquidacionesNetosPorFormaDePago.SetParameterValue(reporteLiquidacionesNetosPorFormaDePago.Parameter_empresa.ParameterFieldName, empresa);
            reporteLiquidacionesNetosPorFormaDePago.SetParameterValue(reporteLiquidacionesNetosPorFormaDePago.Parameter_soft.ParameterFieldName, "SOffT " + version);
            FrmReportes visor = new FrmReportes(reporteLiquidacionesNetosPorFormaDePago);
            visor.ShowDialog();
        }

        public static void ListadoDeConceptos(DataSet fuente)
        {
            CRConceptos reporteConceptos = new CRConceptos();
            reporteConceptos.SetDataSource(fuente);
            FrmReportes visor = new FrmReportes(reporteConceptos);
            visor.ShowDialog();
        }

        public static void ConceptosLiquidados(DataSet fuente, String titulo, String empresa, String version)
        {
            CRLiquidacionesTotalesPorConcepto reporteLiquidacionesTotalesPorConcepto = new CRLiquidacionesTotalesPorConcepto();
            reporteLiquidacionesTotalesPorConcepto.SetDataSource(fuente);
            reporteLiquidacionesTotalesPorConcepto.SetParameterValue(reporteLiquidacionesTotalesPorConcepto.Parameter_Titulo.ParameterFieldName, titulo);
            reporteLiquidacionesTotalesPorConcepto.SetParameterValue(reporteLiquidacionesTotalesPorConcepto.Parameter_empresa.ParameterFieldName, empresa);
            reporteLiquidacionesTotalesPorConcepto.SetParameterValue(reporteLiquidacionesTotalesPorConcepto.Parameter_soft.ParameterFieldName, "SOffT " + version);
            FrmReportes visor = new FrmReportes(reporteLiquidacionesTotalesPorConcepto);
            visor.ShowDialog();
        }
        #endregion

        #region Anticipos

        public static void ArchivoAcreditacion(DataSet fuente, DateTime fechaAcreditacion, String descripcionLiquidacion, String empresa, String nroEmpresa)
        {
            CRReporteBapro reporteAcreditacionBancariaBapro = new CRReporteBapro();
            reporteAcreditacionBancariaBapro.SetDataSource(fuente);
            reporteAcreditacionBancariaBapro.SetParameterValue(reporteAcreditacionBancariaBapro.Parameter_FechaAcreditacion.ParameterFieldName, fechaAcreditacion);
            reporteAcreditacionBancariaBapro.SetParameterValue(reporteAcreditacionBancariaBapro.Parameter_LiquidacionDescripcion.ParameterFieldName, descripcionLiquidacion);
            reporteAcreditacionBancariaBapro.SetParameterValue(reporteAcreditacionBancariaBapro.Parameter_Empresa.ParameterFieldName, empresa);
            reporteAcreditacionBancariaBapro.SetParameterValue(reporteAcreditacionBancariaBapro.Parameter_NroEmpresa.ParameterFieldName, nroEmpresa);
            FrmReportes visor = new FrmReportes(reporteAcreditacionBancariaBapro);
            visor.ShowDialog();
        }

        public static void AcreditacionDeAnticipos(DataSet fuente, String fechaAcreditacion, String descripcionLiquidacion, String empresa, String nroEmpresa)
        {
            CRReporteBapro reporteAcreditacionBancariaBapro = new CRReporteBapro();
            reporteAcreditacionBancariaBapro.SetDataSource(fuente);
            reporteAcreditacionBancariaBapro.SetParameterValue(reporteAcreditacionBancariaBapro.Parameter_FechaAcreditacion.ParameterFieldName, fechaAcreditacion);
            reporteAcreditacionBancariaBapro.SetParameterValue(reporteAcreditacionBancariaBapro.Parameter_LiquidacionDescripcion.ParameterFieldName, descripcionLiquidacion);
            reporteAcreditacionBancariaBapro.SetParameterValue(reporteAcreditacionBancariaBapro.Parameter_Empresa.ParameterFieldName, empresa);
            reporteAcreditacionBancariaBapro.SetParameterValue(reporteAcreditacionBancariaBapro.Parameter_NroEmpresa.ParameterFieldName, nroEmpresa);
            FrmReportes visor = new FrmReportes(reporteAcreditacionBancariaBapro);
            visor.ShowDialog();
        }

        public static void ReporteDeAnticiposPorTipo(DataSet fuente, String empresa, String version)
        {
            CRAnticiposPorTipo crAnticiposPorTipo = new CRAnticiposPorTipo();
            crAnticiposPorTipo.SetDataSource(fuente);
            crAnticiposPorTipo.SetParameterValue(crAnticiposPorTipo.Parameter_empresa.ParameterFieldName, empresa);
            crAnticiposPorTipo.SetParameterValue(crAnticiposPorTipo.Parameter_soft.ParameterFieldName, "SOffT " + version);
            FrmReportes visor = new FrmReportes(crAnticiposPorTipo);
            visor.ShowDialog();
        }

        public static void ReporteDeAnticiposPorLegajo(DataSet fuente, String empresa, String version)
        {
            CRAnticiposPorLegajo crAnticiposPorLegajo = new CRAnticiposPorLegajo();
            crAnticiposPorLegajo.SetDataSource(fuente);
            crAnticiposPorLegajo.SetParameterValue(crAnticiposPorLegajo.Parameter_empresa.ParameterFieldName, empresa);
            crAnticiposPorLegajo.SetParameterValue(crAnticiposPorLegajo.Parameter_soft.ParameterFieldName, "SOffT " + version);
            FrmReportes visor = new FrmReportes(crAnticiposPorLegajo);
            visor.ShowDialog();        
        }

        public static void ValeAnticipo(DataSet fuente)
        {
            CRAnticipoVale anticipoVale = new CRAnticipoVale();
            anticipoVale.SetDataSource(fuente);
            FrmReportes visor = new FrmReportes(anticipoVale);
            visor.ShowDialog();
        }

        #endregion

        #region Informes

        /// <summary>
        /// Genera y presenta el informe de Jornada Legal con los horarios de los empleados por centro de costo
        /// </summary>
        /// <param name="fuente">Datos necesarios para confeccionar el informe</param>
        public static void JornadaLegal(DataSet fuente)
        {
            CRHorarios crHorarios = new CRHorarios();
            crHorarios.SetDataSource(fuente);
            FrmReportes visor = new FrmReportes(crHorarios);
            visor.ShowDialog();
        }

        public static void ConsultaDeCamposEmpledo(
            DataSet fuente,
            String filtro,
            String liquidacion,
            String descripcion,
            String estado,
            String empresa,
            String version
            )
        {
            CRCamposEmpleado reporteEmpleadosPorCampo = new CRCamposEmpleado();
            reporteEmpleadosPorCampo.SetDataSource(fuente);
            reporteEmpleadosPorCampo.SetParameterValue(reporteEmpleadosPorCampo.Parameter_filtro.ParameterFieldName, filtro);
            reporteEmpleadosPorCampo.SetParameterValue(reporteEmpleadosPorCampo.Parameter_liquidacion.ParameterFieldName, liquidacion);
            reporteEmpleadosPorCampo.SetParameterValue(reporteEmpleadosPorCampo.Parameter_descripcion.ParameterFieldName, descripcion);
            reporteEmpleadosPorCampo.SetParameterValue(reporteEmpleadosPorCampo.Parameter_Estado.ParameterFieldName, estado);
            reporteEmpleadosPorCampo.SetParameterValue(reporteEmpleadosPorCampo.Parameter_empresa.ParameterFieldName, empresa);
            reporteEmpleadosPorCampo.SetParameterValue(reporteEmpleadosPorCampo.Parameter_soft.ParameterFieldName, "SOffT " + version);
            FrmReportes visor = new FrmReportes(reporteEmpleadosPorCampo);
            visor.ShowDialog();
        }

        public static void AcumuladosPorTipo(DataSet fuente)
        {
            CRAcumuladosPorTipo crAcumuladosPorTipo = new CRAcumuladosPorTipo();
            crAcumuladosPorTipo.SetDataSource(fuente);
            FrmReportes visor = new FrmReportes(crAcumuladosPorTipo);
            visor.ShowDialog();
        }

        public static void Sindicatos(DataSet fuente, System.Collections.IList titulos, String descripcion, String anioMes)
        {
            CRSindicatos crSindicatos = new CRSindicatos();
            crSindicatos.SetDataSource(fuente);
            crSindicatos.SetParameterValue(crSindicatos.Parameter_Titulo1.ParameterFieldName, titulos[1]);
            crSindicatos.SetParameterValue(crSindicatos.Parameter_Titulo2.ParameterFieldName, titulos[2]);
            crSindicatos.SetParameterValue(crSindicatos.Parameter_Titulo3.ParameterFieldName, titulos[3]);
            crSindicatos.SetParameterValue(crSindicatos.Parameter_Titulo4.ParameterFieldName, titulos[4]);
            crSindicatos.SetParameterValue(crSindicatos.Parameter_Titulo5.ParameterFieldName, titulos[5]);
            crSindicatos.SetParameterValue(crSindicatos.Parameter_Titulo6.ParameterFieldName, titulos[6]);
            crSindicatos.SetParameterValue(crSindicatos.Parameter_Titulo7.ParameterFieldName, titulos[7]);
            crSindicatos.SetParameterValue(crSindicatos.Parameter_Sindicato.ParameterFieldName, descripcion);
            crSindicatos.SetParameterValue(crSindicatos.Parameter_anioMes.ParameterFieldName, anioMes);
            FrmReportes visor = new FrmReportes(crSindicatos);
            visor.ShowDialog();
        }
 
        #endregion

        #region Empleados

        public static void ListaEmpleados(DataTable fuente)
        {
            CRListaDeEmpleados lista = new CRListaDeEmpleados();
            lista.SetDataSource(fuente);
            FrmReportes visor = new FrmReportes(lista);
            visor.ShowDialog();
        }

        public static void DatosEmpleado(DataSet fuente, String empresa, String version)
        {
            CREmpleado crEmpleado = new CREmpleado();
            crEmpleado.SetDataSource(fuente);
            crEmpleado.SetParameterValue(crEmpleado.Parameter_empresa.ParameterFieldName, empresa);
            crEmpleado.SetParameterValue(crEmpleado.Parameter_soft.ParameterFieldName, "SOffT " + version);
            FrmReportes visor = new FrmReportes(crEmpleado);
            visor.ShowDialog();
        }

        public static void FechasDeJubilacion(DataSet fuente, String empresa, String version)
        {
            CREmpleadosPorFechaDeJubilacion crFechasDeJubilacion = new CREmpleadosPorFechaDeJubilacion();
            crFechasDeJubilacion.SetDataSource(fuente);
            crFechasDeJubilacion.SetParameterValue(crFechasDeJubilacion.Parameter_empresa.ParameterFieldName, empresa);
            crFechasDeJubilacion.SetParameterValue(crFechasDeJubilacion.Parameter_soft.ParameterFieldName, "SOffT " + version);
            FrmReportes visor = new FrmReportes(crFechasDeJubilacion);
            visor.ShowDialog();
        }

        #endregion

        #region Asientos de Sueldo

        public static void ReporteAsientoDeSueldos(DataSet fuente, String empresa, String version, String anioMes)
        {
            CRAsientoDeSueldo crAsientoDeSueldo = new CRAsientoDeSueldo();
            crAsientoDeSueldo.SetDataSource(fuente);
            crAsientoDeSueldo.SetParameterValue(crAsientoDeSueldo.Parameter_aniomes.ParameterFieldName, anioMes);
            crAsientoDeSueldo.SetParameterValue(crAsientoDeSueldo.Parameter_empresa.ParameterFieldName, empresa);
            crAsientoDeSueldo.SetParameterValue(crAsientoDeSueldo.Parameter_soft.ParameterFieldName, "SOffT " + version);
            FrmReportes visor = new FrmReportes(crAsientoDeSueldo);
            visor.ShowDialog();
        }

        public static void ReportePorCentroDeCosto(DataSet fuente, String empresa, String version, String anioMes)
        {
            CRAsientoDeSueldoPorCentroCosto crAsientoDeSueldoPorCentroCosto = new CRAsientoDeSueldoPorCentroCosto();
            crAsientoDeSueldoPorCentroCosto.SetDataSource(fuente);
            crAsientoDeSueldoPorCentroCosto.SetParameterValue(crAsientoDeSueldoPorCentroCosto.Parameter_aniomes.ParameterFieldName, anioMes);
            crAsientoDeSueldoPorCentroCosto.SetParameterValue(crAsientoDeSueldoPorCentroCosto.Parameter_empresa.ParameterFieldName, empresa);
            crAsientoDeSueldoPorCentroCosto.SetParameterValue(crAsientoDeSueldoPorCentroCosto.Parameter_soft.ParameterFieldName, "SOffT " + version);
            FrmReportes visor = new FrmReportes(crAsientoDeSueldoPorCentroCosto);
            visor.ShowDialog();
        }

        #endregion
    }
}
