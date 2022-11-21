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

		public SongValidationVM Get(int songId)
		{
			return new SongDetailDAO().Get(songId);
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
		public void Create(SongDetailVM model, Dictionary<int, string> singerList)
		{
			// check each singer in song detail
			foreach(string singerName in singerList.Values)
			{
				model.SingerName = singerName;
				// check existence
				if (SongDetailExists(model) == true) throw new Exception("Song has existed");
			}

			foreach(int singerId in singerList.Keys)
			{
				model.SingerId = singerId;

				Create(model);
			}
		}

		public void Create(SongDetailVM model)
		{
			var dto = ParseToSongDetailDTO(model);
			new SongDetailDAO().Create(dto);
		}

		public void Update(SongDetailVM model, Dictionary<int, string> singerList)
		{
			foreach (string singerName in singerList.Values)
			{
				bool checkForUpdate = true;
				model.SingerName = singerName;
				// check existence
				if (SongDetailExists(model, checkForUpdate) == true) throw new Exception("Song has existed");
			}

			var temp = new Dictionary<int, string>(singerList);
			foreach (var singer in temp)
			{
				model.SingerId = singer.Key;
				model.SingerName = singer.Value;

				//if song detail doesn't exist, create first
				if (SongDetailExists(model) == false)
				{
					Create(model);
				}
				else
				{
					var dto = ParseToSongDetailDTO(model);
					new SongDetailDAO().Update(dto);
				}
			}

			//get all song detail having the model's song id
			var allSongDetail = new SongDetailDAO().Get(model.SongId);
			List<string> detailList = allSongDetail.SingerName.Split(',').ToList();
			//delete the song details which are not in the update data
			foreach(string singerName in detailList)
			{
				if (singerList.ContainsValue(singerName) == false)
				{
					int singerId = new SingerDAO().GetBySingerName(singerName).ToArray()[0].Id;
					Delete(model.SongId, singerId);
				}
			}
		}

		public void Delete(int songId, int singerId)
		{
			new SongDetailDAO().Delete(songId, singerId);
		}

		private bool SongDetailExists(SongDetailVM model, bool checkForUpdate = false)
		{
			var dto = ParseToSongDetailDTO(model);
			var returnModel = new SongDetailDAO().SongDetailExists(dto, checkForUpdate);

			return returnModel != null;
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
