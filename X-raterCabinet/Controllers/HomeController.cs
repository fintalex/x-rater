﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;

namespace x_rater.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Default()
		{
			//ExChangeRatesController ex = new ExChangeRatesController();
			//List<ExChangeRates> ds = ex.GetRates();
			
            return View();
        }
    }
}