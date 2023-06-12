using Microsoft.AspNetCore.Mvc;
using Day2ApplicationView.Models;
using Day2ApplicationView.ViewModels;
using System.Net;

namespace Day2ApplicationView.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult Details()
        {
            Product product = new Product()
            {
                Id = 01,
                Name = "Rudra",
                Price = 54



            };
            ProductViewModel productViewModel = new ProductViewModel()
            {
                Product = product,
                Title = "Product Details Page",
                Header = "Product Details",

            };
            //Pass the studentDetailsViewModel to the view
            return View(productViewModel);


        }

        public IActionResult Create(Product pdr)
        {
            return Ok(pdr);
            //return View();
        }
        public IActionResult Edit(Product pdr)
        {
            return Ok(pdr);
            //return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
