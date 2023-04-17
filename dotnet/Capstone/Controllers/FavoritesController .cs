using Microsoft.AspNetCore.Mvc;
using Capstone.DAO;
using Capstone.Models;
using Capstone.Security;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;

namespace Capstone.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FavoritesController : ControllerBase
    {
        private readonly IFavoritesDao favoritesDao;
        private int loggedInUser;

        public FavoritesController(IFavoritesDao _favoritesDao)
        {
            favoritesDao = _favoritesDao;
            this.loggedInUser = Convert.ToInt32(User.FindFirst("sub")?.Value);
            Console.WriteLine(loggedInUser);
        }

        [HttpGet()]
        public ActionResult<UserMovie> GetMovie(int userId)
        {
            IList<UserMovie> favMovie = favoritesDao.GetFavoriteMovies(userId);
            if (favMovie != null)
            {
                return Ok(favMovie);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet()]
        public ActionResult<UserGenre> GetGenre(int userId)
        {
            IList<UserGenre> favGenre = favoritesDao.GetFavoriteGenres(userId);
            if (favGenre != null)
            {
                return Ok(favGenre);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("/userFavorites/:movies")]//is this the right route? Please check
        public IActionResult AddUserMovie(UserMovie userMovie)
        {
            //IActionResult result;

            UserMovie added = favoritesDao.AddFavoriteMovie(userMovie.UserId, userMovie.MovieId);
            return Created($"/userMovie/{added.MovieId}", added);
            //throw new NotImplementedException();
        }

        [HttpPost("/userFavorites/:genres")]//is this the right route? Please check
        public IActionResult AddUserGenre(UserGenre userGenre)
        {
            //IActionResult result;

            UserGenre added = favoritesDao.AddFavoriteGenre(userGenre.UserId, userGenre.GenreId);
            return Created($"/userMovie/{added.GenreId}", added);

            throw new NotImplementedException();
        }

        //[HttpPut("{movieId}")]
        //public ActionResult<UserMovie> UpdateFavoriteMovies(int movieId, UserMovie userMovie)
        //{
        //    UserMovie favToUpdate = favoritesDao.UpdateFavoriteMovies(movieId, userMovie);
        //    if (favToUpdate == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(favToUpdate);
        //}

        //[HttpPut("{genreId}")]
        //public ActionResult<UserGenre> UpdateFavoriteGenres(int genreId, UserMovie userMovie)
        //{
        //    UserMovie favToUpdate = favoritesDao.UpdateFavoriteGenres(genreId, userMovie);
        //    if (favToUpdate == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(favToUpdate);
        //}

    }
}
