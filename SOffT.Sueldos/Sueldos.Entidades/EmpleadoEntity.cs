/*  
    EmpleadoEntity.cs

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
using System.Data;
using System.Data.Common;

namespace Sueldos.Entidades
{
    /// <summary>
    /// Esta clase maneja los empleados. El concepto es que la persona existe 
    /// en la tabla empleados. y el empleado se maneja del maestro de sueldos
    /// </summary>
    public class EmpleadoEntity:PersonaEntity
    {
        private int legajo;
        private string cuil;
        private int idAFJP;
        private DateTime fechaIngreso;
        private DateTime fechaReconocimiento;
        private DateTime fechaEgreso;
        private DateTime fechaReIngreso;
        private double sueldoOjornal;
        private int idEstado;
        private int idTipoLiquidacion;
        private int idCausaEgreso;
        private int idCategoria;
        private int idContrato;
        private int idConvenio;
        private int idSindicato;
        private int idPuesto;
        private int idArea;
        private int idCentroDeCosto;
        private int idSucursalBanco;
        private int idBanco;
        private string numeroCuenta;
        private int idFormaDePago;
        private int idObraSocial;
        private int legajoDelConyuge;
        private int idSituacionDeRevista;
        private int idCodigoDeCondicion;
        private int idCodigoDeActividad;
        private int idModalidadDeContratacion;
        private int idCodigoDeSiniestrado;
        private List<CampoEmpleadoEntity> otrosCampos;
        private List<FamiliarEntity> familiares;
        private List<PeriodoTrabajadoEntity> periodos;
        private List<HorarioEntity> horarios;
        private List<VacacionEntity> vacaciones;

   
        /// <summary>
        /// constructor vacio
        /// </summary>
        public EmpleadoEntity() 
        {
            this.cuil = "";
            this.numeroCuenta = "";
            this.otrosCampos = new List<CampoEmpleadoEntity>();
            this.familiares = new List<FamiliarEntity>();
            this.periodos = new List<PeriodoTrabajadoEntity>();
            this.horarios = new List<HorarioEntity>();
            this.vacaciones = new List<VacacionEntity>();
        }

        /// <summary>
        /// Constructor para cargar datos. base.idPersona=idEmpleado
        /// </summary>
        /// <param name="idPersona"></param>
        public EmpleadoEntity(int idEmpleado):base(idEmpleado)
        {
            this.cuil = "";
            this.numeroCuenta = "";
            this.otrosCampos = new List<CampoEmpleadoEntity>();
            this.familiares = new List<FamiliarEntity>();
            this.periodos = new List<PeriodoTrabajadoEntity>();
            this.horarios = new List<HorarioEntity>();
            this.vacaciones = new List<VacacionEntity>();
        }


        /// <summary>
        /// Constructor para cargar datos de un empleado nuevo.
        /// </summary>
        /// <param name="idPersona"></param>
        /// <param name="nombre"></param>
        /// <param name="domicilio"></param>
        /// <param name="idPais"></param>
        /// <param name="idProvincia"></param>
        /// <param name="idLocalidad"></param>
        /// <param name="cp"></param>
        /// <param name="telefono"></param>
        /// <param name="telefonoM"></param>
        /// <param name="idTipoDocumento"></param>
        /// <param name="numeroDocumento"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="idEstadoCivil"></param>
        /// <param name="foto"></param>
        /// <param name="legajo"></param>
        /// <param name="cuil"></param>
        /// <param name="idAFJP"></param>
        /// <param name="fechaIngreso"></param>
        /// <param name="fechaEgreso"></param>
        /// <param name="sueldoOjornal"></param>
        /// <param name="idEstado"></param>
        /// <param name="idTipoLiquidacion"></param>
        /// <param name="idCausaEgreso"></param>
        /// <param name="idCategoria"></param>
        /// <param name="idContrato"></param>
        /// <param name="idConvenio"></param>
        /// <param name="idPuesto"></param>
        /// <param name="idArea"></param>
        /// <param name="idCentroDeCosto"></param>
        /// <param name="idBanco"></param>
        /// <param name="numeroCuenta"></param>
        /// <param name="idObraSocial"></param>
        public EmpleadoEntity(int idPersona, int legajo, string nombre, string domicilio, int idPais,
            int idProvincia,int idLocalidad, string cp, string telefono, string telefonoM,
            int idTipoDocumento, string numeroDocumento, DateTime fechaNacimiento, int idEstadoCivil,
            string foto, int idSexo, int idNacionalidad, string cuil, int idAFJP, DateTime fechaReconocimiento, 
            DateTime fechaIngreso, DateTime fechaEgreso, DateTime fechaReIngreso,
            double sueldoOjornal, int idEstado, int idTipoLiquidacion, int idCausaEgreso, 
            int idCategoria, int idContrato, int idConvenio, int idSindicato, int idPuesto, int idArea,
            int idCentroDeCosto, int idSucursalBanco, int idBanco, string numeroCuenta, int idFormaDePago, int idObraSocial, int legajoDelConyuge,
            int idSituacionDeRevista, int idCodigoDeCondicion, int idCodigoDeActividad, int idModalidadDeContratacion, 
            int idCodigoDeSiniestrado)
            :base(idPersona, nombre, domicilio, idPais, idProvincia, idLocalidad, cp, 
            telefono, telefonoM, idTipoDocumento, numeroDocumento, fechaNacimiento, idEstadoCivil, foto,
            idSexo, idNacionalidad)
        {
            this.legajo = legajo;
            this.cuil = cuil ;
            this.idAFJP = idAFJP;
            this.fechaReconocimiento = fechaReconocimiento;
            this.fechaIngreso = fechaIngreso;
            this.fechaEgreso = fechaEgreso;
            this.fechaReIngreso = fechaReIngreso;
            this.sueldoOjornal = sueldoOjornal;
            this.idEstado = idEstado;
            this.idTipoLiquidacion = idTipoLiquidacion;
            this.idCausaEgreso = idCausaEgreso;
            this.idCategoria = idCategoria;
            this.idContrato =idContrato;
            this.idConvenio = idConvenio;
            this.idSindicato = idSindicato;
            this.idPuesto = idPuesto;
            this.idArea = idArea;
            this.idCentroDeCosto = idCentroDeCosto;
            this.idSucursalBanco = idSucursalBanco;
            this.idBanco = idBanco;
            this.idFormaDePago = idFormaDePago;
            this.numeroCuenta = numeroCuenta;
            this.idObraSocial = idObraSocial;
            this.legajoDelConyuge = legajoDelConyuge;
            this.idSituacionDeRevista=idSituacionDeRevista;
            this.idCodigoDeCondicion = idCodigoDeCondicion;
            this.idCodigoDeActividad=idCodigoDeActividad;
            this.idModalidadDeContratacion=idModalidadDeContratacion;
            this.idCodigoDeSiniestrado=idCodigoDeSiniestrado;
            this.otrosCampos = new List<CampoEmpleadoEntity>();
            this.periodos = new List<PeriodoTrabajadoEntity>();
            this.horarios = new List<HorarioEntity>();
            this.vacaciones = new List<VacacionEntity>();
        }

        public int Legajo
        {
            get { return this.legajo; }
            set { legajo = value; }
        }

        public DateTime FechaReconocimiento
        {
            get { return fechaReconocimiento; }
            set { fechaReconocimiento = value; }
        }

        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }
        public DateTime FechaEgreso
        {
            get { return fechaEgreso; }
            set { fechaEgreso = value; }
        }
        public DateTime FechaReIngreso
        {
            get { return fechaReIngreso; }
            set { fechaReIngreso = value; }
        }

        public int IdAFJP
        {
            get { return idAFJP; }
            set { idAFJP = value; }
        }
        public string CUIL
        {
            get { return cuil; }
            set { cuil = value; }
        }
        public double SueldoOjornal
        {
            get { return sueldoOjornal; }
            set { sueldoOjornal = value; }
        }
        public int IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }
        public int IdTipoLiquidacion
        {
            get { return idTipoLiquidacion; }
            set { idTipoLiquidacion = value; }
        }
        public int IdCausaEgreso
        {
            get { return idCausaEgreso; }
            set { idCausaEgreso = value; }
        }
        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }
        public int IdContrato
        {
            get { return idContrato; }
            set { idContrato = value; }
        }
        public int IdConvenio
        {
            get { return idConvenio; }
            set { idConvenio = value; }
        }
        public int IdSindicato
        {
            get { return idSindicato; }
            set { idSindicato=value;}
        }
        public int IdPuesto
        {
            get { return idPuesto; }
            set { idPuesto = value; }

        }
        public int IdArea
        {
            get { return idArea; }
            set { idArea = value; }
        }
        public int IdCentroDeCosto
        {
            get { return idCentroDeCosto; }
            set { idCentroDeCosto = value; }
        }
        public int IdBanco
        {
            get { return idBanco; }
            set { idBanco = value; }
        }
        public string NumeroCuenta
        {
            get { return numeroCuenta; }
            set { numeroCuenta = value; }
        }

        public int IdSucursalBanco
        {
            get { return idSucursalBanco;}
            set { idSucursalBanco = value; }
        }

        public int IdFormaDePago
        {
            get { return idFormaDePago; }
            set { idFormaDePago = value; }
        }

        public int IdObraSocial
        {
            get { return idObraSocial; }
            set { idObraSocial = value; }
        }

        public int LegajoDelConyuge
        {
            get { return legajoDelConyuge; }
            set { legajoDelConyuge = value; }
        }

        public int IdSituacionDeRevista
        {
            get { return idSituacionDeRevista; }
            set { idSituacionDeRevista = value; }
        }

        public int IdCodigoDeCondicion
        {
            get { return idCodigoDeCondicion; }
            set { idCodigoDeCondicion = value; }
        }

        public int IdCodigoDeActividad
        {
            get { return idCodigoDeActividad; }
            set { idCodigoDeActividad = value; }
        }

        public int IdModalidadDeContratacion
        {
            get { return idModalidadDeContratacion; }
            set { idModalidadDeContratacion = value; }
        }

        public int IdCodigoDeSiniestrado
        {
            get { return idCodigoDeSiniestrado; }
            set { idCodigoDeSiniestrado = value; }
        }

        public List<CampoEmpleadoEntity> OtrosCampos
        {
            get { return this.otrosCampos; }
            set {}
        }

        public List<FamiliarEntity> Familiares
        {
            get { return this.familiares; }
            set { }
        }

        public List<PeriodoTrabajadoEntity> Periodos
        {
            get { return this.periodos; }
            set { }
        }

        public List<HorarioEntity> Horarios
        {
            get { return this.horarios; }
            set { }
        }

        public List<VacacionEntity> Vacaciones
        {
            get { return this.vacaciones; }
            set { }
        }




    }
}
