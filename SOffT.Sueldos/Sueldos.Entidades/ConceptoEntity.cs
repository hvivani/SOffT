/*  
    ConceptoEntity.cs

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

namespace Sueldos.Entidades
{
    public class ConceptoEntity
    {
        public int IdCalculo { get; set; }
        public int OrdenDeProceso { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Formula { get; set; }
        public int Tipo { get; set; }
        public Boolean Imprime { get; set; }
        public Boolean ImprimeCantidad { get; set; }
        public Boolean ImprimeVU { get; set; }
        public Boolean Desactivado { get; set; }
        public int IdTipoLiquidacion { get; set; }
        public int idAplicacion { get; set; }
        public int IdCuentaContable { get; set; }

        public ConceptoEntity() { }

        public ConceptoEntity(int idCalculo, int ordenDeProcesso, int codigo)
        {
            this.IdCalculo = idCalculo;
            this.OrdenDeProceso = ordenDeProcesso;
            this.Codigo = codigo;

            this.Descripcion = string.Empty;
            this.Formula = string.Empty;
        }

    }
}
