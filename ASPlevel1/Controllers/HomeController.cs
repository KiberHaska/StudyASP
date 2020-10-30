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
        public IActionResult Index()
        {            
            return View();
        }       
    }
}
