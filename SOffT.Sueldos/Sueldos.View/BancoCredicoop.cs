/*  
    BancoCredicoop.cs

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
using System.Collections.Generic;
using System.IO;
using System.Data.Common;
using System.Windows.Forms;
using Sofft.Utils;

namespace Sueldos.View
{
    /// <summary>
    /// Clase que define estructura de archivos para acreditacion de sueldos en cuentas
    /// </summary>
    class BancoCredicoop
    {
        //Maximo de 50 beneficiarios por archivo

        public const string nombreArchivo = "sueldos-credicoop.txt";
        
        public struct movimiento
        {
            public static string tipoCuentaCredito="";          //char(1) 1:ctacte - 2:caja ahorro
            public const string banco = "191";                  //char(3) codigo de banco
            public static string sucursalCuentaCredito = "";    //char(3) numero de sucursal del banco
            public static string cuentaCredito = "";            //char(7) 6 cuenta + 1 verificador
            public static string controlDeCuenta;               //char(1) repite digito verificador de cuenta
            public static string importeDeCredito = "";         //char(15) 13 enteros y 2 decimales
            public static string beneficiario = "";             //char(40) apellido y nombre del beneficiario
            public static string cuil = "";                     //char(11) cuil del beneficiario
            public static string legajo = "";                   //char(10) legajo asignado por la empresa
            public static string observaciones = "";            //char(60) 
        }

        /// <summary>
        /// Genera archivo con formato credicoop. 
        /// </summary>
        /// <param name="idliquidacion"></param>
        /// <param name="archivo"></param>
        /// <param name="esLiquidacionNormal"></param>
        public static void generaArchivo(int idliquidacion, string archivo, List<int> tiposLiquidacionesSeleccionados, DateTime fechaAcreditacion, bool todosLosConveios, int idConvenio)
        {
            string importe = "";
            DbDataReader rsLegajos;
            StreamWriter sw = new StreamWriter(archivo);

            //recorrer netos por legajo
            //consultar netos por idliquidacion.
            //repoteLiquidacionesNetoPorLegajo. calcular haberes+adicionales-retenciones
            if (todosLosConveios)
                rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesNetosPorLegajoPorBanco", "@idLiquidacion", idliquidacion, "@idFormaDePago", 2, "@idBanco", 3);
            else
                rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesNetosPorLegajoPorBancoPorConvenio", "@idLiquidacion", idliquidacion, "@idFormaDePago", 2, "@idBanco", 3, "@idConvenio", idConvenio);

            while (rsLegajos.Read())  //para cada legajo recorro todos los campos definidos en tablas
            {
                if (Varios.Right(Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["legajo"]), "codigo", 21).ToString(), 1) == "1")
                    movimiento.tipoCuentaCredito = "2";
                else
                    movimiento.tipoCuentaCredito = "1";
                movimiento.sucursalCuentaCredito = Varios.Left(Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["legajo"]), "codigo", 21).ToString(), 2).PadLeft(3, '0');
                movimiento.cuentaCredito = Varios.Left(Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["legajo"]), "codigo", 22).ToString(), 7).PadLeft(7, '0');
                movimiento.controlDeCuenta = Varios.Right(movimiento.cuentaCredito, 1);
                importe = string.Format("{0:#0.00}", Convert.ToDouble(rsLegajos["Neto"]));
                importe = importe.Replace(".", "");
                movimiento.importeDeCredito = importe.PadLeft(15, '0');
                movimiento.beneficiario = Varios.Left(rsLegajos["Apellidos y nombres"].ToString().PadRight(40, ' '), 40);
                movimiento.cuil = Varios.Left(Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["legajo"]), "codigo", 18).ToString().Replace("-", ""), 11);
                movimiento.legajo = Varios.Left(rsLegajos["Legajo"].ToString(), 10).PadLeft(10, '0');
                movimiento.observaciones = "                                                            ";

                if (movimiento.cuentaCredito.Length == 0 || movimiento.controlDeCuenta.Length == 0)
                    MessageBox.Show("ATENCIÓN: el empleado " + movimiento.beneficiario + " no tiene cuenta o banco asignado. No se exportara la liquidación.");
                else
                {
                    //GRABA DETALLE
                    sw.WriteLine(movimiento.tipoCuentaCredito + movimiento.banco + movimiento.sucursalCuentaCredito + movimiento.cuentaCredito + movimiento.controlDeCuenta + movimiento.importeDeCredito + movimiento.beneficiario + movimiento.cuil + movimiento.legajo + movimiento.observaciones);
                    //actualiza liquidacionesEstados
                    for (int i = 0; i < tiposLiquidacionesSeleccionados.Count; i++)
                        Model.DB.ejecutarProceso(Model.TipoComando.SP, "liquidacionesEstadosActualizar", "@idLiquidacion", idliquidacion, "@idTipoLiquidacion", tiposLiquidacionesSeleccionados[i], "@legajo", Convert.ToInt32(rsLegajos["legajo"].ToString()), "@acreditada", true, "fechaAcreditacion", fechaAcreditacion);
                }
            }
            sw.Close();
        }

        public static void generaArchivoDesdeAnticipos(int anioMes, int idTipoAnticipo, string archivo, DateTime fechaAcreditacion, bool todosLosConveios, int idConvenio)
        {
            string importe = "";
            DbDataReader rsLegajos;
            StreamWriter sw = new StreamWriter(archivo);

            //recorrer netos por legajo
            //consultar netos por idliquidacion.
            //repoteLiquidacionesNetoPorLegajo. calcular haberes+adicionales-retenciones
            if (todosLosConveios)
                rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "anticiposConsultarParaAcreditarPorBanco", "@anioMes", anioMes, "@idTipoAnticipo", idTipoAnticipo, "@idBanco", 3);
            else
                rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "anticiposConsultarParaAcreditarPorBancoPorConvenio", "@anioMes", anioMes, "@idTipoAnticipo", idTipoAnticipo, "@idBanco", 3, "@idConvenio", idConvenio);

            while (rsLegajos.Read())  //para cada legajo recorro todos los campos definidos en tablas
            {
                if (Varios.Right(Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["legajo"]), "codigo", 21).ToString(), 1) == "1")
                    movimiento.tipoCuentaCredito = "2";
                else
                    movimiento.tipoCuentaCredito = "1";
                movimiento.sucursalCuentaCredito = Varios.Left(Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["legajo"]), "codigo", 21).ToString().PadLeft(3, '0'), 3);
                movimiento.cuentaCredito = Varios.Left(Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["legajo"]), "codigo", 22).ToString(), 7);
                movimiento.controlDeCuenta = Varios.Right(movimiento.cuentaCredito, 1);
                importe = string.Format("{0:#0.00}", Convert.ToDouble(rsLegajos["Neto"]));
                importe = importe.Replace(".", "");
                movimiento.importeDeCredito = importe.PadLeft(15, '0');
                movimiento.beneficiario = Varios.Left(rsLegajos["Apellidos y nombres"].ToString().PadRight(40, ' '), 40);
                movimiento.cuil = Varios.Left(Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["legajo"]), "codigo", 18).ToString().Replace("-", ""), 11);
                movimiento.legajo = Varios.Left(rsLegajos["Legajo"].ToString(), 10).PadLeft(10, '0');
                movimiento.observaciones = "                                                            ";


                if (movimiento.cuentaCredito.Length == 0 || movimiento.controlDeCuenta.Length == 0)
                    MessageBox.Show("ATENCIÓN: el empleado " + movimiento.beneficiario + " no tiene cuenta o banco asignado. No se exportara la liquidación.");
                else
                {
                    //GRABA DETALLE
                    sw.WriteLine(movimiento.tipoCuentaCredito + movimiento.banco + movimiento.sucursalCuentaCredito + movimiento.cuentaCredito + movimiento.controlDeCuenta + movimiento.importeDeCredito + movimiento.beneficiario + movimiento.cuil + movimiento.legajo + movimiento.observaciones);
                }
            }
            sw.Close();
        }
    }
}
