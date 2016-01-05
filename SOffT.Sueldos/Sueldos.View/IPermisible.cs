/*  
    IPermisible.cs

    Author:
    Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>
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
namespace Sueldos.View
{
    /// <summary>
    /// Define metodos y propiedades para manejar permisos de un formulario en una estrutura de arbol de formularios
    /// </summary>
    interface IPermisible
    {
        /// <summary>
        /// Metodo para abrir el formulario y aplicar los permisos correspondientes al mismo.
        /// </summary>
        /// <param name="nivel">Nivel del fomulario invocador</param>
        /// <param name="indice">Indice del objeto invocador</param>
        void abrir(string nivel, int indice);
        /// <summary>
        /// Obtiene el nivel de profundida del formulario actual en la rama del arbol de formularios que lo contiene
        /// </summary>
        string Nivel { get; }
    }
}
