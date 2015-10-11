using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sofft.ViewComunes;

namespace Sueldos.View
{
    public partial class frmEdicionConcepto : Form
    {
        private int idTablaLiquidacion;

        public string Formula
        {
            get { return textBoxConcepto.Text; }
        }

        public string FormulaCompilador
        {
            get
            {
                string formulaCompilador = "";
                foreach (string fragmento in concepto)
                { formulaCompilador = formulaCompilador + fragmento + " "; }
                return formulaCompilador;
            }
        }

        public frmEdicionConcepto(int tabla)
        {
            InitializeComponent();
            idTablaLiquidacion = tabla;
            activarPaso(pasos.Inicio);
            OperandorActivo = radioButtonVariable;
            Controles.cargaComboBox(comboBoxOperandosGeneral, "descripcion", "indice", "tablasConsultarIndiceDescripcion", "tabla", "VAR");
        }
        
        enum pasos
        {
            Inicio,
            Accion,
            Si,
            Entonces,
            Sino,
            Operando,
            Operador,
            Parametro,
        }

        pasos pasoActivo = pasos.Inicio;
        int parentesis = 0;
        Stack<int> parametros = new Stack<int>();
        Queue<String> concepto = new Queue<string>();

        private void activarPaso(pasos paso)
        {
            if (parametros.Count == 0 && parentesis == 0)
            {
                switch (paso)
                {
                    case pasos.Inicio:
                        btnAccion.Enabled = true;
                        btnSI.Enabled = true;
                        btnEntonces.Enabled = false;
                        btnSino.Enabled = false;
                        btnGrabar.Enabled = false;
                        groupBoxAccion.Enabled = false;
                        groupBoxFuncion.Enabled = false;
                        groupBoxOperacionesLogicas.Enabled = false;
                        groupBoxOperacionesAritmeticas.Enabled = false;
                        groupBoxGrupos.Enabled = false;
                        groupBoxOperandos.Enabled = false;
                        break;
                    case pasos.Accion:
                        btnAccion.Enabled = false;
                        btnSI.Enabled = false;
                        btnEntonces.Enabled = false;
                        btnSino.Enabled = false;
                        btnGrabar.Enabled = false;
                        groupBoxAccion.Enabled = true;
                        groupBoxFuncion.Enabled = false;
                        groupBoxOperacionesLogicas.Enabled = false;
                        groupBoxOperacionesAritmeticas.Enabled = false;
                        groupBoxGrupos.Enabled = false;
                        groupBoxOperandos.Enabled = false;
                        break;
                    case pasos.Si:
                        btnAccion.Enabled = false;
                        btnSI.Enabled = false;
                        btnEntonces.Enabled = false;
                        btnSino.Enabled = false;
                        btnGrabar.Enabled = false;
                        groupBoxAccion.Enabled = false;
                        groupBoxFuncion.Enabled = true;
                        groupBoxOperacionesLogicas.Enabled = false;
                        groupBoxOperacionesAritmeticas.Enabled = false;
                        groupBoxGrupos.Enabled = true;
                        groupBoxOperandos.Enabled = true; 
                        break;
                    case pasos.Entonces:
                        btnAccion.Enabled = false;
                        btnSI.Enabled = false;
                        btnEntonces.Enabled = false;
                        btnSino.Enabled = false;
                        btnGrabar.Enabled = false;
                        groupBoxAccion.Enabled = true;
                        groupBoxFuncion.Enabled = false;
                        groupBoxOperacionesLogicas.Enabled = false;
                        groupBoxOperacionesAritmeticas.Enabled = false;
                        groupBoxGrupos.Enabled = false;
                        groupBoxOperandos.Enabled = false; break;
                    case pasos.Sino:
                        btnAccion.Enabled = false;
                        btnSI.Enabled = false;
                        btnEntonces.Enabled = false;
                        btnSino.Enabled = false;
                        btnGrabar.Enabled = false;
                        groupBoxAccion.Enabled = true;
                        groupBoxFuncion.Enabled = false;
                        groupBoxOperacionesLogicas.Enabled = false;
                        groupBoxOperacionesAritmeticas.Enabled = false;
                        groupBoxGrupos.Enabled = false;
                        groupBoxOperandos.Enabled = false; break;
                    default:
                        break;
                }
            }
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            btnAccion.Enabled = false;
            btnSI.Enabled = false;
            groupBoxAccion.Enabled = true;

            pasoActivo = pasos.Accion;
        }

