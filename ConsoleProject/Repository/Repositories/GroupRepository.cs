using Domain.Models;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        public void Add(Group group)
        {
            throw new NotImplementedException();
        }

        public Group GetById(int groupId)
        {
            throw new NotImplementedException();
        }

        public Group GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
