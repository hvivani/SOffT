/*  
    ReciboRenglon.cs

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
    class ReciboRenglon
    {
        private int idLiquidacion;
        private int idTipoLiquidacion;
        private int legajo;
        private int codigo;
        private int posicion;
        private char letra;
        private int anioMes;
        private int idCalculo;
        private int idAplicacion;
        private int ordenProceso;
        private double cantidad;
        private double vu;
        private double importe;

        public int IdLiquidacion
        {
            get { return idLiquidacion; }
            set { 
                this.idLiquidacion = value;
                DbDataReader rs = null;
                rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesDetalleConsultar",
                    "id", this.idLiquidacion
                    );
                if (rs.Read())
                {
                    //this.anioMes = anioMes;
                    //this.idAplicacion = idAplicacion;
                    /* idTipoSalario
                     * descripcion
                     * fechaLiquidacion
                     * periodoLiquidado
                     * lugarDePago
                     * fechaDePago
                     * periodoDepositado
                     * bancoDepositado
                     */
                }
                Model.DB.desconectarDB();
            }
        }

        public int IdTipoLiquidacion
        {
            get { return idTipoLiquidacion; }
            set { idTipoLiquidacion = value; }
        }

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set {
                codigo = value;
                DbDataReader rs = null;
                rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "calculoConsultar",
                    "codigo", this.codigo,
                    "idCalculo", this.idCalculo
                    );
                if (rs.Read())
                {
                    //idCalculo, OrdenProceso, Codigo, Descripcion, Formula, Tipo, Imprime, ImprimeCantidad, ImprimeVU, desactivado, idTipoLiquidacion, idAplicacion
                    this.ordenProceso = Convert.ToInt32(rs["OrdenProceso"]);
                    this.posicion = Convert.ToInt32(rs["Tipo"]);
                    this.idTipoLiquidacion = Convert.ToInt32(rs["idTipoLiquidacion"]);
                    this.idAplicacion = Convert.ToInt32(rs["idAplicacion"]);
                }
                Model.DB.desconectarDB();
            }
        }

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public double VU
        {
            get { return vu; }
            set { vu = value; }
        }
        
        public double Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        public int IdCalculo
        {
            get { return idCalculo; }
            set { idCalculo = value; }
        }
        
        #region BaseDatos

        public void CargarDatosConcepto()
        {

        }
        
        public void CargarDatos()
        {
            DbDataReader rs = null;
            rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "liquidacionesConsultarConcepto",
                "@idLiquidacion", this.idLiquidacion,
                "@legajo", this.legajo,
                "@codigo", this.codigo
                );
            if (rs.Read())
            {
                this.cantidad = Convert.ToDouble(rs["Cantidad"]);
                this.vu = Convert.ToDouble(rs["VU"]);
                this.importe = Convert.ToDouble(rs["Importe"]);
            }
            Model.DB.desconectarDB();
        }

        public void Actualizar()
        {
            Model.DB.ejecutarProceso(Model.TipoComando.SP, "liquidacionesActualizar",
                "idLiquidacion", this.idLiquidacion,
                "idTipoLiquidacion", this.idTipoLiquidacion,
                "legajo", this.legajo,
                "codigo", this.codigo,
                "cantidad", this.cantidad,
                "UV", this.vu,
                "importe", this.importe);
        }

        public void Grabar()
        {
            Model.DB.ejecutarProceso(Model.TipoComando.SP, "liquidacionesInsertar",
                "idLiquidacion", this.idLiquidacion,
                "idTipoLiquidacion", this.idTipoLiquidacion,
                "Legajo", this.legajo,
                "Codigo", this.codigo,
                "AnioMes", this.anioMes,
                "idCalculo", this.idCalculo,
                "idAplicacion", this.idAplicacion,
                "Posicion", this.posicion,
                "Cantidad", this.cantidad,
                "VU", this.vu,
                "Importe", this.importe,
                "Letra", this.letra,
                "OrdenProceso", this.ordenProceso);
        }
        #endregion
    }
}
