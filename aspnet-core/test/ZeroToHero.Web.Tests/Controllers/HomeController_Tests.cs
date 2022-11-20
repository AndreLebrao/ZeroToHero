using System.Threading.Tasks;
using ZeroToHero.Models.TokenAuth;
using ZeroToHero.Web.Controllers;
using Shouldly;
using Xunit;

namespace ZeroToHero.Web.Tests.Controllers
{
    public class HomeController_Tests: ZeroToHeroWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}