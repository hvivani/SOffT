/*  
    DatosSQL.cs

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
using System.Data.SqlClient;

using Log4Net;

namespace Model
{
	public class Datos
	{
		SqlConnection con;

		public Datos(string conString) {
			this.con = new SqlConnection(conString);
		}

		/// <summary>Devuelve la Cadena de Conexión del objeto SqlConnection.</summary>
		public string StringConnection {
			get { return this.con.ConnectionString; }
		}

		public void Open() {
			this.con.Open();
		}

		public void Close() {
			this.con.Close();
		}



        public Boolean existeTabla(string nombreTabla) {
            string sql = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES " +
                         "WHERE TABLE_TYPE = 'BASE TABLE' " +
                         "AND TABLE_NAME = '" + nombreTabla + "'";

            int ret = (int)sqlSc(sql);
            return ret > 0;
        }


		public SqlDataReader sqlDr(string sql) {
			SqlCommand cmd = new SqlCommand(sql, con);
			cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 180; // 3 min
			cmd.CommandText = sql;
			return exeRdDr(cmd);
		}

		public SqlDataReader spDr(string sp) {
			SqlCommand cmd = new SqlCommand(sp, con);
			cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 180; // 3 min
			return exeRdDr(cmd);
		}

		public SqlDataReader spDr(string sp, object[] pr, string[] NomParam) {
			SqlCommand cmd = new SqlCommand(sp, con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddRange(addParams(pr, NomParam));
			return exeRdDr(cmd);
		}


		public DataTable sqlDt(string sql) {
			SqlCommand cmd = new SqlCommand(sql, con);
			cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 180; // 3 min
			cmd.CommandText = sql;
			return exeRd(cmd);
		}

		public DataTable spDt(string sp) {
			SqlCommand cmd = new SqlCommand(sp, con);
			cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 180; // 3 min
			return exeRd(cmd);
		}

		public DataTable spDt(string sp, object[] pr, string[] nomParam) {
			SqlCommand cmd = new SqlCommand(sp, con);
			cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 180; // 3 min
			cmd.Parameters.AddRange(addParams(pr, nomParam));
			return exeRd(cmd);
		}


		public object spSc(string sp) {
			SqlCommand cmd = new SqlCommand(sp, con);
			cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 180; // 3 min
			return exeSc(cmd);
		}

		public object sqlSc(string sql) {
			SqlCommand cmd = new SqlCommand(sql, con);
			cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 180; // 3 min
			return exeSc(cmd);
		}

		public int sqlNc(string sql) {
			SqlCommand cmd = new SqlCommand(sql, con);
			cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 180; // 3 min
			return exeNc(cmd);
		}

		public object spSc(string sp, object[] pr, string[] NomParam) {
			SqlCommand cmd = new SqlCommand(sp, con);
			//string[] NomParam = new string[] { "id", "nom", "dir", "tel" };
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddRange(addParams(pr, NomParam));
			return exeSc(cmd);
		}

		public int spNc(string sp, object[] pr, string[] NomParam) {
			SqlCommand cmd = new SqlCommand(sp, con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddRange(addParams(pr, NomParam));
			return exeNc(cmd);
		}

		public int spNc(string sp) {
			SqlCommand cmd = new SqlCommand(sp, con);
			cmd.CommandType = CommandType.StoredProcedure;
			return exeNc(cmd);
		}

		public double spNc_Double(string sp) {
			SqlCommand cmd = new SqlCommand(sp, con);
			cmd.CommandType = CommandType.StoredProcedure;
			return exeNc_Double(cmd);
		}



		SqlParameter[] addParams(object[] pr, string[] NomParam) {
			SqlParameter[] ifxp = new SqlParameter[pr.Length];
			int i = 0;
			foreach (object pr1 in pr) {
				//Param = "?" + i.ToString();
				ifxp[i] = new SqlParameter(i.ToString(), pr1);
				ifxp[i].ParameterName = "@" + NomParam[i];
				i++;
			}
			return ifxp;
		}

		DataTable exeRd(SqlCommand cmd) {
			DataTable dt = new DataTable();
			try {
				SqlDataReader dr = cmd.ExecuteReader();
				dt.Load(dr);
				dr.Close();
			} catch (SqlException ex) {
				MyLog4Net.Instance.getCustomLog(this.GetType()).Error("exeRd() -> " + ex.Message);
				throw ex;
			}
			return dt;
		}

		SqlDataReader exeRdDr(SqlCommand cmd) {
			try {
				return cmd.ExecuteReader();
			} 
            catch (SqlException ex) {
				MyLog4Net.Instance.getCustomLog(this.GetType()).Error("exeRdDr() -> " + ex.Message);
				throw ex;
			}
		}

		object exeSc(SqlCommand cmd) {
			try {
				return cmd.ExecuteScalar();
			} 
            catch (SqlException ex) {
				MyLog4Net.Instance.getCustomLog(this.GetType()).Error("exeSc() -> " + ex.Message);
				throw ex;
			}
		}

		int exeNc(SqlCommand cmd) {
			try {
 				return cmd.ExecuteNonQuery();
			} 
            catch (SqlException ex) {
				MyLog4Net.Instance.getCustomLog(this.GetType()).Error("exeNc() -> " + cmd.CommandText +
                    " - " +  ex.Message);
				throw ex;
			}
		}

		double exeNc_Double(SqlCommand cmd) { // double ??????????????
			try {
				return cmd.ExecuteNonQuery();
			}
            catch (SqlException ex) {
				MyLog4Net.Instance.getCustomLog(this.GetType()).Error("exeNc_Double() -> " + ex.Message);
                throw ex;
			}
		}

	}
}