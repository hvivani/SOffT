using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Sofft.ViewComunes;

namespace Sueldos.View
{
    class CamposEmpleado:CollectionBase
    {
        public int Add(CampoEmpleado item)
        {
            return List.Add(item);
        }

        public void Insert(int index, CampoEmpleado item)
        {
            List.Insert(index, item);
        }

        public void Remove(CampoEmpleado item)
        {
            List.Remove(item);
        }

        public bool Contains(CampoEmpleado item)
        {
            return List.Contains(item);
        }

        public int IndexOf(CampoEmpleado item)
        {
            return List.IndexOf(item);
        }

        public void CopyTo(CampoEmpleado[] array, int index)
        {
            List.CopyTo(array, index);
        }

        public CampoEmpleado this[int index]
        {
            get { return (CampoEmpleado)List[index]; }
            set { List[index] = value; }
        }

        public void cargarDataGridView(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = this;
            dgv.Columns["legajo"].Visible=false;
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
        public bool existeCodigo(CampoEmpleado ce)
        {
            Boolean salida=false;
            foreach (CampoEmpleado c in this)
            {
                if (c.Codigo == ce.Codigo)
                    salida=true;
            }
            return salida;

        }

        
    }
}
