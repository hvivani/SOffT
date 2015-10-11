/*  
    Liquidacion.cs

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
using System.Data.Common;

namespace Sueldos.View
{
    class Liquidacion
    {
        private int id;
        private int anioMes;
        private int idAplicacion;
        private int idTipoSalario;
        private string descripcion;
        private DateTime fechaLiquidacion;
        private string periodoLiquidado;
        private string lugarDePago;
        private IList<DateTime> fechasDePago;
        private string periodoDepositado;
        private string bancoDepositado;
        private DateTime fechaDepositado;
        private Boolean idEstado;
        private Boolean recibosSeparados;


        public Liquidacion()
        {
            this.fechasDePago = new List<DateTime>();
        }

        /// <summary>
        /// Constructor para Liquidacion existente.
        /// </summary>
        /// <param name="anioMes">AnioMes de liquidacion</param>
        /// <param name="indice">idTabla=indice de tabla de liquidacion</param>
        public Liquidacion(int idLiquidacion)
        {
            this.id = idLiquidacion;
            this.fechasDePago = new List<DateTime>();
            this.cargarDatos();
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int AnioMes
        {
            get { return anioMes; }
            set { anioMes = value; }
        }

        public int IdAplicacion
        {
            get { return idAplicacion; }
            set { idAplicacion = value; }
        }

        public int IdTipoSalario
        {
            get { return idTipoSalario; }
            set { idTipoSalario = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public DateTime FechaLiquidacion
        {
            get { return fechaLiquidacion; }
            set { fechaLiquidacion = value; }
        }

        public string PeriodoLiquidado
        {
            get { return periodoLiquidado; }
            set { periodoLiquidado = value; }
        }

        public string LugarDePago
        {
            get { return lugarDePago; }
            set { lugarDePago = value; }
        }

        public IList<DateTime> FechasDePago
        {
            get { return fechasDePago; }
            set { fechasDePago = value; }
        }

        public string PeriodoDepositado
        {
            get { return periodoDepositado; }
            set { periodoDepositado = value; }
        }

        public string BancoDepositado
        {
            get { return bancoDepositado; }
            set { bancoDepositado = value; }
        }

        public DateTime FechaDepositado
        {
            get { return fechaDepositado; }
            set { fechaDepositado = value; }
        }


        public Boolean IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }

        public Boolean RecibosSeparados
        {
            get { return recibosSeparados; }
            set { recibosSeparados = value; }
        }

        protected void cargarDatos()
        {
            //cargo datos liquidacion
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP,"liquidacionesDetalleConsultar", "@id", this.id );
            if (rs.Read())
            {
                this.anioMes = Convert.ToInt32(rs["anioMes"]);
                this.idAplicacion = Convert.ToInt32(rs["idAplicacion"]);
                this.idTipoSalario = Convert.ToInt32(rs["idTipoSalario"]);
                this.descripcion = rs["Descripcion"].ToString();
                this.fechaLiquidacion = Convert.ToDateTime(rs["fechaLiquidacion"]);
                this.periodoLiquidado = rs["periodoLiquidado"].ToString();
                this.lugarDePago = rs["lugarDePago"].ToString();
              //  this.fechasDePago[0] = Convert.ToDateTime(rs["fechaDePago"]);
              //  this.cargarFechasDePago();
                this.periodoDepositado = rs["periodoDepositado"].ToString();
                this.bancoDepositado = rs["bancoDepositado"].ToString();
                this.fechaDepositado = Convert.ToDateTime(rs["fechaDepositado"]);
                this.idEstado = Convert.ToBoolean(rs["estado"]);
                this.recibosSeparados = Convert.ToBoolean(rs["recibosSeparados"]);

            }
            Model.DB.desconectarDB();
        }

    /*    private void cargarFechasDePago()
        {
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "fechasDePagoConsultar", "@idLiquidacion", this.id);
            while (rs.Read())
                this.fechasDePago.Add(Convert.ToDateTime(rs["fechaDePago"]));
            Model.DB.desconectarDB();
        }*/

   /*     private void grabarFechasDePago()
        {
            //primero elimino las actuales
            Model.DB.ejecutarProceso(Model.TipoComando.SP, "fechasDePagoEliminarTodas", "@idLiquidacion", this.id);
            for (int i = 0; i < this.fechasDePago.Count; i++)
                Model.DB.ejecutarProceso(Model.TipoComando.SP, "fechasDePagoInsertar", "@idLiquidacion", this.id, "@fechaDePago", this.fechasDePago[i]);
        }*/

   /*     public void grabar()
        {   //graba y luego obtiene el id grabado para ser asignado al objeto.
            Model.DB.ejecutarProceso(Model.TipoComando.SP, "liquidacionesDetalleActualizar", "@AnioMes", this.anioMes, "@idAplicacion", this.idAplicacion, "@idTipoSalario", this.idTipoSalario, "@descripcion", this.descripcion, "@fechaLiquidacion", this.fechaLiquidacion, "@periodoLiquidado", this.periodoLiquidado, "@lugarDePago", this.lugarDePago, "@periodoDepositado", this.periodoDepositado, "@bancoDepositado", this.bancoDepositado, "@fechaDepositado", this.fechaDepositado, "@estado", this.idEstado, "@recibosSeparados", this.recibosSeparados);
            this.id = Convert.ToInt32(Model.DB.ejecutarScalar(Model.TipoComando.SP, "liquidacionesDetalleConsultaNueva",  "@AnioMes",this.anioMes, "@idAplicacion", this.idAplicacion, "@fechaLiquidacion", this.FechaLiquidacion ));
            this.grabarFechasDePago();
        }*/

   /*     public static Boolean consultarAnioMesAbierta(int anioMes)
        {
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesDetalleConsultarAnioMesAbierta", "@anioMes", anioMes);
            if (rs.Read())
            {
                Model.DB.desconectarDB();
                return true;
            }
            else
            {
                Model.DB.desconectarDB();
                return false;
            }
            
        }*/

    /*    public static Boolean hayConveniosAsociados(int idTipoLiq)
        {
            DbDataReader rsLiquidaciones;
            rsLiquidaciones = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "tablasConsultarConveniosAsociadosAliquidaciones", "@idTipoLiquidacion", idTipoLiq);
            if (rsLiquidaciones.Read())
            {
                if (Convert.ToInt32(rsLiquidaciones["contenido"]) > 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }*/

    }

}
