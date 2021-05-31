using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Resiter.Models
{
    public interface IRepository
    {
        IEnumerable<User> AddUser();
        IEnumerable<User> EditAdmin();

        User Get(int id);
        void Create(User user);
    }
}
