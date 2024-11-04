using Microsoft.AspNetCore.Mvc;

namespace InsoftNepalWebsite.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
