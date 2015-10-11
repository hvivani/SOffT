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
    public partial class frmDatosEmpleado : Form
    {

        private ConsultaEmpleados consEmple = new ConsultaEmpleados();

        private EmpleadoEntity empleado = null;        

        public frmDatosEmpleado()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (this.btnGrabar.Enabled)
            {
                DialogResult result = MessageBox.Show("Salir sin grabar los cambios ? " , "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    this.Close();
            }else
                this.Close();
        }

        private void FrmDatosEmpleado_Load(object sender, EventArgs e)
        {

        }

        public void abrirParaNuevo()
        {
            this.cargarCombos();
            empleado = new EmpleadoEntity();
            empleado.IdPersona = 0;
            this.mostrarDatosEnForm();
            this.txtLegajo.Enabled = true;
            this.btnGrabar.Enabled = false;
            this.ShowDialog();
        }

        public void abrirParaConsultar(int idEmpleado)
        {
            this.cargarCombos();
            empleado = consEmple.getEmpleado(idEmpleado);
            this.cargarGrillas();
            this.mostrarDatosEnForm();
            this.btnGrabar.Enabled = false;
            this.gbBanco.Enabled = false;
            this.gbCategoria.Enabled = false;
            this.gbFechas.Enabled = false;
            this.gbIdentificacion.Enabled = false;
            this.gbOtrosCampos.Enabled = false;
            this.gbPersona.Enabled = false;
            this.gbSalario.Enabled = false;

            this.ShowDialog();
        }

        public void abrirParaModificar(int idEmpleado)
        {
            this.cargarCombos();
            empleado = consEmple.getEmpleado(idEmpleado);
            this.cargarGrillas();
            this.mostrarDatosEnForm();
            this.txtLegajo.Enabled = false;
            this.btnGrabar.Enabled = false;
            this.ShowDialog();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            EmpresaEntity emp = new ConsultaEmpresas().getById(1);
            DataSet ds = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "reporteEmpleado", "@legajo", empleado.Legajo);
            this.Cursor = Cursors.Default;
            Sueldos.Reportes.CrystalReport.ReportesCreador.DatosEmpleado(ds, emp.RazonSocial, Application.ProductVersion);
        
            /*  frmReportes frmrepo = new frmReportes();
            crEmpleado cre = new crEmpleado();
            Empleados emps = new Empleados();
            emps.Add(this.empleado);
            cre.SetDataSource(emps);

            frmrepo.abrir(cre);*/
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (this.datosValidos())
            {
                consEmple.grabar(empleado);
                this.btnGrabar.Enabled = false;
            }
        }

        private void mostrarDatosEnForm()
        {
            this.txtLegajo.Text = empleado.Legajo.ToString();
            this.txtApellidoyNombres.Text = empleado.Nombre ;
            this.txtDomicilio.Text = empleado.Domicilio;
            this.txtTelefono.Text = empleado.Telefono ;
            this.txtTelefonoMensajes.Text = empleado.TelefonoMensajes;
            this.txtCP.Text = empleado.CP ;
            this.txtCUIL.Text = empleado.CUIL;
            this.cmbAFJP.SelectedValue = empleado.IdAFJP;
            Controles.seteaDTPicker(dtpFechaIngreso,empleado.FechaIngreso);
            Controles.seteaDTPicker(this.dtpFechaEgreso, empleado.FechaEgreso);
            Controles.seteaDTPicker(this.dtpFechaReIngreso, empleado.FechaReIngreso);
            Controles.seteaDTPicker(this.dtpFechaReconocimiento, empleado.FechaReconocimiento);
            this.txtSueldoOjornal.Text = empleado.SueldoOjornal.ToString();
            this.cmbEstado.SelectedValue  = empleado.IdEstado;
            this.actualizaEstadoEmpleado();
            this.cmbTipoLiquidacion.SelectedValue = empleado.IdTipoLiquidacion;
            this.cmbCausaEgreso.SelectedValue = empleado.IdCausaEgreso;
            this.cmbContrato.SelectedValue = empleado.IdContrato ;
            this.cmbPais.SelectedValue = empleado.IdPais;
            Controles.cargaComboBox(this.cmbProvincia, "nombreProvincia", "idProvincia", "ProvinciasConsultar", "@idPais", this.cmbPais.SelectedValue);
            this.cmbProvincia.SelectedValue = empleado.IdProvincia;
            Controles.cargaComboBox(this.cmbLocalidad, "nombreLocalidad", "idLocalidad", "LocalidadesConsultar", "@idPais", this.cmbPais.SelectedValue, "@idProvincia", this.cmbProvincia.SelectedValue);
            this.cmbLocalidad.SelectedValue = empleado.IdLocalidad;
            this.cmbTipoDoc.SelectedValue = empleado.IdTipoDocumento;
            this.txtNumeroDoc.Text = empleado.NumeroDocumento;
            this.cmbEstadoCivil.SelectedValue = empleado.IdEstadoCivil;
            Controles.seteaDTPicker(this.dtpFechaNacimiento, empleado.FechaNacimiento);
            this.cmbCentroDeCosto.SelectedValue = empleado.IdCentroDeCosto;
            this.cmbCategoria.SelectedValue = empleado.IdCategoria ;
            this.cmbPuesto.SelectedValue = empleado.IdPuesto;
            this.cmbArea.SelectedValue = empleado.IdArea;
            try
            {
                this.pbFoto.Image = new Bitmap(empleado.Foto);
            }
            catch (Exception)
            {
                this.pbFoto.Image = null;
            }
            this.cmbSucursalesBanco.SelectedValue = empleado.IdSucursalBanco;
            this.cmbBancos.SelectedValue = empleado.IdBanco;
            this.txtNumeroCuenta.Text = empleado.NumeroCuenta;
            this.cmbFormaDePago.SelectedValue = empleado.IdFormaDePago;
            this.cmbConvenio.SelectedValue = empleado.IdConvenio ;
            this.cmbSindicato.SelectedValue = empleado.IdSindicato;
            this.cmbObraSocial.SelectedValue = empleado.IdObraSocial;
            this.cmbSexo.SelectedValue = empleado.IdSexo;
            this.cmbNacionalidad.SelectedValue = empleado.IdNacionalidad;
            this.txtLegajoConyuge.Text = empleado.LegajoDelConyuge.ToString();
            this.cmbSituacionDeRevista.SelectedValue = empleado.IdSituacionDeRevista;
            this.cmbCodigoDeCondicion.SelectedValue = empleado.IdCodigoDeCondicion;
            this.cmbCodigoDeActividad.SelectedValue = empleado.IdCodigoDeActividad;
            this.cmbModalidadDeContratacion.SelectedValue = empleado.IdModalidadDeContratacion;
            this.cmbCodigoDeSiniestrado.SelectedValue = empleado.IdCodigoDeSiniestrado;
            if (this.empleado.OtrosCampos != null && this.empleado.OtrosCampos.Count > 0)
                this.cargarDGVcampos(this.dgvCampos);
                //this.empleado.OtrosCampos.cargarDataGridView(this.dgvCampos);
            if (this.empleado.Familiares != null && this.empleado.Familiares.Count > 0)
                this.cargarDGVfamiliares(this.dgvFamiliares);
                //this.empleado.Familiares.cargarDataGridView(this.dgvFamiliares);
            if (this.empleado.Periodos != null && this.empleado.Periodos.Count > 0)
                this.cargarDGVperiodos(this.dgvPeriodos);
                //this.empleado.Periodos.cargarDataGridView(this.dgvPeriodos);
            if (this.empleado.Horarios != null && this.empleado.Horarios.Count > 0)
                this.cargarDGVhorarios(this.dgvHorarios);
                //this.empleado.Horarios.cargarDataGridView(this.dgvHorarios);
            if (this.empleado.Vacaciones != null && this.empleado.Vacaciones.Count > 0)
                this.cargarDGVvacaciones(this.dgvVacaciones);
                //this.empleado.Vacaciones.cargarDataGridView(this.dgvVacaciones);
            //seteo texto de ventana
            this.Text = "Datos del Empleado: " + empleado.Legajo + " " + empleado.Nombre;
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdEstado = Convert.ToInt32(this.cmbEstado.SelectedValue);
                this.btnGrabar.Enabled = true;
                    
            }
        }

        private void cargarDGVvacaciones (DataGridView dgv)
        {
        	dgv.DataSource = null;
        	dgv.AutoGenerateColumns = true;
        	dgv.DataSource = empleado.Vacaciones;

            //Fecha as 'Fecha Otorgada', anioVacaciones AS 'Año Vacaciones', totalDias AS 'Total Dias', diasTomados AS 'Dias Tomados'
        	dgv.Columns["Fecha"].DisplayIndex = 0;
        	dgv.Columns["Fecha"].HeaderText = "Fecha Otorgada";
        	dgv.Columns["AnioVacaciones"].DisplayIndex = 1;
        	dgv.Columns["AnioVacaciones"].HeaderText = "Vacaciones";
        	dgv.Columns["TotalDias"].DisplayIndex = 2;
        	dgv.Columns["TotalDias"].HeaderText = "Total Dias";
        	dgv.Columns["DiasTomados"].DisplayIndex = 3;
        	dgv.Columns["DiasTomados"].HeaderText = "Dias Tomados";
        	dgv.Columns["Codigo"].Visible = false;
        	dgv.Columns["Legajo"].Visible = false;
        	Controles.setEstandarDataGridView (dgv);
        	for (int i = 0; i < dgv.Columns.Count - 1; i++) {
        		dgv.Columns[i].Visible = !(dgv.Columns[i].Name.StartsWith ("id") || dgv.Columns[i].Name.StartsWith ("Id"));
        	}

		}

        private void cargarDGVhorarios (DataGridView dgv)
        {
        	dgv.DataSource = null;
        	dgv.DataSource = empleado.Horarios;
        	dgv.Columns["Id"].DisplayIndex = 0;
        	dgv.Columns["Legajo"].Visible = false;
        	dgv.Columns["IdDia"].Visible = false;
        	dgv.Columns["Dia"].DisplayIndex = 1;
        	dgv.Columns["LimiteDia"].DisplayIndex = 2;
        	dgv.Columns["IdTipoMovimiento"].Visible = false;
        	dgv.Columns["TipoMovimiento"].DisplayIndex = 3;
        	dgv.Columns["Hora"].DisplayIndex = 4;
        	dgv.Columns["Tolerancia"].DisplayIndex = 5;
        	Controles.setEstandarDataGridView (dgv);
			for (int i = 0; i < dgv.Columns.Count - 1; i++) {
				dgv.Columns[i].Visible = !(dgv.Columns[i].Name.StartsWith ("id") || dgv.Columns[i].Name.StartsWith ("Id"));
			}
        }

        private void cargarDGVperiodos (DataGridView dgv)
        {
        	dgv.DataSource = null;
        	dgv.DataSource = empleado.Periodos;
        	dgv.Columns["Id"].DisplayIndex = 0;
        	dgv.Columns["Legajo"].DisplayIndex = 1;
        	dgv.Columns["FechaInicio"].DisplayIndex = 2;
        	dgv.Columns["FechaFin"].DisplayIndex = 3;
        	dgv.Columns["IdCausaEgreso"].Visible = false;
        	dgv.Columns["CausaEgreso"].DisplayIndex = 4;
        	dgv.Columns["Observaciones"].DisplayIndex = 5;
        	Controles.setEstandarDataGridView (dgv);
        	for (int i = 0; i < dgv.Columns.Count - 1; i++) {
        		dgv.Columns[i].Visible = !(dgv.Columns[i].Name.StartsWith ("id") || dgv.Columns[i].Name.StartsWith ("Id"));
        	}

		}

        private void cargarDGVfamiliares (DataGridView dgv)
        {
        	dgv.DataSource = null;
        	dgv.DataSource = empleado.Familiares;
        	dgv.Columns["Legajo"].Visible = false;
        	dgv.Columns["IdFamiliar"].DisplayIndex = 0;
        	dgv.Columns["ApellidoYnombres"].DisplayIndex = 1;
        	dgv.Columns["IdParentesco"].Visible = false;
        	dgv.Columns["Parentesco"].DisplayIndex = 2;
        	dgv.Columns["IdTipoDocumento"].Visible = false;
        	dgv.Columns["TipoDocumento"].DisplayIndex = 3;
        	dgv.Columns["NumeroDocumento"].DisplayIndex = 4;
        	dgv.Columns["FechaNacimiento"].DisplayIndex = 5;
        	dgv.Columns["FechaAlta"].DisplayIndex = 6;
        	dgv.Columns["FechaBaja"].DisplayIndex = 7;
        	dgv.Columns["IdSexo"].Visible = false;
        	dgv.Columns["Sexo"].DisplayIndex = 8;
        	dgv.Columns["IdNacionalidad"].Visible = false;
        	dgv.Columns["Nacionalidad"].DisplayIndex = 9;
        	dgv.Columns["IdEstadoCivil"].Visible = false;
        	dgv.Columns["EstadoCivil"].DisplayIndex = 10;
        	dgv.Columns["GeneraSalario"].DisplayIndex = 11;
        	dgv.Columns["DeclaradoParaGanancias"].DisplayIndex = 12;
        	Controles.setEstandarDataGridView (dgv);
        	for (int i = 0; i < dgv.Columns.Count - 1; i++) {
        		dgv.Columns[i].Visible = !(dgv.Columns[i].Name.StartsWith ("id") || dgv.Columns[i].Name.StartsWith ("Id"));
        	}

		}


        private void cargarDGVcampos (DataGridView dgv)
        {
        	dgv.DataSource = null;
        	dgv.DataSource = empleado.OtrosCampos;
        	dgv.Columns["Legajo"].Visible = false;
        	dgv.Columns["Nombre"].Visible = false;
        	dgv.Columns["Codigo"].DisplayIndex = 0;
        	dgv.Columns["Descripcion"].DisplayIndex = 1;
        	dgv.Columns["Valor"].DisplayIndex = 2;
        	dgv.Columns["Detalle"].DisplayIndex = 3;
        	Controles.setEstandarDataGridView (dgv);
			for (int i = 0; i < dgv.Columns.Count - 1; i++) {
				dgv.Columns[i].Visible = !(dgv.Columns[i].Name.StartsWith ("id") || dgv.Columns[i].Name.StartsWith ("Id"));
			}
			
		}


        /// <summary>
        /// administra el estado de los controles que muestran la causa de egreso y fechas de baja y reingreso
        /// en base al estado del empleado.
        /// </summary>
        private void actualizaEstadoEmpleado()
        {

            this.lblFechaEgreso.Visible = this.dtpFechaEgreso.Checked;
            this.dtpFechaEgreso.Visible = this.dtpFechaEgreso.Checked;
            this.lblCausaEgreso.Visible = this.dtpFechaEgreso.Checked;
            this.cmbCausaEgreso.Visible = this.dtpFechaEgreso.Checked;

            this.lblFechaReIngreso.Visible = this.dtpFechaReIngreso.Checked;
            this.dtpFechaReIngreso.Visible = this.dtpFechaReIngreso.Checked;
        }

        /// <summary>
        /// actualiza controles relacionados con formas de pago de acuerdo a sus valores.
        /// </summary>
        private void actualizaFormasDePago()
        {
            if (empleado.IdFormaDePago == 2)
            {
                this.cmbBancos.Visible = true;
                this.cmbSucursalesBanco.Visible = true;
                this.txtNumeroCuenta.Visible = true;
                this.lblSucursalBanco.Visible = true;
                this.lblNumeroCuenta.Visible = true;
                this.lblBanco.Visible = true;
            }
            else
            {
                this.cmbBancos.Visible = false;
                this.cmbSucursalesBanco.Visible = false;
                this.txtNumeroCuenta.Visible = false;
                this.lblSucursalBanco.Visible = false;
                this.lblNumeroCuenta.Visible = false;
                this.lblBanco.Visible = false;
            }
        }

        private void cmbCausaEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdCausaEgreso = Convert.ToInt32(this.cmbCausaEgreso.SelectedValue);
                this.btnGrabar.Enabled = true;
            }
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdProvincia = Convert.ToInt32(this.cmbProvincia.SelectedValue);
                Controles.cargaComboBox(this.cmbLocalidad, "nombreLocalidad", "idLocalidad", "LocalidadesConsultar", "@idPais", this.cmbPais.SelectedValue, "@idProvincia", this.cmbProvincia.SelectedValue);
                this.btnGrabar.Enabled = true;
            }
        }


        private void cargarCombos()
        {
            Controles.cargaComboBox(this.cmbEstado, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 10);
            Controles.cargaComboBox(this.cmbTipoLiquidacion, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 41);
            Controles.cargaComboBox(this.cmbCausaEgreso, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 11);
            Controles.cargaComboBox(this.cmbContrato, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 12);
            Controles.cargaComboBox(this.cmbPais, "nombrePais", "idPais", "PaisesConsultar");
            Controles.cargaComboBox(this.cmbProvincia, "nombreProvincia", "idProvincia", "ProvinciasConsultar", "@idPais", this.cmbPais.SelectedValue);
            Controles.cargaComboBox(this.cmbLocalidad, "nombreLocalidad", "idLocalidad", "LocalidadesConsultar", "@idPais", this.cmbPais.SelectedValue, "@idProvincia", this.cmbProvincia.SelectedValue);
            Controles.cargaComboBox(this.cmbTipoDoc, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 16);
            Controles.cargaComboBox(this.cmbAFJP, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 20);
            Controles.cargaComboBox(this.cmbEstadoCivil, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 15);
            Controles.cargaComboBox(this.cmbCentroDeCosto, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 35);
            Controles.cargaComboBox(this.cmbCategoria, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 30);
            Controles.cargaComboBox(this.cmbPuesto, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 31);
            Controles.cargaComboBox(this.cmbArea, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 36);
            Controles.cargaComboBox(this.cmbSucursalesBanco, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 21);
            Controles.cargaComboBox(this.cmbBancos, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 24);
            Controles.cargaComboBox(this.cmbConvenio, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 13);
            Controles.cargaComboBox(this.cmbSindicato, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 14);
            Controles.cargaComboBox(this.cmbObraSocial, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 50);
            Controles.cargaComboBox(this.cmbSexo, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 7);
            Controles.cargaComboBox(this.cmbNacionalidad, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 5);
            Controles.cargaComboBox(this.cmbFormaDePago, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 23);
            Controles.cargaComboBox(this.cmbHorariosPlantillas, "Horario", "id", "horariosPlantillasConsultarParaCombo");
            Controles.cargaComboBox(this.cmbSituacionDeRevista, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 60);
            this.cmbSituacionDeRevista.SelectedIndex = -1;
            Controles.cargaComboBox(this.cmbCodigoDeCondicion, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 61);
            this.cmbCodigoDeCondicion.SelectedIndex = -1;
            Controles.cargaComboBox(this.cmbCodigoDeActividad, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 62);
            this.cmbCodigoDeActividad.SelectedIndex = -1;
            Controles.cargaComboBox(this.cmbModalidadDeContratacion, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 63);
            this.cmbModalidadDeContratacion.SelectedIndex = -1;
            Controles.cargaComboBox(this.cmbCodigoDeSiniestrado, "detalle", "contenido", "tablasConsultarContenidoyDetalle", "tabla", "empleadosSueldos", "indice", 64);
            this.cmbCodigoDeSiniestrado.SelectedIndex = -1;
        }

        private void cargarGrillas ()
        {
        	if (empleado != null)
            {
        		//Controles.cargaDataGridView(this.dgvVacaciones, "vacacionesConsultarParaGrilla", "@legajo", empleado.Legajo);
        		Controles.cargaDataGridView (this.dgvAsistencia, "asistenciaConsultarParaGrilla", "@legajo", empleado.Legajo);
        		Controles.setEstandarDataGridView (this.dgvVacaciones);
                Controles.cargaDataGridView (this.dgvAnticipos, "anticiposConsultarPorLegajoCtaCte", "@legajo", empleado.Legajo);
				Controles.setEstandarDataGridView(this.dgvAsistencia);
//                dgvAnticipos.Columns[0].Visible = false;
//                dgvAnticipos.Columns[1].Visible = false;
//                dgvAnticipos.Columns[3].Visible = false;
                //Controles.cargaDataGridView(this.dgvAnticipos, "novedadesConsultarParaAnticipos", "@legajo", empleado.Legajo);
                Controles.setEstandarDataGridView(this.dgvAnticipos);

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            openFileDialogFoto.Filter = "Imagen JPG (*.jpg)|*.jpg";
            openFileDialogFoto.FileName = "";
            if (openFileDialogFoto.ShowDialog()==DialogResult.OK )
            {
                this.btnGrabar.Enabled = true;
                empleado.Foto = openFileDialogFoto.FileName;
                try
                {
                    this.pbFoto.Image = new Bitmap(empleado.Foto);
                }
                catch (Exception)
                {
                    this.pbFoto.Image = null;
                }
            }

        }

        private void tabRemuneraciones_Click(object sender, EventArgs e)
        {

        }

        private void dgvCampos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CampoEmpleadoEntity campoOriginal = new CampoEmpleadoEntity();
            frmCampoEmpleado frmc = new frmCampoEmpleado();
            frmc.abrirParaNuevo(ref campoOriginal);
            //if (empleado.OtrosCampos.existeCodigo(campoOriginal))
            if (this.existeCodigoCampoEmpleado(campoOriginal))
                MessageBox.Show("el campo ya existe, modifiquelo por favor");
            else
            {
                empleado.OtrosCampos.Add(campoOriginal);
                this.btnGrabar.Enabled = true;
            }
            //this.empleado.OtrosCampos.cargarDataGridView(this.dgvCampos);
            this.cargarDGVcampos(this.dgvCampos);
        }

        /// <summary>
        /// verifica si un codigo existe en la coleccion
        /// </summary>
        /// <param name="ce"></param>
        /// <returns></returns>
        private bool existeCodigoCampoEmpleado(CampoEmpleadoEntity ce)
        {
            Boolean salida = false;
            foreach (CampoEmpleadoEntity c in empleado.OtrosCampos)
            {
                if (c.Codigo == ce.Codigo)
                    salida = true;
            }
            return salida;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CampoEmpleadoEntity campoOriginal = null; ;
            frmCampoEmpleado frmc = new frmCampoEmpleado();
            campoOriginal = empleado.OtrosCampos[Convert.ToInt32(Controles.consultaRenglonSeleccionado(this.dgvCampos))];
            frmc.abrirParaModificar(ref campoOriginal);
            this.btnGrabar.Enabled = true;
            //this.empleado.OtrosCampos.cargarDataGridView(this.dgvCampos);
            this.cargarDGVcampos(this.dgvCampos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CampoEmpleadoEntity campoOriginal = null; ;
            campoOriginal = empleado.OtrosCampos[Convert.ToInt32(Controles.consultaRenglonSeleccionado(this.dgvCampos))];
            DialogResult result = MessageBox.Show("Confirma la eliminación del campo ?", "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                empleado.OtrosCampos.Remove(campoOriginal);
                this.btnGrabar.Enabled = true;
            }
            //this.empleado.OtrosCampos.cargarDataGridView(this.dgvCampos);
            this.cargarDGVcampos(this.dgvCampos);
        }





        private void txtApellidoyNombres_TextChanged(object sender, EventArgs e)
        {
            empleado.Nombre = this.txtApellidoyNombres.Text; ;
            this.btnGrabar.Enabled = true;
        }

        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {
            empleado.Domicilio = this.txtDomicilio.Text; ;
            this.btnGrabar.Enabled = true;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            empleado.Telefono = this.txtTelefono.Text;
            this.btnGrabar.Enabled = true;
        }

        private void txtLegajo_TextChanged(object sender, EventArgs e)
        {
            empleado.Legajo = Convert.ToInt32(this.txtLegajo.Text);
            this.btnGrabar.Enabled = true;
        }

        private void txtTelefonoMensajes_TextChanged(object sender, EventArgs e)
        {
            empleado.TelefonoMensajes = this.txtTelefonoMensajes.Text;
            this.btnGrabar.Enabled = true;
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            empleado.FechaNacimiento = this.dtpFechaNacimiento.Value;
            this.btnGrabar.Enabled = true;
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdPais = Convert.ToInt32(this.cmbPais.SelectedValue);
                Controles.cargaComboBox(this.cmbProvincia, "nombreProvincia", "idProvincia", "ProvinciasConsultar", "@idPais", this.cmbPais.SelectedValue);
                this.btnGrabar.Enabled = true;
            }
        }

        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdLocalidad = Convert.ToInt32(this.cmbLocalidad.SelectedValue);
                this.btnGrabar.Enabled = true;
            }
        }

        private void txtCP_TextChanged(object sender, EventArgs e)
        {
            empleado.CP = this.txtCP.Text;
            this.btnGrabar.Enabled = true;
        }

        private void cmbTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdTipoDocumento = Convert.ToInt32(this.cmbTipoDoc.SelectedValue);
                this.btnGrabar.Enabled = true;
            }
        }

        private void txtNumeroDoc_TextChanged(object sender, EventArgs e)
        {
            empleado.NumeroDocumento = this.txtNumeroDoc.Text ;
            this.btnGrabar.Enabled = true;
        }

        private void txtCUIL_TextChanged(object sender, EventArgs e)
        {
            empleado.CUIL = this.txtCUIL.Text;
            this.btnGrabar.Enabled = true;
        }

        private void cmbEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdEstadoCivil = Convert.ToInt32(this.cmbEstadoCivil.SelectedValue);
                this.btnGrabar.Enabled = true;
            }
        }

        private void cmbAFJP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdAFJP = Convert.ToInt32(this.cmbAFJP.SelectedValue);
                this.btnGrabar.Enabled = true;
            }
        }

        private void cmbCentroDeCosto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdCentroDeCosto = Convert.ToInt32(this.cmbCentroDeCosto.SelectedValue);
                this.btnGrabar.Enabled = true;
            }
        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            //empleado.FechaIngreso = this.dtpFechaIngreso.Value;
            this.btnGrabar.Enabled = true;
        }

        private void dtpFechaEgreso_ValueChanged(object sender, EventArgs e)
        {
            this.dtpFechaEgreso.ShowCheckBox = true;
            /*if (this.dtpFechaEgreso.Checked)
            {
                empleado.FechaEgreso = this.dtpFechaEgreso.Value;
            //    cmbCausaEgreso.SelectedValue = 1;
            //    cmbEstado.SelectedValue = 1;
            }
            else
            {
                empleado.FechaEgreso = new DateTime(0);
            //    cmbCausaEgreso.SelectedValue = 0;
            //    cmbEstado.SelectedValue = 0;
            }*/
            
            this.btnGrabar.Enabled = true;
        }


        private void cmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdPuesto = Convert.ToInt32(this.cmbPuesto.SelectedValue);
                this.btnGrabar.Enabled = true;
            }
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdArea = Convert.ToInt32(this.cmbArea.SelectedValue);
                this.btnGrabar.Enabled = true;
            }
        }

        private void cmbTipoLiquidacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdTipoLiquidacion = Convert.ToInt32(this.cmbTipoLiquidacion.SelectedValue);
                this.btnGrabar.Enabled = true;
            }
        }

        private void cmbObraSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdObraSocial = Convert.ToInt32(this.cmbObraSocial.SelectedValue);
                this.btnGrabar.Enabled = true;
            }
        }

        private void txtSueldoOjornal_TextChanged(object sender, EventArgs e)
        {
            if (this.txtSueldoOjornal.Text != "")
            {
                empleado.SueldoOjornal = Convert.ToDouble(this.txtSueldoOjornal.Text);
                this.btnGrabar.Enabled = true;
            }
        }

        private void cmbConvenio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdConvenio = Convert.ToInt32(this.cmbConvenio.SelectedValue);
                this.btnGrabar.Enabled = true;
            }
        }

        private void cmbBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdSucursalBanco = Convert.ToInt32(this.cmbSucursalesBanco.SelectedValue);
                this.btnGrabar.Enabled = true;
            }
        }

        private void txtNumeroCuenta_TextChanged(object sender, EventArgs e)
        {
            empleado.NumeroCuenta = this.txtNumeroCuenta.Text;
            this.btnGrabar.Enabled = true;
        }

        private void tabVacaciones_Click(object sender, EventArgs e)
        {

        }

        private void cmbNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdNacionalidad = Convert.ToInt32(this.cmbNacionalidad.SelectedValue);
                this.btnGrabar.Enabled = true;
            }
        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdSexo = Convert.ToInt32(this.cmbSexo.SelectedValue);
                this.btnGrabar.Enabled = true;
            }

        }

        private void txtLegajoConyuge_TextChanged(object sender, EventArgs e)
        {
            empleado.LegajoDelConyuge = Convert.ToInt32(this.txtLegajoConyuge.Text);
            this.btnGrabar.Enabled = true;
        }

        private void btnModificarFamiliar_Click(object sender, EventArgs e)
        {
            FamiliarEntity original = null; ;
            frmFamiliar frmf = new frmFamiliar();
            original = empleado.Familiares[Convert.ToInt32(Controles.consultaRenglonSeleccionado(this.dgvFamiliares))];
            frmf.abrirParaModificar(ref original);
            this.btnGrabar.Enabled = true;
            //this.empleado.Familiares.cargarDataGridView(this.dgvFamiliares );
            this.cargarDGVfamiliares(this.dgvFamiliares);
       }

        

        private void btnNuevoFamiliar_Click(object sender, EventArgs e)
        {
            FamiliarEntity original = new FamiliarEntity();
            frmFamiliar frmf = new frmFamiliar();
            frmf.abrirParaNuevo(ref original);
            //if (empleado.Familiares.existeCodigo(original))
            if (this.existeCodigoFamiliar(original))
                MessageBox.Show("el familiar ya existe, modifiquelo por favor");
            else
            {
                empleado.Familiares.Add(original);
                this.btnGrabar.Enabled = true;
            }
            //this.empleado.Familiares.cargarDataGridView(this.dgvFamiliares);
            this.cargarDGVfamiliares(this.dgvFamiliares);
        }

        /// <summary>
        /// verifica si un codigo existe en la coleccion
        /// </summary>
        /// <param name="ce"></param>
        /// <returns></returns>
        private bool existeCodigoFamiliar(FamiliarEntity ce)
        {
            Boolean salida = false;
            foreach (FamiliarEntity c in empleado.Familiares)
            {
                if (c.NumeroDocumento == ce.NumeroDocumento)
                    salida = true;
            }
            return salida;
        }


        private void btnEliminarFamiliar_Click(object sender, EventArgs e)
        {
            FamiliarEntity original = null; ;
            original = empleado.Familiares[Convert.ToInt32(Controles.consultaRenglonSeleccionado(this.dgvFamiliares))];
            //DialogResult result = MessageBox.Show("Confirma la eliminación del campo ?", "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Varios.confirmaEliminarRegistro())
            {
                empleado.Familiares.Remove(original);
                this.btnGrabar.Enabled = true;
            }
            //this.empleado.Familiares.cargarDataGridView(this.dgvFamiliares);
            this.cargarDGVfamiliares(this.dgvFamiliares);
        }

        private void reportDocument1_InitReport(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdCategoria = Convert.ToInt32(this.cmbCategoria.SelectedValue);
                this.btnGrabar.Enabled = true;
            }

        }

        private void cmbContrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdContrato = Convert.ToInt32(this.cmbContrato.SelectedValue);
                this.btnGrabar.Enabled = true;
            }
        }

        private void dtpFechaReIngreso_ValueChanged(object sender, EventArgs e)
        {
            this.dtpFechaReIngreso.ShowCheckBox = true;

            /*if (this.dtpFechaReIngreso.Checked)
                empleado.FechaReIngreso = this.dtpFechaReIngreso.Value;
            else
                empleado.FechaReIngreso = new DateTime(0);*/
            
            this.btnGrabar.Enabled = true;
        }


        private bool datosValidos()
        {
            Boolean ok = true;
            if (empleado.Legajo == 0)
            {
                MessageBox.Show("Debe establecer el legajo del empleado");
                ok = false;
                this.txtLegajo.Focus();
            }
            else
            {
                if (empleado.Nombre.Length < 5)
                {
                    MessageBox.Show("Debe establecer el nombre del empleado");
                    ok = false;
                    this.txtApellidoyNombres.Focus();
                }
                else
                {
                    if (consEmple.existeLegajo(empleado.Legajo) && empleado.IdPersona == 0)
                    {
                        MessageBox.Show("El legajo del empleado ya existe");
                        ok = false;
                        this.txtLegajo.Focus();
                    }
                    else
                    {
                        if (empleado.IdConvenio == 0 || empleado.IdCategoria == 0 || empleado.IdContrato == 0 )
                        {
                            MessageBox.Show("Debe ingresar datos de Convenio/Categoria/Contrato");
                            ok = false;
                            this.cmbConvenio.Focus();
                        }
                        else
                        {
                            if (!CUIL.Validar(empleado.CUIL))
                            {
                                MessageBox.Show("Debe ingresar el CUIL valido del empleado");
                                ok = false;
                                this.txtCUIL.Focus();
                            }
                            else
                            {
                                if (empleado.IdArea == 0)
                                {
                                    MessageBox.Show("Debe ingresar el Area del empleado");
                                    ok = false;
                                    this.cmbArea.Focus();
                                }
                                else
                                {
                                    if (empleado.IdTipoLiquidacion == 0)
                                    {
                                        MessageBox.Show("Debe ingresar el Tipo de Salario");
                                        ok = false;
                                        this.cmbTipoLiquidacion.Focus();
                                    }
                                    else
                                    {
                                        if (empleado.SueldoOjornal <= 0)
                                        {
                                            MessageBox.Show("Debe ingresar el Sueldo o Jornal");
                                            ok = false;
                                            this.txtSueldoOjornal.Focus();
                                        }
                                        else
                                        {
                                            if (empleado.IdCentroDeCosto == 0)
                                            {
                                                MessageBox.Show("Debe ingresar el Centro de Costo");
                                                ok = false;
                                                this.cmbCentroDeCosto.Focus();
                                            }
                                            else
                                            {
                                                if (empleado.IdSexo == 0)
                                                {
                                                    MessageBox.Show("Debe ingresar el Sexo del Empleado");
                                                    ok = false;
                                                    this.cmbSexo.Focus();
                                                }
                                                else
                                                {
                                                    if (cmbSituacionDeRevista.SelectedIndex == -1)
                                                    {
                                                        MessageBox.Show("Debe asignar una Situcion de Revista");
                                                        ok = false;
                                                        cmbSituacionDeRevista.Focus();
                                                    }
                                                    else
                                                    {
                                                        if (cmbCodigoDeCondicion.SelectedIndex == -1)
                                                        {
                                                            MessageBox.Show("Debe asignar un Código de Condición");
                                                            ok = false;
                                                            cmbCodigoDeCondicion.Focus();
                                                        }
                                                        else
                                                        {
                                                            if (cmbCodigoDeActividad.SelectedIndex == -1)
                                                            {
                                                                MessageBox.Show("Debe asignar un Código de Actividad");
                                                                ok = false;
                                                                cmbCodigoDeActividad.Focus();
                                                            }
                                                            else
                                                            {
                                                                if (cmbModalidadDeContratacion.SelectedIndex == -1)
                                                                {
                                                                    MessageBox.Show("Debe asignar una Modalidad de Contratación");
                                                                    ok = false;
                                                                    cmbModalidadDeContratacion.Focus();
                                                                }
                                                                else
                                                                {
                                                                    if (cmbCodigoDeSiniestrado.SelectedIndex == -1)
                                                                    {
                                                                        MessageBox.Show("Debe asignar un Código de Siniestrado");
                                                                        ok = false;
                                                                        cmbCodigoDeSiniestrado.Focus();
                                                                    }
                                                                    else
                                                                    {
                                                                        if (cmbFormaDePago.SelectedIndex == 2 && txtNumeroCuenta.Text.Length == 0)
                                                                        {
                                                                            MessageBox.Show("Debe Ingresar el número de cuenta");
                                                                            ok = false;
                                                                            txtNumeroCuenta.Focus();
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ok;
        }

        private void cmbSindicato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdSindicato = Convert.ToInt32(this.cmbSindicato.SelectedValue);
                this.btnGrabar.Enabled = true;
            }

        }

        private void btnPeriodosTrabajados_Click(object sender, EventArgs e)
        {
          /*  frmPeriodosTrabajados FrmPeriodos = new frmPeriodosTrabajados(empleado.Periodos);
            empleado.cargarFechas();
            Varios.seteaDTPicker(dtpFechaIngreso, empleado.FechaIngreso,true );
            Varios.seteaDTPicker(this.dtpFechaEgreso, empleado.FechaEgreso,true );
            Varios.seteaDTPicker(this.dtpFechaReIngreso, empleado.FechaReIngreso,true );
            this.dtpFechaReIngreso.Refresh();*/
        }

        private void btnNuevoPeriodoTrabajado_Click(object sender, EventArgs e)
        {
            frmPeriodosTrabajados frmPeriodos = new frmPeriodosTrabajados();
            frmPeriodos.Periodo = new PeriodoTrabajadoEntity();
            frmPeriodos.ShowDialog();
            if (frmPeriodos.Periodo.FechaInicio > Convert.ToDateTime("01/01/1920"))
            {
                frmPeriodos.Periodo.Legajo = empleado.Legajo;
                this.empleado.Periodos.Add(frmPeriodos.Periodo);
                //this.empleado.Periodos.cargarDataGridView(this.dgvPeriodos);
                this.cargarDGVperiodos(this.dgvPeriodos);
                this.actualizarControlesFechas();
                this.btnGrabar.Enabled = true;
            }
        }



        private void btnEliminarPeriodoTrabajado_Click(object sender, EventArgs e)
        {
            PeriodoTrabajadoEntity campoOriginal = null;
            if (Controles.consultaRenglonSeleccionado(this.dgvPeriodos) >= 0)
            {
                campoOriginal = empleado.Periodos[Convert.ToInt32(Controles.consultaRenglonSeleccionado(this.dgvPeriodos))];
                if (Varios.confirmaEliminarRegistro())
                {
                    empleado.Periodos.Remove(campoOriginal);
                    //this.empleado.Periodos.cargarDataGridView(this.dgvPeriodos);
                    this.cargarDGVperiodos(this.dgvPeriodos);
                    this.actualizarControlesFechas();
                    this.btnGrabar.Enabled = true;
                }
            }
            

        }

        /// <summary>
        /// Realiza la actualización de los controles de fechas de ingreso/egreso/reingreso
        /// de acuerdo a la información actualizada en periodosTrabajados
        /// </summary>
        private void actualizarControlesFechas()
        {
            consEmple.actualizarFechas(empleado);
            //empleado.cargarFechas();
            Controles.seteaDTPicker(dtpFechaIngreso, empleado.FechaIngreso, true);
            Controles.seteaDTPicker(this.dtpFechaEgreso, empleado.FechaEgreso, true);
            Controles.seteaDTPicker(this.dtpFechaReIngreso, empleado.FechaReIngreso, true);
        }

        private void btnModificarPeriodoTrabajado_Click(object sender, EventArgs e)
        {
            PeriodoTrabajadoEntity campoOriginal = null;
            if (Controles.consultaRenglonSeleccionado(this.dgvPeriodos) >= 0)
            {
                campoOriginal = empleado.Periodos[Convert.ToInt32(Controles.consultaRenglonSeleccionado(this.dgvPeriodos))];
                frmPeriodosTrabajados frmPeriodos = new frmPeriodosTrabajados();
                frmPeriodos.Periodo = campoOriginal;
                frmPeriodos.ShowDialog();
                if (frmPeriodos.Periodo.FechaInicio > Convert.ToDateTime("01/01/1920"))
                {
                    //this.empleado.Periodos.cargarDataGridView(this.dgvPeriodos);
                    this.cargarDGVperiodos(this.dgvPeriodos);
                    this.actualizarControlesFechas();
                    this.btnGrabar.Enabled = true;
                }
            }

        }

        private void dtpFechaReconocimiento_ValueChanged(object sender, EventArgs e)
        {
            //empleado.FechaIngreso = this.dtpFechaIngreso.Value;
            empleado.FechaReconocimiento = this.dtpFechaReconocimiento.Value;
            this.btnGrabar.Enabled = true;
        }

        private void cmbFormaDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdFormaDePago = Convert.ToInt32(this.cmbFormaDePago.SelectedValue);
                this.btnGrabar.Enabled = true;
                this.actualizaFormasDePago();
            }
            
        }

        private void btnNuevoHorario_Click(object sender, EventArgs e)
        {
            frmHorario FrmHorario = new frmHorario();
            FrmHorario.Horario = new HorarioEntity();
            FrmHorario.ShowDialog();
            if (FrmHorario.Horario!=null)
            {
                FrmHorario.Horario.Legajo = empleado.Legajo;
                this.empleado.Horarios.Add(FrmHorario.Horario);
                //this.empleado.Horarios.cargarDataGridView(this.dgvHorarios);
                this.cargarDGVhorarios(this.dgvHorarios);
                this.btnGrabar.Enabled = true;
            }

        }

        private void btnModificarHorario_Click(object sender, EventArgs e)
        {
            HorarioEntity campoOriginal = null; ;
            if (Controles.consultaRenglonSeleccionado(this.dgvHorarios) >= 0)
            {
                campoOriginal = empleado.Horarios[Convert.ToInt32(Controles.consultaRenglonSeleccionado(this.dgvHorarios))];
                frmHorario FrmHorario = new frmHorario();
                FrmHorario.Horario = campoOriginal;
                FrmHorario.ShowDialog();
                if (FrmHorario.Horario!=null)
                {
                    //this.empleado.Horarios.cargarDataGridView(this.dgvHorarios);
                    this.cargarDGVhorarios(this.dgvHorarios);
                    this.btnGrabar.Enabled = true;
                }
            }
        }

        private void btnEliminarHorario_Click(object sender, EventArgs e)
        {
            HorarioEntity campoOriginal = null;
            if (Controles.consultaRenglonSeleccionado(this.dgvHorarios) >= 0)
            {
                campoOriginal = empleado.Horarios[Convert.ToInt32(Controles.consultaRenglonSeleccionado(this.dgvHorarios))];
                if (Varios.confirmaEliminarRegistro())
                {
                    empleado.Horarios.Remove(campoOriginal);
                    //this.empleado.Horarios.cargarDataGridView(this.dgvHorarios);
                    this.cargarDGVhorarios(this.dgvHorarios);
                    this.btnGrabar.Enabled = true;
                }
            }
            

        }

        private void btnAplicarHorarioPredefinido_Click(object sender, EventArgs e)
        {
            int diaDesde = 0;
            int diaHasta = 0;
            DateTime horaEntrada = new DateTime(0);
            DateTime horaSalida = new DateTime(0);
            int tolerancia=0;
            string dia="";

            HorarioEntity horario = null;

            if (!Varios.IsNumeric(this.cmbHorariosPlantillas.SelectedValue.ToString()))
                return;

            if (this.chkEliminaExistentes.Checked)
            {
                //limpio grilla
                this.dgvHorarios.DataSource = "";
                //limpio horarios en empleado
                empleado.Horarios.Clear();
            }
            
            System.Data.Common.DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "horariosPlantillasConsultarId", "@id", Convert.ToInt32(this.cmbHorariosPlantillas.SelectedValue));
            if (rs.Read())
            {
                diaDesde = Convert.ToInt32(rs["idDiaDesde"]);
                diaHasta = Convert.ToInt32(rs["idDiaHasta"]);
                horaEntrada = Convert.ToDateTime(rs["horaEntrada"]);
                horaSalida = Convert.ToDateTime(rs["horaSalida"]);
                tolerancia=Convert.ToInt32(rs["Tolerancia"]);
                for (; diaDesde <= diaHasta; diaDesde++)
                {
                    System.Data.Common.DbDataReader rsDia = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "tablasConsultarDetalle", "@tabla", "calendario", "indice", 3, "contenido", diaDesde);
                    if (rsDia.Read())
                        dia = rsDia["detalle"].ToString();

                    //dia=Model.DB.ejecutarScalar(Model.TipoComando.SP, "tablasConsultarDetalle", "@tabla","calendario","indice",3, "contenido", diaDesde ).ToString();
                    
                    if (horaEntrada > horaSalida)
                    {
                        horario = new HorarioEntity(0, empleado.Legajo, 24, diaDesde,dia , 1, "ENTRADA", horaEntrada.ToShortTimeString(), tolerancia);
                        empleado.Horarios.Add(horario);
                        horario = new HorarioEntity(0, empleado.Legajo, 0, diaDesde , dia, 2, "SALIDA", horaSalida.ToShortTimeString(), tolerancia);
                        empleado.Horarios.Add(horario);
                    }
                    else
                    {
                        horario = new HorarioEntity(0, empleado.Legajo, 0, diaDesde, dia, 1, "ENTRADA", horaEntrada.ToShortTimeString(), tolerancia);
                        empleado.Horarios.Add(horario);
                        horario = new HorarioEntity(0, empleado.Legajo,0, diaDesde, dia, 2,"SALIDA", horaSalida.ToShortTimeString(), tolerancia);
                        empleado.Horarios.Add(horario);
                    }     
                }
                //empleado.Horarios.cargarDataGridView(this.dgvHorarios);
                this.cargarDGVhorarios(this.dgvHorarios);
            }

            this.btnGrabar.Enabled = true;
        }

        private void cmbSituacionDeRevista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdSituacionDeRevista= Convert.ToInt32(this.cmbSituacionDeRevista.SelectedValue);
                this.btnGrabar.Enabled = true;
            }

        }

        private void cmbCodigoDeCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdCodigoDeCondicion = Convert.ToInt32(this.cmbCodigoDeCondicion.SelectedValue);
                this.btnGrabar.Enabled = true;
            }

        }

        private void cmbCodigoDeActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdCodigoDeActividad= Convert.ToInt32(this.cmbCodigoDeActividad.SelectedValue);
                this.btnGrabar.Enabled = true;
            }

        }

        private void cmbModalidadDeContratacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdModalidadDeContratacion = Convert.ToInt32(this.cmbModalidadDeContratacion.SelectedValue);
                this.btnGrabar.Enabled = true;
            }

        }

        private void cmbCodigoDeSiniestrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdCodigoDeSiniestrado = Convert.ToInt32(this.cmbCodigoDeSiniestrado.SelectedValue);
                this.btnGrabar.Enabled = true;
            }

        }

        private void btnNuevoVacaciones_Click(object sender, EventArgs e)
        {
            VacacionEntity original = new VacacionEntity();
            original.Legajo = this.empleado.Legajo;
            original.AnioVacaciones = DateTime.Now.Year;
            frmVacacionesEmpleado frmv = new frmVacacionesEmpleado();
            frmv.abrirParaNuevo(ref original);
            if (frmv.Ok)
            {
                empleado.Vacaciones.Add(original);
                this.btnGrabar.Enabled = true;
                //this.empleado.Vacaciones.cargarDataGridView(this.dgvVacaciones);
                this.cargarDGVvacaciones(this.dgvVacaciones);
            }
        }

        private void btnModificarVacaciones_Click(object sender, EventArgs e)
        {
            VacacionEntity original = null; ;
            frmVacacionesEmpleado frmv = new frmVacacionesEmpleado();
            original = empleado.Vacaciones[Convert.ToInt32(Controles.consultaRenglonSeleccionado(this.dgvVacaciones))];
            frmv.abrirParaModificar(ref original);
            if (frmv.Ok)
            {
                this.btnGrabar.Enabled = true;
                //this.empleado.Vacaciones.cargarDataGridView(this.dgvVacaciones);
                this.cargarDGVvacaciones(this.dgvVacaciones);
            }
        }

        private void btnEliminarVacaciones_Click(object sender, EventArgs e)
        {
            VacacionEntity original = null; ;
            original = empleado.Vacaciones[Convert.ToInt32(Controles.consultaRenglonSeleccionado(this.dgvVacaciones))];
            if (Varios.confirmaEliminarRegistro())
            {
                empleado.Vacaciones.Remove(original);
                this.btnGrabar.Enabled = true;
            }
            //this.empleado.Vacaciones.cargarDataGridView(this.dgvVacaciones);
            this.cargarDGVvacaciones(this.dgvVacaciones);
        }

        private void cmbBancos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                empleado.IdBanco = Convert.ToInt32(this.cmbBancos.SelectedValue);
                this.btnGrabar.Enabled = true;
            }
        }
    }
}