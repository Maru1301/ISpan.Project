using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSystem.Models.DTOs
{
	public class AlbumDTO
	{
		public int Id { get; set; }

		public string AlbumName { get; set; }

		public DateTime Released { get; set; }
	}
}
