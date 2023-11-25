using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface IGroupRepository
    {
        void Create(Group group);
        void Delete(int groupId);
        void Edit(Group group);
        Group GetById(int groupId);
        List<Group> GetAll();
        List<Group> Search(string groupName);
        List<Group> SortingByCapacity();
        void Edit(System.Text.RegularExpressions.Group group);
        void Create(System.Text.RegularExpressions.Group group);
    }
}
