using SongSystem.Models.DTOs;

namespace SongSystem.Models.ViewModels
{
	public static class AlbumExts
	{
		public static AlbumDTO ToAlbumDTO(this AlbumVM model)
		{
			return new AlbumDTO
			{
				Id = model.Id,
				AlbumName = model.AlbumName,
				Released = model.Released,
			};
		}
	}
}