        private void btnSI_Click(object sender, EventArgs e)
        {
            btnAccion.Enabled = false;
            btnSI.Enabled = false;
            groupBoxFuncion.Enabled = true;
            groupBoxOperandos.Enabled = true;
            groupBoxGrupos.Enabled = true;
            
            pasoActivo = pasos.Si;
            textBoxConcepto.AppendText("Si ");
        }

        private void btnEntonces_Click(object sender, EventArgs e)
        {
            btnEntonces.Enabled = false;
            groupBoxAccion.Enabled = true;
            groupBoxFuncion.Enabled = false;
            groupBoxOperandos.Enabled = false;
            groupBoxGrupos.Enabled = false;
        
            pasoActivo = pasos.Entonces;
            concepto.Enqueue("?");
            textBoxConcepto.AppendText("Entonces ");
        }

        private void btnSino_Click(object sender, EventArgs e)
        {
            btnSino.Enabled = false;
            groupBoxAccion.Enabled = true;
            groupBoxFuncion.Enabled = false;
            groupBoxOperandos.Enabled = false;
            groupBoxGrupos.Enabled = false;

            pasoActivo = pasos.Sino;
            concepto.Enqueue(":");
            textBoxConcepto.AppendText("Sino ");
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            pasoActivo = pasos.Inicio;
            activarPaso(pasos.Inicio);
            concepto.Clear();
            textBoxConcepto.Text = "";
            this.Close();
        }

        private void listBoxAccion_Click(object sender, EventArgs e)
        {
            btnAgregarAccion.Enabled = true;
            switch (listBoxAccion.SelectedIndex)
            {
                case 0: 
                    labelAyuda.Text = "Guarda un valor en un destino";
                    break;
                case 1: 
                    labelAyuda.Text = "Guarda un valor en un acumulador. Reemplaza el valor actual con el nuevo valor";
                    break;
                case 2: 
                    labelAyuda.Text = "Acumula un valor en un acumulador. Adiciona el valor al valor actual";
                    break;
                case 3: 
                    labelAyuda.Text = "Actualiza el valor de un campo de empleado";
                    break;
                case 4: 
                    labelAyuda.Text = "Continua la liquidacion con el siguiente concepto";
                    break;
                case 5: 
                    labelAyuda.Text = "Continua la liquidacion en el conecto especificado";
                    break;
                default: 
                    labelAyuda.Text = "";
                    break;
            }
        }

        private void btnAgregarAccion_Click(object sender, EventArgs e)
        {
            btnAgregarAccion.Enabled = false;
            groupBoxAccion.Enabled = false;
            groupBoxFuncion.Enabled = true;
            groupBoxGrupos.Enabled = true;
            groupBoxOperacionesLogicas.Enabled = false;
            groupBoxOperacionesAritmeticas.Enabled = false;
            groupBoxOperandos.Enabled = true;
            
            textBoxConcepto.AppendText(listBoxAccion.SelectedItem.ToString());
            
            
            btnSiguienteParametro.Enabled = false;
            btnAgregar.Enabled = true;

            switch (listBoxAccion.SelectedIndex)
            {
                case 0:
                    concepto.Enqueue("guardar");
                    concepto.Enqueue("(");
                    parametros.Push(2);
                    textBoxConcepto.AppendText("(");
                    break;
                case 1:
                    concepto.Enqueue("guardarAcumulado");
                    concepto.Enqueue("(");
                    parametros.Push(2);
                    textBoxConcepto.AppendText("(");
                    break;
                case 2:
                    concepto.Enqueue("acumular");
                    concepto.Enqueue("(");
                    parametros.Push(2);
                    textBoxConcepto.AppendText("(");
                    break;
                case 3:
                    concepto.Enqueue("actualizarCampoEmpleado");
                    concepto.Enqueue("(");
                    parametros.Push(2);
                    textBoxConcepto.AppendText("(");
                    break;
                case 4:
                    concepto.Enqueue("seguir");
                    parametros.Push(0);
                    btnSiguienteParametro.Enabled = false;
                    btnAgregar.Enabled = false;
                    groupBoxGrupos.Enabled = false;
                    btnSino.Enabled = (pasoActivo == pasos.Entonces);
                    btnGrabar.Enabled = (pasoActivo == pasos.Sino || pasoActivo == pasos.Accion);
                    groupBoxFuncion.Enabled = false;
                    break;
                case 5:
                    concepto.Enqueue("saltar");
                    concepto.Enqueue("(");
                    parametros.Push(1);
                    groupBoxGrupos.Enabled = false;
                    textBoxConcepto.AppendText("(");
                    break;
                default:
                    labelAyuda.Text = "";
                    break;
            }
        }

