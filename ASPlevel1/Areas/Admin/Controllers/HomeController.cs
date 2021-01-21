using AspLevel1.Domain.Entities;
using ASPlevel1.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPlevel1.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admins")]
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View(_productService.GetProducts(new ProductFilter()));
        }
    }
}
