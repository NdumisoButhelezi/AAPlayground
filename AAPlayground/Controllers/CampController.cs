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
        public ActionResult DisplayCampFees()
        {
            return View(new CampFeesModel());
        }

        [HttpPost]
        public ActionResult DisplayCampFees(CampFeesModel model)
        {
            model.TotalDue = model.calcTotalDue();
            return View(model);
        }
    }
}