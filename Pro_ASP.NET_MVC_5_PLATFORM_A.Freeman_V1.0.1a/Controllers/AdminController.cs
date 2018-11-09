using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pro_ASP.NET_MVC_5_PLATFORM_A.Freeman_V1._0._1a.Controllers
{
    public class AdminController : Controller
    {
        private IUserRepository repository;

        public AdminController(IUserRepository repo)
        {
            repository = repo;
        }
        // GET: Admin
        public ActionResult ChangeLoginName(string oldName, string newName)
        {
            User user = repository.FetchByLoginName(oldName);
            user.LoginName = newName;
            repository.SubmitChanges();

            return View();
        }
    }
}