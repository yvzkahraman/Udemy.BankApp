using Udemy.BankApp.Web.Data.Entities;

namespace Udemy.BankApp.Web.Data.Interfaces
{
     public interface IAccountRepository
    {
        void Create(Account account);
    }
}
