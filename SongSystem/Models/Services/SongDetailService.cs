using ISpan.SQL.Utility;
using SongSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSystem.Models.Services
{
	public class SongDetailService
	{
		public IEnumerable<SongIndexVM> GetAll()
		{
			string sql = @"select so.Id as SongId, so.SongName, si.Id as SingerId, si.SingerName, gr.GroupName, so.Length, g.GenreName, al.AlbumName, so.Released, so.Language, SD.Composer, SD.Arranger, SD.Producer, SD.Lyricist, SD.RecordCompany, SD.Lyric
							from SongDetails SD
							inner join Songs so on SD.SongId = so.Id
							inner join singers si on SD.SingerId = si.Id
							left join Groups gr on gr.Id = SD.GroupId
							inner join Genres g on g.Id = so.GenreId
							left join Albums al on al.Id = SD.AlbumId
							order by so.Id";

			return new SqlDBHelper("default").Select(sql, null)
							.AsEnumerable()
							.Select(row => ToSongIndexVM(row));
		}

		public SongValidationVM Get(int songId, int singerId)
		{
			//todo correct the sql
			string sql = @"select SongId, so.SongName, SingerId, si.SingerName, gr.GroupName, so.Length, g.GenreName, al.AlbumName, so.Released, so.Language, SD.Composer, SD.Arranger, SD.Producer, SD.Lyricist, SD.RecordCompany, SD.Lyric
							from SongDetails SD
							inner join Songs so on SD.SongId = so.Id
							inner join singers si on SD.SingerId = si.Id
							left join Groups gr on gr.Id = SD.GroupId
							inner join Genres g on g.Id = So.GenreId
							left join Albums al on al.Id = SD.AlbumId
							where SongId = @SongId and SingerId = @SingerId";

			var parameters = new SqlParameterBuilder().AddInt("SongId", songId).AddInt("SingerId", singerId).Build();

			var dt = new SqlDBHelper("default").Select(sql, parameters);
			if (dt.Rows.Count == 0) return null;
			var dr = dt.Rows[0];

			return ParseToSongValidationVM(dr);
		}


		public IEnumerable<SongIndexVM> GetByLength(TimeSpan lengthStart, TimeSpan lengthEnd)
		{
			if(lengthEnd == TimeSpan.Zero)
			{
				lengthEnd = new TimeSpan(23, 59, 59);
			}else if (lengthEnd < lengthStart) throw new Exception("Max time value should not less than min value.");

			string sql = @"select SongId, so.SongName, SingerId, si.SingerName, gr.GroupName, so.Length, g.GenreName, al.AlbumName, so.Released, so.Language, SD.Composer, SD.Arranger, SD.Producer, SD.Lyricist, SD.RecordCompany, SD.Lyric
							from SongDetails SD
							inner join Songs so on SD.SongId = so.Id
							inner join singers si on SD.SingerId = si.Id
							left join Groups gr on gr.Id = SD.GroupId
							inner join Genres g on g.Id = So.GenreId
							left join Albums al on al.Id = SD.AlbumId
							where so.Length between @lengthStart and @lengthEnd";

			var parameters = new SqlParameterBuilder().AddTime("lengthStart", lengthStart).AddTime("lengthEnd", lengthEnd).Build();

			return new SqlDBHelper("default").Select(sql, parameters)
							.AsEnumerable()
							.Select(row => ToSongIndexVM(row)); ;
		}

		public IEnumerable<SongIndexVM> GetByReleased(DateTime released)
		{
			if(released > DateTime.Today)
			{
				throw new Exception("Released time should not be over today");
			}

			string sql = @"select SongId, so.SongName, SingerId, si.SingerName, gr.GroupName, so.Length, g.GenreName, al.AlbumName, so.Released, so.Language, SD.Composer, SD.Arranger, SD.Producer, SD.Lyricist, SD.RecordCompany, SD.Lyric
							from SongDetails SD
							inner join Songs so on SD.SongId = so.Id
							inner join singers si on SD.SingerId = si.Id
							left join Groups gr on gr.Id = SD.GroupId
							inner join Genres g on g.Id = So.GenreId
							left join Albums al on al.Id = SD.AlbumId
							where so.Released = @Released";

			var parameters = new SqlParameterBuilder().AddDateTime("Released", released).Build();

			return new SqlDBHelper("default").Select(sql, parameters)
							.AsEnumerable()
							.Select(row => ToSongIndexVM(row)); ;
		}

		public void Create(SongDetailVM model)
		{
			string sql = @"insert into SongDetails(SongId, SingerId, Lyric, GroupId, AlbumId, Composer, Arranger, Lyricist, Producer, RecordCompany)
					values(@SongId, @SingerId, @Lyric, @GroupId, @AlbumId, @Composer, @Arranger, @Lyricist, @Producer, @RecordCompany)";

			var parameters = new SqlParameterBuilder()
									.AddInt("SongId", model.SongId)
									.AddInt("SingerId", model.SingerId)
									.AddNVarChar("Lyric", 3000, model.Lyric)
									.AddNullableInt("GroupId", model.GroupId)
									.AddNullableInt("AlbumId", model.AlbumId)
									.AddNVarChar("Composer", 50, model.Composer)
									.AddNVarChar("Arranger", 50, model.Arranger)
									.AddNVarChar("Lyricist", 50, model.Lyricist)
									.AddNVarChar("Producer", 50, model.Producer)
									.AddNVarChar("RecordCompany", 50, model.RecordCompany)
									.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Update(SongDetailVM model)
		{
			string sql = @"update SongDetails 
							set GroupId = @GroupId,
							AlbumId = @AlbumId,
							Composer = @Composer,
							Arranger = @Arranger,
							Lyricist = @Lyricist,
							Producer = @Producer,
							RecordCompany = @RecordCompany,
							Lyric = @Lyric
							where SongId = @SongId 
							and SingerId = @SingerId";

			var parameters = new SqlParameterBuilder()
									.AddInt("SongId", model.SongId)
									.AddInt("SingerId", model.SingerId)
									.AddNullableInt("GroupId", model.GroupId)
									.AddNullableInt("AlbumId", model.AlbumId)
									.AddNVarChar("Composer", 50, model.Composer)
									.AddNVarChar("Arranger", 50, model.Arranger)
									.AddNVarChar("Lyricist", 50, model.Lyricist)
									.AddNVarChar("Producer", 50, model.Producer)
									.AddNVarChar("RecordCompany", 50, model.RecordCompany)
									.AddNVarChar("Lyric", 3000, model.Lyric)
									.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Delete(int songId, int singerId)
		{
			string sql = "delete from SongDetails where SongId = @SongId and SingerId = @SingerId";

			var parameters = new SqlParameterBuilder().AddInt("SongId", songId).AddInt("SingerId", singerId).Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		private SongValidationVM ParseToSongValidationVM(DataRow dr)
		{
			return new SongValidationVM
			{
				SongId = dr.Field<int>("SongId"),
				SongName = dr.Field<string>("SongName"),
				SingerId = dr.Field<int>("SingerId"),
				SingerName = dr.Field<string>("SingerName"),
				GenreName = dr.Field<string>("GenreName"),
				Language = dr.Field<string>("Language"),
				Length = dr.Field<TimeSpan>("Length"),
				Released = dr.Field<DateTime>("Released"),
				GroupName = dr.Field<string>("GroupName"),
				AlbumName = dr.Field<string>("AlbumName"),
				Composer = dr.Field<string>("Composer"),
				Arranger = dr.Field<string>("Arranger"),
				Producer = dr.Field<string>("Producer"),
				Lyricist = dr.Field<string>("Lyricist"),
				RecordCompany = dr.Field<string>("RecordCompany"),
				Lyric = dr.Field<string>("Lyric"),
			};
		}

		private SongIndexVM ToSongIndexVM(DataRow row)
		{
			return new SongIndexVM
			{
				SongId = row.Field<int>("SongId"),
				SongName = row.Field<string>("SongName"),
				SingerId = row.Field<int>("SingerId"),
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
				Lyric = row.Field<string>("Lyric")
			};
		}
	}
}
