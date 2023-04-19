using Microsoft.AspNetCore.Mvc;
using Capstone.DAO;
using Capstone.Models;
using Capstone.Security;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;

namespace Capstone.Controllers
{
   [Route("api/[controller]")]
    [ApiController]
    public class FavoritesController : ControllerBase
    {
        private readonly IFavoritesDao favoritesDao;
        private int loggedInUser;

        public FavoritesController(IFavoritesDao _favoritesDao)
        {
            favoritesDao = _favoritesDao;
            //this.loggedInUser = Convert.ToInt32(User.FindFirst("sub")?.Value);
           // Console.WriteLine(loggedInUser);
        }

        [HttpGet("userMovie/{userId}")]
        public ActionResult<UserMovie> GetMovie(int userId)
        {
            IList<UserMovie> userMovie = favoritesDao.GetFavoriteMovies(userId);
            if (userMovie != null)
            {
                return Ok(userMovie);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("/userGenre/{userId}")]
        public ActionResult<UserGenre> GetGenre(int userId)
        {
            IList<UserGenre> userGenre = favoritesDao.GetFavoriteGenres(userId);
            if (userGenre != null)
            {
                return Ok(userGenre);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("/userMovie/{userId}")]//is this the right route? Please check
        public IActionResult AddUserMovie(UserMovie userMovie)
        {
            //IActionResult result;

            UserMovie added = favoritesDao.AddFavoriteMovie(userMovie.UserId, userMovie.MovieId);
            return Created($"/userMovie/{added.MovieId}", added);
            //throw new NotImplementedException();
        }

        [HttpPost("/userGenre/{userId}")]//is this the right route? Please check
        public IActionResult AddUserGenre(UserGenre userGenre)
        {
            //IActionResult result;

            UserGenre added = favoritesDao.AddFavoriteGenre(userGenre.UserId, userGenre.GenreId);
            return Created($"/userGenre/{added.GenreId}", added);

            throw new NotImplementedException();
        }

        //[HttpPut("{movieId}")]
        //public ActionResult<UserMovie> UpdateFavoriteMovies(int movieId, UserMovie userMovie)
        //{
        //    UserMovie userMovie = favoritesDao.UpdateFavoriteMovies(movieId, userMovie);
        //    if (userMovie == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(userMovie);
        //}

        //[HttpPut("{genreId}")]
        //public ActionResult<UserGenre> UpdateFavoriteGenres(int genreId, UserMovie userMovie)
        //{
        //    UserMovie userGenre = favoritesDao.UpdateFavoriteGenres(genreId, userGenre);
        //    if (favToUpdate == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(userGenre);
        //}

    }
}
