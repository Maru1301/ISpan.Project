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
	public class SongDetailDAO
	{
		private string originalSql = @"select songId, SongName, left(SingerName, len(SingerName)-1) as SingerName, Length, GenreName, Language, Released, Lyric, GroupName, AlbumName, Composer, Arranger, lyricist, Producer, RecordCompany from
(select s.Id as SongId, SongName, Length, GenreName, Language, Released, Lyric, GroupName,AlbumName, 
composer, Arranger, Lyricist, Producer, RecordCompany,(
	SELECT CAST(SingerName as nvarchar) + ','
	from SongDetails
	join Singers on SongDetails.SingerId = Singers.Id
	where SongId = S.Id
	for xml path('')
	) as SingerName
from Songs S
join Genres on Genres.Id = S.GenreId
join (
	select SongId, Lyric, GroupName, AlbumName, composer, Arranger, Lyricist, Producer, RecordCompany
	from SongDetails SD 
	join Songs S on S.Id = SD.SongId
	join Genres G on S.GenreId = G.Id
	left join Groups Gr on Gr.Id = SD.GroupId
	left join Albums Al on Al.Id = SD.AlbumId
	group by SongId, Lyric, GroupName, AlbumName, composer, Arranger, Lyricist, Producer, RecordCompany
	) as SongDetail on SongDetail.SongId = S.Id) as SongDetailTable";
		public IEnumerable<SongIndexVM> GetAll()
		{
			string sql = originalSql;

			return new SqlDBHelper("default").Select(sql, null)
							.AsEnumerable()
							.Select(row => ToSongIndexVM(row));
		}

		public SongValidationVM Get(int songId)
		{
			string sql = originalSql + " where SongId = @SongId";

			var parameters = new SqlParameterBuilder().AddInt("SongId", songId).Build();

			var dt = new SqlDBHelper("default").Select(sql, parameters);
			if (dt.Rows.Count == 0) return null;
			var dr = dt.Rows[0];

			return ParseToSongValidationVM(dr);
		}

		public IEnumerable<SongIndexVM> GetByLength(TimeSpan lengthStart, TimeSpan lengthEnd)
		{
			if (lengthEnd == TimeSpan.Zero)
			{
				lengthEnd = new TimeSpan(23, 59, 59);
			}
			else if (lengthEnd < lengthStart) throw new Exception("Max time value should not less than min value.");

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
			if (released > DateTime.Today)
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

		public IEnumerable<SongIndexVM> GetBySinger(string singer)
		{
			string sql = @"select * from
(select s.Id as SongId, SongName, Length, GenreName, Language, Released, Lyric, GroupName,AlbumName, 
composer, Arranger, Lyricist, Producer, RecordCompany,(
	SELECT CAST(SingerName as nvarchar) + ','
	from SongDetails
	join Singers on SongDetails.SingerId = Singers.Id
	where SongId = S.Id
	for xml path('')
	) as SingerName
from Songs S
join Genres on Genres.Id = S.GenreId
join (
	select SongId, Lyric, GroupName, AlbumName, composer, Arranger, Lyricist, Producer, RecordCompany
	from SongDetails SD 
	join Songs S on S.Id = SD.SongId
	join Genres G on S.GenreId = G.Id
	left join Groups Gr on Gr.Id = SD.GroupId
	left join Albums Al on Al.Id = SD.AlbumId
	group by SongId, Lyric, GroupName, AlbumName, composer, Arranger, Lyricist, Producer, RecordCompany
	) as SongDetail on SongDetail.SongId = S.Id) as SongDetailTable
where SingerName like @SingerName";

			var parameters = new SqlParameterBuilder().AddNVarChar("SingerName", 50, singer).Build();

			return new SqlDBHelper("default").Select(sql, parameters)
							.AsEnumerable()
							.Select(row => ToSongIndexVM(row)); ;
		}

		public IEnumerable<SongIndexVM> GetByGroup(string group)
		{
			string sql = @"select * from
(select s.Id as SongId, SongName, Length, GenreName, Language, Released, Lyric, GroupName,AlbumName, 
composer, Arranger, Lyricist, Producer, RecordCompany,(
	SELECT CAST(SingerName as nvarchar) + ','
	from SongDetails
	join Singers on SongDetails.SingerId = Singers.Id
	where SongId = S.Id
	for xml path('')
	) as SingerName
from Songs S
join Genres on Genres.Id = S.GenreId
join (
	select SongId, Lyric, GroupName, AlbumName, composer, Arranger, Lyricist, Producer, RecordCompany
	from SongDetails SD 
	join Songs S on S.Id = SD.SongId
	join Genres G on S.GenreId = G.Id
	left join Groups Gr on Gr.Id = SD.GroupId
	left join Albums Al on Al.Id = SD.AlbumId
	group by SongId, Lyric, GroupName, AlbumName, composer, Arranger, Lyricist, Producer, RecordCompany
	) as SongDetail on SongDetail.SongId = S.Id) as SongDetailTable
							where GroupName like @GroupName";

			var parameters = new SqlParameterBuilder().AddNVarChar("GroupName", 50, group).Build();

			return new SqlDBHelper("default").Select(sql, parameters)
							.AsEnumerable()
							.Select(row => ToSongIndexVM(row)); ;
		}

		public IEnumerable<SongIndexVM> GetByGenre(string genre)
		{
			string sql = @"select * from
(select s.Id as SongId, SongName, Length, GenreName, Language, Released, Lyric, GroupName,AlbumName, 
composer, Arranger, Lyricist, Producer, RecordCompany,(
	SELECT CAST(SingerName as nvarchar) + ','
	from SongDetails
	join Singers on SongDetails.SingerId = Singers.Id
	where SongId = S.Id
	for xml path('')
	) as SingerName
from Songs S
join Genres on Genres.Id = S.GenreId
join (
	select SongId, Lyric, GroupName, AlbumName, composer, Arranger, Lyricist, Producer, RecordCompany
	from SongDetails SD 
	join Songs S on S.Id = SD.SongId
	join Genres G on S.GenreId = G.Id
	left join Groups Gr on Gr.Id = SD.GroupId
	left join Albums Al on Al.Id = SD.AlbumId
	group by SongId, Lyric, GroupName, AlbumName, composer, Arranger, Lyricist, Producer, RecordCompany
	) as SongDetail on SongDetail.SongId = S.Id) as SongDetailTable
							where GenreName like @GenreName";

			var parameters = new SqlParameterBuilder().AddNVarChar("GenreName", 50, genre).Build();

			return new SqlDBHelper("default").Select(sql, parameters)
							.AsEnumerable()
							.Select(row => ToSongIndexVM(row)); ;
		}

		public IEnumerable<SongIndexVM> GetByAlbum(string album)
		{
			string sql = @"select * from
(select s.Id as SongId, SongName, Length, GenreName, Language, Released, Lyric, GroupName,AlbumName, 
composer, Arranger, Lyricist, Producer, RecordCompany,(
	SELECT CAST(SingerName as nvarchar) + ','
	from SongDetails
	join Singers on SongDetails.SingerId = Singers.Id
	where SongId = S.Id
	for xml path('')
	) as SingerName
from Songs S
join Genres on Genres.Id = S.GenreId
join (
	select SongId, Lyric, GroupName, AlbumName, composer, Arranger, Lyricist, Producer, RecordCompany
	from SongDetails SD 
	join Songs S on S.Id = SD.SongId
	join Genres G on S.GenreId = G.Id
	left join Groups Gr on Gr.Id = SD.GroupId
	left join Albums Al on Al.Id = SD.AlbumId
	group by SongId, Lyric, GroupName, AlbumName, composer, Arranger, Lyricist, Producer, RecordCompany
	) as SongDetail on SongDetail.SongId = S.Id) as SongDetailTable
							where AlbumName like @AlbumName";

			var parameters = new SqlParameterBuilder().AddNVarChar("AlbumName", 50, album).Build();

			return new SqlDBHelper("default").Select(sql, parameters)
							.AsEnumerable()
							.Select(row => ToSongIndexVM(row)); ;
		}

		public IEnumerable<SongIndexVM> GetByLangauge(string language)
		{
			string sql = @"select * from
(select s.Id as SongId, SongName, Length, GenreName, Language, Released, Lyric, GroupName,AlbumName, 
composer, Arranger, Lyricist, Producer, RecordCompany,(
	SELECT CAST(SingerName as nvarchar) + ','
	from SongDetails
	join Singers on SongDetails.SingerId = Singers.Id
	where SongId = S.Id
	for xml path('')
	) as SingerName
from Songs S
join Genres on Genres.Id = S.GenreId
join (
	select SongId, Lyric, GroupName, AlbumName, composer, Arranger, Lyricist, Producer, RecordCompany
	from SongDetails SD 
	join Songs S on S.Id = SD.SongId
	join Genres G on S.GenreId = G.Id
	left join Groups Gr on Gr.Id = SD.GroupId
	left join Albums Al on Al.Id = SD.AlbumId
	group by SongId, Lyric, GroupName, AlbumName, composer, Arranger, Lyricist, Producer, RecordCompany
	) as SongDetail on SongDetail.SongId = S.Id) as SongDetailTable
							where Language like @Language";

			var parameters = new SqlParameterBuilder().AddNVarChar("Language", 50, language).Build();

			return new SqlDBHelper("default").Select(sql, parameters)
							.AsEnumerable()
							.Select(row => ToSongIndexVM(row)); ;
		}

		public IEnumerable<SongIndexVM> GetByRecordCompany(string recordCompany)
		{
			string sql = @"select * from
(select s.Id as SongId, SongName, Length, GenreName, Language, Released, Lyric, GroupName,AlbumName, 
composer, Arranger, Lyricist, Producer, RecordCompany,(
	SELECT CAST(SingerName as nvarchar) + ','
	from SongDetails
	join Singers on SongDetails.SingerId = Singers.Id
	where SongId = S.Id
	for xml path('')
	) as SingerName
from Songs S
join Genres on Genres.Id = S.GenreId
join (
	select SongId, Lyric, GroupName, AlbumName, composer, Arranger, Lyricist, Producer, RecordCompany
	from SongDetails SD 
	join Songs S on S.Id = SD.SongId
	join Genres G on S.GenreId = G.Id
	left join Groups Gr on Gr.Id = SD.GroupId
	left join Albums Al on Al.Id = SD.AlbumId
	group by SongId, Lyric, GroupName, AlbumName, composer, Arranger, Lyricist, Producer, RecordCompany
	) as SongDetail on SongDetail.SongId = S.Id) as SongDetailTable
							where RecordCompany like @RecordCompany";

			var parameters = new SqlParameterBuilder().AddNVarChar("RecordCompany", 50, recordCompany).Build();

			return new SqlDBHelper("default").Select(sql, parameters)
							.AsEnumerable()
							.Select(row => ToSongIndexVM(row)); ;
		}
		public void Create(SongDetailDTO model)
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

		public void Update(SongDetailDTO model)
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

		public SongDetailVM SongDetailExists(SongDetailDTO model, bool checkForUpdate = false)
		{
			string sql = "select * from SongDetails where SongId = @SongId and SingerId = @SingerId";
			var parameterbuilder = new SqlParameterBuilder().AddInt("SongId", model.SongId).AddInt("SingerId", model.SingerId);

			if (checkForUpdate == true)
			{
				sql += " and Arranger != @Arranger";
				parameterbuilder = parameterbuilder.AddVarChar("Arranger", 50, model.Arranger);
			}
			var parameters = parameterbuilder.Build();

			var dt = new SqlDBHelper("default").Select(sql, parameters);
			if (dt.Rows.Count == 0) return null;
			var dr = dt.Rows[0];

			return ParseToSongDetailVM(dr);
		}

		private SongDetailVM ParseToSongDetailVM(DataRow dr)
		{
			return new SongDetailVM
			{
				SongId = dr.Field<int>("SongId"),
				//SongName = dr.Field<string>("SongName"),
				SingerId = dr.Field<int>("SingerId"),
				//SingerName = dr.Field<string>("SingerName"),
				//GroupName = dr.Field<string>("GroupName"),
				//AlbumName = dr.Field<string>("AlbumName"),
				Composer = dr.Field<string>("Composer"),
				Arranger = dr.Field<string>("Arranger"),
				Producer = dr.Field<string>("Producer"),
				Lyricist = dr.Field<string>("Lyricist"),
				RecordCompany = dr.Field<string>("RecordCompany"),
				Lyric = dr.Field<string>("Lyric"),
				AlbumId = dr.Field<int?>("AlbumId"),
				GroupId = dr.Field<int?>("GroupId"),
			};
		}

		private SongValidationVM ParseToSongValidationVM(DataRow dr)
		{
			return new SongValidationVM
			{
				SongId = dr.Field<int>("SongId"),
				SongName = dr.Field<string>("SongName"),
				//SingerId = dr.Field<int>("SingerId"),
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
				//SingerId = row.Field<int>("SingerId"),
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
