using System.Threading.Tasks;
using Interface;
using PipServices.Commons.Data;
using PipServices.Net.Rest;

namespace Clients
{
    public class AccountsHttpClientV1 : CommandableHttpClient, IAccountsHttpClientV1
    {
        public AccountsHttpClientV1() : base("v1/accounts")
        {

        }

        public async Task<DataPage<AccountV1>> GetAccountsAsync(string correlationId, FilterParams filter, PagingParams paging)
        {
            return await CallCommandAsync<DataPage<AccountV1>>(
                "get_accounts",
                correlationId,
                new
                {
                    filter = filter,
                    paging = paging
                }
            );
        }

        public async Task<AccountV1> GetAccountByIdAsync(string correlationId, string id)
        {
            return await CallCommandAsync<AccountV1>(
                "get_account_by_id",
                correlationId,
                new
                {
                    account_id = id
                }
            );
        }

        public async Task<AccountV1> GetAccountByLoginAsync(string correlationId, string login)
        {
            return await CallCommandAsync<AccountV1>(
                "get_account_by_login",
                correlationId,
                new
                {
                    login = login
                }
            );
        }

        public async Task<AccountV1> CreateAccountAsync(string correlationId, AccountV1 account)
        {
            return await CallCommandAsync<AccountV1>(
                "create_account",
                correlationId,
                new
                {
                    account = account
                }
            );
        }


        public async Task<AccountV1> UpdateAccountAsync(string correlationId, AccountV1 account)
        {
            return await CallCommandAsync<AccountV1>(
                "update_account",
                correlationId,
                new
                {
                    account = account
                }
            );
        }
    
        public async Task<AccountV1> DeleteAccountByIdAsync(string correlationId, string accountId)
        {
            return await CallCommandAsync<AccountV1>(
                "delete_account_by_id",
                correlationId,
                new
                {
                    account_id = accountId
                }
            );
        }

    }
}