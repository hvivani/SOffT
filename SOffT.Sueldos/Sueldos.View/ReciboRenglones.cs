/*  
    ReciboRenglones.cs

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

namespace Sueldos.View
{
    class ReciboRenglones : CollectionBase
    {
        public int Add(ReciboRenglon item)
        { return List.Add(item); }

        public void Insert(int index, ReciboRenglon item)
        { List.Insert(index, item); }

        public void Remove(ReciboRenglon item)
        { List.Remove(item); }

        public bool Contains(ReciboRenglon item)
        { return List.Contains(item); }

        public int IndexOf(ReciboRenglon item)
        { return List.IndexOf(item); }

        public void CopyTo(ReciboRenglon[] array, int index)
        { List.CopyTo(array, index); }

        public ReciboRenglon this[int index]
        {
            get { return (ReciboRenglon)List[index]; }
            set { List[index] = value; }
        }
    }
}
