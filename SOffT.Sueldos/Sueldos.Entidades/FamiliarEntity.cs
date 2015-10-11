/*  
    FamiliarEntity.cs

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
    public class FamiliarEntity
    {
        private int legajo;
        private int idFamiliar;
        private string apellidoYnombres;
        private int idParentesco;
        private string parentesco;
        private int idTipoDocumento;
        private string tipoDocumento;
        private string numeroDocumento;
        private DateTime fechaNacimiento;
        private DateTime fechaAlta;
        private DateTime fechaBaja;
        private int idSexo;
        private string sexo;
        private int idNacionalidad;
        private string nacionalidad;
        private int idEstadoCivil;
        private string estadoCivil;
        private bool generaSalario;
        private bool declaradoParaGanancias;

        public FamiliarEntity() { }

    /*    public Familiar(int idPersona, int legajo, string nombre, 
            int idTipoDocumento, string numeroDocumento, DateTime fechaNacimiento, 
            int idEstadoCivil, int idSexo, int idNacionalidad, int idFamiliar,  int idParentesco,
            DateTime fechaAlta, DateTime fechaBaja,bool generaSalario)
            :base(idPersona, legajo, nombre, idTipoDocumento, numeroDocumento, fechaNacimiento, idEstadoCivil, 
            idSexo, idNacionalidad)
        {
            this.idFamiliar = idFamiliar;
            this.idParentesco = idParentesco;
            this.fechaAlta = fechaAlta;
            this.fechaBaja = fechaBaja;
            this.generaSalario = generaSalario;
        }*/


        public FamiliarEntity(int legajo, int idFamiliar,string apellidoYnombres, int idParentesco,
            string parentesco, int idTipoDocumento, string tipoDocumento, string numeroDocumento, 
            DateTime fechaNacimiento, DateTime fechaAlta, DateTime fechaBaja,
            int idSexo, string sexo, int idNacionalidad, string nacionalidad, int idEstadoCivil,
            string EstadoCivil, bool generaSalario, bool declaradoParaGanancias)
        {
            this.legajo = legajo;
            this.idFamiliar = idFamiliar;
            this.apellidoYnombres = apellidoYnombres;
            this.idParentesco = idParentesco;
            this.parentesco = parentesco;
            this.idTipoDocumento = idTipoDocumento;
            this.tipoDocumento = tipoDocumento;
            this.numeroDocumento = numeroDocumento;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaAlta = fechaAlta;
            this.fechaBaja = fechaBaja;
            this.idSexo = idSexo;
            this.sexo = sexo;
            this.idNacionalidad = idNacionalidad;
            this.nacionalidad = nacionalidad;
            this.idEstadoCivil = idEstadoCivil;
            this.EstadoCivil = EstadoCivil;
            this.generaSalario = generaSalario;
            this.declaradoParaGanancias = declaradoParaGanancias;
        }

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public int IdFamiliar
        {
            get { return idFamiliar; }
            set { idFamiliar = value; }
        }

        public string ApellidoYnombres
        {
            get { return apellidoYnombres; }
            set { apellidoYnombres = value; }
        }

        public int IdParentesco
        {
            get { return idParentesco; }
            set { idParentesco = value; }
        }
        public string Parentesco
        {
            get { return parentesco; }
            set { parentesco = value; }
        }

        public int IdTipoDocumento
        {
            get { return idTipoDocumento; }
            set { idTipoDocumento = value; }
        }

        public string TipoDocumento
        {
            get { return tipoDocumento; }
            set { tipoDocumento = value; }
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

        public DateTime FechaAlta
        {
            get { return fechaAlta; }
            set { fechaAlta = value; }
        }
        public DateTime FechaBaja
        {
            get { return fechaBaja; }
            set { fechaBaja = value; }
        }

        public int IdSexo
        {
            get { return idSexo; }
            set { idSexo = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public int IdNacionalidad
        {
            get { return idNacionalidad; }
            set { idNacionalidad = value; }
        }

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }

        public int IdEstadoCivil
        {
            get { return idEstadoCivil; }
            set { idEstadoCivil = value; }
        }

        public string EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        public bool GeneraSalario
        {
            get { return generaSalario; }
            set { generaSalario = value; }
        }

        public bool DeclaradoParaGanancias
        {
            get { return declaradoParaGanancias; }
            set { declaradoParaGanancias = value; }
        }
    }

}



















