using System;
using System.Threading.Tasks;
using Clients;
using PipServices.Commons.Config;
using PipServices.Commons.Refer;
using Xunit;

namespace Test.Clients.Version1
{
    public class AccountHttpClientV1Test
    {
        private static readonly ConfigParams HttpConfig = ConfigParams.FromTuples(
            "connection.protocol", "http",
            "connection.host", "serv",
            "connection.port", 8080
        );

        private AccountsHttpClientV1 _client;
        private AccountClientV1Fixture _fixture;

        public AccountHttpClientV1Test()
        {
            try
            {
                _client = new AccountsHttpClientV1();

                IReferences references = References.FromTuples(
                    new Descriptor("SHL-Account", "client", "http", "default", "1.0"), _client
                );

                _client.Configure(HttpConfig);
                _client.SetReferences(references);

                _fixture = new AccountClientV1Fixture(_client);

                _client.OpenAsync(null).Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        [Fact]
        public async Task TestHttpClientCrudOperationsAsync()
        {
            await _fixture.TestClientCrudOperationsAsync();
        }
    }
}
