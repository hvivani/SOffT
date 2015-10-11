/*  
    BancoGalicia.cs

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
using System.Text;
using System.IO;
using System.Data.Common;
using System.Windows.Forms;
using Sofft.Utils;

namespace Sueldos.View
{
    /// <summary>
    /// Clase que define estructura de archivos para acreditacion de sueldos en cuentas
    /// </summary>
    class BancoGalicia
    {

        public const string nombreArchivo = "balcarce-galicia.txt";

        public struct cabecera
        {
            public const string tipoRegistro = "H"; //H:header
            public const string empresas = "52097"; //Código de prestación de la empresa
            public const string tipoCuenta = "0"; //Indica si la cuenta de débito es CC (0) o CA (4)
            public const string folio = "025002"; //Folio de la cuenta de débito
            public const string digito1 = "3"; //Dígito 1 de la cuenta de débito
            public const string sucursal = "083"; //Sucursal de la cuenta de débito
            public const string digito2 = "4"; //Dígito 2 de la cuenta de débito
            public static string importe = "              "; //Importe total del archivo (12 enteros + 2 decimales)
            public static string fecAcred; //Fecha de acreditación
            public const string filler = "                         ";//25
        }

        public struct movimiento
        {
            public const string tipoRegistro = "D"; //D: detalle
            public static string empresas = "52097"; //Código de prestación de la empresa
            public static string tipoCuenta = ""; //0 ctacte - 4 C.A.
            public static string folio = "      "; //Folio de la cuenta de crédito
            public static string digito1; //digito 1 de la cuenta de crédito
            public static string sucursal = ""; //sucursal cuenta credito
            public static string digito2 = ""; //digito 2 de la cuenta de crédito
            public static string nombre = "                    "; //Nombre del titular de la cuenta de crédito
            public static string importe = "              ";//Importe a acreditar (12 enteros + 2 decimales).
            public static string concepto = "  "; //00 si la empresa no manda nada //01 HABERES - 04 SAC
            public const string filler = "           "; //11
        }

        public struct final
        {
            public const string tipoRegistro = "F"; //F:footer
            public const string empresas = "52097"; //Código de prestación de la empresa
            public static string cantRegistros; //Cantidad de registros
            public const string filler = "                                                    ";//52
        }

        /// <summary>
        /// Genera archivo con formato galica. 
        /// </summary>
        /// <param name="idliquidacion"></param>
        /// <param name="archivo"></param>
        /// <param name="esLiquidacionNormal"></param>
        public static void generaArchivo(int idliquidacion, string archivo, List<int> tiposLiquidacionesSeleccionados, DateTime fechaAcreditacion, bool todosLosConveios, int idConvenio)
        {
            //00 si la empresa no manda nada //01 HABERES - 04 SAC - 02 HS EXTRAS - 05 VACACIONES
            /*si el indice 0 es 1, se seleccionó la liquidacion normal.*/
            if (tiposLiquidacionesSeleccionados[0] == 4) //SAC
                movimiento.concepto = "04";
            else
                if (tiposLiquidacionesSeleccionados[0] == 3) // VACACIONES
                    movimiento.concepto = "05";
                else
                    movimiento.concepto = "01"; //HABERES
            string cuenta = "";
            string importe = "";
            int cantRegistros = 0;
            double importeTotal = 0;
            DbDataReader rsLegajos;
            StreamWriter sw = new StreamWriter(archivo);

            //recorro netos para obtener total del archivo. este dato va en cabecera
            if (todosLosConveios)
                rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesNetosPorLegajoPorBanco", "@idLiquidacion", idliquidacion, "@idFormaDePago", 2, "@idBanco", 2);
            else
                rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesNetosPorLegajoPorBancoPorConvenio", "@idLiquidacion", idliquidacion, "@idFormaDePago", 2, "@idBanco", 2, "@idConvenio", idConvenio);

            while (rsLegajos.Read())  //para cada legajo recorro todos los campos definidos en tablas
            {
                importe = string.Format("{0:#0.00}", Convert.ToDouble(rsLegajos["Neto"]));
                importeTotal = importeTotal + Convert.ToDouble(importe);

            }
            cabecera.importe = string.Format("{0:#0.00}", importeTotal).Replace(".", "").PadLeft(14, '0');
            cabecera.fecAcred = Varios.Right(fechaAcreditacion.Year.ToString(), 4) + fechaAcreditacion.Month.ToString().PadLeft(2, '0') + fechaAcreditacion.Day.ToString().PadLeft(2, '0');
            //GRABA CABECERA.
            sw.WriteLine(cabecera.tipoRegistro + cabecera.empresas + cabecera.tipoCuenta + cabecera.folio + cabecera.digito1 + cabecera.sucursal + cabecera.digito2 + cabecera.importe + cabecera.fecAcred + cabecera.filler);

            //recorrer netos por legajo
            //consultar netos por idliquidacion.
            //repoteLiquidacionesNetoPorLegajo. calcular haberes+adicionales-retenciones
            //rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesNetosPorLegajoPorBanco", "@idLiquidacion", idliquidacion, "@idFormaDePago", 2, "@idBanco", 2);
            if (todosLosConveios)
                rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesNetosPorLegajoPorBanco", "@idLiquidacion", idliquidacion, "@idFormaDePago", 2, "@idBanco", 2);
            else
                rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesNetosPorLegajoPorBancoPorConvenio", "@idLiquidacion", idliquidacion, "@idFormaDePago", 2, "@idBanco", 2, "@idConvenio", idConvenio);
            while (rsLegajos.Read())  //para cada legajo recorro todos los campos definidos en tablas
            {
                cantRegistros++;
                movimiento.nombre = Varios.Left(rsLegajos["Apellidos y nombres"].ToString(), 20).PadRight(20, ' ');
                importe = string.Format("{0:#0.00}", Convert.ToDouble(rsLegajos["Neto"]));
                importe = importe.Replace(".", "");
                movimiento.importe = importe.PadLeft(14, '0');
                movimiento.sucursal = Varios.Right(Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["legajo"]), "codigo", 22).ToString(), 4);
                movimiento.digito2 = Varios.Right(movimiento.sucursal, 1);
                movimiento.sucursal = Varios.Left(movimiento.sucursal, 3);
                //movimiento.sucursal = Varios.Right(movimiento.sucursal, 3);
                movimiento.folio = Varios.Left(Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["legajo"]), "codigo", 22).ToString(), 8);
                movimiento.digito1 = Varios.Right(movimiento.folio, 1);
                movimiento.tipoCuenta = Varios.Left(movimiento.folio, 1);
                movimiento.folio = Varios.Right(Varios.Left(movimiento.folio, 7), 6);
                //movimiento.folio = Varios.Right(movimiento.folio, 6);
                //movimiento.digito1 = Varios.Left(movimiento.folio, 1);
                //movimiento.digito2 = Varios.Right( Varios.Left(movimiento.folio, 2),1);
                if (movimiento.folio.Length == 0 || movimiento.sucursal == "0")
                    MessageBox.Show("ATENCIÓN: el empleado " + movimiento.nombre + " no tiene cuenta o banco asignado. No se exportara la liquidación.");
                else
                {
                    //GRABA DETALLE
                    sw.WriteLine(movimiento.tipoRegistro + movimiento.empresas + movimiento.tipoCuenta + movimiento.folio + movimiento.digito1 + movimiento.sucursal + movimiento.digito2 + movimiento.nombre + movimiento.importe + movimiento.concepto + movimiento.filler);
                    //actualiza liquidacionesEstados
                    for (int i = 0; i < tiposLiquidacionesSeleccionados.Count; i++)
                        Model.DB.ejecutarProceso(Model.TipoComando.SP, "liquidacionesEstadosActualizar", "@idLiquidacion", idliquidacion, "@idTipoLiquidacion", tiposLiquidacionesSeleccionados[i], "@legajo", Convert.ToInt32(rsLegajos["legajo"].ToString()), "@acreditada", true, "fechaAcreditacion", fechaAcreditacion);
                }
            }
            final.cantRegistros = cantRegistros.ToString().PadLeft(7, '0');
            //grabar final.
            sw.WriteLine(final.tipoRegistro + final.empresas + final.cantRegistros + final.filler);
            sw.Close();
        }


        public static void generaArchivoDesdeAnticipos(int anioMes, int idTipoAnticipo, string archivo, DateTime fechaAcreditacion, bool todosLosConveios, int idConvenio)
        {
            //00 si la empresa no manda nada //01 HABERES - 04 SAC - 02 HS EXTRAS - 05 VACACIONES
            /*si el indice 0 es 1, se seleccionó la liquidacion normal.*/

            movimiento.concepto = "01"; //HABERES
            string importe = "";
            int cantRegistros = 0;
            double importeTotal = 0;
            DbDataReader rsLegajos;
            StreamWriter sw = new StreamWriter(archivo);

            //recorro netos para obtener total del archivo. este dato va en cabecera
            if (todosLosConveios)
                rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "anticiposConsultarParaAcreditarPorBanco", "@anioMes", anioMes, "@idTipoAnticipo", idTipoAnticipo, "@idBanco", 2);
            else
                rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "anticiposConsultarParaAcreditarPorBancoPorConvenio", "@anioMes", anioMes, "@idTipoAnticipo", idTipoAnticipo, "@idBanco", 2, "@idConvenio", idConvenio);

            while (rsLegajos.Read())  //para cada legajo recorro todos los campos definidos en tablas
            {
                importe = string.Format("{0:#0.00}", Convert.ToDouble(rsLegajos["Neto"]));
                importeTotal = importeTotal + Convert.ToDouble(importe);

            }
            cabecera.importe = string.Format("{0:#0.00}", importeTotal).Replace(".", "").PadLeft(14, '0');
            cabecera.fecAcred = Varios.Right(fechaAcreditacion.Year.ToString(), 4) + fechaAcreditacion.Month.ToString().PadLeft(2, '0') + fechaAcreditacion.Day.ToString().PadLeft(2, '0');
            //GRABA CABECERA.
            sw.WriteLine(cabecera.tipoRegistro + cabecera.empresas + cabecera.tipoCuenta + cabecera.folio + cabecera.digito1 + cabecera.sucursal + cabecera.digito2 + cabecera.importe + cabecera.fecAcred + cabecera.filler);


            //recorrer netos por legajo
            //consultar netos por idliquidacion.
            //repoteLiquidacionesNetoPorLegajo. calcular haberes+adicionales-retenciones
            if (todosLosConveios)
                rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "anticiposConsultarParaAcreditarPorBanco", "@anioMes", anioMes, "@idTipoAnticipo", idTipoAnticipo, "@idBanco", 2);
            else
                rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "anticiposConsultarParaAcreditarPorBancoPorConvenio", "@anioMes", anioMes, "@idTipoAnticipo", idTipoAnticipo, "@idBanco", 2, "@idConvenio", idConvenio);

            while (rsLegajos.Read())  //para cada legajo recorro todos los campos definidos en tablas
            {
                cantRegistros++;
                movimiento.nombre = Varios.Left(rsLegajos["Apellidos y nombres"].ToString(), 20).PadRight(20, ' ');
                importe = string.Format("{0:#0.00}", Convert.ToDouble(rsLegajos["Neto"]));
                importe = importe.Replace(".", "");
                movimiento.importe = importe.PadLeft(14, '0');
                movimiento.sucursal = Varios.Right(Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["legajo"]), "codigo", 22).ToString(), 4);
                movimiento.digito2 = Varios.Right(movimiento.sucursal, 1);
                movimiento.sucursal = Varios.Left(movimiento.sucursal, 3);
                //movimiento.sucursal = Varios.Right(movimiento.sucursal, 3);
                movimiento.folio = Varios.Left(Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["legajo"]), "codigo", 22).ToString(), 8);
                movimiento.digito1 = Varios.Right(movimiento.folio, 1);
                movimiento.tipoCuenta = Varios.Left(movimiento.folio, 1);
                movimiento.folio = Varios.Right(Varios.Left(movimiento.folio, 7), 6);
                //movimiento.folio = Varios.Right(movimiento.folio, 6);
                //movimiento.digito1 = Varios.Left(movimiento.folio, 1);
                //movimiento.digito2 = Varios.Right( Varios.Left(movimiento.folio, 2),1);
                if (movimiento.folio.Length == 0 || movimiento.sucursal == "0")
                    MessageBox.Show("ATENCIÓN: el empleado " + movimiento.nombre + " no tiene cuenta o banco asignado. No se exportara la liquidación.");
                else
                {
                    //GRABA DETALLE
                    sw.WriteLine(movimiento.tipoRegistro + movimiento.empresas + movimiento.tipoCuenta + movimiento.folio + movimiento.digito1 + movimiento.sucursal + movimiento.digito2 + movimiento.nombre + movimiento.importe + movimiento.concepto + movimiento.filler);
                }
            }
            final.cantRegistros = cantRegistros.ToString().PadLeft(7, '0');
            //grabar final.
            sw.WriteLine(final.tipoRegistro + final.empresas + final.cantRegistros + final.filler);
            sw.Close();
        }


        //   public static void generaArchivoDesdeAnticipos(int anioMes, int idTipoAnticipo, string archivo)
        //   {
        /*0082 para sueldo del mes - 0096 para cualquier otra acreditacion (sac/vac/etc)*/
        //       movimiento.codigoDeOperacion = "0096";
        //       string cuenta = "";
        //       string importe = "";
        //       int cantRegistros = 0;
        //       double importeTotal = 0;
        //       StreamWriter sw = new StreamWriter(archivo);
        //grabar cabecera.
        //       cabecera.fechaEmision = System.DateTime.Now.Day.ToString().PadLeft(2, '0') + System.DateTime.Now.Month.ToString().PadLeft(2, '0') + Varios.Right(System.DateTime.Now.Year.ToString(), 2);
        //       cabecera.horaEmision = System.DateTime.Now.Hour.ToString().PadLeft(2, '0') + System.DateTime.Now.Minute.ToString().PadLeft(2, '0');
        //       sw.WriteLine(cabecera.ceros + cabecera.rotuloArchivo + cabecera.numeroCPD + cabecera.fechaEmision + cabecera.horaEmision + cabecera.numeroBanco + cabecera.filler + cabecera.marca);
        //recorrer netos por legajo
        //consultar netos por idliquidacion.
        //repoteLiquidacionesNetoPorLegajo. calcular haberes+adicionales-retenciones
        /*        DbDataReader rsLegajos;
                rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "anticiposConsultarParaAcreditar", "@anioMes", anioMes, "@idTipoAnticipo", idTipoAnticipo);
                while (rsLegajos.Read())  //para cada legajo recorro todos los campos definidos en tablas
                {
                    cantRegistros++;
                    movimiento.legajo = rsLegajos["Legajo"].ToString().PadLeft(8, '0');
                    movimiento.nombreTitular = Varios.Left(rsLegajos["Apellidos y nombres"].ToString(), 22).PadRight(22, ' ');
                    importe = string.Format("{0:#0.00}", Convert.ToDouble(rsLegajos["Neto"]));
                    importeTotal = importeTotal + Convert.ToDouble(importe);
                    importe = importe.Replace(".", "");
                    movimiento.importe = importe.PadLeft(11, '0');
                    movimiento.numeroCasaBeneficiaria = Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["Legajo"]), "codigo", 21).ToString();
                    movimiento.numeroCasaReceptora = movimiento.numeroCasaBeneficiaria;
                    cuenta = Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["Legajo"]), "codigo", 22).ToString();
                    if (cuenta.Length == 0 || movimiento.numeroCasaBeneficiaria == "0")
                        MessageBox.Show("ATENCIÓN: el legajo " + movimiento.legajo + " no tiene cuenta o banco asignado. No se exportara la liquidación.");
                    else
                    {
                        movimiento.numeroCuentaBeneficiaria = Varios.Left(cuenta, cuenta.Length - 1).PadLeft(6, '0');
                        movimiento.digitoVerificador = Varios.Right(Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["Legajo"]), "codigo", 22).ToString(), 1);
                        sw.WriteLine(movimiento.numeroCasaBeneficiaria + movimiento.numeroCasaReceptora + movimiento.codigoDeOperacion + movimiento.indicativoTipoCuenta + movimiento.numeroCuentaBeneficiaria + movimiento.digitoVerificador + movimiento.filler01 + movimiento.importe + movimiento.legajo + movimiento.nombreTitular + movimiento.filler02 + movimiento.marca);
                    }
                }
                //grabar final.
                sw.WriteLine(final.finArchivo + cantRegistros.ToString().PadLeft(6, '0') + string.Format("{0:#0.00}", importeTotal).Replace(".", "").PadLeft(14, '0') + final.filler + final.marca);
                sw.Close();
            }
    */

    }
}
