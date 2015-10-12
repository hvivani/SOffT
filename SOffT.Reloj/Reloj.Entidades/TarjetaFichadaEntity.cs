/*  
    TarjetaFichadaEntity.cs

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
using Sofft.Utils;

namespace Reloj.Entidades
{
    public class TarjetaFichadaEntity
    {
        public byte Empresa{get;set;}
        public byte CentroDeCosto { get; set; }
        public int Legajo {get;set;}
        public string StringTarjeta { get; set; }

        public TarjetaFichadaEntity() { }

        public TarjetaFichadaEntity(string stringTarjeta)
        {
            this.StringTarjeta = stringTarjeta;
            this.Empresa = byte.Parse(Varios.Left(stringTarjeta, 2));
            this.CentroDeCosto=byte.Parse(Varios.Right(Varios.Left(stringTarjeta,4),2));
            if (this.StringTarjeta.Length == 10) //tarjetas con legajo de 6 digitos
            {
                this.Legajo = int.Parse(Varios.Right(stringTarjeta, 6));
            }
            if (this.StringTarjeta.Length == 9) //tarjetas con legajo de 5 digitos
            {
                this.Legajo = int.Parse(Varios.Right(stringTarjeta, 5));
            }
        }
    }
}
