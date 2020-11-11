﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspLevel1.Domain.Entities;
using ASPlevel1.Infrastructure.Interfaces;
using ASPlevel1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPlevel1.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductService _productService;

        public CatalogController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductDetails()
        {
            return View();
        }
        public IActionResult Shop(int? categoryId, int? brandId)
        {           
            // получаем список отфильтрованных продуктов
            var products = _productService.GetProducts(
                new ProductFilter { BrandId = brandId, CategoryId = categoryId });

            // сконвертируем в CatalogViewModel
            var model = new CatalogViewModel()
            {
                BrandId = brandId,
                CategoryId = categoryId,
                Products = products.Select(p => new ProductViewModel()
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    Name = p.Name,
                    Order = p.Order,
                    Price = p.Price
                }).OrderBy(p => p.Order).ToList()
            };

            return View(model);
        }
    }
}
