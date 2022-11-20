using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSystem.Models.ViewModels
{
	public class LoginVM
	{
		[Required(ErrorMessage = "Account is required")]
		[MaxLength(16, ErrorMessage = "The Account value cannot exceed 16 characters.")]
		[MinLength(3, ErrorMessage = "The Account value cannot be less than 3 characters.")]
		public string Account { get; set; }

		[Required(ErrorMessage = "Password is required")]
		public string Password { get; set; }
	}
}
