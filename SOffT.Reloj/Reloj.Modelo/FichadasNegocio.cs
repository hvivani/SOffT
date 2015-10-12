/*  
    FichadasNegocio.cs

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
using Reloj.Entidades;
using Reloj.Data;

namespace Reloj.Negocio
{
    public class FichadasNegocio
    {
        public FichadasNegocio()
        {
        }

        /// <summary>
        /// Crea una nueva instancia de Fichada
        /// </summary>
        /// <returns>Fichada con valor de propiedades por defecto</returns>
        public FichadaEntity GetNew()
        {
            return new FichadaEntity();
        }

        /// <summary>
        /// Obtiene una instancia especifica de Fichada
        /// </summary>
        /// <param name="id">Identificador unico de Fichada</param>
        /// <returns>Instancia de Fichada solicitada</returns>
        public FichadaEntity getById(short id)
        {
            FichadaEntity fichada = null;
            using (var fichadaData = new FichadaData())
            {
                fichada = fichadaData.GetBy(id);
            }
            return fichada;
        }

        /// <summary>
        /// Obtiene la lista de todos las Fichada
        /// </summary>
        /// <returns>Lista de Fichada</returns>
        public List<FichadaEntity> getLista()
        {
            using (var fichadaData = new FichadaData())
            {
                List<FichadaEntity> fichadas = fichadaData.GetAll();
                return fichadas;
            }
        }

        /// <summary>
        /// Obtiene la lista de todos las Fichadas entre fechas
        /// </summary>
        /// <returns>Lista de Fichada</returns>
        public List<FichadaEntity> getListaEntreFechas(System.DateTime desde, System.DateTime hasta)
        {
            using (var fichadaData = new FichadaData())
            {
                List<FichadaEntity> fichadas = fichadaData.GetEntreFechas(desde, hasta);
                return fichadas;
            }
        }

        public System.Data.DataSet getAll(System.DateTime desde, System.DateTime hasta)
        {
            System.Data.DataSet ds = null;
            using (var fichadaData = new FichadaData())
            {
                ds = fichadaData.GetAll(desde,hasta);
            }
            return ds;
        }

        /// <summary>
        /// Accion de eliminar una Fichada
        /// </summary>
        /// <param name="Fichada">Fichada a eliminar</param>
        /*public void Eliminar(FichadaEntity fichada)
        {
            using (var fichadaData = new FichadaData())
            {
                FichadaData.Delete(fichada);
            }
        }*/

        /// <summary>
        /// Acción de guardar un Fichada
        /// </summary>
        /// <param name="Fichada">Fichada a guardar</param>
        public void Guardar(FichadaEntity fichada)
        {
            this.Validar(fichada);
            using (var fichadaData = new FichadaData())
            {
                if (fichada.Id == 0)
                {
                    fichadaData.Insert(fichada);
                }
                /*else
                {
                    fichadaData.Update(fichada);
                }*/
            }
        }

        /// <summary>
        /// Valida los datos de Fichada
        /// </summary>
        /// <param name="Fichada">Fichada a validar</param>
        private void Validar(FichadaEntity fichada)
        {
            if (fichada.Fecha == null || fichada.Fecha.Equals(string.Empty))
            {
                throw new ValidacionException("Falta cargar la fecha");
            }
        }

    }
}
