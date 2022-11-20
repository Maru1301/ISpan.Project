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
		//public string Password { get; set; }
		public string Name { get; set; }
	}

	public class UserVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Account is required")]
		[MaxLength(16, ErrorMessage = "The Account value cannot exceed 16 characters.")]
		[MinLength(3, ErrorMessage = "The Account value cannot be less than 3 characters.")]
		public string Account { get; set; }

		[Required(ErrorMessage = "Password is required")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Name is required")]
		public string Name { get; set; }
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
			};
		}
	}
}
