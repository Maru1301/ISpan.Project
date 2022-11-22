using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSystem.Models.ViewModels
{
	public class GroupIndexVM
	{
		public int Id { get; set; }
		public string GroupName { get; set; }
		public DateTime Established { get; set; }
	}
	public class GroupVM
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Group Name is required")]
		public string GroupName { get; set; }
		[Required(ErrorMessage = "{0} Time is required")]
		[CustomValidation(typeof(GroupVM), "ValidateEstablished", ErrorMessage = "{0} time could not be over today.")]
		public DateTime Established { get; set; }

		public static ValidationResult ValidateEstablished(DateTime es, ValidationContext context)
		{
			return (es < DateTime.Today.AddDays(1)) ? ValidationResult.Success :
				new ValidationResult(null, new string[] { "Established" });
		}
	}
}
