using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSystem.Models.DTOs
{
	public class SongDetailDTO
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

		public string Composer { get; set; }

		public string Arranger { get; set; }

		public string Lyricist { get; set; }

		public string Producer { get; set; }

		public string RecordCompany { get; set; }
	}
}
