using System.Collections.Generic;
using Capstone.Models;

namespace Capstone.DAO
{
    public interface ICommentsDao
    {
        List<string> ViewComments();
    }
}
