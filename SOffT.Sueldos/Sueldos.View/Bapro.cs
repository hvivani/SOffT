/*  
    Bapro.cs

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
    class Bapro
    {
        /*                 XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX                     
                     DISE¥O DE ARCHIVO MAGNETICO PARA PAGO DE HABERES               
                                                                                
         SOPORTE:                                                                   
         -------                                                                    
                  - Diskette de 3 1/2 pulgadas.                                     
                                                                                
                  IMPORTANTE: "Deber  emitir un archivo por cada tipo de            
                               moneda o letra, en  soportes  magn‚ticos             
                               separados".                                          
                                                                                
         LONGITUD DEL REGISTRO:                                                     
         ---------------------                                                      
                  - 80 caracteres.                                                  

         ROTULO DEL ARCHIVO:                                                        
         ------------------                                                         
                  - IDHXXX (emitir sin la extensi¢n TXT)                            
                                                                                
         NIVEL DE REGISTROS:                                                        
         ------------------                                                         
                                                                                
                  - I - Registro inicial.                                           
                  - II - Registro de movimientos.                                   
                  - III - Registro final.                                           
                                                                /.                  
                                                                  - 2 -             
                                                                                
                                 DETALLE DE LOS REGISTROS                           
                                 ------------------------                           
                                                                                
                                   I - REGISTRO INICIAL                             
                                   --------------------                             
                                                                                
         ÉÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÑÍÍÍÍÍÍÍÍÍÍÍÍÍÍÑÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ»   
         º               ³              ³                                       º   
         º   NRO. CAMPO  ³  POSICION/ES ³         C  O  N  C  E  P  T  O        º   
         ÌÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍØÍÍÍÍÍÍÍÍÍÍÍÍÍÍØÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ¹   
         º               ³              ³                                       º   
         º               ³              ³                                       º   
         º               ³              ³                                       º   
         º       01      ³    01 a 10   ³ CEROS (indicativo comienzo de archivo)º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º               ³              ³                                       º   
         º       02      ³    11 a 16   ³ ROTULO DEL ARCHIVO:    XXXXX          º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º               ³              ³                                       º   
         º       03      ³    17 a 17   ³ NUMERO DE CPD:  X                     º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º               ³              ³                                       º   
         º       04      ³    18 a 23   ³ FECHA DE EMISION DEL SOPORTE MAGNETICOº   
         º               ³              ³ FORMATO: DDMMAA                       º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º               ³              ³                                       º   
         º       05      ³    24 a 27   ³ HORA DE EMISION DEL SOPORTE MAGNETICO º   
         º               ³              ³ FORMATO: HHMM                         º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º               ³              ³                                       º   
         º       06      ³    28 a 30   ³ NUMERO DE BANCO:  014                 º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º               ³              ³                                       º   
         º       07      ³    31 a 79   ³ FILLER (BLANCOS)                      º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º               ³              ³                                       º   
         º       08      ³    80 a 80   ³ MARCA:  0                             º   
         ÈÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÏÍÍÍÍÍÍÍÍÍÍÍÍÍÍÏÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ¼   
                                                                                
                                                                /.                  
                                                                  - 3 -             
                                                                                
                               II - REGISTRO DE MOVIMIENTOS                         
                               ----------------------------                         
                                                                                
         ÉÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÑÍÍÍÍÍÍÍÍÍÍÍÍÍÍÑÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ»   
         º               ³              ³                                       º   
         º   NRO. CAMPO  ³  POSICION/ES ³         C  O  N  C  E  P  T  O        º   
         ÌÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍØÍÍÍÍÍÍÍÍÍÍÍÍÍÍØÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ¹   
         º               ³              ³                                       º   
         º               ³              ³                                       º   
         º       01      ³    01 a 04   ³ NUMERO DE CASA BENEFICIARIA: (sucursalº   
         º               ³              ³ en donde  se deber  acreditar el      º   
         º               ³              ³ dep¢sito                              º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º       02      ³    05 a 08   ³ NUMERO  DE  CASA  RECEPTORA: constanteº   
         º               ³              ³  XXXX                                 º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º       03      ³    09 a 12   ³ CODIGO  DE  OPERACION:                º   
         º               ³              ³  0082 : movimientos en Pesos          º   
         º               ³              ³  0101 : movimientos en Patacones S1   º   
         º               ³              ³  0102 : movimientos en Patacones S2   º   
         º               ³              ³  0103 : movimientos en Lecop S1       º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º       04      ³    13 a 13   ³ INDICATIVO TIPO DE CUENTA:            º   
         º               ³              ³  1 : Si el c¢digo de operaci¢n es 0082º   
         º               ³              ³  5 : Si los c¢digos de operaci¢n son  º   
         º               ³              ³      101 ¢ 102 ¢ 103.                 º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º       05      ³    14 a 19   ³ NUMERO DE CUENTA BENEFICIARIA         º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º       06      ³    20 a 20   ³ DIGITO VERIFICADOR                    º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º       07      ³    21 a 22   ³ FILLER NUMERICO (INFORMAR CEROS)      º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º       08      ³    23 a 33   ³ IMPORTE (9 enteros y 2 decimales) (SINº   
         º               ³              ³ PUNTOS NI COMAS)                      º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º       09      ³    34 a 41   ³ REFERENCIA NUMERICA (NRO. DE LEGAJO,  º   
         º               ³              ³ AFILIADO, IDENTIFICADOR EMPLEADO, ETC)º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º       10      ³    42 a 63   ³ TITULAR DE LA CUENTA BENEFICIARIA     º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º       11      ³    64 a 79   ³ FILLER (BLANCOS)                      º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º       12      ³    80 a 80   ³ MARCA:  0                             º   
         ÈÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÏÍÍÍÍÍÍÍÍÍÍÍÍÍÍÏÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ¼   
                                                                                
                                                                /.                  
                                                                  - 4 -             
                                                                                
                                   III - REGISTRO FINAL                             
                                   --------------------                             
                                                                                
         ÉÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÑÍÍÍÍÍÍÍÍÍÍÍÍÍÍÑÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ»   
         º               ³              ³                                       º   
         º   NRO.CAMPO   ³  POSICION/ES ³         C  O  N  C  E  P  T  O        º   
         ÌÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍØÍÍÍÍÍÍÍÍÍÍÍÍÍÍØÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ¹   
         º               ³              ³                                       º   
         º               ³              ³                                       º   
         º               ³              ³                                       º   
         º       01      ³    01 a 10   ³  INDICATIVO FIN DE ARCHIVO  (consignarº   
         º               ³              ³  siempre nueves)                      º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º               ³              ³                                       º   
         º       02      ³    11 a 16   ³  CANTIDAD DE REGISTROS  DE MOVIMIENTOSº   
         º               ³              ³  GRABADOS (no incluir inicial y final)º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º               ³              ³                                       º   
         º       03      ³    17 a 30   ³  IMPORTE TOTAL  DE INTERDEPOSITOS  (12º   
         º               ³              ³  enteros y 2 decimales) (SIN PUNTOS NIº   
         º               ³              ³  COMAS)                               º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º               ³              ³                                       º   
         º       04      ³    31 a 79   ³  FILLER (BLANCOS)                     º   
         ÇÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¶   
         º               ³              ³                                       º   
         º       05      ³    80 a 80   ³  MARCA:  0                            º   
         ÈÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÏÍÍÍÍÍÍÍÍÍÍÍÍÍÍÏÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ¼   
                                                                                
         LOS CAMPOS NRO. DE CASA TOMADORA, NRO. DE CASA BENEFICIARIA,  CODIGO  DE   
         OPERACION, NUMERO DE CUENTA  BENEFICIARIA  E  IMPORTE  DEL  REGISTRO  DE   
         MOVIMIENTOS, NO PODRAN SER INFORMADOS CON CEROS.  EN CASO CONTRARIO,       
         NUESTRO SISTEMA RECHAZARA EL ARCHIVO, SIENDO DEVUELTO SIN PROCESAR.        
         LOS CAMPOS NUMERICOS DEBEN CONTENER CEROS A LA IZQUIERDA HASTA COMPLETAR   
         EL CAMPO.                                                                  
                                                                /.                  
                                                                                
                                                                  - 5 -             
                                                                                
                                    LISTADO DE RESPALDO                             
                                    -------------------                             
                                                                                
            Este listado deber   estar  ordenado  por  sucursal  beneficiaria  y por   
            n£mero de cuenta y estar  configurado de la siguiente manera:              
                                                                                
            - LINEA DE TITULOS:                                                        
            * Fecha de proceso.                                                      
            * T¡tulo: "..........(nombre identificatorio del Organismo) ......."     
            * N£mero de hoja.                                                        
                                                                                
            - LINEA DE SUBTITULOS:                                                     
            * Subtitular: SERVICIO DE PAGO DE HABERES                                
                                                                                
            - LINEA DE DETALLE:                                                        
            * N£mero de sucursal beneficiaria.                                       
            * N£mero de cuenta y d¡gito verificador.                                 
            * C¢digo de operaci¢n.                                                   
            * Importe.                                                               
            * Referencia.                                                            
            * Titular de la cuenta beneficiaria.                                     
                                                                                
            - LINEA DE TOTALES:                                                        
                                                                                
            * Total general de movimientos:                                          
             . Cantidad.                                                            
             . Importe.                                                             
                                                                                
            */

        public struct cabecera
        {
            public const string ceros = "0000000000";
            public const string rotuloArchivo = "IDS898";
            public const string numeroCPD = "0";
            public static string fechaEmision; //DDMMAA
            public static string horaEmision; //HHMM
            public const string numeroBanco = "014";
            public const string filler = "                                                 ";
            public const string marca = "0";
        }

        public struct movimiento
        {
            public static string numeroCasaBeneficiaria = "6102";
            public static string numeroCasaReceptora = "6102";
            /*0082 para sueldo del mes - 0096 para cualquier otra acreditacion (sac/vac/etc)*/
            public static string codigoDeOperacion;
            public const string indicativoTipoCuenta = "1";
            public static string numeroCuentaBeneficiaria;
            public static string digitoVerificador;
            public const string filler01 = "00";
            public static string importe;
            public static string legajo;
            public static string nombreTitular;
            public const string filler02 = "                ";
            public const string marca = "0";
        }

        public struct final
        {
            public const string finArchivo = "9999999999";
            //    public static string cantidadRegistrosMovimientos;
            //    public static string  importeTotalInterdepositos;
            public const string filler = "                                                 ";
            public const string marca = "0";
        }

        /// <summary>
        /// Genera archivo con formato bapro. 
        /// Si es liquidacion normal codigo operación:0082
        /// Si es liquidacion vac o sac u otro codigo operación:0096 
        /// </summary>
        /// <param name="idliquidacion"></param>
        /// <param name="archivo"></param>
        /// <param name="esLiquidacionNormal"></param>
        public static void generaArchivo(int idliquidacion, string archivo, List<int> tiposLiquidacionesSeleccionados, DateTime fechaAcreditacion, bool todosLosConveios, int idConvenio)
        {
            /*0082 para sueldo del mes - 0096 para cualquier otra acreditacion (sac/vac/etc)*/
            /*si el indice 0 es 1, se seleccionó la liquidacion normal.*/
            if (tiposLiquidacionesSeleccionados[0] == 1)
                movimiento.codigoDeOperacion = "0082";
            else
                movimiento.codigoDeOperacion = "0096";
            string cuenta = "";
            string importe = "";
            int cantRegistros = 0;
            double importeTotal = 0;
            StreamWriter sw = new StreamWriter(archivo);
            //grabar cabecera.
            cabecera.fechaEmision = System.DateTime.Now.Day.ToString().PadLeft(2, '0') + System.DateTime.Now.Month.ToString().PadLeft(2, '0') + Varios.Right(System.DateTime.Now.Year.ToString(), 2);
            cabecera.horaEmision = System.DateTime.Now.Hour.ToString().PadLeft(2, '0') + System.DateTime.Now.Minute.ToString().PadLeft(2, '0');
            sw.WriteLine(cabecera.ceros + cabecera.rotuloArchivo + cabecera.numeroCPD + cabecera.fechaEmision + cabecera.horaEmision + cabecera.numeroBanco + cabecera.filler + cabecera.marca);
            //recorrer netos por legajo
            //consultar netos por idliquidacion.
            //repoteLiquidacionesNetoPorLegajo. calcular haberes+adicionales-retenciones
            DbDataReader rsLegajos;
            if (todosLosConveios)
                rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesNetosPorLegajoPorBanco", "@idLiquidacion", idliquidacion, "@idFormaDePago", 2, "@idBanco", 1);
            else
                rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesNetosPorLegajoPorBancoPorConvenio", "@idLiquidacion", idliquidacion, "@idFormaDePago", 2, "@idBanco", 1, "@idConvenio", idConvenio);

            while (rsLegajos.Read())  //para cada legajo recorro todos los campos definidos en tablas
            {
                cantRegistros++;
                movimiento.legajo = rsLegajos["legajo"].ToString().PadLeft(8, '0');
                movimiento.nombreTitular = Varios.Left(rsLegajos["Apellidos y nombres"].ToString(), 22).PadRight(22, ' ');
                //importe = string.Format("{0:#0.00}", Convert.ToDouble(rsLegajos["Haberes"]) + Convert.ToDouble(rsLegajos["Adicionales"]) - Convert.ToDouble(rsLegajos["retenciones"]));
                importe = string.Format("{0:#0.00}", Convert.ToDouble(rsLegajos["Neto"]));
                importeTotal = importeTotal + Convert.ToDouble(importe);
                importe = importe.Replace(".", "");
                movimiento.importe = importe.PadLeft(11, '0');
                movimiento.numeroCasaBeneficiaria = Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["legajo"]), "codigo", 21).ToString();
                movimiento.numeroCasaReceptora = movimiento.numeroCasaBeneficiaria;
                cuenta = Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["legajo"]), "codigo", 22).ToString();
                if (cuenta.Length == 0 || movimiento.numeroCasaBeneficiaria == "0")
                    MessageBox.Show("ATENCIÓN: el legajo " + movimiento.legajo + " no tiene cuenta o banco asignado. No se exportara la liquidación.");
                else
                {
                    movimiento.numeroCuentaBeneficiaria = Varios.Left(cuenta, cuenta.Length - 1).PadLeft(6, '0');
                    movimiento.digitoVerificador = Varios.Right(Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["legajo"]), "codigo", 22).ToString(), 1);
                    sw.WriteLine(movimiento.numeroCasaBeneficiaria + movimiento.numeroCasaReceptora + movimiento.codigoDeOperacion + movimiento.indicativoTipoCuenta + movimiento.numeroCuentaBeneficiaria + movimiento.digitoVerificador + movimiento.filler01 + movimiento.importe + movimiento.legajo + movimiento.nombreTitular + movimiento.filler02 + movimiento.marca);
                    //actualiza liquidacionesEstados
                    for (int i = 0; i < tiposLiquidacionesSeleccionados.Count; i++)
                        Model.DB.ejecutarProceso(Model.TipoComando.SP, "liquidacionesEstadosActualizar", "@idLiquidacion", idliquidacion, "@idTipoLiquidacion", tiposLiquidacionesSeleccionados[i], "@legajo", Convert.ToInt32(movimiento.legajo), "@acreditada", true, "fechaAcreditacion", fechaAcreditacion);
                }
            }
            //grabar final.
            sw.WriteLine(final.finArchivo + cantRegistros.ToString().PadLeft(6, '0') + string.Format("{0:#0.00}", importeTotal).Replace(".", "").PadLeft(14, '0') + final.filler + final.marca);
            sw.Close();
        }

        public static void generaArchivoDesdeAnticipos(int anioMes, int idTipoAnticipo, string archivo, bool todosLosConveios, int idConvenio)
        {
            /*0082 para sueldo del mes - 0096 para cualquier otra acreditacion (sac/vac/etc)*/
            movimiento.codigoDeOperacion = "0096";
            string cuenta = "";
            string importe = "";
            int cantRegistros = 0;
            double importeTotal = 0;
            StreamWriter sw = new StreamWriter(archivo);
            //grabar cabecera.
            cabecera.fechaEmision = System.DateTime.Now.Day.ToString().PadLeft(2, '0') + System.DateTime.Now.Month.ToString().PadLeft(2, '0') + Varios.Right(System.DateTime.Now.Year.ToString(), 2);
            cabecera.horaEmision = System.DateTime.Now.Hour.ToString().PadLeft(2, '0') + System.DateTime.Now.Minute.ToString().PadLeft(2, '0');
            sw.WriteLine(cabecera.ceros + cabecera.rotuloArchivo + cabecera.numeroCPD + cabecera.fechaEmision + cabecera.horaEmision + cabecera.numeroBanco + cabecera.filler + cabecera.marca);
            //recorrer netos por legajo
            //consultar netos por idliquidacion.
            //repoteLiquidacionesNetoPorLegajo. calcular haberes+adicionales-retenciones
            DbDataReader rsLegajos;
            if (todosLosConveios)
                rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "anticiposConsultarParaAcreditarPorBanco", "@anioMes", anioMes, "@idTipoAnticipo", idTipoAnticipo, "@idBanco", 1);
            else
                rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "anticiposConsultarParaAcreditarPorBancoPorConvenio", "@anioMes", anioMes, "@idTipoAnticipo", idTipoAnticipo, "@idBanco", 1, "@idConvenio", idConvenio);

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
    }
}
