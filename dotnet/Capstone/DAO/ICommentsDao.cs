using System.Collections.Generic;
using Capstone.Models;

namespace Capstone.DAO
{
    public interface ICommentsDao
    {
        List<string> ViewComments();
        List<string> PostComment(int userId1, int userId2, string comment);
    }
}
