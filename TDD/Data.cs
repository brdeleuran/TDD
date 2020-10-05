using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TDD
{
    public class Data
    {
        private List<User> users = new List<User>()
        {
            new User("1234", 554466),
            new User("5678", 558),
            new User("9012", 60),
            new User("3456", 90000000)
        };
        public List<User> Users { get { return users; } }

        public bool CreateUser(string pin, double balance)
        {
            if (Regex.IsMatch(pin, "[0-9]") && pin.Length == 4)
            {
                users.Add(new User(pin, balance));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
