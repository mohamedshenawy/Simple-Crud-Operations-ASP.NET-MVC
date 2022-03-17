using Crud_Operations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud_Operations.DataBaseContexts
{
    public class SqlContext : IContext
    {
        public List<Student> Students { get; set; }

        public SqlContext()
        {
            Students = new List<Student>()
            {
                new Student() { ID = 1, Name = "mohamed", Age = 23, Gender = "male" }
            };
        }
    }
}