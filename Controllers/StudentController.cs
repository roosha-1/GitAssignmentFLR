using GitAssignmentFLR.Models;
using Microsoft.AspNetCore.Mvc;

namespace GitAssignmentFLR.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>();
       
        public IActionResult Index()
        {
          var std=new Student(1,"roo","roo@roo.roo");
          var std1=new Student(2,"moo","moo@roo.roo");
          var std3=new Student(3,"doo","doo@roo.roo");
          var std2=new Student(4,"loo","loo@roo.roo");
            students.Add(std);
            students.Add(std1);
            students.Add(std2);
            students.Add(std3);


            return View();
        }

        public IActionResult Edit()
        {


          
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
