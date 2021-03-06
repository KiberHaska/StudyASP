﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPlevel1.Infrastructure;
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
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult BlogSingle()
        {
            return View();
        }
        
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
       
        public IActionResult Error()
        {
            return View();
        }
    }
}
