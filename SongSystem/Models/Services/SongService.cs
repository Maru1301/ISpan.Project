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
	public class SongService
	{
		public IEnumerable<SongIndexVM> GetAll()
		{
			return new SongDAO().GetAll();
		}

		public SongVM Get(int id)
		{
			return new SongDAO().Get(id);
		}

		public SongVM Get(string songName)
		{
			return new SongDAO().Get(songName);
		}

		public void Create(SongVM model)
		{
			if (SongExists(model) == true) throw new Exception("Song has existed");
			var dto = model.ToSongDTO();

			new SongDAO().Create(dto);
		}

		public void Update(SongVM model)
		{
			if (SongExists(model) == true) throw new Exception("Song has existed");
			var dto = model.ToSongDTO();

			new SongDAO().Update(dto);
		}

		public void Delete(int id)
		{
			new SongDAO().Delete(id);
		}

		private bool SongExists(SongVM model)
		{
			var dto = model.ToSongDTO();
			var returnModel = new SongDAO().SongExists(dto);

			return returnModel != null;
		}

	}
}
