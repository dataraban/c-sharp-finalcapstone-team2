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
    public class CommentsController : Controller
    {
        private readonly ICommentsDao commentsDao;
  
        public CommentsController(ICommentsDao commentsDao)
        {
            this.commentsDao = commentsDao;
        }

        [HttpGet("/commentslist")]
        public List<string> ViewComments()
        {
            return commentsDao.ViewComments();
        }
    }
        }
