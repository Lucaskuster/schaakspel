using Microsoft.AspNetCore.Mvc;

namespace Schaakspel.ApplicationLayer.Controllers
{
    public class MoveController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
