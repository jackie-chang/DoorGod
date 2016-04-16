using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoorGodWeb.Core;
using System.Collections.Generic;
using DoorGodWeb.Models;

namespace DoorGodWebTest
{
    [TestClass]
    public class GeneralTest
    {
        [TestMethod]
        public void ConvertToGeneralArrayTest()
        {
            //empInfo[0] = emp.EmpCName;
            //empInfo[1] = emp.DeptNo;
            //empInfo[2] = emp.ArriveDate;
            //empInfo[3] = "";
            //empInfo[4] = "";
            //empInfo[5] = "";
            //empInfo[6] = emp.Sex;
            //empInfo[7] = emp.Role;
            //empInfo[8] = emp.FloorGroups;
            //empInfo[9] = "";
            EmpInfo e = new EmpInfo()
            {
                EmpCName = "no1",
                DeptNo = "tt",
                ArriveDate = "2099/01/01",
                LeaveDate = null,
                ReserverLeaveDate = null,
                EMail = null,
                Sex="F",
                Role="一般員工",
                FloorGroups="0",
                ExtCompany="",
                EmpNo ="test1"
            };

            //1.測試如果型別不是Class，回傳是否為Null

            string[] result = Utility.ConvertToGeneralArray(10, new List<int>());
            Assert.IsNull(result, "測試null");

            //2.測試正常值
            result = Utility.ConvertToGeneralArray(10, e);
            Assert.AreEqual(10, result.Length, "陣列大小是否正確");
            Assert.AreEqual(result[0], "no1", "EmpCName");
            Assert.AreEqual(result[1], "tt", "DeptNo");
            Assert.AreEqual(result[2], "2099/01/01", "ArriveDate");
            Assert.AreEqual(result[3], "", "LeaveDate");
            Assert.AreEqual(result[4], "", "ReserverLeaveDate");
            Assert.AreEqual(result[5], "", "EMail");
            Assert.AreEqual(result[6], "F", "Sex");
            Assert.AreEqual(result[7], "一般員工", "Role");
            Assert.AreEqual(result[8], "0", "FloorGroups");
            Assert.AreEqual(result[9], "", "ExtCompany");

            //3.測試別的類別
            AddCardInfo c = new AddCardInfo()
            {
                EmpNo = "test2",
                CardNo = "99999999999",
                CardState = "123"
            };

            string[] result2 = Utility.ConvertToGeneralArray(3, c);
            
            Assert.AreEqual(3, result2.Length, "陣列大小是否正確");
            Assert.AreEqual(result2[0], "test2", "EmpNo");
            Assert.AreEqual(result2[1], "99999999999", "CardNo");
            Assert.AreEqual(result2[2], "123", "CardState");

        }
    }
}
