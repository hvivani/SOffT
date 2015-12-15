/*
    Usuario.cs

    Author:
    Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>
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
using System.Data;
using System.Windows.Forms;

namespace Sofft.Utils
{
	public class Usuario
	{
		public int IdUsuario {
			get;
			set;
		}

		public string Login {
			get;
			set;
		}

		public string Password {
			get;
			set;
		}

		public string Nombre {
			get;
			set;
		}

		public int IdEmpleado {
			get;
			set;
		}

		public bool Seguridad {
			get;
			set;
		}

		public bool Documentos {
			get;
			set;
		}

		public bool Eliminado {
			get;
			set;
		}

		[Obsolete ("Usar ExisteUsuario()")]
		public int consultarExisteUsuario (string usr, string pwd)
		{
			return ExisteUsuario (usr, pwd);
		}

		public int ExisteUsuario (string usr, string pwd)
		{
			int idUsuario;
			idUsuario = Convert.ToInt32 (Model.DB.ejecutarScalar (Model.TipoComando.SP, "usuariosConsultarSiExiste", "usr", usr, "pwd", pwd));
			return idUsuario > 0 ? idUsuario : 0;
		}

		[Obsolete ("Usar SetPermisos (ref List<Button> botones, string nivel)")]
		public static void setPermisos (ref Button[] botones, string nivel)
		{
			if (Modulo.Usuario != null) {
				var ds = Model.DB.ejecutarDataSet (Model.TipoComando.SP, "permisosConsultarNivel", "@idUsuario", Modulo.Usuario.IdUsuario, "@idModulo", Modulo.IdModulo, "nivel", nivel);
				foreach (DataRow dr in ds.Tables["permisosConsultarNivel"].Rows) {
					try {
						botones [Convert.ToInt32 (dr ["indice"])].Enabled = (bool)dr ["acceso"];
					} catch (Exception) {
						Console.WriteLine ("Eliminar Permisos del Nivel: " + nivel + " indice: " + dr ["indice"] + " por no corresponder a ningun boton");
					}
				}
			}
		}

		public static void SetPermisos (ref List<Button> botones, string nivel)
		{
			if (Modulo.Usuario != null) {
				var ds = Model.DB.ejecutarDataSet (Model.TipoComando.SP, "permisosConsultarNivel", "@idUsuario", Modulo.Usuario.IdUsuario, "@idModulo", Modulo.IdModulo, "nivel", nivel);
				foreach (DataRow dr in ds.Tables["permisosConsultarNivel"].Rows) {
					try {
						botones [Convert.ToInt32 (dr ["indice"])].Enabled = (bool)dr ["acceso"];
					} catch (Exception) {
						Console.WriteLine ("Eliminar Permisos del Nivel: " + nivel + " indice: " + dr ["indice"] + " por no corresponder a ningun boton");
					}
				}
			}
		}

		[Obsolete ("Usar SetPermisosIndices (ref List<Button> botones)")]
		public static void setPermisosIndices (ref Button[] botones)
		{
			DataSet ds;
			ds = Model.DB.ejecutarDataSet (Model.TipoComando.SP, "permisosUsuariosConsultarIndice", "@idUsuario", Modulo.Usuario.IdUsuario, "@idModulo", Modulo.IdModulo);
			foreach (DataRow dr in ds.Tables["permisosUsuariosConsultarIndice"].Rows) {
				botones [(int)dr ["indice"] - 1].Enabled = (bool)dr ["acceso"];
			}
		}

		public static void SetPermisosIndices (ref List<Button> botones)
		{
			var ds = Model.DB.ejecutarDataSet (Model.TipoComando.SP, "permisosUsuariosConsultarIndice", "@idUsuario", Modulo.Usuario.IdUsuario, "@idModulo", Modulo.IdModulo);
			foreach (DataRow dr in ds.Tables["permisosUsuariosConsultarIndice"].Rows) {
				botones [(int)dr ["indice"] - 1].Enabled = (bool)dr ["acceso"];
			}
		}

		[Obsolete ("Usar SetPermisosSubIndices (ref List<Button> botones, int indice)")]
		public static void setPermisosSubIndices (ref Button[] botones, int indice)
		{
			if (Modulo.Usuario != null) {
				var ds = Model.DB.ejecutarDataSet (Model.TipoComando.SP, "permisosUsuariosConsultarSubIndice", "idUsuario", Modulo.Usuario.IdUsuario, "idModulo", Modulo.IdModulo, "indice", indice);
				foreach (DataRow dr in ds.Tables["permisosUsuariosConsultarSubIndice"].Rows) {
					botones [(int)dr ["subIndice"] - 1].Enabled = (bool)dr ["acceso"];
				}
			}
		}

		public static void SetPermisosSubIndices (ref List<Button> botones, int indice)
		{
			if (Modulo.Usuario != null) {
				var ds = Model.DB.ejecutarDataSet (Model.TipoComando.SP, "permisosUsuariosConsultarSubIndice", "idUsuario", Modulo.Usuario.IdUsuario, "idModulo", Modulo.IdModulo, "indice", indice);
				foreach (DataRow dr in ds.Tables["permisosUsuariosConsultarSubIndice"].Rows) {
					botones [(int)dr ["subIndice"] - 1].Enabled = (bool)dr ["acceso"];
				}
			}
		}
	}
}
