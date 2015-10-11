/*  
    ConsultaFechasDePago.cs

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
using Sueldos.Data;
using Sueldos.Entidades;


namespace Sueldos.Modelo
{
    public class ConsultaFechasDePago
    {
        public ConsultaFechasDePago() { }

        public int insert(FechaDePagoEntity fecha)
        {
            using (var fechadepagoData = new FechaDePagoData())
            {
                return fechadepagoData.insert(fecha);
            }
        }

        public int update(FechaDePagoEntity fecha)
        {
            using (FechaDePagoData fechadepagoData = new FechaDePagoData())
            {
                return fechadepagoData.update(fecha);
            }
        }

        public int delete(FechaDePagoEntity fecha)
        {
            using (FechaDePagoData fechadepagoData = new FechaDePagoData())
            {
                return fechadepagoData.delete(fecha);
            }
        }


        public FechaDePagoEntity getById(int idLiquidacion, DateTime fechaDePago)
        {
            FechaDePagoEntity fecha;
            using (var fechadepagoData = new FechaDePagoData())
            {
                fecha = fechadepagoData.getById(idLiquidacion, fechaDePago);
            }
            return fecha;
        }

        public List<FechaDePagoEntity> getAll(int idLiquidacion)
        {
            using (var fechadepagoData = new FechaDePagoData())
            {
                List<FechaDePagoEntity> fechas = fechadepagoData.GetAll(idLiquidacion);
                return fechas;
            }
        }
        

    }
}
