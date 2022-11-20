﻿using ISpan.SQL.Utility;
using SongSystem.Models.DTOs;
using SongSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSystem.Infra.DAOs
{
	public class UserDAO
	{
		public IEnumerable<UserIndexVM> GetAll()
		{
			string sql = @"select * from Users order by Id DESC";

			return new SqlDBHelper("default").Select(sql, null)
								.AsEnumerable()
								.Select(row => ParseToUserIndexVM(row));
			//.ToList();
		}

		private UserIndexVM ParseToUserIndexVM(DataRow row)
		{
			return new UserIndexVM
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				//Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name")
			};
		}

		public void Create(UserDTO dto)
		{
			string sql = @"insert into Users(Account, Password, Name)
							values(@Account, @Password, @Name)";

			var parameters = new SqlParameterBuilder()
									.AddNVarChar("Account", 50, dto.Account)
									.AddNVarChar("Password", 50, dto.Password)
									.AddNVarChar("Name", 50, dto.Name)
									.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Update(UserDTO dto)
		{
			string sql = @"update Users 
							set 
							Account = @Account, 
							Password = @Password,
							Name = @Name
							where id = @id";
			var parameters = new SqlParameterBuilder()
			.AddInt("id", dto.Id)
										.AddNVarChar("Account", 50, dto.Account)
										.AddNVarChar("Password", 50, dto.Password)
										.AddNVarChar("Name", 50, dto.Name)
										.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Delete(int id)
		{
			string sql = @"delete from Users 
							where id = @id";
			var parameters = new SqlParameterBuilder()
									.AddInt("id", id)
									.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public UserDTO Get(string account)
		{
			string sql = "select * from Users where Account = @Account";
			var parameters = new SqlParameterBuilder()
									.AddNVarChar("Account", 50, account)
									.Build();

			DataTable dt = new SqlDBHelper("default").Select(sql, parameters);

			if (dt.Rows.Count == 0) return null;

			return ToUserDTO(dt.Rows[0]);
		}

		private UserDTO ToUserDTO(DataRow row)
		{
			return new UserDTO
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name")
			};
		}

		public UserDTO GetOneRow(int id)
		{
			string sql = "select * from Users where id = @id";
			var parameters = new SqlParameterBuilder()
									.AddInt("id", id)
									.Build();
			DataTable dt = new SqlDBHelper("default").Select(sql, parameters);
			DataRow dr = dt.Rows[0];

			return ToUserDTO(dr);
		}
	}
}