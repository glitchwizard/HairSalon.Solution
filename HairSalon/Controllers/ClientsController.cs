using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HairSalon.Controllers
{
    public class ClientsController : Controller
    {

        [HttpGet("/stylists/{stylistId}/clients")]
        public ActionResult Index()
        {
            List<Client> allClients = Client.GetAll();
            return View(allClients);
        }

        [HttpGet("/stylists/{stylistId}/clients/new")]
        public ActionResult New(int stylistId)
        {
            Stylist selectedStylist = Stylist.Find(stylistId);
            return View(selectedStylist);
        }

        [HttpPost("/stylists/{stylistId}")]
        public RedirectToActionResult Create(int stylistId, string clientName)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Stylist selectedStylist = Stylist.Find(stylistId);
            Client newClient = new Client(clientName, stylistId);
            newClient.Save();
            return RedirectToAction("Show", "Stylists");
        }

        [HttpGet("/stylists/{stylistId}/clients/{clientId}")]
        public ActionResult Show(int stylistId, int clientId)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Stylist selectedStylist = Stylist.Find(stylistId);
            Client selectedClient = Client.Find(clientId);
            model.Add("stylist", selectedStylist);
            model.Add("client", selectedClient);
            return View(model);
        }
    }
}
