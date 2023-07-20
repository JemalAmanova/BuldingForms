using BuldingForms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuldingForms.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(ProductRepository.Products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(new List<string> { "Bilgisayar", "Tablet", "Telefon" });
            return View();
        }

        [HttpPost]
        public IActionResult Create( Product model)
        {
            //kullanıcıdan gelen formları kaydedecek olan metod.
            ProductRepository.AddProduct(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Search( string q)
        {
          if (string.IsNullOrWhiteSpace(q))
               return View();
          
           return View("Index", ProductRepository.Products.Where(i => i.Name.Contains(q)));


        }
    }
}
