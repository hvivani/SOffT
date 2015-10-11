using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using Sofft.Utils;
using Sofft.ViewComunes;
using Sueldos.Modelo;
using Sueldos.Entidades;

namespace Sueldos.View
{
    public partial class frmABMnovedades : Form
    {

        private NovedadEntity nove = null;
        private ConsultaTablas consutab = new ConsultaTablas();
        private ConsultaLiquidacionDetalle consuliqdet = new ConsultaLiquidacionDetalle();
        private ConsultaNovedades consunove = new ConsultaNovedades();
        private ConsultaEmpleados consuemple = new ConsultaEmpleados();
        
        public frmABMnovedades()
        {
            InitializeComponent();
            this.txtLegajo.KeyDown += new KeyEventHandler(txtLegajo_KeyDown);
            this.cmbEmpleados.KeyDown += new KeyEventHandler(cmbEmpleados_KeyDown);
            this.cmbNovedad.KeyDown += new KeyEventHandler(cmbNovedad_KeyDown);
            this.txtValor.KeyDown += new KeyEventHandler(txtValor_KeyDown);
        }

        void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
                this.btnGrabar.Focus();
        }

        void cmbNovedad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtValor.Focus();
        }

        void cmbEmpleados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.cmbNovedad.Focus();
        }

        void txtLegajo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.txtLegajo.Text.Length>0)
                this.cmbEmpleados.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmABMnovedades_Load(object sender, EventArgs e)
        {
            this.btnCancelar_Click(sender,e);
        }

        public void abrir()
        {
            this.cargarCombos();
            this.rbTodas.Select();
            this.ShowDialog();
        }

        public void abrirParaAnticipos()
        {
            MessageBox.Show("Reveer implementacion");
          /*  this.txtAnio.Text = System.DateTime.Today.Year.ToString();
            this.txtMes.Text = System.DateTime.Today.Month.ToString();
            DB.cargaComboBox(this.cmbTipoLiquidacion, "descripcion", "indice", "tablasConsultar", "@nombre", "calculo");
            DB.cargaComboBox(this.cmbNovedad, "descripcion", "indice", "tablasConsultarCodigosNovedades");
            DB.cargaComboBox(this.cmbEmpleados, "Apellido y Nombres", "legajo", "empleadosConsultarParaCombo");
            this.rbPorNovedad.Enabled = false;
            this.cmbNovedad.SelectedValue = 410;
            this.ShowDialog();*/

        }


        private void actualizarGrillaNovedades() 
        {
            if (Convert.ToInt32(this.cmbNovedad.SelectedValue) > 0)
            {
                Controles.cargaDataGridView(this.dgvNovedades,consunove.getAll(int.Parse(this.cmbLiquidacion.SelectedValue.ToString()),""),false );
                Controles.setEstandarDataGridView(this.dgvNovedades);
            }
        }

        private void actualizarGrillaNovedadesEmpleado()
        {
            if (Convert.ToInt32(this.cmbEmpleados.SelectedValue) > 0)
            {
                Controles.cargaDataGridView(this.dgvNovedades, consunove.getAll(int.Parse(this.cmbLiquidacion.SelectedValue.ToString()), " novedades.legajo = " + this.cmbEmpleados.SelectedValue.ToString()), false);
                Controles.setEstandarDataGridView(this.dgvNovedades);
            }
        }

        private void actualizarGrillaNovedadesCodigo()
        {
            if (Convert.ToInt32(this.cmbNovedad.SelectedValue) > 0)
            {
                Controles.cargaDataGridView(this.dgvNovedades, consunove.getAll(int.Parse(this.cmbLiquidacion.SelectedValue.ToString()), " novedades.codigo = " + this.cmbNovedad.SelectedValue.ToString()), false);
                Controles.setEstandarDataGridView(this.dgvNovedades);
            }
        }

        private void cmbTipoLiquidacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.actualizarGrillaNovedades();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            nove = new NovedadEntity(int.Parse( this.cmbLiquidacion.SelectedValue.ToString()),0,0);
            novedadEntityBindingSource.DataSource = nove;

            this.txtLegajo.Text = "";
            this.txtLegajo.Enabled = true;
            this.cmbEmpleados.SelectedValue=-1;
            this.cmbEmpleados.Enabled = true;
            //si esta habilitado rb por novedad, habilito cmbNovedad
            this.cmbNovedad.Enabled = this.rbPorNovedad.Enabled;
            this.txtValor.Text = "";
            this.txtValor.Enabled = true;
            this.txtLegajo.Focus();
            this.btnEliminar.Enabled = false;
            this.btnCerrar.Enabled = false;
            this.btnAgregar.Enabled = false;
            this.btnGrabar.Enabled = true;
            this.btnCancelar.Enabled = true;
            this.gbConsultas.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtLegajo.Text = "";
            this.txtLegajo.Enabled = false;
            this.cmbEmpleados.SelectedValue=-1;
            this.cmbEmpleados.Enabled = false;
            this.txtValor.Text = "";
            this.txtValor.Enabled = false;
            this.btnEliminar.Enabled = true;
            this.btnCerrar.Enabled = true;
            this.btnAgregar.Enabled = true;
            this.btnGrabar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.gbConsultas.Enabled = true;
            //this.rbTodas.Select();
            this.cmbNovedad.Enabled = false;
            //this.actualizarGrillaNovedades();
            if (rbPorLegajo.Checked)
                this.actualizarGrillaNovedadesEmpleado();
            if (rbPorNovedad.Checked)
                this.actualizarGrillaNovedadesCodigo();
            if (rbTodas.Checked)
                this.actualizarGrillaNovedades();
            this.btnAgregar.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (this.datosValidos())
            {
                consunove.grabar(nove);
                this.btnCancelar_Click(sender, e);
            }
        }

        private bool datosValidos()
        {
            Boolean ok = true;
            if (Convert.ToInt32(this.cmbEmpleados.SelectedValue) < 1)
            {
                MessageBox.Show("Debe seleccionar un empleado valido");
                ok = false;
                this.cmbEmpleados.Focus();
            }
            else
            {
                if (Convert.ToInt32(this.cmbNovedad.SelectedValue) < 1)
                {
                    MessageBox.Show("Debe seleccionar una novedad válida");
                    ok = false;
                    this.cmbNovedad.Focus();
                }
                else
                {
                    if ( !Varios.IsNumeric(this.txtValor.Text) || Convert.ToDouble (this.txtValor.Text) < 0)
                    {
                        MessageBox.Show("Debe ingresar un valor válido");
                        ok = false;
                        this.txtValor.Focus();
                    }
                }
            }
            return ok;
        }

        private void txtLegajo_TextChanged(object sender, EventArgs e)
        {
            if (Varios.IsNumeric(this.txtLegajo.Text))
                this.cmbEmpleados.SelectedValue = this.txtLegajo.Text;
            if (this.rbPorLegajo.Checked)
                this.actualizarGrillaNovedadesEmpleado();
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbEmpleados.SelectedValue != null)
                this.txtLegajo.Text = this.cmbEmpleados.SelectedValue.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            nove = consunove.getById(int.Parse(this.cmbLiquidacion.SelectedValue.ToString()), int.Parse(Controles.consultaCampoRenglon(this.dgvNovedades, 1)), double.Parse(Controles.consultaCampoRenglon(this.dgvNovedades, 3)));
            novedadEntityBindingSource.DataSource = nove;

            if (Convert.ToInt32(Controles.consultaCampoRenglon(this.dgvNovedades, 1)) > 0 && Varios.confirmaEliminarRegistro())
            {
                consunove.delete(nove);
                MessageBox.Show("el registro se elimino con éxito");
                this.btnCancelar_Click(sender,e);
                this.actualizarGrillaNovedades();
            }
        }

        private void rbTodas_CheckedChanged(object sender, EventArgs e)
        {
            this.gbDatosLiquidacion.Enabled = true;
            this.cmbNovedad.Enabled = false;
            this.txtLegajo.Enabled = false;
            this.cmbEmpleados.Enabled = false;
            this.actualizarGrillaNovedades();
        }

        private void rbPorLegajo_CheckedChanged(object sender, EventArgs e)
        {
            this.gbDatosLiquidacion.Enabled = false;
            this.cmbNovedad.Enabled = false;
            this.txtLegajo.Enabled = true;
            this.cmbEmpleados.Enabled = true;
            this.actualizarGrillaNovedadesEmpleado();
        }

        private void rbPorNovedad_CheckedChanged(object sender, EventArgs e)
        {
            this.gbDatosLiquidacion.Enabled = false;
            this.cmbNovedad.Enabled = true;
            this.txtLegajo.Enabled = false;
            this.cmbEmpleados.Enabled = false;
            this.actualizarGrillaNovedadesCodigo();
        }

        private void cmbNovedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.rbPorNovedad.Checked)
                this.actualizarGrillaNovedadesCodigo();
        }


        private void cargarCombos()
        {
            Controles.cargaComboBox(this.cmbNovedad, "descripcion", "indice", consutab.getByNombre("novedades","descripcion"));
            Controles.cargaComboBox(this.cmbEmpleados, "Nombres", "Legajo", consuemple.GetAlldatosBasicos());
            Controles.cargaComboBox(this.cmbLiquidacion,"descripcion","id",consuliqdet.getByEstado(0));

        }

        private void cmbLiquidacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnCancelar_Click(null, null);
        }

 
    }
}