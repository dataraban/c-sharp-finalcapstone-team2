using Microsoft.Extensions.Configuration.UserSecrets;
using System.Collections.Generic;

namespace Capstone.Models
{
    public class UserMovie
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }

        public UserMovie(int userId, int movieId)
        {
            UserId = userId;
            MovieId = movieId;
        }

        public bool IsValid(int userId) {
            int dbUserId = 1;//logic for validating a user id exists
            
            if (userId == dbUserId)
            { //compare to db list of userIds 
                return true;
            }
            return false;
        }

        public List<UserMovie> GetFavoriteMovies(int userId) {
            int dbUserId = 1;
            List<UserMovie> favMovies = new List<UserMovie>();

            if (userId == dbUserId) {
                return favMovies;
            }
            return null;
        }

    }

    public class UserGenre
    {
        public int UserId { get; set; }
        public int GenreId { get; set; }

        public UserGenre(int userId, int genreId) { 
            UserId = userId;
            GenreId = genreId; 
        }
        public bool IsValid(int userId)
        {
            int dbUserId = 1; //logic for validating a user id exists
           
            if (userId == dbUserId)
            { //compare to db list of userIds 
                return true;
            }
            return false;
        }
        public List<UserGenre> GetFavoriteGenres(int userId)
        {
            List<UserGenre> favGenre = new List<UserGenre>();
            int dbUserId = 1;

            if (userId == dbUserId)
            {
                return favGenre;
            }
            return null;
        }
    }

}