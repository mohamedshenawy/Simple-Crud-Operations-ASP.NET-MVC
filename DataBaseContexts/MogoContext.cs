using Crud_Operations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud_Operations.DataBaseContexts
{
    public class MogoContext : IContext
    {
        public List<Student> Students { get; set; }

        public MogoContext()
        {
            Students = new List<Student>()
            {
                new Student() { ID = 2, Name = "sara", Age = 19, Gender = "female" },
                new Student() { ID = 3, Name = "ahmed", Age = 25, Gender = "male" },
                new Student() { ID = 4, Name = "mohamed", Age = 23, Gender = "male" }
            };
            
            //Students.Add(std); 
        }
    }
}