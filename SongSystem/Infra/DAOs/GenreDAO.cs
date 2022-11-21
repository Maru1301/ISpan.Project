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
	public class GenreDAO
	{
		public IEnumerable<GenreIndexVM> GetAll()
		{
			string sql = @"select * from Genres Order By Created_at";

			return new SqlDBHelper("default").Select(sql, null)
							.AsEnumerable()
							.Select(row => ParseToSongGenreIndexVM(row));
		}

		public GenreVM Get(int id)
		{
			string sql = "select * from Genres where id = @id";
			var parameters = new SqlParameterBuilder()
			.AddInt("id", id)
			.Build();

			var dt = new SqlDBHelper("default").Select(sql, parameters);
			if (dt.Rows.Count == 0)
			{
				return null;
			}
			var dr = dt.Rows[0];
			return ParseToSongGenreVM(dr);
		}

		public IEnumerable<GenreIndexVM> Get(string GenreName)
		{
			string sql = "select * from Genres where GenreName like @GenreName";
			var parameters = new SqlParameterBuilder()
									.AddNVarChar("GenreName", 50, GenreName)
			.Build();

			return new SqlDBHelper("default").Select(sql, parameters)
							.AsEnumerable()
							.Select(row => ParseToSongGenreIndexVM(row));
		}

		public void Create(GenreDTO model)
		{
			string sql = @"insert into Genres(GenreName)
							values(@GenreName)";

			var parameters = new SqlParameterBuilder()
									.AddNVarChar("GenreName", 50, model.GenreName)
									.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Update(GenreDTO model)
		{

			string sql = @"update Genres 
							set GenreName = @GenreName
							where Id = @Id";

			var parameters = new SqlParameterBuilder()
									.AddInt("Id", model.Id)
									.AddNVarChar("GenreName", 50, model.GenreName)
									.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Delete(int id)
		{
			string sql = @"delete from Genres 
							where id = @id";
			var parameters = new SqlParameterBuilder()
									.AddInt("id", id)
			.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		private GenreIndexVM ParseToSongGenreIndexVM(DataRow row)
		{
			return new GenreIndexVM
			{
				Id = row.Field<int>("id"),
				GenreName = row.Field<string>("GenreName"),
			};
		}

		private GenreVM ParseToSongGenreVM(DataRow dr)
		{
			return new GenreVM
			{
				Id = dr.Field<int>("id"),
				GenreName = dr.Field<string>("GenreName"),
			};
		}

		public GenreVM GenreExists(GenreDTO model)
		{
			string sql = "select * from Genres where GenreName = @GenreName";

			if (model.Id != 0)
			{
				sql += " and Id != @Id";
			}

			var parameters = new SqlParameterBuilder()
									.AddNVarChar("GenreName", 50, model.GenreName)
									.AddInt("Id", model.Id)
			.Build();

			DataTable dt = new SqlDBHelper("default").Select(sql, parameters);
			if (dt.Rows.Count == 0) return null;
			var dr = dt.Rows[0];

			return ParseToSongGenreVM(dr);
		}
	}
}
