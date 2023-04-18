using System.Data.Common;
using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Capstone.DAO
{
    public class TestSqlDao : ITestDao
    {
        private readonly string connectionString;

        public TestSqlDao(string connString)
        {
            connectionString = connString;
        }


        public IList<Testclass> GetAllTests()
        {
            IList<Testclass> tests = new List<Testclass>();
            try
            {
                using (SqlConnection myCon = new SqlConnection(connectionString))
                {
                    myCon.Open();
                    SqlCommand cmd = new SqlCommand("SELECT movie_name, genre_id FROM movies", myCon);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Testclass test = CreateTestFromReader(sdr);
                        tests.Add(test);
                    }
                    return new List<Testclass>();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private Testclass CreateTestFromReader(SqlDataReader sdr)
        {
            Testclass test = new Testclass();
            test.movie_name = Convert.ToString(sdr["movie_name"]);
            test.genre_id = Convert.ToInt32(sdr["genre_id"]);

            return test;
        }
    }
}
