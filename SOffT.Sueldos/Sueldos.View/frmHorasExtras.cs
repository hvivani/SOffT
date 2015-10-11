using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Sofft.ViewComunes;

namespace Sueldos.View
{
    public partial class frmHorasExtras : Form
    {
        public frmHorasExtras()
        {
            InitializeComponent();
            this.dtpDesde.Value = System.DateTime.Now;
            this.dtpHasta.Value = System.DateTime.Now;
            this.actualizarGrilla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int leg = 0;
            this.pbProceso.Value = 0;
            this.pbProceso.Maximum= (int)Model.DB.ejecutarScalar(Model.TipoComando.SP, "relojConsultarFichadasCantidadParaHorasExtras", "@desde", this.dtpDesde.Value.ToShortDateString(), "@hasta", this.dtpHasta.Value.ToShortDateString());
            System.Data.Common.DbDataReader rs = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "relojConsultarFichadasParaHorasExtras", "@desde", this.dtpDesde.Value.ToShortDateString() , "@hasta", this.dtpHasta.Value.ToShortDateString() );
            while (rs.Read()) //recorro fechas
            {
                leg = Convert.ToInt32(rs["legajo"]);
                Console.WriteLine("registro: " + leg.ToString());
                this.procesaDia(Convert.ToDateTime(rs["fecha"]), leg);

                System.Windows.Forms.Application.DoEvents();
            }
            rs.Close();
            Model.DB.desconectarDB();
            //this.procesaDia(Convert.ToDateTime("02/06/2008"),151);
            this.actualizarGrilla();
            MessageBox.Show("fin del proceso.");
        }


