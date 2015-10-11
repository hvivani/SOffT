/*  
    PeriodoTrabajadoEntity.cs

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
    public class PeriodoTrabajadoEntity
    {
        private int id;
        private int legajo;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private int idCausaEgreso;
        private string causaEgreso;
        private string observaciones;

        public PeriodoTrabajadoEntity()
        {

        }

        public PeriodoTrabajadoEntity(int Id, int Legajo, DateTime FechaInicio, DateTime FechaFin, int IdCausaEgreso, string CausaEgreso, string Observaciones)
        {
            this.id = Id;
            this.legajo = Legajo;
            this.fechaInicio = FechaInicio;
            this.fechaFin = FechaFin;
            this.idCausaEgreso = IdCausaEgreso;
            this.causaEgreso = CausaEgreso;
            this.observaciones = Observaciones;
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

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        public int IdCausaEgreso
        {
            get { return idCausaEgreso; }
            set { idCausaEgreso = value; }
        }

        public string CausaEgreso
        {
            get { return causaEgreso; }
            set { causaEgreso = value; }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

    }
}
