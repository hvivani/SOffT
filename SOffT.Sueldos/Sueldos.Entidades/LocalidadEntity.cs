/*  
    LocalidadEntity.cs

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
    class LocalidadEntity
    {
        private int id;
        private string nombreLocalidad;


        public LocalidadEntity() { }
        public LocalidadEntity(int id) { }
        
        public void setIdLocalidad(int id) { this.id = id; }
        public int getIdLocalidad(int id) { return this.id; }

        public void setNombreLocalidad(string descri) { this.nombreLocalidad = descri; }
        public string getIdLocalidad() { return this.nombreLocalidad; }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
