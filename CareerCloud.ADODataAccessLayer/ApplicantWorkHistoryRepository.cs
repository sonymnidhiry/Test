﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using Microsoft.Extensions.Configuration;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantWorkHistoryRepository : IDataRepository<ApplicantWorkHistoryPoco>
    {
        private readonly string _connStr;
        public ApplicantWorkHistoryRepository()
        {
            var config = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            config.AddJsonFile(path, false);
            var root = config.Build();
            _connStr = root.GetSection("ConnectionStrings").GetSection("DataConnection").Value;

        }
        public void Add(params ApplicantWorkHistoryPoco[] items)
        {
            foreach (ApplicantWorkHistoryPoco poco in items)
            {
                using (SqlConnection connection = new SqlConnection(_connStr))
                {

                    SqlCommand comm = new SqlCommand();
                    comm.Connection = connection;
                    comm.CommandText = @"INSERT INTO [dbo].[Applicant_Work_History]
                                               ([Id]
                                               ,[Applicant]
                                               ,[Company_Name]
                                               ,[Country_Code]
                                               ,[Location]
                                               ,[Job_Title]
                                               ,[Job_Description]
                                               ,[Start_Month]
                                               ,[Start_Year]
                                               ,[End_Month]
                                               ,[End_Year])
                                         VALUES
                                               (@Id
                                                ,@Applicant
                                               ,@Company_Name
                                               ,@Country_Code
                                               ,@Location
                                               ,@Job_Title
                                               ,@Job_Description
                                               ,@Start_Month
                                               ,@Start_Year
                                               ,@End_Month
                                               ,@End_Year) ";

                    comm.Parameters.AddWithValue("@ID", poco.Id);
                    comm.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    comm.Parameters.AddWithValue("@Company_Name", poco.CompanyName);
                    comm.Parameters.AddWithValue("@Country_Code", poco.CountryCode);
                    comm.Parameters.AddWithValue("@Location", poco.Location);
                    comm.Parameters.AddWithValue("@Job_Title", poco.JobTitle);
                    comm.Parameters.AddWithValue("@Job_Description", poco.JobDescription);
                    comm.Parameters.AddWithValue("@Start_Month", poco.StartMonth);
                    comm.Parameters.AddWithValue("@Start_Year", poco.StartYear);
                    comm.Parameters.AddWithValue("@End_Month", poco.EndMonth);
                    comm.Parameters.AddWithValue("@End_Year", poco.EndYear);
                    connection.Open();
                    int rowEffected = comm.ExecuteNonQuery();
                    connection.Close();


                }
            }
        }



        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantWorkHistoryPoco> GetAll(params Expression<Func<ApplicantWorkHistoryPoco, object>>[] navigationProperties)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT [Id]
                                          ,[Applicant]
                                          ,[Company_Name]
                                          ,[Country_Code]
                                          ,[Location]
                                          ,[Job_Title]
                                          ,[Job_Description]
                                          ,[Start_Month]
                                          ,[Start_Year]
                                          ,[End_Month]
                                          ,[End_Year]
                                          ,[Time_Stamp]
                                   FROM [dbo].[Applicant_Work_History]";
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                ApplicantWorkHistoryPoco[] pocos = new ApplicantWorkHistoryPoco[500];
                int index = 0;
                while (reader.Read())
                {
                    ApplicantWorkHistoryPoco poco = new ApplicantWorkHistoryPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Applicant = reader.GetGuid(1);
                    poco.CompanyName = reader.GetString(2);
                    poco.CountryCode = reader.GetString(3);
                    poco.Location = reader.GetString(4);
                    poco.JobTitle = reader.GetString(5);
                    poco.JobDescription = reader.GetString(6);
                    poco.StartMonth = reader.GetInt16(7);
                    poco.StartYear = reader.GetInt32(8);
                    poco.EndMonth = reader.GetInt16(9);
                    poco.EndYear = reader.GetInt32(10);
                    poco.TimeStamp = (byte[])reader[11];
                    pocos[index] = poco;
                    index++;


                }

                conn.Close();
                return pocos.Where(a => a != null).ToList();

            }

        }

        public IList<ApplicantWorkHistoryPoco> GetList(Expression<Func<ApplicantWorkHistoryPoco, bool>> where, params Expression<Func<ApplicantWorkHistoryPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantWorkHistoryPoco GetSingle(Expression<Func<ApplicantWorkHistoryPoco, bool>> where, params Expression<Func<ApplicantWorkHistoryPoco, object>>[] navigationProperties)
        {
            IQueryable<ApplicantWorkHistoryPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params ApplicantWorkHistoryPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (ApplicantWorkHistoryPoco poco in items)
                {
                    cmd.CommandText = @"Delete From Applicant_Work_History where Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }

        }

        public void Update(params ApplicantWorkHistoryPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (var poco in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Applicant_Work_History]
                                       SET
                                          [Applicant] = @Applicant
                                          ,[Company_Name] = @Company_Name
                                          ,[Country_Code] = @Country_Code
                                          ,[Location] = @Location
                                          ,[Job_Title] = @Job_Title
                                          ,[Job_Description] = @Job_Description
                                          ,[Start_Month] = @Start_Month
                                          ,[Start_Year] = @Start_Year
                                          ,[End_Month] = @End_Month
                                          ,[End_Year] = @End_Year
                                        WHERE[Id]=@Id";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    cmd.Parameters.AddWithValue("@Company_Name", poco.CompanyName);
                    cmd.Parameters.AddWithValue("@Country_Code", poco.CountryCode);
                    cmd.Parameters.AddWithValue("@Location", poco.Location);
                    cmd.Parameters.AddWithValue("@Job_Title", poco.JobTitle);
                    cmd.Parameters.AddWithValue("@Job_Description", poco.JobDescription);
                    cmd.Parameters.AddWithValue("@Start_Month", poco.StartMonth);
                    cmd.Parameters.AddWithValue("@Start_Year", poco.StartYear);
                    cmd.Parameters.AddWithValue("@End_Month", poco.EndMonth);
                    cmd.Parameters.AddWithValue("@End_Year", poco.EndYear);
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }
        }
    }
}



