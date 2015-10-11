/*  
    NovedadData.cs

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
    public class NovedadData:GenericData 
    {
        public NovedadData() : base("novedades") { }

        #region ABM

        public int insert(NovedadEntity nove)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Agregando: " + nove.IdLiquidacion + " " + nove.Legajo + " " + nove.Codigo);
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ");
                sql.Append(this.tabla);
                sql.Append(" VALUES(");
                sql.Append(nove.IdLiquidacion);
                sql.Append(", ");
                sql.Append(nove.Legajo);
                sql.Append(", ");
                sql.Append(nove.Codigo);
                sql.Append(", '");
                sql.Append(nove.Valor );
                sql.Append("')");
                return Model.DB.ejecutarProceso(Model.TipoComando.Texto, sql.ToString());
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("insert(). " + ex.Message, ex);
                throw;
            }

        }

        public int update(NovedadEntity nove)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Actualizando: " + nove.IdLiquidacion + " " + nove.Legajo + " " + nove.Codigo);
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE ");
                sql.Append(this.tabla);
                sql.Append(" SET");
                sql.Append(" valor = '");
                sql.Append(nove.Valor);
                sql.Append("' WHERE ");
                sql.Append(" idLiquidacion = ");
                sql.Append(nove.IdLiquidacion);
                sql.Append(" and legajo = ");
                sql.Append(nove.Legajo);
                sql.Append(" and codigo = ");
                sql.Append(nove.Codigo);
                return Model.DB.ejecutarProceso(Model.TipoComando.Texto, sql.ToString());
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("update(). " + ex.Message, ex);
                throw;
            }
        }

        public int delete(NovedadEntity nove)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Eliminado id: " + nove.IdLiquidacion + " " + nove.Legajo + " " + nove.Codigo );
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" idLiquidacion = ");
            sql.Append(nove.IdLiquidacion);
            sql.Append(" and legajo = ");
            sql.Append(nove.Legajo);
            sql.Append(" and codigo = ");
            sql.Append(nove.Codigo);
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
        /// Devuelve una Novedad a partir de su (Id): idLiquidacion, legajo, codigo. 
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        public NovedadEntity getById(int IdLiquidacion, int legajo, double codigo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT idLiquidacion");
            sql.Append(", legajo");
            sql.Append(", codigo");
            sql.Append(", valor");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" idLiquidacion = ");
            sql.Append(IdLiquidacion);
            sql.Append(" and legajo = ");
            sql.Append(legajo);
            sql.Append(" and codigo = ");
            sql.Append(codigo);
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


        public List<NovedadEntity> GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT idLiquidacion");
            sql.Append(", legajo");
            sql.Append(", codigo");
            sql.Append(", valor");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            return this.getLista(sql.ToString());
        }

        /// <summary>
        /// Devuelve dataset de novedades filtrada por idLiquidacion
        /// y otros criterios
        /// </summary>
        /// <param name="idLiquidacion"></param>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public DataSet GetAll(int idLiquidacion, string filtro)
        {
            DataSet ds;
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT novedades.idLiquidacion ");
            sql.Append(", empleados.legajo as Legajo");
            sql.Append(", empleados.nyap as Nombres");
            sql.Append(", novedades.codigo as Codigo");
            sql.Append(", tablas.descripcion as Descripcion");
            sql.Append(", novedades.valor as Valor");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" INNER JOIN empleados ON empleados.legajo = novedades.legajo ");
            sql.Append(" INNER JOIN tablas ON tablas.nombre = 'Novedades' AND tablas.indice = novedades.Codigo ");
            sql.Append(" where novedades.idLiquidacion = " + idLiquidacion);
            if (filtro.Length > 0)
                sql.Append(" and " + filtro);
            ds = Model.DB.ejecutarDataSet(Model.TipoComando.Texto, sql.ToString());
            return ds;
        }


        #endregion


        #region PRIVATE

        private NovedadEntity make(IDataReader reader)
        {
            NovedadEntity nove = new NovedadEntity(int.Parse(reader["idLiquidacion"].ToString()), int.Parse(reader["legajo"].ToString()), int.Parse(reader["codigo"].ToString()));
            nove.Valor = reader["valor"].ToString();
            return nove;
        }

        private List<NovedadEntity> getLista(string sql)
        {
            var novedades = new List<NovedadEntity>();
            try
            {
                using (IDataReader reader = Model.DB.ejecutarDataReader(Model.TipoComando.Texto, sql.ToString()))
                {
                    while (reader.Read())
                        novedades.Add(this.make(reader));
                }
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getListaNovedades(). " + ex.Message, ex);
                throw;
            }
            return novedades;
        }

        #endregion

    }
}
