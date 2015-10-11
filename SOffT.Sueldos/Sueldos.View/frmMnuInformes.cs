using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sofft.Utils;
using Sueldos.Entidades;
using Sueldos.Modelo;

namespace Sueldos.View
{
    public partial class frmMnuInformes : Sofft.ViewComunes.frmMenu
    {
        public frmMnuInformes()
        {
            InitializeComponent();
            this.creaBotones("Jornada Legal", "Empleados por Campo", "Acumulados por Tipo", "Sindicatos", "Vacaciones Por Año", "Fechas de Jubilación");
            this.Text = "Informes";
        }

        public void abrir()
        { this.ShowDialog(); }

        public override void boton_Click(int indice)
        {
            DataSet ds;
            //frmReportes visor;
            Dialogos.frmSeleccionAnioMes frmFecha;
            EmpresaEntity empresa = new ConsultaEmpresas().getById(1);
            switch (indice)
            {
                case 0: //Jornada Legal
                    ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteHorarios");
                    Model.DB.ejecutarDataSet(ref ds, Model.TipoComando.SP, "empresaConsultar", "@idEmpresa", 1);
                    Sueldos.Reportes.CrystalReport.ReportesCreador.JornadaLegal(ds);
                    break;
                case 1: //Consulta de campos empledo
                    //TODO Incorporar el filtro de estado de empleado
                    Dialogos.frmSeleccionCampoEmpleado seleccionCampo = new Sueldos.View.Dialogos.frmSeleccionCampoEmpleado();
                    if (seleccionCampo.ShowDialog() == DialogResult.OK)
                    {
                        if (seleccionCampo.Filtrado)
                        {
                            if (seleccionCampo.Historico)
                            {
                                ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "ReporteEmpleadosPorCampoEmpleadoValorHistorico",
                                        "indice", seleccionCampo.Indice,
                                        "contenido", seleccionCampo.Contenido,
                                        "idEstado", seleccionCampo.Estado,
                                        "idLiquidacion", seleccionCampo.LiquidacionID);
                            }
                            else
                            {
                                ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "ReporteEmpleadosPorCampoEmpleadoValor",
                                        "indice", seleccionCampo.Indice,
                                        "contenido", seleccionCampo.Contenido,
                                        "idEstado", seleccionCampo.Estado);
                            }
                            ds.Tables[0].TableName = "ReporteEmpleadosPorCampoEmpleado";
                        }
                        else
                        {
                            if (seleccionCampo.Historico)
                            {
                                ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "ReporteEmpleadosPorCampoEmpleadoHistorico",
                                        "indice", seleccionCampo.Indice,
                                        "tipo", seleccionCampo.Tipo,
                                        "idEstado", seleccionCampo.Estado,
                                        "idLiquidacion", seleccionCampo.LiquidacionID);
                            }
                            else
                            {
                                ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "ReporteEmpleadosPorCampoEmpleado",
                                        "indice", seleccionCampo.Indice,
                                        "tipo", seleccionCampo.Tipo,
                                        "idEstado", seleccionCampo.Estado);
                            }
                            ds.Tables[0].TableName = "ReporteEmpleadosPorCampoEmpleado";
                        }
                        EmpresaEntity emp = new ConsultaEmpresas().getById(1);
                        Sueldos.Reportes.CrystalReport.ReportesCreador.ConsultaDeCamposEmpledo(
                            ds,
                            seleccionCampo.ContenidoDescripcion,
                            seleccionCampo.LiquidacionDescripcion,
                            seleccionCampo.IndiceDescripcion,
                            seleccionCampo.EstadoDescripcion,
                            emp.RazonSocial,
                            Application.ProductVersion);
                    }

                    break;
                case 2: //Acumulados por Tipo
                    frmFecha = new Sueldos.View.Dialogos.frmSeleccionAnioMes();
                    if (frmFecha.ShowDialog() == DialogResult.OK)
                    {
                        ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteAcumuladosPorTipo",
                                "anioMes", frmFecha.AnioMes);
                        Sueldos.Reportes.CrystalReport.ReportesCreador.AcumuladosPorTipo(ds);
                    }
                    break;
                case 3: //Sindicatos
                    //TODO cpereyra
                    MessageBox.Show("No implementado todavia");

                    Dialogos.frmSeleccionItem selItem = new Dialogos.frmSeleccionItem();
                    selItem.Nombre = "Sindicato";
                    selItem.Lista = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "tablasConsultarContenidoyDetalleParaCombo",
                        "tabla", "empleadosSueldos",
                        "indice", 14);
                    selItem.HabilitarTodos = false;

                    if (selItem.ShowDialog() == DialogResult.OK)
                    {
                        frmFecha = new Sueldos.View.Dialogos.frmSeleccionAnioMes();
                        if (frmFecha.ShowDialog() == DialogResult.OK)
                        {
                            ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteSindicatos",
                                    "idSindicato", selItem.SelectedID,
                                    "anioMes", frmFecha.AnioMes);
                            List<string> titulos = new List<string>();
                            System.Data.Common.DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "reporteSindicatosDescripcion", "idSindicato", selItem.SelectedID);
                            while (rs.Read())
                            { titulos.Add(rs["Descripcion"].ToString()); }
                            Sueldos.Reportes.CrystalReport.ReportesCreador.Sindicatos(ds, titulos, selItem.SelectedDescripcion, frmFecha.AnioMesDescripcion);
                        }
                    }
                    break;
                case 4: //Vacaciones Por Año
                    frmFecha = new Sueldos.View.Dialogos.frmSeleccionAnioMes();
                    if (frmFecha.ShowDialog() == DialogResult.OK)
                    {
                        string fecha = "31/12/" + frmFecha.Anio;
                        DataSet resultado = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "vacacionesCalculaDiasTodos", "fechaTope", fecha);
                        resultado.DataSetName = "vacacionesCalculaDiasTodos";
                        Model.DataSetTo.CSV(resultado, Model.Delimitador.PuntoComa);
                        resultado.Dispose();
                    }
                    break;
                case 5: //Fechas de Jubilación
                    ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "ReporteEmpleadosPorFechaDeJubilacion");
                    Sueldos.Reportes.CrystalReport.ReportesCreador.FechasDeJubilacion(ds, empresa.RazonSocial, Application.ProductVersion);
                    break;
            }
        }
    }
}