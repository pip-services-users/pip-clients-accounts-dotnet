using System;
using System.Linq;
using System.Threading.Tasks;
using Clients;
using Test.Data;
using Xunit;

namespace Test.Clients.Version1
{
    public class AccountClientV1Fixture
    {
        private readonly IAccountsHttpClientV1 _client;

        public AccountClientV1Fixture(IAccountsHttpClientV1 client)
        {
            _client = client;
        }

        public async Task TestClientCrudOperationsAsync()
        {
            var account1 = await _client.CreateAccountAsync(null, AccountTestModelV1.GenerateRandomAccountV1());
            var account2 = await _client.CreateAccountAsync(null, AccountTestModelV1.GenerateRandomAccountV1());

            var projectionResult1 = await _client.GetAccountsAsync(null, null, null);
            Assert.Equal(account1.Name, projectionResult1.Data.FirstOrDefault(t=>t.Id == account1.Id).Name);
            Assert.Equal(account2.Name, projectionResult1.Data.FirstOrDefault(t=>t.Id == account2.Id).Name);

            var page = await _client.GetAccountsAsync(null, null, null);
            Assert.Equal(2, page.Data.Count);

            await _client.DeleteAccountByIdAsync(null, account1.Id);

            dynamic projectionResult2 = await _client.GetAccountByIdAsync(null, account2.Id);
            Assert.Equal(account2.Id, projectionResult2.Id);
            

            var result = await _client.GetAccountByLoginAsync(null, account1.Login);
            Assert.NotNull(result);

            await _client.DeleteAccountByIdAsync(null, account2.Id);
            page = await _client.GetAccountsAsync(null, null, null);
            Assert.Empty(page.Data);
        }
    }
}