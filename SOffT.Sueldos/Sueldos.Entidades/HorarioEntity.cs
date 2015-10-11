/*  
    HorarioEntity.cs

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
    public class HorarioEntity
    {
        private int id;
        private int legajo;
        private int limiteDia;
        private int idDia;
        private string dia;
        private int idTipoMovimiento;
        private string tipoMovimiento;
        private string hora;
        private int tolerancia;         //siempre dada en minutos

        public HorarioEntity()
        {

        }

        public HorarioEntity(int Id, int Legajo, int LimiteDia, int IdDia, string  Dia, int IdTipoMovimiento, string TipoMovimiento,string Hora, int tolerancia )
        {
            this.id = Id;
            this.legajo = Legajo;
            this.limiteDia = LimiteDia;
            this.idDia = IdDia;
            this.dia = Dia;
            this.idTipoMovimiento = IdTipoMovimiento;
            this.tipoMovimiento = TipoMovimiento;
            this.hora = Hora;
            this.tolerancia = tolerancia;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public int LimiteDia
        {
            get { return limiteDia; }
            set { limiteDia = value; }
        }

        public int IdDia
        {
            get { return idDia; }
            set { idDia = value; }
        }

        public string Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        public int IdTipoMovimiento
        {
            get { return idTipoMovimiento; }
            set { idTipoMovimiento = value; }
        }

        public string TipoMovimiento
        {
            get { return tipoMovimiento; }
            set { tipoMovimiento = value; }
        }

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public int Tolerancia
        {
            get { return tolerancia; }
            set { tolerancia = value; }
        }
    }
}
