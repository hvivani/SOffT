using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sofft.ViewComunes;
using Sueldos.Entidades;
using Sueldos.Modelo;

namespace Sueldos.View
{
    public partial class frmAcreditacionesAnticipos : Form
    {
        public frmAcreditacionesAnticipos()
        {
            InitializeComponent();
            this.cargarCombos();
            this.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarCombos()
        {
            Controles.cargaComboBox(this.cmbTipoAnticipo, "descripcion", "indice", "tablasConsultarIndiceDescripcion", "@tabla", "tiposDeAnticipo");
            Controles.cargaComboBox(this.cmbAnios, "contenido", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "calendario", "indice", 1);
            this.cmbAnios.SelectedValue = DateTime.Now.Year;
            Controles.cargaComboBox(this.cmbMeses, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "@tabla", "calendario", "indice", 2);
            this.cmbMeses.SelectedValue = DateTime.Now.Month;
            dtpFechaAcreditacion.Value = DateTime.Now;
            Controles.cargaComboBox(this.cmbBancos, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 24);
            Controles.cargaComboBox(this.cmbConvenio, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 13);
        }

        private void btnGenerarArchivo_Click(object sender, EventArgs e)
        {
            String nroEmpresa = "";
            if (Convert.ToInt32(this.cmbTipoAnticipo.SelectedValue) > 0)
            {
                int idConvenio = Convert.ToInt32(this.cmbConvenio.SelectedValue);
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
                        //this.saveFileDialogBancos.FileName = BancoGalicia.nombreArchivo;
                        break;
                }
                this.saveFileDialogBancos.FileName = nroEmpresa;
                if (saveFileDialogBancos.ShowDialog() == DialogResult.OK)
                {
                    int anioMes = Convert.ToInt32(this.cmbAnios.SelectedValue.ToString() + this.cmbMeses.SelectedValue.ToString().PadLeft(2, '0'));

                    Cursor.Current = Cursors.WaitCursor;
                    switch (int.Parse(cmbBancos.SelectedValue.ToString()))
                    {
                        case 1:
                            Bapro.generaArchivoDesdeAnticipos(anioMes, Convert.ToInt32(this.cmbTipoAnticipo.SelectedValue), this.saveFileDialogBancos.FileName, chkConvenido.Checked, idConvenio);
                            break;
                        case 2:
                            BancoGalicia.generaArchivoDesdeAnticipos(anioMes, Convert.ToInt32(this.cmbTipoAnticipo.SelectedValue), this.saveFileDialogBancos.FileName,this.dtpFechaAcreditacion.Value, chkConvenido.Checked, idConvenio);
                            break;
                        default:
                            MessageBox.Show("Banco no definido para exportar.");
                            break;
                    }
                    Cursor.Current = Cursors.Default;

                    //instancio reporte//
               /*     Sueldos.View.Reportes.CRReporteBapro reporteAcreditacionBancariaBapro = new Sueldos.View.Reportes.CRReporteBapro();
                    DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "anticiposConsultarParaAcreditar", "@anioMes", anioMes, "@idTipoAnticipo", Convert.ToInt32(this.cmbTipoAnticipo.SelectedValue));
                    ds.Tables[0].TableName = "liquidacionesNetosPorLegajo";
                    reporteAcreditacionBancariaBapro.SetDataSource(ds);
                    reporteAcreditacionBancariaBapro.SetParameterValue(reporteAcreditacionBancariaBapro.Parameter_FechaAcreditacion.ParameterFieldName, dtpFechaAcreditacion.Value.ToShortDateString());
                    reporteAcreditacionBancariaBapro.SetParameterValue(reporteAcreditacionBancariaBapro.Parameter_LiquidacionDescripcion.ParameterFieldName, "Anticipo " + cmbTipoAnticipo.Text + " " + cmbMeses.Text + " " + cmbAnios.Text);
                    frmReportes visor = new frmReportes(reporteAcreditacionBancariaBapro);
                    visor.ShowDialog(this);*/


                    this.Cursor = Cursors.WaitCursor;
                    DataSet ds;
                    if (chkConvenido.Checked)
                    { ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "anticiposConsultarParaAcreditarPorBanco", "@anioMes", anioMes, "@idTipoAnticipo", Convert.ToInt32(this.cmbTipoAnticipo.SelectedValue), "@idBanco", int.Parse(cmbBancos.SelectedValue.ToString())); }
                    else
                    { ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "anticiposConsultarParaAcreditarPorBancoPorConvenio", "@anioMes", anioMes, "@idTipoAnticipo", Convert.ToInt32(this.cmbTipoAnticipo.SelectedValue), "@idBanco", int.Parse(cmbBancos.SelectedValue.ToString()), "@idConvenio", idConvenio); }
                    ///Cambiamos el nombre de tabla para que el crystal report no de problemas en tiempo de ejecución, dado
                    ///que el reporte se usa tambien para acreditaciones de sueldos.
                    ds.Tables[0].TableName = "liquidacionesNetosPorLegajo";
                    this.Cursor = Cursors.Default;
                    EmpresaEntity emp = new ConsultaEmpresas().getById(1);
                    Sueldos.Reportes.CrystalReport.ReportesCreador.AcreditacionDeAnticipos(ds, dtpFechaAcreditacion.Value.ToShortDateString(), "Anticipo " + cmbTipoAnticipo.Text + " " + cmbMeses.Text + " " + cmbAnios.Text, emp.RazonSocial, nroEmpresa);
                }
            }
            else
                MessageBox.Show("Debe seleccionar al menos un tipo de anticipos");
            this.btnGenerarArchivo.Enabled = false;

        }

        private void chkConvenido_CheckedChanged(object sender, EventArgs e)
        {
            cmbConvenio.Enabled = !chkConvenido.Checked;
        }

    }
}