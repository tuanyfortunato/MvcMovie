using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class Movies : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}