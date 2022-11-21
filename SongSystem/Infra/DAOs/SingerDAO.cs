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
	public class SingerDAO
	{
		public IEnumerable<SingerIndexVM> GetAll()
		{
			string sql = @"select S.Id, S.SingerName, S.DateOfBirth, S.Gender, S.Country, G.GroupName from Singers S
							left join Groups G on S.GroupId = G.Id
							order by S.Created_at";

			return new SqlDBHelper("default").Select(sql, null)
							.AsEnumerable()
							.Select(row => ParseToSingerIndexVM(row));
		}

		public SingerVM Get(int id)
		{
			string sql = "select * from Singers S where S.Id = @Id";
			var parameters = new SqlParameterBuilder()
			.AddInt("Id", id)
			.Build();

			var dt = new SqlDBHelper("default").Select(sql, parameters);
			if (dt.Rows.Count == 0)
			{
				return null;
			}
			var dr = dt.Rows[0];

			return ParseToSingerVM(dr);
		}

		public IEnumerable<SingerIndexVM> GetBySingerName(string singerName)
		{
			string sql = @"select * from Singers S 
							left join Groups G on S.GroupId = G.Id
							where S.SingerName like @SingerName";
			var parameters = new SqlParameterBuilder()
			.AddNVarChar("SingerName", 50, singerName)
			.Build();

			return new SqlDBHelper("default").Select(sql, parameters)
							.AsEnumerable()
							.Select(row => ParseToSingerIndexVM(row));
		}

		public IEnumerable<SingerIndexVM> GetByDateOfBirth(DateTime dt)
		{
			string sql = @"select * from Singers S 
							left join Groups G on S.GroupId = G.Id
							where S.DateOfBirth = @DateOfBirth";
			var parameters = new SqlParameterBuilder()
			.AddDate("DateOfBirth", dt)
			.Build();

			return new SqlDBHelper("default").Select(sql, parameters)
							.AsEnumerable()
							.Select(row => ParseToSingerIndexVM(row));
		}

		public IEnumerable<SingerIndexVM> GetByCountry(string country)
		{
			string sql = @"select * from Singers S 
							left join Groups G on S.GroupId = G.Id
							where S.Country like @Country";
			var parameters = new SqlParameterBuilder()
			.AddNVarChar("Country", 50, country)
			.Build();

			return new SqlDBHelper("default").Select(sql, parameters)
							.AsEnumerable()
							.Select(row => ParseToSingerIndexVM(row));
		}

		public IEnumerable<SingerIndexVM> GetByGroupName(string groupName)
		{
			string sql = @"select * from Singers S 
							left join Groups G on S.GroupId = G.Id
							where G.GroupName like @GroupName";
			var parameters = new SqlParameterBuilder()
			.AddNVarChar("GroupName", 50, groupName)
			.Build();

			return new SqlDBHelper("default").Select(sql, parameters)
							.AsEnumerable()
							.Select(row => ParseToSingerIndexVM(row));
		}

		public void Create(SingerDTO model)
		{
			string sql = @"insert into Singers(SingerName, DateOfBirth, Gender, Country, GroupId)
							values(@SingerName, @DateOfBirth, @Gender, @Country, @GroupId)";

			var parameters = new SqlParameterBuilder()
								.AddNVarChar("SingerName", 50, model.SingerName)
								.AddDateTime("DateOfBirth", model.DateOfBirth)
								.AddNullableBit("Gender", model.Gender)
								.AddNVarChar("Country", 50, model.Country)
								.AddNullableInt("GroupId", model.GroupId)
			.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Update(SingerDTO model)
		{
			string sql = @"update Singers 
							set SingerName = @SingerName, 
							Gender = @Gender, 
							DateOfBirth = @DateOfBirth, 
							Country = @Country,
							GroupId = @GroupId
							Where Id = @Id";

			var parameters = new SqlParameterBuilder()
								.AddInt("Id", model.Id)
								.AddNVarChar("SingerName", 50, model.SingerName)
								.AddNullableBit("Gender", model.Gender)
								.AddDate("DateOfBirth", model.DateOfBirth)
								.AddNVarChar("Country", 50, model.Country)
								.AddNullableInt("GroupId", model.GroupId)
			.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Delete(int id)
		{
			string sql = @"delete from Singers where Id = @Id";

			var parameters = new SqlParameterBuilder()
								.AddInt("Id", id)
			.Build();

			new SqlDBHelper("default").ExecuteNonQuery(sql, parameters);
		}

		private SingerIndexVM ParseToSingerIndexVM(DataRow row)
		{
			return new SingerIndexVM
			{
				Id = row.Field<int>("Id"),
				SingerName = row.Field<string>("SingerName"),
				DateOfBirth = row.Field<DateTime>("DateOfBirth"),
				Gender = row.Field<bool>("Gender") ? "Male" : "Female",
				Country = row.Field<string>("Country"),
				GroupName = row.Field<string>("GroupName"),
			};
		}

		private SingerVM ParseToSingerVM(DataRow dr)
		{
			return new SingerVM
			{
				Id = dr.Field<int>("ID"),
				SingerName = dr.Field<string>("SingerName"),
				Gender = dr.Field<bool>("Gender"),
				DateOfBirth = dr.Field<DateTime>("DateOfBirth"),
				Country = dr.Field<string>("Country"),
				GroupId = dr.Field<int?>("GroupId"),
			};
		}

		public GroupVM GroupExists(SingerDTO model)
		{
			string sql = "Select * from Groups where GroupName = @GroupName";
			var parameters = new SqlParameterBuilder().AddNVarChar("GroupName", 50, model.GroupName).Build();

			var dt = new SqlDBHelper("default").Select(sql, parameters);
			if (dt.Rows.Count == 0) return null;
			var dr = dt.Rows[0];
			
			return ParseToGroupVM(dr);
		}

		private GroupVM ParseToGroupVM(DataRow dr)
		{
			return new GroupVM
			{
				Id = dr.Field<int>("ID"),
				GroupName = dr.Field<string>("GroupName"),
				Established = dr.Field<DateTime>("Established"),
			};
		}
	}
}
