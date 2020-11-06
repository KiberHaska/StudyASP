using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPlevel1.Infrastructure.Interfaces;
using ASPlevel1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPlevel1.Controllers
{
    public class OfficeController : Controller
    {
        private readonly IOfficesService _officesService;
        public OfficeController(IOfficesService officesService)
        {
            _officesService = officesService;
        }

        public IActionResult Offices()
        {           
            return View(_officesService.GetAll());
        }

        public IActionResult OfficeDetails(int id)
        {
            var office = _officesService.GetById(id);
            if (office == null)
                return NotFound(); //return 404 Not Found

            return View(office);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _officesService.GetById(id);

            if (model == null)
                return NotFound(); //404

            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(OfficeViewModel model)
        {
            if (model.Id > 0)
            {
                var dbItem = _officesService.GetById(model.Id);
                if (ReferenceEquals(dbItem, null))
                    return NotFound();

                dbItem.Name = model.Name;
                dbItem.Address = model.Address;               
            }

            return RedirectToAction(nameof(Offices));
        }

        public IActionResult Delete(int id)
        {
            _officesService.Delete(id);
            return RedirectToAction(nameof(Offices));
        }
    }
}
