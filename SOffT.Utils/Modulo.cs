/*  
    Modulo.cs

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
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Sofft.Utils
{
    /*Esta clase lleva todas las variables y constantes que corresponden
     * al modulo actual, además de realizar algunas taréas específicas
     * del mismo*/
	/// <summary>
	/// 
	/// </summary>
    public class Modulo
    {
        //public const string version = "v.1.5.34";
        public const string nombreLogo=  "Logo.jpg";
        public const string nombreIcono ="icono.ico";
        public const string nombreLogoGrande = "logoGrande.jpg";
        public const string pathImagenes = "Imagenes";
		public const string pathDocumentos = "Documentos";


        private static string servidorDB;
        private static string db;
        private static string nombreModulo;
        private static string nombreSistema;
        private static string fechaActual;
        private static Usuario usuario;   
        private static int idModulo;
        private static Boolean validaLogin;
        private static string permisosXML; //variable para cargar el nombre del archivo de definicion de la estructura de permisos


        public static string ServidorDB
        {
            get { return servidorDB; }
            set { servidorDB = value; }
        }

        public static string DB
        {
            get { return db; }
            set { db=value;}
        }

        public static string NombreModulo
        {
            get { return nombreModulo;}
            set { nombreModulo = value; }
        }

        public static string NombreSistema
        {
            get { return nombreSistema ; }
            set { nombreSistema = value; }
        }

        public static string FechaActual
        {
            get { return fechaActual; }
            set { fechaActual = value; }
        }

        public static Usuario Usuario    
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public static int IdModulo
        {
            get { return idModulo; }
            set { idModulo = value; }
        }

        public static string PermisosXML
        {
            get { return permisosXML; }
            set { permisosXML = value; }
        }

        /// <summary>
        /// Indica si se está utilizando la verificacion de login en el modulo.
        /// El valor se setea en el metodo VerificaLogin
        /// </summary>
        public static Boolean ValidaLogin
        {
            get { return validaLogin; }
            set { validaLogin = value; }
        }

        /// <summary>
        /// carga el icono desde el directorio imágenes del modulo
        /// </summary>
        /// <returns></returns>
        public static Icon cargaIcono ()
        {
        	Icon icono = null;
        	try
            {
				string pathIcono = Application.StartupPath + Path.DirectorySeparatorChar + pathImagenes + Path.DirectorySeparatorChar + nombreIcono;
        		icono = new Icon (pathIcono);
        	}
            catch (Exception ex)
            {
        		Console.WriteLine ("Error al cargar el icono del modulo {0}", ex);
            }
            return icono;
        }

        public void tomarLogin()
        {
            //este metodo abre el archivo ini y setea el usuario por defecto o ultimo validado
        }
        public void guardarLogin()
        {
            //este metodo guarda el login en el archivo 
        }


        public static void seteaCultura()
        {
            Console.WriteLine("Seteando configuración regional:");
            Console.WriteLine(CultureInfo.CurrentCulture.NativeName);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(ConfigurationManager.AppSettings["CultureInfo"], true);
            Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencySymbol = ConfigurationManager.AppSettings["CurrencySymbol"];
            Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortTimePattern = ConfigurationManager.AppSettings["ShortTimePattern"];
            Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = ConfigurationManager.AppSettings["ShortDatePattern"];
            Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ConfigurationManager.AppSettings["NumberDecimalSeparator"];
            Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ConfigurationManager.AppSettings["CurrencyDecimalSeparator"];
            Console.WriteLine(CultureInfo.CurrentCulture.NativeName);
        }

    }
}
