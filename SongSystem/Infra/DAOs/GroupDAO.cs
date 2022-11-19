using ISpan.SQL.Utility;
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
	public class GroupDAO
	{
		public IEnumerable<GroupIndexVM> GetAll()
		{
			string sql = "select * from Groups order by Created_at";

			return new SqlDBHelper("default").Select(sql, null)
							.AsEnumerable()
							.Select(row => ParseToGroupIndexVM(row));
		}

		public GroupVM Get(int? id)
		{
			string sql = "Select * from Groups where Id = @Id";
			var parameters = new SqlParameterBuilder()
									.AddNullableInt("Id", id)
			.Build();

			var dt = new SqlDBHelper("default").Select(sql, parameters);
			if (dt.Rows.Count == 0)
			{
				return null;
			}
			var dr = dt.Rows[0];

			return ParseToGroupVM(dr);
		}

		public IEnumerable<GroupIndexVM> Get(string value)
		{
			string sql = "Select * from Groups where GroupName like @GroupName";
			var parameters = new SqlParameterBuilder()
									.AddNVarChar("GroupName", 50, value)
			.Build();

			return new SqlDBHelper("default").Select(sql, parameters)
								.AsEnumerable()
								.Select(row => ParseToGroupIndexVM(row));
		}

		public void Create(GroupDTO model)
		{
			string sql = @"insert into Groups(GroupName, Established)
							values(@GroupName, @Established)";

			var parameters = new SqlParameterBuilder()
								.AddNVarChar("GroupName", 50, model.GroupName)
								.AddDateTime("Established", model.Established)
			.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Update(GroupDTO model)
		{
			string sql = @"update Groups 
							set GroupName = @GroupName, 
							Established = @Established
							Where Id = @Id";

			var parameters = new SqlParameterBuilder()
								.AddInt("Id", model.Id)
								.AddNVarChar("GroupName", 50, model.GroupName)
								.AddDate("Established", model.Established)
								.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Delete(int id)
		{
			//if (SingerInGroup(id) == true) throw new Exception("There exists at least one singer in the group");
			string sql = @"delete from Groups where Id = @Id";

			var parameters = new SqlParameterBuilder()
								.AddInt("Id", id)
			.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		private GroupIndexVM ParseToGroupIndexVM(DataRow row)
		{
			return new GroupIndexVM
			{
				Id = row.Field<int>("Id"),
				GroupName = row.Field<string>("GroupName"),
				Established = row.Field<DateTime>("Established"),
			};
		}

		private GroupVM ParseToGroupVM(DataRow dr)
		{
			return new GroupVM
			{
				Id = dr.Field<int>("Id"),
				GroupName = dr.Field<string>("GroupName"),
				Established = dr.Field<DateTime>("Established"),
			};
		}

		public GroupVM GroupExists(GroupDTO model)
		{
			var parameterbuilder = new SqlParameterBuilder();
			string sql = "Select * from Groups where GroupName = @GroupName";

			if (model.Id != 0)
			{
				sql += " and Id != @Id";
				parameterbuilder = parameterbuilder.AddInt("Id", model.Id);
			}
			var parameters = parameterbuilder.AddNVarChar("GroupName", 50, model.GroupName)
			.Build();

			var dt = new SqlDBHelper("default").Select(sql, parameters);
			if(dt.Rows.Count == 0) return null;
			var dr = dt.Rows[0];

			return ParseToGroupVM(dr);
		}
	}
}
