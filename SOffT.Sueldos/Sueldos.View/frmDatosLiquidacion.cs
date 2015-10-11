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
using Sueldos.Entidades;
using Sueldos.Modelo;

namespace Sueldos.View
{
    public partial class frmDatosLiquidacion : Form
    {

        private LiquidacionDetalleEntity liquidacionDetalle = null;
        private ConsultaTablas consutab = new ConsultaTablas();
        private ConsultaLiquidacionDetalle consuliqdet = new ConsultaLiquidacionDetalle();
        private ConsultaLiquidacionesPorTipo consuliqtipo = new ConsultaLiquidacionesPorTipo();

        public frmDatosLiquidacion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (this.btnGrabar.Enabled)
            {
                DialogResult result = MessageBox.Show("Salir sin grabar los cambios ? ", "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    this.Close();
            }
            else
                this.Close();
        }


        private void cmbTipoLiquidacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbAplicacion.Enabled = true;
        }

        private void frmDatosLiquidacion_Load(object sender, EventArgs e)
        {
            this.actualizarCombos();
        }

        public void abrirParaAgregar()
        {
            this.cargarCombos();

            this.cmbAnios.SelectedValue = double.Parse(System.DateTime.Now.Year.ToString());
            this.cmbMeses.SelectedValue = double.Parse(System.DateTime.Now.Month.ToString());

            liquidacionDetalle = new LiquidacionDetalleEntity(Convert.ToInt32(Varios.anioMes(Convert.ToInt32(this.cmbAnios.SelectedValue), Convert.ToByte(this.cmbMeses.SelectedValue))), 1, System.DateTime.Now.Date);
            liquidacionDetalleEntityBindingSource.DataSource = liquidacionDetalle;
            
            this.dtpFechaDePago.Value = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
            liquidacionDetalle.FechaDepositado = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());

            this.gbLiquidacion.Enabled = true;
            this.gbLiquidacion1.Enabled = true;
            this.gbLiquidacion2.Enabled = true;
            this.gbTipoLiquidacion.Enabled = true;
            this.gbFechasDePago.Enabled = true;
            this.btnGrabar.Enabled = true;
            liquidacionDetalle.PeriodoLiquidado = this.cmbAplicacion.Text + " " + this.cmbMeses.Text + "/" + this.cmbAnios.Text;

            this.liquidacionDetalle.RecibosSeparados = true;

