using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSystem.Models.ViewModels
{
	public class SongIndexVM
	{
		public int SongId { get; set; }
		public string SongName { get; set; }

		public int SingerId { get; set; }
		public string SingerName { get; set; }

		public string GroupName { get; set; }

		public TimeSpan Length { get; set; }

		public string GenreName { get; set; }

		public string AlbumName { get; set; }

		public DateTime Released { get; set; }

		public String Language { get; set; }

		public string Composer { get; set; }

		public string Arranger { get; set; }

		public string Producer { get; set; }

		public string Lyricist { get; set; }

		public string RecordCompany { get; set; }

		public string Lyric { get; set; }
	}

	public class SongValidationVM
	{
		public int SongId { get; set; }

		[Required(ErrorMessage = "Song name is required")]
		public string SongName { get; set; }

		public int SingerId { get; set; }
		[Required(ErrorMessage = "Singer name is required")]
		public string SingerName { get; set; }

		public string GroupName { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		[CustomValidation(typeof(SongVM), "ValidateTimeSpan", ErrorMessage = "Length could not be zero")]
		public TimeSpan Length { get; set; }

		[Required(ErrorMessage = "Genre name is required")]
		public string GenreName { get; set; }

		public string AlbumName { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		public DateTime Released { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		public String Language { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		public string Composer { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		public string Arranger { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		public string Producer { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		public string Lyricist { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		public string RecordCompany { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		public string Lyric { get; set; }
	}
	public class SongVM
	{
		public int SongId { get; set; }

		[Required(ErrorMessage = "Song name is required")]
		public string SongName { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		[CustomValidation(typeof(SongVM), "ValidateTimeSpan", ErrorMessage = "Length could not be zero")]
		public TimeSpan Length { get; set; }

		public int GenreId { get; set; }

		[Required(ErrorMessage = "Genre name is required")]
		public string GenreName { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		public String Language { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		public DateTime Released { get; set; }

		public static ValidationResult ValidateTimeSpan(TimeSpan x, ValidationContext context)
		{
			return (x.TotalSeconds == 0) ? new ValidationResult(null, new string[] { "Length" })
				: ValidationResult.Success;
		}
	}

	public class SongDetailVM
	{
		public int SongId { get; set; }

		[Required(ErrorMessage = "Song name is required")]
		public string SongName { get; set; }

		public int SingerId { get; set; }

		[Required(ErrorMessage = "Singer name is required")]
		public string SingerName { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		public string Lyric { get; set; }

		public int? GroupId { get; set; }

		public string GroupName { get; set; }

		public int? AlbumId { get; set; }

		public string AlbumName { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		public string Composer { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		public string Arranger { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		public string Lyricist { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		public string Producer { get; set; }

		[Required(ErrorMessage = "{0} is required")]
		public string RecordCompany { get; set; }
	}
}
