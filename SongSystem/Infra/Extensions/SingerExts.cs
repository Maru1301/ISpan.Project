using SongSystem.Models.DTOs;

namespace SongSystem.Models.ViewModels
{
	public static class SingerExts
	{
		public static SingerDTO ToSingerDTO(this SingerVM model)
		{
			return new SingerDTO
			{
				Id = model.Id,
				SingerName = model.SingerName,
				DateOfBirth = model.DateOfBirth,
				Gender = model.Gender,
				Country = model.Country,
				GroupId = model.GroupId,
				GroupName = model.GroupName,
			};
		}
	}
}
