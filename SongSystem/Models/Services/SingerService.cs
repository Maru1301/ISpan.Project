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
	public class SingerService
	{
		public IEnumerable<SingerIndexVM> GetAll()
		{
			return new SingerDAO().GetAll();
		}

		public SingerVM Get(int id)
		{
			return new SingerDAO().Get(id);
		}

		public IEnumerable<SingerIndexVM> GetBySingerName(string singerName)
		{
			return new SingerDAO().GetBySingerName(singerName);
		}

		public IEnumerable<SingerIndexVM> GetByDateOfBirth(DateTime dt)
		{
			return new SingerDAO().GetByDateOfBirth(dt);
		}

		public IEnumerable<SingerIndexVM> GetByCountry(string country)
		{
			return new SingerDAO().GetByCountry(country);
		}

		public IEnumerable<SingerIndexVM> GetByGroupName(string country)
		{
			return new SingerDAO().GetByGroupName(country);
		}

		public void Create(SingerVM model)
		{
			if (GroupExists(model) == false) throw new Exception("Group does not exist");

			var dto = model.ToSingerDTO();

			new SingerDAO().Create(dto);
		}

		public void Update(SingerVM model)
		{
			if (GroupExists(model) == false) throw new Exception("Group does not exist");

			var dto = model.ToSingerDTO();

			new SingerDAO().Update(dto);
		}

		public void Delete(int id)
		{
			new SingerDAO().Delete(id);
		}

		private bool GroupExists(SingerVM model)
		{
			if (model.GroupName == string.Empty && model.GroupId == null) return true;

			var dto = model.ToSingerDTO();
			var returnModel = new SingerDAO().GroupExists(dto);

			return returnModel != null;
		}
	}
}
