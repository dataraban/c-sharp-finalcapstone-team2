using System.Collections.Generic;
using Capstone.Models;

namespace Capstone.DAO

{
    public interface ITestDao
    {
        IList<Testclass> GetAllTests();
    }
}
