﻿using Microsoft.AspNetCore.Mvc;

namespace InsoftNepalWebsite.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
