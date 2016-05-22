using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoorGodWeb.Models;
using System.Diagnostics;
using DoorGodWeb.Core;
using DoorGodWeb.Abstract;

namespace DoorGodWeb.Controllers
{
    public class CreateCardController : Controller
    {
        private ICardService cardService;
        
        public CreateCardController(ICardService cardService)
        {
            this.cardService = cardService;
        }        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            //員工身分需下拉式選單
            ViewBag.empRoleListItem = DoorGodConst.GetEmpRoleListItem();
            return View(new EmpInfo());
        }


        [HttpPost]
        public ActionResult Create(EmpInfo emp)
        {
            ViewBag.empRoleListItem = DoorGodConst.GetEmpRoleListItem();

            try
            {
                if (ModelState.IsValid)
                {
                    TempData["message"] = cardService.SetEmp(emp);
                    return View();
                }
                return View(emp);
            }
            catch (Exception ex)
            {
                //TODO WriteLog
                Debug.WriteLine(ex.Message);
                TempData["message"] = ex.Message;
                return View();
            }
            
        }             

        public ActionResult AddCard()
        {
            ViewBag.cardStateListItem = DoorGodConst.GetCardStateListItem();

            return View(new AddCardInfo());
        }
        [HttpPost]
        public ActionResult AddCard(AddCardInfo addCardInfo)
        {

            try
            {
                ViewBag.cardStateListItem = DoorGodConst.GetCardStateListItem();

                if (ModelState.IsValid)
                {
                    TempData["message"] = cardService.SetEmpCard( addCardInfo.EmpNo, addCardInfo.CardNo, addCardInfo.CardState);
                    return View();
                }
                return View(addCardInfo);
            }
            catch (Exception ex)
            {
                //TODO WriteLog
                Debug.WriteLine(ex.Message);
                TempData["message"] = ex.Message;
                return View();
            }
        }

    }
}