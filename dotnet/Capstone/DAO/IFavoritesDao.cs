using Capstone.Models;
using System.Collections.Generic;

namespace Capstone.DAO
{
    public interface IFavoritesDao
    {
        List<UserMovie> GetFavoriteMovies(int userId);
        UserMovie AddFavoriteMovie(int userId, int movieId);
        List<UserGenre> GetFavoriteGenres(int userId);
        UserGenre AddFavoriteGenre(int userId, int genreId);

        List<UserMovie> UpdateFavoriteMovies(int userId);
        UserMovie UpdateFavoriteMovie(int userId, int movieId);
        List<UserGenre> UpdateFavoriteGenres(int userId);
        UserGenre UpdateFavoriteGenre(int userId, int genreId);
    }
}
