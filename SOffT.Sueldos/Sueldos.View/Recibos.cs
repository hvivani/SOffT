/*  
    recibos.cs

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
using System.Collections;

namespace Sueldos.View
{
    public class Recibos : CollectionBase
    {
        public int Add(Recibo item)
        { return List.Add(item); }

        public void Insert(int index, Recibo item)
        { List.Insert(index, item); }

        public void Remove(Recibo item)
        { List.Remove(item); }

        public bool Contains(Recibo item)
        { return List.Contains(item); }

        public int IndexOf(Recibo item)
        { return List.IndexOf(item); }

        public void CopyTo(Recibo[] array, int index)
        { List.CopyTo(array, index); }

        public Recibo this[int index]
        {
            get { return (Recibo)List[index]; }
            set { List[index] = value; }
        }
    }
}
