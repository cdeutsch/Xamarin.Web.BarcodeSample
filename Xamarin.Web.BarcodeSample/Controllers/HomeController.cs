using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xamarin.Web.BarcodeSample.Models;

namespace Xamarin.Web.BarcodeSample.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var model = new PromoModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(PromoModel model)
        {
            if (ModelState.IsValid)
            {
                // TODO: save to DB, or execute other business logic.

                return View("Success", model);
            }

            return View(model);
        }

    }
}
