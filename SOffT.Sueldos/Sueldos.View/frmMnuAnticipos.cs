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
    public partial class frmMnuAnticipos : Sofft.ViewComunes.frmMenu 
    {


        public frmMnuAnticipos()
        {
            InitializeComponent();
            this.creaBotones("ABM Anticipos","Emisión de Anticipos", "Reporte por Tipo", "Reporte por Legajo","Acreditaciones");
            this.Text = "Anticipos";
        }
        
        public void abrir()
        {
            this.ShowDialog();
        }

        public override void boton_Click(int indice)
        {
            //frmReportes visor;
            Dialogos.frmSeleccionAnioMes seleccionAnioMes;
            switch (indice)
            {
                case 0: //ABM Anticipos
                    frmABManticipos abmAnticipos = new frmABManticipos();
                    break;
                case 1: //Emisión de Anticipos
                    frmAnticipo anticipo = new frmAnticipo();
                    anticipo.abrirParaNuevo();
                    break;
                case 2: //Reporte de Anticipos por Tipo
                    //TODO agregar dialogo que solicita aniomes
                    seleccionAnioMes = new Sueldos.View.Dialogos.frmSeleccionAnioMes();
                    if (seleccionAnioMes.ShowDialog() == DialogResult.OK)
                    {
                      /*  Reportes.CRAnticiposPorTipo crAnticiposPorTipo = new Sueldos.View.Reportes.CRAnticiposPorTipo();
                        crAnticiposPorTipo.SetDataSource(Model.DB.ejecutarDataSet(Model.TipoComando.SP, "ReporteAnticiposPorAnioMes", "anioMes", seleccionAnioMes.AnioMes));
                        EmpresaEntity emp = new ConsultaEmpresas().getEmpresa(1);
                        crAnticiposPorTipo.SetParameterValue(crAnticiposPorTipo.Parameter_empresa.ParameterFieldName, emp.RazonSocial);
                        crAnticiposPorTipo.SetParameterValue(crAnticiposPorTipo.Parameter_soft.ParameterFieldName, "SOffT " + Modulo.version);
                        visor = new frmReportes(crAnticiposPorTipo);
                        visor.ShowDialog();*/
                        EmpresaEntity emp = new ConsultaEmpresas().getById(1);
                        DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "ReporteAnticiposPorAnioMes", "anioMes", seleccionAnioMes.AnioMes);
                        Sueldos.Reportes.CrystalReport.ReportesCreador.ReporteDeAnticiposPorTipo(ds, emp.RazonSocial, "SOffT " + Application.ProductVersion );
                    }
                    break;
                case 3: //Reporte de Anticipos Por Legajo
                    //TODO agregar dialogo que solicita aniomes
                    seleccionAnioMes = new Sueldos.View.Dialogos.frmSeleccionAnioMes();
                    if (seleccionAnioMes.ShowDialog() == DialogResult.OK)
                    {
                      /*  Reportes.CRAnticiposPorLegajo crAnticiposPorLegajo = new Sueldos.View.Reportes.CRAnticiposPorLegajo();
                        crAnticiposPorLegajo.SetDataSource(Model.DB.ejecutarDataSet(Model.TipoComando.SP, "ReporteAnticiposPorAnioMes", "anioMes", seleccionAnioMes.AnioMes));
                        EmpresaEntity emp = new ConsultaEmpresas().getEmpresa(1);
                        crAnticiposPorLegajo.SetParameterValue(crAnticiposPorLegajo.Parameter_empresa.ParameterFieldName, emp.RazonSocial);
                        crAnticiposPorLegajo.SetParameterValue(crAnticiposPorLegajo.Parameter_soft.ParameterFieldName, "SOffT " + Modulo.version);
                        visor = new frmReportes(crAnticiposPorLegajo);
                        visor.ShowDialog(); */
                        EmpresaEntity emp = new ConsultaEmpresas().getById(1);
                        DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "ReporteAnticiposPorAnioMes", "anioMes", seleccionAnioMes.AnioMes);
                        Sueldos.Reportes.CrystalReport.ReportesCreador.ReporteDeAnticiposPorLegajo(ds, emp.RazonSocial,  Application.ProductVersion);
                    }
                    break;
                case 4: //Acreditaciones
                    frmAcreditacionesAnticipos frmacre = new frmAcreditacionesAnticipos();
                    break;

            }
        }
    }
}

