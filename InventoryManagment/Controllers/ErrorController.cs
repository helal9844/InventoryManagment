using BL;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagment.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/Error")]
        public IActionResult Error()
        {
            var errorDetails = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var error = new ErrorException(HttpContext.Response.StatusCode, errorDetails?.Error.Message, errorDetails?.Error.StackTrace);
            return View("Error", error);
        }

        [Route("/Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            var error = new ErrorException(statusCode);
            return View("Error", error);
        }
    }
}
