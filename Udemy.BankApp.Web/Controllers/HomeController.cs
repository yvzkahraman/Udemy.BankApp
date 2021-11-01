using Microsoft.AspNetCore.Mvc;
using Udemy.BankApp.Web.Data.Entities;
using Udemy.BankApp.Web.Data.Interfaces;
using Udemy.BankApp.Web.Data.UnitOfWork;
using Udemy.BankApp.Web.Mapping;

namespace Udemy.BankApp.Web.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IUserMapper _userMapper;
        private readonly IUow _uow;

        public HomeController(/*IApplicationUserRepository applicationUserRepository,*/ IUserMapper userMapper, IUow uow)
        {
            //_applicationUserRepository = applicationUserRepository;
            _userMapper = userMapper;
            _uow = uow;
        }

        public IActionResult Index()
        {
            return View(_userMapper.MapToListOfUserList(_uow.GetRepository<ApplicationUser>().GetAll()));
        }
    }
}
