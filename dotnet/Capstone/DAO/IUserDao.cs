using Capstone.Models;
using System.Collections.Generic;

namespace Capstone.DAO
{
    public interface IUserDao
    {
        User GetUser(string username);
        User AddUser(string username, string password, string role);
        //User GetAllUsers(string username);
        List<int> ViewUserIds();
        List<string> ViewUsers();
    }
}
