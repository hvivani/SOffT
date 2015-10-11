/*  
    LiquidacionPorTipo.cs

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
    public class LiquidacionPorTipoData: GenericData
    {
        public LiquidacionPorTipoData() : base("liquidacionesPorTipo") { }

        #region ABM

        public int insert(LiquidacionPorTipoEntity liqui)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Agregando: " + liqui.IdLiquidacion);
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ");
                sql.Append(this.tabla);
                sql.Append(" VALUES(");
                sql.Append(liqui.IdLiquidacion);
                sql.Append(", ");
                sql.Append(liqui.IdTipoLiquidacion);
                sql.Append(", ");
                sql.Append(liqui.Seleccionado ? 1 : 0);
                sql.Append(") ");

                return Model.DB.ejecutarProceso(Model.TipoComando.Texto, sql.ToString());
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("insert(). " + ex.Message, ex);
                throw;
            }

        }

        public int update(LiquidacionPorTipoEntity liqui)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Actualizando: " + liqui.IdLiquidacion );
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE ");
                sql.Append(this.tabla);
                sql.Append(" SET");
                sql.Append(" seleccionado = ");
                sql.Append(liqui.Seleccionado ? 1 : 0);
                sql.Append(" WHERE ");
                sql.Append(" idLiquidacion = ");
                sql.Append(liqui.IdLiquidacion );
                sql.Append(" and idTipoLiquidacion = ");
                sql.Append(liqui.IdTipoLiquidacion );
                return Model.DB.ejecutarProceso(Model.TipoComando.Texto, sql.ToString());
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("update(). " + ex.Message, ex);
                throw;
            }

        }

        public int delete(LiquidacionPorTipoEntity liqui)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Eliminado id: " + liqui.IdLiquidacion);
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" idLiquidacion = ");
            sql.Append(liqui.IdLiquidacion);
            sql.Append(" and idTipoLiquidacion = ");
            sql.Append(liqui.IdTipoLiquidacion);
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


        #region SELECTS

        public LiquidacionPorTipoEntity getById(int idLiquidacion, int idTipoLiquidacion)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT idLiquidacion");
            sql.Append(", idTipoLiquidacion");
            sql.Append(", seleccionado");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" idLiquidacion = " + idLiquidacion);
            sql.Append(" and idTipoLiquidacion = " + idTipoLiquidacion );
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

        public List<LiquidacionPorTipoEntity> GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT idLiquidacion");
            sql.Append(", idTipoLiquidacion");
            sql.Append(", seleccionado");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            return this.getLista(sql.ToString());
        }


        public List<LiquidacionPorTipoEntity> GetAll(int idLiquidacion)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT idLiquidacion");
            sql.Append(", idTipoLiquidacion");
            sql.Append(", seleccionado");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" idLiquidacion = " + idLiquidacion);
            return this.getLista(sql.ToString());
        }


        #endregion


        #region PRIVATE

        private LiquidacionPorTipoEntity make(IDataReader reader)
        {
            LiquidacionPorTipoEntity liqui = new  LiquidacionPorTipoEntity(int.Parse(reader["idLiquidacion"].ToString()), int.Parse(reader["idTipoLiquidacion"].ToString()));
            liqui.Seleccionado = Boolean.Parse(reader["seleccionado"].ToString());
            return liqui;
        }

        private List<LiquidacionPorTipoEntity> getLista(string sql)
        {
            var liquis = new List<LiquidacionPorTipoEntity>();
            try
            {
                using (IDataReader reader = Model.DB.ejecutarDataReader(Model.TipoComando.Texto, sql.ToString()))
                {
                    while (reader.Read())
                        liquis.Add(this.make(reader));
                }
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getListaLiquis(). " + ex.Message, ex);
                throw;
            }
            return liquis;
        }

        #endregion

    }
}
