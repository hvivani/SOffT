/*  
    TablaData.cs

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
using Log4Net;
using Sueldos.Entidades;
using System.Data;


namespace Sueldos.Data
{
    public class TablaData:GenericData 
    {
        public TablaData() : base("tablas") { }

        #region ABM

        public int insert(TablaEntity tabla)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Agregando: " + tabla.ToString());
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ");
                sql.Append(this.tabla);
                sql.Append(" VALUES('");
                sql.Append(tabla.Nombre);
                sql.Append("', ");
                sql.Append(tabla.Indice);
                sql.Append(", '");
                sql.Append(tabla.Descripcion);
                sql.Append("', ");
                sql.Append(tabla.Contenido);
                sql.Append(", '");
                sql.Append(tabla.Detalle);
                sql.Append("', ");
                sql.Append(tabla.Identidad );
                sql.Append(")");
                return Model.DB.ejecutarProceso(Model.TipoComando.Texto, sql.ToString());
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("insert(). " + ex.Message, ex);
                throw;
            }

        }

        public int update(TablaEntity tabla)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Actualizando: " + tabla.ToString());
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE ");
                sql.Append(this.tabla);
                sql.Append(" SET");
                sql.Append(" indice = ");
                sql.Append(tabla.Indice);
                sql.Append(", descripcion = '");
                sql.Append(tabla.Descripcion);
                sql.Append("', contenido = ");
                sql.Append(tabla.Contenido);
                sql.Append(", detalle = '");
                sql.Append(tabla.Detalle );
                sql.Append("', identidad = ");
                sql.Append(tabla.Identidad );
                sql.Append(" WHERE ");
                sql.Append(" id = ");
                sql.Append(tabla.Id);
                sql.Append(" and nombre = '");
                sql.Append(tabla.Nombre);
                sql.Append("'");
                return Model.DB.ejecutarProceso(Model.TipoComando.Texto, sql.ToString());
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("update(). " + ex.Message, ex);
                throw;
            }

        }

        public int delete(TablaEntity tabla)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Eliminado id: " + tabla.Id);
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" id = ");
            sql.Append(tabla.Id);
            try
            {
                return Model.DB.ejecutarProceso(Model.TipoComando.Texto, sql.ToString());
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("delete(). " + ex.Message, ex);
                throw;
            }

        }

        #endregion

        #region SELECTs

        /// <summary>
        /// Devuelve una lista de contenido y detalle de Tablas a partir de su nombre/indice. 
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        public List<TablaEntity> getByContenidoYdetalle(string nombreTabla, int indice)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id");
            sql.Append(", nombre");
            sql.Append(", indice");
            sql.Append(", descripcion");
            sql.Append(", contenido");
            sql.Append(", detalle");
            sql.Append(", identidad");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" nombre = '" + nombreTabla);
            sql.Append("' and indice = " + indice);
            List<TablaEntity> tablas = new List<TablaEntity>();
            try
            {
                using (IDataReader reader = Model.DB.ejecutarDataReader(Model.TipoComando.Texto, sql.ToString()))
                {
                    while (reader.Read())
                        tablas.Add (this.make(reader));
                }
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getById(). " + ex.Message, ex);
                throw;
            }
            return tablas;
        }


        /// <summary>
        /// Devuelve el contenido de una tabla a partir de su nombre. 
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        public List<TablaEntity> getByNombre(string nombreTabla)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id");
            sql.Append(", nombre");
            sql.Append(", indice");
            sql.Append(", descripcion");
            sql.Append(", contenido");
            sql.Append(", detalle");
            sql.Append(", identidad");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" nombre = '" + nombreTabla);
            sql.Append("' order by nombre, indice, descripcion, contenido");
            List<TablaEntity> tablas = new List<TablaEntity>();
            try
            {
                using (IDataReader reader = Model.DB.ejecutarDataReader(Model.TipoComando.Texto, sql.ToString()))
                {
                    while (reader.Read())
                        tablas.Add(this.make(reader));
                }
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getById(). " + ex.Message, ex);
                throw;
            }
            return tablas;
        }

        /// <summary>
        /// Devuelve el contenido de una tabla a partir de su nombre. 
        /// Se deben especificar campos de ordenacion
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        public List<TablaEntity> getByNombre(string nombreTabla, string orden)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id");
            sql.Append(", nombre");
            sql.Append(", indice");
            sql.Append(", descripcion");
            sql.Append(", contenido");
            sql.Append(", detalle");
            sql.Append(", identidad");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" nombre = '" + nombreTabla);
            sql.Append("' order by " + orden);
            List<TablaEntity> tablas = new List<TablaEntity>();
            try
            {
                using (IDataReader reader = Model.DB.ejecutarDataReader(Model.TipoComando.Texto, sql.ToString()))
                {
                    while (reader.Read())
                        tablas.Add(this.make(reader));
                }
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getById(). " + ex.Message, ex);
                throw;
            }
            return tablas;
        }

        /// <summary>
        /// Devuelve el contenido de una tabla a partir de su nombre. 
        /// Se aceptan filtros
        /// Se deben especificar campos de ordenacion
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        public List<TablaEntity> getByNombre(string nombreTabla, string filtro, string orden)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id");
            sql.Append(", nombre");
            sql.Append(", indice");
            sql.Append(", descripcion");
            sql.Append(", contenido");
            sql.Append(", detalle");
            sql.Append(", identidad");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" nombre = '" + nombreTabla + "'");
            if (filtro.Length>0)
                sql.Append(" and " + filtro);
            sql.Append(" order by " + orden);
            List<TablaEntity> tablas = new List<TablaEntity>();
            try
            {
                using (IDataReader reader = Model.DB.ejecutarDataReader(Model.TipoComando.Texto, sql.ToString()))
                {
                    while (reader.Read())
                        tablas.Add(this.make(reader));
                }
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getById(). " + ex.Message, ex);
                throw;
            }
            return tablas;
        }


        public List<TablaEntity> getNombresTablas()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT distinct");
            sql.Append(" nombre");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            List<TablaEntity> tablas = new List<TablaEntity>();
            try
            {
                using (IDataReader reader = Model.DB.ejecutarDataReader(Model.TipoComando.Texto, sql.ToString()))
                {
                    while (reader.Read())
                        tablas.Add(new TablaEntity(reader["nombre"].ToString(), 0, 0));
                }
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getNombresTablas(). " + ex.Message, ex);
                throw;
            }
            return tablas;
        }


        /// <summary>
        /// Devuelve una Tabla a partir de su (Id): nombre, indice, contenido. 
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        public TablaEntity getById(string nombre, int indice, double contenido)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id");
            sql.Append(", nombre");
            sql.Append(", indice");
            sql.Append(", descripcion");
            sql.Append(", contenido");
            sql.Append(", detalle");
            sql.Append(", identidad");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" nombre = '" + nombre);
            sql.Append("' and indice = " + indice);
            sql.Append(" and contenido = " + contenido);
            try
            {
                using (IDataReader reader = Model.DB.ejecutarDataReader(Model.TipoComando.Texto, sql.ToString()))
                {
                    return (reader.Read()) ? this.make(reader) : null;
                }
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getById(). " + ex.Message, ex);
                throw;
            }
        }

        /// <summary>
        /// Devuelve el indice Maximo de una tabla de acuerdo a su nombre y descripcion 
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        public int getMaxIndice(string nombre, string descripcion)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT max(indice) as indice");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" nombre = '" + nombre);
            sql.Append("' and descripcion = '" + descripcion + "'" );
            try
            {
                using (IDataReader reader = Model.DB.ejecutarDataReader(Model.TipoComando.Texto, sql.ToString()))
                {
                    if (reader.Read())
                        return Convert.ToInt32(reader["indice"]);
                    else
                        return 0;
                }
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getById(). " + ex.Message, ex);
                throw;
            }
        }

        public TablaEntity getById(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id");
            sql.Append(", nombre");
            sql.Append(", indice");
            sql.Append(", descripcion");
            sql.Append(", contenido");
            sql.Append(", detalle");
            sql.Append(", identidad");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" id = " + id);
            try
            {
                using (IDataReader reader = Model.DB.ejecutarDataReader(Model.TipoComando.Texto, sql.ToString()))
                {
                    return (reader.Read()) ? this.make(reader) : null;
                }
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getById(). " + ex.Message, ex);
                throw;
            }
        }

        public List<TablaEntity> GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id");
            sql.Append(", nombre");
            sql.Append(", indice");
            sql.Append(", descripcion");
            sql.Append(", contenido");
            sql.Append(", detalle");
            sql.Append(", identidad");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            return this.getLista(sql.ToString());
        }


        #endregion




        #region PRIVATE

        private TablaEntity make(IDataReader reader)
        {
            TablaEntity tabla = new TablaEntity(reader["nombre"].ToString(), int.Parse(reader["indice"].ToString()), double.Parse(reader["contenido"].ToString()));
            tabla.Id = Convert.ToInt32(reader["id"]);
            tabla.Descripcion = reader["descripcion"].ToString();
            tabla.Detalle = reader["detalle"].ToString();
            tabla.Identidad = Convert.ToInt32(reader["identidad"]);
            return tabla;
        }

        private List<TablaEntity> getLista(string sql)
        {
            var tablas = new List<TablaEntity>();
            try
            {
                using (IDataReader reader = Model.DB.ejecutarDataReader(Model.TipoComando.Texto, sql.ToString()))
                {
                    while (reader.Read())
                        tablas.Add(this.make(reader));
                }
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getListaTablas(). " + ex.Message, ex);
                throw;
            }
            return tablas;
        }



        #endregion



    }
}
