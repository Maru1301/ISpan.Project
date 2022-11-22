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
	public class GenreService
	{
		public IEnumerable<GenreIndexVM> GetAll()
		{
			return new GenreDAO().GetAll();
		}

		public GenreVM Get(int id)
		{
			return new GenreDAO().Get(id);
		}

		public IEnumerable<GenreIndexVM> Get(string genreName)
		{
			return new GenreDAO().Get(genreName);
		}


		public void Create(GenreVM model)
		{
			if (GenreExists(model) == true) throw new Exception("Genre Name has existed");

			var dto = model.ToGenreDTO();

			new GenreDAO().Create(dto);
		}

		public void Update(GenreVM model)
		{
			if (GenreExists(model) == true) throw new Exception("Genre Name has existed");

			var dto = model.ToGenreDTO();

			new GenreDAO().Update(dto);
		}

		public void Delete(int id)
		{
			new GenreDAO().Delete(id);
		}

		private bool GenreExists(GenreVM model)
		{
			var dto = model.ToGenreDTO();

			var returnModel =  new GenreDAO().GenreExists(dto);

			return returnModel != null;
		}
	}
}
