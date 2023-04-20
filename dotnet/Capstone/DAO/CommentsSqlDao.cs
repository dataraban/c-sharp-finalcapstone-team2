using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Capstone.Models;
using Capstone.Security;
using Capstone.Security.Models;

namespace Capstone.DAO
{
    public class CommentsSqlDao : ICommentsDao
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

                    SqlCommand cmd = new SqlCommand("SELECT user_author_id, comment_text from user_comments JOIN users on users.user_id = user_posted_id WHERE username = 'Josephina366';", conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string comment = Convert.ToString(reader["comment_text"]);
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

        public List<string> PostComments(int userId1, int userId2, string comment)
        {
            List<string> comments = new List<string>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO user_comments (user_author, user_posted, comment_text) VALUES (@user_author_id, @user_posted_id, @comment_text;", conn);
                        cmd.Parameters.AddWithValue("@user_author", userId1);
                        cmd.Parameters.AddWithValue("@user_posted", userId2 );
                        cmd.Parameters.AddWithValue("@comment_text", comment);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string comment = Convert.ToString(reader["comment_text"]);
                        comments.Add(comment);
                    }
                }
            }
            catch (SqlException) {
                throw;
            }
            return comments;
        }
    }
}


