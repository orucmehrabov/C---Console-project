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
        public void Create(Group group)
        {
            throw new NotImplementedException();
        }

        public void Delete(int groupId)
        {
            throw new NotImplementedException();
        }

        public void Edit(Group group)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetAll()
        {
            throw new NotImplementedException();
        }

        public Group GetById(int groupId)
        {
            throw new NotImplementedException();
        }

        public List<Group> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Group> SortByCapacity()
        {
            throw new NotImplementedException();
        }
    }
}
