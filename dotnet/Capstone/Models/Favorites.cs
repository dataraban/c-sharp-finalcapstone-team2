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
    }

}