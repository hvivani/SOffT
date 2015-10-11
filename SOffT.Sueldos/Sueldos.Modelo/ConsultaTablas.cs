/*  
    ConsultaTablas.cs

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
    public class ConsultaTablas
    {

        public ConsultaTablas() { }

        public int insert(TablaEntity tabla)
        {
            using (var tablaData = new TablaData())
            {
                return tablaData.insert(tabla);
            }
        }

        public int update(TablaEntity tabla)
        {
            using (TablaData tablaData = new TablaData())
            {
                return tablaData.update(tabla);
            }
        }

        public int delete(TablaEntity tabla)
        {
            using (TablaData tablaData = new TablaData())
            {
                return tablaData.delete(tabla);
            }
        }
        /// <summary>
        /// Crea una tabla y carga datos de tabla preexistente.
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        public TablaEntity getById(string nombre, int indice, double contenido)
        {
            TablaEntity tabla;
            using (var tablaData = new TablaData())
            {
                tabla=tablaData.getById(nombre, indice, contenido);
            }
            return tabla;
        }

        /// <summary>
        /// Obtiene la lista de tablas 
        /// </summary>
        /// <returns>Lista de tablas</returns>
        public List<TablaEntity> getContenidoYdetalle(string nombreTabla, int indice)
        {
            using (var tablaData = new TablaData())
            {
                List<TablaEntity> tablas = tablaData.getByContenidoYdetalle(nombreTabla,indice);
                return tablas;
            }
        }

        /// <summary>
        /// Obtiene los nombres de las tablas
        /// </summary>
        /// <returns></returns>
        public List<TablaEntity> getNombres()
        {
            using (var tablaData = new TablaData())
            {
                List<TablaEntity> tablas = tablaData.getNombresTablas();
                return tablas;
            }
        }

        /// <summary>
        /// Obtiene el contenido de una tabla por su nombre
        /// </summary>
        /// <returns></returns>
        public List<TablaEntity> getByNombre(string nombre)
        {
            using (var tablaData = new TablaData())
            {
                List<TablaEntity> tablas = tablaData.getByNombre(nombre);
                return tablas;
            }
        }

        /// <summary>
        /// Obtiene el contenido de una tabla por su nombre
        /// Debe especificarse campo/s de ordenacion
        /// </summary>
        /// <returns></returns>
        public List<TablaEntity> getByNombre(string nombre, string orden)
        {
            using (var tablaData = new TablaData())
            {
                List<TablaEntity> tablas = tablaData.getByNombre(nombre, orden);
                return tablas;
            }
        }

        /// <summary>
        /// Obtiene el contenido de una tabla por su nombre
        /// Se aceptan filtros
        /// Debe especificarse campo/s de ordenacion
        /// </summary>
        /// <returns></returns>
        public List<TablaEntity> getByNombre(string nombre, string filtro, string orden)
        {
            using (var tablaData = new TablaData())
            {
                List<TablaEntity> tablas = tablaData.getByNombre(nombre, filtro ,orden);
                return tablas;
            }
        }

    }
}
