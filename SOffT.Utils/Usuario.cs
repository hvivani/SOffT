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
using System.Data;
using System.Windows.Forms;

namespace Sofft.Utils
{
    public class Usuario
    {
        private int idUsuario;
        private string nombre;
        private string login;
        private string password;
        private int idEmpleado;
        private bool seguridad;
        private bool documentos;
        private bool eliminado;

        public Usuario() { }
        
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }
        
        public bool Seguridad
        {
            get { return seguridad; }
            set { seguridad = value; }
        }
        
        public bool Documentos
        {
            get { return documentos; }
            set { documentos = value; }
        }

        public bool Eliminado
        {
            get { return eliminado; }
            set { eliminado = value; }
        }

        public int consultarExisteUsuario(string usr, string pwd)
        {
            int idUsuario;
            idUsuario = Convert.ToInt32(Model.DB.ejecutarScalar(Model.TipoComando.SP, "usuariosConsultarSiExiste", "usr", usr, "pwd", pwd));
            if (idUsuario > 0)
                return idUsuario;
            else
                return 0;
        }

        public static void setPermisosIndices(ref Button[] botones)
        {
            DataSet ds;
            ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "permisosUsuariosConsultarIndice", "@idUsuario", Modulo.Usuario.idUsuario, "@idModulo", Modulo.IdModulo);
            foreach (DataRow dr in ds.Tables["permisosUsuariosConsultarIndice"].Rows)
            {
                botones[(int)dr["indice"] - 1 ].Enabled = (bool)dr["acceso"];
            }
        }

        public static void setPermisosSubIndices(ref Button[] botones, int indice)
        {
            if (Modulo.Usuario != null)
            {
                DataSet ds;
                ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "permisosUsuariosConsultarSubIndice", "idUsuario", Modulo.Usuario.idUsuario, "idModulo", Modulo.IdModulo, "indice", indice);
                foreach (DataRow dr in ds.Tables["permisosUsuariosConsultarSubIndice"].Rows)
                {
                    botones[(int)dr["subIndice"] - 1].Enabled = (bool)dr["acceso"];
                }
            }
        }

        public static void setPermisos(ref Button[] botones, string nivel)
        {
            if (Modulo.Usuario != null)
            {
                DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "permisosConsultarNivel", "@idUsuario", Modulo.Usuario.idUsuario, "@idModulo", Modulo.IdModulo, "nivel", nivel);
                foreach (DataRow dr in ds.Tables["permisosConsultarNivel"].Rows)
                {
                    try
                    { botones[Convert.ToInt32(dr["indice"])].Enabled = (bool)dr["acceso"]; }
                    catch (Exception)
                    { System.Console.WriteLine("Eliminar Permisos del Nivel: " + nivel + " indice: " + dr["indice"].ToString() + " por no corresponder a ningun boton"); }
                }
            }
        }
    }
}
