using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarybooling
{
    internal class User
    {
        public int Id { get; private set; }
        public string UserName { get; private set; }

        public User(int id, string userName)
        {
            Id = id;
            UserName = userName;
        }
    }
}
