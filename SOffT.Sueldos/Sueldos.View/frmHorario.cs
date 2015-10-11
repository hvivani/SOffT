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
    public partial class frmHorario : Form
    {
        /// <summary>
        /// variable local para controlar los datos a pasar en el form.
        /// </summary>
        private HorarioEntity horario;

        public HorarioEntity Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        public frmHorario()
        {
            InitializeComponent();
            this.cargarCombos();
        }


        private void cargarCombos()
        {
            Controles.cargaComboBox(this.cmbDias, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "Calendario", "indice", 3);
            Controles.cargaComboBox(this.cmbMovimientos, "descripcion", "id", "tiposMovimientosHorariosConsultar");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Horario = null;
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            this.horario.LimiteDia = Convert.ToInt32(this.txtLimiteDia.Text);
            this.Horario.IdDia = Convert.ToInt32(this.cmbDias.SelectedValue);
            this.Horario.Dia = this.cmbDias.Text;
            this.Horario.IdTipoMovimiento = Convert.ToInt32(this.cmbMovimientos.SelectedValue);
            this.Horario.TipoMovimiento = this.cmbMovimientos.Text;
            this.Horario.Hora = this.mTBHora.Text;
            this.Horario.Tolerancia = Convert.ToInt32(this.txtTolerancia.Text);
            this.Close();
        }

        public void cargarDatos()
        {
            this.cmbDias.SelectedValue = this.Horario.IdDia;
            this.txtLimiteDia.Text = this.horario.LimiteDia.ToString();
            this.cmbMovimientos.SelectedValue = this.Horario.IdTipoMovimiento;
            this.mTBHora.Text=this.Horario.Hora;
            this.txtTolerancia.Text = this.horario.Tolerancia.ToString();
        }

        private void frmHorario_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }

        private void txtLimiteDia_TextChanged(object sender, EventArgs e)
        {
            if (Varios.IsNumeric(this.txtLimiteDia.Text) && Convert.ToInt32(this.txtLimiteDia.Text) >= 0 && Convert.ToInt32(this.txtLimiteDia.Text) <=24)
                this.horario.LimiteDia  = Convert.ToInt32( this.txtLimiteDia.Text);
        }

        private void txtTolerancia_TextChanged(object sender, EventArgs e)
        {

            if (Varios.IsNumeric(this.txtTolerancia.Text) && Convert.ToInt32(this.txtTolerancia.Text) >= 0 && Convert.ToInt32(this.txtTolerancia.Text) <= 60)
                this.horario.Tolerancia = Convert.ToInt32(this.txtTolerancia.Text);

        }

    }
}