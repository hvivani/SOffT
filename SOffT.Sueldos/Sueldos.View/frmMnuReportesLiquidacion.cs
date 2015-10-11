using System.Data;
using System.Windows.Forms;
using Sofft.ViewComunes;
using Sueldos.Entidades;
using Sueldos.Modelo;
using Sueldos.Reportes.CrystalReport;
using Sueldos.View.Dialogos;

namespace Sueldos.View
{
    public partial class frmMnuReportesLiquidacion : frmMenu
    {
        private EmpresaEntity empresa;
        private Dialogos.frmSeleccionLiquidacionPorTipos selLiquidacionTipo;
        public frmMnuReportesLiquidacion()
        {
            InitializeComponent();
            this.creaBotones(
                "Borrador de Liquidacion",
                "Recibos de Sueldo",
                "Libro Ley",
                "Rubricas para Libro Ley",
                "Netos por Legajo",
                "Netos Por Forma de Pago",
                "Netos Por Area",
                "Listado de Conceptos",
                "Conceptos Liquidados",
                "Borrador por Convenio",
                "Netos por Centro de Costo");
            this.Text = "Reportes Liquidación";
            empresa = new ConsultaEmpresas().getById(1);
        }

        public void abrir()
        { this.ShowDialog(); }

        public override void boton_Click(int indice)
        {
            Dialogos.frmSeleccionAnioMes frmFecha;
            switch (indice)
            {
                case 0:
                    //Borrador de Liquidacion
                    selLiquidacionTipo = new frmSeleccionLiquidacionPorTipos();
                    if (selLiquidacionTipo.ShowDialog(this) == DialogResult.OK)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteRecibosSueldoDetalle", "@idLiquidacion", selLiquidacionTipo.LiquidacionId);
                        this.Cursor = Cursors.Default;
                        ReportesCreador.BorradorDeLiquidacion(ds, selLiquidacionTipo.LiquidacionDescripcion, empresa.RazonSocial, empresa.CUIT, empresa.Domicilio, empresa.Actividad);
                    }
                    break;
                case 1:
                    //Recibos de Sueldo
                    frmSeleccionLiquidacionPorTiposConFechaAcreditacion selLiquidacion = new Dialogos.frmSeleccionLiquidacionPorTiposConFechaAcreditacion();
                    if (selLiquidacion.ShowDialog() == DialogResult.OK)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        DataSet dsRecibosSueldos = new DataSet();
                        Model.DB.ejecutarDataSet(ref dsRecibosSueldos, Model.TipoComando.SP, "reporteRecibosSueldoDetalle", "@idLiquidacion", selLiquidacion.LiquidacionId);
                        Model.DB.ejecutarDataSet(ref dsRecibosSueldos, Model.TipoComando.SP, "reporteRecibosSueldoGeneral", "@idLiquidacion", selLiquidacion.LiquidacionId);
                        this.Cursor = Cursors.Default;
                        ReportesCreador.RecibosDeSueldo(dsRecibosSueldos, selLiquidacion.FechaPago.ToString());
                    }
                    break;
                case 2: //Libro Ley
                    selLiquidacionTipo = new frmSeleccionLiquidacionPorTipos();
                    if (selLiquidacionTipo.ShowDialog(this) == DialogResult.OK)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteRecibosSueldoDetalle", "@idLiquidacion", selLiquidacionTipo.LiquidacionId);
                        this.Cursor = Cursors.Default;
                        ReportesCreador.LibroLey(ds, selLiquidacionTipo.LiquidacionDescripcion, empresa.RazonSocial, empresa.CUIT, empresa.Domicilio, empresa.Actividad);
                    }
                    break;
                case 3: //Rubricas para Libro Ley
                    DataSet dsRubricas = Model.DB.ejecutarDataSet(
                    Model.TipoComando.SP, "empresaConsultarParaRubrica", "@idEmpresa", 1, "@cantPaginas", new Sueldos.View.Dialogos.frmSeleccionValor("Páginas").Valor);
                    Sueldos.Reportes.CrystalReport.ReportesCreador.RubricasLibroLey(dsRubricas);
                    break;
                case 4: //Netos por Legajo
                    selLiquidacionTipo = new frmSeleccionLiquidacionPorTipos();
                    if (selLiquidacionTipo.ShowDialog(this) == DialogResult.OK)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        EmpresaEntity emp = new ConsultaEmpresas().getById(1);
                        DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteLiquidacionesNetoPorLegajo", "@idLiquidacion", selLiquidacionTipo.LiquidacionId);
                        this.Cursor = Cursors.Default;
                        ReportesCreador.NetosPorLegajo(ds, selLiquidacionTipo.LiquidacionDescripcion, emp.RazonSocial, Application.ProductVersion);
                    }
                    break;
                case 5: //Netos Por Forma de Pago
                    selLiquidacionTipo = new frmSeleccionLiquidacionPorTipos();
                    if (selLiquidacionTipo.ShowDialog(this) == DialogResult.OK)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        EmpresaEntity emp = new ConsultaEmpresas().getById(1);
                        DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteLiquidacionesNetoPorFormaDePago", "@idLiquidacion", selLiquidacionTipo.LiquidacionId);
                        this.Cursor = Cursors.Default;
                        ReportesCreador.NetosPorFormaDePago(ds, selLiquidacionTipo.LiquidacionDescripcion, emp.RazonSocial, Application.ProductVersion);
                    }
                    break;
                case 6: //Netos por Area
                    frmFecha = new frmSeleccionAnioMes();
                    if (frmFecha.ShowDialog() == DialogResult.OK)
                    {
                        DataSet resultado = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteNetoPorLegajoAreaConvenioAnioMes", "anioMes", frmFecha.AnioMes);
                        resultado.DataSetName = "reporteNetoPorLegajoAreaConvenioAnioMes";
                        Model.DataSetTo.CSV(resultado, Model.Delimitador.PuntoComa);
                        resultado.Dispose();
                    }
                    break;
                case 7: //Listado de Conceptos
                    this.Cursor = Cursors.WaitCursor;
                    DataSet dsConceptos = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteConceptos");
                    this.Cursor = Cursors.Default;
                    ReportesCreador.ListadoDeConceptos(dsConceptos);
                    break;
                case 8: //Conceptos Liquidados
                    selLiquidacionTipo = new frmSeleccionLiquidacionPorTipos();
                    if (selLiquidacionTipo.ShowDialog(this) == DialogResult.OK)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        EmpresaEntity emp = new ConsultaEmpresas().getById(1);
                        DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteLiquidacionesTotalesPorConcepto", "@idLiquidacion", selLiquidacionTipo.LiquidacionId);
                        this.Cursor = Cursors.Default;
                        ReportesCreador.ConceptosLiquidados(ds, selLiquidacionTipo.LiquidacionDescripcion, emp.RazonSocial, Application.ProductVersion);
                    }
                    break;
                case 9:
                    //Borrador de Liquidacion
                    selLiquidacionTipo = new frmSeleccionLiquidacionPorTipos();
                    if (selLiquidacionTipo.ShowDialog(this) == DialogResult.OK)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteRecibosSueldoDetalle", "@idLiquidacion", selLiquidacionTipo.LiquidacionId);
                        this.Cursor = Cursors.Default;
                        ReportesCreador.BorradorDeLiquidacionPorConvenio(ds, selLiquidacionTipo.LiquidacionDescripcion, empresa.RazonSocial, empresa.CUIT, empresa.Domicilio, empresa.Actividad);
                    }
                    break;
                case 10: //Netos por Centro de Costo
                    frmFecha = new frmSeleccionAnioMes();
                    if (frmFecha.ShowDialog() == DialogResult.OK)
                    {
                        DataSet resultado = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteNetoPorLegajoPorCentroDeCostoAnioMes", "anioMes", frmFecha.AnioMes);
                        resultado.DataSetName = "reporteNetoPorLegajoPorCentroDeCostoAnioMes";
                        Model.DataSetTo.CSV(resultado, Model.Delimitador.PuntoComa);
                        resultado.Dispose();
                    }
                    break;
            }
        }
    }
}