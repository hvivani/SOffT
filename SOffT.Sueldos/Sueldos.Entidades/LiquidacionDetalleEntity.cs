/*  
    LiquidacionDetalleEntity.cs

    Author:
    Hernan Vivani <hernan@vivani.com.ar> - http://hvivani.com.ar

    Copyright © SOffT 2010 - http://www.sofft.com.ar

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
using System.Text;

namespace Sueldos.Entidades
{
    public class LiquidacionDetalleEntity
    {
        public int Id { get; set; }
        public int AnioMes { get; set; }
        public int IdAplicacion { get; set; }
        public int IdTipoSalario { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaLiquidacion { get; set; }
        public string PeriodoLiquidado { get; set; }
        public string LugarDePago { get; set; }
        public List<FechaDePagoEntity> FechasDePago { get; set; }
        public string PeriodoDepositado { get; set; }
        public string BancoDepositado { get; set; }
        public DateTime FechaDepositado { get; set; }
        public Boolean Estado { get; set; }
        public Boolean RecibosSeparados { get; set; }
        public Boolean Eliminado { get; set; }

        public LiquidacionDetalleEntity(int id)
        {
            this.Id = id;
            this.FechasDePago = new List<FechaDePagoEntity>();
        }

        public LiquidacionDetalleEntity(int aniomes, int idAplicacion, DateTime fechaLiquidacion)
        {
            this.AnioMes = aniomes;
            this.IdAplicacion = idAplicacion;
            this.FechaLiquidacion = fechaLiquidacion;

            this.Id = 0;
            this.IdTipoSalario = 0;
            this.Descripcion = string.Empty;
            this.PeriodoLiquidado = string.Empty;
            this.LugarDePago = string.Empty;
            this.FechasDePago = new List<FechaDePagoEntity>();
            this.PeriodoLiquidado = string.Empty;
            this.BancoDepositado = string.Empty;
            this.FechaDepositado = DateTime.MinValue;
            this.Estado = false;
            this.RecibosSeparados = false;
            this.Eliminado = false;
        }

        public LiquidacionDetalleEntity()
        {
            this.Id = 0;
            this.AnioMes = 0;
            this.IdAplicacion = 0;
            this.IdTipoSalario = 0;
            this.Descripcion = string.Empty;
            this.FechaLiquidacion = DateTime.MinValue;
            this.PeriodoLiquidado = string.Empty;
            this.LugarDePago = string.Empty;
            this.FechasDePago = new List<FechaDePagoEntity>();
            this.PeriodoLiquidado = string.Empty;
            this.BancoDepositado = string.Empty;
            this.FechaDepositado = DateTime.MinValue;
            this.Estado = false;
            this.RecibosSeparados = false;
            this.Eliminado = false;
        }
    }
}
