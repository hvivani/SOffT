/*  
    HuellasNegocio.cs

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
using Sueldos.Entidades;


namespace Reloj.Negocio
{
    public class HuellasNegocio
    {
        public HuellasNegocio()
        {
        }

        /// <summary>
        /// Crea una nueva instancia de Huella
        /// </summary>
        /// <returns>Huella con valor de propiedades por defecto</returns>
        public HuellaEntity GetNew()
        {
            return new HuellaEntity();
        }

        /// <summary>
        /// Obtiene una instancia especifica de Huella
        /// </summary>
        /// <param name="id">Identificador unico de Huella</param>
        /// <returns>Instancia de Huella solicitada</returns>
        public HuellaEntity getById(int legajo, int idHuella)
        {
            HuellaEntity huella = null;
            using (var huellaData = new HuellaData())
            {
                huella = huellaData.GetBy(legajo,idHuella);
            }
            return huella;
        }

        public HuellaEntity getByHuella(string huellaStr)
        {
            HuellaEntity huella = null;
            using (var huellaData = new HuellaData())
            {
                huella = huellaData.GetBy(huellaStr);
            }
            return huella;
        }

        /// <summary>
        /// Obtiene la lista de todos las Huella
        /// </summary>
        /// <returns>Lista de Huella</returns>
        public List<HuellaEntity> getLista()
        {
            using (var huellaData = new HuellaData())
            {
                List<HuellaEntity> huellas = huellaData.GetAll();
                return huellas;
            }
        }

        /// <summary>
        /// Obtiene la lista de todas las Huella de un legajo
        /// </summary>
        /// <returns>Lista de Huella</returns>
        public List<HuellaEntity> getByLegajo(int legajo)
        {
            using (var huellaData = new HuellaData())
            {
                List<HuellaEntity> huellas = huellaData.GetBy(legajo);
                return huellas;
            }
        }

        /// <summary>
        /// Accion de eliminar una Huella
        /// </summary>
        /// <param name="Huella">Huella a eliminar</param>
        public void Eliminar(HuellaEntity huella)
        {
            using (var huellaData = new HuellaData())
            {
                huellaData.Delete(huella);
            }
        }

        /// <summary>
        /// elimina todas las huellas de un legajo
        /// </summary>
        /// <param name="huella"></param>
        public void Eliminar(int legajo)
        {
            using (var huellaData = new HuellaData())
            {
                huellaData.Delete(legajo);
            }
        }

        /// <summary>
        /// Acción de insertar una Huella
        /// </summary>
        /// <param name="Huella">Huella a guardar</param>
        public void Guardar(HuellaEntity huella)
        {
            this.Validar(huella);
            using (var huellaData = new HuellaData())
            {
                if (huellaData.GetBy(huella.Legajo,int.Parse( huella.DedoHuella.Contenido.ToString()))==null)
                {
                    huellaData.Insert(huella);
                }
                else
                {
                    huellaData.Update(huella);
                }
            }
        }

        /// <summary>
        /// Valida los datos de Huella
        /// </summary>
        /// <param name="Huella">Huella a validar</param>
        private void Validar(HuellaEntity huella)
        {
            if (huella.Huella == null || huella.Huella.Equals(string.Empty))
            {
                throw new ValidacionException("Falta cargar la huella");
            }
        }

    }
}
