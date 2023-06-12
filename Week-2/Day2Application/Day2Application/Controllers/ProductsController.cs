using Microsoft.AspNetCore.Mvc;

namespace Day2Application.Controllers
{
    public class ProductsController : Controller
    {
        public String Index()
        {
            return "This is index page";

        }
        public String Details()
        {
            return "This is details page";
        }
        
        public String Create()
        {
            return "This is Create page.";
        }
        public String Edit()
        {
            return "This is Edit page";
        }
        public String Delete()
        {
            return "This is Delete page";
        }
    }
}
