﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDigital.Controllers
{
    public class SistemaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Produtos()
        {
            return View();
        }
    }
}
