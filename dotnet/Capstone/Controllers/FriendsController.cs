using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Capstone.Models;
using Capstone.DAO;

namespace Capstone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendsController : Controller
    {
        private readonly IFriendsDao friendsDao;
        public FriendsController(IFriendsDao friendsDao)
        {
            this.friendsDao = friendsDao;
        }

        [HttpGet("/friendslist")]
        public List<string> ViewFriends()
        {
            return friendsDao.ViewFriends();
        }
    }
}