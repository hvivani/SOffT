/*  
    Acumulados.cs

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
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Sofft.ViewComunes;

namespace Sueldos.View
{
    class Acumulados : CollectionBase
    {
        public int Add(Acumulado item)
        {
            return List.Add(item);
        }

        public void Insert(int index, Acumulado item)
        {
            List.Insert(index, item);
        }

        public void Remove(Acumulado item)
        {
            List.Remove(item);
        }

        public bool Contains(Acumulado item)
        {
            return List.Contains(item);
        }

        public int IndexOf(Acumulado item)
        {
            return List.IndexOf(item);
        }

        public void CopyTo(Acumulado[] array, int index)
        {
            List.CopyTo(array, index);
        }

        public Acumulado this[int index]
        {
            get { return (Acumulado)List[index]; }
            set { List[index] = value; }
        }

        public void cargarDataGridView(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = this;
            dgv.Columns["legajo"].Visible = false;
            dgv.Columns["nombre"].Visible = false;
            dgv.Columns["codigo"].DisplayIndex = 0;
            dgv.Columns["descripcion"].DisplayIndex = 1;
            dgv.Columns["valor"].DisplayIndex = 2;
            dgv.Columns["detalle"].DisplayIndex = 3;
            Controles.setEstandarDataGridView(dgv);
        }

        /// <summary>
        /// verifica si un codigo existe en la coleccion
        /// </summary>
        /// <param name="ce"></param>
        /// <returns></returns>
        public bool existeCodigo(Acumulado ce)
        {
            Boolean salida = false;
            foreach (Acumulado c in this)
            {
                if (c.Codigo == ce.Codigo)
                    salida = true;
            }
            return salida;

        }


    }
}
