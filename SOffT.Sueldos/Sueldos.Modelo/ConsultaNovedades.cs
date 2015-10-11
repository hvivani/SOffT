/*  
    ConsultaNovedades.cs

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
    public class ConsultaNovedades
    {
        public ConsultaNovedades() { }

        public int insert(NovedadEntity nove)
        {
            using (var novedadesData = new NovedadData())
            {
                return novedadesData.insert(nove);
            }
        }

        public int update(NovedadEntity nove)
        {
            using (NovedadData novedadData = new NovedadData())
            {
                return novedadData.update(nove);
            }
        }

        public int delete(NovedadEntity nove)
        {
            using (NovedadData novedadData = new NovedadData())
            {
                return novedadData.delete(nove);
            }
        }

        /// <summary>
        /// Inserta o Actualiza nueva novedad
        /// </summary>
        /// <returns></returns>
        public int grabar(NovedadEntity nove)
        {
            using (NovedadData novedadData = new NovedadData())
            {
                if (novedadData.getById(nove.IdLiquidacion, nove.Legajo, nove.Codigo) == null)
                    return novedadData.insert(nove);
                else
                    return novedadData.update(nove);
            }
        }

        public NovedadEntity getById(int idLiquidacion, int legajo, double codigo)
        {
            NovedadEntity nove;
            using (var novedadData = new NovedadData())
            {
                nove = novedadData.getById(idLiquidacion, legajo, codigo);
            }
            return nove;
        }

        public System.Data.DataSet getAll(int idLiquidacion, string filtro)
        {
            System.Data.DataSet ds = null;
            using (var novedadData = new NovedadData())
            {
                ds = novedadData.GetAll(idLiquidacion, filtro);
            }
            return ds;
        }
        
        
    }
}
