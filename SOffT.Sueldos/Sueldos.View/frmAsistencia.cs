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

namespace Sueldos.View
{
    public partial class frmAsistencia : Form
    {

        private ConsultaLiquidacionDetalle consuliqdet = new ConsultaLiquidacionDetalle();

        /// <summary>
        /// vector de controles textbox para almacenar los 
        /// días.
        /// </summary>
        TextBox[] txtManana = null;
        TextBox[] txtTarde = null;

        Label[] lblDia = null;

        byte topeMes = 0;

        public frmAsistencia()
        {
            InitializeComponent();
            this.txtLegajo.KeyDown += new KeyEventHandler(txtLegajo_KeyDown);
            this.cmbNovedades.KeyDown += new KeyEventHandler(cmbNovedades_KeyDown);
            this.dtpDesde.GotFocus += new EventHandler(dtpDesde_GotFocus);
            this.dtpHasta.GotFocus += new EventHandler(dtpHasta_GotFocus);

        }

        void frmDiasAsistencia_Click(object sender, EventArgs e)
        {
            TextBox tt;
            tt = (TextBox)sender;
            
            frmABMfichadas frmFicha = new frmABMfichadas(Convert.ToInt32(this.cmbEmpleados.SelectedValue), new DateTime(this.dtpFecha.Value.Year, this.dtpFecha.Value.Month,Convert.ToInt32(tt.Tag) + 1));
            frmFicha.Dispose();
        }


        void dtpHasta_GotFocus(object sender, EventArgs e)
        {
            this.seleccionaHasta();
        }

        void dtpDesde_GotFocus(object sender, EventArgs e)
        {
            this.seleccionaDesde();
        }


        void cmbNovedades_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnGrabar.Focus();
        }

        void txtLegajo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnConsultar_Click(sender, e);
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {

        }


        public void abrir()
        {
            dtpFecha.Value = System.DateTime.Now;
            this.topeMes = this.obtieneTopeMes(dtpFecha.Value);
       //   fecha = Convert.ToDateTime("31/05/2007");//System.DateTime.Now;
            Controles.cargaComboBox(this.cmbEmpleados, "Apellido y Nombres", "legajo", "empleadosConsultarParaCombo");
            Controles.cargaComboBox(this.cmbNovedades, "detalle", "indice", "tablasConsultarCodigosAsistencia");
            this.procesaMes(dtpFecha.Value, Convert.ToInt32(this.cmbEmpleados.SelectedValue));
            this.limpiaSeleccionDias();
            this.dtpDesde.Value = this.dtpFecha.Value.Date ;
            this.dtpHasta.Value = this.dtpFecha.Value.Date ; 
            this.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void procesaMes(DateTime fecha, int legajo)
        {
          //  this.verificaLiquidacion(fecha);

            this.armaCalendario(fecha);
            DateTime fdesde = Convert.ToDateTime("01" + "/" + fecha.Month.ToString() + "/" + fecha.Year.ToString());
            DateTime fhasta = Convert.ToDateTime(topeMes + "/" + fecha.Month.ToString() + "/" + fecha.Year.ToString());
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP,"relojConsultarFechas", "@legajo", legajo, "@Desde", fdesde, "@hasta",fecha );
            while (rs.Read())
            {
               this.procesaDia( Convert.ToDateTime(rs["fecha"]),legajo);
            }
            Model.DB.desconectarDB();
            if (fdesde < this.dtpDesde.MaxDate)
            {
                this.dtpDesde.MinDate = fdesde;
                this.dtpDesde.MaxDate = fhasta;
            }
            else
            {
                this.dtpDesde.MaxDate = fhasta;
                this.dtpDesde.MinDate = fdesde;
            }
            this.dtpDesde.Value = fdesde;

            if (fdesde < this.dtpHasta.MaxDate)
            {
                this.dtpHasta.MinDate = fdesde;
                this.dtpHasta.MaxDate = fhasta;
            }
            else
            {
                this.dtpHasta.MaxDate = fhasta;
                this.dtpHasta.MinDate = fdesde;
            }
            this.dtpHasta.Value = fdesde;
            this.rbtMananaDesde.Select();
            this.rbtTardeHasta.Select();

            this.cargaNovedades(fecha, legajo);
        }

