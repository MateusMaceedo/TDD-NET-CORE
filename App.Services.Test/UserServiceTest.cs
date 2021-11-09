using NUnit.Framework;

namespace App.Services.Test
{
    public class UserServiceTest
    {
        private User user;
        private UserService _userService;

        [SetUp]
        public void Setup()
        {
            _userService = new UserService();
            user = new User();
        }

        [Test]
        public void MustInsertUser()
        {
            user.Email = "mateus.macedo@live.com";
            user.FirstName = "Mateus";
            user.LastName = "Macedo";
            Assert.IsNotNull(_userService.InsertUser(user));

            user.Email = "mateus.macedo.com";
            Assert.IsNull(_userService.InsertUser(user));
        }
    }
}
