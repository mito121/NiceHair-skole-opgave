using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NiceHair.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NiceHair.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // List of services
        public List<Service> ServiceList =
        new List<Service>
        {
            new Service {ServiceId = 1, ServiceName = "Herre(fedt)klip"},
            new Service {ServiceId = 2, ServiceName = "Dameklap"},
            new Service {ServiceId = 3, ServiceName = "Børneklup"}
        };

        // Actions
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Staff()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View(ServiceList);
        }

        public IActionResult Service(int id)
        {
            Service service = ServiceList.FirstOrDefault(t => t.ServiceId == id);
            ViewBag.id = id;
            ViewBag.name = service.ServiceName;
            return View(service);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }


    // Services
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
    }
}
