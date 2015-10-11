/*  
    ArchivoTexto.cs

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
using System.IO;

namespace Model
{
    public class  ArchivoTexto
    {
        /// <summary>
        /// Graba archivo de texto en path y archivo indicado en parametro archivo.
        /// Se graba la cena indicada en cadena. icluye 0d0a.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="cadena"></param>
        public static void grabaArchivoTexto(string archivo, string cadena)
        {
            FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(cadena);
            writer.Close();
        }

        public static FileStream crearArchivo(string archivo)
        {
            FileStream stream = new FileStream(archivo, FileMode.Create, FileAccess.Write);
            return stream;
        }

    }
}
