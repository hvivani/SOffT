using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sofft.ViewComunes;

namespace Sueldos.View
{
    public partial class frmActualizarFichadas : Form
    {
        public frmActualizarFichadas()
        {
            InitializeComponent();
            this.lstHojas.Click += new EventHandler(lstHojas_Click);

        }

        void lstHojas_Click(object sender, EventArgs e)
        {
            this.ProcesarDatosHoja();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            DataTable dt;
            openFileDialogArchivo.Filter = "Excel XLS (*.xls)|*.xls";
            openFileDialogArchivo.FileName = "";
            if (openFileDialogArchivo.ShowDialog() == DialogResult.OK)
            {

                dt=PlanillaDeCalculo.leerEsquemaLibro(this.openFileDialogArchivo.FileName);
                this.lstHojas.Items.Clear();
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    this.lstHojas.Items.Add(dt.Rows[i].ItemArray[2].ToString());
                    i++;
                }
                this.lstHojas.SetSelected(0, true); //selecciona el primer registro
                this.pbFichadas.Value = 0;
                this.btnActualizar.Enabled = true;
            }
        }

        private void ProcesarDatosHoja()
        {
            DataTable dt;
            dt=PlanillaDeCalculo.leerDatosHoja(this.openFileDialogArchivo.FileName,this.lstHojas.SelectedItem.ToString());
            this.dgvDatos.DataSource = dt;
            Controles.setEstandarDataGridView(this.dgvDatos);
        }

        private void lstHojas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ProcesarDatosHoja();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int legajo = 0;
            int idReloj = 0;
            DateTime fecha=new DateTime(0);
            DateTime hora = new DateTime(0);
            string nombreColumna = "";
            DataTable dt = (DataTable)this.dgvDatos.DataSource;
            this.pbFichadas.Minimum = 0;
            this.pbFichadas.Maximum = dt.Rows.Count;
            for (int iRen = 0; iRen < dt.Rows.Count; iRen++)
            {
                this.pbFichadas.Value = iRen;
                for (int jCol = 0; jCol < dt.Columns.Count; jCol++)
                {
                    using (IDataReader reader = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "tablasConsultarDetalle", "tabla", "formatos", "indice", 1, "contenido", jCol))
                    {
                        if (reader.Read())
                        {
                            nombreColumna = reader["detalle"].ToString();
                            //nombreColumna = (string)Model.DB.ejecutarScalar(Model.TipoComando.SP, "tablasConsultarDetalle", "tabla", "formatos", "indice", 1, "contenido", jCol);
                            if (nombreColumna == "Legajo")
                                legajo = Convert.ToInt32(dt.Rows[iRen].ItemArray[jCol]);
                            if (nombreColumna == "Fecha")
                                fecha = Convert.ToDateTime(dt.Rows[iRen].ItemArray[jCol]);
                            if (nombreColumna == "Hora")
                                hora = Convert.ToDateTime(dt.Rows[iRen].ItemArray[jCol]);
                            if (nombreColumna == "idReloj")
                                idReloj = Convert.ToInt32(dt.Rows[iRen].ItemArray[jCol]);
                        }
                        Model.DB.desconectarDB();
                    }
                }
                if (legajo > 0)
                {
                    Model.DB.ejecutarProceso(Model.TipoComando.SP, "relojInsertarCaptura", "@legajo", legajo, "@fecha", fecha.ToShortDateString(), "@hora", hora.ToShortTimeString(), "@idReloj", idReloj);
                    Model.DB.desconectarDB();
                }
                Console.WriteLine("legajo: " + legajo + " fecha/hora: " + fecha + hora + " idReloj " + idReloj);
            }
            this.pbFichadas.Value = dt.Rows.Count;
            this.btnActualizar.Enabled = false;
            MessageBox.Show("El proceso finalizó con éxito.");
        }



        


    }
}