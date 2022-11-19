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
	public class AlbumService
	{
		public IEnumerable<AlbumIndexVM> GetAll()
		{
			return new AlbumDAO().GetAll();
		}

		public AlbumVM Get(int? id)
		{
			return new AlbumDAO().Get(id);
		}

		public IEnumerable<AlbumIndexVM> Get(string albumName)
		{
			return new AlbumDAO().Get(albumName);
		}

		public void Create(AlbumVM model)
		{
			if (AlbumExists(model) == true) throw new Exception("Genre Name has existed");

			var dto = ParseToAlbumDTO(model);

			new AlbumDAO().Create(dto);
		}

		public void Update(AlbumVM model)
		{
			if (AlbumExists(model) == true) throw new Exception("Genre Name has existed");

			var dto = ParseToAlbumDTO(model);

			new AlbumDAO().Update(dto);
		}

		public void Delete(int id)
		{
			new AlbumDAO().Delete(id);
		}
		private AlbumDTO ParseToAlbumDTO(AlbumVM model)
		{
			return new AlbumDTO
			{
				Id = model.Id,
				AlbumName = model.AlbumName,
				Released = model.Released,
			};
		}

		private bool AlbumExists(AlbumVM model)
		{
			var dto = ParseToAlbumDTO(model);

			var returnModel = new AlbumDAO().AlbumExists(dto);

			return returnModel == null;
		}
	}
}
