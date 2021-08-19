using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPM_UI.Helper
{
    public class CustomUserAuthenticate : TypeFilterAttribute
    {
        public CustomUserAuthenticate() : base(typeof(AuthenticateLoginUser))
        {

        }

        public class AuthenticateLoginUser : IAuthorizationFilter
        {
            public void OnAuthorization(AuthorizationFilterContext context)
            {
                if(context.HttpContext.Session.GetString("UserName") == null)
                {
                    context.Result = new RedirectToActionResult("LoginForm", "LoginAuthenticate", null);
                }
            }
        }
    }
}
