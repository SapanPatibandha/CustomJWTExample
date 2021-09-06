using SecurityManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityManager.Services
{
    public class UserService : IUserService
    {
        public bool IsValidUserInformation(LoginModel model)
        {
            if (model.UserName.Equals("Jay") && model.Password.Equals("123456")) return true;
            else return false;
        }
    }
}
