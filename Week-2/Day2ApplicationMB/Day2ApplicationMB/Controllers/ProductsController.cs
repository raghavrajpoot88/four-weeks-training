using Microsoft.AspNetCore.Mvc;
using Day2ApplicationMB.Models;
using System.Threading.Tasks;
using System.Reflection;

namespace Day2ApplicationMB.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Products P){
            if (ModelState.IsValid)
            {

                var newProduct = new Products
                {
                    Id = P.Id,
                    Name = P.Name,
                    Price = P.Price,
                    

                };
                return Ok(newProduct);
            }
            return View(P);
            //return Ok(P);
        }
        //[Route("Products/Getdata/{name?}")]
        //public String Getdata(products pds)
        //{
        //    return pds.name;
        //}
    }
}
