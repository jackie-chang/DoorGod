using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DoorGodWeb.Models
{
    public class AddCardInfo
    {
        [Display (Name ="員工編號")]
        public string EmpNo { get; set; }
        [Display(Name = "卡號")]
        public string CardNo { get; set; }
        [Display(Name = "卡片狀態")]
        public string CardState { get; set; }
    }
}