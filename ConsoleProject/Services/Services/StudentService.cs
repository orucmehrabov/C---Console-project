using Domain.Models;
using Repository.Repositories.Interfaces;
using Services.Services.Interfaces;

namespace Services.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Create(Student student)
        {
            // Create logic
        }

        public void Delete(int studentId)
        {
            // Delete logic
        }

        public void Edit(Student student)
        {
            // Edit logic
        }

        public Student GetById(int studentId)
        {
            // Get by Id logic
            return null;
        }

        public List<Student> GetAll()
        {
            // Get all logic
            return null;
        }

        public List<Student> SearchByName(string name)
        {
            // Search by name logic
            return null;
        }

        public List<Student> SortByAge()
        {
            // Sort by age logic
            return null;
        }
    }
}
