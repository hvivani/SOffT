/*  
    LiquidacionDetalleData.cs

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
    public class LiquidacionDetalleData:GenericData 
    {
        public LiquidacionDetalleData() : base("LiquidacionesDetalle") { }

        #region ABM

        public int insert(LiquidacionDetalleEntity liqdet)
        {
            int salida = 0;
            //int salidaFechas = 0;
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Agregando: " + liqdet.Id);
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ");
                sql.Append(this.tabla);
                sql.Append(" VALUES(");
               // sql.Append(liqdet.Id);
               // sql.Append(", ");
                sql.Append(liqdet.AnioMes);
                sql.Append(", ");
                sql.Append(liqdet.IdAplicacion);
                sql.Append(", ");
                sql.Append(liqdet.IdTipoSalario);
                sql.Append(", '");
                sql.Append(liqdet.Descripcion);
                sql.Append("', '");
                sql.Append(liqdet.FechaLiquidacion);
                sql.Append("', '");
                sql.Append(liqdet.PeriodoLiquidado);
                sql.Append("', '");
                sql.Append(liqdet.LugarDePago);
                sql.Append("', '");
                sql.Append(string.Empty );
                sql.Append("', '");
                sql.Append(liqdet.PeriodoDepositado);
                sql.Append("', '");
                sql.Append(liqdet.BancoDepositado);
                sql.Append("', '");
                sql.Append(liqdet.FechaDepositado);
                sql.Append("', ");
                sql.Append(liqdet.Estado ? 1 : 0);
                sql.Append(", ");
                sql.Append(liqdet.RecibosSeparados ? 1 : 0);
                sql.Append(", ");
                sql.Append(liqdet.Eliminado ? 1 : 0);
                sql.Append(")");

                salida = Model.DB.ejecutarProceso(Model.TipoComando.Texto, sql.ToString());
                //salidaFechas = this.insertFechasDePago(liqdet.FechasDePago);

                return salida; //+ salidaFechas;
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("insert(). " + ex.Message, ex);
                throw;
            }
        }

        public int insertFechasDePago(List<FechaDePagoEntity> fechas)
        {
            int salida = 0;
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Agregando fechas de pago: " + fechas.ToString());
            try
            {
                using (var fechadepagoData = new FechaDePagoData())
                {
                    foreach (FechaDePagoEntity f in fechas)
                        fechadepagoData.insert(f);
                }
                return salida;
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("insert(). fechas de pago" + ex.Message, ex);
                return -1;
                throw;
            }
        }

        public int update(LiquidacionDetalleEntity liqdet)
        {
            int salida = 0;
            int salidaFechas = 0;
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Actualizando: " + liqdet.Id);
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE ");
                sql.Append(this.tabla);
                sql.Append(" SET");
                sql.Append(" aniomes = ");
                sql.Append(liqdet.AnioMes);
                sql.Append(", idAplicacion = ");
                sql.Append(liqdet.IdAplicacion);
                sql.Append(", idTipoSalario = ");
                sql.Append(liqdet.IdTipoSalario);
                sql.Append(", descripcion = '");
                sql.Append(liqdet.Descripcion);
                sql.Append("', fechaLiquidacion = '");
                sql.Append(liqdet.FechaLiquidacion);
                sql.Append("', periodoLiquidado = '");
                sql.Append(liqdet.PeriodoLiquidado);
                sql.Append("', lugarDePago = '");
                sql.Append(liqdet.LugarDePago );
                //sql.Append("', fechaDePago = '");
                //sql.Append(liqdet.FechaDePago);
                sql.Append("', periodoDepositado = '");
                sql.Append(liqdet.PeriodoDepositado);
                sql.Append("', bancoDepositado = '");
                sql.Append(liqdet.BancoDepositado);
                sql.Append("', fechaDepositado = '");
                sql.Append(liqdet.FechaDepositado);
                sql.Append("', estado = ");
                sql.Append(liqdet.Estado ? 1 : 0);
                sql.Append(", recibosSeparados = ");
                sql.Append(liqdet.RecibosSeparados ? 1 : 0);
                sql.Append(", eliminado = ");
                sql.Append(liqdet.Eliminado ? 1 : 0);
                sql.Append(" WHERE ");
                sql.Append(" id = ");
                sql.Append(liqdet.Id);
                salida = Model.DB.ejecutarProceso(Model.TipoComando.Texto, sql.ToString());
                salidaFechas = this.deleteFechasDePago(liqdet.Id);//primero elimino las existentes
                salidaFechas = this.insertFechasDePago(liqdet.FechasDePago);//luego inserto
                return salida + salidaFechas;
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("update(). " + ex.Message, ex);
                throw;
            }
        }

        public int updateFechasDePago(List<FechaDePagoEntity> fechas)
        {
            int salida = 0;
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Actualizando fechas de pago: " + fechas.ToString());
            try
            {
                using (var fechadepagoData = new FechaDePagoData())
                {
                    foreach (FechaDePagoEntity f in fechas)
                        fechadepagoData.update(f);
                }
                return salida;
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("update(). fechas de pago" + ex.Message, ex);
                return -1;
                throw;
            }
        }



        public int delete(LiquidacionDetalleEntity liqdet)
        {
            int salida = 0;
            int salidaFechas = 0;
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Eliminado id: " + liqdet.Id);
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("update ");
                sql.Append(this.tabla);
                sql.Append(" set eliminado = 1 where");
                sql.Append(" id = ");
                sql.Append(liqdet.Id);

                salida=Model.DB.ejecutarProceso(Model.TipoComando.Texto, sql.ToString());
                salidaFechas=this.deleteFechasDePago(liqdet.Id);
                return salida+salidaFechas;
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("delete(). " + ex.Message, ex);
                throw;
            }

        }

        public int deleteFechasDePago(List<FechaDePagoEntity> fechas)
        {
            int salida = 0;
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Eliminando fechas de pago: " + fechas.ToString());
            try
            {
                using (var fechadepagoData = new FechaDePagoData())
                {
                    foreach (FechaDePagoEntity f in fechas)
                        fechadepagoData.delete(f);
                }
                return salida;
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("delete(). fechas de pago" + ex.Message, ex);
                return -1;
                throw;
            }
        }

        public int deleteFechasDePago(int idLiquidacion)
        {
            int salida = 0;
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Eliminando fechas de pago: " + idLiquidacion);
            try
            {
                using (var fechadepagoData = new FechaDePagoData())
                    fechadepagoData.delete(idLiquidacion);

                return salida;
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("delete(). fechas de pago" + ex.Message, ex);
                return -1;
                throw;
            }
        }


        #endregion


        #region SELECTs

        public LiquidacionDetalleEntity getById(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id");
            sql.Append(", aniomes");
            sql.Append(", idAplicacion");
            sql.Append(", idTipoSalario");
            sql.Append(", descripcion");
            sql.Append(", fechaLiquidacion");
            sql.Append(", periodoLiquidado");
            sql.Append(", lugarDePago");
           // sql.Append(", fechaDePago");
            sql.Append(", periodoDepositado");
            sql.Append(", bancoDepositado");
            sql.Append(", fechaDepositado");
            sql.Append(", estado");
            sql.Append(", recibosSeparados");
            sql.Append(", eliminado");
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


        public LiquidacionDetalleEntity getById(int aniomes, int idAplicacion, DateTime fechaLiquidacion)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id");
            sql.Append(", aniomes");
            sql.Append(", idAplicacion");
            sql.Append(", idTipoSalario");
            sql.Append(", descripcion");
            sql.Append(", fechaLiquidacion");
            sql.Append(", periodoLiquidado");
            sql.Append(", lugarDePago");
          //  sql.Append(", fechaDePago");
            sql.Append(", periodoDepositado");
            sql.Append(", bancoDepositado");
            sql.Append(", fechaDepositado");
            sql.Append(", estado");
            sql.Append(", recibosSeparados");
            sql.Append(", eliminado");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" aniomes = " + aniomes );
            sql.Append(" and idAplicacion = " + idAplicacion);
            sql.Append(" and fechaLiquidacion = '" + fechaLiquidacion + "'");
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
        /// Consulta si una liquidación por estado y aniomes. Devuelve el id o cero si no la encuentra
        /// </summary>
        /// <param name="aniomes"></param>
        /// <param name="idAplicacion"></param>
        /// <param name="fechaLiquidacion"></param>
        /// <returns></returns>
        public int getIdByEstado(int aniomes, int estado)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT isnull(id,0) as id");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" aniomes = " + aniomes);
            sql.Append(" and estado = " + estado);
            try
            {
                return int.Parse(Model.DB.ejecutarScalar(Model.TipoComando.Texto , sql.ToString()).ToString());
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getById(). " + ex.Message, ex);
                throw;
            }
        }
        
        public List<LiquidacionDetalleEntity> getByEstado(int estado)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id");
            sql.Append(", aniomes");
            sql.Append(", idAplicacion");
            sql.Append(", idTipoSalario");
            sql.Append(", descripcion");
            sql.Append(", fechaLiquidacion");
            sql.Append(", periodoLiquidado");
            sql.Append(", lugarDePago");
         //   sql.Append(", fechaDePago");
            sql.Append(", periodoDepositado");
            sql.Append(", bancoDepositado");
            sql.Append(", fechaDepositado");
            sql.Append(", estado");
            sql.Append(", recibosSeparados");
            sql.Append(", eliminado");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" WHERE ");
            sql.Append(" eliminado = 0 and estado=" + estado);
            return this.getLista(sql.ToString());
        }


        public List<LiquidacionDetalleEntity> GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id");
            sql.Append(", aniomes");
            sql.Append(", idAplicacion");
            sql.Append(", idTipoSalario");
            sql.Append(", descripcion");
            sql.Append(", fechaLiquidacion");
            sql.Append(", periodoLiquidado");
            sql.Append(", lugarDePago");
         //   sql.Append(", fechaDePago");
            sql.Append(", periodoDepositado");
            sql.Append(", bancoDepositado");
            sql.Append(", fechaDepositado");
            sql.Append(", estado");
            sql.Append(", recibosSeparados");
            sql.Append(", eliminado");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            return this.getLista(sql.ToString());
        }

        public DataSet GetAllGrilla()
        {
            try
            {
                DataSet ds;
                ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "liquidacionesDetalleConsultarParaGrilla");
                return ds;
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getAll(). " + ex.Message, ex);
                throw;
            }

        }

        #endregion


        #region PRIVATE

        private LiquidacionDetalleEntity make(IDataReader reader)
        {
            LiquidacionDetalleEntity liqdet = new LiquidacionDetalleEntity(int.Parse(reader["aniomes"].ToString()), int.Parse(reader["idAplicacion"].ToString()), DateTime.Parse(reader["fechaLiquidacion"].ToString()));
            liqdet.Id = int.Parse(reader["id"].ToString());
            liqdet.IdTipoSalario = int.Parse(reader["idTipoSalario"].ToString());
            liqdet.Descripcion = reader["descripcion"].ToString();
            liqdet.PeriodoLiquidado = reader["periodoLiquidado"].ToString();
            liqdet.LugarDePago = reader["lugarDePago"].ToString();
            //liqdet.FechaDePago = reader["fechaDePago"] == DBNull.Value ? new DateTime(0) : DateTime.Parse(reader["fechaDePago"].ToString());
            liqdet.PeriodoDepositado = reader["periodoDepositado"].ToString();
            liqdet.BancoDepositado = reader["bancoDepositado"].ToString();
            liqdet.FechaDepositado = reader["fechaDepositado"] == DBNull.Value ? new DateTime(0) : DateTime.Parse(reader["fechaDepositado"].ToString());
            liqdet.Estado = Boolean.Parse(reader["Estado"].ToString());
            liqdet.RecibosSeparados = Boolean.Parse(reader["recibosSeparados"].ToString());
            liqdet.Eliminado = Boolean.Parse(reader["eliminado"].ToString());

            //cargo fechas de pago
            using (var fechadepagoData = new FechaDePagoData())
            {
                liqdet.FechasDePago = fechadepagoData.GetAll(liqdet.Id);
            }


            return liqdet;
        }

        private List<LiquidacionDetalleEntity> getLista(string sql)
        {
            var liquidaciones = new List<LiquidacionDetalleEntity>();
            try
            {
                using (IDataReader reader = Model.DB.ejecutarDataReader(Model.TipoComando.Texto, sql.ToString()))
                {
                    while (reader.Read())
                        liquidaciones.Add(this.make(reader));
                }
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getListaLiquidacionesDetalle(). " + ex.Message, ex);
                throw;
            }
            return liquidaciones;
        }

        #endregion

    }
}
