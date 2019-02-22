using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogPostCMS.Models.Handler
{
    public class NewMinAgeHandler : AuthorizationHandler<NewMinAgeRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, NewMinAgeRequirement requirement)
        {

            if (!context.User.HasClaim(c => c.Type == ClaimTypes.DateOfBirth))
            {
                return Task.CompletedTask;
            }

            DateTime dateOfBirth = Convert.ToDateTime(context.User.FindFirst(u => u.Type == ClaimTypes.DateOfBirth).Value);

            int age = DateTime.Today.Year - dateOfBirth.Year;

            if (dateOfBirth > DateTime.Today.AddYears(-age))
            {
                age--;
            }

            if (age >= 21)
            {
                context.Succeed(requirement);

            }

            return Task.CompletedTask;
        }
    }
}
