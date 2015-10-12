/*  
    Program.cs

    Author:
    Hernan Vivani <hernan@vivani.com.ar> - http://hvivani.com.ar

    Copyright © SOffT 2008 - http://www.sofft.com.ar

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
using System.Windows.Forms;
using Sofft.Utils;

namespace Reloj.View
{
    static class Program
    {
        /// <summary>
        /// Variable estatica y publica para obtener el valor pasado por parametro
        /// en linea de comandos que indica el id de reloj que se esta ejecutando.
        /// Si no se pasa ningún parametro se asume idreloj = 0;
        /// </summary>
        public static int idReloj;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Seteo idReloj
            if (args.Length>0 && Varios.IsNumeric(args[0].ToString()))
                idReloj = Convert.ToInt32(args[0].ToString());
            else
                idReloj = 0;

            //Establesco la conexion defecto de la configuracion en app.config
            Model.DB.ConnectionName = "reloj.Properties.Settings.sueldosConnectionStringDefault";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmReloj());
            //Application.Run(new frmFingerPrintUtils());
        }
    }
}