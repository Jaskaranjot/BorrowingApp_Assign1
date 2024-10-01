using BorrowingApp_Assign1.Models;
using BorrowingApp_Assign1.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace BorrowingApp_Assign1.Controllers
{
        public class RequestController : Controller
        {
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

            // Admin page: List all requests
            public IActionResult Requests()
            {
                var requests = RequestRepository.GetAllRequests();
                return View(requests);
            }

            // Show all equipment
            public IActionResult AllEquipment()
            {
                var equipment = EquipmentRepository.GetAllEquipment();
                return View(equipment);
            }

            // Show available equipment only
            public IActionResult AvailableEquipment()
            {
                var availableEquipment = EquipmentRepository.GetAllEquipment().Where(e => e.IsAvailable).ToList();
                return View(availableEquipment);
            }
            public IActionResult AdminRequests()
            {
                var requests = RequestRepository.GetAllRequests();
                return View("RequestsAdmin", requests);
            }


        }
    }
