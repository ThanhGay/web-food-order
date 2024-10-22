using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFO.Auth.ApplicationService.Common;
using WFO.Auth.ApplicationService.UserModule.Abstracts;
using WFO.Auth.Dtos.UserModule;
using WFO.Auth.Infrastructure;

namespace WFO.Auth.ApplicationService.UserModule.Implements
{
    public class UserService : AuthServiceBase, IUserService
    {
        public UserService(ILogger<UserService> logger, AuthDbContext dbContext) : base(logger, dbContext)
        {
        }

        public void CreateUser(CreateUserDto input)
        {
            //_dbContext.Users.Add();
        }
    }
}
