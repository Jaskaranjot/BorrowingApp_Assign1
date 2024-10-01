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

        // View all requests (admin page)
        public IActionResult Requests()
        {
            var requests = RequestRepository.GetAllRequests();
            return View(requests);
        }

        // New: All Equipment Listing
        public IActionResult AllEquipment()
        {
            var equipmentList = EquipmentRepository.GetAllEquipment();
            return View(equipmentList); // This will render AllEquipment.cshtml (to be implemented)
        }

        // New: Available Equipment Listing
        public IActionResult AvailableEquipment()
        {
            var availableEquipment = EquipmentRepository.GetAvailableEquipment();
            return View(availableEquipment); // This will render AvailableEquipment.cshtml (to be implemented)
        }
    }
}
