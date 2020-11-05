using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPlevel1.Infrastructure.Interfaces;
using ASPlevel1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPlevel1.Controllers
{
    //[Route("users/[action]")]
    [Route("users")]
    public class EmployeeController : Controller
    {
       private readonly IEmployeesService _employeesService;
       public EmployeeController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        [Route("list")]
        public IActionResult Employees()
        {
            return View(_employeesService.GetAll());
        }

        [Route("{id}")]
        public IActionResult EmployeeDetails(int id)
        {
            var employee = _employeesService.GetById(id);
            if (employee == null)
                return NotFound(); //return 404 Not Found

            return View(employee);
        }

        [HttpGet]
        [Route("/edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
                return View(new EmployeeViewModel());

            var model = _employeesService.GetById(id.Value);
            
            if (model == null)
                return NotFound(); //404

            return View(model);
        }

        [HttpPost]
        [Route("/edit/{id?}")]
        public IActionResult Edit(EmployeeViewModel model)
        {
           if(model.Id > 0)
            {
                var dbItem = _employeesService.GetById(model.Id);
                if (ReferenceEquals(dbItem, null))
                    return NotFound();

                dbItem.FirstName = model.FirstName;
                dbItem.SurName = model.SurName;
                dbItem.Age = model.Age;
                dbItem.Patronymic = model.Patronymic;
                dbItem.Position = model.Position;
            }
            else
            {
                _employeesService.AddNew(model);
            }
            _employeesService.Commit();
            return RedirectToAction(nameof(Employees));
        }
      
        [Route("/delete/{id?}")]
        public IActionResult Delete(int id)
        {
            _employeesService.Delete(id);
            return RedirectToAction(nameof(Employees));
        }        
    }
}
