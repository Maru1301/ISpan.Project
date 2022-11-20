using ISpan.SQL.Utility;
using SongSystem.Models.DTOs;
using SongSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SongSystem.Infra.DAOs
{
	public class SongDAO
	{
		public IEnumerable<SongIndexVM> GetAll()
		{
			string sql = @"select * from Songs order by Id";

			return new SqlDBHelper("default").Select(sql, null)
							.AsEnumerable()
							.Select(row => ToSongIndexVM(row));
		}

		public SongVM Get(int id)
		{
			string sql = @"select * from songs where Id = @Id";

			var parameters = new SqlParameterBuilder().AddInt("Id", id).Build();

			var dt = new SqlDBHelper("default").Select(sql, parameters);
			if (dt.Rows.Count == 0) return null;
			var dr = dt.Rows[0];

			return ParseToSongVM(dr);
		}

		public SongVM Get(string songName)
		{
			string sql = @"select * from songs where SongName = @SongName";

			var parameters = new SqlParameterBuilder().AddNVarChar("SongName", 50, songName).Build();

			var dt = new SqlDBHelper("default").Select(sql, parameters);
			if (dt.Rows.Count == 0) return null;
			var dr = dt.Rows[0];

			return ParseToSongVM(dr);
		}
		public void Create(SongDTO model)
		{
			string sql = @"insert into Songs(SongName, Length, GenreId, Language,Released)
					values(@SongName, @Length, @GenreId, @Language, @Released)";

			var parameters = new SqlParameterBuilder()
									.AddNVarChar("SongName", 50, model.SongName)
									.AddTime("Length", model.Length)
									.AddInt("GenreId", model.GenreId)
									.AddDateTime("Released", model.Released)
									.AddNVarChar("Language", 50, model.Language)
			.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Update(SongDTO model)
		{
			string sql = @"update songs 
							set SongName = @SongName, 
							Length = @Length, 
							GenreId = @GenreId,
							Language = @Language,
							Released = @Released
							where Id = @Id";

			var parameters = new SqlParameterBuilder()
									.AddInt("Id", model.SongId)
									.AddNVarChar("SongName", 50, model.SongName)
									.AddTime("Length", model.Length)
									.AddInt("GenreId", model.GenreId)
									.AddNVarChar("Language", 50, model.Language)
									.AddDateTime("Released", model.Released)
									.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Delete(int id)
		{
			string sql = "delete from songs where Id = @Id";

			var parameters = new SqlParameterBuilder().AddInt("Id", id).Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public SongVM SongExists(SongDTO model)
		{
			string sql = "select * from songs where SongName = @SongName";
			var parametersbuilder = new SqlParameterBuilder().AddNVarChar("SongName", 50, model.SongName);

			if(model.SongId> 0)
			{
				sql += " and Id != @Id";
				parametersbuilder = parametersbuilder.AddInt("Id", model.SongId);
			}

			var parameters = parametersbuilder.Build();

			var dt = new SqlDBHelper("default").Select(sql, parameters);
			if (dt.Rows.Count == 0) return null;
			var dr = dt.Rows[0];

			return ParseToSongVM(dr);
		}

		private SongVM ParseToSongVM(DataRow dr)
		{
			return new SongVM
			{
				SongId = dr.Field<int>("Id"),
				SongName = dr.Field<string>("SongName"),
				Length = dr.Field<TimeSpan>("Length"),
				GenreId = dr.Field<int>("GenreId"),
				Released = dr.Field<DateTime>("Released"),
				Language = dr.Field<string>("Language"),
			};
		}

		private SongIndexVM ToSongIndexVM(DataRow row)
		{
			return new SongIndexVM
			{
				SongId = row.Field<int>("SongId"),
				SongName = row.Field<string>("SongName"),
				SingerName = row.Field<string>("SingerName"),
				GroupName = row.Field<string>("GroupName"),
				Length = row.Field<TimeSpan>("Length"),
				GenreName = row.Field<string>("GenreName"),
				AlbumName = row.Field<string>("AlbumName"),
				Released = row.Field<DateTime>("Released"),
				Language = row.Field<string>("Language"),
				Composer = row.Field<string>("Composer"),
				Arranger = row.Field<string>("Arranger"),
				Producer = row.Field<string>("Producer"),
				Lyricist = row.Field<string>("Lyricist"),
				RecordCompany = row.Field<string>("RecordCompany"),
			};
		}
	}
}
