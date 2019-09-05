using NUnit.Framework;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Onion.Infrastructure;
using Onion.Service;

namespace Onion.Test
{
    public class Tests
    {
        private  IUserService _userService;
        [SetUp]
        public void Setup()
        {
            var serviceProvider = Startup.ServiceProvider;
            if (serviceProvider != null)
            {
                _userService = serviceProvider.GetService<IUserService>();
            }
        }

        [Test]
        public async Task UserServiceAdd_TestAsync()
        {
            var user = new UserDM {
                FirstName = "Mohammed",
                MiddleName = "Tanbir",
                LastName = "Hossain"
            };
            var actualResult = await _userService.AddAsync(user);
            var expectedResult = true;
            Assert.AreEqual(expectedResult,actualResult);
        }
    }
}
