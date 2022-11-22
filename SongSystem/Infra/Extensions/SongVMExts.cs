using SongSystem.Models.DTOs;

namespace SongSystem.Models.ViewModels
{
	public static class SongVMExts
	{
		public static SongDTO ToSongDTO(this SongVM model)
		{
			return new SongDTO
			{
				SongId = model.SongId,
				SongName = model.SongName,
				GenreId = model.GenreId,
				GenreName = model.GenreName,
				Language = model.Language,
				Released = model.Released,
				Length = model.Length,
			};
		}

		public static SongDetailDTO ToSongDetailDTO(this SongDetailVM model)
		{
			return new SongDetailDTO
			{
				SongId = model.SongId,
				SongName = model.SongName,
				SingerId = model.SingerId,
				SingerName = model.SingerName,
				Lyric = model.Lyric,
				GroupId = model.GroupId,
				GroupName = model.GroupName,
				AlbumId = model.AlbumId,
				AlbumName = model.AlbumName,
				Composer = model.Composer,
				Arranger = model.Arranger,
				Lyricist = model.Lyricist,
				Producer = model.Producer,
				RecordCompany = model.RecordCompany,
			};
		}
	}
}
