/*  
    PersonaEntity.cs

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
    public abstract class PersonaEntity
    {
        private int idPersona;
        private string nombre;
        private string domicilio;
        private int idPais;
        private int idProvincia;
        private int idLocalidad;
        private string cp;
        private string telefono;
        private string telefonoMensajes;
        private int idTipoDocumento;
        private string numeroDocumento;
        private DateTime fechaNacimiento;
        private int idEstadoCivil;
        private string foto;
        private int idSexo;
        private int idNacionalidad;

        /// <summary>
        /// constructor vacio
        /// </summary>
        public PersonaEntity() 
        {
            this.cp = "";
            this.telefono = "";
            this.telefonoMensajes = "";
            this.numeroDocumento = "";
            this.foto = "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersona"></param>
        public PersonaEntity(int idPersona)
        {
            this.idPersona = idPersona;
        }

        public PersonaEntity(int idPersona, string nombre, string domicilio, int idPais,
            int idProvincia,int idLocalidad, string cp, string telefono, string telefonoM,
            int idTipoDocumento, string numeroDocumento, DateTime fechaNacimiento, 
            int idEstadoCivil, string foto, int idSexo, int idNacionalidad)
        {
            this.idPersona = idPersona;
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.idPais = idPais;
            this.idProvincia = idProvincia;
            this.idLocalidad = idLocalidad;
            this.cp = cp;
            this.telefono = telefono;
            this.telefonoMensajes = telefonoM;
            this.idTipoDocumento = idTipoDocumento;
            this.numeroDocumento = numeroDocumento;
            this.fechaNacimiento = fechaNacimiento;
            this.idEstadoCivil = idEstadoCivil;
            this.foto = foto;
            this.idSexo = idSexo;
            this.idNacionalidad = idNacionalidad;
        }

        /// <summary>
        /// constructor pequeño, en principio para instancias de familiares
        /// </summary>
        /// <param name="idPersona"></param>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="idTipoDocumento"></param>
        /// <param name="tipoDocumento"></param>
        /// <param name="numeroDocumento"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="idEstadoCivil"></param>
        /// <param name="idSexo"></param>
        /// <param name="idNacionalidad"></param>
    /*    public PersonaEntity(int idPersona, int legajo, string nombre, 
            int idTipoDocumento, string numeroDocumento, DateTime fechaNacimiento,
            int idEstadoCivil, int idSexo, int idNacionalidad)
        {
            this.idPersona = idPersona;
            this.legajo = legajo;
            this.nombre = nombre;
            this.idTipoDocumento = idTipoDocumento;
            this.numeroDocumento = numeroDocumento;
            this.fechaNacimiento = fechaNacimiento;
            this.idEstadoCivil = idEstadoCivil;
            this.idSexo = idSexo;
            this.idNacionalidad = idNacionalidad;
        }*/

    /*    public virtual void muestraDatos()
        {
            System.Console.WriteLine(this.idPersona);
            System.Console.WriteLine(this.legajo);
            System.Console.WriteLine(this.nombre);
            System.Console.WriteLine(this.numeroDocumento);
            System.Console.WriteLine(this.fechaNacimiento);
        }*/

        public int IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
        public int IdPais
        {
            get { return idPais; }
            set { idPais = value; }
        }
        public int IdProvincia
        {
            get { return idProvincia; }
            set { idProvincia = value; }
        }
        public int IdLocalidad
        {
            get { return idLocalidad; }
            set { idLocalidad = value; }
        }
        public string CP
        {
            get { return cp; }
            set { this.cp = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string TelefonoMensajes
        {
            get { return telefonoMensajes; }
            set { telefonoMensajes = value; }
        }
        public int IdTipoDocumento
        {
            get { return idTipoDocumento; }
            set { idTipoDocumento = value; }
        }

        public string NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public int IdEstadoCivil
        {
            get { return idEstadoCivil; }
            set { idEstadoCivil = value; }
        }
        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }
        public int IdSexo
        {
            get { return idSexo; }
            set { idSexo = value; }
        }
        public int IdNacionalidad
        {
            get { return idNacionalidad; }
            set { idNacionalidad = value; }
        }



    }
}
