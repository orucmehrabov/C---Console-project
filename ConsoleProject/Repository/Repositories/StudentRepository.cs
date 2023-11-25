using Domain.Models;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public void Create(Student student)
        {
            throw new NotImplementedException();
        }

        public void Delete(int studentId)
        {
            throw new NotImplementedException();
        }

        public void Edit(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetById(int studentId)
        {
            throw new NotImplementedException();
        }

        public List<Student> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Student> SortByAge()
        {
            throw new NotImplementedException();
        }
    }