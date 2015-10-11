using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sofft.ViewComunes;
using Sueldos.Entidades;

namespace Sueldos.View
{
    public partial class frmFamiliar : Form
    {
        public frmFamiliar()
        {
            InitializeComponent();
        }

        private void frmFamiliar_Load(object sender, EventArgs e)
        {
        }


        public void abrir()
        {

        }


        private void cargarCombos()
        {
            Controles.cargaComboBox(this.cmbTipoDocumento, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "EmpleadosSueldos", "@indice", 16);
            Controles.cargaComboBox(this.cmbParentesco, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "familiares", "@indice", 10);
            Controles.cargaComboBox(this.cmbSexo, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "EmpleadosSueldos", "@indice", 7);
            Controles.cargaComboBox(this.cmbNacionalidad, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "EmpleadosSueldos", "@indice", 5);
            Controles.cargaComboBox(this.cmbEstadoCivil, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "EmpleadosSueldos", "@indice", 15);
        }

        public void abrirParaNuevo(ref FamiliarEntity f)
        {
            this.cargarCombos();
            this.txtApellidoYNombres.Focus();
        //    this.dtpFechaBaja = null;
            this.ShowDialog();

            f.ApellidoYnombres = this.txtApellidoYNombres.Text;
            f.IdParentesco = Convert.ToInt32(this.cmbParentesco.SelectedValue);
            f.Parentesco = this.cmbParentesco.Text;
            f.IdTipoDocumento = Convert.ToInt32( this.cmbTipoDocumento.SelectedValue);
            f.TipoDocumento = this.cmbTipoDocumento.Text;
            f.NumeroDocumento = this.txtNumeroDocumento.Text;
            f.FechaNacimiento = this.dtpFechaNacimiento.Value;
            f.FechaAlta = this.dtpFechaAlta.Value;
            f.FechaBaja = this.dtpFechaBaja.Value;
            f.IdSexo = Convert.ToInt32(this.cmbSexo.SelectedValue);
            f.Sexo = this.cmbSexo.Text;
            f.IdNacionalidad  = Convert.ToInt32(this.cmbNacionalidad.SelectedValue);
            f.Nacionalidad = this.cmbNacionalidad.Text;
            f.IdEstadoCivil = Convert.ToInt32(this.cmbEstadoCivil.SelectedValue);
            f.EstadoCivil = this.cmbEstadoCivil.Text;
            f.GeneraSalario = this.chkGeneraSalario.Checked;
            f.DeclaradoParaGanancias = this.chkDeclaradoParaGanancias.Checked;
            
        }



        public void abrirParaModificar(ref FamiliarEntity f)
        {
            this.cargarCombos();
            this.txtApellidoYNombres.Focus();
            //    this.dtpFechaBaja = null;


            this.txtApellidoYNombres.Text = f.ApellidoYnombres;
            this.cmbParentesco.SelectedValue = f.IdParentesco;
            //f.Parentesco = this.cmbParentesco.Text;
            this.cmbTipoDocumento.SelectedValue = f.IdTipoDocumento;
            //f.TipoDocumento = this.cmbTipoDocumento.Text;
            this.txtNumeroDocumento.Text = f.NumeroDocumento;
            this.dtpFechaNacimiento.Value = f.FechaNacimiento;
            this.dtpFechaAlta.Value = f.FechaAlta;
            this.dtpFechaBaja.Value = f.FechaBaja;
            this.cmbSexo.SelectedValue = f.IdSexo;
            this.cmbSexo.Text = f.Sexo;
            this.cmbNacionalidad.SelectedValue = f.IdNacionalidad;
            //f.Nacionalidad = this.cmbNacionalidad.Text;
            this.cmbEstadoCivil.SelectedValue = f.IdEstadoCivil;
            //f.EstadoCivil = this.cmbEstadoCivil.Text;
            this.chkGeneraSalario.Checked = f.GeneraSalario;
            this.chkDeclaradoParaGanancias.Checked = f.DeclaradoParaGanancias;

            this.ShowDialog();

            f.ApellidoYnombres = this.txtApellidoYNombres.Text;
            f.IdParentesco = Convert.ToInt32(this.cmbParentesco.SelectedValue);
            f.Parentesco = this.cmbParentesco.Text;
            f.IdTipoDocumento = Convert.ToInt32(this.cmbTipoDocumento.SelectedValue);
            f.TipoDocumento = this.cmbTipoDocumento.Text;
            f.NumeroDocumento = this.txtNumeroDocumento.Text;
            f.FechaNacimiento = this.dtpFechaNacimiento.Value.Date ;
            f.FechaAlta = this.dtpFechaAlta.Value.Date;
            f.FechaBaja = this.dtpFechaBaja.Value.Date;
            f.IdSexo = Convert.ToInt32(this.cmbSexo.SelectedValue);
            f.Sexo = this.cmbSexo.Text;
            f.IdNacionalidad = Convert.ToInt32(this.cmbNacionalidad.SelectedValue);
            f.Nacionalidad = this.cmbNacionalidad.Text;
            f.IdEstadoCivil = Convert.ToInt32(this.cmbEstadoCivil.SelectedValue);
            f.EstadoCivil = this.cmbEstadoCivil.Text;
            f.GeneraSalario = this.chkGeneraSalario.Checked;
            f.DeclaradoParaGanancias = this.chkDeclaradoParaGanancias.Checked;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkGeneraSalario_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}