/*  
    formulaConcepto.cs

    Author:
    Claudio Rodrigo Pereyra Diaz <claudiorodrigo@pereyradiaz.com.ar>
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

namespace Sueldos.View
{
    class FormulaConcepto
    {
        private Queue<string> formulaCompilador;

        public FormulaConcepto()
        {
            formulaCompilador = new Queue<string>();
        }

        public string CadenaCompilador
        {
            get
            {
                string cadena = "";
                foreach (string elemento in formulaCompilador)
                { cadena = cadena + elemento + " "; }
                return cadena;
            }
            set
            {
                String[] expresiones;
                expresiones = value.Split(" ".ToCharArray());
                for (int i = 0; i < expresiones.Length; i++)
                { formulaCompilador.Enqueue(expresiones[i]); }
            }
        }

        public string CadenaNatural
        {
            get
            {
                string cadena = "";
                foreach (string elemento in formulaCompilador)
                { cadena = cadena + this.traducir(elemento) + " "; }
                return cadena;
            }
        }

        private string traducir(string instruccion)
        {
            switch (instruccion)
            {
                case "?": return "entonces";
                case ":": return "sino";
                case "||": return "o";
                case "&&": return "y";
                case "<>": return "disntinto de";
                case ">=": return "mayor o igual que";
                case "<=": return "menor o igual que";
                case ">": return "mayor que";
                case "<": return "menor que";
                case "+": return instruccion;
                case "-": return instruccion;
                case "/": return instruccion;
                case "*": return instruccion;
                case "(": return instruccion;
                case ")": return instruccion;
                case ",": return instruccion;
                case "": return " ";
                case " ": return " ";
                default: return this.consultar(instruccion);
            }
        }

        private string consultar(string instrucion)
        {
            String[] cadena = instrucion.Split("(),\"".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            switch (cadena[0])
            {
                case "campoEmpleado":
                    return Model.DB.ejecutarScalar(Model.TipoComando.SP, "tablaConsultarDescipcion", "tabla", "empleadosSueldos", "indice", cadena[1]).ToString();
                case "variable":
                    return Model.DB.ejecutarScalar(Model.TipoComando.SP, "tablaConsultarDescipcion", "tabla", "VAR", "indice", cadena[1]).ToString();
                case "acumulador":
                    return Model.DB.ejecutarScalar(Model.TipoComando.SP, "tablaConsultarDescipcion", "tabla", "ACU", "indice", cadena[1]).ToString();
                case "novedadEmpleado":
                    return Model.DB.ejecutarScalar(Model.TipoComando.SP, "tablaConsultarDescipcion", "tabla", "novedades", "indice", cadena[1]).ToString();
                case "tablas":
                    return Model.DB.ejecutarScalar(Model.TipoComando.SP, "tablaConsultarDescipcion", "tabla", cadena[1], "indice", cadena[2]).ToString();
                case "fechaEmpleado":
                    return Model.DB.ejecutarScalar(Model.TipoComando.SP, "tablaConsultarDescipcion", "tabla", "empleadosSueldos", "indice", cadena[1]).ToString();
                case "acumuladoEmpleado":
                    return Model.DB.ejecutarScalar(Model.TipoComando.SP, "tablaConsultarDescipcion", "tabla", "acumulados", "indice", cadena[1]).ToString();
                case "asistenciaEmpleadoEntreDias":
                    return Model.DB.ejecutarScalar(Model.TipoComando.SP, "tablaConsultarDescipcion", "tabla", "asistencia", "indice", cadena[1]).ToString()
                        + " entre " + cadena[2] + " y " + cadena[3];
                case "acumuladoMayorEntreFechas":
                    return Model.DB.ejecutarScalar(Model.TipoComando.SP, "tablaConsultarDescipcion", "tabla", "acumulados", "indice", cadena[1]).ToString()
                        + " entre " + cadena[2] + " y " + cadena[3];
                case "saltar":
                    return cadena[0] + " a ";
                       // + Model.DB.ejecutarDataSet(Model.TipoComando.SP, "calculoConsultarDescripcion", "idCalculo", cadena[1]).Tables[0].ToString();
                default: return instrucion;
            }
        }

        public void Agregar(string valor)
        { formulaCompilador.Enqueue(valor); }

        public string Quitar()
        { return formulaCompilador.Dequeue(); }
    }
}
