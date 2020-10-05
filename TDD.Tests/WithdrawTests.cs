using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD;
using Xunit;

namespace TDD.Tests
{
    public class WithdrawTests
    {
        [Theory]
        [InlineData("1234", 200, 100)]
        [InlineData("5468", 4500, 1100)]
        [InlineData("9775", 4440, 4400)]
        public void Check_MoneyIsRemovedFromAccountBalance(string pin, double balance, double amount)
        {
            User user = new User(pin, balance);

            user.WithdrawMoney(amount);

            double expected = balance - amount;

            Assert.Equal(expected, user.Balance);
        }
    }
}
