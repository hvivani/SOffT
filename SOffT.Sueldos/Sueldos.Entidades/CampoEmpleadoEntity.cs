/*  
    CampoEmpleadoEntity.cs

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
    public class CampoEmpleadoEntity
    {
        private int legajo;
        private string nombre;
        private int codigo;
        private string descripcion;
        private string valor;
        private string detalle;

        public CampoEmpleadoEntity() { }

        public CampoEmpleadoEntity(int codigo, string descripcion, string valor, string detalle)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.valor = valor;
            this.detalle = detalle;
        }

        public CampoEmpleadoEntity(int legajo, string nombre, int codigo, string descripcion, string valor,string detalle) 
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.valor = valor;
            this.detalle = detalle;
        }

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
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
        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
    }
}
