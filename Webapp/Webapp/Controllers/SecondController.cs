using Microsoft.AspNetCore.Mvc;

namespace Webapp.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 

    }
}
