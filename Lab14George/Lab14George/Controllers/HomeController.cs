using Microsoft.AspNetCore.Mvc;

namespace Lab14George.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}