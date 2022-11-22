using SongSystem.Models.DTOs;

namespace SongSystem.Models.ViewModels
{
	public static class GroupExts
	{
		public static GroupDTO ToGroupDTO(this GroupVM model)
		{
			return new GroupDTO
			{
				Id = model.Id,
				GroupName = model.GroupName,
				Established = model.Established,
			};
		}
	}
}
