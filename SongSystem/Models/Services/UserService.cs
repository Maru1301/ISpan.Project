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
	public class UserService
	{
		public UserVM Get(string account)
		{
			return new UserDAO().Get(account);
		}

		public void Create(UserDTO dto)
		{
			//AccountValidation
			if (AccountExists(dto.Account)) throw new Exception("the account has existed!");

			new UserDAO().Create(dto);
		}

		private bool AccountExists(string account, int id = -1)
		{
			var parameterBuilder = new SqlParameterBuilder();
			string sql = "select count(*) as count from Users where Account = @Account";
			if (id != -1)
			{
				sql += " and id != @id";
				parameterBuilder = parameterBuilder.AddInt("Id", id);
			}

			var parameters = parameterBuilder.AddVarChar("Account", 50, account)
									.Build();
			DataTable dt = new SqlDBHelper("default").Select(sql, parameters);

			return dt.Rows[0].Field<int>("count") > 0;
		}

		public void Update(UserDTO dto)
		{
			//AccountValidation
			if (AccountExists(dto.Account, dto.Id)) throw new Exception("the account has existed!");

			new UserDAO().Update(dto);
		}

		public void Delete(int id)
		{
			new UserDAO().Delete(id);
		}

		public bool Authenticate(LoginVM model)
		{
			var user = new UserDAO().Get(model.Account);
			if (user == null) return false;

			return (user.Password == model.Password);
		}
	}
}
