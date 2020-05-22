using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADAM.Models;

namespace ADAM.Controllers
{
    public class HomeController : BaseController
    {
        adamMod adamObj = new adamMod();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public JsonResult get_daily_data(string areaID, string shiftID)
        {
            List<IDictionary<string, string>> results = new List<IDictionary<string, string>>();

            results = adamObj.get_daily_data(areaID, shiftID);

            return Json(results);
        }

    }
}
