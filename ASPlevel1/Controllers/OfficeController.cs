using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPlevel1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPlevel1.Controllers
{
    public class OfficeController : Controller
    {
        private readonly List<OfficeViewModel> _employees = new List<OfficeViewModel>
        {
            new OfficeViewModel
            {
                Id = 1,
                Name = "Office1",
                Address = "1 Street"                
            },
            new OfficeViewModel
            {
                Id = 2,
                Name = "Office2",
                Address = "2 Street"                
            },
            new OfficeViewModel
            {
                Id = 3,
                Name = "Office3",
                Address = "3 Street"
            }
            };
        
        public IActionResult Offices()
        {           
            return View(_employees);
        }

        public IActionResult OfficeDetails(int id)
        {
            var office = _employees.FirstOrDefault(x => x.Id == id);
            if (office == null)
                return NotFound(); //return 404 Not Found

            return View(office);
        }
    }
}
