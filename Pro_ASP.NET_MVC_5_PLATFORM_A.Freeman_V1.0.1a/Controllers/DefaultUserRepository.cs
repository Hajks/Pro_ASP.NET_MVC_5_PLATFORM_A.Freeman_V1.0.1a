using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pro_ASP.NET_MVC_5_PLATFORM_A.Freeman_V1._0._1a.Controllers
{
    public class DefaultUserRepository: IUserRepository
    {
        public void Add(User newUser)
        {

        }

        public User FetchByLoginName(string loginName)
        {
            return new User() {LoginName= loginName};
        }

        public void SubmitChanges()
        {

        }
    }
}