using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectService()
        {
            return View();
        }

        public ActionResult BookingForm(string serviceType)
        {
            ViewBag.ServiceType = serviceType;
            return View();
        }

        public ActionResult BookingConfirmed()
        {
            return View();
        }

        public ActionResult RideHistory()
        {
            return View();
        }

        public ActionResult DriverVehicleManagement()
        {
            return View();
        }



    }
}