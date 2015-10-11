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
    public partial class frmMnuAsientosDeSueldos : Sofft.ViewComunes.frmMenu 
    {
        public frmMnuAsientosDeSueldos()
        {
            InitializeComponent();
            this.creaBotones("Formulas Asientos de Sueldos", "Generar Asiento de Sueldos","Asiento de Sueldos", "Asientos por Centro de Costo");
            this.Text = "Asientos de Sueldos";
        }

        public override void boton_Click(int indice)
        {
            //frmReportes visor;
            Dialogos.frmSeleccionAnioMes seleccionAnioMes;
            switch (indice)
            {
                case 0: //Formulas Asientos de Sueldos
                    frmABMConceptos frmFormulasAsientos = new frmABMConceptos();
                    frmFormulasAsientos.abrirParaAsientosDeSueldos();
                    break;
                case 1: //Generar Asiento de Sueldos
                    frmLiquidacionTabla frmLiqui = new frmLiquidacionTabla();
                    frmLiqui.abrirParaTabla(101);
                    break;
                case 2: //Reporte Asiento de Sueldos
                    seleccionAnioMes = new Sueldos.View.Dialogos.frmSeleccionAnioMes();
                    if (seleccionAnioMes.ShowDialog() ==DialogResult.OK )
                    {
                        /*Reportes.CRAsientoDeSueldo crAsientoDeSueldo = new Sueldos.View.Reportes.CRAsientoDeSueldo();
                        crAsientoDeSueldo.SetDataSource(Model.DB.ejecutarDataSet(Model.TipoComando.SP, "ReporteAsientoDeSueldos", "anioMes", seleccionAnioMes.AnioMes));
                        EmpresaEntity emp = new ConsultaEmpresas().getEmpresa(1);
                        crAsientoDeSueldo.SetParameterValue(crAsientoDeSueldo.Parameter_empresa.ParameterFieldName, emp.RazonSocial);
                        crAsientoDeSueldo.SetParameterValue(crAsientoDeSueldo.Parameter_soft.ParameterFieldName, "SOffT " + Modulo.version);
                        visor = new frmReportes(crAsientoDeSueldo);
                        visor.ShowDialog();*/
                        EmpresaEntity emp = new ConsultaEmpresas().getById(1);
                        DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "ReporteAsientoDeSueldos", "anioMes", seleccionAnioMes.AnioMes);
                        Sueldos.Reportes.CrystalReport.ReportesCreador.ReporteAsientoDeSueldos(ds, emp.RazonSocial,  Application.ProductVersion, seleccionAnioMes.AnioMesDescripcion);
                    }
                    break;
                case 3: //Reporte por Centro de Costo
                    seleccionAnioMes = new Sueldos.View.Dialogos.frmSeleccionAnioMes();
                    if (seleccionAnioMes.ShowDialog() == DialogResult.OK)
                    {
                      /*  Reportes.CRAsientoDeSueldoPorCentroCosto crAsientoDeSueldoPorCentroCosto = new Sueldos.View.Reportes.CRAsientoDeSueldoPorCentroCosto();
                        crAsientoDeSueldoPorCentroCosto.SetDataSource(Model.DB.ejecutarDataSet(Model.TipoComando.SP, "ReporteAsientoDeSueldosPorCentroCosto", "anioMes", seleccionAnioMes.AnioMes));
                        EmpresaEntity emp = new ConsultaEmpresas().getEmpresa(1);
                        crAsientoDeSueldoPorCentroCosto.SetParameterValue(crAsientoDeSueldoPorCentroCosto.Parameter_empresa.ParameterFieldName, emp.RazonSocial);
                        crAsientoDeSueldoPorCentroCosto.SetParameterValue(crAsientoDeSueldoPorCentroCosto.Parameter_soft.ParameterFieldName, "SOffT " + Modulo.version);
                        visor = new frmReportes(crAsientoDeSueldoPorCentroCosto);
                        visor.ShowDialog(); */
                        EmpresaEntity emp = new ConsultaEmpresas().getById(1);
                        DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "ReporteAsientoDeSueldosPorCentroCosto", "anioMes", seleccionAnioMes.AnioMes);
                        Sueldos.Reportes.CrystalReport.ReportesCreador.ReportePorCentroDeCosto(ds, emp.RazonSocial,  Application.ProductVersion, seleccionAnioMes.AnioMesDescripcion);
                    }
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }

    }
}

