using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;


namespace XeGateway.Filters
{
    public class XeAuthorizeFilterAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
           
            var authHeader = actionContext.Request.Headers.Authorization;
            if (authHeader != null)
            {
              if(authHeader.Scheme.Equals("basic", StringComparison.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(authHeader.Parameter))
                {
                    var credEncoded = authHeader.Parameter;
                    var encoding = Encoding.GetEncoding("iso-8859-1");
                    var Cred =  encoding.GetString(Convert.FromBase64String(credEncoded));
                    var split = Cred.Split(':');
                    var userName = split[0];
                    var password = split[1];
                    var rolse = new string[] { "Admin" };
                    var genericPrincipal = new GenericPrincipal(new GenericIdentity(userName, "Admin"), rolse);
                    Thread.CurrentPrincipal = genericPrincipal;
                    return;
                } 
            }

            HandleUnAuthorizeRequest(actionContext);
        }

        private void HandleUnAuthorizeRequest(HttpActionContext actionContext)
        {
            actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
            actionContext.Response.Headers.Add("WWW-Authanticate", "BASIC Only for API Administrator ");
        }
    }
}