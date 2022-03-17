using Crud_Operations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Operations.OperationsRepo
{
    public interface IStudentRepo
    {
        List<Student> GetAll();
        Student GetByID(int id);
        void Create(Student std);
        Student Read(int id);
        void Update(Student std);
        void Delete(int id);
    }
}
