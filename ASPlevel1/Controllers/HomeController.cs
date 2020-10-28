using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPlevel1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPlevel1.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<EmployeeViewModel> _employees = new List<EmployeeViewModel>
        {
            new EmployeeViewModel
            {
                Id = 1,
                FirstName = "Ivan",
                SurName = "IvanOff",
                Patronymic = "Ivanovich",
                Age = 22,
                Position = "Boss"
            },
            new EmployeeViewModel
            {
                Id = 2,
                FirstName = "Vlad",
                SurName = "PetrOff",
                Patronymic = "Ivanovich",
                Age = 35,
                Position = "Programmer"
            }
            };
        public IActionResult Index()
        {
            //return Content("Hello from controller!");
            return View();
        }
        public IActionResult Employees()
        {           
            return View(_employees);
        }

        public IActionResult EmployeeDetails(int id)
        {
            var employee = _employees.FirstOrDefault(x => x.Id == id);
            if (employee == null)
                return NotFound(); //return 404 Not Found

            return View(employee);
        }
    }
}
