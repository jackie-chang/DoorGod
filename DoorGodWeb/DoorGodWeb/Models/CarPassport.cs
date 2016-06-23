using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoorGodWeb.Models
{
    public class CarPassport
    {
        [Required(ErrorMessage = "必填欄位")]
        public string SetNo { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        public DateTime? EndDate { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        public string[] EmpNoList { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        public int CarType { get; set; }
    }
}