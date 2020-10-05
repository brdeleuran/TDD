using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD;
using Xunit;

namespace TDD.Tests
{
    public class LoginTests
    {
        [Fact]
        public void Login_LoginWorking()
        {
            Login login = new Login();
            //object actual = login.LoginUser("1234");
            

            Assert.True(login.LoginUser("1234").GetType() == typeof(User));
        }

        [Fact]
        public void Login_LoginNotWorking()
        {
            Login login = new Login();
            //bool actual = login.LoginUser("0000");

            Assert.True(login.LoginUser("0000").GetType() == typeof(User));
        }
    }
}
