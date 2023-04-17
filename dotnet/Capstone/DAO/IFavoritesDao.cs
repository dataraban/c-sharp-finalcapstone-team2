using Capstone.Models;
using System.Collections.Generic;

namespace Capstone.DAO
{
    public interface IFavoritesDao
    {
        IList<UserMovie> GetFavoriteMovies(int userId);
        UserMovie AddFavoriteMovie(int userId, int movieId);

        IList<UserGenre> GetFavoriteGenres(int userId);
        UserGenre AddFavoriteGenre(int userId, int genreId);


        //IList<UserMovie> UpdateFavoriteMovies(int userId);
        //UserMovie UpdateFavoriteMovie(int userId, int movieId);

        //IList<UserGenre> UpdateFavoriteGenres(int userId);
        //UserGenre UpdateFavoriteGenre(int userId, int genreId);
    }
}
