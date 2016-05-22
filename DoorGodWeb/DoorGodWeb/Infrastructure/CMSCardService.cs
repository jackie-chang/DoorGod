using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoorGodWeb.Abstract;
using DoorGodWeb.Models;
using DoorGodWeb.Core;

namespace DoorGodWeb.Infrastructure
{
    public class CMSCardService : ICardService
    {
        private security02.CMSWebService service;

        public CMSCardService()
        {
            this.service = new security02.CMSWebService();
        }

        public string AddCarPassport(CarPassport carPassport)
        {
            throw new NotImplementedException();
        }

        public string ClearAllCarPassport(string setNo, string carType)
        {
            throw new NotImplementedException();
        }

        public string DeleteCarPassport(CarPassport carPassport)
        {
            throw new NotImplementedException();
        }

        public string DeleteEmp(string empNo)
        {
            throw new NotImplementedException();
        }

        public string SetDept(string deptNo, string name, string parentDeptNo)
        {
            throw new NotImplementedException();
        }

        public string SetEmp(EmpInfo emp)
        {
            string[] empInfo = Utility.ConvertToGeneralArray(10, emp);

            if (empInfo == null) throw new NullReferenceException();

            //TODO Mapping Int Result
            return service.SetEmp(DoorGodConst.GetUserName(), emp.EmpNo, empInfo).ToString();
        }

        public string SetEmpCard(string empNo, string cardNo, string cardState)
        {
            //TODO Mapping Int Result
            return service.SetEmpCard(DoorGodConst.GetUserName(), empNo, cardNo, cardState).ToString();
        }

        public string SetEmpTempCard(string empNo, string cardNo, string cardState)
        {
            return service.SetEmpTempCard(DoorGodConst.GetUserName(), empNo, cardNo, cardState).ToString();
        }

        
    }
}