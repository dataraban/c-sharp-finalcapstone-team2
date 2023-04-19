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
            //List<UserMovie> returnUserMovies = null;
            IList<UserMovie> userMovies = new List<UserMovie>();
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
                        UserMovie userMovie = new UserMovie();

                        userMovie.UserId = Convert.ToInt32(reader["user_id"]);
                        userMovie.MovieId = Convert.ToInt32(reader["movie_id"]);

                        userMovies.Add(userMovie);//add stuff to list
                    }
                    return userMovies; 
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public UserMovie AddFavoriteMovie(int userId, int movieId)
        {
            UserMovie userMovie = new UserMovie();
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO user_movie (user_id, movie_id) VALUES (@user_id, @movie_id);",
                        conn);
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    cmd.Parameters.AddWithValue("@movie_id", movieId);

                    cmd.ExecuteNonQuery();
                }
                return userMovie;
            }
            catch (SqlException)
            {
                throw;
            }
            
        }

        public IList<UserGenre> GetFavoriteGenres(int userId)
        {
            IList<UserGenre> userGenres = new List<UserGenre>(); 
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM user_genre JOIN genre on user_genre.genre_id = genre.genre_id WHERE userId = @user_id;",
                        conn);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    SqlDataReader reader = cmd.ExecuteReader(); 

                    while(reader.Read())
                    {
                        UserGenre userGenre = new UserGenre();

                        userGenre.UserId = Convert.ToInt32(reader["user_id"]);
                        userGenre.GenreId = Convert.ToInt32(reader["genre_id"]);

                        userGenres.Add(userGenre); 
                    }
                    return userGenres; 
                }
            }
            catch(SqlException)
                {
                throw ;
            }
        }

        public  UserGenre AddFavoriteGenre(int userId, int genreId)
        {
            UserGenre userGenre = new UserGenre(); 
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO user_genre (user_id, genre_id) VALUES (@user_id, @genre_id);",
                        conn);
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    cmd.Parameters.AddWithValue("@genre_id", genreId);

                    cmd.ExecuteNonQuery();

                }
                return userGenre; 
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
