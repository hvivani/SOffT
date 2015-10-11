/*  
    DatosMySQL.cs

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
using MySql.Data.MySqlClient;

namespace Model
{
    public class DatosMySQL
    {
        
        MySqlConnection  con;

        public DatosMySQL(string conString)
        {
            con = new MySqlConnection(conString);
        }

        public void Open()
        {
            con.Open();
        }

        public void Close()
        {
            con.Close();
        }

        public MySqlDataReader sqlDr(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            return exeRdDr(cmd);
        }
        public int sqlNc(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            return exeNc(cmd);
        }

        public MySqlDataReader spDr(string sp)
        {
            MySqlCommand cmd = new MySqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            return exeRdDr(cmd);
        }

        public MySqlDataReader spDr(string sp, object[] pr, string[] NomParam)
        {
            MySqlCommand cmd = new MySqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(addParams(pr, NomParam));
            return exeRdDr(cmd);
        }

        public DataTable sqlDt(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            return exeRd(cmd);
        }
        public object sqlSc(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            return exeSc(cmd);
        }        

        public DataTable spDt(string sp)
        {
            MySqlCommand cmd = new MySqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            return exeRd(cmd);
        }

        public DataTable spDt(string sp, object[] pr, string[] nomParam)
        {
            MySqlCommand cmd = new MySqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(addParams(pr, nomParam));
            return exeRd(cmd);
        }

        public object  spSc(string sp)
        {
            MySqlCommand cmd = new MySqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            return exeSc(cmd);
        }

        public object spSc(string sp, object[] pr, string[] NomParam)
        {
            MySqlCommand cmd = new MySqlCommand(sp, con);
            //string[] NomParam = new string[] { "id", "nom", "dir", "tel" };
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(addParams(pr, NomParam));
            return exeSc(cmd);
        }
        public int spNc(string sp, object[] pr, string[] NomParam)
        {
            MySqlCommand cmd = new MySqlCommand(sp, con);
            //string[] NomParam = new string[] { "id", "nom", "dir", "tel" };
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(addParams(pr, NomParam));
            return exeNc(cmd);
        }
        
        public int spNc(string sp)
        {
            MySqlCommand cmd = new MySqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            return exeNc(cmd);
        }


        MySqlParameter[] addParams(object[] pr, string[] NomParam)
        {
            MySqlParameter[] ifxp = new MySqlParameter[pr.Length];
            int i = 0;
            foreach (object pr1 in pr)
            {
                //Param = "?" + i.ToString();
                ifxp[i] = new MySqlParameter(i.ToString(), pr1);
                ifxp[i].ParameterName = "?" + NomParam[i];
                i++;
            }
            return ifxp;
        }

        DataTable exeRd(MySqlCommand cmd)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            catch (MySqlException  ex)
            {
                Console.WriteLine("Problem with connection attempt: " + ex.Message);
                throw;
            }
            return dt;
        }

        MySqlDataReader exeRdDr(MySqlCommand cmd)
        {
            MySqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Problem with connection attempt: " + ex.Message);
                throw;
            }
            return dr;
        }

        object exeSc(MySqlCommand cmd)
        {
            object ob;
            try
            {
                ob = cmd.ExecuteScalar(); 
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Problem with connection attempt: " + ex.Message);
                throw;
            }
            
            return ob;
        }
        int exeNc(MySqlCommand cmd)
        {
            int ob;
            try
            {
                ob = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Problem with connection attempt: " + ex.Message);
                throw;
            }

            return ob;
        }
    }
}
