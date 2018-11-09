using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pro_ASP.NET_MVC_5_PLATFORM_A.Freeman_V1._0._1a.Controllers;

namespace Pro_ASP.NET_MVC_5_PLATFORM_A.Freeman_V1._0._1a.Tests
{
    [TestClass]
    public class AdminControllerTest
    {
        [TestMethod]
        public void CanChangeLoginName()
        {
            User user = new User() {LoginName = "Bogdan"};
            FakeRepository repositoryParam = new FakeRepository();
            repositoryParam.Add(user);
            AdminController target = new AdminController(repositoryParam);
            string oldLoginParam = user.LoginName;
            string newLoginParam = "Janek";

            target.ChangeLoginName(oldLoginParam, newLoginParam);

            Assert.AreEqual(newLoginParam, user.LoginName);
            Assert.IsTrue(repositoryParam.DidSubmitChanges);


        }

        public class FakeRepository:IUserRepository
        {
            public List<User> Users = new List<User>();
            public bool DidSubmitChanges = false;

            public void Add(User user)
            {
                Users.Add(user);
            }

            public User FetchByLoginName(string loginName)
            {
                return Users.First(m => m.LoginName == loginName);
            }

            public void SubmitChanges()
            {
                DidSubmitChanges = true;
            }
        }
    }
}
