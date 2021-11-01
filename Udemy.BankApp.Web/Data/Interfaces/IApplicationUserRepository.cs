using System.Collections.Generic;
using Udemy.BankApp.Web.Data.Entities;

namespace Udemy.BankApp.Web.Data.Interfaces
{
    public interface IApplicationUserRepository
    {
        List<ApplicationUser> GetAll();
        ApplicationUser GetById(int id);
    }
}
