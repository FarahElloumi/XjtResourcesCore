using AspNet.Security.OpenIdConnect.Extensions;
using AspNet.Security.OpenIdConnect.Server;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using XJTResourcesCore.Models;

namespace XJTResourcesCore.Providers
{
    public class AuthorizationProvider : OpenIdConnectServerProvider 
    {
        private readonly ILogger _logger;
        public AuthorizationProvider() {

            var factory = new LoggerFactory();
            _logger = factory.CreateLogger("Debug");
        }

        public override Task ValidateTokenRequest(ValidateTokenRequestContext context)
        {
            context.Skip();

            return Task.FromResult<object>(null);
        }

        public override Task GrantResourceOwnerCredentials(GrantResourceOwnerCredentialsContext context)
        {
            string username = context.UserName;
            string password = context.Password;

            UserManager<ApplicationUser> userManager = context.HttpContext.RequestServices.GetRequiredService<UserManager<ApplicationUser>>();
            ApplicationUser user = userManager.FindByNameAsync(username).Result;

            if (userManager.CheckPasswordAsync(user, password).Result)
            {
                ClaimsIdentity identity = new ClaimsIdentity(OpenIdConnectServerDefaults.AuthenticationScheme);
                identity.AddClaim(ClaimTypes.Name, user.UserName,
                    OpenIdConnectConstants.Destinations.AccessToken,
                    OpenIdConnectConstants.Destinations.IdentityToken);

                List<string> roles = userManager.GetRolesAsync(user).Result.ToList();
                foreach (string role in roles)
                {
                    identity.AddClaim(ClaimTypes.Role, role,
                        OpenIdConnectConstants.Destinations.AccessToken,
                        OpenIdConnectConstants.Destinations.IdentityToken);
                }

                AuthenticationTicket ticket = new AuthenticationTicket(
                    new ClaimsPrincipal(identity),
                    new AuthenticationProperties(),
                    context.Options.AuthenticationScheme);
                ticket.SetResources("resource_server");

                List<string> scopes = new List<string>();
                if (context.Request.HasScope("offline_access"))
                {
                    scopes.Add("offline_access");
                }
                ticket.SetScopes(scopes);

                if (string.IsNullOrWhiteSpace(context.Request.Resource)){
                    _logger.LogDebug("setting default audience for ticket....");
                }

                context.Validate(ticket);
            }
            else
            {
                context.Reject("invalid credentials");
            }

            return Task.FromResult(0);
        }
       
    }
}
