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
        Student GetById(int studentId);
        void Add(Student student);
        void Update(Student student);
    }
}
