/*  
    CUIL.cs

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

namespace Sueldos.View
{
    /// <summary>
    /// Clase estatica para manipular un numero de CUIL/CUIT
    /// </summary>
    static class CUIL
    {
        /// <summary>
        /// Valida el numero de CUIL/CUIT recalculando el digito verificador
        /// </summary>
        /// <param name="cuit">Numero de CUIL/CUIT</param>
        /// <returns>Verdadero si es valido, Falso si es invalido</returns>
        public static Boolean Validar(string cuil)
        {
            Double resto;
            Double suma;
            Double cociente;
            //Limpio el cuit
            cuil = CUIL.Limpiar(cuil);
            if (cuil.Length == 11)
            {
                suma = char.GetNumericValue(cuil[0]) * 5;
                suma = suma + char.GetNumericValue(cuil[1]) * 4;
                suma = suma + char.GetNumericValue(cuil[2]) * 3;
                suma = suma + char.GetNumericValue(cuil[3]) * 2;
                suma = suma + char.GetNumericValue(cuil[4]) * 7;
                suma = suma + char.GetNumericValue(cuil[5]) * 6;
                suma = suma + char.GetNumericValue(cuil[6]) * 5;
                suma = suma + char.GetNumericValue(cuil[7]) * 4;
                suma = suma + char.GetNumericValue(cuil[8]) * 3;
                suma = suma + char.GetNumericValue(cuil[9]) * 2;
                suma = suma * 10;
                cociente = suma / 11;
                resto = suma - (int)cociente * 11;
                return !(resto != char.GetNumericValue(cuil[10]) || cociente == 0);
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Limpia una cadena de CUIL/CUIT eliminando todo caracter no numericos
        /// </summary>
        /// <param name="cuit">Numero de CUIL/CUIT</param>
        /// <returns>Cadena de numeros que representa el CUIL/CUIT</returns>
        public static string Limpiar(string cuil)
        {
            cuil = cuil.Replace("-", "");
            return cuil;
        }

        /// <summary>
        /// busca el digito verificador dado el pre que es determinado por el sexo.
        /// Masculino=20, si no da con 20, pasa a ser 23
        /// Femenino=27, si no da con 20, pasa a ser 23
        /// </summary>
        /// <param name="pre"></param>
        /// <param name="dni"></param>
        /// <returns></returns>
        public static string buscarDigitoVerificador(string pre, string dni)
        {
            string cuil = "";
            string cad = "";
            Boolean ok = false;
            for (int j = 0; j < 10; j++)
            {
                cad = pre.PadLeft(2, '0') + dni + j.ToString();
                ok = CUIL.Validar(cad);
                if (ok)
                    cuil = cad;
            }
            return cuil;
        }


        public static string generar(char sexo, string dni)
        {
            string cuil = "";
            if (sexo == 'F')
            {
                cuil = CUIL.buscarDigitoVerificador("27", dni);
                if (cuil == "")
                {
                    cuil = CUIL.buscarDigitoVerificador("23", dni);
                }
            }
            if (sexo == 'M')
            {
                cuil = CUIL.buscarDigitoVerificador("20", dni);
                if (cuil == "")
                {
                    cuil = CUIL.buscarDigitoVerificador("23", dni);
                }
            }
            if (sexo == 'E')  //en caso de empresas, el CUIT es:
            {
                cuil = CUIL.buscarDigitoVerificador("30", dni);
                if (cuil == "")
                {
                    cuil = CUIL.buscarDigitoVerificador("33", dni);
                }
            }
            return cuil;
        }
    }
}
