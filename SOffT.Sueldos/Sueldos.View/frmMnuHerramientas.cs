using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sofft.Utils;

namespace Sueldos.View
{
    public partial class frmMnuHerramientas : Sofft.ViewComunes.frmMenu 
    {
        public frmMnuHerramientas()
        {
            InitializeComponent();
            this.creaBotones("ABM de Tablas", "Documentos", "Validador de CUIL", "Datos Empresa", "BackUp Base de Datos", "Gestión de Datos Remotos");
            this.Text = "Herramientas";
        }

        public void abrir()
        {
            this.ShowDialog();
        }


        public override void boton_Click(int indice)
        {
            switch (indice)
            {
                case 0: //ABM de Tablas
                    frmABMTablas frmTablas = new frmABMTablas();
                    //frmTablas.abrir();
                    break;
                case 1: //Documentos
                    OpenFileDialog abrirDocumento = new OpenFileDialog();
                    abrirDocumento.InitialDirectory = Application.StartupPath + Modulo.pathDocumentos.Replace("/", System.IO.Path.DirectorySeparatorChar.ToString());
                    if (abrirDocumento.ShowDialog() == DialogResult.OK)
                    { System.Diagnostics.Process.Start(abrirDocumento.FileName); }
                    break;
                case 2: //Validador de CUIL
                    frmValidaCUIL frmcuil = new frmValidaCUIL();
                    frmcuil.ShowDialog();
                    break;
                case 3: //Datos Empresa
                    frmDatosEmpresa frmEmpre = new frmDatosEmpresa();
                  //  frmEmpre.abrir();
                    break;
                case 4:
                    try
                    {//TODO: Fix Mono
                        Model.DB.ejecutarProceso(Model.TipoComando.Texto, "BACKUP DATABASE [sueldos] TO DISK = 'C:\\sueldos" + System.DateTime.Now.Year.ToString() + System.DateTime.Now.Month.ToString().PadLeft(2, '0') + System.DateTime.Now.Day.ToString().PadLeft(2, '0') + System.DateTime.Now.Hour.ToString().PadLeft(2, '0') + System.DateTime.Now.Minute.ToString().PadLeft(2, '0') + ".bak'");
                        MessageBox.Show("El backup se realizó con éxito en c:\\sueldosAAAAMMDD.bak");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al crear el backup: " + ex.ToString());
                    }
                    break;
                case 5:
                    frmGestionDatosRemotos FrmGestionDatosRemotos = new frmGestionDatosRemotos();
                    FrmGestionDatosRemotos.abrir();
                    break;
            }
        }


        private void abrirDocumento()
        {
         /*   openFileDialogFoto.Filter = "Imagen JPG (*.jpg)|*.jpg";
            openFileDialogFoto.FileName = "";
            if (openFileDialogFoto.ShowDialog() == DialogResult.OK)
            {
                this.btnGrabar.Enabled = true;
                empleado.Foto = openFileDialogFoto.FileName;
                try
                {
                    this.pbFoto.Image = new Bitmap(empleado.Foto);
                }
                catch (Exception)
                {
                    this.pbFoto.Image = null;
                }
            }
            */
        }
    }
}

