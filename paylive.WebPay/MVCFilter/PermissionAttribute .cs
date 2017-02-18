using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace paylive.WebPay.MVCFilter
{
    public class PermissionAttribute : AuthorizeFilter
    {
        public PermissionAttribute(AuthorizationPolicy policy) : base(policy)
        {
        }

        public override Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            #region 模拟登录

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, "admin"),
                new Claim(ClaimTypes.Role, "admin")
            };
            var identity = new ClaimsIdentity(claims, "mylogin");
            var principal = new ClaimsPrincipal(identity);
            context.HttpContext.User = principal;

            #endregion


            //Otherwise apply this policy
            return base.OnAuthorizationAsync(context);
        }
    }
}