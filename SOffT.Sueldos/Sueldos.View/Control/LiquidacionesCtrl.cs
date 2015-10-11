using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Sueldos.View.Control
{
    public partial class LiquidacionesCtrl : UserControl
    {
        /// <summary>
        /// Control para seleccionar una liquidacion activa, y uno o mas tipos de liquidacion correspondiente
        /// </summary>
        public LiquidacionesCtrl()
        {
            InitializeComponent();
            
            comboBoxEstado.ValueMember = "contenido";
            comboBoxEstado.DisplayMember = "detalle";

            comboBoxLiquidaciones.ValueMember = "id";
            comboBoxLiquidaciones.DisplayMember = "descripcion";

            listBoxTiposLiquidacion.ValueMember = "idTipoLiquidaciones";
            listBoxTiposLiquidacion.DisplayMember = "descripcion";
        }

        #region Propiedades
        /// <summary>
        /// Obtiene o Establece el id de la liquidacion seleccionada en el combo
        /// </summary>
        public int LiquidacionId
        {
            get { return Convert.ToInt32(comboBoxLiquidaciones.SelectedValue); }
            set { comboBoxLiquidaciones.SelectedValue = value; }
        }

        /// <summary>
        /// Obtiene la descripcion de la liquidacion seleccionda
        /// </summary>
        public string LiquidacionDescripcion
        { get { return comboBoxLiquidaciones.Text; } }

        /// <summary>
        /// Obtiene una lista con los id de los tipos de liquidacion seleccionados
        /// </summary>
        public IList<int> TiposSeleccionados
        {
            get
            {
                List<int> lista = new List<int>(this.listBoxTiposLiquidacion.SelectedItems.Count);
                foreach (DataRowView item in this.listBoxTiposLiquidacion.SelectedItems)
                { lista.Add(Convert.ToInt32(item[0])); }
                return lista;
            }
        }
        #endregion

        #region Metodos
        public event EventHandler LiquidacionId_Changed;
        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxLiquidaciones.DataSource = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "liquidacionesDetalleParaCombo", "estado", Convert.ToInt32(comboBoxEstado.SelectedValue)).Tables[0];
            comboBoxLiquidaciones.Refresh();
            listBoxTiposLiquidacion.Refresh();
            listBoxTiposLiquidacion.ClearSelected();
        }
        private void comboBoxLiquidaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxTiposLiquidacion.DataSource = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "liquidacionesPorTipoConsultar", "idLiquidacion", this.LiquidacionId).Tables[0];
            listBoxTiposLiquidacion.Refresh();
            listBoxTiposLiquidacion.ClearSelected();
            if (this.LiquidacionId_Changed != null)
            { this.LiquidacionId_Changed(sender, e); }
        }
        /// <summary>
        /// Llena el combo y la lista con la informacion de las liquidaciones
        /// </summary>
        public void LiquidacionesCargar()
        {
            comboBoxEstado.DataSource = Model.DB.ejecutarDataSet(Model.TipoComando.SP, "tablasConsultarContenidoyDetalle", "tabla", "LiquidacionesDetalle", "indice", 0).Tables[0];
            comboBoxEstado.Refresh();
            comboBoxLiquidaciones.Refresh();
            listBoxTiposLiquidacion.Refresh();
            listBoxTiposLiquidacion.ClearSelected();
        }

        /// <summary>
        /// Actualiza el estado de seleccion de los tipos de liquidacion seleccionados, para su posterior uso
        /// </summary>
        public void GrabarTipoSeleccionados()
        {
            foreach (DataRowView item in this.listBoxTiposLiquidacion.Items)
            {
                Model.DB.ejecutarProceso(Model.TipoComando.SP,
                    "liquidacionesPorTipoActualizarSeleccionado",
                    "idLiquidacion", this.LiquidacionId,
                    "idTipoLiquidacion", item[0],
                    "seleccionado", listBoxTiposLiquidacion.GetSelected(listBoxTiposLiquidacion.Items.IndexOf(item))
                    );
            }
        }
        #endregion
      }
}
