using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        void Create(Student student);
        void Delete(int studentId);
        void Edit(Student student);
        Student GetById(int studentId);
        List<Student> GetAll();
        List<Student> SearchByName(string name);
        List<Student> SortByAge();
    }
}
