using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HairSalon.Controllers
{
    public class ClientsController : Controller
    {

        [HttpGet("/stylists/{stylistId}/clients")]
        public ActionResult Index()
        {
            List<Stylist> allStylists = Stylist.GetAll();
            return View(allStylists);
        }

        [HttpGet("/stylists/{stylistId}/clients/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/stylists/{stylistId}/clients")]
        public ActionResult Create(string stylistName)
        {
            Stylist newStylist = new Stylist(stylistName);
            newStylist.Save();
            List<Stylist> allStylists = Stylist.GetAll();
            return View("Index", allStylists);
        }

        [HttpGet("/stylists/{stylistId}/clients/{clientId}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Stylist selectedStylist = Stylist.Find(id);
            List<Client> clientList = selectedStylist.GetClients();
            model.Add("stylist", selectedStylist);
            model.Add("clients", clientList);
            return View(model);
        }
    }
}
