using Udemy.BankApp.Web.Data.Entities;
using Udemy.BankApp.Web.Models;

namespace Udemy.BankApp.Web.Mapping
{
    public class AccountMapper : IAccountMapper
    {
        public Account Map(AccountCreateModel model)
        {
            return new Account
            {
                AccountNumber = model.AccountNumber,
                ApplicationUserId = model.ApplicationUserId,
                Balance = model.Balance,
            };
        }
    }
}
