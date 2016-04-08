using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoorGodWeb.Models;
using System.Diagnostics;

namespace DoorGodWeb.Controllers
{
    public class HomeController : Controller
    {
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
            //step 1 轉換成陣列
            try
            {

                //CMSWebService.ArrayOfString empInfo = new CMSWebService.ArrayOfString();
                string[] empInfo = new string[10];
                empInfo[0]=emp.EmpCName;
                empInfo[1]=emp.DeptNo;
                empInfo[2]=emp.ArriveDate;
                empInfo[3]="";
                empInfo[4]="";
                empInfo[5]="";
                empInfo[6]=emp.Sex;
                empInfo[7]=emp.Role;
                empInfo[8]=emp.FloorGroups;
                empInfo[9]="";



                //CMSWebService.SetEmpRequest setEmpReq = new CMSWebService.SetEmpRequest();
                //setEmpReq.Body = new CMSWebService.SetEmpRequestBody();

                //setEmpReq.Body.UserName = "CC_Dev";
                //setEmpReq.Body.EmpNo = emp.EmpNo;
                //setEmpReq.Body.EmpInfo = empInfo;

                //CMSWebService.SetEmpResponse res = ser.SetEmp(setEmpReq);

                //int result = res.Body.SetEmpResult;


                security02.CMSWebService d = new security02.CMSWebService();
                int result = d.SetEmp(DoorGodConst.GetUserName(), emp.EmpNo, empInfo);

                //int result2 = d.DeleteEmp("CC_Dev", emp.EmpNo);


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            

            return View();
        }

        public ActionResult AddCard()
        {
            ViewBag.cardStateListItem = DoorGodConst.GetCardStateListItem();
            
            return View(new AddCardInfo());
        }
        [HttpPost]
        public ActionResult AddCard(AddCardInfo addCardInfo )
        {
            security02.CMSWebService d = new security02.CMSWebService();
            int result = d.SetEmpCard(DoorGodConst.GetUserName(), addCardInfo.EmpNo, addCardInfo.CardNo, addCardInfo.CardState);
            return Content(result.ToString());
        }
        
    }
}