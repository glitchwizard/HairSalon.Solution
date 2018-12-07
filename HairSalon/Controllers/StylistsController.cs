using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections;

namespace HairSalon.Controllers
{
    public class StylistsController : Controller
    {
        [HttpGet("/stylists")]
        public ActionResult Index()
        {
            string dummyString = "";
            List<Stylist> allStylists = Stylist.GetAll();
            return View(dummyString);
        }

        [HttpGet("/stylists/new")]
        public ActionResult New()
        {
            return View();
        }
    }
}
