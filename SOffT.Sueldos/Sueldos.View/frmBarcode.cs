using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sofft.Utils;
using Sueldos.Entidades;
using Sueldos.Modelo;

namespace Sueldos.View
{
    public partial class frmBarcode : Form
    {
        /************************************/
        /*variables para captura de pantalla*/
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        /************************************/

        DSBarCode.BarCodeCtrl[] barCode39 = null;
        TextBox[] txtLegajo = null;

        public frmBarcode()
        {
            InitializeComponent();
            this.cargaControles();
            this.ShowDialog();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLegajo_TextChanged(object sender, EventArgs e)
        {
            TextBox tb;
            tb = (TextBox)sender;

            if (tb.Text.Length > 0 && Varios.IsNumeric(tb.Text))
            {
                this.barCode39[Convert.ToInt32(tb.Tag)].BarCode = this.txtEmpresa.Text + tb.Text.PadLeft(5,'0');
                this.barCode39[Convert.ToInt32(tb.Tag)].HeaderText = Varios.Left(tb.Text.PadLeft(5,'0') + "_" +  ConsultaEmpleados.consultarApellidoYnombres(Convert.ToInt32(this.txtLegajo[Convert.ToInt32(tb.Tag)].Text)),28);
            }
            
        }

        private void frmBarcode_Load(object sender, EventArgs e)
        {
        }

        private void printDbarcode_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.CaptureScreen();
            this.printDbarcode.Print();
        }

        /// <summary>
        /// Rutina de captura de pantalla para imprimir el frm actual
        /// </summary>
        private void CaptureScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            /*captura titulo y bordes*/
            int widthDiff = this.Width - this.ClientRectangle.Width;
            int heightDiff = this.Height - this.ClientRectangle.Height;
            int borderSize = widthDiff / 2;
            int heightTitleBar = heightDiff - borderSize;
            /**/
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width + widthDiff, this.ClientRectangle.Height + heightDiff, dc1, 0 - borderSize, 0 - heightTitleBar, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void cargaControles()
        {
            Font fuente = new Font("Microsoft Sans Serif", 8, FontStyle.Regular );
            byte TabIndTxt = 0;
            byte TabIndBar = 100;

            flpBarCode.Controls.Clear();
            barCode39 = new DSBarCode.BarCodeCtrl[9];
            txtLegajo = new TextBox[9];
            for (int i = 0; i < 9; i++)
            {
                barCode39[i] = new DSBarCode.BarCodeCtrl();
                barCode39[i].Width  = 200;//190
                barCode39[i].Height = 113;//103
                barCode39[i].BarCodeHeight = 70;
                barCode39[i].HeaderText = "";
                barCode39[i].HeaderFont = fuente;
                barCode39[i].ShowHeader = true;
                barCode39[i].BorderStyle = BorderStyle.FixedSingle;
                barCode39[i].Tag = i;
                barCode39[i].BarCode = "0";
                barCode39[i].TabIndex = TabIndBar;
                barCode39[i].Weight = DSBarCode.BarCodeCtrl.BarCodeWeight.Small;
                TabIndBar++;

                txtLegajo[i] = new TextBox();
                txtLegajo[i].Width = 45;
                txtLegajo[i].Height = 20;
                txtLegajo[i].MaxLength = 5;
                txtLegajo[i].TabIndex=TabIndTxt;
                TabIndTxt++;
                this.txtLegajo[i].Tag = i;
                this.txtLegajo[i].TextChanged += new EventHandler(txtLegajo_TextChanged);

                flpBarCode.Controls.Add(barCode39[i]);
                flpBarCode.Controls.Add(txtLegajo[i]);
            }
        }



    }
}