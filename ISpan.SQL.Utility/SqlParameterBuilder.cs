using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.SQL.Utility
{
	public class SqlParameterBuilder
	{
		private List<SqlParameter> parameters = new List<SqlParameter>();

		public SqlParameterBuilder AddInt(string colName, int value)
		{
			parameters.Add(new SqlParameter(colName, SqlDbType.Int) { Value = value });

			return this;
		}

		public SqlParameterBuilder AddNullableInt(string colName, int? value)
		{
			if (value.HasValue)
				parameters.Add(new SqlParameter(colName, SqlDbType.Int) { Value = value });
			else
				parameters.Add(new SqlParameter(colName, DBNull.Value));

			return this;
		}
		public SqlParameterBuilder AddVarChar(string colName, int length, string value)
		{
			parameters.Add(new SqlParameter(colName, SqlDbType.VarChar, length) { Value = value });

			return this;
		}

		public SqlParameterBuilder AddNVarChar(string colName, int length, string value)
		{
			parameters.Add(new SqlParameter(colName, SqlDbType.NVarChar, length) { Value = value });

			return this;
		}

		public SqlParameterBuilder AddDateTime(string colName, DateTime value)
		{
			parameters.Add(new SqlParameter(colName, SqlDbType.DateTime) { Value = value });

			return this;
		}

		public SqlParameterBuilder AddDate(string colName, DateTime value)
		{
			parameters.Add(new SqlParameter(colName, SqlDbType.Date) { Value = value });

			return this;
		}

		public SqlParameterBuilder AddTime(string colName, TimeSpan value)
		{
			parameters.Add(new SqlParameter(colName, SqlDbType.Time) { Value = value });

			return this;
		}

		public SqlParameterBuilder AddBool(string colName, bool value)
		{
			parameters.Add(new SqlParameter(colName, SqlDbType.Bit) { Value = value });

			return this;
		}

		public SqlParameterBuilder AddBigint(string colName, TimeSpan value)
		{
			parameters.Add(new SqlParameter(colName, SqlDbType.BigInt) { Value = value });

			return this;
		}

		public SqlParameterBuilder AddBit(string colName, bool value)
		{
			parameters.Add(new SqlParameter(colName, SqlDbType.Bit) { Value = value });

			return this;
		}

		public SqlParameterBuilder AddNullableBit(string colName, bool? value)
		{
			if (value.HasValue)
				parameters.Add(new SqlParameter(colName, SqlDbType.Int) { Value = value });
			else
				parameters.Add(new SqlParameter(colName, DBNull.Value));

			return this;
		}

		public SqlParameter[] Build()
		{
			return parameters.ToArray();
		}
	}
}
