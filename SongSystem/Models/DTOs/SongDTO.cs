using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSystem.Models.DTOs
{
	public class SongDTO
	{
		public int SongId { get; set; }

		public string SongName { get; set; }

		public TimeSpan Length { get; set; }

		public int GenreId { get; set; }

		public string GenreName { get; set; }

		public String Language { get; set; }

		public DateTime Released { get; set; }
	}
}
