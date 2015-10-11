/*  
    ConsultaEmpleados.cs

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
    public class ConsultaEmpleados
    {
        public ConsultaEmpleados() { }


        /// <summary>
        /// Graba Empleado (inserta/actualiza)
        /// </summary>
        /// <param name="empleado"></param>
        /// <returns></returns>
        public int grabar(EmpleadoEntity empleado)
        {
            using (var empleadoData = new EmpleadoData())
            {
                return empleadoData.insert(empleado);
            }
        }


        /// <summary>
        /// Consulta el legajo de un empleado a partir del cuil.
        /// El cuil debe pasarse sin guiones
        /// </summary>
        /// <param name="cuil"></param>
        /// <returns></returns>
        public static int consultarLegajoEmpleado(string cuil)
        {
            int legajo = 0;
            using (var empleadoData = new EmpleadoData())
            {
                legajo = empleadoData.getLegajoByCUIL(cuil);
            }
            return legajo;
        }

        /// <summary>
        /// Dado un legajo, consulta el apellido y nombres del empleado.
        /// </summary>
        /// <param name="legajo"></param>
        /// <returns></returns>
        public static string consultarApellidoYnombres(int legajo)
        {
            string nombre = "";
            using (var empleadoData = new EmpleadoData())
            {
                nombre = empleadoData.getNombresByLegajo(legajo);
            }
            return nombre;
        }

        /// <summary>
        /// Dado un legajo, consulta el apellido y nombres del empleado.
        /// </summary>
        /// <param name="legajo"></param>
        /// <returns></returns>
        public static string consultarApellidoYnombresConBajas(int legajo)
        {
            string nombre = "";
            using (var empleadoData = new EmpleadoData())
            {
                nombre = empleadoData.getNombresByLegajoConBajas(legajo);
            }
            return nombre;
        }
        
        /// <summary>
        /// Dado un legajo, consulta la foto del empleado.
        /// </summary>
        /// <param name="legajo"></param>
        /// <returns></returns>
        public static string consultarFoto(int legajo)
        {
            string foto = "";
            using (var empleadoData = new EmpleadoData())
            {
                foto = empleadoData.getFotoByLegajo(legajo);
            }
            return foto;
        }

        public System.Data.DataSet GetAlldatosBasicos()
        {
            System.Data.DataSet ds = null;
            using (var empleadoData = new EmpleadoData())
            {
                ds = empleadoData.GetAlldatosBasicos();
            }
            return ds;
        }


        /// <summary>
        /// Verifica si existe un legajo
        /// </summary>
        /// <param name="legajo"></param>
        /// <returns></returns>
        public bool existeLegajo(int legajo)
        {
            Boolean existe;
            using (var empleadoData = new EmpleadoData())
            {
                existe = empleadoData.existeLegajo(legajo);
            }
            return existe;
        }

        public void actualizarFechas(EmpleadoEntity empleado)
        {
            using (var empleadoData = new EmpleadoData())
            {
                empleadoData.cargarFechas(empleado);
            }
        }

        /// <summary>
        /// Crea empleado y carga datos del empleado previamente existente.
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        public EmpleadoEntity getEmpleado(int idEmpleado)
        {
            EmpleadoEntity emp;
            using (var empleadoData = new EmpleadoData())
            {
                emp = empleadoData.getById(idEmpleado);
            }
            return emp;
        }


    }
}
