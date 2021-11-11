using AutoMapper;
using Ljubimci_API.Controllers;
using Ljubimci_API.DTOs;
using Ljubimci_API.Services.Auth;
using Ljubimci_API_Test.Fakes;
using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;

namespace Ljubimci_API_Test.ControllersTest
{
    [TestFixture]
    public class AccountControllerTest
    {
        static InputRegisterDTO[] registerAppUserDTOs_GoodParameters =
        {
            new(){UserName="Pera",Email="pera@gmail.com", PhoneNumber="065 523 0691", City="Belgrade", Password="a"},
            new(){UserName="laza",Email="laza@gmail.com", PhoneNumber="065/523-0691", City="Novi Sad", Password="a"},
            new(){UserName="MIkA",Email="mika@gmail.com", PhoneNumber="0655230691", City="Pozarevac", Password="a"},
            new(){UserName="ZiKa",Email="zika@gmail.com", PhoneNumber="065 523 0691", City="Tutin", Password="a"}
        };

        static InputRegisterDTO[] registerAppUserDTOs_BadParameters =
        {
            new(){UserName=null,Email="pera@gmail.com", PhoneNumber="065 523 0691", City="Belgrade", Password="a"},
            new(){UserName="laza",Email=null, PhoneNumber="065/523-0691", City="Novi Sad", Password="a"},
            new(){UserName="MIkA",Email="mika@gmail.com", PhoneNumber="0655230691", City="Pozarevac", Password=null}
        };

        private Mock<FakeUserManager> _userManager;
        private Mock<FakeSignInManager> _signInManager;
        private Mock<ITokenService> _tokenService;
        private IMapper _mapper;
        private IConfiguration _configuration;

        public AccountControllerTest(IConfiguration configuration, IMapper mapper)
        {
            _userManager = new Mock<FakeUserManager>();
            _signInManager = new Mock<FakeSignInManager>();
            _configuration = configuration;
            _mapper = mapper;
            _tokenService = new Mock<ITokenService>(_configuration, _userManager);
            //_accountController = new AccountController(_userManager, _signInManager, _configuration, _mapper);
        }

        [Test]
        [TestCaseSource("registerAppUserDTOs_GoodParameters")]
        public void Register_GoodParameters_ReturnAppUserDTO(InputRegisterDTO registerAppUserDTO)
        {
            //arrange 

            //act

            //assert
        }
    }
}
