/*  
    Calculo.cs

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
using System.Data.Common;
using System.Windows.Forms;
using Sofft.Utils;

namespace Sueldos.View
{
    class Calculo
    {

        private static int idTabla;  //idTabla en calculo 
        private static int legajo;   //legajo que se esta liquidando
        private static int salto;   //OrdPro a saltar en calculo
        private static int anioMes;  //AnioMes a liquidar
        private static double[] acu;  //arreglo de acumuladores
        private static double[] var; //arreglo de variables
        private static double imprime;
        private static double imprimeCantidad;
        private static double imprimeValorUnitario;
        private static int idAplicacion;
        private static int idLiquidacion;
        private static int idTipoLiquidacion; //normal/vacaciones/etc



        public static int IdTabla
        {
            get { return idTabla; }
            set { idTabla = value; }
        }

        public static int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public static int Salto
        {
            get { return salto; }
            set { salto = value; }
        }

        public static int AnioMes
        {
            get { return anioMes; }
            set { anioMes = value; }
        }

        public static int IdAplicacion
        {
            get { return idAplicacion; }
            set { idAplicacion = value; }
        }

        public static int IdLiquidacion
        {
            get { return idLiquidacion; }
            set { idLiquidacion = value; }
        }

        private void inicializaACUs()
        {
            acu.Initialize();
        }

        private void inicializaVARs()
        {
            var.Initialize();
        }

        /// <summary>
        /// actualiza tabla verificando si es una tabla de la db
        /// o de la tabla tablas.
        /// la tabla debe llamarse nombretablaActualizar
        /// </summary>
        /// <param name="nombreTabla"></param>
        /// <param name="codigo"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
        public double actualizarTabla(string nombreTabla, int codigo, string valor)
        {
            //consulto identidad
            byte identidad = 0;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP,"tablasConsultarContenidoyDetalle", "@tabla", nombreTabla, "@indice", codigo);
            if (rs.Read())
                identidad = Convert.ToByte(rs["identidad"]);
            Model.DB.desconectarDB();
            //si es tabla con historico
            if (identidad == 2)
                Model.DB.ejecutarProceso(Model.TipoComando.SP, nombreTabla + "Actualizar", "@AnioMes", Calculo.AnioMes, "@Indice", idTabla, "@Legajo", Calculo.Legajo, "@Codigo", codigo, "@valor", valor);
            return 0;
        }

        /// <summary>
        /// actualiza la tabla de campos historicos de empleados 
        /// dado el codigo, lo copia de la tabla de empleados
        /// y lo almacena en empleadosHistoricoLiquidacion
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public int actualizarHistoricoEmpleado(int codigo)
        {
            Model.DB.ejecutarProceso(Model.TipoComando.SP, "empleadosHistoricoLiquidacionActualizaDesdeEmpleado", "@idLiquidacion", Calculo.idLiquidacion, "@legajo", Calculo.legajo, "@codigo", codigo);
            return 0;
        }

        /// <summary>
        /// devuelve un valor numerico con un numero de decimales dados.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="dec"></param>
        /// <returns></returns>
        public string decimales(string valor, int dec)
        {
            string cad = "{0:#0.";
            for (int i=0; i < dec; i++)
                cad = cad + '0';
            cad=cad + '}';
            return string.Format(cad,this.Redondear(Convert.ToDouble(valor),dec));

        }

        /// <summary>
        /// Consulta cantidad de familiares para un legajo con un determinado
        /// parentesco
        /// </summary>
        /// <param name="idParentesco"></param>
        /// <returns></returns>
        public double familiaresConsultarCantidad(int idParentesco)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP,"familiaresConsultarCantidadPorParentesco", "@Legajo", Calculo.Legajo, "@idParentesco", idParentesco);
            if (rs.Read())
                salida = Convert.ToDouble(rs["cantidad"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        /// <summary>
        /// consulta importe de anticipos a descontar.
        /// </summary>
        /// <returns></returns>
        public double anticiposConsultarImporte()
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "anticiposConsultarParaLiquidacion", "@Legajo", Calculo.Legajo, "@anioMes", Calculo.AnioMes );
            if (rs.Read())
                salida = Convert.ToDouble(rs["importe"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        public double anticiposConsultarImportePorTipo(int tipo)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "anticiposConsultarParaLiquidacionPorTipo", "@Legajo", Calculo.Legajo, "@anioMes", Calculo.AnioMes, "@idTipoAnticipo", tipo);
            if (rs.Read())
                salida = Convert.ToDouble(rs["importe"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }



        /// <summary>
        /// acumula en acumulador acu[]
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="indice"></param>
        public double acumular(double valor, int indice)
        {
            acu[indice] = acu[indice] + valor;
            Console.WriteLine("     ACU[" + indice + "]=" + valor.ToString());
            return valor;
        }
        
        /// <summary>
        ///  guarda el valor en variable var[] no cumula
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="indice"></param>
        public double guardar(double valor, int indice)
        {
            var[indice] = valor;
            Console.WriteLine("     VAR[" + indice + "]=" + valor.ToString());
            return valor;
        }

        public double potencia(double Base, double exponente)
        {
            double result = 0;
            result = Math.Pow(Base, exponente);
            return result;
        }

        /// <summary>
        /// guarda en acumulados
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="indice"></param>
        /// <returns></returns>
        public double guardarEnAcumulado(double valor, int indice)
        {
            Model.DB.ejecutarProceso(Model.TipoComando.SP, "acumuladosActualizar", "@AnioMes", Calculo.AnioMes, "@Indice", idTabla, "@Legajo", Calculo.Legajo, "@Codigo", indice, "@Valor", valor);
            return valor;
        }

        /// <summary>
        /// consulta valor almacenado en acumulado
        /// </summary>
        /// <param name="indice"></param>
        /// <returns></returns>
        public double acumuladoEmpleado(int indice)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP ,"acumuladosConsultar", "@AnioMes", Calculo.AnioMes , "@Indice", idTabla, "@Legajo", Calculo.Legajo, "@Codigo", indice);
            if (rs.Read())
                salida = Convert.ToDouble(rs["Valor"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        /// <summary>
        /// Obtiene el importe total liquidado de un concepto dado.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public double totalConceptoImporte(int codigo)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP , "liquidacionesConsultarConcepto", "@idLiquidacion", Calculo.IdLiquidacion  ,"@Legajo", Calculo.Legajo, "@Codigo", codigo);
            if (rs.Read())
                salida = Convert.ToDouble(rs["Importe"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        /// <summary>
        /// Consulta el importe total liquidado para un concepto de acuerdo al tipo de liquidacion.
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public double totalConceptoImportePorTipo(int codigo, int tipo)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesConsultarConceptoPorTipo", "@idLiquidacion", Calculo.IdLiquidacion, "@idTipoLiquidacion",tipo ,"@Legajo", Calculo.Legajo, "@Codigo", codigo);
            if (rs.Read())
                salida = Convert.ToDouble(rs["Importe"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }


        public double totalConceptoImporteMes(int codigo)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesConsultarConceptoAnioMes", "@anioMes", Calculo.AnioMes, "@Legajo", Calculo.Legajo, "@Codigo", codigo);
            if (rs.Read())
                salida = Convert.ToDouble(rs["Importe"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        public double totalConceptoImporteAnioMes(int codigo, int AnioMes)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesConsultarConceptoAnioMes", "@anioMes", AnioMes , "@Legajo", Calculo.Legajo, "@Codigo", codigo);
            if (rs.Read())
                salida = Convert.ToDouble(rs["Importe"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        public double totalConceptoHaberImporteMes(int codigo)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesConsultarConceptoAnioMesPosicion", "@anioMes", Calculo.AnioMes, "@Legajo", Calculo.Legajo, "@Codigo", codigo, "@posicion", 1);
            if (rs.Read())
                salida = Convert.ToDouble(rs["Importe"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        public double totalConceptoAdicionalImporteMes(int codigo)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesConsultarConceptoAnioMesPosicion", "@anioMes", Calculo.AnioMes, "@Legajo", Calculo.Legajo, "@Codigo", codigo, "@posicion", 3);
            if (rs.Read())
                salida = Convert.ToDouble(rs["Importe"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        
        public double totalConceptoHaberCantidadMes(int codigo)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesConsultarConceptoAnioMesPosicion", "@anioMes", Calculo.AnioMes, "@Legajo", Calculo.Legajo, "@Codigo", codigo, "@posicion", 1);
            if (rs.Read())
                salida = Convert.ToDouble(rs["Cantidad"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        /// <summary>
        /// consulta el mayor acumulado entre fechas
        /// </summary>
        /// <param name="indice"></param>
        /// <param name="fDesde"></param>
        /// <param name="fHasta"></param>
        /// <returns></returns>
        public double acumuladoMayorEntreFechas(int codigo, DateTime fDesde, DateTime fHasta)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP,"acumuladosConsultarMayorEntreFechas", "@legajo", Calculo.Legajo , "@codigo", codigo, "@fDesde", fDesde , "@fHasta", fHasta);
            if (rs.Read())
                salida = Convert.ToDouble(rs["Valor"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }
        

        /// <summary>
        /// devuelve el contenido de una variable
        /// </summary>
        /// <param name="indice"></param>
        /// <returns></returns>
        public double variable(int indice)
        {
            return var[indice];
        }

        /// <summary>
        /// devuelve el contenido de un acumulador
        /// </summary>
        /// <param name="indice"></param>
        /// <returns></returns>
        public double acumulador(int indice)
        {
            return acu[indice];
        }

        /// <summary>
        /// consulta tablas en tablas
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="indice"></param>
        /// <returns></returns>
        public double tablas(string tabla, int indice)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP ,"tablasConsultarContenidoYdetalle", "@tabla", tabla, "@indice", indice);
            if (rs.Read())
                salida = Convert.ToDouble(rs["Contenido"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        /// <summary>
        /// busca en tablas un importe en la columna detalle, comprendido en el rango delimitado por indice y contenido
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
        public double buscarImporte(string tabla, double valor)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "tablasBuscarImporteEntreRangos", "@tabla", tabla, "@valor", valor);
            if (rs.Read())
                salida = Convert.ToDouble(rs["detalle"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }


        /// <summary>
        /// busca un determinado valor comprendido entre los campos contenido y detalle, aplicando un coeficiente (dividiendo) los campos 
        /// contenido y detalle y devuelve el campo detalle.
        /// Este metodo es explicito para ganancias. Habría que trabajarlo un poco mas.
        /// Se realiza acá el pasaje de coeficientes para no aumentar la complejidad en 
        /// las formulas.
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
        public double buscarValorCoeficiente(string tabla, double valor)
        {
            /////campo utilizado para enviar el mes de liquidacion al sp. (mes + 1 para ganancias)
            int mm = 0;
            if (mesLiquidacion() < 12)
                mm = mesLiquidacion() + 1;
            else
                mm = 1;
            /////
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "tablasBuscarValorCoeficiente", "@tabla", tabla, "@valor", valor, "@coeficiente", 12, "@mesLiquidacion", mm);
            if (rs.Read())
                salida = Convert.ToDouble(rs["detalle"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        /// <summary>
        /// busca un determinado valor comprendido entre los campos contenido y detalle, y devuelve el campo detalle.
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
        public double buscarValor(string tabla, double valor)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "tablasBuscarValor", "@tabla", tabla, "@valor", valor);
            if (rs.Read())
                salida = Convert.ToDouble(rs["detalle"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }


        /// <summary>
        /// busca un determinado valor comprendido entre los campos contenido y detalle, aplicando un coeficiente (dividiendo) los campos 
        /// contenido y detalle y devuelve el campo indice dividido el coeficiente.
        /// Este metodo es explicito para ganancias. Habría que trabajarlo un poco mas.
        /// Se realiza acá el pasaje de coeficientes para no aumentar la complejidad en 
        /// las formulas.
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
        public double buscarIndiceCoeficiente(string tabla, double valor)
        {
            /////campo utilizado para enviar el mes de liquidacion al sp. (mes + 1 para ganancias)
            int mm=0;
            if (mesLiquidacion() < 12)
                mm = mesLiquidacion() + 1;
            else
                mm = 1;
            /////
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "tablasBuscarIndiceCoeficiente", "@tabla", tabla, "@valor", valor, "@coeficiente", 12, "@mesLiquidacion", mm);
            if (rs.Read())
                salida = Convert.ToDouble(rs["indice"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        /// <summary>
        /// consulta acumulados entre rango de anios mes
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
        public double acumuladosEntreRangos(int anioMesDesde, int anioMesHasta, int codigo)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "acumuladosConsultarEntreRangos", "@anioMesDesde", anioMesDesde, "@anioMesHasta", anioMesHasta, "@legajo", Calculo.legajo , "@codigo", codigo);
            if (rs.Read())
                salida = Convert.ToDouble(rs["valor"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        /// <summary>
        /// consulta acumulados del ultimo anio desde mes actual - 1
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
        public double acumuladosUltimoAnio(int codigo)
        {
            double salida;
            int anioMesDesde = 0;
            int anioMesHasta = 0;
            //armo aniomesdesde y aniomeshasta
            if (mesLiquidacion() == 1)
            {
                anioMesDesde = Int32.Parse(ArmaAnioMes(anioLiquidacion() - 1, 1));
                anioMesHasta = Int32.Parse(ArmaAnioMes(anioLiquidacion() - 1, 12));
            }
            else
            {
                anioMesDesde = Int32.Parse(ArmaAnioMes(anioLiquidacion() - 1, byte.Parse((mesLiquidacion() ).ToString())));
                anioMesHasta = Int32.Parse(ArmaAnioMes(anioLiquidacion(), byte.Parse((mesLiquidacion() - 1).ToString())));
            }
            //consulto
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "acumuladosConsultarEntreRangos", "@anioMesDesde", anioMesDesde, "@anioMesHasta", anioMesHasta, "@legajo", Calculo.legajo, "@codigo", codigo);
            if (rs.Read())
                salida = Convert.ToDouble(rs["valor"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        
        /// <summary>
        /// Sigue tablas de calculo.
        /// </summary>
        /// <param name="idT"></param>
        /// <param name="idAplicacion"></param>
        public static void sigueCalculo(int idT,int idTipoLiquidacion, Boolean reciboSeparado)
        {
            acu = new double[61];
            var = new double[61];
          //  inicializaACUs();
          //  inicializaVARs();
            Calculo.idTipoLiquidacion = idTipoLiquidacion;
            Console.WriteLine("Tabla: " + idT.ToString() + " idTipoLiquidacion: " + idTipoLiquidacion.ToString() + " reciboSeparado: " + reciboSeparado.ToString() );
            if (Calculo.AnioMes == 0 || Calculo.Legajo == 0)
                MessageBox.Show("No se puede seguir el calculo, no se ha seteado AnioMes o Legajo.");

            IdTabla = idT;      //este valor viene del tablas: calculo
            Eval3.Evaluator ev = new Eval3.Evaluator(Eval3.eParserSyntax.cSharp , false);
            ev.AddEnvironmentFunctions(new Calculo());
            salto = 0;
            double salida=0;    //contiene el id de la linea a saltar
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "calculoConsultarParaLiquidar", "@idCalculo", IdTabla, "@OrdenProceso", 0, "@idAplicacion", IdAplicacion, "@idTipoLiquidacion", idTipoLiquidacion, "@reciboSeparado", reciboSeparado, "@idLiquidacion", IdLiquidacion);
            while (rs.Read())
            {
                //if (Convert.ToInt32(rs["OrdPro"]) == 91)
                Console.WriteLine("Concepto: " + rs["OrdenProceso"].ToString());
                if (salto == 0)
                {
                    try
                    {
                        salida = Convert.ToDouble(ev.Parse(rs["Formula"].ToString()).value);
                        Console.WriteLine("salida: " + salida.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("OrdenProceso: " + Convert.ToInt32(rs["OrdenProceso"].ToString()) + " " + (ex.Message + "\r\n"));
                    }

                    if (Convert.ToInt32(rs["ImprimeCantidad"]) == 1 && var[58] > 0)
                    {
                        Console.WriteLine("var[58]: " + var[58].ToString());
                        imprimeCantidad = var[58];
                        var[58] = 0;
                    }
                    else
                        imprimeCantidad = 0;
                    if (Convert.ToInt32(rs["ImprimeVU"]) == 1 && var[59] > 0)
                    {
                        Console.WriteLine("var[59]: " + var[59].ToString());
                        imprimeValorUnitario = var[59];
                        var[59] = 0;
                    }
                    else
                        imprimeValorUnitario = 0;
                    
                    if (Convert.ToInt32(rs["Imprime"]) == 1 && salida != 0)
                    {
                        imprime = salida;
                        Model.DB.ejecutarProceso(Model.TipoComando.SP, "liquidacionesInsertar", "@idLiquidacion", Calculo.IdLiquidacion, "@idTipoLiquidacion", idTipoLiquidacion, "@Legajo", Calculo.Legajo, "@Codigo", Convert.ToInt32(rs["Codigo"]), "@AnioMes", Calculo.AnioMes, "@idCalculo", idTabla, "idAplicacion", Calculo.IdAplicacion, "@Posicion", Convert.ToInt32(rs["Tipo"]), "@Cantidad", imprimeCantidad, "@VU", imprimeValorUnitario, "@Importe", imprime, "@Letra", "", "@OrdenProceso", Convert.ToInt32(rs["OrdenProceso"]));
                        //DB.ejecutarSpScalarInt("liquidacionesInsertar", "@AnioMes", Calculo.AnioMes , "@Indice", idTabla, "@Legajo", Calculo.Legajo , "@Codigo", Convert.ToInt32(rs["Codigo"]), "@Pos", Convert.ToInt32(rs["Tipo"]), "@Cant", imprimeCantidad, "@VU", imprimeValorUnitario, "@Importe", imprime, "@Letra", "", "@OrdPro", Convert.ToInt32(rs["OrdPro"]),"@idAplicacion",Calculo.IdAplicacion, "@idLiquidacion", Calculo.IdLiquidacion );
                        imprimeCantidad = 0;
                        imprimeValorUnitario = 0;
                    }
                }
                else
                {
                    if (salto > 0)
                    {
                        Console.WriteLine("salto: " + salto.ToString());
                        rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "calculoConsultarParaLiquidar", "@idCalculo", IdTabla, "@OrdenProceso", salto, "@idAplicacion", IdAplicacion, "@idTipoLiquidacion", idTipoLiquidacion, "@reciboSeparado", reciboSeparado, "@idLiquidacion", IdLiquidacion); 
                        salto = 0;
                    }
                    else
                    {
                        //error
                    }
                }
            }
            Model.DB.desconectarDB();
        }


        public int saltar(int codigo) { Salto=codigo; return 0;}

        public int seguir() { return 0; }


        public double Redondear(double num, int decimales)
        {
            return System.Math.Round( num,decimales);
            
        }

        /// <summary>
        /// Obtiene el valor del campo del maestro del empleado a
        /// partir del codigo de campo
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public double campoEmpleado(int codigo)
        {
            string cad;
            cad = (string)Model.DB.ejecutarScalar(Model.TipoComando.SP,"empleadosSueldosConsultarValorLegajo", "@legajo", Calculo.Legajo  , "@codigo", codigo);
            if (cad != null)
                return Convert.ToDouble(cad);
            else
                return 0;
        }

        public double actualizarCampoEmpleado(int codigo, double valor)
        {
            Model.DB.ejecutarProceso(Model.TipoComando.SP, "empleadosSueldosActualizar", "@legajo", Calculo.Legajo, "@codigo", codigo, "@valor", valor);
            return valor;
        }


     /*   public double actualizarAsiento(int cuenta, double debe, double haber)
        {
            Model.DB.ejecutarProceso(Model.TipoComando.SP, "asientosDeSueldosActualizar", "@idLiquidacion",Calculo.IdLiquidacion , "@anioMes",Calculo.AnioMes, "@legajo", Calculo.Legajo, "@idCuenta", cuenta, "@debe", debe, "@haber", haber);
            return 0;
        }*/

        public double actualizarDebeAsiento(int cuenta, double debe)
        {
            if (cuenta == 935 && Calculo.legajo==459)
                Console.WriteLine("estoy");
            if (double.IsNaN(debe)) //para los casos en que venga un NaN o infinito
                debe = 0;
            Model.DB.ejecutarProceso(Model.TipoComando.SP, "asientosDeSueldosActualizar", "@idLiquidacion", Calculo.IdLiquidacion, "@anioMes", Calculo.AnioMes, "@legajo", Calculo.Legajo, "@idCuenta", cuenta, "@debe", debe, "@haber", 0);
            return debe;
        }

        public double actualizarHaberAsiento(int cuenta, double haber)
        {
            if (double.IsNaN(haber)) //para los casos en que venga un NaN o infinito
                haber = 0;
            Model.DB.ejecutarProceso(Model.TipoComando.SP, "asientosDeSueldosActualizar", "@idLiquidacion", Calculo.IdLiquidacion, "@anioMes", Calculo.AnioMes, "@legajo", Calculo.Legajo, "@idCuenta", cuenta, "@debe", 0, "@haber", haber);
            return haber;
        }

        public double novedadEmpleado(int codigo)
        {
            string cad;
            cad = (string)Model.DB.ejecutarScalar(Model.TipoComando.SP, "novedadesConsultarValorLegajo", "@idLiquidacion", Calculo.idLiquidacion, "@legajo", Calculo.Legajo, "@codigo", codigo);
            if (cad != null)
                return Convert.ToDouble(cad);
            else
                return 0;
        }

        public double asistenciaEmpleado(int codigo)
        {
            string cad;
            cad = Model.DB.ejecutarScalar(Model.TipoComando.SP,"asistenciaConsultarLegajoCodigo", "@AnioMes", Calculo.AnioMes,  "@legajo", Calculo.Legajo, "@codigo", codigo).ToString();
            if (cad != "")
                return Convert.ToDouble(cad);
            else
                return 0;
        }

        /// <summary>
        /// Consulta la cantidad de dias de asistencia para un empleado entre fechas para un codigo especifico. 
        /// Por ej. asistenciaConsultarLegajoEntreDias(200801,151,1,15)*/
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="desde"></param>
        /// <param name="hasta"></param>
        /// <returns></returns>
        public double asistenciaEmpleadoEntreDias(int codigo,int desde, int hasta)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP,"asistenciaConsultarLegajoEntreDias", "@AnioMes", Calculo.AnioMes, "@legajo", Calculo.Legajo, "@codigo", codigo, "@diaDesde", desde, "@diaHasta", hasta);
            if (rs.Read())
                salida = Convert.ToDouble(rs["cantidad"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
       } 

        /// <summary>
        /// Calcula la suma total de haberes dado un idLiquidacion
        /// </summary>
        /// <returns></returns>
        public double totalHaberes()
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesConsultarTotalPosicion", "@idLiquidacion", Calculo.IdLiquidacion, "@idTipoLiquidacion" ,Calculo.idTipoLiquidacion ,"@legajo", Calculo.Legajo, "@posicion", 1);

            if (rs.Read())
                salida = Convert.ToDouble(rs["total"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        public double totalHaberesMesPorTipo(int tipo)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesConsultarTotalPosicionTipoMes", "@anioMes", Calculo.AnioMes, "@idTipoLiquidacion", tipo, "@legajo", Calculo.Legajo, "@posicion", 1, "@idAplicacion",Calculo.IdAplicacion);
            if (rs.Read())
                salida = Convert.ToDouble(rs["importe"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        public double totalAdicionalesMesPorTipo(int tipo)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesConsultarTotalPosicionTipoMes", "@anioMes", Calculo.AnioMes, "@idTipoLiquidacion", tipo, "@legajo", Calculo.Legajo, "@posicion", 3, "@idAplicacion", Calculo.IdAplicacion);
            if (rs.Read())
                salida = Convert.ToDouble(rs["importe"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        public double totalRetencionesMesPorTipo(int tipo)
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesConsultarTotalPosicionTipoMes", "@anioMes", Calculo.AnioMes, "@idTipoLiquidacion", tipo, "@legajo", Calculo.Legajo, "@posicion", 2, "@idAplicacion", Calculo.IdAplicacion);
            if (rs.Read())
                salida = Convert.ToDouble(rs["importe"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        /// <summary>
        /// Calcula la suma total de haberes dado un AnioMes de Liquidacion
        /// </summary>
        /// <returns></returns>
        public double totalHaberesMes()
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesConsultarTotalPosicionAnioMes", "@anioMes", Calculo.AnioMes, "@legajo", Calculo.Legajo, "@posicion", 1);
            if (rs.Read())
                salida = Convert.ToDouble(rs["total"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }



        public double totalAdicionales()
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesConsultarTotalPosicion", "@idLiquidacion", Calculo.IdLiquidacion, "@idTipoLiquidacion" ,Calculo.idTipoLiquidacion, "@legajo", Calculo.Legajo, "@posicion", 3);
            if (rs.Read())
                salida = Convert.ToDouble(rs["total"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }


        public double totalAdicionalesMes()
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesConsultarTotalPosicionAnioMes", "@anioMes", Calculo.AnioMes, "@legajo", Calculo.Legajo, "@posicion", 3);
            if (rs.Read())
                salida = Convert.ToDouble(rs["total"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }


        public double totalRetenciones()
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesConsultarTotalPosicion", "@idLiquidacion", Calculo.IdLiquidacion, "@idTipoLiquidacion" ,Calculo.idTipoLiquidacion, "@legajo", Calculo.Legajo, "@posicion", 2);
            if (rs.Read())
                salida = Convert.ToDouble(rs["total"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        public double totalRetencionesMes()
        {
            double salida;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesConsultarTotalPosicionAnioMes", "@anioMes", Calculo.anioMes, "@legajo", Calculo.Legajo, "@posicion", 2);
            if (rs.Read())
                salida = Convert.ToDouble(rs["total"]);
            else
                salida = 0;
            Model.DB.desconectarDB();
            return salida;
        }

        /// <summary>
        /// consulta la existencia de un codigo de situacion de revista
        /// en la asistencia pasandole el numero de ocurrencia a consultar
        /// es decir, si es la 1ra, la 2da, etc. 
        /// devuelve el codigo de asistencia de dicha ocurrencia
        /// </summary>
        /// <param name="ocurencia"></param>
        /// <returns></returns>
        public double codigoSituacionDeRevista(int ocurrencia)
        {
            double salida = 0;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "asistenciaConsultarOcurrenciaSituacionDeRevista", "@legajo", Calculo.Legajo, "@anioMes", Calculo.AnioMes, "@ocurrencia", ocurrencia);
            if (rs.Read()) //este recorrido se supone realizarse siempre sobre 3 o cuatro registros
                salida = Convert.ToDouble(rs["codigo"]);
            Model.DB.desconectarDB();
            return salida;
        }


        /// <summary>
        /// consulta el dia de inicio de un codigo de situacion de revista
        /// en la asistencia pasandole el numero de ocurrencia a consultar
        /// es decir, si es la 1ra, la 2da, etc. 
        /// devuelve el codigo de asistencia de dicha ocurrencia
        /// </summary>
        /// <param name="ocurencia"></param>
        /// <returns></returns>
        public double diaInicioSituacionDeRevista(int ocurrencia)
        {
            double salida = 0;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "asistenciaConsultarOcurrenciaSituacionDeRevista", "@legajo", Calculo.Legajo, "@anioMes", Calculo.AnioMes, "@ocurrencia", ocurrencia);
            if (rs.Read()) //este recorrido se supone realizarse siempre sobre 3 o cuatro registros
                salida = Convert.ToDouble(rs["DiaInicio"]);
            Model.DB.desconectarDB();
            return salida;
        }

        /// <summary>
        /// Consulta el saldo total del debe de una cuenta asociada a un concepto
        /// </summary>
        /// <param name="idCuenta"></param>
        /// <returns></returns>
        public double consultarDebeConceptoLiquidado(int idCuenta)
        {
            double salida = 0;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "asientoDeSueldosConsultarSaldoCuenta", "@anioMes",Calculo.anioMes  ,"@legajo", Calculo.Legajo, "@idCuenta", idCuenta );
            if (rs.Read()) //este recorrido se supone realizarse siempre sobre 3 o cuatro registros
            {
          //      if (Calculo.legajo == 459)
          //          Console.WriteLine(legajo.ToString());
          //      if ( double.IsNaN(Convert.ToDouble(rs["debe"])))
          //          salida = 0;
          //      else
                    salida = Convert.ToDouble(rs["debe"]);
            }
            Model.DB.desconectarDB();
            return salida;
        }

        public double consultarHaberConceptoLiquidado(int idCuenta)
        {
            double salida = 0;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "asientoDeSueldosConsultarSaldoCuenta", "@anioMes", Calculo.anioMes, "@legajo", Calculo.Legajo, "@idCuenta", idCuenta);
            if (rs.Read()) //este recorrido se supone realizarse siempre sobre 3 o cuatro registros
                salida = Convert.ToDouble(rs["haber"]);
            Model.DB.desconectarDB();
            return salida;
        }

        /// <summary>
        /// calcula la antiguedad del empleado en días, en base a los períodos trabajados
        /// detallados en dicha tabla
        /// </summary>
        /// <returns></returns>
        public double consultarDiasAntiguedad(DateTime fechaTope)
        {
            double salida = 0;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "periodosTrabajadosCalculaAntiguedad", "@fechaTope", fechaTope, "@legajo", Calculo.Legajo);
            if (rs.Read()) 
                salida = Convert.ToDouble(rs["totalDias"]);
            Model.DB.desconectarDB();
            return salida;
        }

        /// <summary>
        /// consulta temporadas trabajadas de acuerdo a periodos trabajados completos
        /// </summary>
        /// <returns></returns>
        public double temporadasTrabajadas()
        {
            double salida = 0;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "periodosTrabajadosConsultaTemporadas", "@legajo", Calculo.Legajo);
            if (rs.Read())
                salida = Convert.ToDouble(rs["periodos"]);
            Model.DB.desconectarDB();
            return salida;
        }

        public double empresaConsultarAlicuotaLRT()
        {
            double salida = 0;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "empresaConsultar", "@idEmpresa", 1);
            if (rs.Read())
                salida = Convert.ToDouble(rs["porcentajeAlicuotaLRT"]);
            Model.DB.desconectarDB();
            return salida;
        }

        public double empresaConsultarCuotaLRT()
        {
            double salida = 0;
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "empresaConsultar", "@idEmpresa", 1);
            if (rs.Read())
                salida = Convert.ToDouble(rs["cuotaFijaLRT"]);
            Model.DB.desconectarDB();
            return salida;
        }

        /// <summary>
        /// devuelve la parte entera de un numero
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public int entero(double numero)
        {
            return (int)numero;
        }

        /// <summary>
        /// Devuelve el total de días que trae un mes.
        /// </summary>
        /// <returns></returns>
        public int diasDelMes()
        {
            DateTime d = new DateTime(Convert.ToInt32(Varios.Left(Calculo.AnioMes.ToString(), 4)),Convert.ToInt32( Varios.Right(Calculo.anioMes.ToString(), 2)), DateTime.DaysInMonth(Convert.ToInt32(Varios.Left(Calculo.AnioMes.ToString(), 4)), Convert.ToInt32(Varios.Right(Calculo.anioMes.ToString(), 2))));
            return d.Day;
        }

        public int mesLiquidacion()
        {
            return Convert.ToInt32(Varios.Right(Calculo.AnioMes.ToString(), 2));
        }

        public int anioLiquidacion()
        {
            return Convert.ToInt32(Varios.Left(Calculo.AnioMes.ToString(), 4));
        }

        public int anioMesLiquidacion()
        {
            return Convert.ToInt32(Calculo.AnioMes.ToString());
        }

        /// <summary>
        /// Arma la cadena AnioMes, a partir de un año y mes dados.
        /// formato aaaamm
        /// </summary>
        /// <returns></returns>
        public string ArmaAnioMes(int anio, byte mes)
        {
            string strMes;
            if (mes > 9)
                strMes = mes.ToString();
            else
                strMes = 0 + mes.ToString();
            return anio.ToString() + strMes;
        }

        public int legajoEmpleado()
        {
            return Calculo.legajo;
        }

        /// <summary>
        /// Devuelve la fecha correspondiente al ultimo dia del mes.
        /// </summary>
        /// <returns></returns>
        public DateTime fechaUltimoDiaDelMes()
        {
            DateTime dd= new DateTime(Convert.ToInt32(Varios.Left(Calculo.AnioMes.ToString(), 4)),Convert.ToInt32( Varios.Right(Calculo.anioMes.ToString(), 2)), DateTime.DaysInMonth(Convert.ToInt32(Varios.Left(Calculo.AnioMes.ToString(), 4)), Convert.ToInt32(Varios.Right(Calculo.anioMes.ToString(), 2))));
            return dd;
        }


        public DateTime fechaDia15DelMes()
        {
            DateTime dd = new DateTime(Convert.ToInt32(Varios.Left(Calculo.AnioMes.ToString(), 4)), Convert.ToInt32(Varios.Right(Calculo.anioMes.ToString(), 2)), 15);
            return dd;
        }

        /// <summary>
        /// retorna el valor almacenado en un campo con formato fecha del empleado.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public DateTime fechaEmpleado(int codigo)
        {
            DateTime salida;
            salida = Convert.ToDateTime(Model.DB.ejecutarScalar(Model.TipoComando.SP,"empleadosSueldosConsultarValorLegajo", "@legajo", Calculo.Legajo , "@codigo", codigo).ToString());
            return salida;
        }

        /// <summary>
        /// Devuelve fecha Nula
        /// </summary>
        /// <returns></returns>
        public DateTime fechaNula()
        {
            return Convert.ToDateTime("01/01/0001");
        }

        /// <summary>
        /// Devuelve =0 si es igual 
        /// >0 si fecha1>fecha2 
        /// <0 si fecha1<fecha2
        /// </summary>
        /// <param name="fecha1"></param>
        /// <param name="fecha2"></param>
        /// <returns></returns>
        public int comparaFecha(DateTime fecha1, DateTime fecha2)
        {
            return fecha1.CompareTo(fecha2);
        }


        public object Muevo(object expr, int campo)
        {
            return "Muevo " + expr.ToString() + " a " + campo;
        }

        public DateTime fechaHoy()
        {
            return System.DateTime.Now;
        }

        /// <summary>
        /// Devuelve la cantidad de Años entre dos fechas.
        /// </summary>
        /// <param name="fDesde"></param>
        /// <param name="fHasta"></param>
        /// <returns></returns>
        public long Anios(DateTime fDesde, DateTime fHasta)
        {
            long i;
            i = DateDiff(DateInterval.Year, fDesde, fHasta );
            return i;
        }

        /// <summary>
        /// Devuelve el año de una fecha.
        /// </summary>
        /// <returns></returns>
        public int Anio(DateTime fecha)
        {
            return fecha.Year;
        }

        /// <summary>
        /// Devuelve el mes de una fecha.
        /// </summary>
        /// <returns></returns>
        public int Mes(DateTime fecha)
        {
            return fecha.Month ;
        }

        /// <summary>
        /// Devuelve el dia de una fecha.
        /// </summary>
        /// <returns></returns>
        public int Dia(DateTime fecha)
        {
            return fecha.Day;
        }

        public long diasEntreFechas(DateTime fDesde, DateTime fHasta)
        {
            long i;
            i = DateDiff(DateInterval.Day, fDesde, fHasta);
            return i;
        }

        public DateTime inicioSemestre()
        {
            DateTime fecha;
            int mes = Convert.ToInt32(Varios.Right(AnioMes.ToString(), 2));
            if (mes<=6)
                fecha = new DateTime(Convert.ToInt32(Varios.Left(AnioMes.ToString(), 4)), 1, 1);
            else
                fecha = new DateTime(Convert.ToInt32(Varios.Left(AnioMes.ToString(), 4)), 7, 1);
            return fecha;
        }

        public DateTime finSemestre()
        {
            DateTime fecha ;
            int mes = Convert.ToInt32(Varios.Right(AnioMes.ToString(), 2));
            if (mes <= 6)
                fecha = new DateTime(Convert.ToInt32(Varios.Left(AnioMes.ToString(), 4)), 6, 30);
            else
                fecha = new DateTime(Convert.ToInt32(Varios.Left(AnioMes.ToString(), 4)), 12, 31);
            return fecha;
        }


        public object SI(bool cond, object ValorVerdadero, object ValorFalso)
        {
            if (cond)
            {
                return ValorVerdadero;
            }
            else
            {
                return ValorFalso;
            }
        }

        public enum DateInterval
        {
            Second, Minute, Hour, Day, Week, Month, Quarter, Year
        }

        public long DateDiff(DateInterval Interval, System.DateTime StartDate, System.DateTime EndDate)
        {
            long lngDateDiffValue = 0;
            System.TimeSpan TS = new System.TimeSpan(EndDate.Ticks - StartDate.Ticks);
            switch (Interval)
            {
                case DateInterval.Day:
                    lngDateDiffValue = (long)TS.Days;
                    break;
                case DateInterval.Hour:
                    lngDateDiffValue = (long)TS.TotalHours;
                    break;
                case DateInterval.Minute:
                    lngDateDiffValue = (long)TS.TotalMinutes;
                    break;
                case DateInterval.Month:
                    lngDateDiffValue = (long)(TS.Days / 30.4375);
                    break;
                case DateInterval.Quarter:
                    lngDateDiffValue = (long)((TS.Days / 30) / 3);
                    break;
                case DateInterval.Second:
                    lngDateDiffValue = (long)TS.TotalSeconds;
                    break;
                case DateInterval.Week:
                    lngDateDiffValue = (long)(TS.Days / 7);
                    break;
                case DateInterval.Year:
                    lngDateDiffValue = (long)(TS.Days / 365.25);
                    break;
            }
            return (lngDateDiffValue);
        }



    }
}
