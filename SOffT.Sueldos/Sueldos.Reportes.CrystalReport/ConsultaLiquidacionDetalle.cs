using System;
using System.Collections.Generic;
using System.Text;
using Sueldos.Data;
using Sueldos.Entidades;

namespace Sueldos.Modelo
{
    public class ConsultaLiquidacionDetalle
    {
        public ConsultaLiquidacionDetalle() { }

        public int insert(LiquidacionDetalleEntity liqdet)
        {
            using (var liquidacionDetalleData = new LiquidacionDetalleData())
            {
                return liquidacionDetalleData.insert(liqdet);
            }
        }

        public int update(LiquidacionDetalleEntity liqdet)
        {
            using (LiquidacionDetalleData liquidacionDetalleData = new LiquidacionDetalleData())
            {
                return liquidacionDetalleData.update(liqdet);
            }
        }

        public int delete(LiquidacionDetalleEntity liqdet)
        {
            using (LiquidacionDetalleData liquidacionDetalleData = new LiquidacionDetalleData())
            {
                return liquidacionDetalleData.delete(liqdet);
            }
        }

        public int insertarFechasDePago(List<FechaDePagoEntity> fechas)
        {
            using (LiquidacionDetalleData liquidaciondetalleData = new LiquidacionDetalleData())
            {
                return liquidaciondetalleData.insertFechasDePago(fechas);
            }
        }

        public LiquidacionDetalleEntity getById(int aniomes, int idAplicacion, DateTime fechaLiquidacion)
        {
            LiquidacionDetalleEntity liqdet;
            using (var liquidacionDetalleData = new LiquidacionDetalleData())
            {
                liqdet = liquidacionDetalleData.getById(aniomes,idAplicacion,fechaLiquidacion);
            }
            return liqdet;
        }

        public LiquidacionDetalleEntity getById(int id)
        {
            LiquidacionDetalleEntity liqdet;
            using (var liquidacionDetalleData = new LiquidacionDetalleData())
            {
                liqdet = liquidacionDetalleData.getById(id);
            }
            return liqdet;
        }

        /// <summary>
        /// Consulta si una liquidación por estado y aniomes. Devuelve el id o cero si no la encuentra
        /// </summary>
        /// <returns></returns>
        public int getIdByEstado(int aniomes, int estado)
        {
            int id=0;
            using (var liquidacionDetalleData = new LiquidacionDetalleData())
            {
                id = liquidacionDetalleData.getIdByEstado(aniomes,estado);
            }
            return id;
        }

        public List<LiquidacionDetalleEntity> getByEstado(int estado)
        {
            using (var liquidacionDetalleData = new LiquidacionDetalleData())
            {
                List<LiquidacionDetalleEntity> liquidaciones = liquidacionDetalleData.getByEstado(estado);
                return liquidaciones;
            }
        }

        public System.Data.DataSet getAllGrilla()
        {
            System.Data.DataSet ds = null;
            using (var liquidaciondetalleData = new LiquidacionDetalleData())
            {
                ds = liquidaciondetalleData.GetAllGrilla();
            }
            return ds;
        }


    }
}