        private void listBoxFunciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAgregarFuncion.Enabled = true;
            switch (listBoxFunciones.SelectedIndex)
            {
                case 0:
                    labelAyuda.Text = "Redondea un valor a una cantidad de decimales especificada";
                    break;
                case 1:
                    labelAyuda.Text = "Busca un importe";
                    break;
                case 2:
                    labelAyuda.Text = "Calcula la cantidad de dias entre dos fechas";
                    break;
                case 3:
                    labelAyuda.Text = "Cantidad de años entre dos fechas";
                    break;
                case 4:
                    labelAyuda.Text = "Devuleve el importe total de un concepto";
                    break;
                case 5:
                    labelAyuda.Text = "Acumulado mayor entre fechas";
                    break;
                case 6:
                    labelAyuda.Text = "Asistencia empleado entre dias";
                    break;
                default:
                    labelAyuda.Text = "";
                    break;
            }

        }

        private void btnAgregarFuncion_Click(object sender, EventArgs e)
        {
            btnAgregarFuncion.Enabled = false;
            btnAgregar.Enabled = true;
            groupBoxGrupos.Enabled = true;
            textBoxConcepto.AppendText(listBoxFunciones.SelectedItem + " ( ");
            switch (listBoxFunciones.SelectedIndex)
            {
                case 0:
                    concepto.Enqueue("redondear");
                    concepto.Enqueue("(");
                    parametros.Push(2);
                    break;
                case 1:
                    concepto.Enqueue("buscarImporte");
                    concepto.Enqueue("(");
                    parametros.Push(1);
                    break;
                case 2:
                    concepto.Enqueue("diasEntreFechas");
                    concepto.Enqueue("(");
                    parametros.Push(2);
                    break;
                case 3:
                    concepto.Enqueue("Anios");
                    concepto.Enqueue("(");
                    parametros.Push(2);
                    break;
                case 4:
                    concepto.Enqueue("totalConseptoImporte");
                    concepto.Enqueue("(");
                    parametros.Push(1);
                    break;
                case 5:
                    concepto.Enqueue("acumuladoMayorEntreFechas");
                    concepto.Enqueue("(");
                    parametros.Push(1);
                    break;
                case 6:
                    concepto.Enqueue("asistenciaEmpleadoEntreDias");
                    concepto.Enqueue("(");
                    parametros.Push(3);
                    break;
                default:
                    labelAyuda.Text = "";
                    break;
            }
        }

        private void btnParentesisAbierto_Click(object sender, EventArgs e)
        {
            parentesis++;
            btnParentesisCerrado.Enabled = true;
            groupBoxOperacionesLogicas.Enabled = false;
            groupBoxOperacionesAritmeticas.Enabled = false;
            groupBoxFuncion.Enabled = true;
            groupBoxOperandos.Enabled = true;

            concepto.Enqueue("(");
            textBoxConcepto.AppendText("( ");
        }

        private void btnParentesisCerrado_Click(object sender, EventArgs e)
        {
            parentesis--;

            if (parentesis == 0)
            {
                btnParentesisCerrado.Enabled = false;
                btnGrabar.Enabled = (pasoActivo == pasos.Accion || pasoActivo == pasos.Sino) && parametros.Count == 0;
            }
            groupBoxOperacionesLogicas.Enabled = pasoActivo == pasos.Si;
            groupBoxOperacionesAritmeticas.Enabled = true;
            groupBoxFuncion.Enabled = false;

            concepto.Enqueue(")");
            textBoxConcepto.AppendText(") ");
        }

        private void btnSiguienteParametro_Click(object sender, EventArgs e)
        {
            int i = parametros.Pop();
            i--;
            if (i > 0)
            {
                concepto.Enqueue(",");
                textBoxConcepto.AppendText(", ");
                parametros.Push(i);
            }
            else
            {
                concepto.Enqueue(")");
                textBoxConcepto.AppendText(") ");
            }
            btnSiguienteParametro.Enabled = (parametros.Count > 0);
            btnGrabar.Enabled = (pasoActivo == pasos.Accion || pasoActivo == pasos.Sino) && parametros.Count == 0 && parentesis == 0;
            btnAgregar.Enabled = !btnGrabar.Enabled;
            btnSino.Enabled = pasoActivo == pasos.Entonces && parametros.Count == 0 && parentesis == 0;
            groupBoxOperacionesLogicas.Enabled = pasoActivo == pasos.Si;
            groupBoxOperacionesAritmeticas.Enabled = true;
        }

