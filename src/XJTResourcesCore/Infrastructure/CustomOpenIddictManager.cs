using OpenIddict;
using OpenIddict.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XJTResourcesCore.Models;
using System.Security.Claims;
using AspNet.Security.OpenIdConnect.Extensions;

namespace XJTResourcesCore.Infrastructure
{
    public class CustomOpenIddictManager : OpenIddictManager<ApplicationUser, Application>
    {
        public CustomOpenIddictManager(OpenIddictServices<ApplicationUser, Application> services) : base(services)
        {

        }

        public override async Task<ClaimsIdentity> CreateIdentityAsync(ApplicationUser user, IEnumerable<string> scopes)
        {
            var claimsIdentity = await base.CreateIdentityAsync(user, scopes);

            claimsIdentity.AddClaim("user_name", user.UserName,
                OpenIdConnectConstants.Destinations.AccessToken,
                   OpenIdConnectConstants.Destinations.IdentityToken
                );

            return claimsIdentity;
        }
    }
}
