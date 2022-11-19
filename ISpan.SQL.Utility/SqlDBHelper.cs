using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.SQL.Utility
{
    public class SqlDBHelper
    {
		private string connString;

		public SqlDBHelper(string keyOfConnString)
		{
			connString = System.Configuration.ConfigurationManager.ConnectionStrings[keyOfConnString].ConnectionString;
		}

		public void ExecuteNonQuery(string sql, SqlParameter[] parameters)
		{
			using (SqlConnection conn = new SqlConnection(connString))
			{
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddRange(parameters);
				conn.Open();

				cmd.ExecuteNonQuery();
			}
		}

		public DataTable Select(string sql, SqlParameter[] parameters)
		{
			using (SqlConnection conn = new SqlConnection(connString))
			{
				SqlCommand cmd = new SqlCommand(sql, conn);
				if (parameters != null)
				{
					cmd.Parameters.AddRange(parameters);
				}

				conn.Open();
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				DataSet dataSet = new DataSet();
				adapter.Fill(dataSet, "table");

				return dataSet.Tables["table"];
			}
		}
	}
}
