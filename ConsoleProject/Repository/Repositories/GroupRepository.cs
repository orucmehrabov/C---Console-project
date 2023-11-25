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
        public void Create(Domain.Models.Group group)
        {
            throw new NotImplementedException();
        }

        public void Create(System.Text.RegularExpressions.Group group)
        {
            throw new NotImplementedException();
        }

        public void Delete(int groupId)
        {
            throw new NotImplementedException();
        }

        public void Edit(Domain.Models.Group group)
        {
            throw new NotImplementedException();
        }

        public void Edit(System.Text.RegularExpressions.Group group)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Models.Group> GetAll()
        {
            throw new NotImplementedException();
        }

        public Domain.Models.Group GetById(int groupId)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Models.Group> Search(string groupName)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Models.Group> SortingByCapacity()
        {
            throw new NotImplementedException();
        }
    }
}
