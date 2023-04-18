using Microsoft.Extensions.Configuration.UserSecrets;
using System;
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

        public IList<UserMovie> GetFavoriteMovies(int userId)
        {
            IList<UserMovie> userMovies = new List<UserMovie>();

            if (userId == MovieId)
            {
                //userMovies.Add(UserMovie.MovieId);

                return userMovies;
            }
            return null;
        }


        //public List<UserMovie> UpdateFavoriteMovies(int userId) {
        //    List<UserMovie> userMovie = new List<UserMovie>();
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

        public UserGenre()
        {
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
        public IList<UserGenre> GetFavoriteGenres(int userId)
        {
            IList<UserGenre> userGenre = new List<UserGenre>();
            if (userId == GenreId)
            {
                //userGenre.Add(GenreId);
                return userGenre;
            }
            return null;
        }
        public UserGenre UpdateFavoriteGenres(int userId, int genreId)
        {

            //UserGenre oldGenreList = FindGenreById(userId);
            //    if (genreId == genreId)
            //    {                    updated.genreId = old.genreId;
            //        GenreId.Remove(oldGenreId);
            //    GenreId.Add(updated);
            //       return updated;
            //    }
            return null;
        }
    }

}