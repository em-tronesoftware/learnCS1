﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeServices.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Calculations()
        {
            return View();
        }
    }
}