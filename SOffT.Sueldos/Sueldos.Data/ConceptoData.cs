/*  
    ConceptoData.cs

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
    public class ConceptoData:GenericData
    {
        public ConceptoData() : base("calculo") { }

        #region ABM

        public int insert(ConceptoEntity conce)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Agregando: " + conce.Codigo.ToString());
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ");
                sql.Append(this.tabla);
                sql.Append(" VALUES(");
                sql.Append(conce.IdCalculo );
                sql.Append(", ");
                sql.Append(conce.OrdenDeProceso);
                sql.Append(", ");
                sql.Append(conce.Codigo);
                sql.Append(", '");
                sql.Append(conce.Descripcion);
                sql.Append("', '");
                sql.Append(conce.Formula);
                sql.Append("', ");
                sql.Append(conce.Tipo);
                sql.Append(", ");
                sql.Append(conce.Imprime ? 1 : 0);
                sql.Append(", ");
                sql.Append(conce.ImprimeCantidad ? 1 : 0);
                sql.Append(", ");
                sql.Append(conce.ImprimeVU ? 1 : 0);
                sql.Append(", ");
                sql.Append(conce.Desactivado ? 1 : 0);
                sql.Append(", ");
                sql.Append(conce.IdTipoLiquidacion);
                sql.Append(", ");
                sql.Append(conce.idAplicacion);
                sql.Append(", ");
                sql.Append(conce.IdCuentaContable);
                sql.Append(")");
                return Model.DB.ejecutarProceso(Model.TipoComando.Texto, sql.ToString());
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("insert(). " + ex.Message, ex);
                throw;
            }

        }

        public int update(ConceptoEntity conce)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Actualizando: " + conce.Codigo.ToString());
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE ");
                sql.Append(this.tabla);
                sql.Append(" SET");
                sql.Append(" descripcion = '");
                sql.Append(conce.Descripcion);
                sql.Append("', formula = '");
                sql.Append(conce.Formula);
                sql.Append("', tipo = ");
                sql.Append(conce.Tipo);
                sql.Append(", imprime = ");
                sql.Append(conce.Imprime ? 1 : 0);
                sql.Append(", imprimeCantidad = ");
                sql.Append(conce.ImprimeCantidad ? 1 : 0);
                sql.Append(", imprimeVU = ");
                sql.Append(conce.ImprimeVU ? 1 : 0);
                sql.Append(", desactivado = ");
                sql.Append(conce.Desactivado ? 1 : 0);
                sql.Append(", idTipoLiquidacion = ");
                sql.Append(conce.IdTipoLiquidacion );
                sql.Append(", idAplicacion = ");
                sql.Append(conce.idAplicacion );
                sql.Append(", idCuentaContable = ");
                sql.Append(conce.IdCuentaContable);
                sql.Append(" WHERE ");
                sql.Append(" idCalculo = ");
                sql.Append(conce.IdCalculo);
                sql.Append(" and OrdenProceso = ");
                sql.Append(conce.OrdenDeProceso);
                sql.Append(" and Codigo = ");
                sql.Append(conce.Codigo);
                return Model.DB.ejecutarProceso(Model.TipoComando.Texto, sql.ToString());
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("update(). " + ex.Message, ex);
                throw;
            }

        }

        public int delete(ConceptoEntity conce)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Eliminado id: " + conce.Codigo.ToString());
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" idCalculo = ");
            sql.Append(conce.IdCalculo);
            sql.Append(" and OrdenProceso = ");
            sql.Append(conce.OrdenDeProceso);
            sql.Append(" and Codigo = ");
            sql.Append(conce.Codigo);
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

        public ConceptoEntity getById(int idCalculo, int ordenProceso, double codigo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT idCalculo");
            sql.Append(", ordeProceso");
            sql.Append(", codigo");
            sql.Append(", descripcion");
            sql.Append(", formula");
            sql.Append(", tipo");
            sql.Append(", imprime");
            sql.Append(", imprimeCantidad");
            sql.Append(", imprimeVU");
            sql.Append(", desactivado");
            sql.Append(", idTipoLiquidacion");
            sql.Append(", idAplicacion");
            sql.Append(", idCuentaContable");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" idCalculo = ");
            sql.Append(idCalculo);
            sql.Append(" and ordeProceso = ");
            sql.Append(ordenProceso);
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


        public List<ConceptoEntity> GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT idCalculo");
            sql.Append(", OrdeProceso");
            sql.Append(", Codigo");
            sql.Append(", Descripcion");
            sql.Append(", Formula");
            sql.Append(", Tipo");
            sql.Append(", Imprime");
            sql.Append(", ImprimeCantidad");
            sql.Append(", ImprimeVU");
            sql.Append(", desactivado");
            sql.Append(", idTipoLiquidacion");
            sql.Append(", idAplicacion");
            sql.Append(", idCuentaContable");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            return this.getLista(sql.ToString());
        }

        /// <summary>
        /// Devuelve dataset de conceptos filtrado por idCalculo
        /// </summary>
        /// <param name="idLiquidacion"></param>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public DataSet GetAll(int idCalculo)
        {
            DataSet ds;
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT idCalculo");
            sql.Append(", OrdeProceso");
            sql.Append(", Codigo");
            sql.Append(", Descripcion");
            sql.Append(", Formula");
            sql.Append(", Tipo");
            sql.Append(", Imprime");
            sql.Append(", ImprimeCantidad");
            sql.Append(", ImprimeVU");
            sql.Append(", desactivado");
            sql.Append(", idTipoLiquidacion");
            sql.Append(", idAplicacion");
            sql.Append(", idCuentaContable");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" where idCalculo = " + idCalculo);
            ds = Model.DB.ejecutarDataSet(Model.TipoComando.Texto, sql.ToString());
            return ds;
        }


        #endregion


        #region PRIVATE

        private ConceptoEntity make(IDataReader reader)
        {
            ConceptoEntity conce = new ConceptoEntity( int.Parse(reader["idCalculo"].ToString()), int.Parse(reader["ordenProceso"].ToString()), int.Parse(reader["codigo"].ToString()));
            conce.Descripcion = reader["descripcion"].ToString();
            conce.Formula = reader["formula"].ToString();
            conce.Tipo = int.Parse(reader["tipo"].ToString());
            conce.Imprime = Boolean.Parse(reader["imprime"].ToString());
            conce.ImprimeCantidad = Boolean.Parse(reader["imprimeCantidad"].ToString());
            conce.ImprimeVU = Boolean.Parse(reader["imprimeVU"].ToString());
            conce.Desactivado = Boolean.Parse(reader["desactivado"].ToString());
            conce.IdTipoLiquidacion = int.Parse(reader["idTipoLiquidacion"].ToString());
            conce.idAplicacion = int.Parse(reader["idAplicacion"].ToString());
            conce.IdCuentaContable = int.Parse(reader["idCuentaContable"].ToString());
            return conce;
        }

        private List<ConceptoEntity> getLista(string sql)
        {
            var conceptos = new List<ConceptoEntity>();
            try
            {
                using (IDataReader reader = Model.DB.ejecutarDataReader(Model.TipoComando.Texto, sql.ToString()))
                {
                    while (reader.Read())
                        conceptos.Add(this.make(reader));
                }
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getListaConceptos(). " + ex.Message, ex);
                throw;
            }
            return conceptos;
        }

        #endregion

    }
}
