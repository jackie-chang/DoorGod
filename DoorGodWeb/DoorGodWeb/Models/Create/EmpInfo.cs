using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DoorGodWeb.Models
{
    public class EmpInfo
    {
        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "員工姓名")]
        public string EmpCName { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "部門代碼")]
        public string DeptNo { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "到職日")]
        public string ArriveDate { get; set; }

        private string _LeaveDate;
        [Display(Name = "離職日")]
        public string LeaveDate
        {
            get
            {
                return _LeaveDate;
            }
            set
            {
                if (value == null)
                {
                    _LeaveDate = "";
                }
                else
                {
                    _LeaveDate = value;
                }
                
            }
        }

        private string _ReserverLeaveDate;
        [Display(Name = "留職停薪日")]
        public string ReserverLeaveDate
        {
            get { return _ReserverLeaveDate; }
            set
            {                
                if (value == null)
                {
                    _ReserverLeaveDate = "";
                }
                else
                {
                    _ReserverLeaveDate = value;
                }
            }
        }

        private string _EMail;
        [EmailAddress(ErrorMessage = "格式錯誤")]
        [Display(Name = "EMail")]
        public string EMail
        {
            get { return _EMail; }
            set
            {                
                if (value == null)
                {
                    _EMail = "";
                }
                else
                {
                    _EMail = value;
                }
            }
        }

        [Display(Name = "性別")]
        public string Sex { get; set; }

        [Display(Name = "員工身分")]
        public string Role { get; set; }

        [Display(Name = "進出樓層")]
        public string FloorGroups { get; set; }

        private string _ExtCompany;
        [Display(Name = "駐點廠商")]
        public string ExtCompany
        {
            get { return _ExtCompany; }
            set
            {               
                if (value == null)
                {
                    _ExtCompany = "";
                }
                else
                {
                    _ExtCompany = value;
                }
            }
        }

        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "員工編號")]
        public string EmpNo { get; set; }
    }
}