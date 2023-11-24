using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User GetById(int userId);
        User GetByEmail(string email);
        void Add(User user);
    }
}
