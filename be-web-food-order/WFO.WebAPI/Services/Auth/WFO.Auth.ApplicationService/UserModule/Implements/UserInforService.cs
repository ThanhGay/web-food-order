using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFO.Auth.ApplicationService.Common;
using WFO.Auth.Infrastructure;
using WFO.Shared.ApplicationService.User;

namespace WFO.Auth.ApplicationService.UserModule.Implements
{
    public class UserInforService : AuthServiceBase, IUserInforService
    {
        public UserInforService(ILogger<UserInforService> logger, AuthDbContext dbContext) : base(logger, dbContext)
        {
        }

        public bool HasUser(int id)
        {
            return _dbContext.Users.Any(acc => acc.Id == id);
        }
    }
}
