/*  
    Controles.cs

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
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;


namespace Sofft.ViewComunes
{
    /// <summary>
    /// Clase de manejo de la presentacion, carga y estetica de varios controles.
    /// </summary>
    public class Controles
    {

        /// <summary>
        /// Devuelve un objeton imágen desde un byte[]
        /// </summary>
        /// <param name="byteArrayIn"></param>
        /// <returns></returns>
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
       /*     MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;*/

            Image newImage;
            //Read image data into a memory stream
            using (MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length))
            {
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);

                //Set image variable value using memory stream.
                newImage = Image.FromStream(ms, true);
            }
            return newImage;

        }

        /// <summary>
        /// Totaliza una columna de un DataGridView
        /// </summary>
        /// <param name="columna"></param>
        /// <returns></returns>
        public static double TotalizarColumnaGrilla(int columna, DataGridView dgv)
        {
            double total = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                total += double.Parse(row.Cells[columna].Value.ToString());
            }
            return total;
        }


        //Open file in to a filestream and read data in a byte array.
        public static byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes 
            //to read from file.
            //In this case we want to read entire file. 
            //So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);

            return data;
        }

        /// <summary>
        /// Devuelve un byte[] desde una imágen
        /// </summary>
        /// <param name="imageIn"></param>
        /// <returns></returns>
        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }

        /// <summary>
        /// Carga un datagrid con el resultado de la ejecucion de un sp.
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="consultaSQL"></param>
        [Obsolete("usar metodo con otros parametros")]
        public static void cargaDataGridView (DataGridView dgv, string sp, params object[] parametros)
        {
			
        	dgv.AutoGenerateColumns = true;
        	dgv.DataSource = Model.DB.ejecutarDataSet (Model.TipoComando.SP, sp, parametros).Tables[sp];
			for (int i = 0; i < dgv.Columns.Count-1; i++) {
				dgv.Columns[i].Visible = !dgv.Columns[i].Name.StartsWith ("id") || !dgv.Columns[i].Name.StartsWith ("Id");	
			}
			
			//TODO: sacar esto de acá !!!
        }


        /// <summary>
        /// Carga un datagrid con el resultado de la ejecucion de un dataset.
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="consultaSQL"></param>
        public static void cargaDataGridView (DataGridView dgv, System.Data.DataSet ds, Boolean columnaCeroVisible)
        {
			dgv.AutoGenerateColumns = true;
            dgv.DataSource = ds.Tables[0];
            dgv.Columns[0].Visible = columnaCeroVisible;
        }

        /// <summary>
        /// Carga un datagrid con una coleccion.
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="consultaSQL"></param>
        public static void cargaDataGridView (DataGridView dgv, object lista, Boolean columnaCeroVisible)
        {
        	dgv.AutoGenerateColumns = true;
        	dgv.DataSource = lista;
        	dgv.Columns[0].Visible = columnaCeroVisible;
        }

        /// <summary>
        /// carga un cmb dado con el resultado de un sp.
        /// setea el dropdownstyle a dropdownlist.
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="displayCol"></param>
        /// <param name="idCol"></param>
        /// <param name="sp"></param>
        /// <param name="parametrosSp"></param>
        [Obsolete("usar metodo con otros parametros")]
        public static void cargaComboBox(ComboBox cmb, string displayCol, string idCol, string sp, params object[] parametrosSp)
        {
            cmb.ValueMember = idCol;
            cmb.DisplayMember = displayCol;
            cmb.DataSource = (Model.DB.ejecutarDataSet(Model.TipoComando.SP, sp, parametrosSp)).Tables[sp];
            //TODO: sacar esto de acá !!!
            // cmb.SelectedIndex = -1; //para q muestre el primero en blanco
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Carga combo box desde lista de objetos, indicando columna display y columna id
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="displayCol"></param>
        /// <param name="idCol"></param>
        /// <param name="lista"></param>
        public static void cargaComboBox(ComboBox cmb, string displayCol, string idCol, object lista)
        {
            cmb.ValueMember = idCol;
            cmb.DisplayMember = displayCol;
            cmb.DataSource = lista;
            // cmb.SelectedIndex = -1; //para q muestre el primero en blanco
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Carga combo box desde dataset, indicando columna display y columna id
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="displayCol"></param>
        /// <param name="idCol"></param>
        /// <param name="lista"></param>
        public static void cargaComboBox(ComboBox cmb, string displayCol, string idCol, System.Data.DataSet ds)
        {
            cmb.ValueMember = idCol;
            cmb.DisplayMember = displayCol;
            cmb.DataSource = ds.Tables[0];
            // cmb.SelectedIndex = -1; //para q muestre el primero en blanco
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        /// <summary>
        /// carga listbox con el resultado de la ejecucion de un sp
        /// </summary>
        /// <param name="lb"></param>
        /// <param name="displayCol"></param>
        /// <param name="idCol"></param>
        /// <param name="sp"></param>
        /// <param name="parametrosSp"></param>
        [Obsolete("usar metodo con otros parametros")]
        public static void cargaListBox(ListBox lb, string displayCol, string idCol, string sp, params object[] parametrosSp)
        {
            lb.ValueMember = idCol;
            lb.DisplayMember = displayCol;
            lb.DataSource = Model.DB.ejecutarDataSet(Model.TipoComando.SP, sp, parametrosSp).Tables[sp];
            //TODO: sacar esto de acá !!!
        }

        /// <summary>
        /// Carga list box con una lista
        /// </summary>
        /// <param name="lb"></param>
        /// <param name="displayCol"></param>
        /// <param name="idCol"></param>
        /// <param name="lista"></param>
        public static void cargaListBox(ListBox lb, string displayCol, string idCol, object lista)
        {
            lb.ValueMember = idCol;
            lb.DisplayMember = displayCol;
            lb.DataSource = lista;
            // cmb.SelectedIndex = -1; //para q muestre el primero en blanco
        }


        /// <summary>
        /// Crea y carga combobox seteado con propiedades por defecto. Lo utilizo para crear arrays
        /// </summary>
        /// <param name="displayCol"></param>
        /// <param name="idCol"></param>
        /// <param name="sp"></param>
        /// <param name="parametrosSp"></param>
        /// <returns></returns>
        public static ComboBox creaComboBox(string displayCol, string idCol, string sp, params object[] parametrosSp)
        {
            ComboBox cmb = new ComboBox();
            cmb.ValueMember = idCol;
            cmb.DisplayMember = displayCol;
            cmb.DataSource = Model.DB.ejecutarDataSet(Model.TipoComando.SP, sp, parametrosSp).Tables[sp];
            cmb.SelectedIndex = -1; //para q muestre el primero en blanco
            return cmb;
        }


        /// <summary>
        /// setea valores estandard en datagrid con ajuste automatico de columnas.
        /// </summary>
        /// <remarks>Desabilita la autogeneracion de columnas</remarks>
        /// <param name="dgv"></param>
        public static void setEstandarDataGridView (DataGridView dgv)
        {
        	//cpereyra: desabilita la autogeneracion de columnas para que no se modifique el orden de las mismas.
        	//Es necesario haber asignado previamente la fuente de datos.
        	dgv.AutoGenerateColumns = true;
        	dgv.AllowUserToAddRows = false;
        	dgv.AllowUserToDeleteRows = false;
        	dgv.AllowUserToResizeRows = false;
        	//dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
        	dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        	dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
        	dgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
        	dgv.ColumnHeadersHeight = 20;
        	dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        	dgv.MultiSelect = false;
        	dgv.ReadOnly = true;
        	dgv.RowHeadersWidth = 21;
        	dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        	dgv.RowTemplate.Height = 20;
        	dgv.RowTemplate.ReadOnly = true;
        	dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
        	dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			dgv.TabIndex = 0;

			for (int i = 0; i < dgv.Columns.Count - 1; i++) {
				dgv.Columns[i].Visible = !(dgv.Columns[i].Name.StartsWith ("id") || dgv.Columns[i].Name.StartsWith ("Id"));
			}
        }

        /// <summary>
        /// carga dtPicker teniendo en cuenta si no hay una fecha seteada.
        /// esteblece automaticamente propiedad checked. Pide showcheckbox. 
        /// Comparo con "01/01/1900".
        /// </summary>
        /// <param name="dtp"></param>
        /// <param name="fecha"></param>
        public static void seteaDTPicker(DateTimePicker dtp, DateTime fecha, Boolean showCheckBox)
        {
            if (fecha > Convert.ToDateTime("01/01/1900"))
            {
                dtp.ShowCheckBox = showCheckBox;
                dtp.Value = fecha;
            }
            else
            {
                dtp.ShowCheckBox = showCheckBox;
                dtp.Checked = false;
            }
        }


        /// <summary>
        /// carga dtPicker teniendo en cuenta si no hay una fecha seteada.
        /// esteblece automaticamente propiedad checked y showcheckbox. 
        /// 
        /// Comparo con "01/01/1900".
        /// </summary>
        /// <param name="dtp"></param>
        /// <param name="fecha"></param>
        public static void seteaDTPicker(DateTimePicker dtp, DateTime fecha)
        {
            if (fecha > Convert.ToDateTime("01/01/1900"))
            {
                dtp.ShowCheckBox = false;
                dtp.Value = fecha;
            }
            else
            {
                dtp.ShowCheckBox = true;
                dtp.Checked = false;
            }
        }

        /// <summary>
        /// consulta el contenido de un campo de un renglon de un dgv.
        /// </summary>
        /// <param name="id">id de columna de la grilla</param>
        /// <returns></returns>
        public static string consultaCampoRenglon(DataGridView dgv, int idColumna)
        {
            return dgv.SelectedRows[0].Cells[idColumna].Value.ToString();
        }


        /// <summary>
        /// consulta el id del renglon seleccionado en una grilla
        /// </summary>
        /// <param name="dgv"></param>
        /// <returns></returns>
        public static int consultaRenglonSeleccionado(DataGridView dgv)
        {
            return dgv.SelectedRows[0].Cells[0].RowIndex;
        }

        /// <summary>
        /// Carga la imagen solicitada en un control bitmap.
        /// </summary>
        /// <param name="pathAbsoluto">Pasar Application.StartupPath + pathRelativo o pathAbsoluto</param> 
        /// <returns></returns>
        public static Bitmap cargarImagen(string pathAbsoluto)
        {
            Bitmap bmp = null; ;
            try
            {
                bmp = new Bitmap(pathAbsoluto);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar la imagen solicitada" + ex);
                //MessageBox.Show("Error al cargar el logo del modulo" + ex);
            }
            return bmp;
        }
    }
}
