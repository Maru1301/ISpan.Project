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
	public class SongDetailService
	{
		public IEnumerable<SongIndexVM> GetAll()
		{
			return new SongDetailDAO().GetAll();
		}

		public SongValidationVM Get(int songId, int singerId)
		{
			return new SongDetailDAO().Get(songId, singerId);
		}

		public IEnumerable<SongIndexVM> GetByLength(TimeSpan lengthStart, TimeSpan lengthEnd)
		{
			if(lengthEnd == TimeSpan.Zero)
			{
				lengthEnd = new TimeSpan(23, 59, 59);
			}else if (lengthEnd < lengthStart) throw new Exception("Max time value should not less than min value.");

			return new SongDetailDAO().GetByLength(lengthStart, lengthEnd);
		}

		public IEnumerable<SongIndexVM> GetByReleased(DateTime released)
		{
			if(released > DateTime.Today)
			{
				throw new Exception("Released time should not be over today");
			}

			return new SongDetailDAO().GetByReleased(released);
		}

		public IEnumerable<SongIndexVM> GetBySinger(string singer)
		{
			return new SongDetailDAO().GetBySinger(singer);
		}

		public IEnumerable<SongIndexVM> GetByGroup(string group)
		{
			return new SongDetailDAO().GetByGroup(group);
		}

		public IEnumerable<SongIndexVM> GetByGenre(string genre)
		{
			return new SongDetailDAO().GetByGenre(genre);
		}

		public IEnumerable<SongIndexVM> GetByAlbum(string album)
		{
			return new SongDetailDAO().GetByAlbum(album);
		}

		public IEnumerable<SongIndexVM> GetByLangauge(string language)
		{
			return new SongDetailDAO().GetByLangauge(language);
		}

		public IEnumerable<SongIndexVM> GetByRecordCompany(string recordCompany)
		{
			return new SongDetailDAO().GetByRecordCompany(recordCompany);
		}
		public void Create(SongDetailVM model)
		{
			// check existence
			var dto = ParseToSongDetailDTO(model);
			new SongDetailDAO().Create(dto);
		}

		public void Update(SongDetailVM model)
		{
			//todo check existence
			var dto = ParseToSongDetailDTO(model);
			new SongDetailDAO().Update(dto);
		}

		public void Delete(int songId, int singerId)
		{
			new SongDetailDAO().Delete(songId, singerId);
		}

		private SongDetailDTO ParseToSongDetailDTO(SongDetailVM model)
		{
			return new SongDetailDTO
			{
				SongId = model.SongId,
				SongName = model.SongName,
				SingerId = model.SingerId,
				SingerName = model.SingerName,
				Lyric = model.Lyric,
				GroupId = model.GroupId,
				GroupName = model.GroupName,
				AlbumId = model.AlbumId,
				AlbumName = model.AlbumName,
				Composer = model.Composer,
				Arranger = model.Arranger,
				Lyricist = model.Lyricist,
				Producer = model.Producer,
				RecordCompany = model.RecordCompany,
			};
		}
	}
}
