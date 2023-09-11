using System.Threading.Tasks;
using Opera.Models.TokenAuth;
using Opera.Web.Controllers;
using Shouldly;
using Xunit;

namespace Opera.Web.Tests.Controllers
{
    public class HomeController_Tests: OperaWebTestBase
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