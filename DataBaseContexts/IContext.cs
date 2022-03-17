using Crud_Operations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Operations.DataBaseContexts
{
    public interface IContext
    {
         List<Student> Students { get; set; }
    }
}