            this.cmbTipoSalario.SelectedValue  = 1;
            this.ShowDialog();
        }

        public void abrirParaModificar(int idLiquidacion)
        {
            this.cargarCombos();

            this.cmbAnios.SelectedValue = double.Parse(System.DateTime.Now.Year.ToString());
            this.cmbMeses.SelectedValue = double.Parse(System.DateTime.Now.Month.ToString());

            liquidacionDetalle = new LiquidacionDetalleEntity(idLiquidacion);
            liquidacionDetalle = consuliqdet.getById(idLiquidacion);

            liquidacionDetalleEntityBindingSource.DataSource = liquidacionDetalle;

            this.actualizarCombos();

            this.cmbAplicacion.SelectedValue = liquidacionDetalle.IdAplicacion;
            this.cmbTipoSalario.SelectedValue = liquidacionDetalle.IdTipoSalario;

            this.cargaListaLiquidacionesPorTipo();

            this.cargaListFechasDePago();

            this.gbLiquidacion.Enabled = false;
            this.gbLiquidacion1.Enabled = true;
            this.gbLiquidacion2.Enabled = true;
            this.gbTipoLiquidacion.Enabled = true;
            this.gbFechasDePago.Enabled = true;
            this.btnGrabar.Enabled = false;

            this.ShowDialog();
        }

        public void abrirParaConsultar(int idLiquidacion)
        {
            this.cargarCombos();

            this.cmbAnios.SelectedValue = double.Parse(System.DateTime.Now.Year.ToString());
            this.cmbMeses.SelectedValue = double.Parse(System.DateTime.Now.Month.ToString());

            liquidacionDetalle = new LiquidacionDetalleEntity(idLiquidacion);
            liquidacionDetalle = consuliqdet.getById(idLiquidacion);
            
            liquidacionDetalleEntityBindingSource.DataSource = liquidacionDetalle;

            this.actualizarCombos();

            this.cmbAplicacion.SelectedValue = liquidacionDetalle.IdAplicacion;
            this.cmbTipoSalario.SelectedValue = liquidacionDetalle.IdTipoSalario;

            this.cargaListaLiquidacionesPorTipo();

            this.cargaListFechasDePago();

            this.gbLiquidacion.Enabled = false;
            this.gbLiquidacion1.Enabled = false;
            this.gbLiquidacion2.Enabled = false;
            this.gbTipoLiquidacion.Enabled = false;
            this.gbFechasDePago.Enabled = false;
            this.btnGrabar.Enabled = false;
            this.ShowDialog();
        }


        private void cargarCombos()
        {
            Controles.cargaComboBox(this.cmbAnios, "contenido", "contenido", consutab.getContenidoYdetalle("calendario", 1));
            Controles.cargaComboBox(this.cmbMeses, "detalle", "contenido", consutab.getContenidoYdetalle("calendario", 2));
            Controles.cargaComboBox(this.cmbEstado, "detalle", "contenido", consutab.getContenidoYdetalle("liquidacionesDetalle", 0));            
            Controles.cargaListBox(this.lstTiposLiquidaciones,"descripcion","indice",consutab.getByNombre("tiposDeLiquidacion","indice < 100","indice"));
            Controles.cargaComboBox(this.cmbAplicacion,"descripcion","indice",consutab.getByNombre("aplicacionLiquida","indice > 0","nombre, indice, descripcion, contenido"));
            Controles.cargaComboBox(this.cmbTipoSalario, "descripcion", "indice", consutab.getByNombre("tiposDeSalario","nombre, indice, descripcion, contenido"));
        }


        private void cargaListaLiquidacionesPorTipo()
        {
            //cargo lista liquidaciones por tipo
            foreach (LiquidacionPorTipoEntity liq in consuliqtipo.getAll(liquidacionDetalle.Id))
                this.lstTiposLiquidaciones.SetSelected(liq.IdTipoLiquidacion - 1, true);
        }

        private void actualizarCombos()
        {
            //Parseo a double por equivalencias en el match entre el combo y el objeto tabla
            if (liquidacionDetalle.AnioMes > 0)
            {
                this.cmbAnios.SelectedValue = double.Parse(Varios.Left(liquidacionDetalle.AnioMes.ToString(), 4));
                this.cmbMeses.SelectedValue = double.Parse(Varios.Right(liquidacionDetalle.AnioMes.ToString(), 2));

                this.cmbEstado.SelectedValue = double.Parse(liquidacionDetalle.Estado ? "1" : "0");

            }
        }

        private void cargaListFechasDePago()
        {
            foreach (FechaDePagoEntity item in this.liquidacionDetalle.FechasDePago)
                this.lstFechasDePago.Items.Add(item.FechaDePago);
            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            liquidacionDetalle.AnioMes = Convert.ToInt32(Varios.anioMes(Convert.ToInt32(this.cmbAnios.SelectedValue), Convert.ToByte(this.cmbMeses.SelectedValue)));
            if (this.datosValidos())
            {

                if (liquidacionDetalle.Id == 0)
                {
                    consuliqdet.insert(liquidacionDetalle);
                    //consulto el id asignado:
                    liquidacionDetalle.Id = consuliqdet.getById(liquidacionDetalle.AnioMes, liquidacionDetalle.IdAplicacion, liquidacionDetalle.FechaLiquidacion).Id;
                    this.actualizaFechasDePago();
                    consuliqdet.insertarFechasDePago(liquidacionDetalle.FechasDePago);
                }
                else
                {
                    this.actualizaFechasDePago();
                    consuliqdet.update(liquidacionDetalle);
                }
                //grabo las liquidaciones por tipo
                //primero elimino las existentes
                foreach (LiquidacionPorTipoEntity liq in consuliqtipo.getAll(liquidacionDetalle.Id))
                    consuliqtipo.delete(liq);
                //inserto nuevos
                foreach (int tab in this.lstTiposLiquidaciones.SelectedIndices)
                    consuliqtipo.insert(new LiquidacionPorTipoEntity(liquidacionDetalle.Id, tab+1));

                this.btnGrabar.Enabled = false;
            }
        }


        private void cmbAnios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(this.cmbAnios.SelectedValue );
        }

        private bool datosValidos()
        {
            Boolean ok = true;
            if (liquidacionDetalle.Descripcion == null || liquidacionDetalle.Descripcion.Length < 1)
            {
                MessageBox.Show("Debe ingresar una descripción.");
                ok = false;
                this.txtDescripcion.Focus();
            }
            else
            {
                if (liquidacionDetalle.FechaLiquidacion.Equals(null))
                {
                    MessageBox.Show("Debe establecer la fecha de liquidación");
                    ok = false;
                    this.dtpFechaLiquidacion.Focus();
                }
                else
                {
                    if (liquidacionDetalle.PeriodoDepositado == null || liquidacionDetalle.PeriodoDepositado.Length < 1)
                    {
                        MessageBox.Show("Debe ingresar período depositado.");
                        ok = false;
                        this.txtPeriodoDepositado.Focus();
                    }
                    else
                    {
                        if (liquidacionDetalle.BancoDepositado == null || liquidacionDetalle.BancoDepositado.Length < 1)
                        {
                            MessageBox.Show("Debe ingresar período banco depositado.");
                            ok = false;
                            this.txtBancoDepositado.Focus();
                        }
                        else
                        {
                            if (this.lstTiposLiquidaciones.SelectedIndex == -1)
                            {
                                MessageBox.Show("Debe seleccionar algún tipo de liquidación para abrir.");
                                ok = false;
                                this.lstTiposLiquidaciones.Focus();
                            }
                            else
                            {
                                if (this.lstFechasDePago.Items.Count == 0)
                                {
                                    MessageBox.Show("Debe ingresar al menos una fecha de pago.");
                                    ok = false;
                                    this.btnInsertar.Focus();
                                }
                            }
                        }
                    }
                }
            }
            return ok;

        }

        private void cmbMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (liquidacionDetalle != null)
                this.btnGrabar.Enabled = true;
        }

        private void dtpFechaLiquidacion_ValueChanged(object sender, EventArgs e)
        {
            this.btnGrabar.Enabled = true;
        }

        private void txtPeriodoLiquidado_TextChanged(object sender, EventArgs e)
        {
            this.btnGrabar.Enabled = true;
        }

        private void txtLugarDePago_TextChanged(object sender, EventArgs e)
        {
            this.btnGrabar.Enabled = true;
        }

        private void dtpFechaDePago_ValueChanged(object sender, EventArgs e)
        {
          //  liquidacion.FechaDePago = this.dtpFechaDePago.Value;
          //  this.btnGrabar.Enabled = true;
        }

        private void txtPeriodoDepositado_TextChanged(object sender, EventArgs e)
        {
            this.btnGrabar.Enabled = true;
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liquidacionDetalle != null)
            {
                this.liquidacionDetalle.Estado = Convert.ToBoolean(int.Parse( this.cmbEstado.SelectedValue.ToString()));
                this.btnGrabar.Enabled = true;
            }
        }

        private void dtpFechaDepositado_ValueChanged(object sender, EventArgs e)
        {
            this.btnGrabar.Enabled = true;
        }

        private void txtBancoDepositado_TextChanged(object sender, EventArgs e)
        {
            this.btnGrabar.Enabled = true;
        }

        private void cmbAplicacion_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (liquidacionDetalle != null)
            {
                this.liquidacionDetalle.IdAplicacion = int.Parse(cmbAplicacion.SelectedValue.ToString());
                Console.WriteLine(cmbAplicacion.SelectedValue.ToString());
                this.btnGrabar.Enabled = true;
                this.armaDescripcionLiquidacion();
                this.liquidacionDetalle.PeriodoLiquidado = this.cmbAplicacion.Text + " " + this.cmbMeses.Text + "/" + this.cmbAnios.Text;

                this.actualizarCombos();
            }

            Console.WriteLine(cmbAplicacion.SelectedValue.ToString());
            if (Convert.ToInt32(cmbAplicacion.SelectedValue) != 1)
            {
                this.cmbTipoSalario.SelectedValue = 0;
                this.cmbTipoSalario.Enabled = true;
            }
            else
            {
                this.cmbTipoSalario.SelectedValue = 1;
                this.cmbTipoSalario.Enabled = false;
            }
            this.liquidacionDetalleEntityBindingSource.ResetBindings(false);
            
        }


        private void cmbTipoSalario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liquidacionDetalle != null)
            {
                this.liquidacionDetalle.IdTipoSalario = int.Parse(this.cmbTipoSalario.SelectedValue.ToString());
                this.btnGrabar.Enabled = true;
            }

        }

        private void lstTiposLiquidaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.armaDescripcionLiquidacion();
            this.liquidacionDetalleEntityBindingSource.ResetBindings(false);
            this.btnGrabar.Enabled = true;
        }

        private void chkRecibosSeparados_CheckedChanged(object sender, EventArgs e)
        {
           // if (liquidacionDetalle != null)
           //     liquidacionDetalle.RecibosSeparados = this.chkRecibosSeparados.Checked;
            this.btnGrabar.Enabled = true;
        }

        private void armaDescripcionLiquidacion()
        {
            if (liquidacionDetalle != null)
            {
                this.liquidacionDetalle.AnioMes = Convert.ToInt32(Varios.anioMes(Convert.ToInt32(this.cmbAnios.SelectedValue), Convert.ToByte(this.cmbMeses.SelectedValue)));
                //arma descripcion de liquidacion
                this.liquidacionDetalle.Descripcion = liquidacionDetalle.AnioMes.ToString() + "/" + this.cmbAplicacion.Text + this.obtieneTiposLiquidacionesSeleccionadas();
                //this.txtDescripcion.Text = aniomes.ToString() + "/" +  this.cmbAplicacion.Text + this.obtieneTiposLiquidacionesSeleccionadas();
                //this.liquidacionDetalleEntityBindingSource.ResetBindings(false);
            }
        }

        private string obtieneTiposLiquidacionesSeleccionadas()
        {
            string cadena = "";
            foreach (TablaEntity tabla in this.lstTiposLiquidaciones.SelectedItems)
            {
                cadena = cadena + "/" + tabla.Descripcion; 
            }
            return cadena;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstFechasDePago.SelectedIndex >= 0)
            {
                this.lstFechasDePago.Items.RemoveAt(this.lstFechasDePago.SelectedIndex);
                this.btnGrabar.Enabled = true;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (verificaFechaDuplicada(this.dtpFechaDePago.Value.Date))
                MessageBox.Show("La fecha ya existe.");
            else
            {
                this.lstFechasDePago.Items.Add(this.dtpFechaDePago.Value.Date);
                this.btnGrabar.Enabled = true;
            }
        }

        private Boolean verificaFechaDuplicada(DateTime fecha)
        {
            Boolean existe = false;
            foreach (Object item in this.lstFechasDePago.Items )
            {
                if (fecha.CompareTo(Convert.ToDateTime(item)) == 0)
                    existe=true;
            }
            return existe;
        }

        /// <summary>
        /// Actualiza la coleccion de fechas de pago del objeto liquidacion recorriendo
        /// el control de lista de fechas
        /// </summary>
        private void actualizaFechasDePago()
        {
            //primero elimino existentes en la lista del objeto.
            this.liquidacionDetalle.FechasDePago.Clear();
            //ahora inserto todo el contenido nuevamente    
            foreach (DateTime item in this.lstFechasDePago.Items)
                this.liquidacionDetalle.FechasDePago.Add(new FechaDePagoEntity(liquidacionDetalle.Id, item.Date));
        }

        private void lstFechasDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}