using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStock.Models;

namespace BookStock.DAL
{
    public static class DatabaseSecond
    {
        static DatabaseSecond()
        {
            Users = Users ?? new EntityModel<User>();
            Books = Books ?? new EntityModel<Book>();
        }
        public static EntityModel<User> Users { get; set; }
        public static EntityModel<Book> Books { get; set; }
    }
}
