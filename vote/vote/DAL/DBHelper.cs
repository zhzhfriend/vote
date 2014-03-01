using System;
using System.Data.OleDb;
using System.Web;
using System.Data;

namespace vote
{
	public class DBHelper : IDisposable
	{
		private OleDbConnection conn=null;
		public void OpenConnection()
		{
			conn =  new OleDbConnection ();
			string connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.Web.HttpContext.Current.Server.MapPath ("~/Data/vote.mdb");
			conn.ConnectionString = connStr;
			conn.Open ();
		}

		public void CloseConnection()
		{
			if (conn != null && conn.State== ConnectionState.Open) {
				conn.Close ();
				conn = null;
			}
		}

		public void Dispose()
		{
			CloseConnection ();
		}

		public int ExecuteNonQuery(String sql)
		{
			OleDbCommand cmd = new OleDbCommand ();
			cmd.Connection = conn;
			cmd.CommandText = sql;
			int result =  cmd.ExecuteNonQuery ();
			return result;
		}

		public OleDbDataReader ExecuteQuery(String sql)
		{
			OleDbCommand cmd = new OleDbCommand ();
			cmd.Connection = conn;
			cmd.CommandText = sql;
			OleDbDataReader reader =  cmd.ExecuteReader ();
			return reader;
		}
	}
}

