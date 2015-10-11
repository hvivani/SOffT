using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Sofft.ViewComunes;

namespace Sueldos.View
{
    class Empleados : CollectionBase
    {
        public int Add(Empleado item)
        {
            return List.Add(item);
        }

        public void Insert(int index, Empleado item)
        {
            List.Insert(index, item);
        }

        public void Remove(Empleado item)
        {
            List.Remove(item);
        }

        public bool Contains(Empleado item)
        {
            return List.Contains(item);
        }

        public int IndexOf(Empleado item)
        {
            return List.IndexOf(item);
        }

        public void CopyTo(Empleado[] array, int index)
        {
            List.CopyTo(array, index);
        }

        public Empleado this[int index]
        {
            get { return (Empleado)List[index]; }
            set { List[index] = value; }
        }

        public void cargarDataGridView(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = this;
         /*   dgv.Columns["legajo"].Visible = false;
            dgv.Columns["idFamiliar"].DisplayIndex = 0;
            dgv.Columns["apellidoYnombres"].DisplayIndex = 1;
            dgv.Columns["idParentesco"].Visible = false;
            dgv.Columns["Parentesco"].DisplayIndex = 2;
            dgv.Columns["idTipoDocumento"].Visible = false;
            dgv.Columns["TipoDocumento"].DisplayIndex = 3;
            dgv.Columns["NumeroDocumento"].DisplayIndex = 4;
            dgv.Columns["fechaNacimiento"].DisplayIndex = 5;
            dgv.Columns["fechaAlta"].DisplayIndex = 6;
            dgv.Columns["fechaBaja"].DisplayIndex = 7;
            dgv.Columns["idSexo"].Visible = false;
            dgv.Columns["Sexo"].DisplayIndex = 8;
            dgv.Columns["idNacionalidad"].Visible = false;
            dgv.Columns["Nacionalidad"].DisplayIndex = 9;
            dgv.Columns["idEstadoCivil"].Visible = false;
            dgv.Columns["EstadoCivil"].DisplayIndex = 10;
            dgv.Columns["generaSalario"].DisplayIndex = 11;*/
            Controles.setEstandarDataGridView(dgv);
        }

        /// <summary>
        /// verifica si un codigo existe en la coleccion
        /// </summary>
        /// <param name="ce"></param>
        /// <returns></returns>
        public bool existeCodigo(Empleado ce)
        {
            Boolean salida = false;
            foreach (Empleado c in this)
            {
                if (c.Legajo  == ce.Legajo)
                    salida = true;
            }
            return salida;

        }


    }
}
