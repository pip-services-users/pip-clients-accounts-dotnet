using System;
using System.Threading.Tasks;
using Interface;
using PipServices.Commons.Data;

namespace Clients
{
    public interface IAccountsHttpClientV1
    {
        Task<DataPage<AccountV1>> GetAccountsAsync(string correlationId, FilterParams filter, PagingParams paging);
        Task<AccountV1> GetAccountByIdAsync(string correlationId, string accountId);
        Task<AccountV1> GetAccountByLoginAsync(string correlationId, string login);
        Task<AccountV1> CreateAccountAsync(string correlationId, AccountV1 account);
        Task<AccountV1> UpdateAccountAsync(string correlationId, AccountV1 account);
        Task<AccountV1> DeleteAccountByIdAsync(string correlationId, string accountId);  
    }
}