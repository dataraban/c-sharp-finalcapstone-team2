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
    public class UserController : Controller
    {
        private readonly IUserDao userDao;
        public UserController(IUserDao userDao)
        {
            this.userDao = userDao;
        }

        [HttpGet]
        public List<int> ViewUserIds()
        {
            return userDao.ViewUserIds();
        }

        [HttpGet("/viewusers")]
        public List<string> ViewUsers()
        {
            return userDao.ViewUsers();
        }
    }
}
