using System.Data.Common;
using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Capstone.DAO
{
    public class FriendsSqlDao : IFriendsDao
    {
        private readonly string connectionString;

        public FriendsSqlDao(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<string> ViewFriends()
        {
            List<string> friends = new List<string>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT username from user_friends JOIN users ON users.user_id = user_id1 WHERE username = 'Josephina366'", conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string friend = Convert.ToString(reader["username"]);
                        friends.Add(friend);
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return friends;
        }
    }
}



