﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JuCheap.Core.Web.Controllers
{
    public class RealTimeAnaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RealTimeData()
        {
            return View();
        }
    }
}