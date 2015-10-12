/*  
    frmFingerPrintUtils.cs

    Author:
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

/*
 * hvivani. 20110518
 * Formulario para enrolamiento e identificación de usuarios. Programado para el lector Wison OR200N v2.5
 * es necesario realizar el registro manual de la librería: regsvr32 WisSensorNLib.dll 
 * antes de utilizar el dispositivo.
 * Debe ademas, agregarse como referencia (objeto COM) en el presente proyecto.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WisSensorNLibLib;

using Sueldos.Entidades;
using Sueldos.Modelo;
using Sofft.ViewComunes;
using Reloj.Entidades;
using Reloj.Negocio;

namespace Reloj.View
{
    public partial class frmFingerPrintUtils : Form
    {
        WisSensorN WisObj = new WisSensorN();
        private ConsultaEmpleados consuemple = new ConsultaEmpleados();
        private ConsultaTablas consutab = new ConsultaTablas();
        private HuellasNegocio huellasNegocio = new HuellasNegocio();

        private HuellaEntity huella;
        private Boolean capturando = false;
        private int idDedo;

        string[] huellaIdentificada=new string[1000];

        public frmFingerPrintUtils()
        {
            InitializeComponent();
            this.cargarCombos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnrolar_Click(object sender, EventArgs e)
        {
            if (this.cmbEmpleados.SelectedValue == null)
            {
                MessageBox.Show("por favor, seleccione un empleado");
            }
            else
                if ( this.idDedo<=0)//this.cmbHuella.SelectedValue == null)
                {
                    MessageBox.Show("por favor, seleccione una huella");
                }else
                {
                    huella= this.huellasNegocio.getById(int.Parse(this.cmbEmpleados.SelectedValue.ToString()), this.idDedo);
                    if (huella != null)
                    {
                        DialogResult result = MessageBox.Show("Esa Huella ya se encuentra registrada. Desea Regrabarla ?", "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            this.huellasNegocio.Eliminar(huella);
                            this.lblMensajes.Text = "Por favor, coloque la huella " + this.cmbHuella.Text + " sobre el lector...";
                            WisObj.StartEnroll();
                        }
                    }
                    else
                    {
                        this.lblMensajes.Text = "Por favor, coloque la huella " + this.cmbHuella.Text + " sobre el lector...";
                        WisObj.StartEnroll();
                    }
                }
            if (this.cmbEmpleados.SelectedValue != null)
            {
                huella = new HuellaEntity(int.Parse(this.cmbEmpleados.SelectedValue.ToString()));
            }
            else
                huella = null;

        }

        private void btnIdentificar_Click(object sender, EventArgs e)
        {
            //if (this.cmbEmpleados.SelectedValue == null)
            //{
            //    MessageBox.Show("por favor, seleccione un empleado");
           // }
           // else
               // if (this.cmbHuella.SelectedValue == null)
               // {
               //     MessageBox.Show("por favor, seleccione una huella");
               // }
               // else
               // {
                    this.solicitarHuella();
               // }
        }

        private void frmFingerPrintUtils_Load(object sender, EventArgs e)
        {
            this.lblMensajes.Text = "Por favor, verifique que el lector de huellas se encuentre conectado ...";
            WisObj.Open();
            WisObj.DataEvent += new _IWisSensorNEvents_DataEventEventHandler(WisObj_DataEvent);
            WisObj.SetDisplay((int)pbHuella.Handle);
            this.FormClosing += new FormClosingEventHandler(frmFingerPrintUtils_FormClosing);
            this.idDedo=0;
            this.cmbHuella.SelectedValue = double.Parse(this.idDedo.ToString());
           // timer1.Start();
        }

        void frmFingerPrintUtils_FormClosing(object sender, FormClosingEventArgs e)
        {
           // timer1.Stop();
            WisObj.Close();

        }

        void WisObj_DataEvent(DATA status, string Template)
        {
            switch (status)
            {
                case DATA.DATA_ENROLL:
                    /*indx = nEnrolled.ToString();
                    msg = "User #" + indx + " is enrolled successfully!!";
                    this.Invoke(new CompleteHandler(Complete), new object[] { msg });
                    DB[nEnrolled] = string.Copy(str);
                    nEnrolled++;*/
                    huella.Huella = string.Copy(Template);
                    //this.huellaIdentificada[0] = string.Copy(Template);
                    this.lblMensajes.Text = "Huella Enrolada !!!!";
           //         MessageBox.Show("Huella Identificada: " + this.huellaIdentificada[0].ToString());
           //         MessageBox.Show("longitud: " + this.huellaIdentificada[0].Length.ToString());
                    
           //         huella.DedoHuella = new TablaEntity("reloj", 4, double.Parse(this.cmbHuella.SelectedValue.ToString()));
                    huella.DedoHuella = new TablaEntity("reloj", 4, this.idDedo);
                    //huella.Huella = this.huellaIdentificada[0].ToString();
                    huellasNegocio.Guardar(huella);
                    break;

                case DATA.DATA_IDENTIFY_CAPTURE:
                 //   string[] hu = new string[10];
                    int i = 0;
                    List<HuellaEntity> huellas = huellasNegocio.getLista();
                    foreach (HuellaEntity h in huellas)
                    {
                        huellaIdentificada[i] = h.Huella;
                        i++;
                    }

                    int nMatched;
                    nMatched = WisObj.Identify(Template, huellaIdentificada);
                    if (nMatched < 0)
                    {
                        this.lblMensajes.Text = "No se encontró huella válida!!";
                        //MessageBox.Show("No se encontró huella válida!!");
                        this.cmbEmpleados.SelectedValue = -1;
                        //this.Invoke(new CompleteHandler(Complete), new object[] { msg });
                    }
                    else
                    {
                        //indx = nMatched.ToString();
                        //msg = "User #" + indx + " is matched!!";
                        //this.lblMensajes.Text = "Huella Identificada ! id=" + nMatched;
                        //MessageBox.Show( "Huella Identificada ! legajo=" + huellas[nMatched].Legajo);
                        this.lblMensajes.Text = "Huella Identificada ! legajo=" + huellas[nMatched].Legajo.ToString();
                        this.cmbEmpleados.SelectedValue = huellas[nMatched].Legajo;
                        //this.Invoke(new CompleteHandler(Complete), new object[] { msg });
                    }
                    this.capturando = false;
                    break;

                case DATA.DATA_VERIFY_CAPTURE:
                    break;
            }

        }

        private void cargarCombos()
        {
            Controles.cargaComboBox(this.cmbEmpleados, "Nombres", "Legajo", consuemple.GetAlldatosBasicos());
            Controles.cargaComboBox(this.cmbHuella, "detalle", "contenido", consutab.getContenidoYdetalle("reloj",4));

        }

        private void solicitarHuella()
        {
            this.capturando = true;
            this.lblMensajes.Text = "Por favor, coloque el dedo sobre el lector...";
            WisObj.IdentifyCapture();
            if (this.cmbEmpleados.SelectedValue != null)
                huella = new HuellaEntity(int.Parse(this.cmbEmpleados.SelectedValue.ToString()));
            else
                huella = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!capturando)
            {
                Console.WriteLine("solicitando huella");
                this.solicitarHuella();
            }
        }

        private void rbMeniqueIzq_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbMeniqueIzq.Checked)
            {
                this.idDedo = 1;
                this.cmbHuella.SelectedValue = double.Parse(this.idDedo.ToString());
            }
        }

        private void rbAnularIzq_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbAnularIzq.Checked)
            {
                this.idDedo = 2;
                this.cmbHuella.SelectedValue = double.Parse(this.idDedo.ToString());
            }
        }

        private void rbMayorIzq_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbMayorIzq.Checked)
            {
                this.idDedo = 3;
                this.cmbHuella.SelectedValue = double.Parse(this.idDedo.ToString());
            }
        }

        private void rbIndiceIzq_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbIndiceIzq.Checked)
            {
                this.idDedo = 4;
                this.cmbHuella.SelectedValue = double.Parse(this.idDedo.ToString());
            }
        }

        private void rbPulgarIzq_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbPulgarIzq.Checked)
            {
                this.idDedo = 5;
                this.cmbHuella.SelectedValue = double.Parse(this.idDedo.ToString());
            }
        }

        private void rbMeniqueDer_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbMeniqueDer.Checked)
            {
                this.idDedo = 10;
                this.cmbHuella.SelectedValue = double.Parse(this.idDedo.ToString());
            }

        }

        private void rbAnularDer_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbAnularDer.Checked)
            {
                this.idDedo = 9;
                this.cmbHuella.SelectedValue = double.Parse(this.idDedo.ToString());
            }
        }

        private void rbMayorDer_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbMayorDer.Checked)
            {
                this.idDedo = 8;
                this.cmbHuella.SelectedValue = double.Parse(this.idDedo.ToString());
            }
        }

        private void rbIndiceDer_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbIndiceDer.Checked)
            {
                this.idDedo = 7;
                this.cmbHuella.SelectedValue = double.Parse(this.idDedo.ToString());
            }
        }

        private void rbPulgarDer_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbPulgarDer.Checked)
            {
                this.idDedo = 6;
                this.cmbHuella.SelectedValue = double.Parse(this.idDedo.ToString());
            }
        }

        private void btnEliminarTodas_Click(object sender, EventArgs e)
        {
            if (this.cmbEmpleados.SelectedValue == null)
            {
                MessageBox.Show("por favor, seleccione un empleado");
            }
            else
            {
                DialogResult result = MessageBox.Show("Está seguro de eliminar todas las huellas del legajo " + this.cmbEmpleados.SelectedValue.ToString() + " ?", "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.huellasNegocio.Eliminar(int.Parse(this.cmbEmpleados.SelectedValue.ToString()));
                    MessageBox.Show("Se eliminaron todas las huellas del legajo " + this.cmbEmpleados.SelectedValue.ToString() + ".");                   
                }
            }

        }


    }
}
