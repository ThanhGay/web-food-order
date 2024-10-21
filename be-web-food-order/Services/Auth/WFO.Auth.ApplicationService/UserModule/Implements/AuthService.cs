using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFO.Auth.ApplicationService.Common;
using WFO.Auth.ApplicationService.UserModule.Abstracts;
using WFO.Auth.Infrastructures;

namespace WFO.Auth.ApplicationService.UserModule.Implements
{
    public class AuthService: AuthServiceBase, IAuthService 
    {
        public AuthService(ILogger<AuthService> logger, AuthDbContext dbContext) : base(logger, dbContext)
        {
        }
    }
}
