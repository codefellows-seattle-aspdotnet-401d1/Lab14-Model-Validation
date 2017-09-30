using Microsoft.AspNetCore.Mvc;

namespace Lab14George.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index() => View();
    }
}