using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace name_api.Authorization
{
    public class ManageAdminRolesAndClaimsRequirement : IAuthorizationRequirement
    {
        public string Policy;
        public ManageAdminRolesAndClaimsRequirement(string policy)
        {
            Policy = policy;
        }
    }
}
