using Microsoft.AspNetCore.Mvc;

namespace InsoftNepalWebsite.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
