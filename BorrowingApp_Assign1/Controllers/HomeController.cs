using Microsoft.AspNetCore.Mvc;
using BorrowingApp_Assign1.Models;
using BorrowingApp_Assign1.Repositories;

namespace BorrowingApp_Assign1.Controllers
{
    public class HomeController : Controller
    {
        // The Index action serves the home page
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RequestForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RequestForm(Request request)
        {
            if (ModelState.IsValid)
            {
                RequestRepository.AddRequest(request);
                return RedirectToAction("Confirmation");
            }
            return View(request);
        }

        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult Requests()
        {
            var requests = RequestRepository.GetAllRequests();
            return View(requests);
        }
    }
}