        /// <summary>
        /// Procesa las fichadas de un dia de un legajo tratando de obtener el total
        /// de horas extras trabajadas
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="legajo"></param>
        private void procesaDia(DateTime fecha, int legajo)
        {
            int horaEntrada = 0;
            int horaSalida = 0;
            int limiteDia = 0;
            int minutosExtras=0;
            int horaDesde = 0;
            int horaHasta = 0;
            int idTipoHoraExtra=0;
            int cont = 1;
            int idDia;

            double limiteHs50 = 0;
            limiteHs50 = this.consultaLimiteHs50();

         //   Model.DB.Enlazado = true;
            System.Data.Common.DbDataReader rs= Model.DB.ejecutarDataReader(Model.TipoComando.SP, "relojConsultarFichadasFechaEnMinutos", "@legajo", legajo, "@fecha", fecha);
            System.Data.Common.DbDataReader rsHorasExtrasDefiniciones = null;
            //limpio horas extras del legajo antes de procesar
            Console.WriteLine("eliminando registro: " + legajo + " fecha: " + fecha);
            Model.DB.ejecutarProceso(Model.TipoComando.SP, "horasExtrasEliminar", "@legajo", legajo, "@fecha", fecha);
            //determino dia de la semana. siempre 0-dom/6-sab
            idDia = (int)fecha.DayOfWeek;
         
            if (rs.HasRows)
            {

                while (rs.Read()) //recorro fichadas del dia
                {
                    this.pbProceso.Value += 1;

                    if (Convert.ToInt32(rs["limiteDia"]) == 24)
                    {
                        //horaEntrada = Convert.ToInt32(rs["minutos"]);
                        horaEntrada = 24 * 60 - horaSalida;
                    }
                    else
                    {
                        if (Convert.ToInt32(rs["minutos"]) < 0)
                            horaEntrada = Convert.ToInt32(rs["minutos"]);
                        if (Convert.ToInt32(rs["minutos"]) > 0)
                            horaSalida = Convert.ToInt32(rs["minutos"]);
                    }
                    if (horaEntrada < 0)
                        horaEntrada = -1 * horaEntrada;
                    if (horaSalida < 0)
                        horaSalida = -1 * horaSalida;
                    
                    if (cont % 2 == 0)  //solo cuando es par verifico
                    {

                        rsHorasExtrasDefiniciones = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "horasExtrasDefinicionesConsultarDia", "@idDia", idDia);
                        while (rsHorasExtrasDefiniciones.Read()) //recorro deficiones de hs. extras para ese dia
                        {
                            if (this.verificaSiFeriado(fecha))
                            {
                                limiteDia = 0;
                                horaDesde = 0;      //00:00:00
                                horaHasta = 1440;   //24:00:00
                                idTipoHoraExtra = 89;
                            }
                            else
                            {
                                limiteDia = Convert.ToInt32(rsHorasExtrasDefiniciones["limiteDia"]);
                                horaDesde = pasaAminutos(Convert.ToDateTime(rsHorasExtrasDefiniciones["horaDesde"]));
                                horaHasta = pasaAminutos(Convert.ToDateTime(rsHorasExtrasDefiniciones["horaHasta"]));
                                idTipoHoraExtra = Convert.ToInt32(rsHorasExtrasDefiniciones["idTipoHoraExtra"]);
                            }

                            if (horaEntrada > horaSalida) //(limiteDia == 24) //&& (horaEntrada>=horaDesde))
                            {
                                //minutosExtras = this.obtieneMinutosExtras(horaDesde, 24*60, 24*60-horaSalida, 24*60);
                                minutosExtras = this.obtieneMinutosExtras(horaDesde, 24 * 60, horaEntrada, 24 * 60);
                                //minutosExtras += this.obtieneMinutosExtras(0, horaHasta, 0, horaEntrada); 
                                minutosExtras += this.obtieneMinutosExtras(0, horaHasta, 0, horaSalida);
                            }
                            else
                            {   //en caso de nocturnas no definidas en el horario del empleado
                                if (horaDesde > horaHasta)
                                    minutosExtras = this.obtieneMinutosExtras(0, horaHasta, horaEntrada, horaSalida);
                                else
                                    minutosExtras = this.obtieneMinutosExtras(horaDesde, horaHasta, horaEntrada, horaSalida);
                            }

                            //horas al 50% Lu a Vi > 10 Hs (540 min)
                            if (idDia >= 1 && idDia <= 5 && idTipoHoraExtra == 80)
                            {
                                if (minutosExtras > limiteHs50 * 60)
                                    minutosExtras = (int)(minutosExtras - (limiteHs50 * 60));
                                else
                                    minutosExtras = 0;
                            }

                            Console.WriteLine("total id: " + Convert.ToInt32(rsHorasExtrasDefiniciones["id"]) + " minutos extras: " + minutosExtras.ToString());
                            Console.WriteLine("insertando registro: " + legajo + " tipo Hora: " + idTipoHoraExtra);
                            if (minutosExtras>0)
                                Model.DB.ejecutarProceso(Model.TipoComando.SP, "horasExtrasActualizar", "@legajo",legajo,"@fecha", fecha,"@idTipoHoraExtra", idTipoHoraExtra,"cantidad", minutosExtras);
                            Thread.Sleep(100); //OJO PARA CONTROLAR timeout
                        }
                        rsHorasExtrasDefiniciones.Close();
                        Model.DB.desconectarDB();
                        
                    }
                    cont++;
                }
                rs.Close();
                Model.DB.desconectarDB();
               // Model.DB.Enlazado = false;
            }
            
        }

        //pasa una hora a minutos
        private int pasaAminutos(DateTime hora)
        {
            int min=0;
            min= hora.Hour * 60 + hora.Minute ;
            return min;
        }


        private int obtieneMinutosExtras(int horaDesde, int horaHasta, int horaEntrada, int horaSalida)
        {
            int minutos = 0;
            if (horaDesde <= horaEntrada && horaHasta >= horaSalida)
                minutos = horaSalida - horaEntrada;
            if (horaDesde >= horaEntrada && horaHasta >= horaSalida)
                minutos = horaSalida - horaDesde;
            if (horaDesde < horaEntrada && horaHasta < horaSalida)
                minutos = horaHasta - horaEntrada;
            if (horaDesde > horaEntrada && horaHasta < horaSalida) //&& horaDesde < horaHasta )
                minutos = horaHasta - horaDesde;
            if (horaDesde > horaEntrada && horaHasta < horaSalida) //&& horaDesde > horaHasta)
                minutos = horaHasta - horaEntrada;
            //if (horaDesde == 0 && horaEntrada == 0 && horaHasta > horaSalida )
            //    minutos = horaHasta - horaSalida;
            if (minutos<0)
                minutos=0;
            return minutos;
        }

        private void actualizarGrilla()
        {
            Controles.cargaDataGridView(this.dgvHorasExtras, "horasExtrasConsultar", "@desde",this.dtpDesde.Value.ToShortDateString(),"@hasta",this.dtpHasta.Value.ToShortDateString());
            Controles.setEstandarDataGridView(this.dgvHorasExtras);
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            this.actualizarGrilla();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            this.actualizarGrilla();
        }

        private Boolean verificaSiFeriado(DateTime fecha)
        {
            Boolean salida=false;
            System.Data.Common.DbDataReader rsFer = Model.DB.ejecutarDataReader(Model.TipoComando.SP,"tablasConsultarContenidoYdetalle", "@tabla", "Feriados", "@indice", fecha.Year.ToString() + fecha.Month.ToString().PadLeft(2,'0'));
            while (rsFer.Read())
            {
                if (Convert.ToInt32(rsFer["contenido"]) == fecha.Day)
                    salida = true;

            }
            Model.DB.desconectarDB();
            return salida;
        }

        private double consultaLimiteHs50 ()
        {
            double salida=0;
            System.Data.Common.DbDataReader rslim = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "tablasConsultarContenidoYdetalle", "@tabla", "horasextras", "@indice", 11);
            while (rslim.Read())
            {
               salida=Convert.ToDouble(rslim["contenido"]);
            }
            Model.DB.desconectarDB();
            return salida;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvHorasExtras.RowCount > 0)
            {
                savefileDexcel.Filter = "EXCEL XLS (*.xls)|*.xls";
                savefileDexcel.FileName = "";

                //if (savefileDexcel.ShowDialog() == DialogResult.OK)
                //{
                    Cursor.Current = Cursors.WaitCursor;
                    //empleado.Foto = openFileDialogFoto.FileName;
                    DataSet ds = new DataSet();
                    ds.Merge((DataTable)this.dgvHorasExtras.DataSource);
                    Model.DataSetTo.XLS(ds,"HorasExtras.xls");
                    //exportarAexcel.exportar(ds, savefileDexcel.FileName);
                    Cursor.Current = Cursors.Default;
                //}
            }

            MessageBox.Show("La exportación finalizó con éxito.");

        }
    }
}