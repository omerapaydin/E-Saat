using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESaat.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ESaat.Controllers
{
    public class HomeController: Controller
    {
        private readonly IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _productRepository.Products.OrderBy(i => i.Title).Take(4).ToListAsync();
            return View(products);
        }

         public async Task<IActionResult> List()
        {
            var products = await _productRepository.Products.ToListAsync();
            return View(products);
        }
    }
}