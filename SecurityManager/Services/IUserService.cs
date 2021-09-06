using SecurityManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityManager.Services
{
    public interface IUserService
    {
        bool IsValidUserInformation(LoginModel model);
    }
}
