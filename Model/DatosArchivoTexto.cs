/*  
    DatosArchivoTexto.cs

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
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Model
{
    public class DatosArchivoTexto
    {
        /// <summary>
        /// Graba archivo de texto en path y archivo indicado en parametro archivo.
        /// Se graba la cena indicada en cadena. icluye 0d0a.
        /// </summary>
		public static void grabaArchivoTexto(string archivo, string cadena, bool graba0D0A) {
			FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);
			StreamWriter writer = new StreamWriter(stream);
            if (graba0D0A)
               writer.WriteLine(cadena);
            else  writer.Write(cadena);
			writer.Close();
		}

        /// <summary>
        /// Lee archivo de texto
        /// </summary>
		public static string leeArchivoTexto(string archivo) {
			string cadena = null;
			FileStream stream = null;
			try {
				stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
			} catch (FileNotFoundException) {
				cadena = string.Empty;
				return cadena;
			}
			if (stream != null) {
				StreamReader reader = new StreamReader(stream);
				while (reader.Peek() > -1) {
					cadena = cadena + reader.ReadLine() + "\r\n";
				}
				reader.Close();
			}
			return cadena;
		}

        public static void crearArchivo(string archivo)
        {
            FileStream stream = new FileStream(archivo, FileMode.Create, FileAccess.Write);
            stream.Close();
            stream.Dispose();
        }

        public static void GeneraArchivoTxT(string nomArchi, IDataReader dr, Boolean FiltraCaracteres)
        {
            string cadena = null;
            string cadenita = null;
            while (dr.Read())
            {
                cadena = null;
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    try { cadenita = dr.GetString(i); }
                    catch { cadenita = string.Empty; }
                    cadena = cadena + cadenita;
                }
                if(FiltraCaracteres)
                   grabaArchivoTexto(nomArchi, filtro(cadena), true);
                else grabaArchivoTexto(nomArchi, cadena, true);
            }
            dr.Close();
        }

        public static string filtro(string palabra)
        {
            //eliminamos palabras de un caracter solo
            if (palabra.Length == 1) return null;

            string aux = palabra;
            //eliminamos caracteres que nos puedan estorbar
            char[] simbolos = new char[18];
            simbolos.SetValue(',', 0);
            simbolos.SetValue(';', 1);
            //simbolos.SetValue('.', 2);
            simbolos.SetValue(':', 2);
            simbolos.SetValue('"', 3);
            simbolos.SetValue('\'', 4);
            simbolos.SetValue('ñ', 5);
            simbolos.SetValue('Ñ', 6);
            simbolos.SetValue('á', 7);
            simbolos.SetValue('é', 8);
            simbolos.SetValue('í', 9);
            simbolos.SetValue('ó', 10);
            simbolos.SetValue('ú', 11);
            simbolos.SetValue('Á', 12);
            simbolos.SetValue('É', 13);
            simbolos.SetValue('Í', 14);
            simbolos.SetValue('Ó', 15);
            simbolos.SetValue('Ú', 16);
            simbolos.SetValue('º', 17);
            //aux = aux.Trim(simbolos);
            char reemplazar = ' ';

            for (int i = 0; i < simbolos.Length; i++)
            {
                reemplazar = ' ';
                if (simbolos[i] == 'ñ')
                    reemplazar = 'n';
                if(simbolos[i] == 'Ñ')
                    reemplazar = 'N';
                // Vocales acentuadas
                if (simbolos[i] == 'á')
                    reemplazar = 'a';
                if (simbolos[i] == 'é')
                    reemplazar = 'e';
                if (simbolos[i] == 'í')
                    reemplazar = 'i';
                if (simbolos[i] == 'ó')
                    reemplazar = 'o';
                if (simbolos[i] == 'ú')
                    reemplazar = 'u';
                if (simbolos[i] == 'Á')
                    reemplazar = 'A';
                if (simbolos[i] == 'É')
                    reemplazar = 'E';
                if (simbolos[i] == 'Í')
                    reemplazar = 'I';
                if (simbolos[i] == 'Ó')
                    reemplazar = 'O';
                if (simbolos[i] == 'Ú')
                    reemplazar = 'U';
                if (simbolos[i] == 'º')
                    reemplazar = '*';

                aux = aux.Replace(simbolos[i], reemplazar);
            }

            return aux;
        }

        public static void GeneraArchivoTxT(string nomArchi, DataTable dt, char Separador)
        {
            string cadena = null;
            cadena = null;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                    Application.DoEvents();            
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        cadena = cadena + dt.Rows[i][j].ToString().Trim() + Separador;
                        Application.DoEvents(); 
                    }
                    grabaArchivoTexto(nomArchi, cadena, true);
                    cadena = null;
            }
        }

        public static void GeneraArchivoTxT(string nomArchi, DataTable dt, char Separador, ref ProgressBar progresBar1, ref Label lblQueHacemos)
        {
            string cadena = null;
            cadena = null;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                Application.DoEvents();
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    cadena = cadena + dt.Rows[i][j].ToString().Trim() + Separador;
                    Application.DoEvents();

                    if ((i % 7) == 0)
                    {
                        progresBar1.Value = i;
                        progresBar1.Refresh();
                        Application.DoEvents();
                    }
                }
                grabaArchivoTexto(nomArchi, cadena, true);
                cadena = null;
            }
        }

        /// <summary>
        /// abre archivo y lo vacia.
        /// </summary>
        public static void vaciarArchivo(string archivo)
        {
            try
            {
                FileStream stream = new FileStream(archivo, FileMode.Truncate, FileAccess.Write);
                stream.Close();
            }
            catch { } //no hace nada no existe el archivo
        }

        /// <summary>
        /// Lee un csv y devuelve un datatable cargado con sus datos, es necesario pasar el nombre de la hoja
        /// </summary>
        /// <param name="nombre">Nombre del archivo que contiene los datos a cargar en el datatable</param>
        /// <param name="ruta">Ruta del archivo que contiene la información</param>
        public static DataTable Lee_CSV(string nombre, string ruta)
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +  ruta + ";" + "Extended Properties='text;HDR=No;FMT=Delimited'";
            DataTable dtCSV = new DataTable();
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                using (OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM " + nombre, conn))
                {
                    da.Fill(dtCSV);
                }
            }
            catch (Exception ex) {
                Log4Net.MyLog4Net.Instance.getCustomLog("DatosArchivoTexto.cs").Error("Lee_CSV() -> Ruta: " + ruta + 
                                      " Archivo: " + nombre + " mensaje: " + ex.Message, ex); 
                return dtCSV;
            }
            return dtCSV;
        }

        public static void FiltroArchivoTexto(string archivo)
        {
            string cadena, cadena1 = null;
            string archivoNuevo = archivo + ".tmp";
            FileStream stream = null;
            FileStream strNuevo = null;
            try
            {
                stream =
                new FileStream(archivo, FileMode.Open, FileAccess.Read);
                strNuevo =
                new FileStream(archivoNuevo, FileMode.Append, FileAccess.Write);
            }
            catch (IOException)
            {
                Console.WriteLine("No se encuentra el archivo especificado. Seleccione un archivo");
                return;
            }

            if (stream != null)
            {
                StreamReader reader = new StreamReader(stream);
                StreamWriter writer = new StreamWriter(strNuevo);
                cadena = reader.ReadLine();
                while (!string.IsNullOrEmpty(cadena))
                {
                    cadena1 = cadena.Replace('"', ' ');
                    cadena1 = cadena1.Replace('º', ' ');
                    cadena1 = cadena1.Replace('�', ' ');
                    cadena1 = cadena1.Replace('\'', ' ');
                    writer.WriteLine(cadena1);
                    cadena = reader.ReadLine();
                }
                reader.Close();
                writer.Close();
            }
            stream.Close();
            strNuevo.Close();
            File.Delete(archivo);
            File.Move(archivoNuevo, archivo);
        }

        //20090916. hvivani. 
        //Concatena archivos de texto
        //Directorio Contiene la ruta física donde se encuentran todos los archivos
        //Filtro archivos determina que archivos del directorio se seleccionaran. todos: *.*
        //Archivo Final es el nombre del archivo (incluyendo la ruta) que tiene la
        //concatenación de todos los archivos
        public static void Concatena(string Directorio, string filtroArchivos, string ArchivoFinal)
        {
            // Crea un arreglo con el nombre de todos los archivos existentes
            string[] ArchivosEntrada = Directory.GetFiles(Directorio,filtroArchivos );
            // Creamos el archivo Final
            FileStream Archivo = new FileStream(ArchivoFinal, FileMode.Create,
            FileAccess.Write, FileShare.None);
            // Para indicar que se va a escribir en el archivo
            StreamWriter writer = new StreamWriter(Archivo);
            foreach (string ArchivoEntrada in ArchivosEntrada)
            {
                // Cargamos el archivo correspondiente
                FileStream ArchivoConcatenar = new FileStream(ArchivoEntrada,
                FileMode.Open, FileAccess.Read);
                // Especificamos que se va a leer el archivo (nota, si no se le pone la
                // instrucción System.Text.Encoding.GetEncoding(1252) los acentos no son leidos)
                StreamReader reader = new StreamReader(ArchivoConcatenar, System.Text.Encoding.GetEncoding(1252));
                string Linea;
                // Recorremos el archivo linea a linea y la vamos escribiendo en el archivo
                // final
                while ((Linea = reader.ReadLine()) != null)
                {
                    writer.WriteLine(Linea);
                }
                // Cerramos el archivo y continuamos con el siguiente
                reader.Close();
            }
            // Cerramos el archivo Final
            writer.Close();
        } 

    }
}
