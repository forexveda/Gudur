﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RotaryWebsite.Controllers
{
    public class BULLETINController : Controller
    {
        public IActionResult Index()
        {
            return View("bulletin");
        }
    }
}
