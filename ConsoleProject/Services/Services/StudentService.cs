using Domain.Models;
using Repository.Repositories.Interfaces;
using Services.Services.Interfaces;

namespace Services.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Create(Student student)
        {
            // Tələbə yaratma əməliyyatını icra et
            _studentRepository.Create(student);
        }

        public void Delete(int studentId)
        {
            // Tələbə silmə əməliyyatını icra et
            _studentRepository.Delete(studentId);
        }

        public void Edit(Student student)
        {
            // Tələbəni düzəltmə əməliyyatını icra et
            _studentRepository.Edit(student);
        }

        public Student GetById(int studentId)
        {
            // Tələbəni ID-ə görə əldə et
            return _studentRepository.GetById(studentId);
        }

        public List<Student> GetAll()
        {
            // Bütün tələbələri əldə et
            return _studentRepository.GetAll();
        }

        public List<Student> SearchByName(string studentName)
        {
            // Adına görə tələbələri axtar
            return _studentRepository.SearchByName(studentName);
        }

        public List<Student> SearchBySurname(string studentSurname)
        {
            // Soyadına görə tələbələri axtar
            return _studentRepository.SearchBySurname(studentSurname);
        }

        public List<Student> SortingByAge()
        {
            // Yaşa görə tələbələri sırala
            return _studentRepository.SortingByAge();
        }
    }
}
