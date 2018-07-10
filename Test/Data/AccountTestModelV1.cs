using System;
using System.Collections.Generic;
using System.Text;
using Interface;
using Xunit;

namespace Test.Data
{
    public static class AccountTestModelV1
    {
        public static AccountV1 GenerateRandomAccountV1()
        {
            AccountV1 tmp = new AccountV1
            {
                Name = Guid.NewGuid().ToString("N").Substring(0, 8),
                Login = Guid.NewGuid().ToString("N").Substring(0, 8),
                Theme = Guid.NewGuid().ToString("N").Substring(0, 8)
            };
            return tmp;
        }
    }
}
