using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sueldos.Reportes
{
    public partial class FrmFichadas : Form
    {
        public FrmFichadas()
        {
            InitializeComponent();
        }
        private  void armarGrillaFichadas()
        {   
            
            int cantidadFichadas = DB.ejecutarSpScalarInt("select  top 1 count(legajo) FROM dbo.reloj group by legajo, fecha order by count(legajo) desc");
            DataTable FichadaReloj = DB.ejecutarSqlDataset("SELECT legajo, fecha, hora FROM 	dbo.reloj order by legajo, fecha, hora", "fichadas").Tables[0];
            DataTable Fichadas = dataSetFichadas.Tables.Add("Fichadas");
            Fichadas.Columns.Add("Legajo");
            Fichadas.Columns.Add("Fecha");
            for(int i = 1; i <= cantidadFichadas / 2; i++)
            {
                Fichadas.Columns.Add("Entrada " + i);
                Fichadas.Columns.Add("Salida " + i);
            }
            int i = 0;
            for (i = 0; i <= FichadaReloj.Rows.Count; i++)
            {
                DataRow row = new DataRow();
            }
            
        }
    }
}