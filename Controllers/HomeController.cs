using Crud_Operations.Models;
using Crud_Operations.OperationsRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_Operations.Controllers
{
    public class HomeController : Controller
    {
        IStudentRepo StdRepo;
        public HomeController(IStudentRepo _StdRepo)
        {
            StdRepo = _StdRepo;
        }
        // GET: Home
        public ActionResult Index()
        {
            
            return View( "Index" , StdRepo.GetAll());
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Student std)
        {
            //Student std = new Student() { ID = ID, Name = Name, Age = Age, Gender = Gender };
            StdRepo.Create(std);
            
            return View("Index" , StdRepo.GetAll());
        }

        public ActionResult Delete(int id)
        {
            StdRepo.Delete(id);
            return Index();
        }
        public ActionResult Update(int id)
        {
            var std = StdRepo.GetByID(id);
            
            return View("Update" , std);
        }
        [HttpPost]
        public ActionResult Update(Student _std)
        {
            var std = StdRepo.GetByID(_std.ID);

            std.Name = _std.Name;
            std.Age = _std.Age;
            std.Gender = _std.Gender;
            return Index();
        }
    }
}