using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace Seguridad
{
    /// <summary>
    /// Clase de manejo de la presentacion, carga y estetica de varios controles.
    /// </summary>
    class Controles
    {
        /// <summary>
        /// Carga un datagrid con el resultado de la ejecucion de un sp.
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="consultaSQL"></param>
        public static void cargaDataGridView(DataGridView dgv, string sp, params object[] parametros)
        {
            dgv.DataSource = Model.DB.ejecutarDataSet(DBNet.TipoComando.SP, sp, parametros).Tables[sp];
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
        public static void cargaComboBox(ComboBox cmb, string displayCol, string idCol, string sp, params object[] parametrosSp)
        {
            cmb.ValueMember = idCol;
            cmb.DisplayMember = displayCol;
            cmb.DataSource = (Model.DB.ejecutarDataSet(DBNet.TipoComando.SP, sp, parametrosSp)).Tables[sp];

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
        public static void cargaListBox(ListBox lb, string displayCol, string idCol, string sp, params object[] parametrosSp)
        {
            lb.ValueMember = idCol;
            lb.DisplayMember = displayCol;
            lb.DataSource = Model.DB.ejecutarDataSet(Model.TipoComando.SP, sp, parametrosSp).Tables[sp];
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
            cmb.DataSource = DBNet.DB.ejecutarDataSet(DBNet.TipoComando.SP, sp, parametrosSp).Tables[sp];
            cmb.SelectedIndex = -1; //para q muestre el primero en blanco
            return cmb;
        }


        /// <summary>
        /// setea valores estandard en datagrid con ajuste automatico de columnas.
        /// </summary>
        /// <remarks>Desabilita la autogeneracion de columnas</remarks>
        /// <param name="dgv"></param>
        public static void setEstandarDataGridView(DataGridView dgv)
        {
            //cpereyra: desabilita la autogeneracion de columnas para que no se modifique el orden de las mismas.
            //Es necesario haber asignado previamente la fuente de datos.
            dgv.AutoGenerateColumns = false;
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
            //     dgv.Size = new System.Drawing.Size(604, 308);
            dgv.TabIndex = 0;
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
