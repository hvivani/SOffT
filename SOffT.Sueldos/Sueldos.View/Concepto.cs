/*  
    Concepto.cs

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
using System.Data;
using System.Data.Common;

namespace Sueldos.View
{
    class Concepto
    {

        public Concepto() { }

        /// <summary>
        /// constructor para cargar datos de un concepto existente
        /// </summary>
        /// <param name="codigo"></param>
        public Concepto(int codigo, int idcalculo)
        {
            this.codigo = codigo;
            this.idCalculo = idcalculo;
        }

        private int idCalculo;
        private int ordenDeProceso;
        private int codigo;
        private string descripcion;
        private string formula;
        private byte tipo;
        private Boolean imprime;
        private Boolean imprimeCantidad;
        private Boolean imprimeValorUnitario;
        private Boolean desactivado;
        private int idTipoLiquidacion;
        private int idAplicacion;
        private int idCuentaContable;

        public int IdCalculo
        {
            get { return idCalculo; }
            set { idCalculo = value; }
        }

        public int OrdenDeProceso
        {
            get { return ordenDeProceso; }
            set { ordenDeProceso = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Formula
        {
            get { return formula; }
            set { formula = value; }
        }

        public byte Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Boolean Imprime
        {
            get { return imprime; }
            set { imprime = value; }
        }

        public Boolean ImprimeCantidad
        {
            get { return imprimeCantidad; }
            set { imprimeCantidad = value; }
        }

        public Boolean ImprimeValorUnitario
        {
            get { return imprimeValorUnitario; }
            set { imprimeValorUnitario = value; }
        }

        public Boolean Desactivado
        {
            get { return desactivado; }
            set { desactivado = value; }
        }

        public int IdTipoLiquidacion
        {
            get { return idTipoLiquidacion; }
            set { idTipoLiquidacion = value; }
        }

        public int IdAplicacion
        {
            get { return idAplicacion; }
            set { idAplicacion = value; }
        }

        public int IdCuentaContable
        {
            get { return idCuentaContable; }
            set { idCuentaContable = value; }
        }


        public void cargarDatosConcepto()
        {
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "calculoConsultar", "@codigo", this.codigo, "@idCalculo", this.idCalculo);
            if (rs.Read())
            {
                this.ordenDeProceso = Convert.ToInt32(rs["OrdenProceso"]);
                this.idCalculo = Convert.ToInt32(rs["idCalculo"]);
                this.descripcion = rs["Descripcion"].ToString();
                this.formula = rs["formula"].ToString();
                this.tipo = Convert.ToByte(rs["tipo"]);
                this.imprime = Convert.ToBoolean (rs["imprime"]);
                this.imprimeCantidad = Convert.ToBoolean(rs["imprimeCantidad"]);
                this.imprimeValorUnitario = Convert.ToBoolean(rs["imprimeVU"]);
                this.desactivado = Convert.ToBoolean(rs["desactivado"]);
                this.idTipoLiquidacion = Convert.ToInt32(rs["idTipoLiquidacion"]);
                this.idAplicacion = Convert.ToInt32(rs["idAplicacion"]);
                this.idCuentaContable = Convert.ToInt32(rs["idCuentaContable"]);
             }
            Model.DB.desconectarDB();
        }

        /// <summary>
        /// Obtiene el valor del campo del maestro del empleado a partir de la 
        /// descripcion del codigo del campo
        /// </summary>
        /// <param name="descripcionCampo"></param>
        /// <returns>p.e. 'obra social'</returns>
  /*      public string Empleado(string descripcionCampo)
        {
            int indice=0;
            string salida;

            SqlDataReader rs = DB.ejecutarSpDataReader("tablasConsultarIndiceDescripcion", "@descripcion", descripcionCampo);
            if (rs.Read())
                indice  = Convert.ToInt32(rs["indice"]);
            Model.DB.desconectarDB();

            if (indice > 0)
                salida = DB.ejecutarSpScalarStr("empleadosSueldosConsultarValorLegajo", "@legajo", 151, "@codigo", indice);
            else
                salida = "Error"; 
            return salida;
        }*/



    }
}
