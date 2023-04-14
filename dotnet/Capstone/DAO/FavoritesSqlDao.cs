using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Capstone.Models;
using Capstone.Security;
using Capstone.Security.Models;

namespace Capstone.DAO
{
    public class FavoritesSqlDao : IFavoritesDao
    {
        private readonly string connectionString;

        public FavoritesSqlDao(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public IList<UserMovie> GetFavoriteMovies(int userId)
        {
            List<UserMovie> returnUserMovies = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    //get a list of User's Favorite movies from the user_movie table

                    SqlCommand cmd = new SqlCommand("SELECT user_id, movie_id FROM user_movie WHERE user_id = @user_id", conn);
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //add stuff to list
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return returnUserMovies;
        }

        public UserMovie AddFavoriteMovie(int userId, int movieId)
        {
            throw new NotImplementedException();
        }

        public IList<UserGenre> GetFavoriteGenres(int userId)
        {
            throw new NotImplementedException();
        }

        public UserGenre AddFavoriteGenre(int userId, int genreId)
        {
            throw new NotImplementedException();
        }


    }
}
