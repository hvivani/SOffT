using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sueldos.View
{
    public partial class frmMnuLiquidacion : Sofft.ViewComunes.frmMenu 
    {

        public frmMnuLiquidacion()
        {
            InitializeComponent();
            this.creaBotones("ABM de Novedades", "ABM de Liquidaciones", "ABM de Conceptos", "Liquidación", "Consulta de Recibos", "Modificacion de Recibos", "Carga Masiva Novedades", "Carga Campos de Empleados", "Carga de Acumulados","Acreditaciones", "Reportes","Asientos de Sueldos");
            this.Text = "Liquidación";
        }

        public override void boton_Click(int indice)
        {
            switch (indice)
            {
                case 0: //ABM de Novedades
                    frmABMnovedades frmNove = new frmABMnovedades();
                    frmNove.abrir();
                    break;
                case 1: //ABM de Liquidaciones
                    frmABMliquidaciones frmAbmLiq = new frmABMliquidaciones();
                    frmAbmLiq.abrir(this.Nivel, indice); 
                    break;
                case 2: //ABM de Conceptos
                    frmABMConceptos frmConce = new frmABMConceptos();
                    frmConce.abrirParaSueldos();
                    break;
                case 3: //Liquidación
                    frmLiquidacion frmLiq = new frmLiquidacion();
                    frmLiq.abrirParaSueldos();
                    break;
                case 4: //Consulta de Recibos
                    frmRecibo frmConsuReci = new frmRecibo();
                    frmConsuReci.abrirParaConsultar();
                    break;
                case 5: //Modificacion de Recibos
                    frmRecibo frmModiReci = new frmRecibo();
                    frmModiReci.abrirParaModificar();
                    break;
                case 6: //Carga Masiva Novedades
                    frmCargaMasivaNovedades frmCargaNove = new frmCargaMasivaNovedades();
                    frmCargaNove.abrir();
                    break;
                case 7: //Carga Campos de Empleados
                    frmCargaCamposDeEmpleados frmCampos = new frmCargaCamposDeEmpleados();
                    //frmCampos.ShowDialog();
                    break;
                case 8: //Carga Acumulados
                    frmCargaAcumulados frmAcumulados = new frmCargaAcumulados();
                    //frmCampos.ShowDialog();
                    break;
                case 9://Acreditaciones
                    frmAcreditaciones frmacre = new frmAcreditaciones();
                    frmacre.ShowDialog();
                    break;
                case 10://Reportes
                    frmMnuReportesLiquidacion frmRepoLiq = new frmMnuReportesLiquidacion();
                    frmRepoLiq.abrir(this.Nivel, indice);
                    break;
                case 11://Asientos de Sueldos
                    frmMnuAsientosDeSueldos frmMenuAsientos = new frmMnuAsientosDeSueldos();
                    frmMenuAsientos.abrir(this.Nivel,indice);
                    break;

            }
        }

    }
}

