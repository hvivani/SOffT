using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sofft.ViewComunes;
using Sueldos.Entidades;
using Sueldos.Modelo;

namespace Sueldos.View
{
    public partial class frmDatosEmpresa : Form
    {
        private ConsultaEmpresas consEmpre = new  ConsultaEmpresas();
        private ConsultaTablas consTablas = new ConsultaTablas();
        private EmpresaEntity empre = null;        


        public frmDatosEmpresa()
        {
            InitializeComponent();
            
            empre = consEmpre.getById(1);

            Controles.cargaComboBox(this.codigoActividadComboBox,"Detalle","Contenido", consTablas.getContenidoYdetalle("empleadossueldos", 62));
            
            Controles.cargaComboBox(this.tipoEmpleadorComboBox, "Detalle", "Contenido", consTablas.getContenidoYdetalle("empresa", 1));

            this.empresaEntityBindingSource.DataSource = empre;

            //this.pbLogotipo.Image = Controles.byteArrayToImage(empre.Imagen);

            this.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            consEmpre.update(empre);
            MessageBox.Show("Los datos se actualizaron con éxito");
            this.actualizarCombos();
        }

        private void frmDatosEmpresa_Load(object sender, EventArgs e)
        {
            this.actualizarCombos();
        }

        private void actualizarCombos()
        {
            //Parseo a double por equivalencias en el match entre el combo y el objeto tabla
            this.codigoActividadComboBox.SelectedValue = double.Parse(empre.CodigoActividad.ToString());
            this.tipoEmpleadorComboBox.SelectedValue = double.Parse(empre.TipoEmpleador.ToString());
        }

        private void paisTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAsignarImagen_Click(object sender, EventArgs e)
        {
            openFileDialogImagen.Title = "Seleccione el lototipo de la empresa (Fondo Blanco 210px por 100px)";
            openFileDialogImagen.Filter = "Imagenes Soportadas|*.jpg; *.png; *.bmp|Imagen JPG|*.jpg|Imagen PNG|*.png|Imagen BMP|*.bmp";
            openFileDialogImagen.FileName = "";
            if (openFileDialogImagen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.pbLogotipo.Image = new Bitmap(openFileDialogImagen.FileName);
                    empre.Imagen = Controles.ImageToByteArray(this.pbLogotipo.Image);
                    //empre.Imagen = Controles.ReadFile(openFileDialogImagen.FileName);
                }
                catch (Exception)
                {
                    this.pbLogotipo.Image = null;
                }
            }
        }
    }
}