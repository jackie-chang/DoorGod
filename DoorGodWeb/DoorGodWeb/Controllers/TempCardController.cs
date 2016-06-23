using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoorGodWeb.Abstract;
using DoorGodWeb.Models;

namespace DoorGodWeb.Controllers
{
    public class TempCardController : Controller
    {
        private ICardService cardService;

        public TempCardController(ICardService cardService)
        {
            this.cardService = cardService;
        }

        // GET: TempCard
        public ActionResult Index()
        {
            ViewBag.CardState = DoorGodConst.GetEmpTempCardState();
            return View();
        }

        [HttpPost]
        public ViewResult Index(string empNo, string cardNo, string cardState)
        {
            ViewBag.CardState = DoorGodConst.GetEmpTempCardState();

            string result = cardService.SetEmpTempCard(empNo, cardNo, cardState);
            
            TempData["message"] = result;
            return View();

        }
               
    }
}