        /// <summary>
        /// verifica si la liquidacion de un anioMes se encuentra abierta como para modificar datos
        /// </summary>
        private void verificaLiquidacion(DateTime fecha)
        {
            //si la fecha del sistema es mayor a la que se quiere modificar se verifica la apertura de la liquidacion
            if (Convert.ToInt32(System.DateTime.Now.Year.ToString() + System.DateTime.Now.Month.ToString().PadLeft(2, '0')) > Convert.ToInt32(fecha.Year.ToString() + fecha.Month.ToString().PadLeft(2, '0')))
                //this.btnGrabar.Enabled = Liquidacion.consultarAnioMesAbierta(Convert.ToInt32(fecha.Year.ToString() + fecha.Month.ToString().PadLeft(2, '0')));
                this.btnGrabar.Enabled = consuliqdet.getIdByEstado(Convert.ToInt32(fecha.Year.ToString() + fecha.Month.ToString().PadLeft(2, '0')), 0) > 0;
            else
                this.btnGrabar.Enabled = true;
        }

        private void cargaNovedades(DateTime fecha, int legajo)
        {
            int dia=0;
            int codigo = 0;
            Font fuenteBold = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP,"asistenciaConsultar", "@fecha",fecha,"@legajo", legajo);
            while (rs.Read())
            {
                dia = Convert.ToDateTime(rs["fecha"]).Day - 1;
                codigo = Convert.ToInt32(rs["codigo"]);
                if (codigo != 0)
                {
                    if (Convert.ToInt32(rs["turno"]) == 0)
                    {
                        this.txtManana[dia].ForeColor = Color.Red;
                        this.txtManana[dia].Font = fuenteBold;
                        this.txtManana[dia].Text = this.descripcionCortaCodigo(codigo);
                        this.txtTarde[dia].ForeColor = Color.Red;
                        this.txtTarde[dia].Font = fuenteBold;
                        this.txtTarde[dia].Text = this.descripcionCortaCodigo(codigo);
                    }
                    else
                    {
                        if (Convert.ToInt32(rs["turno"]) == 1)
                        {
                            this.txtManana[dia].Font = fuenteBold;
                            this.txtManana[dia].ForeColor = Color.Red;
                            this.txtManana[dia].Text = this.descripcionCortaCodigo(codigo);
                        }
                        else
                        {
                            if (Convert.ToInt32(rs["turno"]) == 2)
                            {
                                this.txtTarde[dia].ForeColor = Color.Red;
                                this.txtTarde[dia].Font = fuenteBold;
                                this.txtTarde[dia].Text = this.descripcionCortaCodigo(codigo);
                            }
                        }
                    }
                }
            }
            Model.DB.desconectarDB();
        }

        private string descripcionCortaCodigo(int codigo)
        {
            string descri = "";
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP,"tablasConsultarContenidoyDetalle", "@tabla", "Asistencia", "@indice", codigo);
            if (rs.Read())
                descri = rs["detalle"].ToString();
            Model.DB.desconectarDB();
            return descri;
        }


        private string descripcionLargaCodigo(int codigo)
        {
            string descri = "";
            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP,"tablasConsultarContenidoyDetalle", "@tabla", "Asistencia", "@indice", codigo);
            if (rs.Read())
                descri = rs["descripcion"].ToString();
            Model.DB.desconectarDB();
            return descri;
        }

        private void procesaDia(DateTime fecha, int legajo)
        {
            byte dia = Convert.ToByte(fecha.Day); //dia que se esta procesando
            Boolean hayManana; // si hay fichadas a la mañana
      //      Boolean hayTarde; //si hay fichadas a la tarde
            int cont; //contador para la cantidad de fichadas en el dia
            TimeSpan acu =new TimeSpan(0,0,0);; //diferencia entre dos fichadas
            TimeSpan horasTrabajadas=new TimeSpan(0,0,0); //contador de hs. trabajadas
            DateTime horaAnterior=Convert.ToDateTime("00:00:00"); //hora anterior
            TimeSpan tarde = new TimeSpan(14, 0, 0);

            DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP,"relojConsultarFichadasLegajoPorDia", "@legajo", legajo, "@fecha", fecha);

            cont = 1;
            hayManana = false;
            //hayTarde = false;
            if (rs.HasRows)
            {
                while (rs.Read())
                {
                    if (cont % 2 == 0)  //solo cuando es par comparo
                    {
                        acu = Convert.ToDateTime(rs["hora"]).Subtract(horaAnterior);
                        horasTrabajadas = horasTrabajadas.Add(acu);
                    }

                    //si antes de la tarde acumulé + de 3 hs trabajadas
                    Console.WriteLine(Convert.ToDateTime(rs["hora"]).TimeOfDay );
                    if (Convert.ToDateTime(rs["hora"]).TimeOfDay < tarde)
                    {
                        hayManana = true;
                        if (horasTrabajadas > new TimeSpan(3, 0, 0))
                            txtManana[dia - 1].Text = "SI";
                    }
                    //si a la tarde acumule mas de 3 hs trabajadas
                    else
                    {
                    //    hayTarde = true;
                        if (hayManana)
                            txtManana[dia - 1].Text = "SI";
                        if (horasTrabajadas > new TimeSpan(5, 0, 0))
                            txtTarde[dia - 1].Text = "SI";
                    }
                    horaAnterior = Convert.ToDateTime(rs["hora"]);
                    cont++;
                }
            }
            else
            {
                txtManana[dia - 1].Text = "????";
                txtTarde[dia - 1].Text = "????";
            }
            Model.DB.desconectarDB();
        }

        private void armaCalendario(DateTime fecha)
        {
            string mes;
            if (Convert.ToInt32(fecha.Month) > 9)
                mes = fecha.Month.ToString();
            else
                mes=0 + fecha.Month.ToString();

            string fechaStr = "/" + fecha.Month.ToString() + "/" + fecha.Year.ToString();

            Font fuenteBold = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);

            flp15Dias.Controls.Clear();
            flpRestoDias.Controls.Clear();

            txtManana = new TextBox[this.topeMes];
            txtTarde = new TextBox[this.topeMes];
            lblDia = new Label[this.topeMes];
            for (int i=0; i < this.topeMes; i++)
            {
                lblDia[i] = new Label();
                lblDia[i].Width = 30;
                lblDia[i].Height = 15;
                lblDia[i].Font = fuenteBold;
                lblDia[i].ForeColor = Color.Blue;
                lblDia[i].TextAlign = ContentAlignment.BottomCenter ;
                lblDia[i].Text = Convert.ToString(i+1);
                txtManana[i] = new TextBox();
                this.txtManana[i].DoubleClick += new EventHandler(frmDiasAsistencia_Click);
                this.txtManana[i].Tag = i;
                txtTarde[i] = new TextBox();
                this.txtTarde[i].DoubleClick  += new EventHandler(frmDiasAsistencia_Click);
                this.txtTarde[i].Tag = i;
                txtManana[i].BackColor = Color.White;
                txtTarde[i].BackColor = Color.White;
                txtManana[i].Text  = "m " + i;
                txtTarde[i].Text  = "t " + i;
                txtManana[i].ReadOnly = true;
                txtTarde[i].ReadOnly  = true ;
                txtManana[i].Width = 40;
                txtTarde[i].Width = 40;


                if (i < 15)
                {
                    flp15Dias.Controls.Add(lblDia[i]);
                    flp15Dias.Controls.Add(txtManana[i]);
                    flp15Dias.Controls.Add(txtTarde[i]);
                }
                else
                {
                    flpRestoDias.Controls.Add(lblDia[i]);
                    flpRestoDias.Controls.Add(txtManana[i]);
                    flpRestoDias.Controls.Add(txtTarde[i]);
                }

                //DOMINGOS
                if (Convert.ToDateTime((i + 1) + fechaStr).DayOfWeek == DayOfWeek.Sunday)
                {
                    txtManana[i].Text = "DOM";
                    txtManana[i].Font = fuenteBold;
                    txtTarde[i].Text = "DOM";
                    txtTarde[i].Font = fuenteBold;
                }else 
                    //SABADOS
                    if (Convert.ToDateTime((i + 1) + fechaStr).DayOfWeek == DayOfWeek.Saturday)
                    {
                        txtManana[i].Text = "SAB";
                        txtManana[i].Font = fuenteBold;
                        txtTarde[i].Text = "SAB";
                        txtTarde[i].Font = fuenteBold;
                    }
                    else // ????
                    {
                        txtManana[i].Text = "????";
                        txtTarde[i].Text = "????";
                    }
            }

            //FERIADOS
            DbDataReader rsFer = Model.DB.ejecutarDataReader(Model.TipoComando.SP,"tablasConsultarContenidoYdetalle", "@tabla", "Feriados", "@indice", fecha.Year.ToString() + mes);
            while (rsFer.Read())
            {
                txtManana[Convert.ToInt32(rsFer["contenido"]) - 1].Text = "FER";
                txtManana[Convert.ToInt32(rsFer["contenido"]) - 1].Font = fuenteBold;
                txtTarde[Convert.ToInt32(rsFer["contenido"]) - 1].Text = "FER";
                txtTarde[Convert.ToInt32(rsFer["contenido"]) - 1].Font = fuenteBold;
            }
            Model.DB.desconectarDB();
        }


        private byte obtieneTopeMes(DateTime fecha)
        {
            byte mes;
            mes = Convert.ToByte(fecha.Month);
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                return 31;
            else
                if (mes == 2)
                    if (System.DateTime.IsLeapYear(fecha.Year))
                        return 29;
                    else
                        return 28;
                else
                    return 30;
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            this.topeMes=obtieneTopeMes(this.dtpFecha.Value);
            this.flp15Dias.Controls.Clear();
            this.flpRestoDias.Controls.Clear();
        }

        private void grpEmpleados_Enter(object sender, EventArgs e)
        {

        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.flp15Dias.Controls.Clear();
            this.flpRestoDias.Controls.Clear();
            if (this.cmbEmpleados.SelectedValue != null)
                this.txtLegajo.Text = this.cmbEmpleados.SelectedValue.ToString();
        }

        private void txtLegajo_TextChanged(object sender, EventArgs e)
        {
            this.flp15Dias.Controls.Clear();
            this.flpRestoDias.Controls.Clear();
            if (this.txtLegajo.Text.Length > 0)
                this.cmbEmpleados.SelectedValue = this.txtLegajo.Text;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.cmbEmpleados.SelectedValue) > 0)
            {
                procesaMes(dtpFecha.Value, Convert.ToInt32(this.cmbEmpleados.SelectedValue));
                this.cmbNovedades.Focus();
            }
            this.dtpDesde.Value = Convert.ToDateTime(this.dtpFecha.Value.ToShortDateString());
            this.dtpHasta.Value = Convert.ToDateTime(this.dtpFecha.Value.ToShortDateString());
        }

        private void cmbNovedades_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblDescripcionCodigo.Text = this.descripcionLargaCodigo(Convert.ToInt32(this.cmbNovedades.SelectedValue));
        }


        private void seleccionaDesde()
        {
            this.limpiaSeleccionDias();
            if (this.rbtMananaDesde.Checked)
            {   //completo celeste mañana y tarde
                this.txtManana[Convert.ToByte(dtpDesde.Value.Day) -1].BackColor = Color.LightBlue;
                this.txtTarde[Convert.ToByte(dtpDesde.Value.Day) -1].BackColor = Color.LightBlue;
            }   //completo celeste la tarde
            if (this.rbtTardeDesde.Checked)
                this.txtTarde[Convert.ToByte(dtpDesde.Value.Day) - 1].BackColor = Color.LightBlue;
            this.dtpHasta.Focus();
        }

        private void seleccionaHasta()
        {
            int desde;
            int hasta;
            desde = Convert.ToInt32(this.dtpDesde.Value.Day); //-1 + 1
            hasta = Convert.ToInt32(this.dtpHasta.Value.Day) -2; //-1 - 1 
            for (int i = desde; i <= hasta; i++)
            {
                this.txtManana[i].BackColor = Color.LightBlue;
                this.txtTarde[i].BackColor = Color.LightBlue;
            }
            if (this.rbtMananaHasta.Checked )
            {
                this.txtManana[Convert.ToByte(this.dtpHasta.Value.Day) - 1].BackColor = Color.LightBlue;
                //si es el mismo dia y mismo turno
                if (this.dtpDesde.Value == this.dtpHasta.Value && ((this.rbtMananaDesde.Checked && this.rbtMananaHasta.Checked)||(this.rbtTardeDesde.Checked && this.rbtTardeHasta.Checked)))
                    this.txtTarde[Convert.ToByte(this.dtpHasta.Value.Day) - 1].BackColor = Color.White;
            }
            if (this.rbtTardeHasta.Checked)
            {
                if (this.dtpDesde.Value != this.dtpHasta.Value) 
                    this.txtManana[Convert.ToByte(this.dtpHasta.Value.Day) - 1].BackColor = Color.LightBlue;
                this.txtTarde[Convert.ToByte(this.dtpHasta.Value.Day) - 1].BackColor = Color.LightBlue;
            }
            this.btnGrabar.Focus();
        }

        private void limpiaSeleccionDias()
        {
            for (int i = 0; i < this.topeMes; i++)
            {
                this.txtManana[i].BackColor = Color.White;
                this.txtTarde[i].BackColor = Color.White;
            }
                
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            byte desde=0;
            byte hasta=0;
            string fecha;
            string mes;
            if (Convert.ToInt32(dtpFecha.Value.Month) > 9)
                mes = dtpFecha.Value.Month.ToString();
            else
                mes=0 + dtpFecha.Value.Month.ToString();
            double cantidad=0;
            double total = 0;
            byte turno=0;
            fecha="/" + mes + "/" + this.dtpFecha.Value.Year.ToString();
            desde = Convert.ToByte(this.dtpDesde.Value.Day);
            hasta = Convert.ToByte(this.dtpHasta.Value.Day);

            if (this.verificaVacaciones(cuentaDias(desde, hasta)))
            {

                for (desde = Convert.ToByte(this.dtpDesde.Value.Day); desde <= hasta; desde++)
                {
                    if (this.txtManana[desde - 1].BackColor == Color.LightBlue && this.txtTarde[desde - 1].BackColor == Color.LightBlue)
                    {
                        cantidad = 1;
                        total = total + 1;
                        turno = 0;
                    }
                    else
                        if (this.txtManana[desde - 1].BackColor == Color.LightBlue)
                        {
                            cantidad = 0.5;
                            total = total + 0.5;
                            turno = 1;
                        }
                        else
                            if (this.txtTarde[desde - 1].BackColor == Color.LightBlue)
                            {
                                cantidad = 0.5;
                                total = total + 0.5;
                                turno = 2;
                            }
                    Model.DB.ejecutarProceso(Model.TipoComando.SP, "asistenciaActualizar", "@fecha", desde.ToString() + fecha, "@legajo", Convert.ToInt32(this.cmbEmpleados.SelectedValue), "@codigo", Convert.ToInt32(this.cmbNovedades.SelectedValue), "@cantidad", cantidad, "@turno", turno);
                }



                this.procesaMes(dtpFecha.Value, Convert.ToInt32(this.cmbEmpleados.SelectedValue));
            }
        }

        private double cuentaDias(byte desde, byte hasta)
        {
            double total=0;
            for (desde = Convert.ToByte(this.dtpDesde.Value.Day); desde <= hasta; desde++)
            {
                if (this.txtManana[desde - 1].BackColor == Color.LightBlue && this.txtTarde[desde - 1].BackColor == Color.LightBlue)
                    total = total + 1;
                else
                    if (this.txtManana[desde - 1].BackColor == Color.LightBlue)
                        total = total + 0.5;
                    else
                        if (this.txtTarde[desde - 1].BackColor == Color.LightBlue)
                            total = total + 0.5;
            }
            return total;
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpDesde.Value > this.dtpHasta.Value && this.dtpDesde.Value >= this.dtpHasta.MinDate && this.dtpDesde.Value <= this.dtpHasta.MaxDate)
                this.dtpHasta.Value = this.dtpDesde.Value;
            this.seleccionaDesde();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            this.seleccionaDesde();
            this.seleccionaHasta();
        }

        private void rbtMananaHasta_CheckedChanged(object sender, EventArgs e)
        {
            this.seleccionaDesde();
            this.seleccionaHasta();
        }

        private void rbtTardeHasta_CheckedChanged(object sender, EventArgs e)
        {
            this.seleccionaDesde();
            this.seleccionaHasta();
        }

        private void rbtMananaDesde_CheckedChanged(object sender, EventArgs e)
        {
            this.seleccionaDesde();
        }

        private void rbtTardeDesde_CheckedChanged(object sender, EventArgs e)
        {
            this.seleccionaDesde();
        }

        /// <summary>
        /// verifica si el codigo a grabar está entre los codigos que tienen contenido=1
        /// en la tabla asistencia. Éstos codigos son los que deben solicitar informacion
        /// para almacenar las vacaciones.
        /// </summary>
        /// <returns></returns>
        private bool verificaVacaciones(double dias)
        {
            bool ok = false; ;
            DbDataReader rsAsis = Model.DB.ejecutarDataReader(Model.TipoComando.SP,"tablasConsultarContenidoYdetalle", "@tabla", "Asistencia", "@indice", this.cmbNovedades.SelectedValue);
            while (rsAsis.Read())
            {
                if (rsAsis["contenido"].ToString() == "1")
                {
                    frmVacacionesEmpleado frmVac = new frmVacacionesEmpleado();
                    ok = frmVac.abrirParaCargar(this.dtpFecha.Value.Year.ToString(), this.dtpFecha.Value.Month.ToString(), dias.ToString(), Convert.ToInt32(this.cmbEmpleados.SelectedValue), this.dtpDesde.Value, Convert.ToInt32(this.cmbNovedades.SelectedValue));
                }
                else
                    ok = true;
                    
            }
            Model.DB.desconectarDB();
            return ok;
        }

        private void flp15Dias_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}