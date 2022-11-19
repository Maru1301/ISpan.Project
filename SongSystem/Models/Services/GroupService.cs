using ISpan.SQL.Utility;
using SongSystem.Infra.DAOs;
using SongSystem.Models.DTOs;
using SongSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSystem.Models.Services
{
	public class GroupService
	{
		public IEnumerable<GroupIndexVM> GetAll()
		{
			return new GroupDAO().GetAll();
		}

		public GroupVM Get(int? id)
		{
			return new GroupDAO().Get(id);
		}

		public IEnumerable<GroupIndexVM> Get(string value)
		{
			return new GroupDAO().Get(value);
		}

		public void Create(GroupVM model)
		{
			if (GroupExists(model) == true) throw new Exception("Group has existed");

			var dto = ParseToGroupDTO(model);

			new GroupDAO().Create(dto);
		}

		public void Update(GroupVM model)
		{
			if (GroupExists(model) == true) throw new Exception("Group has existed");

			var dto = ParseToGroupDTO(model);

			new GroupDAO().Update(dto);
		}

		public void Delete(int id)
		{
			//if (SingerInGroup(id) == true) throw new Exception("There exists at least one singer in the group");
			new GroupDAO().Delete(id);
		}

		private GroupDTO ParseToGroupDTO(GroupVM model)
		{
			return new GroupDTO
			{
				Id= model.Id,
				GroupName = model.GroupName,
				Established = model.Established,
			};
		}

		public bool GroupExists(GroupVM model)
		{
			var dto = ParseToGroupDTO(model);
			var returnModel = new GroupDAO().GroupExists(dto);

			return returnModel != null;
		}
	}
}
