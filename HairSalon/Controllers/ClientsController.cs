using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HairSalon.Controllers
{
    public class ClientsController : Controller
    {
        public void Dispose()
        {
            Stylist.ClearAll();
            Client.ClearAll();
        }

        public StylistTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=3306;database=charley_mcgowan_test;";
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}