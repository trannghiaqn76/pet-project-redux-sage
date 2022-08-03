using Microsoft.AspNetCore.Authorization; 
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_api.Authorization
{
    public class NameAuthorizationHandler : AuthorizationHandler<ManageAdminRolesAndClaimsRequirement>
    {
        private readonly IConfiguration _configuration;
        public NameAuthorizationHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, ManageAdminRolesAndClaimsRequirement requirement)
        {
            if (context.User == null)
            {
                return;
            }

            var httpContextResource = context.Resource as DefaultHttpContext;
            var request = httpContextResource.Request;
            request.EnableBuffering();
            var body = await new StreamReader(request.Body).ReadToEndAsync();
            request.Body.Seek(0, SeekOrigin.Begin);

            if (context.User.IsInRole(Constants.ContactAdministratorsRole))
            {
                context.Succeed(requirement);
            }

            return;
        }
    }
}
