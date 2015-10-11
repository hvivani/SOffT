/*  
    Varios.cs

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
using System.Windows.Forms;

namespace Sofft.Utils
{
    public class Varios
    {

        public enum DateInterval
        {
            Second, Minute, Hour, Day, Week, Month, Quarter, Year
        }

        public static long DateDiff(DateInterval Interval, System.DateTime StartDate, System.DateTime EndDate)
        {
            long lngDateDiffValue = 0;
            System.TimeSpan TS = new System.TimeSpan(EndDate.Ticks - StartDate.Ticks);
            switch (Interval)
            {
                case DateInterval.Day:
                    lngDateDiffValue = (long)TS.Days;
                    break;
                case DateInterval.Hour:
                    lngDateDiffValue = (long)TS.TotalHours;
                    break;
                case DateInterval.Minute:
                    lngDateDiffValue = (long)TS.TotalMinutes;
                    break;
                case DateInterval.Month:
                    lngDateDiffValue = (long)(TS.Days / 30);
                    break;
                case DateInterval.Quarter:
                    lngDateDiffValue = (long)((TS.Days / 30) / 3);
                    break;
                case DateInterval.Second:
                    lngDateDiffValue = (long)TS.TotalSeconds;
                    break;
                case DateInterval.Week:
                    lngDateDiffValue = (long)(TS.Days / 7);
                    break;
                case DateInterval.Year:
                    lngDateDiffValue = (long)(TS.Days / 365);
                    break;
            }
            return (lngDateDiffValue);
        }//end of DateDiff

        public static bool IsNumeric(string theValue)
        {
            try
            {
                Convert.ToDouble(theValue);
                return true;
            } 
            catch 
            {
                return false;
            }
        }



        public static string consultarFechaActual()
        {
            string fecha;
            fecha = Model.DB.ejecutarScalar(Model.TipoComando.SP, "fechaActual").ToString();
            return fecha;
            ///TODO: sacar esto de acá !!!!!!!!!!!!!!!!!!!! Quitar referencia DBNET tambien
        }
        
        /// <summary>
        /// Arma la cadena AnioMes, a partir de un año y mes dados.
        /// formato aaaamm
        /// </summary>
        /// <returns></returns>
        public static string anioMes(int anio, byte mes)
        {
            string strMes;
            if (mes > 9)
                strMes = mes.ToString();
            else
                strMes = 0 + mes.ToString();
            return anio.ToString() + strMes;
        }

        /// <summary>
        /// realiza consulta generica para confirmar la eliminacion de un registro
        /// Está seguro de eliminar el registro ?
        /// </summary>
        /// <returns></returns>
        public static bool confirmaEliminarRegistro()
        {
            DialogResult result = MessageBox.Show("Está seguro de eliminar el registro ?", "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }




        /// <summary>
        /// Obtiene parte izquierda de una cadena
        /// </summary>
        /// <param name="param"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string Left(string param, int length)
        {
            string result=param;
            //we start at 0 since we want to get the characters starting from the
            //left and with the specified lenght and assign it to a variable
           if (param.Length>length )
                result = param.Substring(0, length);
            //return the result of the operation
            return result;
        }

        /// <summary>
        /// obtiene parte derecha de una cadena
        /// </summary>
        /// <param name="param"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string Right(string param, int length)
        {
            //start at the index based on the lenght of the sting minus
            //the specified lenght and assign it a variable
            string result = param.Substring(param.Length - length, length);
            //return the result of the operation
            return result;
        }

        /// <summary>
        /// obtiene caracteres dada una posicion de inicio y longitud
        /// </summary>
        /// <param name="param"></param>
        /// <param name="startIndex"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string Mid(string param, int startIndex, int length)
        {
            //start at the specified index in the string ang get N number of
            //characters depending on the lenght and assign it to a variable
            string result = param.Substring(startIndex, length);
            //return the result of the operation
            return result;
        }

        /// <summary>
        /// Obtiene caracteres a partir de una posicion dada hasta el final
        /// </summary>
        /// <param name="param"></param>
        /// <param name="startIndex"></param>
        /// <returns></returns>
        public static string Mid(string param, int startIndex)
        {
            //start at the specified index and return all characters after it
            //and assign it to a variable
            string result = param.Substring(startIndex);
            //return the result of the operation
            return result;
        }
    }


}