using BusinessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace x_rater.Controllers
{
    public class GraphicController : Controller
    {
        public ActionResult Show()
        {
            ExChangeRatesController exRatesCtrl = new ExChangeRatesController();
            List<Valute> list = exRatesCtrl.GetListValutes();

            ViewBag.ValuteList = list;

            return View();
        }

        public ActionResult Spline()
        {
            return View();
        }

        public ActionResult testts()
        {
            return View();
        }
    }
}
