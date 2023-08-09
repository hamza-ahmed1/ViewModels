using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewModels.Models;

namespace ViewModels.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Id = 1,Name="Hamza",Gender="male",Standard="2"},
                new Student() { Id = 2,Name="Daniyal",Gender="male",Standard="3"}
            };
            List<Teacher> teacher = new List<Teacher>()
            {
                new Teacher() { Id = 1,Name="Hamza",Qualification="BSCS",  Salary=1000},
                new Teacher() { Id = 2,Name="Daniyal",Qualification="BSCS",Salary=1000}
            };
            //we can't pass 2nd model as 2nd arg in view or we can't add another model dir
            SchoolViewModel schoolviewmodel = new SchoolViewModel()
            {
                MyStudents = students,
                MyTeachers = teacher
            };
            return View(schoolviewmodel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}