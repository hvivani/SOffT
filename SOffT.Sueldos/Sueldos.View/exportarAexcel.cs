/*  
    exportarAexcel.cs

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
//using Microsoft.Office.Interop.Excel;
using System.Data;


namespace Sueldos.View
{

    /// <summary>
    /// Clase armada con fuentes obtenidos en: http://www.codeproject.com/KB/office/FastExcelExporting.aspx
    /// </summary>
    class exportarAexcel
    {

        /// <summary>
        /// Exporta a excel por método rápido.
        /// Guarda en archivo especificado directamente.
        /// </summary>
        /// <param name="dataSet"></param>
        /// <param name="outputPath"></param>
        public static void exportar(DataSet dataSet, string outputPath)
        {
            // Create the Excel Application object
/*            ApplicationClass excelApp = new ApplicationClass();

            // Create a new Excel Workbook
            Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);

            int sheetIndex = 0;

            // Copy each DataTable
            foreach (System.Data.DataTable dt in dataSet.Tables)
            {

                // Copy the DataTable to an object array
                object[,] rawData = new object[dt.Rows.Count + 1, dt.Columns.Count];

                // Copy the column names to the first row of the object array
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    rawData[0, col] = dt.Columns[col].ColumnName;
                }

                // Copy the values to the object array
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    for (int row = 0; row < dt.Rows.Count; row++)
                    {
                        rawData[row + 1, col] = dt.Rows[row].ItemArray[col];
                    }
                }

                // Calculate the final column letter
                string finalColLetter = string.Empty;
                string colCharset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                int colCharsetLen = colCharset.Length;

                if (dt.Columns.Count > colCharsetLen)
                {
                    finalColLetter = colCharset.Substring(
                        (dt.Columns.Count - 1) / colCharsetLen - 1, 1);
                }

                finalColLetter += colCharset.Substring(
                        (dt.Columns.Count - 1) % colCharsetLen, 1);

                // Create a new Sheet
                Worksheet excelSheet = (Worksheet)excelWorkbook.Sheets.Add(
                    excelWorkbook.Sheets.get_Item(++sheetIndex),
                    Type.Missing, 1, XlSheetType.xlWorksheet);

                excelSheet.Name = dt.TableName;

                // Fast data export to Excel
                string excelRange = string.Format("A1:{0}{1}",
                    finalColLetter, dt.Rows.Count + 1);

                excelSheet.get_Range(excelRange, Type.Missing).Value2 = rawData;

                // Mark the first row as BOLD
                ((Range)excelSheet.Rows[1, Type.Missing]).Font.Bold = true;
            }

            // Save and Close the Workbook
            excelWorkbook.SaveAs(outputPath, XlFileFormat.xlWorkbookNormal, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            excelWorkbook.Close(true, Type.Missing, Type.Missing);
            excelWorkbook = null;

            // Release the Application object
            excelApp.Quit();
            excelApp = null;

            // Collect the unreferenced objects
            GC.Collect();
            GC.WaitForPendingFinalizers(); */

        }

        /// <summary>
        /// Exporta a excel por el metodo de
        /// celda a celda. Guarda en archivo especificado directamente.
        /// </summary>
        /// <param name="dataSet"></param>
        /// <param name="outputPath"></param>
        public static void exportarCeldaACelda(DataSet dataSet, string outputPath)
        {
            // Create the Excel Application object
/*            ApplicationClass excelApp = new ApplicationClass();

            // Create a new Excel Workbook
            Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);

            int sheetIndex = 0;

            // Copy each DataTable as a new Sheet
            foreach (System.Data.DataTable dt in dataSet.Tables)
            {

                // Create a new Sheet
                Worksheet excelSheet = (Worksheet)excelWorkbook.Sheets.Add(
                    excelWorkbook.Sheets.get_Item(++sheetIndex),
                    Type.Missing, 1, XlSheetType.xlWorksheet);

                excelSheet.Name = dt.TableName;

                // Copy the column names (cell-by-cell)
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    excelSheet.Cells[1, col + 1] = dt.Columns[col].ColumnName;
                }

                ((Range)excelSheet.Rows[1, Type.Missing]).Font.Bold = true;


                // Copy the values (cell-by-cell)
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    for (int row = 0; row < dt.Rows.Count; row++)
                    {
                        excelSheet.Cells[row + 2, col + 1] = dt.Rows[row].ItemArray[col];
                    }
                }

            }

            // Save and Close the Workbook
            excelWorkbook.SaveAs(outputPath, XlFileFormat.xlWorkbookNormal, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            excelWorkbook.Close(true, Type.Missing, Type.Missing);
            excelWorkbook = null;

            // Release the Application object
            excelApp.Quit();
            excelApp = null;

            // Collect the unreferenced objects
            GC.Collect();
            GC.WaitForPendingFinalizers(); */

        }

        /// <summary>
        /// Exporta a excel por el metodo de
        /// celda a celda. Guarda en archivo especificado directamente.
        /// </summary>
        /// <param name="dataSet"></param>
        /// <param name="outputPath"></param>
        /// <param name="colControl">Columna del DataSet que se utiliza para el corte control del pivoteo</param>
        /// <param name="colColumna">Columna del DataSet que indica la columna resultado del pivot</param>
        /// <param name="colValor">Columna del DataSet que indica la columna de valor resultado del pivot</param>
        public static void exportarCeldaACeldaPivot(DataSet dataSet, string outputPath, int colControl, int colColumna, int colValor)
        {
            // Create the Excel Application object
/*            ApplicationClass excelApp = new ApplicationClass();

            // Create a new Excel Workbook
            Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);

            int sheetIndex = 0;

            // Copy each DataTable as a new Sheet
            foreach (System.Data.DataTable dt in dataSet.Tables)
            {

                // Create a new Sheet
                Worksheet excelSheet = (Worksheet)excelWorkbook.Sheets.Add(
                    excelWorkbook.Sheets.get_Item(++sheetIndex),
                    Type.Missing, 1, XlSheetType.xlWorksheet);

                excelSheet.Name = dt.TableName;

                ((Range)excelSheet.Rows[1, Type.Missing]).Font.Bold = true;

                //TODO cpereyra conversion excel pivot
                //Copia haciendo Pivot
                Int64 fila = 1;
                object control = dt.Rows[0].ItemArray[colControl];
                excelSheet.Cells[fila, "A"] = control.ToString();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    if (!dt.Rows[row].ItemArray[colControl].Equals(control))
                    {
                        fila++;
                        control = dt.Rows[row].ItemArray[colControl];
                        excelSheet.Cells[fila, "A"] = control.ToString();
                    }
                    excelSheet.Cells[fila, dt.Rows[row].ItemArray[colColumna]] = dt.Rows[row].ItemArray[colValor];
                }
            }

            // Save and Close the Workbook
            excelWorkbook.SaveAs(outputPath, XlFileFormat.xlWorkbookNormal, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            excelWorkbook.Close(true, Type.Missing, Type.Missing);
            excelWorkbook = null;

            // Release the Application object
            excelApp.Quit();
            excelApp = null;

            // Collect the unreferenced objects
            GC.Collect();
            GC.WaitForPendingFinalizers();*/

        }
    }
}
