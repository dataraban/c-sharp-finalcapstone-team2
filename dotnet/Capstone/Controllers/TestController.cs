using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class TestController : ControllerBase
    {
        private readonly ITestDao dao;
        public TestController(ITestDao _dao)
        {
            dao = _dao;
        }

        [HttpGet()]
        public ActionResult<Testclass> GetAllTests()
        {
            IList<Testclass> favMovie = dao.GetAllTests();
            if (favMovie != null)
            {
                return Ok(favMovie);
            }
            else
            {
                return NotFound();
            }

        }




















        //[HttpGet]
        //public IList<Testclass> Get()
        //{
        //    using (SqlConnection myCon = new SqlConnection(_configuration))
        //        string query = @"select movie_name, genre_id from movies";
        //    //Make list instead of data table. Loop through results of SQL query.
        //    //ParkSqlDao in DaoLecture
        //    IList<Testclass> samplelist = new List<Testclass>();
        //    string sqlDataSource = _configuration.GetConnectionString("Project");
        //    SqlDataReader myReader;
        //    using(SqlConnection myCon= new SqlConnection(sqlDataSource))
        //    {
        //        myCon.Open();
        //        using (SqlCommand myCommand = new SqlCommand(query, myCon))
        //        {
        //            myReader = myCommand.ExecuteReader();
        //            samplelist.Add(myReader);
        //            myReader.Close();
        //            myCon.Close();
        //        }
        //    }
        //    return samplelist;
        //}
    }
}
