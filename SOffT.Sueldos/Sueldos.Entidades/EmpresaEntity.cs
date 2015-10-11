/*  
    EmpresaEntity.cs

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
using System.Data.Common;

namespace Sueldos.Entidades
{
    public class EmpresaEntity
    {
        private int idEmpresa;
        private string razonSocial;
        private string cuit;
        private string domicilio;
        private int ultimaRubrica;
        private Boolean correspondeReduccion;
        private int codigoActividad;
        private int tipoEmpleador;
        private double porcentajeAlicuotaLRT;
        private double cuotaFijaLRT;
        private string pais;
        private string provincia;
        private string localidad;
        private byte[] imagen;
        private string actividad;


        public int IdEmpresa
        {
            get { return idEmpresa; }
            set { idEmpresa = value; }
        }

        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }

        public string CUIT
        {
            get { return cuit; }
            set { cuit = value; }
        }

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public int UltimaRubrica
        {
            get { return ultimaRubrica; }
            set { ultimaRubrica = value; }
        }

        public Boolean CorrespondeReduccion
        {
            get { return correspondeReduccion; }
            set { correspondeReduccion = value; }
        }

        public int CodigoActividad
        {
            get { return codigoActividad; }
            set { codigoActividad = value; }
        }

        /// <summary>
        /// Devuelve la descripcion del la actividad de la empresa
        /// </summary>
        public string Actividad
        {
            get { return actividad; }
            set { actividad = value; }
        }


        public int TipoEmpleador
        {
            get { return tipoEmpleador; }
            set { tipoEmpleador = value; }
        }

        public double PorcentajeAlicuotaLRT
        {
            get { return porcentajeAlicuotaLRT; }
            set { porcentajeAlicuotaLRT=value;}
        }

        public double CuotaFijaLRT
        {
            get { return cuotaFijaLRT; }
            set { cuotaFijaLRT = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public byte[] Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }



        /// <summary>
        /// Constructor Empresa, carga datos de empresa existente.
        /// </summary>
        /// <param name="idEmpresa"></param>
        public EmpresaEntity(int idEmpresa)
        {
            this.idEmpresa = idEmpresa;
        }


    }
}
