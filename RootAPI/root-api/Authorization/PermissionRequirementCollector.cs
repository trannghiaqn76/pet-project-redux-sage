using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace name_api.Authorization
{
    public class PermissionRequirementCollector
    {
        private List<string> _policies;
        private List<string> GetAuthorizePolicies()
        {
            if (_policies == null)
            {
                var asm = Assembly.GetExecutingAssembly();
                _policies = asm.GetTypes()
                   .Where(type => typeof(ControllerBase).IsAssignableFrom(type))
                   .SelectMany(type => type.GetMethods())
                   .Where(method => method.IsPublic && method.IsDefined(typeof(AuthorizeAttribute)))
                   .Select(method => method.GetCustomAttribute<AuthorizeAttribute>())
                   .Where(attribule => attribule.Policy != null)
                   .Select(attribule => attribule.Policy)
                   .ToList();
            }

            return _policies;
        }

        public List<ManageAdminRolesAndClaimsRequirement> GetPermissionRequirements()
        {
            var result = new List<ManageAdminRolesAndClaimsRequirement>();
            var policies = GetAuthorizePolicies();

            policies.ForEach(policy =>
            {
                result.Add(new ManageAdminRolesAndClaimsRequirement(policy));
            });

            return result;
        }
    }
}
