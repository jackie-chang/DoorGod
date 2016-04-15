using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorGodWeb.Models;

namespace DoorGodWeb.Abstract
{
    public interface ICardService
    {
        string SetDept(string deptNo, string name, string parentDeptNo);
        string SetEmp(EmpInfo emp);
        string DeleteEmp(string empNo);
        string SetEmpCard(string empNo, string cardNo, string cardState);
        string AddCarPassport(CarPassport carPassport);
        string DeleteCarPassport(CarPassport carPassport);
        string ClearAllCarPassport(string setNo, string carType);
        string SetEmpTempCard(string empNo, string cardNo, string cardState);
    }
}
