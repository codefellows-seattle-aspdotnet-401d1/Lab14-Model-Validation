using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab14_miya.Controllers
{
    [Route("Error")]
    public class ErrorPageController : Controller
    {
        public ViewResult Error()
        {
            string errorMessage = "Oops. Something's not right....";
            ViewData["msg"] = errorMessage;
            return View();
        }
    }
    
}
