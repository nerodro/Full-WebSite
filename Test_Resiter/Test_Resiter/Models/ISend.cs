using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Resiter.Models
{
    public interface ISend
    {
        IEnumerable<SendForm> sends();

        SendForm Get(int id);
        void Create(SendForm send);
    }
}
