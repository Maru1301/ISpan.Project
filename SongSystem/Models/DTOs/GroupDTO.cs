using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSystem.Models.DTOs
{
	public class GroupDTO
	{
		public int Id { get; set; }

		public string GroupName { get; set; }

		public DateTime Established { get; set; }
	}
}
