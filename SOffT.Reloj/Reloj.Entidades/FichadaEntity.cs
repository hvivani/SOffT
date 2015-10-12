/*  
    FichadaEntity.cs

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
using System.Text;
using Sueldos.Entidades;


namespace Reloj.Entidades
{
    public class FichadaEntity
    {
        public int Id{get;set;}
        public int Legajo{get;set;}
        public string ApellidoYnombres { get; set; }
        public string Foto { get; set; }
        public string Fecha{get;set;}
        public string Hora{get;set;}
        public TablaEntity Reloj{get;set;} 

        public FichadaEntity() { }

        public FichadaEntity(int id)
        {
            this.Id=id;
        }

        public FichadaEntity(int id, int legajo)
        {
            this.Id = id;
            this.Legajo = legajo;
        }



    }
}
