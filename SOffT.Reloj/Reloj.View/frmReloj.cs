/*  
    frmReloj.cs

    Author:
    Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>
    Hernan Vivani <hernan@vivani.com.ar> - http://hvivani.com.ar

    Copyright © SOffT 2008 - http://www.sofft.com.ar

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using System.Globalization;
using System.Threading;
using System.Configuration;
using Sofft.Utils;
using Sofft.ViewComunes;
using Reloj.Entidades;
using Reloj.Negocio;
using Sueldos.Modelo;
using Sueldos.Entidades;
using WisSensorNLibLib;


namespace Reloj.View
{
    public partial class frmReloj : Form
    {

        WisSensorN WisObj = new WisSensorN();

        private TarjetaFichadaEntity tarjetaFichada = null;
        private FichadaEntity fichada=null;

        private FichadasNegocio fichadasNegocio = new FichadasNegocio();
        private ConsultaTablas consultaTablas = new ConsultaTablas();

        private DateTime ultimaFichada=new DateTime(0);
        private int ultimoLegajo = 0;

        private HuellasNegocio huellasNegocio = new HuellasNegocio();
        private HuellaEntity huella;
        private Boolean capturando = false;
        string[] arrayHuellas;
        List<HuellaEntity> huellas = null;


        public frmReloj()
        {
            InitializeComponent();
            this.pictureBoxEmpresa.Image = Controles.cargarImagen(Application.StartupPath + @"/imagenes/logoGrande.jpg");
            //Evento para mantener siempre en el foco en la entrada de texto
            textBoxStringTarjeta.LostFocus += new EventHandler(textBoxLegajo_LostFocus);
            //Evento para manejar el retorno de carro en la entrada de texto
            textBoxStringTarjeta.KeyDown += new KeyEventHandler(textBoxLegajo_KeyDown);
            this.lblVersion.Text = "versión: " + Application.ProductVersion;
            this.seteaCultura();
            //setea tooltip
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(this.btnExportar,"exportar fichadas");
        }

        void textBoxLegajo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.tarjetaFichada = new TarjetaFichadaEntity(this.textBoxStringTarjeta.Text);
                this.fichada = new FichadaEntity(0, tarjetaFichada.Legajo);
                this.procesaFichada(fichada);
            }
        }

        private void textBoxLegajo_LostFocus(object sender, EventArgs e)
        {
            if (textBoxStringTarjeta.Enabled)
            {
                textBoxStringTarjeta.Focus();
            }
        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            labelSistemaFecha.Text = DateTime.Now.Date.ToLongDateString().ToUpper();
            labelSistemaHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.timerHuella.Start();
            //this.capturando = true;
            BotonesHabilitar(btnDetener.Enabled);
            cargarFichadas();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            this.timerHuella.Stop();
            this.capturando = false;
            WisObj.StopCapture();
            BotonesHabilitar(btnDetener.Enabled);
            textBoxStringTarjeta.Clear();
            this.lstFichadas.Items.Clear();
       }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonesHabilitar(Boolean habilita)
        {
            btnIniciar.Enabled = habilita;
            btnSalir.Enabled = habilita;
            btnDetener.Enabled = !habilita;
            textBoxStringTarjeta.Enabled = !habilita;
        }



        private void cargarFichadas()
        {
            this.lstFichadas.Items.Clear();
            List<FichadaEntity> fichadas = null;
            //Cargo lista de fichadas            
            fichadas = fichadasNegocio.getListaEntreFechas(System.DateTime.Now.Date, System.DateTime.Now.Date);
            foreach (FichadaEntity f in fichadas)
            {
                this.lstFichadas.Items.Add(f.Fecha + "  " + f.Hora  + "  " + f.Legajo.ToString().PadLeft(5, '0') + "  " + f.ApellidoYnombres);
            }
            //Cargo info Ultima Fichada
            if (fichadas != null && fichadas.Count>0)
            {
                FichadaEntity ultima = fichadas[0]; //[fichadas.Count - 1];
                labelUltimaFichadaHora.Text = ultima.Hora;
                labelUltimaFichadaFecha.Text = ultima.Fecha;
                labelUltimaFichadaLegajo.Text = ultima.Legajo.ToString().PadLeft(5, '0');
                labelUltimaFichadaApellidoNombre.Text = ultima.ApellidoYnombres;
                if (ultima.Foto == null)
                    pictureBoxUltimaFichadaFoto.Image = null;
                else
                    pictureBoxUltimaFichadaFoto.Image = Controles.cargarImagen(ultima.Foto);
            }
            textBoxStringTarjeta.Clear();
            textBoxStringTarjeta.Focus();
        }

        private void FormReloj_Shown(object sender, EventArgs e)
        {
            BotonesHabilitar(btnDetener.Enabled);
            cargarFichadas();
            textBoxStringTarjeta.Focus();
        }


        private void procesaFichada(FichadaEntity fichada)
        {
            long segundosEntreFichada;
            fichada.Fecha = System.DateTime.Now.ToShortDateString(); 
            fichada.Hora = System.DateTime.Now.Hour.ToString().PadLeft(2, '0') + ":" + System.DateTime.Now.Minute.ToString().PadLeft(2, '0') + ":" + System.DateTime.Now.Second.ToString().PadLeft(2, '0');

            //verifica tiempos entre fichadas y legajo repetido
            //si la fichada es del mismo legajo y está dentro de los 30 segundos se descarta.
            segundosEntreFichada = Varios.DateDiff(Varios.DateInterval.Second, this.ultimaFichada, Convert.ToDateTime(fichada.Hora));
            if (this.ultimoLegajo ==fichada.Legajo && segundosEntreFichada < 30)
                return;          
            this.ultimaFichada = Convert.ToDateTime(fichada.Hora);
            this.ultimoLegajo = fichada.Legajo;

            labelUltimaFichadaHora.Text = fichada.Hora;
            labelUltimaFichadaFecha.Text = fichada.Fecha;
            labelUltimaFichadaLegajo.Text = fichada.Legajo.ToString();

            fichada.ApellidoYnombres = ConsultaEmpleados.consultarApellidoYnombres(fichada.Legajo);
            //ConsultaEmpleados.
            //Cargo datos fichada
            if (fichada.ApellidoYnombres != "SIN DATO")
            {
                fichada.Foto = ConsultaEmpleados.consultarFoto(fichada.Legajo);
                labelUltimaFichadaApellidoNombre.Text = fichada.ApellidoYnombres;
                if (fichada.Foto=="")
                    pictureBoxUltimaFichadaFoto.Image = null;
                else
                    pictureBoxUltimaFichadaFoto.Image = Controles.cargarImagen(fichada.Foto);
                //inserta en lista por arriba
                this.lstFichadas.Items.Insert(0, fichada.Fecha + "  " + fichada.Hora + "  " + fichada.Legajo.ToString().PadLeft(5, '0') + "  " + labelUltimaFichadaApellidoNombre.Text);
                //inserta registro en db.

                fichada.Reloj = consultaTablas.getById("reloj", 3, Program.idReloj);
                fichadasNegocio.Guardar(fichada);
              //  Model.DB.ejecutarProceso(Model.TipoComando.SP, "relojInsertarCaptura", "legajo", legajo, "fecha", fecha, "hora", hora, "idReloj", Program.idReloj);
            }
            else
            {
                labelUltimaFichadaApellidoNombre.Text = "!!!! ERROR !!!!";
                pictureBoxUltimaFichadaFoto.Image = null;
            }

            //limpia campo
            this.textBoxStringTarjeta.Clear();
        }

        private void pictureBoxUltimaFichadaFoto_Click(object sender, EventArgs e)
        {

        }

        private void seteaCultura()
        {
            Console.WriteLine("Seteando configuración regional:");
            Console.WriteLine(CultureInfo.CurrentCulture.NativeName);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(ConfigurationManager.AppSettings["CultureInfo"], true);
            Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencySymbol = ConfigurationManager.AppSettings["CurrencySymbol"];
            Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortTimePattern = ConfigurationManager.AppSettings["ShortTimePattern"];
            Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = ConfigurationManager.AppSettings["ShortDatePattern"];
            Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ConfigurationManager.AppSettings["NumberDecimalSeparator"];
            Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ConfigurationManager.AppSettings["CurrencyDecimalSeparator"];
            Console.WriteLine(CultureInfo.CurrentCulture.NativeName);
        }

        private void frmReloj_Load(object sender, EventArgs e)
        {
            WisObj.Open();
            WisObj.DataEvent += new _IWisSensorNEvents_DataEventEventHandler(WisObj_DataEvent);
            WisObj.SetDisplay((int)this.pictureBoxUltimaFichadaFoto.Handle);
            this.FormClosing += new FormClosingEventHandler(frmReloj_FormClosing);
       //     this.TopMost = false;
      //     MessageBox.Show("topmost");
            //cargo vector de huellas
            huellas = huellasNegocio.getLista();
            timerHuella.Start();
        }

        void frmReloj_FormClosing(object sender, FormClosingEventArgs e)
        {
            WisObj.StopCapture();
            timerHuella.Stop();
            WisObj.Close();
        }

        void WisObj_DataEvent(DATA status, string Template)
        {
            switch (status)
            {
                case DATA.DATA_ENROLL:
                    break;

                case DATA.DATA_IDENTIFY_CAPTURE:
                    int i = 0;
                    this.arrayHuellas = new string[huellas.Count];
                    foreach (HuellaEntity h in huellas)
                    {
                        this.arrayHuellas[i] = h.Huella;
                        i++;
                    }

                    int nMatched;
                    nMatched = WisObj.Identify(Template, this.arrayHuellas);
                    if (nMatched < 0)
                    {
                        //MessageBox.Show("No se encontró huella válida!!");
                        labelUltimaFichadaApellidoNombre.Text = "!!!! ERROR !!!!";
                    }
                    else
                    {
                        //MessageBox.Show("Huella Identificada ! legajo=" + huellas[nMatched].Legajo);
                        //huella = new HuellaEntity(huellas[nMatched].Legajo);                        
                        this.fichada = new FichadaEntity(0, huellas[nMatched].Legajo);
                        this.procesaFichada(fichada);
                    }
                    this.capturando = false;
                    break;

                case DATA.DATA_VERIFY_CAPTURE:
                    break;
            }
        }

        private void timerHuella_Tick(object sender, EventArgs e)
        {
            if (!capturando)
            {
                Console.WriteLine("solicitando huella");
                this.solicitarHuella();
            }
        }

        private void solicitarHuella()
        {
            this.capturando = true;
           // this.lblMensajes.Text = "Por favor, coloque el dedo sobre el lector...";
            WisObj.IdentifyCapture();
            //huella = new HuellaEntity(int.Parse(this.cmbEmpleados.SelectedValue.ToString()));
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            DataSet fichadas = null;
            //Cargo lista de fichadas            
            fichadas = fichadasNegocio.getAll(System.DateTime.Now.Date, System.DateTime.Now.Date);
            Model.DataSetTo.XLS(fichadas, "Fichadas");
            fichadas.Dispose();
        }
    }
}