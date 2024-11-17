using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Revit.Entity.Users;

namespace Revit.Entity.Family
{
    public class CheckUserExistFilterAttribute:ActionFilterAttribute
    {
        private readonly UserManager<R_User> _userManager;
        public CheckUserExistFilterAttribute(UserManager<R_User> userManager)
        {
            _userManager = userManager;
        }
        
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var userIdParameter = context.ActionArguments.Single(a => a.Key == "UserId");
            if (userIdParameter.Value is string userId)
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user is null)
                {
                    context.Result = new NotFoundResult();
                }
            }
             await base.OnActionExecutionAsync(context, next);
        }
    }
}