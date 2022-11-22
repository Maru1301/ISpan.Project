using SongSystem.Models.DTOs;

namespace SongSystem.Models.ViewModels
{
	public static class GenreExts
	{
		public static GenreDTO ToGenreDTO(this GenreVM model)
		{
			return new GenreDTO
			{
				Id = model.Id,
				GenreName = model.GenreName,
			};
		}
	}
}
