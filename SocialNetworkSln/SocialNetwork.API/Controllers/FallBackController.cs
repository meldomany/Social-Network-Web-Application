﻿using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace SocialNetwork.API.Controllers
{
    public class FallBackController : Controller
    {
        public IActionResult Index()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html"), "text/HTML");
        }
    }
}
