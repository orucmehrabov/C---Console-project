using Repository.Repositories.Interfaces;
using System.Text.RegularExpressions;

namespace Services.Services
{
    public class GroupService
    {
        private readonly IGroupRepository _groupRepository;

        public GroupService(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public void Create(Group group)
        {
            // Qrup yaratma əməliyyatını icra et
            _groupRepository.Create(group);
        }

        public void Delete(int groupId)
        {
            // Qrup silmə əməliyyatını icra et
            _groupRepository.Delete(groupId);
        }

        public void Edit(Group group)
        {
            // Qrupu düzəltmə əməliyyatını icra et
            _groupRepository.Edit(group);
        }

        public Group GetById(int groupId)
        {
            // Qrupu ID-ə görə əldə et
            return _groupRepository.GetById(groupId);
        }

        public List<Group> GetAll()
        {
            // Bütün qrupları əldə et
            return _groupRepository.GetAll();
        }

        public List<Group> Search(string groupName)
        {
            // Adına görə qrupları axtar
            return _groupRepository.Search(groupName);
        }

        public List<Group> SortingByCapacity()
        {
            // Capacity-yə görə qrupları sırala
            return _groupRepository.SortingByCapacity();
        }
    }
}
