using AutoMapper;
using Ljubimci_API.Controllers;
using Ljubimci_API.Data;
using Ljubimci_API.Entities;
using Ljubimci_API.Interfaces;
using Ljubimci_API.Services;
using Ljubimci_API_Test.Fakes;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ljubimci_API_Test.ControllersTest
{
    [TestFixture]
    public class AccountControllerTest
    {
        static RegisterAppUserDTO[] registerAppUserDTOs_GoodParameters =
        {
            new(){UserName="Pera",Email="pera@gmail.com", PhoneNumber="065 523 0691", City="Belgrade", Password="a"},
            new(){UserName="laza",Email="laza@gmail.com", PhoneNumber="065/523-0691", City="Novi Sad", Password="a"},
            new(){UserName="MIkA",Email="mika@gmail.com", PhoneNumber="0655230691", City="Pozarevac", Password="a"},
            new(){UserName="ZiKa",Email="zika@gmail.com", PhoneNumber="065 523 0691", City="Tutin", Password="a"}
        };

        static RegisterAppUserDTO[] registerAppUserDTOs_BadParameters =
        {
            new(){UserName=null,Email="pera@gmail.com", PhoneNumber="065 523 0691", City="Belgrade", Password="a"},
            new(){UserName="laza",Email=null, PhoneNumber="065/523-0691", City="Novi Sad", Password="a"},
            new(){UserName="MIkA",Email="mika@gmail.com", PhoneNumber="0655230691", City="Pozarevac", Password=null}
        };

        private AccountController _accountController;
        private Mock<FakeUserManager> _userManager;
        private Mock<FakeSignInManager> _signInManager;
        private ITokenService _tokenService;
        private IMapper _mapper;
        private IConfiguration _configuration;

        public AccountControllerTest()
        {
            _userManager = new Mock<FakeUserManager>();
            _signInManager = new Mock<FakeSignInManager>();
            //_tokenService = new Mock<TokenService>();
            //_accountController = new AccountController(_userManager, _signInManager,);
        }

        [Test]
        [TestCaseSource("registerAppUserDTOs_GoodParameters")]
        public void Register_GoodParameters_ReturnAppUserDTO(RegisterAppUserDTO registerAppUserDTO)
        {
            //arrange 

            //act

            //assert
        }
    }
}
