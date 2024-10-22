using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFO.Auth.Dtos.UserModule;

namespace WFO.Auth.ApplicationService.UserModule.Abstracts
{
    public interface IUserService
    {
        void CreateUser(CreateUserDto input);
    }
}
