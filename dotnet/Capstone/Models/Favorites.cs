using Microsoft.Extensions.Configuration.UserSecrets;
using System.Collections.Generic;

namespace Capstone.Models
{
    public class UserMovie
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }

        public UserMovie() { }
        public UserMovie(int userId, int movieId)
        {
            UserId = userId;
            MovieId = movieId;
        }

        //public bool IsValid(int userId) {
        //    int dbUserId = 1;//logic for validating a user id exists
            
        //    if (userId == dbUserId)
        //    { //compare to db list of userIds 
        //        return true;
        //    }
        //    return false;
        //}

        //public IList<UserMovie> GetFavoriteMovies(int userId, int movieId) {
        //    int dbUserId = 1;
        //    IList<UserMovie> userMovie = new List<UserMovie>();

        //    if (userId == dbUserId) {
        //        return userMovie;
        //    }
        //    return null;
        //}
        

        //public List<UserMovie> UpdateFavoriteMovies(int userId) {
        //    List<UserMovie> favMovies = new List<UserMovie>();
        //    if
        //}

    }

    public class UserGenre
    {
        public int UserId { get; set; }
        public int GenreId { get; set; }


        public UserGenre(int userId, int genreId) { 
            UserId = userId;
            GenreId = genreId; 
        }
        //public bool IsValid(int userId)
        //{
        //    int dbUserId = 1; //logic for validating a user id exists
           
        //    if (userId == dbUserId)
        //    { //compare to db list of userIds 
        //        return true;
        //    }
        //    return false;
        //}
        //public IList<UserGenre> GetFavoriteGenres(int userId)
        //{
        //    IList<UserGenre> favGenre = new List<UserGenre>();
        //    int dbUserId = 1;

        //    if (userId == dbUserId)
        //    {
        //        return favGenre;
        //    }
        //    return null;
        //}
        //public UserGenre UpdateFavoriteGenres(int userId) {

        //    //UserGenre oldGenreList = FindReservationById(userId);
        //    //    if (old != null)
        //    //    {                    updated.userId = old.userId;
        //    //        GenreId.Remove(old);
        //    //    GenreId.Add(updated);
        //    //        return updated;
        //    //    }
        //        return null;
        //}
    }

}