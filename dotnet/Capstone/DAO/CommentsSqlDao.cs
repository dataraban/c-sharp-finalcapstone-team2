using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Capstone.Models;
using Capstone.Security;
using Capstone.Security.Models;

namespace Capstone.DAO
{
    public class CommentsSqlDao
    {
        private readonly string connectionString;

        public CommentsSqlDao(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<string> ViewComments()
        {
            List<string> comments = new List<string>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * from user_comments", conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string comment = Convert.ToString(reader["comment"]);
                       comments.Add(comment);
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return comments;
        }
    }
}


