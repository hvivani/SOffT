/*  
    FechaDePagoData.cs

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
    public class FechaDePagoData:GenericData
    {
        public FechaDePagoData() : base("fechasDePago") {}

        #region ABM

        public int insert(FechaDePagoEntity fecha)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Agregando: " + fecha.FechaDePago);
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ");
                sql.Append(this.tabla);
                sql.Append(" VALUES(");
                sql.Append(fecha.IdLiquidacion);
                sql.Append(", '");
                sql.Append(fecha.FechaDePago);
                sql.Append("')");
                return Model.DB.ejecutarProceso(Model.TipoComando.Texto, sql.ToString());
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("insert(). " + ex.Message, ex);
                throw;
            }

        }

        public int update(FechaDePagoEntity fecha)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Actualizando: " + fecha.FechaDePago);
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE ");
                sql.Append(this.tabla);
                sql.Append(" SET");
                sql.Append(" fechaDePago = '");
                sql.Append(fecha.FechaDePago);
                sql.Append("'");
                sql.Append(" WHERE ");
                sql.Append(" idLiquidacion = ");
                sql.Append(fecha.IdLiquidacion);
                return Model.DB.ejecutarProceso(Model.TipoComando.Texto, sql.ToString());
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("update(). " + ex.Message, ex);
                throw;
            }

        }

        public int delete(FechaDePagoEntity fecha)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Eliminado id: " + fecha.FechaDePago);
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" idLiquidacion = ");
            sql.Append(fecha.IdLiquidacion);
            sql.Append(" and fechaDePago = '");
            sql.Append(fecha.FechaDePago + "'");
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

        public int delete(int idLiquidacion)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Eliminado id: " + idLiquidacion.ToString());
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" idLiquidacion = ");
            sql.Append(idLiquidacion);
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

        public FechaDePagoEntity getById(int id, DateTime fechadepago)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT idLiquidacion");
            sql.Append(", fechaDePago");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" idLiquidacion = " + id);
            sql.Append(" and fechaDePago = '" + fechadepago + "'");
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

        public List<FechaDePagoEntity> GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT idLiquidacion");
            sql.Append(", fechaDePago");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            return this.getLista(sql.ToString());
        }


        public List<FechaDePagoEntity> GetAll(int idLiquidacion)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT idLiquidacion");
            sql.Append(", fechaDePago");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" idLiquidacion = " + idLiquidacion);
            return this.getLista(sql.ToString());
        }

        #endregion


        #region PRIVATE

        private FechaDePagoEntity make(IDataReader reader)
        {
            FechaDePagoEntity fecha = new FechaDePagoEntity(int.Parse(reader["idLiquidacion"].ToString()), DateTime.Parse(reader["fechaDePago"].ToString()));
            return fecha;
        }

        private List<FechaDePagoEntity> getLista(string sql)
        {
            var fechas = new List<FechaDePagoEntity>();
            try
            {
                using (IDataReader reader = Model.DB.ejecutarDataReader(Model.TipoComando.Texto, sql.ToString()))
                {
                    while (reader.Read())
                        fechas.Add(this.make(reader));
                }
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getListaTablas(). " + ex.Message, ex);
                throw;
            }
            return fechas;
        }

        #endregion


    }
}
