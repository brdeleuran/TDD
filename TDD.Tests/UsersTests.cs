using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TDD.Tests
{
    public class UsersTests
    {
        [Fact]
        public void Login_CreateUserWorking()
        {
            Data data = new Data();

            bool actual = data.CreateUser("1020", 2000);

            Assert.True(actual);
        }

        [Fact]
        public void Login_CreateUserNotWorking()
        {
            Data data = new Data();
            bool actual = data.CreateUser("15555", 4546);

            Assert.False(actual);
        }
    }
}
