/*  
    GenericData.cs

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
using Model;

namespace Sueldos.Data
{
    /// <summary>
    /// Clase Abstracta con el comportamiento general de los objetos DATA.
    /// Se deshabilita el manejo de la conexion desde aquí dado que se levanta y setea
    /// una sola vez desdel el program de la aplicación que llama.
    /// </summary>
    /// <author> hvivani </author>

    public abstract class GenericData:IDisposable 
    {
       // protected Datos dto;
        protected string tabla;

        public GenericData(string nombreTabla)
        {
            this.tabla = nombreTabla;
       //     this.dto = new Datos(Codigos.stringConnection);
       //     this.dto.Open();
        }

        public string Tabla
        {
            get { return this.tabla; }
        }


        #region Miembros de IDisposable

        public void Dispose()
        {
            DB.desconectarDB();
       //     this.dto.Close();
        }

        #endregion
    }

}
