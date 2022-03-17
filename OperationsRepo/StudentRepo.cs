using Crud_Operations.DataBaseContexts;
using Crud_Operations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud_Operations.OperationsRepo
{
    public class StudentRepo : IStudentRepo
    {
        IContext Students;
        public StudentRepo(IContext _Students)
        {
            Students = _Students; 
        }
        public void Create(Student std)
        {
            Students.Students.Add(std);
        }

        public void Delete(int id)
        {
            var std = Students.Students.Where(i => i.ID == id).FirstOrDefault();
            Students.Students.Remove(std);
        }

        public List<Student> GetAll()
        {
            return Students.Students;
        }

        public Student GetByID(int id)
        {
            return Students.Students.Where(i => i.ID == id).FirstOrDefault();
        }

        public Student Read(int id)
        {
            return Students.Students.Where(i => i.ID == id).FirstOrDefault();
        }

        public void Update(Student _std)
        {
            var std = Students.Students.Where(i => i.ID == _std.ID).FirstOrDefault();
            std.Name = _std.Name;
            std.Age = _std.Age;
            std.Gender = _std.Gender;
        }
    }
}