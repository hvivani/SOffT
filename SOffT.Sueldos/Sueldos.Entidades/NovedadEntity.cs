/*  
    NovedadEntity.cs

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
    public class NovedadEntity
    {
        public int IdLiquidacion { get; set; }
        public int Legajo { get; set; }
        public int Codigo { get; set; }
        public string Valor { get; set; }

        public NovedadEntity() { }

        public NovedadEntity(int idLiquidacion, int legajo, int codigo)
        {
            this.IdLiquidacion = idLiquidacion;
            this.Legajo = legajo;
            this.Codigo = codigo;
        }


    }
}
