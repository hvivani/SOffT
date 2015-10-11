/*  
    VacacionEntity.cs

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
    public class VacacionEntity
    {
        private int legajo;

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private int codigo = 45;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private int anioVacaciones;

        public int AnioVacaciones
        {
            get { return anioVacaciones; }
            set { anioVacaciones = value; }
        }
        private int diasTomados;

        public int DiasTomados
        {
            get { return diasTomados; }
            set { diasTomados = value; }
        }
        private int totalDias;

        public int TotalDias
        {
            get { return totalDias; }
            set { totalDias = value; }
        }
    }
}
