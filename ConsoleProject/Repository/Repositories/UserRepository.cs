using Domain.Models;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void Register(User user)
        {
            throw new NotImplementedException();
        }
    }
}
