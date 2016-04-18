using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoorGodWeb.Models;
using DoorGodWeb.Abstract;

namespace DoorGodWeb.Controllers
{
    public class CarPassportController : Controller
    {
        private ICardService cardService;

        public CarPassportController(ICardService cardService)
        {
            this.cardService = cardService;
        }

        // GET: CarPassport
        public ViewResult Add()
        {
            ViewBag.CarType = DoorGodConst.GetCarPassportType();
            return View(new CarPassport());
        }

        [HttpPost]
        public ActionResult Add(CarPassport carPassport)
        {
            if (ModelState.IsValid)
            {
                //TODO: Implement call WebService function.
                string result = cardService.AddCarPassport(carPassport);               

                TempData["message"] = result;
                return RedirectToAction("Add");
            }
            else
            {
                return View(carPassport);
            }
        }

        public ViewResult Delete()
        {
            ViewBag.CarType = DoorGodConst.GetCarPassportType();
            return View(new CarPassport());
        }

        [HttpPost]
        public ActionResult Delete(CarPassport carPassport)
        {
            string result = cardService.DeleteCarPassport(carPassport);
            TempData["message"] = result;
            return View(carPassport);
        }

        public ViewResult ClearAll()
        {
            ViewBag.CarType = DoorGodConst.GetCarPassportType();
            return View();
        }

        [HttpPost]
        public ActionResult ClearAll(string setNo, string carType)
        {
            string result = cardService.ClearAllCarPassport(setNo, carType);
            TempData["message"] = result;
            return View();
        }
    }
}