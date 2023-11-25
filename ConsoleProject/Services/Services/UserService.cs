using Domain.Models;
using Repository.Repositories.Interfaces;
using Services.Services.Interfaces;

namespace Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Register(User user)
        {
            // Register logic
        }

        public User Login(string email, string password)
        {
            // Login logic
            return null;
        }
    }

}
