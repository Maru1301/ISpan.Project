using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongSystem.Infra.Extensions
{
	public class ValidationHelper
	{
		public static bool Validate<T>(T model, Dictionary<string, Control> map, ErrorProvider errorProvider)
		{
			ValidationContext context = new ValidationContext(model, null, null);
			List<ValidationResult> errors = new List<ValidationResult>();

			errorProvider.Clear();
			bool ValidateAllProperties = true;
			bool isValid = Validator.TryValidateObject(model, context, errors, ValidateAllProperties);
			if (isValid == false)
			{
				DisplayErrorByErrorProvider(errors, map, errorProvider);
			}
			return isValid;
		}

		private static void DisplayErrorByErrorProvider(List<ValidationResult> errors, Dictionary<string, Control> map, ErrorProvider errorProvider)
		{
			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.SingleOrDefault();
				if (map.TryGetValue(propName, out Control ctr1))
				{
					errorProvider.SetError(ctr1, error.ErrorMessage);
				}
			}
		}
	}
}
