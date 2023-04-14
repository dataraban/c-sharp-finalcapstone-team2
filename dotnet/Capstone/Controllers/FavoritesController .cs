using Microsoft.AspNetCore.Mvc;
using Capstone.DAO;
using Capstone.Models;
using Capstone.Security;
using System;

namespace Capstone.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FavoritesController : ControllerBase
    {
        private readonly IFavoritesDao favoritesDao;

        public FavoritesController(IFavoritesDao _favoritesDao)
        {
            favoritesDao = _favoritesDao;
        }

        [HttpPost("/userFavorites")]//is this the right route? Please check
        public IActionResult AddUserMovie(UserMovie userMovie)
        {
            //IActionResult result;

            //favoritesDao.AddFavoriteMovie(userMovie.UserId, userMovie.MovieId);

            //return result;

            throw new NotImplementedException();
        }


    }
}
