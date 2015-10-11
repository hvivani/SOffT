using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sofft.Utils;


namespace Sueldos.View
{
    public partial class frmSueldos : Sofft.ViewComunes.frmPrincipal
    {
        public frmSueldos()
        {
            
            InitializeComponent();
            Modulo.seteaCultura();
            Modulo.ValidaLogin = true;
            this.creaBotones("A.B.M. Empleados", "Reloj y Asistencia", "Anticipos", "Liquidacion", "Cargas Sociales", "Informes", "Herramientas");
            this.setDatos("", "", "Gestión de Asistencia, Remuneraciones y Cargas Sociales", "", null, "versión: " + Application.ProductVersion);
            this.Text = "SOffT Sueldos";
            if (Modulo.ValidaLogin)
                this.verificaLogin();
        }

        public override void boton_Click(int indice)
        {
            switch (indice)
            {
                case 0: //A.B.M. Empleados
                    frmABMempleados frmEmple = new frmABMempleados();
                    frmEmple.abrir(this.Nivel, indice);
                    break;
                case 1: //Reloj y Asistencia
                    frmMnuAsistencia frmAsi = new frmMnuAsistencia();
                    frmAsi.abrir(this.Nivel, indice);
                    break;
                case 2: //Anticipios
                    frmMnuAnticipos frmAnti = new frmMnuAnticipos();
                    frmAnti.abrir(this.Nivel, indice);
                    break;
                case 3: //Liquidacion
                    frmMnuLiquidacion frmLiq = new frmMnuLiquidacion();
                    frmLiq.abrir(this.Nivel, indice);
                    break;
                case 4: //Cargas Sociales
                    frmMnuCargasSociales frmCargas = new frmMnuCargasSociales();
                    frmCargas.abrir(this.Nivel, indice);
                    break;
                case 5: //Informes
                    frmMnuInformes frmInf = new frmMnuInformes();
                    frmInf.abrir(this.Nivel, indice);
                    break;
                case 6: //Herramientas
                    frmMnuHerramientas frmHerr = new frmMnuHerramientas();
                    frmHerr.abrir(this.Nivel, indice);
                    break;
            }
        }
    }
}

