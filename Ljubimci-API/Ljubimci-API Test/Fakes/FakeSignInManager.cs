using Ljubimci_API.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ljubimci_API_Test.Fakes
{
    public class FakeSignInManager : SignInManager<AppUser>
    {
        public FakeSignInManager() : base(
                                        new FakeUserManager(),
                                        new Mock<IHttpContextAccessor>().Object,
                                        new Mock<IUserClaimsPrincipalFactory<AppUser>>().Object,
                                        new Mock<IOptions<IdentityOptions>>().Object,
                                        new Mock<ILogger<SignInManager<AppUser>>>().Object,
                                        new Mock<IAuthenticationSchemeProvider>().Object,
                                        null    //https://github.com/aspnet/Identity/issues/640
                                     )
        {
        }
    }
}
