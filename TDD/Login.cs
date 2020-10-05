using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TDD
{
    public class Login
    {
        private List<User> users = new Data().Users;
        private User user;
        public object LoginUser(string pin)
        {
            if (Regex.IsMatch(pin, "[0-9]") && pin.Length == 4)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Pin == pin)
                    {
                        user = users[i];
                        return user;
                    }
                }
                
            }
            return user;
        }
    }
}
