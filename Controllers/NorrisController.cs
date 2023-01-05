using Microsoft.AspNetCore.Mvc;

namespace ChuckNorrisQuotes.Controllers
{
    public class NorrisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