        private void OperadorLogico_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            panelOperadoresLogicos.Enabled = false;
            panelYO.Enabled = true;
            groupBoxOperacionesLogicas.Enabled = false;
            groupBoxOperacionesAritmeticas.Enabled = false;

            switch (b.Text)
            {
                case "Distinto": concepto.Enqueue("<>"); break;
                case "Igual": concepto.Enqueue("="); break;
                case "Menor": concepto.Enqueue("<"); break;
                case "Mayor": concepto.Enqueue(">"); break;
                case "Menor o Igual": concepto.Enqueue("<="); break;
                case "Mayor o Igual": concepto.Enqueue(">="); break;
                default: break;
            }
           
            textBoxConcepto.AppendText(b.Text + " ");

        }

        private void btnY_Click(object sender, EventArgs e)
        {
            panelOperadoresLogicos.Enabled = true;
            panelYO.Enabled = false;
            groupBoxOperacionesLogicas.Enabled = false;
            groupBoxOperacionesAritmeticas.Enabled = false;

            concepto.Enqueue("&&");
            textBoxConcepto.AppendText("y ");
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            panelOperadoresLogicos.Enabled = true;
            panelYO.Enabled = false;
            groupBoxOperacionesLogicas.Enabled = false;
            groupBoxOperacionesAritmeticas.Enabled = false;

            concepto.Enqueue("||");
            textBoxConcepto.AppendText("o ");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnGrabar.Enabled = (pasoActivo == pasos.Accion || pasoActivo == pasos.Sino) && parametros.Count == 0 && parentesis == 0;
            btnEntonces.Enabled = pasoActivo == pasos.Si && parametros.Count == 0 && parentesis == 0;
            btnSino.Enabled = pasoActivo == pasos.Entonces && parametros.Count == 0 && parentesis == 0;
            btnSiguienteParametro.Enabled = (parametros.Count > 0);
            groupBoxOperacionesLogicas.Enabled = pasoActivo == pasos.Si;
            groupBoxOperacionesAritmeticas.Enabled = true;

            switch (OperandorActivo.Name)
            {
                //General
                case "radioButtonVariable":
                    concepto.Enqueue("variable(" + comboBoxOperandosGeneral.SelectedValue + ")");
                    textBoxConcepto.AppendText(comboBoxOperandosGeneral.Text + " ");
                    break;
                case "radioButtonAcumulador":
                    concepto.Enqueue("acumulador(" + comboBoxOperandosGeneral.SelectedValue + ")");
                    textBoxConcepto.AppendText(comboBoxOperandosGeneral.Text + " ");
                    break;
                case "radioButtonAsistencia":
                    concepto.Enqueue("variable(" + comboBoxOperandosGeneral.SelectedValue + ")");
                    textBoxConcepto.AppendText(comboBoxOperandosGeneral.Text + " ");
                    break;
                case "radioButtonConstante":
                    concepto.Enqueue("variable(" + comboBoxOperandosGeneral.SelectedValue + ")");
                    textBoxConcepto.AppendText(comboBoxOperandosGeneral.Text + " ");
                    break;
                case "radioButtonConcepto":
                    concepto.Enqueue(comboBoxOperandosGeneral.SelectedValue.ToString());
                    textBoxConcepto.AppendText(comboBoxOperandosGeneral.Text + " ");
                    break;
                case "radioButtonValor":
                    concepto.Enqueue(textBoxValor.Text);
                    textBoxConcepto.AppendText(textBoxValor.Text + " ");
                    break;
                case "radioButtonTabla":
                    concepto.Enqueue("tablas(\"" + comboBoxTabla.SelectedValue + "\"," + comboBoxCampo.SelectedValue + ")");
                    textBoxConcepto.AppendText(comboBoxCampo.Text + " ");
                    break;
                //Empleado
                case "radioButtonCampo":
                    concepto.Enqueue("campoEmpleado(" + comboBoxOperandoEmpleado.SelectedValue + ")");
                    textBoxConcepto.AppendText(comboBoxOperandoEmpleado.Text + " ");
                    break;
                case "radioButtonNovedad":
                    concepto.Enqueue("novedadEmpleado(" + comboBoxOperandoEmpleado.SelectedValue + ")");
                    textBoxConcepto.AppendText(comboBoxOperandoEmpleado.Text + " ");
                    break;
                case "radioButtonFecha":
                    concepto.Enqueue("fechaEmpleado(" + comboBoxOperandoEmpleado.SelectedValue + ")");
                    textBoxConcepto.AppendText(comboBoxOperandoEmpleado.Text + " ");
                    break;
                case "radioButtonAcumuladoEmpleado":
                    concepto.Enqueue("acumuladoEmpleado(" + comboBoxOperandoEmpleado.SelectedValue + ")");
                    textBoxConcepto.AppendText(comboBoxOperandoEmpleado.Text + " ");
                    break;
                default:
                    break;
            }
        }

        private void OperacionAritmetica_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            groupBoxGrupos.Enabled = true;
            groupBoxOperacionesAritmeticas.Enabled = false;
            groupBoxOperacionesLogicas.Enabled = false;

            concepto.Enqueue(b.Text);
            textBoxConcepto.AppendText(b.Text + " ");
        }

        private RadioButton OperandorActivo;
        private void radioButtonOperandos_CheckedChanged(object sender, EventArgs e)
        {
            OperandorActivo = (RadioButton)sender;
            comboBoxOperandosGeneral.DataSource = null;
            switch (OperandorActivo.Name)
            {
                //General
                case "radioButtonVariable":
                    Controles.cargaComboBox(comboBoxOperandosGeneral, "descripcion", "indice", "tablasConsultarIndiceDescripcion", "tabla", "VAR");
                    break;
                case "radioButtonAcumulador":
                    Controles.cargaComboBox(comboBoxOperandosGeneral, "descripcion", "indice", "tablasConsultarIndiceDescripcion","tabla",  "ACU");
                    break;
                case "radioButtonAsistencia":
                    Controles.cargaComboBox(comboBoxOperandosGeneral, "descripcion", "indice", "tablasConsultarIndiceDescripcion", "tabla", "asistencia");
                    break;
                case "radioButtonConstante":
                    break;
                case "radioButtonConcepto":
                    Controles.cargaComboBox(comboBoxOperandosGeneral, "Descripcion", "Codigo", "calculoConsultarDescripcion", "idCalculo", idTablaLiquidacion);
                    break;
                case "radioButtonValor":
                    break;
                case "radioButtonTabla":
                    Controles.cargaComboBox(comboBoxTabla, "nombre", "nombre", "tablasConsultarNombres");
                    break;
                //Empleado
                case "radioButtonCampo":
                    Controles.cargaComboBox(comboBoxOperandoEmpleado, "descripcion", "indice", "tablasConsultarIndiceDescripcion", "tabla", "empleadosSueldos");
                    break;
                case "radioButtonNovedad":
                    Controles.cargaComboBox(comboBoxOperandoEmpleado, "descripcion", "indice", "tablasConsultarIndiceDescripcion", "tabla", "novedades");
                    break;
                case "radioButtonFecha":
                    Controles.cargaComboBox(comboBoxOperandoEmpleado, "descripcion", "indice", "tablasConsultarIndiceDescripcion", "tabla", "empleadosSueldos");
                    break;
                case "radioButtonAcumuladoEmpleado":
                    Controles.cargaComboBox(comboBoxOperandoEmpleado, "descripcion", "indice", "tablasConsultarIndiceDescripcion","tabla",  "acumulados");    
                    break;

                default:
                    break;
            }

            comboBoxOperandosGeneral.Enabled = radioButtonVariable.Checked ||
                radioButtonAcumulador.Checked || radioButtonAsistencia.Checked ||
                radioButtonConcepto.Checked || radioButtonConstante.Checked;
            textBoxValor.Enabled = radioButtonValor.Checked;
            comboBoxTabla.Enabled = radioButtonTabla.Checked;
            comboBoxCampo.Enabled = radioButtonTabla.Checked;
            comboBoxOperandoEmpleado.Enabled = radioButtonCampo.Checked ||
                radioButtonAcumuladoEmpleado.Checked || radioButtonFecha.Checked ||
                radioButtonNovedad.Checked;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string fragmento in concepto)
            {
                textBoxConceptoCompilador.AppendText(fragmento + " ");
            }
        }
        
        private void comboBoxTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Controles.cargaComboBox(comboBoxCampo, "descripcion", "indice", "tablasConsultarIndiceDescripcion", "tabla", comboBoxTabla.SelectedValue);
        }
    }
}