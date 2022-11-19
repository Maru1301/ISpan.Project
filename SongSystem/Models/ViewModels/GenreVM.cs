using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSystem.Models.ViewModels
{
	public class GenreIndexVM
	{
		public int Id { get; set; }
		public string GenreName { get; set; }
	}
	public class GenreVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Genre name is required!")]
		public string GenreName { get; set; }
	}
}
