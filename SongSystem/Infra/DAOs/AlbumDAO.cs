using ISpan.SQL.Utility;
using SongSystem.Models.DTOs;
using SongSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSystem.Infra.DAOs
{
	public class AlbumDAO
	{
		public IEnumerable<AlbumIndexVM> GetAll()
		{
			string sql = "select * from Albums order by Created_at";

			return new SqlDBHelper("default").Select(sql, null)
							.AsEnumerable()
							.Select(row => ParseToAlbumIndexVM(row));
		}

		public AlbumVM Get(int? id)
		{
			string sql = "Select * from Albums where Id = @Id";
			var parameters = new SqlParameterBuilder()
									.AddNullableInt("Id", id)
									.Build();
			var dt = new SqlDBHelper("default").Select(sql, parameters);
			if (dt.Rows.Count == 0)
			{
				return null;
			}
			var dr = dt.Rows[0];

			return ParseToAlbumVM(dr);
		}

		public IEnumerable<AlbumIndexVM> Get(string albumName)
		{
			string sql = "Select * from Albums where AlbumName like @AlbumName";
			var parameters = new SqlParameterBuilder()
									.AddNVarChar("AlbumName", 50, albumName)
									.Build();
			var model = new SqlDBHelper("default").Select(sql, parameters)
							.AsEnumerable()
							.Select(row => ParseToAlbumIndexVM(row));
			return model;
		}

		public void Create(AlbumDTO model)
		{
			string sql = @"insert into Albums(AlbumName, Released)
							values(@AlbumName, @Released)";

			var parameters = new SqlParameterBuilder()
								.AddNVarChar("AlbumName", 50, model.AlbumName)
								.AddDateTime("Released", model.Released)
			.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Update(AlbumDTO model)
		{
			string sql = @"update Albums 
							set AlbumName = @AlbumName, 
							Released = @Released
							Where Id = @Id";

			var parameters = new SqlParameterBuilder()
								.AddInt("Id", model.Id)
								.AddNVarChar("AlbumName", 50, model.AlbumName)
								.AddDate("Released", model.Released)
			.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Delete(int id)
		{
			string sql = @"delete from Albums where Id = @Id";

			var parameters = new SqlParameterBuilder()
								.AddInt("Id", id)
			.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		private AlbumIndexVM ParseToAlbumIndexVM(DataRow row)
		{
			return new AlbumIndexVM
			{
				Id = row.Field<int>("Id"),
				AlbumName = row.Field<string>("AlbumName"),
				Released = row.Field<DateTime>("Released"),
			};
		}

		private AlbumVM ParseToAlbumVM(DataRow dr)
		{
			return new AlbumVM
			{
				Id = dr.Field<int>("Id"),
				AlbumName = dr.Field<string>("AlbumName"),
				Released = dr.Field<DateTime>("Released"),
			};
		}

		public AlbumVM AlbumExists(AlbumDTO model)
		{
			var parameterbuilder = new SqlParameterBuilder();
			string sql = "Select * from Albums where AlbumName = @AlbumName";

			if (model.Id != 0)
			{
				sql += " and Id != @Id";
				parameterbuilder = parameterbuilder.AddInt("Id", model.Id);
			}
			var parameters = parameterbuilder.AddNVarChar("AlbumName", 50, model.AlbumName).Build();

			var dt = new SqlDBHelper("default").Select(sql, parameters);
			if (dt.Rows.Count == 0) return null;
			var dr = dt.Rows[0];

			return ParseToAlbumVM(dr);
		}
	}
}
