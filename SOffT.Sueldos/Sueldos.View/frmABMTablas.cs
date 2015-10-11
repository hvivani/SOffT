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
    public partial class frmABMTablas : Form
    {
        private ConsultaTablas consutab = new ConsultaTablas();
        private TablaEntity tabla = null;

        public frmABMTablas()
        {
            InitializeComponent();
            this.txtIndice.KeyDown += new KeyEventHandler(txtIndice_KeyDown);
            this.txtDescripcion.KeyDown += new KeyEventHandler(txtDescripcion_KeyDown);
            this.txtContenido.KeyDown += new KeyEventHandler(txtContenido_KeyDown);
            this.txtDetalle.KeyDown += new KeyEventHandler(txtDetalle_KeyDown);
            this.txtIdentidad.KeyDown += new KeyEventHandler(txtIdentidad_KeyDown);

            this.cargarCombos();

            this.ShowDialog();
        }

        void txtIdentidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnGrabar.Focus();
        }

        void txtDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtIdentidad.Focus();
        }

        void txtContenido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtDetalle.Focus();
        }

        void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtContenido.Enabled)
                    this.txtContenido.Focus();
                else
                    this.txtDetalle.Focus();
            }
        }

        void txtIndice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtDescripcion.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmABMTablas_Load(object sender, EventArgs e)
        {
            this.accionCancelar();
        }

        private void cargarCombos()
        {
            Controles.cargaComboBox(this.cmbTablas, "nombre", " ", consutab.getNombres());
        }


        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.actualizarGrillaTablas();
        }

        private void dgTablas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.accionAgregar();
            this.tabla = new TablaEntity(this.cmbTablas.Text, 0, 0);
            this.tablaEntityBindingSource.DataSource = this.tabla;
        }

        public virtual void accionAgregar()
        {
            this.cmbTablas.Enabled = false;
            this.txtIndice.Enabled = true;
            this.txtDescripcion.Enabled = true;
            this.txtContenido.Enabled = true;
            this.txtDetalle.Enabled = true;
            this.txtIdentidad.Enabled = true;

            this.btnAgregar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnGrabar.Enabled = true;
            this.btnCancelar.Enabled = true;
            this.btnModificar.Enabled = true;
            this.btnCerrar.Enabled = false;

            this.txtIndice.Focus();
        }

        public virtual void accionCancelar()
        {
            this.cmbTablas.Enabled = true;
            this.txtIndice.Enabled = false;
            this.txtDescripcion.Enabled = false;
            this.txtContenido.Enabled = false;
            this.txtDetalle.Enabled = false;
            this.txtIdentidad.Enabled = false;

            this.btnAgregar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnGrabar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.btnModificar.Enabled = true;
            this.btnCerrar.Enabled = true;
        }


        public virtual void accionModificar()
        {
            this.cmbTablas.Enabled = false;
            this.txtIndice.Enabled = true;
            this.txtDescripcion.Enabled = true;
            this.txtContenido.Enabled = true;
            this.txtDetalle.Enabled = true;
            this.txtIdentidad.Enabled = true;

            this.btnAgregar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnGrabar.Enabled = true;
            this.btnCancelar.Enabled = true;
            this.btnModificar.Enabled = false;
            this.btnCerrar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.accionCancelar();
            this.tablaEntityBindingSource.Clear();
            this.actualizarGrillaTablas();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (this.datosValidos())
            {
                if (tabla.Id > 0)
                    consutab.update(tabla);
                else
                    consutab.insert(tabla);
                this.btnCancelar_Click(sender, e);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.accionModificar();
            tabla = consutab.getById(this.cmbTablas.Text, Convert.ToInt32(Controles.consultaCampoRenglon(this.dgTablas, 2)), Convert.ToDouble(Controles.consultaCampoRenglon(this.dgTablas, 4)));

            this.tablaEntityBindingSource.DataSource = tabla;

            this.txtDescripcion.Focus();
        }


        private void actualizarGrillaTablas()
        {
            Controles.cargaDataGridView(this.dgTablas, consutab.getByNombre(this.cmbTablas.Text),false );
            Controles.setEstandarDataGridView(this.dgTablas);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            tabla = consutab.getById(this.cmbTablas.Text, Convert.ToInt32(Controles.consultaCampoRenglon(this.dgTablas, 2)), Convert.ToDouble(Controles.consultaCampoRenglon(this.dgTablas, 4)));
            this.tablaEntityBindingSource.DataSource = tabla;
            
            if (Varios.confirmaEliminarRegistro())
            {
                consutab.delete(tabla);
                MessageBox.Show("el registro se elimino con éxito");
            }
            this.btnCancelar_Click(sender, e);
        }


        private bool datosValidos()
        {
            Boolean ok = true;
            if (!Varios.IsNumeric(this.txtIndice.Text) || Convert.ToInt32(this.txtIndice.Text) < 0)
            {
                MessageBox.Show("Debe ingresar un indice valido");
                ok = false;
                this.txtIndice.Focus();
            }
            else
            {
                if (this.txtDescripcion.Text.Length == 0)
                {
                    MessageBox.Show("Debe ingresar una descripcion valida");
                    ok = false;
                    this.txtDescripcion.Focus();
                }
            }
            return ok;
        }


    }
}