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
using Sueldos.Entidades;
using Sueldos.Modelo;

namespace Sueldos.View
{
    public partial class frmImportarSIJP : Form
    {
        public frmImportarSIJP()
        {
            InitializeComponent();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DbDataReader rsCampos;
			//TODO: Fix Mono
            StreamReader sr = new StreamReader(@"E:\programas\sueldos\archivos\SIJP200809.txt");
            string linea;
            string valorLeido;
            int legajo;
            while ((linea= sr.ReadLine())!=null) 
            {
                Console.WriteLine(linea);
                rsCampos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "tablasConsultarFormatosExportacion", "@tabla", "sijp");

                legajo = ConsultaEmpleados.consultarLegajoEmpleado(linea.Substring(0, 11));
                while (rsCampos.Read())
                {
                    valorLeido = linea.Substring(Convert.ToInt32(rsCampos["posicion"]) - 1, Convert.ToInt32(rsCampos["longitud"]));
                    Console.WriteLine(valorLeido);
                    if (Convert.ToInt32(rsCampos["posicion"]) == 1)
                        Model.DB.ejecutarProceso(Model.TipoComando.SP, "empleadosSueldosActualizar", "@legajo", legajo, "@codigo", 18, "@valor", valorLeido);
                    if (Convert.ToInt32(rsCampos["posicion"]) == 45)
                        Model.DB.ejecutarProceso(Model.TipoComando.SP, "empleadosSueldosActualizar", "@legajo", legajo, "@codigo", 60, "@valor", Convert.ToInt32(valorLeido));
                    if (Convert.ToInt32(rsCampos["posicion"]) == 47)
                        Model.DB.ejecutarProceso(Model.TipoComando.SP, "empleadosSueldosActualizar", "@legajo", legajo, "@codigo", 61, "@valor", Convert.ToInt32(valorLeido));
                    if (Convert.ToInt32(rsCampos["posicion"]) == 49)
                        Model.DB.ejecutarProceso(Model.TipoComando.SP, "empleadosSueldosActualizar", "@legajo", legajo, "@codigo", 62, "@valor", Convert.ToInt32(valorLeido));
                    if (Convert.ToInt32(rsCampos["posicion"]) == 58)
                        Model.DB.ejecutarProceso(Model.TipoComando.SP, "empleadosSueldosActualizar", "@legajo", legajo, "@codigo", 63, "@valor", Convert.ToInt32(valorLeido));
                    if (Convert.ToInt32(rsCampos["posicion"]) == 61)
                        Model.DB.ejecutarProceso(Model.TipoComando.SP, "empleadosSueldosActualizar", "@legajo", legajo, "@codigo", 50, "@valor", Convert.ToInt32(valorLeido));
                    if (Convert.ToInt32(rsCampos["posicion"]) == 209 && Varios.IsNumeric(valorLeido))
                        Model.DB.ejecutarProceso(Model.TipoComando.SP, "empleadosSueldosActualizar", "@legajo", legajo, "@codigo", 64, "@valor", Convert.ToInt32(valorLeido));

                    //Console.WriteLine(linea.Substring(Convert.ToInt32(rsCampos["posicion"])-1, Convert.ToInt32(rsCampos["longitud"])));
                }
                rsCampos.Close();
            }
            sr.Close();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}