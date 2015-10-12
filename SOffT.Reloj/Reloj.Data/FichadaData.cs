/*  
    FichadaData.cs

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
    public class FichadaData : GenericData
    {
        public FichadaData() : base("reloj") { }

        #region ABM

        public int Insert(FichadaEntity fichada)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Agregando: " + fichada.ToString());
            try
            {
                return Model.DB.ejecutarProceso(Model.TipoComando.SP, "relojInsertarCaptura", "legajo", fichada.Legajo , "fecha", fichada.Fecha , "hora", fichada.Hora , "idReloj", fichada.Reloj==null ? 0 : fichada.Reloj.Contenido );
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("insert(). " + ex.Message, ex);
                throw;
            }
        }

        //DESARROLLAR PARA USAR EN EL ABM DE FICHADAS
    /*    public int Update(FichadaEntity fichada)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Actualizando: " + fichada.ToString());
            try
            {
                return Model.DB.ejecutarProceso(Model.TipoComando.SP, "relojActualizar", "@legajo", fichada.Legajo, "@fecha", fichada.Fecha, "@hora", fichada.Hora , "@idTipoMovimiento", Convert.ToInt32(this.cmbMovimientos.SelectedValue), "@idEstadoFichada", 3);
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("update(). " + ex.Message, ex);
                throw;
            }
        }*/

        //DESARROLLAR PARA USAR EN EL ABM DE FICHADAS
        /*public int Delete(FichadaEntity fichada)
        {
            MyLog4Net.Instance.getCustomLog(this.GetType()).Info("Borrando idFichada: " + fichada.GetId());
            StringBuilder sql = new StringBuilder();
            try
            {
                return Model.DB.ejecutarProceso(Model.TipoComando.SP, "relojEliminar", "@id", Controles.consultaCampoRenglon(this.dgvFichadas, 0));
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("delete(). " + ex.Message, ex);
                throw;
            }
        }*/

        #endregion

        #region SELECTs

        public FichadaEntity GetBy(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id");
            sql.Append(", legajo");
            sql.Append(", fecha");
            sql.Append(", hora");
            sql.Append(", idReloj");
            sql.Append(", idTipoMovimiento");
            sql.Append(", idEstadoFichada");
            sql.Append(", horaServidor");
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

        public List<FichadaEntity> GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id");
            sql.Append(", legajo");
            sql.Append(", fecha");
            sql.Append(", hora");
            sql.Append(", idReloj");
            sql.Append(", idTipoMovimiento");
            sql.Append(", idEstadoFichada");
            sql.Append(", horaServidor");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" ORDER BY fecha, hora ");
            return this.getLista(sql.ToString());
        }

        public List<FichadaEntity> GetEntreFechas(System.DateTime desde, System.DateTime hasta )
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id");
            sql.Append(", reloj.fecha");
            sql.Append(", Convert(varchar(50),reloj.hora,108)  as hora");
            sql.Append(", reloj.legajo");
            sql.Append(", empleados.nyap");
            sql.Append(@", REPLACE(foto, '\\curie\sistemas\personal\Fotos\', './fotos/') AS foto");
            sql.Append(", reloj.idReloj");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" INNER JOIN empleados ");
            sql.Append(" ON empleados.legajo = reloj.legajo");
            sql.Append(" WHERE reloj.fecha >= '" + desde + "'");
            sql.Append(" AND reloj.fecha <= '" + hasta + "'"); 
            sql.Append (" AND (empleados.eliminado = 0) ");
            sql.Append(" ORDER BY fecha, hora desc");
            return this.getLista(sql.ToString());
        }

        public DataSet GetAll(System.DateTime desde, System.DateTime hasta)
        {
            DataSet ds;
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id");
            sql.Append(", reloj.fecha");
            sql.Append(", Convert(varchar(50),reloj.hora,108)  as hora");
            sql.Append(", reloj.legajo");
            sql.Append(", empleados.nyap");
            sql.Append(@", REPLACE(foto, '\\curie\sistemas\personal\Fotos\', './fotos/') AS foto");
            sql.Append(", reloj.idReloj");
            sql.Append(" FROM ");
            sql.Append(this.tabla);
            sql.Append(" INNER JOIN empleados ");
            sql.Append(" ON empleados.legajo = reloj.legajo");
            sql.Append(" WHERE reloj.fecha >= '" + desde + "'");
            sql.Append(" AND reloj.fecha <= '" + hasta + "'");
            sql.Append(" AND (empleados.eliminado = 0) ");
            sql.Append(" ORDER BY fecha, hora desc");
            ds = Model.DB.ejecutarDataSet(Model.TipoComando.Texto, sql.ToString());
            return ds;
        }

        #endregion

        #region PRIVATE

        private FichadaEntity make(IDataReader reader)
        {
            FichadaEntity fichada =
                new FichadaEntity(int.Parse(reader["id"].ToString()));
            fichada.Legajo = int.Parse(reader["legajo"].ToString());
            fichada.Fecha = DateTime.Parse(reader["fecha"].ToString()).ToShortDateString();
            fichada.Hora = reader["hora"].ToString();
            fichada.Foto = reader["foto"].ToString();
            using (EmpleadoData empleadoData = new EmpleadoData())
            {
                fichada.ApellidoYnombres = empleadoData.getNombresByLegajo(fichada.Legajo);
            }
            using (TablaData tablaData = new TablaData())
            {
                int idReloj = int.Parse(reader["idReloj"].ToString());
                fichada.Reloj = (TablaEntity)tablaData.getById("reloj",3,idReloj);
            }
            //falta asignar:
            //reloj.TipoMovimiento
            //reloj.EstadoFichada
            //reloj.HoraServidor
            
            return fichada;
        }

        private List<FichadaEntity> getLista(string sql)
        {
            var fichadas = new List<FichadaEntity>();
            try
            {
                using (IDataReader reader = Model.DB.ejecutarDataReader(Model.TipoComando.Texto,sql))
                {
                    while (reader.Read())
                        fichadas.Add(this.make(reader));
                }
            }
            catch (Exception ex)
            {
                MyLog4Net.Instance.getCustomLog(this.GetType()).Error("getListaFichadas(). " + ex.Message, ex);
                throw;
            }
            return fichadas;
        }

        #endregion
    }
}
