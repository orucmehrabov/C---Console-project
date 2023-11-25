using Domain.Models;
using Repository.Repositories.Interfaces;
using Services.Services.Interfaces;

namespace Services.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Register(User user)
        {
            // Qeydiyyat əməliyyatını icra et
            _userRepository.Register(user);
        }

        public User Login(string email, string password)
        {
            // Giriş əməliyyatını icra et
            return _userRepository.Login(email, password);
        }
    }
}
