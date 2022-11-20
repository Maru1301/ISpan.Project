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

			var dto = ParseToGenreDTO(model);

			new GenreDAO().Create(dto);
		}

		public void Update(GenreVM model)
		{
			if (GenreExists(model) == true) throw new Exception("Genre Name has existed");

			var dto = ParseToGenreDTO(model);

			new GenreDAO().Update(dto);
		}

		public void Delete(int id)
		{
			new GenreDAO().Delete(id);
		}

		private GenreDTO ParseToGenreDTO(GenreVM model)
		{
			return new GenreDTO
			{
				Id = model.Id,
				GenreName = model.GenreName,
			};
		}

		private bool GenreExists(GenreVM model)
		{
			var dto = ParseToGenreDTO(model);

			var returnModel =  new GenreDAO().GenreExists(dto);

			return returnModel != null;
		}
	}
}
