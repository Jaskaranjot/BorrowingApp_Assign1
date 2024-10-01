using Microsoft.AspNetCore.Mvc;

namespace BorrowingApp_Assign1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
