/*
    Modulo.cs

    Author:
    Hernan Vivani <hernan@vivani.com.ar> - http://hvivani.com.ar
    Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>

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
	/// <summary>
	///Esta clase lleva todas las variables y constantes que corresponden
	///al modulo actual, además de realizar algunas taréas específicas del mismo
	/// </summary>
	public static class Modulo
	{
		//public const string version = "v.1.5.34";
		public const string nombreLogo = "Logo.jpg";
		public const string nombreIcono = "icono.ico";
		public const string nombreLogoGrande = "logoGrande.jpg";
		public const string pathImagenes = "Imagenes";
		public const string pathDocumentos = "Documentos";

		//variable para cargar el nombre del archivo de definicion de la estructura de permisos

		public static string ServidorDB {
			get;
			set;
		}

		public static string DB {
			get;
			set;
		}

		public static string NombreModulo {
			get;
			set;
		}

		public static string NombreSistema {
			get;
			set;
		}

		public static string FechaActual {
			get;
			set;
		}

		public static Usuario Usuario {
			get;
			set;
		}

		public static int IdModulo {
			get;
			set;
		}

		public static string PermisosXML {
			get;
			set;
		}

		/// <summary>
		/// Indica si se está utilizando la verificacion de login en el modulo.
		/// El valor se setea en el metodo VerificaLogin
		/// </summary>
		public static Boolean ValidaLogin {
			get;
			set;
		}

		/// <summary>
		/// carga el icono desde el directorio imágenes del modulo
		/// </summary>
		/// <returns></returns>
		[Obsolete ("Usar CargarIcono()")]
		public static Icon cargaIcono ()
		{
			return CargaIcono ();
		}

		/// <summary>
		/// carga el icono desde el directorio imágenes del modulo
		/// </summary>
		/// <returns></returns>
		public static Icon CargarIcono ()
		{
			Icon icono = null;
			try {
				string pathIcono = string.Format ("{1}{0}{2}{0}{3}", Path.DirectorySeparatorChar, Application.StartupPath, pathImagenes, nombreIcono);
				icono = new Icon (pathIcono);
			} catch (Exception ex) {
				Console.WriteLine ("Error al cargar el icono del modulo {0}", ex);
			}
			return icono;
		}

		[Obsolete ("Usar TomarLogin()")]
		public static void tomarLogin ()
		{
			//este metodo abre el archivo ini y setea el usuario por defecto o ultimo validado
			TomarLogin ();
		}

		public static void TomarLogin ()
		{
			//este metodo abre el archivo ini y setea el usuario por defecto o ultimo validado
			throw NotImplementedException ();
		}

		[Obsolete ("Usar GuardarLogin()")]
		public static void guardarLogin ()
		{
			//este metodo guarda el login en el archivo
			GuardarLogin ();
		}

		public static void GuardarLogin ()
		{
			//este metodo guarda el login en el archivo
			throw NotImplementedException ();
		}

		[Obsolete ("Usar SeteaCultura")]
		public static void seteaCultura ()
		{
			SeteaCultura ();
		}

		public static void SeteaCultura ()
		{
			Console.WriteLine ("Seteando configuración regional:");
			Console.WriteLine (CultureInfo.CurrentCulture.NativeName);
			Thread.CurrentThread.CurrentCulture = new CultureInfo (ConfigurationManager.AppSettings ["CultureInfo"], true);
			Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencySymbol = ConfigurationManager.AppSettings ["CurrencySymbol"];
			Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortTimePattern = ConfigurationManager.AppSettings ["ShortTimePattern"];
			Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = ConfigurationManager.AppSettings ["ShortDatePattern"];
			Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ConfigurationManager.AppSettings ["NumberDecimalSeparator"];
			Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ConfigurationManager.AppSettings ["CurrencyDecimalSeparator"];
			Console.WriteLine (CultureInfo.CurrentCulture.NativeName);
		}
	}
}
