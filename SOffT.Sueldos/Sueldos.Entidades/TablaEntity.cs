/*  
    TablaEntity.cs

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
    public class TablaEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Indice { get; set; }
        public string Descripcion { get; set; }
        public double Contenido { get; set; }
        public string Detalle { get; set; }
        public int Identidad {get; set;}


        public TablaEntity() 
        {
            this.Id = 0;
            this.Nombre = string.Empty;
            this.Indice = 0;
            this.Descripcion = string.Empty;
            this.Contenido = 0;
            this.Detalle = string.Empty;
            this.Identidad = 0;
        }

        public TablaEntity(int id)
        {
            this.Id = id;
        }

        public TablaEntity(string nombre, int indice, double contenido)
        {
            this.Id = 0;
            this.Nombre = nombre;
            this.Indice = indice;
            this.Contenido = contenido;

            this.Descripcion = string.Empty;
            this.Detalle = string.Empty;
            this.Identidad = 0;
        }
    }
}
