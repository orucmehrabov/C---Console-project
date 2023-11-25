using Repository.Repositories.Interfaces;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Services.Services
{
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository _groupRepository;

        public GroupService(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public void Create(Group group)
        {
            // Create logic
        }

        public void Delete(int groupId)
        {
            // Delete logic
        }

        public void Edit(Group group)
        {
            // Edit logic
        }

        public Group GetById(int groupId)
        {
            // Get by Id logic
            return null;
        }

        public List<Group> GetAll()
        {
            // Get all logic
            return null;
        }

        public List<Group> SearchByName(string name)
        {
            // Search by name logic
            return null;
        }

        public List<Group> SortByCapacity()
        {
            // Sort by capacity logic
            return null;
        }
    }
}
