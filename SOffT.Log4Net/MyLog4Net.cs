/*  
    MyLog4Net.cs

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
using System.IO;
using log4net;
using log4net.Config;

namespace Log4Net {

    /// <summary>
    /// Logging utilizando: Log4Net
    /// Esta clase provee el acceso a 2 objetos para emitir logs: defaultLog y customLog.
    /// La configuración de los mismos se encuentra en log4net.config (o app.config).
    /// DefaultLog utiliza un log por defecto pre configurado.
    /// CustomLog permite recuperar un objeto de log con el nombre de la clase que lo invoca.
    /// <example><code>Uso: MyLog4Net.Instance.DefaultLog.Info("mensaje de log")</code></example>
    /// <author> Ramiro </author> </summary>
    /// <remarks>Singleton class</remarks>
    public sealed class MyLog4Net { // public final class

        private ILog defaultLog; // se crea al generar el objeto (única instancia)

        /// <summary>Constructor. Crea el log por defecto.</summary>
        private MyLog4Net() {
            // lee el archivo de configuración con la definición de los logs.
            FileInfo configFile = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config");
            if (configFile.Exists) {
                XmlConfigurator.Configure(configFile);
                XmlConfigurator.ConfigureAndWatch(configFile);
            } else {
                // sin parámetros toma el config de la Aplicación que utiliza el paquete (.dll)
                // XmlConfigurator.Configure(); // toma de app.config

                // crea una configuración por defecto
                BasicConfigurator.Configure();

                // TODO: cargar una configuración mínima acorde por programa....
            }

            // instancia el Log por defecto.
            this.defaultLog = LogManager.GetLogger("InfoLog"); // this.ToString()
        }

        public static readonly MyLog4Net Instance = new MyLog4Net();


        /// <summary>Devuelve el objeto de log por defecto.</summary>
        public ILog DefaultLog {
            get {
                return this.defaultLog;
            }
        }

        /// <summary>
        /// Devuelve un objeto de log basado en el tipo de la clase que lo invocó.
        /// </summary>
        /// <param name="typeOfClass">Type de la clase que lo solicita. Ej: this.GetType()</param>
        public ILog getCustomLog(Type typeOfClass) {
            return LogManager.GetLogger(typeOfClass);
        }

        /// <summary>
        /// Devuelve un objeto de log basado en el nombre de la clase que lo invocó.
        /// </summary>
        /// <param name="nameOfClass">Nombre de la clase que lo solicita.</param>
        public ILog getCustomLog(string nameOfClass) {
            return LogManager.GetLogger(nameOfClass);
        }

    } // End of class

} // End of package