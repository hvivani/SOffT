/*  
    Acumulado.cs

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

namespace Sueldos.View
{
    public class Acumulado
    {
        private int anioMes;
        private int indice;
        private int legajo;
        private int codigo;
        private string descripcion;
        private double valor;
 
        public Acumulado() { }

        public Acumulado(int anioMes, int indice, int legajo, int codigo, string descripcion ,double valor)
        {
            this.anioMes=anioMes;
            this.indice =indice;
            this.legajo=legajo;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.valor = valor;
        }


        public int AnioMes
        {
            get { return anioMes; }
            set { anioMes = value; }
        }

        public int Indice
        {
            get { return indice; }
            set { indice = value; }
        }

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
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

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
