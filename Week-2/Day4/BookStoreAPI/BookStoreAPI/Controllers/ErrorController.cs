﻿//using Microsoft.AspNetCore.Diagnostics;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace BookStoreAPI.Controllers
//{
//    [Route("api/Error")]
//    [ApiController]
//    public class ErrorController : ControllerBase
//    {
//        [HttpGet]
//        [Route("/error-local-development")]
//        public IActionResult ErrorLocalDevelopment(
//        [FromServices] IWebHostEnvironment webHostEnvironment)
//        {
//            if (webHostEnvironment.EnvironmentName != "Development")
//            {
//                throw new InvalidOperationException(
//                    "This shouldn't be invoked in non-development environments.");
//            }

//            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();

//            return Problem(
//                detail: context.Error.StackTrace,
//                title: context.Error.Message);
//        }

//        [HttpGet]
//        [Route("/error")]
//        public IActionResult Error() => Problem();
//    }
//}
