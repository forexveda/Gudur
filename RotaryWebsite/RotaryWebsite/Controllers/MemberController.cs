﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RotaryWebsite.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View("Member");
        }
    }
}