/*  
    HuellaData.cs

    Author:
    Hernan Vivani <hernan@vivani.com.ar> - http://hvivani.com.ar

    Copyright © SOffT 2008 - http://www.sofft.com.ar

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
using System.Text;

using Reloj.Entidades;
using Sueldos.Entidades;
using Sueldos.Data;
using Log4Net;

namespace Reloj.Data
{
    public class HuellaData : GenericData
    {
        public HuellaData() : base("huellas") { }

        #region ABM

        public int Insert(HuellaEntity huella)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Agregando: " + huella.ToString());
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ");
                sql.Append(this.tabla);
                sql.Append(" VALUES(");
                sql.Append(huella.Legajo);
                sql.Append(", ");
                sql.Append(huella.DedoHuella.Contenido);
                sql.Append(", '");
                sql.Append(huella.Huella);
                sql.Append("') ");
                return Model.DB.ejecutarProceso(Model.TipoComando.Texto, sql.ToString());

            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("insert(). " + ex.Message, ex);
                throw;
            }
        }

        public int Update(HuellaEntity huella)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Actualizando: " +  huella.ToString());
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE ");
                sql.Append(this.tabla);
                sql.Append(" SET");
                sql.Append(" huella = '");
                sql.Append(huella.Huella);
                sql.Append("' WHERE ");
                sql.Append(" legajo = ");
                sql.Append(huella.Legajo);
                sql.Append(" and idHuella = ");
                sql.Append(huella.DedoHuella.Contenido);
                return Model.DB.ejecutarProceso(Model.TipoComando.Texto, sql.ToString());

            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("update(). " + ex.Message, ex);
                throw;
            }
        }

        public int Delete(HuellaEntity huella)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Huella idFichada: " + huella.Legajo);
            StringBuilder sql = new StringBuilder();
            try
            {
                sql.Append("DELETE");
                sql.Append(" FROM ");
                sql.Append(this.tabla);
                sql.Append(" WHERE ");
                sql.Append(" legajo = ");
                sql.Append(huella.Legajo);
                sql.Append(" and idHuella = ");
                sql.Append(huella.DedoHuella.Contenido);
                return Model.DB.ejecutarProceso(Model.TipoComando.Texto, sql.ToString());
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("delete(). " + ex.Message, ex);
                throw;
            }
        }

        /// <summary>
        /// borra todas las huellas de un legajo
        /// </summary>
        /// <param name="huella"></param>
        /// <returns></returns>
        public int Delete(int legajo)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Eliminado Huellas legajo: " + legajo);
            StringBuilder sql = new StringBuilder();
            try
            {
                sql.Append("DELETE");
                sql.Append(" FROM ");
                sql.Append(this.tabla);
                sql.Append(" WHERE ");
                sql.Append(" legajo = ");
                sql.Append(legajo);
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

        public HuellaEntity GetBy(int legajo, int idHuella)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT legajo");
            sql.Append(", idHuella");
            sql.Append(", huella");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" legajo = ");
            sql.Append(legajo);
            sql.Append(" and idHuella = ");
            sql.Append(idHuella);
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

        public HuellaEntity GetBy(string huella)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT legajo");
            sql.Append(", idHuella");
            sql.Append(", huella");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" huella = '");
            sql.Append(huella);
            sql.Append("'");
            try
            {
                using (IDataReader reader = Model.DB.ejecutarDataReader(Model.TipoComando.Texto, sql.ToString()))
                {
                    return (reader.Read()) ? this.make(reader) : null;
                }
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getByHuella(). " + ex.Message, ex);
                throw;
            }
        }


        public List<HuellaEntity> GetBy(int legajo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT legajo");
            sql.Append(", idHuella");
            sql.Append(", huella");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" legajo = ");
            sql.Append(legajo);
            return this.getLista(sql.ToString());
        }


        public List<HuellaEntity> GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT legajo");
            sql.Append(", idHuella");
            sql.Append(", huella");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" ORDER BY legajo, idHuella ");
            return this.getLista(sql.ToString());
        }


        #endregion

        #region PRIVATE

        private HuellaEntity make(IDataReader reader)
        {
            HuellaEntity huella =
                new HuellaEntity(int.Parse(reader["legajo"].ToString()));

            using (TablaData tablaData = new TablaData())
            {
                int idHuella = int.Parse(reader["idHuella"].ToString());
                huella.DedoHuella = (TablaEntity)tablaData.getById("reloj", 4, idHuella);
            }
            huella.Huella = reader["huella"].ToString();
            return huella;
        }

        private List<HuellaEntity> getLista(string sql)
        {
            var huellas = new List<HuellaEntity>();
            try
            {
                using (IDataReader reader = Model.DB.ejecutarDataReader(Model.TipoComando.Texto, sql))
                {
                    while (reader.Read())
                        huellas.Add(this.make(reader));
                }
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getListaHuellas(). " + ex.Message, ex);
                throw;
            }
            return huellas;
        }

        #endregion
    }
}
