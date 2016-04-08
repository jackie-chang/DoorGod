using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DoorGodWeb.Models
{
    public class EmpInfo
    {

        [Required(ErrorMessage ="必填欄位")]
        [Display(Name ="員工編號")]
        
        public string EmpNo { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "員工姓名")]
        public string EmpCName { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "部門代碼")]
        public string DeptNo { get; set; }

        [Display(Name = "到職日")]
        public string ArriveDate { get; set; }

        [Display(Name = "離職日")]
        public string LeaveDate { get; set; }

        [Display(Name = "留職停薪日")]
        public string ReserverLeaveDate { get; set; }

        [EmailAddress(ErrorMessage = "格式錯誤")]
        [Display(Name = "EMail")]
        public string EMail { get; set; }

        [Display(Name ="性別")]
        public string Sex { get; set; }

        [Display(Name="員工身分")]
        public string Role { get; set; }

        [Display(Name="進出樓層")]
        public string FloorGroups { get; set; }

        [Display(Name ="駐點廠商")]
        public string ExtCompany { get; set; }

    }
}