using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoorGodWeb.Abstract;
using DoorGodWeb.Models;

namespace DoorGodWeb.Infrastructure
{
    public class CMSCardService : ICardService
    {
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
            throw new NotImplementedException();
        }

        public string SetEmpCard(string empNo, string cardNo, string cardState)
        {
            throw new NotImplementedException();
        }

        public string SetEmpTempCard(string empNo, string cardNo, string cardState)
        {
            throw new NotImplementedException();
        }
    }
}