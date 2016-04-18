using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoorGodWeb.Controllers
{
    public class TempCardController : Controller
    {
        // GET: TempCard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        { return View();
        }
    }
}