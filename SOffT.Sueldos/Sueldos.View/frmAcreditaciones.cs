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
using Sueldos.Modelo;

namespace Sueldos.View
{
    public partial class frmAcreditaciones : Form
    {
        public frmAcreditaciones()
        {
            InitializeComponent();
            liqCtrlAcreditaciones.LiquidacionId_Changed += new EventHandler(liqCtrlAcreditaciones_LiquidacionId_Changed);
        }

        void liqCtrlAcreditaciones_LiquidacionId_Changed(object sender, EventArgs e)
        {
            this.cargarCombos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        { this.Close(); }

        private void btnGenerarArchivo_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            string fechadepago = "";
            string nroEmpresa = "";
            foreach (DataRowView objDataRowView in this.lstFechasDePago.SelectedItems)
                fechadepago = objDataRowView["fechadepago"].ToString();

            if (this.liqCtrlAcreditaciones.TiposSeleccionados.Count > 0)
            {
                int idConvenio = Convert.ToInt32(this.cmbConvenio.SelectedValue);
                //instancio reporte//
                if (chkConvenido.Checked)
                { ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "liquidacionesNetosPorLegajoPorBanco", "@idLiquidacion", this.liqCtrlAcreditaciones.LiquidacionId, "@idFormaDePago", 2, "@idBanco", int.Parse(cmbBancos.SelectedValue.ToString())); }
                else
                { ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "liquidacionesNetosPorLegajoPorBancoPorConvenio", "@idLiquidacion", this.liqCtrlAcreditaciones.LiquidacionId, "@idFormaDePago", 2, "@idBanco", int.Parse(cmbBancos.SelectedValue.ToString()), "@idConvenio", idConvenio); }

                ds.Tables[0].TableName = "liquidacionesNetosPorLegajo"; //esto es porque cambiamos el nombre de la consulta y el crystal toma el nombre viejo para este reporte

                //       		Sueldos.View.Reportes.CRReporteBapro reporteAcreditacionBancariaBapro = new Sueldos.View.Reportes.CRReporteBapro ();
                //    reporteAcreditacionBancariaBapro.SetDataSource(Model.DB.ejecutarDataSet(Model.TipoComando.SP, "liquidacionesNetosPorLegajo", "@idLiquidacion", this.liqCtrlAcreditaciones.LiquidacionId, "@idFormaDePago", 2));
                //       		reporteAcreditacionBancariaBapro.SetDataSource (ds);
                //*****************//
                this.saveFileDialogBancos.Filter = "Texto TXT (*.txt)|*.txt";
                switch (int.Parse(cmbBancos.SelectedValue.ToString()))
                {
                    case 1:
                        nroEmpresa = Bapro.cabecera.rotuloArchivo;
                        //this.saveFileDialogBancos.FileName = Bapro.cabecera.rotuloArchivo;
                        break;
                    case 2:
                        nroEmpresa = BancoGalicia.nombreArchivo;
                        //this.saveFileDialogBancos.FileName =  BancoGalicia.nombreArchivo;
                        break;
                    case 3:
                        nroEmpresa = BancoCredicoop.nombreArchivo;
                        //this.saveFileDialogBancos.FileName = BancoCredicoop.nombreArchivo;
                        break;
                }
                this.saveFileDialogBancos.FileName = nroEmpresa;
                if (saveFileDialogBancos.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    //hay que grabar los tipos seleccionados en  el temporal para que sean tomados por las consultas
                    this.liqCtrlAcreditaciones.GrabarTipoSeleccionados();
                    //en el indice 0 de los tipos seleccionados está la liq. normal.      
                    switch (int.Parse(cmbBancos.SelectedValue.ToString()))
                    {
                        case 1:
                            Bapro.generaArchivo(this.liqCtrlAcreditaciones.LiquidacionId, this.saveFileDialogBancos.FileName, (List<int>)this.liqCtrlAcreditaciones.TiposSeleccionados, Convert.ToDateTime(fechadepago), chkConvenido.Checked, idConvenio);
                            break;
                        case 2:
                            BancoGalicia.generaArchivo(this.liqCtrlAcreditaciones.LiquidacionId, this.saveFileDialogBancos.FileName, (List<int>)this.liqCtrlAcreditaciones.TiposSeleccionados, Convert.ToDateTime(fechadepago), chkConvenido.Checked, idConvenio);
                            break;
                        case 3:
                            BancoCredicoop.generaArchivo(this.liqCtrlAcreditaciones.LiquidacionId, this.saveFileDialogBancos.FileName, (List<int>)this.liqCtrlAcreditaciones.TiposSeleccionados, Convert.ToDateTime(fechadepago), chkConvenido.Checked, idConvenio);
                            break;
                        default:
                            MessageBox.Show("Banco no definido para exportar.");
                            break;
                    }
                    Cursor.Current = Cursors.Default;
                    //    MessageBox.Show("El archivo se generó con éxito.");
                }
                //genero el reporte. 
                //OJO que no debe generarse sin setear la consulta antes del proceso del archivo, ya que 
                //marcaria las liquidaciones como acreditadas antes de imprimir.
                //        		reporteAcreditacionBancariaBapro.SetParameterValue (reporteAcreditacionBancariaBapro.Parameter_FechaAcreditacion.ParameterFieldName, Convert.ToDateTime (this.lstFechasDePago.Text));
                //       		reporteAcreditacionBancariaBapro.SetParameterValue (reporteAcreditacionBancariaBapro.Parameter_LiquidacionDescripcion.ParameterFieldName, this.liqCtrlAcreditaciones.LiquidacionDescripcion);
                //        		frmReportes visor = new frmReportes (reporteAcreditacionBancariaBapro);
                EmpresaEntity emp = new ConsultaEmpresas().getById(1);
                Sueldos.Reportes.CrystalReport.ReportesCreador.AcreditacionDeAnticipos(ds, this.lstFechasDePago.Text, this.liqCtrlAcreditaciones.LiquidacionDescripcion, emp.RazonSocial, nroEmpresa);
                //visor.ShowDialog(this);
            }
            else
                MessageBox.Show("Debe seleccionar al menos una liquidación.");
            this.btnGenerarArchivo.Enabled = false;
        }

        private void frmAcreditaciones_Load(object sender, EventArgs e)
        {
            this.liqCtrlAcreditaciones.LiquidacionesCargar();
            this.cargarCombos();
        }


        private void cargarCombos()
        {
            Controles.cargaListBox(this.lstFechasDePago, "fechaDePago", "idLiquidacion", "fechasDePagoConsultar", "@idLiquidacion", this.liqCtrlAcreditaciones.LiquidacionId);
            Controles.cargaComboBox(this.cmbBancos, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 24);
            Controles.cargaComboBox(this.cmbConvenio, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 13);
        }

        private void chkConvenido_CheckedChanged(object sender, EventArgs e)
        {
            cmbConvenio.Enabled = !chkConvenido.Checked;
        }
    }
}