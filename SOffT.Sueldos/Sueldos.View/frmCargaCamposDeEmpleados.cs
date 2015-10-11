using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sofft.Utils;
using Sofft.ViewComunes;
using Sueldos.Entidades;

namespace Sueldos.View
{
    public partial class frmCargaCamposDeEmpleados : Form
    {

        List<CampoEmpleadoEntity> camposEmpleado;
        CampoEmpleadoEntity campo;

        public frmCargaCamposDeEmpleados()
        {
            InitializeComponent();
            this.txtLegajo.KeyDown += new KeyEventHandler(txtLegajo_KeyDown);
            this.txtLegajo.GotFocus += new EventHandler(txtLegajo_GotFocus);
            this.cmbEmpleados.KeyDown += new KeyEventHandler(cmbEmpleados_KeyDown);
            this.cmbTablasIndice.KeyDown += new KeyEventHandler(cmbTablasIndice_KeyDown);
            this.cmbTablasDetalle.KeyDown += new KeyEventHandler(cmbTablasDetalle_KeyDown);
            this.txtValor.KeyDown += new KeyEventHandler(txtValor_KeyDown);
            this.txtValor.GotFocus += new EventHandler(txtValor_GotFocus);
            this.cargarCombos();
            camposEmpleado = new  List<CampoEmpleadoEntity>();
            this.ShowDialog();
        }

        void txtLegajo_GotFocus(object sender, EventArgs e)
        {
            this.txtLegajo.SelectAll();
        }

        void txtValor_GotFocus(object sender, EventArgs e)
        {
            this.txtValor.SelectAll();
        }

        void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnGrabar.Focus();
            }
        }

        void cmbTablasIndice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtValor.Enabled)
                    this.txtValor.Focus();
                else
                    this.cmbTablasDetalle.Focus();
            }
        }

        void cmbTablasDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnGrabar.Focus();
            }
             
        }

        void cmbEmpleados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.cmbTablasIndice.Focus();
        }

        void txtLegajo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.cmbEmpleados.Focus();
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cargarCombos()
        {
            Controles.cargaComboBox(this.cmbEmpleados, "Apellido y Nombres", "legajo", "empleadosConsultarParaCombo");
            Controles.cargaComboBox(this.cmbTablasIndice, "descripcion", "indice", "tablasConsultarIndiceDescripcion", "@tabla", "empleadosSueldos");
            Controles.cargaComboBox(this.cmbTablasDetalle, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "empleadosSueldos", "@indice", this.cmbTablasIndice.SelectedValue);
        }

        private void cmbTablasIndice_SelectedIndexChanged(object sender, EventArgs e)
        {

            Controles.cargaComboBox(this.cmbTablasDetalle, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "empleadosSueldos", "@indice", this.cmbTablasIndice.SelectedValue);
            //busca valor almacenado para mostralo como predeterminado.
            this.actualizaValorLegajo();
        }

        private void txtLegajo_TextChanged(object sender, EventArgs e)
        {
            if (Varios.IsNumeric(this.txtLegajo.Text))
            {
                this.cmbEmpleados.SelectedValue = this.txtLegajo.Text;
                this.actualizaValorLegajo();
            }
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbEmpleados.SelectedValue != null)
                this.txtLegajo.Text = this.cmbEmpleados.SelectedValue.ToString();
        }

        private void cmbTablasDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbTablasDetalle.Text == "")
            {
                this.cmbTablasDetalle.Enabled = false;
                this.txtValor.Enabled = true;
            }
            else
            {
                this.txtValor.Text = "";
                this.cmbTablasDetalle.Enabled = true;
                this.txtValor.Enabled = false;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.cmbEmpleados.SelectedValue) > 0 && Convert.ToInt32(this.cmbTablasIndice.SelectedValue) > 0)
            {
                campo = new CampoEmpleadoEntity(Convert.ToInt32(this.cmbEmpleados.SelectedValue), this.cmbEmpleados.Text, Convert.ToInt32(this.cmbTablasIndice.SelectedValue), this.cmbTablasIndice.Text, this.txtValor.Text, this.cmbTablasDetalle.Text);
                //camposEmpleado.Add(campo);
                camposEmpleado.Insert(0, campo);

                this.dgvCamposEmpleado.DataSource = null;
                this.dgvCamposEmpleado.DataSource = this.camposEmpleado;

                //formatea DGV
                this.dgvCamposEmpleado.Columns["legajo"].DisplayIndex = 0;
                this.dgvCamposEmpleado.Columns["nombre"].DisplayIndex = 1;
                this.dgvCamposEmpleado.Columns["codigo"].DisplayIndex = 2;
                this.dgvCamposEmpleado.Columns["descripcion"].DisplayIndex = 3;
                this.dgvCamposEmpleado.Columns["valor"].DisplayIndex = 4;
                this.dgvCamposEmpleado.Columns["detalle"].DisplayIndex = 5;
                Controles.setEstandarDataGridView(this.dgvCamposEmpleado);

                //graba datos del registro
                if (this.txtValor.Enabled)
                    Model.DB.ejecutarProceso(Model.TipoComando.SP, "empleadosSueldosActualizar", "@legajo", Convert.ToInt32(this.cmbEmpleados.SelectedValue), "@codigo", Convert.ToInt32(this.cmbTablasIndice.SelectedValue), "@valor", this.txtValor.Text);
                else
                    Model.DB.ejecutarProceso(Model.TipoComando.SP, "empleadosSueldosActualizar", "@legajo", Convert.ToInt32(this.cmbEmpleados.SelectedValue), "@codigo", Convert.ToInt32(this.cmbTablasIndice.SelectedValue), "@valor", Convert.ToInt32(this.cmbTablasDetalle.SelectedValue));
            }
            else
                MessageBox.Show("Hay datos invalidos. Verifique !!");
            this.txtLegajo.Focus();
        }

        private void actualizaValorLegajo()
        {
            string valor="";
            if (this.cmbTablasIndice.SelectedValue!=null)
            {
                if (this.cmbEmpleados.SelectedValue != null)
                {
                    if (Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(this.cmbEmpleados.SelectedValue), "@codigo", Convert.ToInt32(this.cmbTablasIndice.SelectedValue))==null)
                        valor = "-1";
                    else
                        valor=Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(this.cmbEmpleados.SelectedValue), "@codigo", Convert.ToInt32(this.cmbTablasIndice.SelectedValue)).ToString();
                    //valor = valor.ToString();
                    if (Varios.IsNumeric(valor))
                        this.cmbTablasDetalle.SelectedValue = valor;
                    else
                        this.cmbTablasDetalle.SelectedValue = 0;
                }
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}