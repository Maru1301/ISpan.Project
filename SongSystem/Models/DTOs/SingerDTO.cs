using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSystem.Models.DTOs
{
	public class SingerDTO
	{
		public int Id { get; set; }

		public string SingerName { get; set; }

		public DateTime DateOfBirth { get; set; }

		public bool? Gender { get; set; }

		public string Country { get; set; }

		public int? GroupId { get; set; }

		public string GroupName { get; set; }
	}
}
