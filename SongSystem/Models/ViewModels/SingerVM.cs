using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSystem.Models.ViewModels
{
	public class SingerIndexVM
	{
		public int Id { get; set; }
		public string SingerName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Gender { get; set; }
		public string Country { get; set; }
		public int? GroupId { get; set; }
		public string GroupName { get; set; }
	}
	public class SingerVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Singer Name is required!")]
		public string SingerName { get; set; }

		[CustomValidation(typeof(SingerVM), "ValidateDateOfBirth", ErrorMessage = "Date of birth could not be over today.")]
		public DateTime DateOfBirth { get; set; }

		[CustomValidation(typeof(SingerVM), "ValidateGender", ErrorMessage = "Gender is required")]
		public bool? Gender { get; set; }

		[Required(ErrorMessage = "{0} is required!")]
		public string Country { get; set; }

		public int? GroupId { get; set; }

		public string GroupName { get; set; }

		public static ValidationResult ValidateDateOfBirth(DateTime dt, ValidationContext context)
		{
			return (dt < DateTime.Today.AddDays(1)) ? ValidationResult.Success
				: new ValidationResult(null, new string[] { "DateOfBirth" });
		}

		public static ValidationResult ValidateGender(bool? gender, ValidationContext context)
		{
			return (gender != null) ? ValidationResult.Success : new ValidationResult(null, new string[] { "Gender" });
		}
	}
}
