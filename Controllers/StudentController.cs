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
            students.Add(std);
            return View();
        }
    }
}
