using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoorGodWeb.Models
{
    public class CarPassport
    {
        public string SetNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string[] EmpNoList { get; set; }
        public string CarType { get; set; }
    }
}