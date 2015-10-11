using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sofft.Utils;
using Sofft.ViewComunes;

namespace Sueldos.View
{
    public partial class frmABMfichadas : Form
    {
        private Boolean paraAsistencia=false;

        public frmABMfichadas()
        {
            InitializeComponent();
            this.cmbMovimientos.KeyDown += new KeyEventHandler(cmbMovimientos_KeyDown);
            this.mTBHora.KeyDown += new KeyEventHandler(mTBHora_KeyDown);
            this.cmbReloj.KeyDown += new KeyEventHandler(cmbReloj_KeyDown);
            this.dtpFecha.KeyDown += new KeyEventHandler(dtpFecha_KeyDown);
            this.txtLegajo.KeyDown += new KeyEventHandler(txtLegajo_KeyDown);
            this.cmbEmpleados.KeyDown += new KeyEventHandler(cmbEmpleados_KeyDown);
            this.cargarCombos();
            this.dtpFecha.Value = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
            this.mTBHora.Enabled = false;
            this.habilitaEliminar();
            this.ShowDialog();
        }

        void cmbEmpleados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.dtpFecha.Focus();
            }
        }

        void txtLegajo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.cmbEmpleados.Focus();
            }
        }

        void dtpFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.cmbMovimientos.Focus();
            }
        }

        void cmbReloj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnGrabar.Focus();
            }
        }

        void mTBHora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.cmbReloj.Focus();
            }
        }

        void cmbMovimientos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.mTBHora.Focus();
            }
        }


        public frmABMfichadas(int legajo, DateTime fecha)
        {
            InitializeComponent();
            this.paraAsistencia = true;
            this.mTBHora.KeyDown += new KeyEventHandler(mTBHora_KeyDown);
            this.cargarCombos();
            this.cmbEmpleados.SelectedValue = legajo;
            this.dtpFecha.Value = fecha;
            this.dtpFecha.Enabled = false;
            this.cmbEmpleados.Enabled = false;
            this.txtLegajo.Enabled = false;

            this.habilitaEliminar();
            this.ShowDialog();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmABMfichadas_Load(object sender, EventArgs e)
        {

        }

        private void cargarCombos()
        {
            Controles.cargaComboBox(this.cmbEmpleados, "Apellido y Nombres", "legajo", "empleadosConsultarParaCombo");
            Controles.cargaComboBox(this.cmbMovimientos, "descripcion", "id", "tiposMovimientosHorariosConsultar");
            Controles.cargaComboBox(this.cmbReloj, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "reloj", "indice", 3);
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbEmpleados.SelectedValue != null)
            {
                this.txtLegajo.Text = this.cmbEmpleados.SelectedValue.ToString();
                this.actualizarGrilla();
            }
        }

        private void txtLegajo_TextChanged(object sender, EventArgs e)
        {
            if (this.txtLegajo.Text != "")
                this.cmbEmpleados.SelectedValue = this.txtLegajo.Text;
            else
                this.cmbEmpleados.SelectedValue = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Varios.IsNumeric(Controles.consultaCampoRenglon(this.dgvFichadas, 0)) && Convert.ToInt32(Controles.consultaCampoRenglon(this.dgvFichadas, 0)) > 0)
            {
                if (Varios.confirmaEliminarRegistro())
                {
                    Model.DB.ejecutarProceso(Model.TipoComando.SP, "relojEliminar", "@id", Controles.consultaCampoRenglon(this.dgvFichadas, 0));
                    MessageBox.Show("la fichada se elimino con éxito");
                    this.actualizarGrilla();
                }
            }
        }

        private void actualizarGrilla()
        {
            Controles.cargaDataGridView(this.dgvFichadas, "relojConsultarFichadasLegajoPorDia", "@legajo", this.cmbEmpleados.SelectedValue, "@fecha", this.dtpFecha.Value);
            Controles.setEstandarDataGridView(this.dgvFichadas);
            dgvFichadas.Columns[0].Visible = false;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.cmbEmpleados.SelectedValue) > 0)
                this.habilitaGrabar();

        }

        private void habilitaGrabar()
        {
            this.mTBHora.Enabled = true;
            this.txtLegajo.Enabled = false;
            this.cmbMovimientos.Enabled = true;
            this.cmbReloj.Enabled = true;
            //this.cmbMovimientos.Focus();
            //this.txtLegajo.Focus();
            //this.txtHora.Focus();
            this.dtpFecha.Focus();
            this.cmbEmpleados.Enabled = false;
            this.btnAgregar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnGrabar.Enabled = true;
            this.btnModificar.Enabled = false;
            this.btnCancelar.Enabled = true;
            this.btnCerrar.Enabled = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //Model.DB.ejecutarProceso(Model.TipoComando.SP, "relojActualizar", "@legajo", Convert.ToInt32(this.cmbEmpleados.SelectedValue), "@fecha", this.dtpFecha.Value.ToShortDateString(), "@hora", Convert.ToDateTime(this.mTBHora.Text).ToString("t", System.Globalization.CultureInfo.CreateSpecificCulture("es-ES")).ToString(),"@idTipoMovimiento", Convert.ToInt32(this.cmbMovimientos.SelectedValue ));
            Model.DB.ejecutarProceso(Model.TipoComando.SP, "relojActualizar", "@legajo", Convert.ToInt32(this.cmbEmpleados.SelectedValue), "@fecha", this.dtpFecha.Value.ToShortDateString(), "@hora", this.mTBHora.Text.PadRight(5,'0') , "@idTipoMovimiento", Convert.ToInt32(this.cmbMovimientos.SelectedValue), "@idEstadoFichada", 3, "@idReloj", Convert.ToInt32(this.cmbReloj.SelectedValue));
          //  Model.DB.ejecutarProceso(Model.TipoComando.SP, "relojInsertarCaptura", "legajo", Convert.ToInt32(this.cmbEmpleados.SelectedValue), "fecha", this.dtpFecha.Value.ToShortDateString(), "hora", this.mTBHora.Text, "idReloj", Convert.ToInt32(this.cmbEmpleados.SelectedValue));
            this.actualizarGrilla();
            this.habilitaEliminar();
            this.btnAgregar.Focus();
        }

        private void habilitaEliminar()
        {
            this.mTBHora.Enabled = false;
            this.cmbMovimientos.Enabled = false;
            this.cmbReloj.Enabled = false;
            if (!this.paraAsistencia)
            {
                this.txtLegajo.Enabled = true;
                this.txtLegajo.Focus();
                this.cmbEmpleados.Enabled = true;
            }
            this.btnAgregar.Enabled = true ;
            this.btnEliminar.Enabled = true ;
            this.btnGrabar.Enabled = false;
            this.btnModificar.Enabled = true;
            this.btnCancelar.Enabled = false;
            this.btnCerrar.Enabled = true ;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.habilitaEliminar();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            this.actualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Varios.IsNumeric(Controles.consultaCampoRenglon(this.dgvFichadas, 0)) && Convert.ToInt32(Controles.consultaCampoRenglon(this.dgvFichadas, 0)) > 0)
            {
                this.habilitaGrabar();
                this.cmbMovimientos.SelectedValue = Controles.consultaCampoRenglon(this.dgvFichadas, 4);
                this.mTBHora.Text = Controles.consultaCampoRenglon(this.dgvFichadas, 3);
            }
        }

        private void mTBHora_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }



    }
}