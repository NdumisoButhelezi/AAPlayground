using AAPlayground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AAPlayground.Controllers
{
    public class CampController : Controller
    {
        // GET: CampFees
        public ActionResult Index()
        {
            return View(new CampFeesModel());
        }

        [HttpPost]
        public ActionResult Result(CampFeesModel model)
        {
            if (ModelState.IsValid)
            {
                model.TotalDue = model.calcTotalDue();
                return View("Result", model);
            }
            return View("Index", model);
        }
    }
}