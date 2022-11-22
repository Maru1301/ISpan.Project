using SongSystem.Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSystem.Models.ViewModels
{
	public class UserIndexVM
	{
		public int Id { get; set; }
		public string Account { get; set; }
		public string Name { get; set; }
		public int Permissions { get; set; }
	}

	public class UserVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		[MaxLength(16, ErrorMessage = "The Account value cannot exceed 16 characters.")]
		[MinLength(3, ErrorMessage = "The Account value cannot be less than 3 characters.")]
		public string Account { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		public string Password { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		public string Name { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		[RegularExpression(@"[1-5]", ErrorMessage = "Permissions value is from 1 to 5")]
		public int Permissions { get; set; }
	}

	public static class UserVMExts
	{
		public static UserDTO ToUserDTO(this UserVM model)
		{
			return new UserDTO
			{
				Id = model.Id,
				Account = model.Account,
				Password = model.Password,
				Name = model.Name,
				Permissions= model.Permissions,
			};
		}
	}
}
