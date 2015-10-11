/*  
    DBnet.cs

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
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace Model
{
    /// <summary>
    /// Clase destinada a la conexion generica a base de datos.
    /// </summary>
    public static class DB
    {
        #region Campos

        private static DbProviderFactory factory;
        private static DbConnection conexion;
        private static string connectionName;
        private static string providerName;
        private static string cadenaConexion;
        private static int commandTimeOut;
        //private static boolean enlazado = false;

        #endregion

        #region Propiedades

        /// <summary>
        /// Leer o Establecer el tiempo de espera de resupuesta de los comandos de consultas
        /// </summary>
        public static int CommandTimeOut
        {
            get { return commandTimeOut; }
            set { commandTimeOut = value; }
        }

        /// <summary>
        /// Leer o Establecer el Nombre invariable del proveedor de bases de datos a utilizar
        /// </summary>
        public static string ProviderName
        {
            get { return DB.providerName; }
            set
            {
                DB.providerName = value;
                DB.factory = DbProviderFactories.GetFactory(DB.providerName);
            }
        }

        /// <summary>
        /// Leer o Establecer la cadena de conexion
        /// </summary>
        public static String CadenaConexion
        {
            get
            { return cadenaConexion; }
            set
            {
                //Establece el tiempo de espera de los comandos
                DB.CommandTimeOut = Convert.ToInt32(ConfigurationManager.AppSettings["TiempoDeEsperaDB"]);
                cadenaConexion = value;
            }
        }

        /// <summary>
        /// Leer o Establecer el nombre la conexion a utilizar que se encuentra definiada en el archivo app.config o web.config
        /// </summary>
        public static string ConnectionName
        {
            get
            { return DB.connectionName; }
            set
            {
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[value];
                DB.CadenaConexion = settings.ConnectionString;
                DB.ProviderName = settings.ProviderName;
                DB.connectionName = value;
            }
        }

        ///// <summary>
        ///// Lee o Establece el tipod e coneccion. True modo enlazado utilizando una unica conexion. False, modo desenlazado realizando una conexion por cada pedido
        ///// </summary>
        //public static Boolean Enlazado
        //{
        //    get { return DB.enlazado; }
        //    set
        //    {
        //        if (value)
        //            DB.enlazado = conectarDB();
        //        else
        //        {
        //            desconectarDB();
        //            DB.enlazado = value;
        //        }
        //    }
        //}

        #endregion

        #region Metodos Privados

        /// <summary>
        /// Crea una coneccion de acuerdo al la configuracion especificada en las propiedades de la clase
        /// </summary>
        /// <remarks>Modificar el string de conexion para la base MySql por cuestion de usuario de base de datos.</remarks>
        /// <returns>Conexion abierta</returns>
        private static Boolean conectarDB()
        {
            try
            {
                conexion = factory.CreateConnection();
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                return true;
            }
            catch (Exception ex)
            {
                RegistrarError(ex);
                return false;
            }
        }

        /// <summary>
        /// Crea un comando de ejecucion en base de datos
        /// </summary>
        /// <param name="tipo">Tipo del comando</param>
        /// <param name="cadenaSql">Cadena del comando</param>
        private static DbCommand crearComando(TipoComando tipo, string cadenaSql)
        {
            DbCommand comando = factory.CreateCommand();

            //asigno los valores del comando a ejecutar
            comando.Connection = conexion;
            switch (tipo)
            {
                case TipoComando.SP:
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        break;
                    }
                case TipoComando.Texto:
                    {
                        comando.CommandType = CommandType.Text;
                        break;
                    }
            }
            comando.CommandText = cadenaSql;
            comando.CommandTimeout = DB.CommandTimeOut;
            return comando;
        }

        /// <summary>
        /// Asigna los parametros al comando de acuerdo al motor utilizado
        /// </summary>
        private static void cargarParametros(ref DbCommand comando, ref object[] parametros)
        {
            DbParameter p;
            for (int i = 0; i < parametros.Length; i = i + 2)
            {
                p = factory.CreateParameter();
                p.ParameterName = parametros[i].ToString();
                p.Value = parametros[i + 1];
                comando.Parameters.Add(p);
            }
        }

        #endregion

        #region Metodos Publicos

        /// <summary>
        /// Desconecta la Base de Datos
        /// </summary>
        public static void desconectarDB()
        {
            //20080610. hvivani. espera el cierre.
            while (conexion.State == ConnectionState.Open)
                conexion.Close();
        }


        /// <summary>
        /// Realiza una consulta a una base de datos y devuelve un dataset nuevo
        /// </summary>
        /// <param name="tipo">Define el tipo de consulta a realizar. SP, texto, TablaEntera</param>
        /// <param name="cadenaSql">SP: nombre SP, Texto: Cadena de consulta</param>
        /// <param name="parametros">Pares Nombre parametros, Valor parametro</param>
        /// <returns>Devuelve resultas de la consulta en tablas contenidas en un DataSet</returns>
        public static DataSet ejecutarDataSet(TipoComando tipo, string cadenaSql, params object[] parametros)
        {
            DbCommand comando;
            DbDataAdapter adaptador = factory.CreateDataAdapter();
            DataSet resultado = new DataSet();

            //if (!enlazado)
            conectarDB();

            //Instancio los objetos de acuerdo al tipo de motor de bases de datos que se utilice
            try
            {
                comando = crearComando(tipo, cadenaSql);
              //  comando.CommandTimeout = CommandTimeOut;
                cargarParametros(ref comando, ref parametros);
                //Ejecuto la consulta

                adaptador.SelectCommand = comando;
                switch (tipo)
                {
                    case TipoComando.SP:
                        {
                            adaptador.Fill(resultado, cadenaSql);
                            break;
                        }
                    default:
                        {
                            adaptador.Fill(resultado);
                            break;
                        }
                }
                //if (!enlazado)
                desconectarDB();
            }
            catch (DbException ex)
            { RegistrarError(ex); }
            return resultado;
        }

        /// <summary>
        /// Realiza una consulta a una base de datos y llena con el resultado un dataset parasado por referencia
        /// </summary>
        /// <param name="dataset">DataSet instanciado a ser llenado</param>
        /// <param name="tipo">Define el tipo de consulta a realizar. SP, texto, TablaEntera</param>
        /// <param name="cadenaSql">SP: nombre SP, Texto: Cadena de consulta</param>
        /// <param name="parametros">Pares Nombre parametros, Valor parametro</param>
        public static void ejecutarDataSet(ref DataSet dataset, TipoComando tipo, string cadenaSql, params object[] parametros)
        {
            DbCommand comando;
            DbDataAdapter adaptador = factory.CreateDataAdapter();
            //if (!enlazado)
            conectarDB();

            //Instancio los objetos de acuerdo al tipo de motor de bases de datos que se utilice
            try
            {
                comando = crearComando(tipo, cadenaSql);
               // comando.CommandTimeout = CommandTimeOut;
                cargarParametros(ref comando, ref parametros);
                //Ejecuto la consulta

                adaptador.SelectCommand = comando;
                switch (tipo)
                {
                    case TipoComando.SP:
                        {
                            adaptador.Fill(dataset, cadenaSql);
                            break;
                        }
                    default:
                        {
                            adaptador.Fill(dataset);
                            break;
                        }
                }
                //if (!enlazado)
                desconectarDB();
            }
            catch (DbException ex)
            { RegistrarError(ex); }
        }

        /// <summary>
        /// Realiza una consulta a una base de datos
        /// </summary>
        /// <param name="tipo">Define el tipo de consulta a realizar. SP, texto, TablaEntera</param>
        /// <param name="cadenaSql">SP: nombre SP, Texto: Cadena de consulta</param>
        /// <param name="parametros">Pares Nombre parametros, Valor parametro</param>
        /// <returns>Devuelve resultas de la consulta en DataReader</returns>
        /// <remarks>IMPORTANTE CERRAR EL DATAREADER AL FINALIZAR SU UTILIZACION</remarks>
        public static DbDataReader ejecutarDataReader(TipoComando tipo, string cadenaSql, params object[] parametros)
        {
            DbCommand comando;
            DbDataReader resultado;
            //if (!enlazado)
            conectarDB();
            comando = crearComando(tipo, cadenaSql);
            cargarParametros(ref comando, ref parametros);
            //Ejecuto la consulta
            resultado = comando.ExecuteReader();

            return resultado;
        }

        /// <summary>
        /// Ejecuta una consulta escalar.
        /// </summary>
        /// <param name="tipo">Tipo de consulta</param>
        /// <param name="cadenaSql">SP: nombre SP, Texto: Cadena de consulta</param>
        /// <param name="parametros">Pares Nombre parametros, Valor parametro</param>
        /// <returns>Devuelve un objeto con un valor escalar a que necesitar ser casteado</returns>
        public static object ejecutarScalar(TipoComando tipo, string cadenaSql, params object[] parametros)
        {
            object id;
            DbCommand comando;
            //if (!enlazado)
            conectarDB();
            comando = crearComando(tipo, cadenaSql);
            cargarParametros(ref comando, ref parametros);
            id = comando.ExecuteScalar();
            //if (!enlazado)
            desconectarDB();
            return id;
        }

        /// <summary>
        /// Ejecuta una consulta sin devolucion de resultados.
        /// </summary>
        /// <param name="tipo">Tipo de consulta</param>
        /// <param name="cadenaSql">SP: nombre SP, Texto: Cadena de consulta</param>
        /// <param name="parametros">Pares Nombre parametros, Valor parametro</param>
        /// <returns>Devuelve cantidad de registros afectados</returns>
        public static int ejecutarProceso(TipoComando tipo, string cadenaSql, params object[] parametros)
        {
            int salida = 0;
            DbCommand comando;
            //if (!enlazado)
            conectarDB();
            comando = crearComando(tipo, cadenaSql);
          //  comando.CommandTimeout = 240;
            cargarParametros(ref comando, ref parametros);
            salida = comando.ExecuteNonQuery();
            //cpereyra - Verificar que si se elemina el comando luego de utilizarlo sigue andando
          //  comando.Dispose();
            //if (!enlazado)
            desconectarDB();
            return salida;
        }

        /// <summary>
        /// Registrar los errores generados al intentar realizar las consultas.
        /// </summary>
        /// <param name="error"></param>
        private static void RegistrarError(Exception error)
        {
            try
            {
                System.IO.StreamWriter w = System.IO.File.AppendText("DBNet.log");
                w.Write("\r\nRegistro de error: ");
                w.WriteLine("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
                w.WriteLine("Message: {0}", error.Message);
                w.WriteLine("Source: {0}", error.Source);
                w.WriteLine("StackTrace:");
                w.WriteLine(error.StackTrace);
                w.WriteLine("-------------------------------");
                w.Flush();
                w.Close();
            }
            catch (Exception)
            {
                //UNDONE cpereyra 
            }

            System.Windows.Forms.MessageBox.Show(error.Message + "\rIntente nuevamente. \rSi el problema persiste informe al administrador.",
                "Error en la aplicacion", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error); 
        }

        #endregion
    }
}
