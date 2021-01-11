using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStock
{
    class Database
    {
        private List<User> _Users;

        public Database()
        {
            if (_Users == null)
                _Users = new List<User>();
        }
        public void AddUser(User user) 
        {
            _Users.Add(user);
        }
        public void RemoveUser(User user)
        {
            _Users.Remove(user);
        }
        public List<User> GetAllUsers()
        {
            return _Users;
        }
    }
}
