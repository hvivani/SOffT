/*  
    DJJUOCRA.cs

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
using System.IO;
using System.Data.Common;
using System.Windows.Forms;
using Sofft.Utils;


namespace Sueldos.View
{
    /// <summary>
    /// Clase que define estructura de archivos para acreditacion del fondo desempleo
    /// en banco nacion
    /// </summary>
    class DDJJUOCRA
    {
        public struct movi
        {
            public static string cuil=""; 			    //11
            public const string afiliado = "S"; 		    //1
            public static string cuota_sindical = ""; 	//($)8
            public static string fondo_cese_laboral = ""; //($)8
            public static string fingreso = "";           //(ddmmaaaa) 	8
            public const string CPLaboral = "1064";	         //4
            public const string Convenio = "UO";           //2
            public static string Categoria = "";		      //2
            public const string AdmPublicaPcial = "N";	  //1
            /*public const string casa = "11000";
            public static string cuenta = "";
            public const string transaccion = "128";
            public const string empresa="KIOS"; 
            public const string filler="               "; 
            public static string importe = "";*/
        }


        public static void generaArchivo(int anioMes, string archivo)
        {
            string importe = "";
            string importe2 = "";
            StreamWriter sw = new StreamWriter(archivo);

            DbDataReader rsLegajos;
            rsLegajos = Model.DB.ejecutarDataReader(Model.TipoComando.SP, "ddjj_uocra", "@anioMes", anioMes);
            while (rsLegajos.Read())  //para cada legajo recorro todos los campos definidos en tablas
            {
                movi.cuil = rsLegajos["cuil"].ToString().PadLeft(11, '0');
                
                importe = string.Format("{0:#0.00}", Convert.ToDouble(rsLegajos["RemCtaSindical"]));
                //importe = importe.Replace(".", "");
                movi.cuota_sindical = importe.PadLeft(8, '0');

                importe2 = string.Format("{0:#0.00}", Convert.ToDouble(rsLegajos["RemFdoCeseLaboral"]));
                //importe2 = importe2.Replace(".", "");
                movi.fondo_cese_laboral = importe2.PadLeft(8, '0');

                movi.fingreso = rsLegajos["fIngreso"].ToString().PadLeft(8, '0');
                //MessageBox.Show(movi.fingreso);

                movi.Categoria = rsLegajos["categoria"].ToString();
                //Console.WriteLine(movi.Categoria);

                if (movi.Categoria == "AYUDANTE")
                    movi.Categoria = "05";
                else
                    if (movi.Categoria == "MEDIO OFICIAL")
                        movi.Categoria = "04";
                    else
                        if (movi.Categoria == "OFICIAL")
                            movi.Categoria = "03";
                        else
                            if (movi.Categoria == "OFICIAL ESPECIALIZADO")
                                movi.Categoria = "02";
                            else
                                if (movi.Categoria == "SERENO")
                                    movi.Categoria = "06";
                                else
                                    movi.Categoria = "01";


                //try
                //{
                //    movi.cuenta = Model.DB.ejecutarScalar(Model.TipoComando.SP, "empleadosSueldosConsultarValorLegajo", "legajo", Convert.ToInt32(rsLegajos["Legajo"]), "codigo", 105).ToString();
                //}
                //catch (Exception e)
                //{
                //    MessageBox.Show("error al obtener cuenta legajo " + int.Parse(rsLegajos["legajo"].ToString()).ToString() + "\n" +  e.ToString());
                //}
                //movi.cuenta = movi.cuenta.PadLeft(9, '0');
                //if (movi.cuenta.Length == 0 )
                //    MessageBox.Show("ATENCIÓN: el legajo " + int.Parse(rsLegajos["legajo"].ToString()).ToString() + " no tiene cuenta o banco asignado. No se exportara el importe.");
                //else
                //{
                    try
                    {
                        sw.WriteLine(movi.cuil + movi.afiliado + movi.cuota_sindical + movi.fondo_cese_laboral + movi.fingreso + movi.CPLaboral + movi.Convenio + movi.Categoria + movi.AdmPublicaPcial  );
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Error al insertar registro en archivo txt. \n" + e.ToString());
                    }
             //   }
            }
            //grabar final.
            sw.Close();
        }



    }
}
