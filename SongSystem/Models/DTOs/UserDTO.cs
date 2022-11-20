using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSystem.Models.DTOs
{
	public class UserDTO
	{
		public int Id { get; set; }

		public string Account { get; set; }

		public string Password { get; set; }

		public string Name { get; set; }

		public int Permissions { get; set; }
	}
}
