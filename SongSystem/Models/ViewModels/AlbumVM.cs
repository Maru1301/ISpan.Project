using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSystem.Models.ViewModels
{
	public class AlbumIndexVM
	{
		public int Id { get; set; }

		public string AlbumName { get; set; }

		public DateTime Released { get; set; }
	}
	public class AlbumVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "{0} is required!")]
		public string AlbumName { get; set; }

		[CustomValidation(typeof(AlbumVM), "ValidateReleased", ErrorMessage = "Released time could not be over today.")]
		public DateTime Released { get; set; }

		public static ValidationResult ValidateReleased(DateTime re, ValidationContext context)
		{
			return (re < DateTime.Today.AddDays(1)) ? ValidationResult.Success: new ValidationResult(null, new string[] { "Released" });
		}
	}
}
